using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO;
using System.Threading;
namespace FreeFall_GUI
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        uint EncoderResolution; //pulse
        float DrumRadius; // m
        float TimeStep = 0;
        uint TimerPeriod;        

        public delegate void SendCommand(string Message); // Function to send a message to STM32
        public SendCommand _SendCommand; //
        private void Setting_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            FormInitilization();
        }
        public void FormInitilization()
        {
            GraphInit();
            proSending.Visible = false;
            gbParam.Enabled = true;                      
        }

        private void GraphInit()
        {
            //GraphPane myPane = TempGraph.GraphPane;

            TempGraph.GraphPane.Title.Text = "Data";
            TempGraph.GraphPane.XAxis.Title.Text = "time (s)";
            TempGraph.GraphPane.YAxis.Title.Text = "Position (m)";
            TempGraph.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            TempGraph.GraphPane.YAxis.Title.FontSpec.FontColor = Color.Red;

            TempGraph.GraphPane.XAxis.Scale.Min = 0;
            TempGraph.GraphPane.XAxis.Scale.Max = 2;
            TempGraph.GraphPane.XAxis.Scale.MinorStep = 1;
            TempGraph.GraphPane.XAxis.Scale.MajorStep = 2;
            TempGraph.GraphPane.YAxis.Scale.Min = -10;
            TempGraph.GraphPane.YAxis.Scale.Max = 10;


            TempGraph.GraphPane.Y2Axis.Title.Text = "Motor Speed (Rpm)";
            TempGraph.GraphPane.Y2Axis.Scale.Min = 0;
            TempGraph.GraphPane.Y2Axis.Scale.Max = 255;
            TempGraph.GraphPane.Y2Axis.Scale.MinorStep = 50;
            TempGraph.GraphPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            TempGraph.GraphPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
            TempGraph.GraphPane.Y2Axis.IsVisible = true;

            TempGraph.GraphPane.IsAlignGrids = true;

            RollingPointPairList TempList = new RollingPointPairList(60000);
            LineItem TempCurve = TempGraph.GraphPane.AddCurve("Position", TempList, Color.Red, SymbolType.None);
            TempCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList RefSpeedList = new RollingPointPairList(60000);
            LineItem RefSpeedCurve = TempGraph.GraphPane.AddCurve("Speed", RefSpeedList, Color.Blue, SymbolType.None);
            RefSpeedCurve.Line.Width = (float)3; // Set LineWidth            

            RefSpeedCurve.IsY2Axis = true;

            TempGraph.GraphPane.AxisChange();
            TempGraph.Invalidate();
        }


        bool ViewMode = true;

        private void DrawData(double timeStep, float RefPostion, float RefSpeed)
        {
            if (TempGraph.GraphPane.CurveList.Count <= 0) // neu ko co duong du lieu dc khoi tao
            {
                return; // Thoat ham
            }

            LineItem TempCurve = TempGraph.GraphPane.CurveList[0] as LineItem;
            if (TempCurve == null) return;
            IPointListEdit TempList = TempCurve.Points as IPointListEdit;
            if (TempList == null) return;
            TempList.Add(timeStep, RefPostion);

            LineItem RefSpeedCurve = TempGraph.GraphPane.CurveList[1] as LineItem;
            if (RefSpeedCurve == null) return;
            IPointListEdit RefSpeedList = RefSpeedCurve.Points as IPointListEdit;
            if (RefSpeedList == null) return;
            RefSpeedList.Add(timeStep, RefSpeed);

            Scale xScale = TempGraph.GraphPane.XAxis.Scale;
            if (timeStep > xScale.Max - xScale.MajorStep)
            {
                if (ViewMode) // SCROLL view Mode
                {
                    xScale.Max = timeStep + 2 * xScale.MajorStep;
                    xScale.Min = timeStep - 2 * xScale.MajorStep;
                }
                else // COMPACR view Mode
                {
                    xScale.Max = timeStep + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            Scale Y1Scale = TempGraph.GraphPane.YAxis.Scale;
            Scale Y2Scale = TempGraph.GraphPane.Y2Axis.Scale;
            TempGraph.GraphPane.IsAlignGrids = true;
            if (RefPostion > Y1Scale.Max) // Auto scale the Speed axis
            {
                Y1Scale.Max = RefPostion + 2 * Y1Scale.MajorStep;
            }
            if (RefPostion < Y1Scale.Min) // Auto scale the Speed axis
            {
                Y1Scale.Min = RefPostion - 2 * Y1Scale.MajorStep;
            }

            if (RefSpeed > Y2Scale.Max)
            {
                Y2Scale.Max = RefSpeed + 2 * Y2Scale.MajorStep;
            }
            if (RefSpeed < Y2Scale.Min)
            {
                Y2Scale.Min = RefSpeed - 2 * Y2Scale.MajorStep;
            }
            TempGraph.GraphPane.IsAlignGrids = true;
            TempGraph.AxisChange();
            TempGraph.Invalidate();
        }

        private void ResetGraph()
        {
            TimeStep = 0;            

            TempGraph.GraphPane.CurveList.Clear();
            // Re-init the curve
            GraphInit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }
        uint ExperimentMode;
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                 DrumRadius = float.Parse(txtDrumRadius.Text);
                 EncoderResolution = uint.Parse(lbEncoderResolution.Text);
                
            }
            catch
            {
                MessageBox.Show("Please Load Params");
                return;
            }
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filePath);
                //Read the first line of text
                string line = sr.ReadLine();
                string[] datafield = line.Split('$');

                try // Check Experiment Mode
                {
                    ExperimentMode = uint.Parse(datafield[0]);
                    if ((ExperimentMode != 1) && (ExperimentMode != 2) && (ExperimentMode != 3))
                    {
                        MessageBox.Show("Experiment Mode is not Determined! Loading Failed");
                        return;
                    }
                    else
                    {
                        switch (ExperimentMode)
                        {
                            case 1:
                                lbExperimentMode.Text = "Dropping";
                                break;
                            case 2:
                                lbExperimentMode.Text = "Pulling";
                                break;
                            case 3:
                                lbExperimentMode.Text = "Pull and Drop";
                                break;
                            default:
                                break;
                        }
                    }
                }
                catch 
                {
                    MessageBox.Show("Invalid Experiment Mode");
                    return;
                }

                // Check Sample Time
                try
                {
                    uint _SampleTime = uint.Parse(datafield[1]);
                    if (_SampleTime.ToString() != txtSampleTime.Text)
                    {
                        MessageBox.Show("Sample Time is different! Loading failed");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Sample Time");
                    return;
                }

                // Start Reading Data
                line = sr.ReadLine();
                
                int TimeStep = 0;
                float PrePosition = 0;
                uint TimerCount = 0;
                int DeltaPulse = 0;
                int TotalPullingPulse = 0;
                int TotalDroppingPulse = 0;
                //Continue to read until you reach end of file
                while (line != null)
                {
                    datafield = line.Split('/');
                    try
                    {

                        // Add to listview
                        ListViewItem item = new ListViewItem(TimeStep.ToString());
                        item.SubItems.Add(datafield[0]);
                        item.SubItems.Add(datafield[1]);

                        float CurrentPosition = float.Parse(datafield[0]);

                        float Speed = float.Parse(datafield[1]);

                        if (CurrentPosition - PrePosition > 0)
                        {
                            DeltaPulse = (int)(0.5 + (CurrentPosition - PrePosition) * EncoderResolution / (2 * Math.PI * DrumRadius));
                            TotalDroppingPulse += DeltaPulse;
                        }
                        if (CurrentPosition - PrePosition < 0)
                        {
                            DeltaPulse = (int)(-0.5 + (CurrentPosition - PrePosition) * EncoderResolution / (2 * Math.PI * DrumRadius));
                            TotalPullingPulse += DeltaPulse;
                        }
                        if (CurrentPosition - PrePosition == 0)
                        {
                            DeltaPulse = 0;
                        }

                        item.SubItems.Add(DeltaPulse.ToString());
                        item.SubItems.Add(TimerCount.ToString());

                        listData.Items.Add(item); // Gán biến datas vào cột tiếp theo của ListView
                        listData.Items[listData.Items.Count - 1].EnsureVisible(); //

                        TimeStep++;
                        PrePosition = CurrentPosition;
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Data");
                        return;
                    }
                    line = sr.ReadLine();
                }
                lbTotalPullingPulse.Text = Math.Abs(TotalPullingPulse).ToString();
                lbPullingDist.Text = Math.Round(Math.Abs(TotalPullingPulse * 2 * Math.PI * DrumRadius / EncoderResolution),2).ToString();
                lbDroppingDist.Text = Math.Round(Math.Abs(TotalDroppingPulse * 2 * Math.PI * DrumRadius / EncoderResolution), 2).ToString();
            }
        }

        private void btnClearListData_Click(object sender, EventArgs e)
        {
            listData.Items.Clear();
        }

        private void btnPlotData_Click(object sender, EventArgs e)
        {
            if (listData.Items.Count == 0)
            {
                return;
            }
            double time;
            float RefPosition;
            float RefSpeed;

            ResetGraph();

            for (int i = 0; i < listData.Items.Count; i++)
            {
                try
                {
                    time = double.Parse(listData.Items[i].SubItems[0].Text) * 0.005;
                    RefPosition = float.Parse(listData.Items[i].SubItems[1].Text);
                    float DrumRadius = float.Parse(txtDrumRadius.Text);
                    RefSpeed = float.Parse(listData.Items[i].SubItems[2].Text) * 60 / (DrumRadius * 2 * (float)3.14);
                }
                catch
                {
                    MessageBox.Show("Invalid Data");
                    return;
                }
                DrawData(time, RefPosition, RefSpeed);
            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            if (listData.Items.Count == 0)
            {
                MessageBox.Show("There is no data");
                return;
            }

            proSending.Maximum = listData.Items.Count;
            proSending.Visible = true;

            // Send Experiment Mode
            if ((ExperimentMode != 1) && (ExperimentMode != 2) && (ExperimentMode != 3))
            {
                MessageBox.Show("Experiment Mode is not Determined!");
                return;
            }
            else
            {
                _SendCommand("10/" + ExperimentMode.ToString());
                Thread.Sleep(5);
            }

            // Send Pulling Bottom Pulse
            if ((ExperimentMode == 2) || (ExperimentMode == 3))
            {
                try
                {
                    uint _PullingPulse = uint.Parse(lbTotalPullingPulse.Text);
                    _SendCommand("9/" + _PullingPulse.ToString());
                    Thread.Sleep(5);
                }
                catch 
                {
                    MessageBox.Show("Invalid Total Pulling Pulse!");
                    return;
                }
            }

            for (int i = 0; i < listData.Items.Count; i++)
            {
                try
                {
                    string DataToSend = "2/" + listData.Items[i].SubItems[0].Text + "/" + listData.Items[i].SubItems[3].Text + "/" + listData.Items[i].SubItems[4].Text;
                    _SendCommand(DataToSend);
                    Thread.Sleep(5);
                    proSending.Value++;
                    proSending.Update();
                }
                catch
                {
                    //MessageBox.Show("Data is invalid, Please try again");
                    proSending.Value = 0;
                    proSending.Visible = false;
                    return;
                }
            }
            proSending.Value = 0;
            proSending.Visible = false;
        }

        private void btnLoadParam_Click(object sender, EventArgs e)
        {
            _SendCommand("45"); // Load Param
        }
        public void CheckParam (uint Code, float Param)
        {
            switch (Code)
            {
                case 11: // Set Drum Radius
                    if (Param.ToString() == txtDrumRadius.Text)
                    {
                        MessageBox.Show("Setting Drum Radius is Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Drum Radius is Failed");
                    }
                    break;
                case 16: // Set Sample Time
                    if (Param.ToString() == txtSampleTime.Text)
                    {
                        MessageBox.Show("Setting SamplTime is Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting SamplTime is Failed");
                    }
                    break;
                case 37: // Set Stopping Time
                    if (Param.ToString() == txtStoppingTime.Text)
                    {
                        MessageBox.Show("Setting Stopping Time is Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Stopping Time is Failed");
                    }
                    break;
                case 13: // Set Going Speed
                    if (Param.ToString() == txtGoingSpeed.Text)
                    {
                        MessageBox.Show("Setting Going Speed is Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Going Speed is Failed");
                    }
                    break;
                default:
                    break;
            }
        }
        public void LoadParams (float _DrumRadius, uint _SampleTime, uint _GoingSpeed, uint EncoderResol, uint _StoppingTime)
        {
            txtDrumRadius.Text = _DrumRadius.ToString();
            txtSampleTime.Text = _SampleTime.ToString();
            txtGoingSpeed.Text = _GoingSpeed.ToString();
            txtStoppingTime.Text = _StoppingTime.ToString();
            lbEncoderResolution.Text = EncoderResol.ToString();
        }

        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraph();
        }

        private void btnSetDrumRadius_Click(object sender, EventArgs e)
        {
            float _DrumRadius;
            if (float.TryParse(txtDrumRadius.Text, out _DrumRadius))
            {
                _SendCommand("11/" + _DrumRadius.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnSetSampleTime_Click(object sender, EventArgs e)
        {
            uint _SampleTime;
            if (uint.TryParse(txtSampleTime.Text, out _SampleTime))
            {
                _SendCommand("16/" + _SampleTime.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnSetGoingSpeed_Click(object sender, EventArgs e)
        {
            uint _GoingSpeed;
            if (uint.TryParse(txtGoingSpeed.Text, out _GoingSpeed))
            {
                _SendCommand("13/" + _GoingSpeed.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnSetStoppingTime_Click(object sender, EventArgs e)
        {
            uint _StoppingTime;
            if (uint.TryParse(txtStoppingTime.Text, out _StoppingTime))
            {
                _SendCommand("37/" + _StoppingTime.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}

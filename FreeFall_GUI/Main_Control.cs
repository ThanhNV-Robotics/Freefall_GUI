using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ZedGraph;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace FreeFall_GUI
{
    public partial class Main_Control : Form
    {
        //# is the charater indicating the ending of the frame
        // '/' is the spliting character: function code/value
        private const string STOP = "1/1";
        private const string ESTOP = "0/0";
        private const string AlarmReset = "0/1";
        private const string PositionMode = "2/0";
        private const string SpeedMode = "2/1";
        private const string JogUp = "3/1";
        private const string JogDown = "3/0";
        private const string StartRunning = "4/1";
        private const string StopRunning = "4/0";

        private bool TYPEOUT;
        private bool BRAKE;
        private bool RDY;
        private bool CmdReach;
        private bool TorqueLimit;
        private bool Alarm;
        private bool CcwTorqueLimit;
        private bool CwTorqueLimit;
        private bool ZeroSpeedReach;
        private bool ExternalBrake;

        private int TotalEpisodes;
        private int CurrentEpisode;
        private bool StartWaitingFlag = false; // Flag to wait for running next episode
        private uint WaitingCount; // To count the timer for waiting
        private uint CountBeforeRunning;
        private bool WaitingBeforeRunning = false;

        private volatile int timercount; // to measure the timer counter

        private int SampleTime = 50;

        double time;

        double TickStart;
        
        bool ViewMode = false;
        bool GraphOn = false;
        bool SpeedView = false;
        bool SpdCmdView = false;
        bool AccXView = false;
        bool AccYView = false;
        bool AccZView = false;

        float MotorSpeed; // Motor speed
        float SpdCommand; // Speed Command
        float AccelerationX; // acclerometerX
        float AccelerationY;
        float AccelerationZ;
        uint DriverOutput;

        private GraphPane MyPane = new GraphPane();
        private bool IsRunning = false;

        // TCP communication variable
        private TcpClient client;
        private StreamReader STR;
        TcpListener listener;
        NetworkStream ns;
        string IpAddress;
        int Port;
        string ServerReceivedMessage;
        public delegate void _SendCommand(string command);
        public _SendCommand SendCommand;
        public delegate void _SendAccZ(float AccZ);
        public _SendAccZ SendAccZ;
        public Main_Control()
        {
            InitializeComponent();
        }

        // User function
        public void ProcessMessage(string ReceivedMessage) // Process data received from STM32
        {
            if (ReceivedMessage[0] == '<')
            {
                COM_Testing.instance._lbReceivedMessage.Text = ReceivedMessage;
                COM_Testing.instance.txtReceivedData.Text = ReceivedMessage;
                Console.WriteLine(ReceivedMessage); // Print the message to the Console Window
            }
            if (ReceivedMessage[0] == 's') // s means data from the driver
            {
                ReceivedMessage = (ReceivedMessage.Replace("s", null)).Replace("e", null); // remove the character s in the string
                // After remove 's' and 'e': functioncode/data1/data2
                string[] ExtractReceivedMessage = ReceivedMessage.Split('/');

                if (ExtractReceivedMessage[0] == "1") // Only the driver outputs
                {
                    if (uint.TryParse(ExtractReceivedMessage[1], out DriverOutput)) // Neu du lieu truyen len la speed
                    {
                        ShowDriverOutput(DriverOutput);
                    }
                }
                if (ExtractReceivedMessage[0] == "2") // Only the speed data
                {
                    try
                    {
                        MotorSpeed = float.Parse(ExtractReceivedMessage[1]);
                        SpdCommand = float.Parse(ExtractReceivedMessage[2]);
                        lbMotorSpeed.Text = ExtractReceivedMessage[1];
                    }
                    catch { }                  
                }
                if (ExtractReceivedMessage[0] == "3") // both Driver output and speed data
                {
                    try
                    {
                        //Console.WriteLine(ExtractReceivedMessage[1].ToString());
                        MotorSpeed = float.Parse(ExtractReceivedMessage[1]);
                        SpdCommand = float.Parse(ExtractReceivedMessage[2]); // Speed command
                        DriverOutput = uint.Parse(ExtractReceivedMessage[3]);
                        //ShowDriverOutput(DriverOutput);
                        lbMotorSpeed.Text = ExtractReceivedMessage[1];
                    }
                    catch { }
                }
            }
            // An episode is completed
            if (ReceivedMessage[0] == '$') // $ means stm32 completes an episode
            {
                if (btnStart.Text == "STOP") // if the system is running
                {
                    ShowCurrentEpisodeLabel(CurrentEpisode + 1, TotalEpisodes);
                    CurrentEpisode++;
                    //progressBar.Value = CurrentEpisode;
                    SaveToExcel(CurrentEpisode); // Save data for the current episode
                    ResetGraph(); // Reset the graph
                    TurnOnGraph(); // Turn on the graph
                    progressBar.PerformStep(); // visual the progress
                    StartWaitingFlag = true;

                    if (CurrentEpisode >= TotalEpisodes) // Complete all the episodes
                    {
                        CurrentEpisode = 0;
                        ShowCurrentEpisodeLabel(CurrentEpisode, TotalEpisodes);
                        btnStart.Text = "START";
                        btnStart.BackColor = Color.Lime;
                        StartWaitingFlag = false; // reset flag
                        WaitingCount = 0; // reset timer count

                        TurnOffGraph(); // Turn off the graph
                        ProgressBarInit();
                        MessageBox.Show("Running completed");
                        progressBar.Visible = false;                        
                    }
                }
            }
        }
        public void SetSampleTime (int _SampleTime)
        {
            SampleTime = _SampleTime;
            timer1.Interval = SampleTime;
        }
        private void ShowDriverOutput (uint DriverOutput) // Visual the driver's output
        {
            if (cbReadOutputs.Checked == true)
            {
                TYPEOUT = GetBit(DriverOutput, 0);
                BRAKE = GetBit(DriverOutput, 1);
                RDY = GetBit(DriverOutput, 2);
                CmdReach = GetBit(DriverOutput, 3);
                TorqueLimit = GetBit(DriverOutput, 4);
                Alarm = GetBit(DriverOutput, 5);
                CcwTorqueLimit = GetBit(DriverOutput, 6);
                CwTorqueLimit = GetBit(DriverOutput, 7);
                ZeroSpeedReach = GetBit(DriverOutput, 8);

                if (!TYPEOUT) { lb_Type.BackColor = Color.Lime; }
                else { lb_Type.BackColor = Color.Gray; }

                if (!BRAKE) { lbBrake.BackColor = Color.Gray; }
                else { lbBrake.BackColor = Color.Red; }

                if (!RDY) { lbReady.BackColor = Color.Lime; }
                else { lbReady.BackColor = Color.Gray; }

                if (!CmdReach) { lbSpeedReach.BackColor = Color.Lime; }
                else { lbSpeedReach.BackColor = Color.Gray; }

                if (!TorqueLimit) { lbTorqueLimit.BackColor = Color.Lime; }
                else { lbTorqueLimit.BackColor = Color.Gray; }

                if (!Alarm) { lbAlarm.BackColor = Color.Gray; }
                else { lbAlarm.BackColor = Color.Yellow; }

                if (!CcwTorqueLimit) { lbCcwTorqueLimit.BackColor = Color.Lime; }
                else { lbCcwTorqueLimit.BackColor = Color.Gray; }

                if (!CwTorqueLimit) { lbCwTorqueLimit.BackColor = Color.Lime; }
                else { lbCwTorqueLimit.BackColor = Color.Gray; }

                if (!ZeroSpeedReach) { lbZeroSpeedReach.BackColor = Color.Lime; }
                else { lbZeroSpeedReach.BackColor = Color.Gray; }
            }
        }
        public bool GetBit(uint b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("> Stop");
            SendCommand(STOP + "$");
        }

        private void btnResetAlarm_Click(object sender, EventArgs e)
        {
            Console.WriteLine("> Alarm Reset");
            SendCommand(AlarmReset + "$");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
            if (IsRunning) // if is not running > Start running
            {
                btnStart.BackColor = Color.Orange;
                btnStart.Text = "STOP";
                
                progressBar.Visible = true;
                TurnOnGraph(); // Turn on the graph
                WaitingBeforeRunning = true;
            }
            else // If it is running > Stop running
            {
                btnStart.BackColor = Color.Lime;
                btnStart.Text = "START";               
                SendCommand(StopRunning + "$");
                ResetGraph();
                ProgressBarInit();
            }
            Console.WriteLine("> Start Running");
        }

        private void btnEstop_Click(object sender, EventArgs e)
        {
            SendCommand(ESTOP + "$");
            Console.WriteLine("> Emergency Stop");
        }

        private void rdPositionMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPositionMode.Checked) // If Position mode is selected
            {
                Console.WriteLine("> Position Mode");
                SendCommand(PositionMode + "$");
            }
            else
            {
                Console.WriteLine("> Speed Mode");
                SendCommand(SpeedMode + "$");
            }
        }

        private void btnMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Jog Move Up");
            SendCommand(JogUp + "$");
        }

        private void btnMoveUp_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Stop");
            SendCommand(STOP + "$");
        }

        private void btnMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Jog Move Down");
            SendCommand(JogDown + "$");
        }

        private void btnMoveDown_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Stop");
            SendCommand(STOP + "$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RegisterAddress = 401; //  P4-02, Speed Command
            float value;
            try
            {
                value = float.Parse(txtSetSpeed.Text);
                string Command = "5" + "/" + "1" + "/" + RegisterAddress.ToString() + "/" + value.ToString() + "$";                
                SendCommand(Command);
                Console.WriteLine("> Set Speed: " + Command);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input data type");
            }
        }
        private void GraphInit()
        {
            GraphPane myPane = SpeedGraph.GraphPane;
            myPane.Title.Text = "Data";
            myPane.XAxis.Title.Text = "time (s)";
            myPane.YAxis.Title.Text = "Speed (rpm)";
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 10;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;

            RollingPointPairList MotorSpeedList = new RollingPointPairList(60000);
            LineItem MotorSpeedCurve = myPane.AddCurve("Motor Speed", MotorSpeedList, Color.Red, SymbolType.None);
            MotorSpeedCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList SpdCmdList = new RollingPointPairList(60000); // speed command curve
            LineItem SpdCmdCurve = myPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
            SpdCmdCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList AccelerationListX = new RollingPointPairList(60000);
            LineItem AccelerationCurveX = myPane.AddCurve("AccelerationX", AccelerationListX, Color.Blue, SymbolType.None);

            RollingPointPairList AccelerationListY = new RollingPointPairList(60000);
            LineItem AccelerationCurveY = myPane.AddCurve("AccelerationY", AccelerationListY, Color.Green, SymbolType.None);
            
            RollingPointPairList AccelerationListZ = new RollingPointPairList(60000);
            LineItem AccelerationCurveZ = myPane.AddCurve("AccelerationZ", AccelerationListZ, Color.Black, SymbolType.None);
            
            AccelerationCurveX.Line.Width = (float)2; // Set LineWidth
            AccelerationCurveY.Line.Width = (float)2; // Set LineWidth
            AccelerationCurveZ.Line.Width = (float)3; // Set LineWidth

            myPane.Y2Axis.IsVisible = true;

            myPane.Y2Axis.Title.Text = "Acceleration, m/s2";
            myPane.Y2Axis.Scale.Min = -11;
            myPane.Y2Axis.Scale.Max = 11;
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;

            myPane.AxisChange();
        }
        private void ProgressBarInit()
        {
            progressBar.Visible = false; // hide the progress bar
            progressBar.Minimum = 0;
            progressBar.Step = 1;
            progressBar.Value = 1;
        }
        void ShowCurrentEpisodeLabel(int currenteps, int totaleps)
        {
            lbCurrentEpisode.Text = currenteps.ToString() + "/" + totaleps.ToString();
        }
        private void Main_Control_Load(object sender, EventArgs e)
        {
            GraphInit();
            ProgressBarInit();
            DisableJogControl();
            TickStart = Environment.TickCount;

            timer1.Interval = SampleTime; //ms
            timer1.Enabled = false;
            ShowCurrentEpisodeLabel(CurrentEpisode,TotalEpisodes);
            //Initial output states color
            lbAlarm.BackColor = Color.Gray;
            lbBrake.BackColor = Color.Gray;
            lbCcwTorqueLimit.BackColor = Color.Gray;
            lbCwTorqueLimit.BackColor = Color.Gray;
            lbReady.BackColor = Color.Gray;
            lbSpeedReach.BackColor = Color.Gray;
            lbTorqueLimit.BackColor = Color.Gray;

            cbReadOutputs.CheckState = CheckState.Checked;
            // Data checkbox
            cbAccX.CheckState = CheckState.Unchecked;
            cbAccY.CheckState = CheckState.Unchecked;
            cbAccZ.CheckState = CheckState.Unchecked;
            cbSpeed.CheckState = CheckState.Unchecked;
            cbSpdCmd.CheckState = CheckState.Unchecked;

            // Initialize TCP server parameters
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); // Get computers' IP address
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpAddress = address.ToString();
                    lbIP.Text = address.ToString();
                }
            }
            Port = 8000; // Default value
            lbPort.Text = Port.ToString();
            //cbServerOn.CheckState = CheckState.Checked; // Turn on the server as default         
        }
        private void cbServerOn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServerOn.CheckState == CheckState.Checked)
            {
                ServerOn();
            }
            else
            {
                ServerOff();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    byte[] msg = new byte[1024];     //the messages arrive as byte array
                    ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client

                    ServerReceivedMessage = Encoding.Default.GetString(msg); // convert to string
                    if (ServerReceivedMessage != null)
                    {
                        this.lbAccel.Invoke(new MethodInvoker(delegate ()
                        {
                            ServerReceivedMessage = ServerReceivedMessage.Replace("a", null).Replace("e", null);
                            string[] ExtractAccelData = ServerReceivedMessage.Split('/'); // split data frame
                            try
                            {
                               AccelerationX = float.Parse(ExtractAccelData[0]); // get acceleration value
                               AccelerationY = float.Parse(ExtractAccelData[1]); // get acceleration value
                               AccelerationZ = float.Parse(ExtractAccelData[2]); // get acceleration value
                               SendAccZ(AccelerationZ); // Send to STM32
                            }
                            catch{ }                            
                            ServerReceivedMessage = "";
                        }));
                    }
                }
                catch
                {
                    //MessageBox.Show(x.Message.ToString());
                }
            }
        }
        private void ServerOn()
        {
            listener = new TcpListener(IPAddress.Any, int.Parse(lbPort.Text));
            try
            {
                listener.Start(); // Start listening for incoming connection request
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            try
            {
                client = listener.AcceptTcpClient();
                ns = client.GetStream(); // network stream
                STR = new StreamReader(client.GetStream());
                backgroundWorker1.RunWorkerAsync(); //Start receiving data in background
                backgroundWorker1.WorkerSupportsCancellation = true; // ability to cancel
            }
            catch (SocketException x)
            {
                if ((x.SocketErrorCode == SocketError.Interrupted))
                    return;
            }
            listener.Stop();

        }
        private void ServerOff()
        {
            try
            {
                backgroundWorker1.CancelAsync();
                client.Close();
                listener.Stop();
            }
            catch { }       
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                SaveToExcel(0); // Thực thi hàm lưu ListView sang Excel
            }
        }
        private void SaveToExcel(int index)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            // Đặt tên cho hai ô A1. B1 lần lượt là "Thời gian (s)" và "Dữ liệu", sau đó tự động dãn độ rộng
            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ws.get_Range("A1", "B1");
            ws.Cells[1, 1] = "time (s)";
            ws.Cells[1, 2] = "Speed (rpm)";
            ws.Cells[1, 3] = "AccX (m/s^2)";
            ws.Cells[1, 4] = "AccY (m/s^2)";
            ws.Cells[1, 5] = "AccZ (m/s^2)";
            rg.Columns.AutoFit();

            // Lưu từ ô đầu tiên của dòng thứ 2, tức ô A2
            int i = 2; // Row index
            int j = 1; // Column index

            foreach (ListViewItem comp in listData.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
            string DataPath = @"C:\Users\thanh\OneDrive\문서\Liintech\Data\Episode" + index.ToString() + ".xlsx";
            try
            {
                wb.SaveAs(DataPath);
                wb.Close();
            }
            catch
            {   }
            
        }
        private void Data_Listview()
        {
            if (!GraphOn)
                return;
            else
            {
                ListViewItem item = new ListViewItem(time.ToString()); // Gán biến realtime vào cột đầu tiên của ListView
                item.SubItems.Add(MotorSpeed.ToString());
                item.SubItems.Add(AccelerationX.ToString());
                item.SubItems.Add(AccelerationY.ToString());
                item.SubItems.Add(AccelerationZ.ToString());

                listData.Items.Add(item); // Gán biến datas vào cột tiếp theo của ListView
                                           // Không nên gán string SDatas vì khi xuất dữ liệu sang Excel sẽ là dạng string, không thực hiện các phép toán được

                listData.Items[listData.Items.Count - 1].EnsureVisible(); // Hiện thị dòng được gán gần nhất ở ListView, tức là mình cuộn ListView theo dữ liệu gần nhất đó
            }
        }
        private void Draw(double time, double speed, double spdcmd, double accelerationX, double accelerationY, double accelerationZ)
        {
            if (SpeedGraph.GraphPane.CurveList.Count <= 0) // neu ko co duong du lieu dc khoi tao
            {
                return; // Thoat ham
            }

            if (SpeedView)
            {
                LineItem SpeedCurve = SpeedGraph.GraphPane.CurveList[0] as LineItem;
                if (SpeedCurve == null) return;
                IPointListEdit SpeedList = SpeedCurve.Points as IPointListEdit;
                if (SpeedList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                SpeedList.Add(time, speed);
            }

            if (SpdCmdView)
            {
                LineItem SpdCmdCurve = SpeedGraph.GraphPane.CurveList[1] as LineItem;                
                if (SpdCmdCurve == null) return;
                IPointListEdit SpdCmdList = SpdCmdCurve.Points as IPointListEdit;
                if (SpdCmdList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                SpdCmdList.Add(time, spdcmd);
            }

            if (AccXView)
            {
                LineItem AccelerationCurveX = SpeedGraph.GraphPane.CurveList[2] as LineItem;
                AccelerationCurveX.IsY2Axis = true; // associate the acceleration curve with y2 axis
                if (AccelerationCurveX == null) return;
                IPointListEdit AccelerationListX = AccelerationCurveX.Points as IPointListEdit;
                if (AccelerationListX == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccelerationListX.Add(time, accelerationX);
            }

            if (AccYView)
            {
                LineItem AccelerationCurveY = SpeedGraph.GraphPane.CurveList[3] as LineItem;
                AccelerationCurveY.IsY2Axis = true; // associate the acceleration curve with y2 axis
                if (AccelerationCurveY == null) return;
                IPointListEdit AccelerationListY = AccelerationCurveY.Points as IPointListEdit;
                if (AccelerationListY == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccelerationListY.Add(time, accelerationY);
            }
            if (AccZView)
            {
                LineItem AccelerationCurveZ = SpeedGraph.GraphPane.CurveList[4] as LineItem;
                AccelerationCurveZ.IsY2Axis = true; // associate the acceleration curve with y2 axis
                if (AccelerationCurveZ == null) return;
                IPointListEdit AccelerationListZ = AccelerationCurveZ.Points as IPointListEdit;
                if (AccelerationListZ == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccelerationListZ.Add(time, accelerationZ);
            }

            Scale xScale = SpeedGraph.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (ViewMode)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = time - xScale.MajorStep;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            Scale YScale = SpeedGraph.GraphPane.YAxis.Scale;
            if (speed > YScale.Max) // Auto scale the Speed axis
            {
                YScale.Max = speed + YScale.MinorStep;
            }
            if (spdcmd > YScale.Max) // Auto scale the Speed axis
            {
                YScale.Max = spdcmd + YScale.MinorStep;
            }
            if (speed < YScale.Min) // Auto scale the Speed axis
            {
                YScale.Min = speed - YScale.MinorStep;
            }
            if (spdcmd < YScale.Min) // Auto scale the Speed axis
            {
                YScale.Max = spdcmd + YScale.MinorStep;
            }
            SpeedGraph.AxisChange();
            SpeedGraph.Invalidate();
        }

        private void btnGraphOn_Click(object sender, EventArgs e)
        {
            if (GraphOn) // if the graph is turned on then turn it off
            {
                TurnOffGraph();          
            }
            else // if the graph is turned off then turn it on
            {
                TurnOnGraph();
            }
        }
        private void TurnOnGraph()
        {
            try
            {
                GraphOn = true;
                btnGraphOn.Text = "Graph OFF";
                SendCommand("6/1" + "$"); // command to turn on
                timer1.Enabled = true;
                TickStart = Environment.TickCount;
                if (SpeedGraph.GraphPane.CurveList.Count <= 0) // Neu chua co duong Curve thi khoi tao
                {
                    RollingPointPairList Speedlist = new RollingPointPairList(6000);
                    LineItem SpeedCurve = SpeedGraph.GraphPane.AddCurve("Speed", Speedlist, Color.Red, SymbolType.None);
                    SpeedCurve.Line.Width = (float)3.0;
                    RollingPointPairList AccelerationList = new RollingPointPairList(6000);
                    LineItem AccelerationCurve = SpeedGraph.GraphPane.AddCurve("Speed", Speedlist, Color.Blue, SymbolType.None);
                    AccelerationCurve.Line.Width = (float)3.0;
                    SpeedGraph.AxisChange();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check the communication");
            }
        }
        private void TurnOffGraph()
        {
            timer1.Enabled = false;
            GraphOn = false;
            btnGraphOn.Text = "Graph ON";
            SendCommand("6/0" + "$");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //SendCommand("12" + "$"); // 12 means request StE03 = Motor Speed
            timercount++;
            time = (timercount * timer1.Interval) / 1000.0;  // to seconds
            Draw(time, MotorSpeed, SpdCommand, AccelerationX, AccelerationY, AccelerationZ);
            //Draw(time, MotorSpeed, 1, 2, 3);
            Data_Listview(); // view data to the list view

            if (StartWaitingFlag) // stm32 finishes an episode, then delay for seconds before the next one
            {
                WaitingCount++;
                if (WaitingCount >= 40) // Delay for 2 seconds, 50*40 = 2000ms
                {
                    StartWaitingFlag = false;
                    WaitingCount = 0;
                    SendCommand(StartRunning + "$"); // Send command to STM32 to run next episode
                }
            }
            if (WaitingBeforeRunning)
            {
                CountBeforeRunning++;
                if (CountBeforeRunning>=40) // delay for 2 secs
                {
                    WaitingBeforeRunning = false;
                    CountBeforeRunning = 0;
                    SendCommand(StartRunning + "$"); // Send command to start running
                }                
            }
        }
        private void ResetGraph()
        {
            btnGraphOn.Text = "Graph ON";
            GraphOn = false;
            //SendCommand("6/0" + "$"); // Stop transmit speed data;
            timer1.Enabled = false; // Stop receive speed data            
            timer1.Interval = SampleTime; //ms Sample time 
            timercount = 0;
            time = 0;

            SendCommand("6/0" + "$"); // turn off receiving

            SpeedGraph.GraphPane.CurveList.Clear(); // Xoa do thi

            //GraphInit(); // Reinitialize the Graph

            SpeedGraph.GraphPane.XAxis.Scale.Max = 10;
            SpeedGraph.GraphPane.XAxis.Scale.Min = 0;
            SpeedGraph.GraphPane.YAxis.Scale.Max = 100;
            SpeedGraph.GraphPane.YAxis.Scale.Min = -100;

            SpeedGraph.GraphPane.AddY2Axis("Acceleration, m/s2");
            SpeedGraph.GraphPane.Y2Axis.IsVisible = true;

            SpeedGraph.GraphPane.Y2Axis.Title.Text = "Acceleration, m/s2";
            SpeedGraph.GraphPane.Y2Axis.Scale.Min = -11;
            SpeedGraph.GraphPane.Y2Axis.Scale.Max = 11;
            SpeedGraph.GraphPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            SpeedGraph.GraphPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;

            RollingPointPairList Speedlist = new RollingPointPairList(60000);
            LineItem SpeedCurve = SpeedGraph.GraphPane.AddCurve("Motor Speed", Speedlist, Color.Red, SymbolType.None);
            SpeedCurve.Line.Width = (float)3.0;

            RollingPointPairList SpdCmdList = new RollingPointPairList(60000);
            LineItem SpdCurve = SpeedGraph.GraphPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
            SpdCurve.Line.Width = (float)3.0;

            RollingPointPairList AccelerationListX = new RollingPointPairList(60000);
            LineItem AccelerationCurveX = SpeedGraph.GraphPane.AddCurve("AccelerationX", AccelerationListX, Color.Blue, SymbolType.None);
            AccelerationCurveX.IsY2Axis = true;
            AccelerationCurveX.Line.Width = (float)3.0;

            RollingPointPairList AccelerationListY = new RollingPointPairList(60000);
            LineItem AccelerationCurveY = SpeedGraph.GraphPane.AddCurve("AccelerationY", AccelerationListY, Color.Green, SymbolType.None);
            AccelerationCurveX.IsY2Axis = true;
            AccelerationCurveX.Line.Width = (float)3.0;

            RollingPointPairList AccelerationListZ = new RollingPointPairList(60000);
            LineItem AccelerationCurveZ = SpeedGraph.GraphPane.AddCurve("AccelerationZ", AccelerationListZ, Color.Black, SymbolType.None);
            AccelerationCurveZ.IsY2Axis = true;
            AccelerationCurveZ.Line.Width = (float)3.0;

            SpeedGraph.AxisChange();
            SpeedGraph.Invalidate();
            listData.Items.Clear(); // Clear data in the list view
        }
        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraph();
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if (btnScroll.Text == "SCROLL")
            {
                ViewMode = true;
                btnScroll.Text = "COMPACT";
            }
            else
            {
                ViewMode = false;
                btnScroll.Text = "SCROLL";
            }
        }

        private void Main_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Response;
            Response = MessageBox.Show("Do you want to exit? ESTOP will be triggered on", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Response == DialogResult.OK)
            {
                Console.WriteLine("> Emergency Stop");
                SendCommand(ESTOP + "$");
                ServerOff();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cbReadOutputs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadOutputs.CheckState == CheckState.Checked) // request reading output data
            {
                SendCommand("8/1" + "$"); // 8/1 = request output data
            }
            else
            {
                SendCommand("8/0" + "$"); // 8/1 = stop Reading output data
                lb_Type.BackColor = Color.Gray;

                lbBrake.BackColor = Color.Gray;

                lbReady.BackColor = Color.Gray;

                lbSpeedReach.BackColor = Color.Gray;

                lbTorqueLimit.BackColor = Color.Gray;

                lbAlarm.BackColor = Color.Gray;

                lbCcwTorqueLimit.BackColor = Color.Gray;

                lbCwTorqueLimit.BackColor = Color.Gray;

                lbZeroSpeedReach.BackColor = Color.Gray;
            }
        }

        private void btnSetEpisode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalEpisodes.Text, out TotalEpisodes))
            {
                SendCommand("9" + "/" + TotalEpisodes.ToString() + "$");
                // 9 is the function code indicates setting the total number of episodes.               
                progressBar.Maximum = TotalEpisodes;
                ShowCurrentEpisodeLabel(CurrentEpisode,TotalEpisodes);
                MessageBox.Show("Setting done");
            }

        }

        private void lbReady_BackColorChanged(object sender, EventArgs e)
        {
            if (lbReady.BackColor == Color.Lime) // The driver is not 
            {
                EnableJogControl();
            }
            else
            {
                DisableJogControl();
            }
        }
        private void DisableJogControl()
        {
            //gbJogControl.Enabled = false;
            btnMoveDown.Enabled = false; 
            btnMoveUp.Enabled = false;
            //txtSetSpeed.Enabled = false;

            btnMoveDown.BackColor = Color.LightGray;
            btnMoveUp.BackColor = Color.LightGray;
            btnSetJogSpeed.BackColor = Color.LightGray;
        }
        private void EnableJogControl()
        {
            gbJogControl.Enabled = true;
            btnMoveDown.Enabled = true;
            btnSetJogSpeed.Enabled = true;
            txtSetSpeed.Enabled = true;

            btnMoveDown.BackColor = Color.FromArgb(192, 255, 192);
            btnMoveUp.BackColor = Color.FromArgb(192, 255, 192);
            btnSetJogSpeed.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void cbSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpeed.CheckState == CheckState.Checked)
            {
                SpeedView = true;
            }
            else SpeedView = false;
        }
        #region Data view check boxes
        private void cbSpdCmd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpdCmd.CheckState == CheckState.Checked)
            {
                SpdCmdView = true;
            }
            else SpdCmdView = false;
        }

        private void cbAccX_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccX.CheckState == CheckState.Checked)
            {
                AccXView = true;
            }
            else AccXView = false;
        }

        private void cbAccY_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccY.CheckState == CheckState.Checked)
            {
                AccYView = true;
            }
            else AccYView = false;
        }

        private void cbAccZ_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccZ.CheckState == CheckState.Checked)
            {
                AccZView = true;
            }
            else AccZView = false;
        }
        #endregion

        private void btnRstMcu_Click(object sender, EventArgs e)
        {
            SendCommand("17$");
        }
    }
}

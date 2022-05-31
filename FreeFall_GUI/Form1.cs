using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using ZedGraph;

namespace FreeFall_GUI
{
    public partial class Form1 : Form
    {
        #region Variables

        public static Form1 instance;
        

        private string ReceivedMessage;

        private string AccelDataToSend;

        COM_Config _COM_Config = new COM_Config();
        COM_Testing TestCOM = new COM_Testing();
        Main_Control _MainCOntrol = new Main_Control();

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        
        // Delegate to load the saved params to the ParamSetting Form
        public delegate void LoadDataToParamSettingForm(float _AccelerationTime, float MaxSpeed, float kp, float Ki, float AccRef, uint SampleTime);
        public LoadDataToParamSettingForm LoadData; // creat an instance
        #endregion

        public Form1()
        {
            InitializeComponent();
            instance = this;
            //Sender = new TransData(SendMessage);
        }
 
        #region Button Callback
        private bool ConnectCOM()
        {
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("6/0" + "$");
                    timer1.Enabled = true;
                    lb_com_status.Text = serialPort1.PortName.ToString() + " is connected";
                    lb_com_status.BackColor = Color.Lime;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            return serialPort1.IsOpen;
        }
        private string[] COMRefresh()
        {
            string[] port = SerialPort.GetPortNames();
            return port;
        }
        private bool COMDisconnect()
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return serialPort1.IsOpen;
        }
        public bool IsFormOpen(Form _form) // Function to check if a form is openned or not
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == _form.Name)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Function
        public void SendMessage(string message) // Function to send a message to STM32
        {
            //MessageToWrite = message;
            try
            {
                serialPort1.WriteTimeout = 500;
                serialPort1.Write(message + "$");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }
        public void SendAccZData(float AccZ)
        {
            string AccData2Send = "9" + "/" + AccZ.ToString();
            SendMessage(AccData2Send); // r is the funtion code
        } 
        public void SetCOMParam (string PortName, int _BauRate, int _DataBits, string _StopBits, string _Parity)
        {
            serialPort1.PortName = PortName;
            serialPort1.BaudRate = _BauRate;
            serialPort1.DataBits = _DataBits;
            switch (_StopBits)
            {
                case "One":
                    serialPort1.StopBits = StopBits.One;// default value
                    break;
                case "Two":
                    serialPort1.StopBits = StopBits.Two;
                    break;
                default:
                    serialPort1.StopBits = StopBits.One;// default value
                    break;
            }
            switch (_Parity)
            {
                case "None":
                    serialPort1.Parity = Parity.None;
                    break;
                case "Even":
                    serialPort1.Parity = Parity.Even;
                    break;
                case "Odd":
                    serialPort1.Parity = Parity.Odd;
                    break;
                default:
                    serialPort1.Parity = Parity.None;
                    break;
            }            
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            //serialPort1.PortName = cb_com_comport.Text;
            serialPort1.BaudRate = 9600; // default value
            serialPort1.DataBits = 8; // default value
            serialPort1.StopBits = StopBits.One;// default value
            serialPort1.Parity = Parity.None;// default value
                                             // 
            Main_Control_Load();
            if (!serialPort1.IsOpen)
            {
                lb_com_status.BackColor = Color.Yellow;
                lb_com_status.Text = "Require connect to the MCU";
            }
        }
        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                lb_com_status.BackColor = Color.Red;
                lb_com_status.Text = "COM is disconnected";
                timer1.Enabled = false;
                //gb_System_Check.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string TemperoryData = serialPort1.ReadExisting();
            ReceivedMessage += TemperoryData; // keep adding to the data
            if (ReceivedMessage[ReceivedMessage.Length - 1] == 'e') // read up to the ending character e
            {
                this.Invoke(new EventHandler(ProcessMessage));
                ReceivedMessage = null;
            }
        }
        private void ProcessMessage(object sender, EventArgs e)
        {
            ReceivedMessage = ReceivedMessage.Replace("\n", null).Replace("\r", null);
            
            if (ReceivedMessage[0] == 'r') // r meean running parameters, check the running parameters
            {
                if (_CheckRunningData == null)
                {
                    return;
                }
                else
                {
                    ReceivedMessage = (ReceivedMessage.Replace("r", null)).Replace("e", null); // remove the character s in the string
                    string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string

                    try
                    {
                        uint ParamCode = uint.Parse(RunningParamString[0]);
                        float Param = float.Parse(RunningParamString[1]);
                        _CheckRunningData(ParamCode, Param); // Check if setting is done or not
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }                                
            }
            if (ReceivedMessage[0] == 'p') // Load running (controller params)
            {
                if (LoadData == null)
                    return;
                ReceivedMessage = (ReceivedMessage.Replace("p", null)).Replace("e", null); // remove the character s in the string
                string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string
                float[] RunningParamFloat = new float[6];

                try
                {
                    for (int i = 0; i < RunningParamFloat.Length; i++)
                    {
                        RunningParamFloat[i] = float.Parse(RunningParamString[i]);
                    }
                    LoadData(RunningParamFloat[0], RunningParamFloat[1], RunningParamFloat[2], RunningParamFloat[3], RunningParamFloat[4], (uint)RunningParamFloat[5]); // Load the data
                }
                catch (Exception)
                {

                }
            }
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
                if (ExtractReceivedMessage[0] == "2") // Only the speed data
                {
                    try
                    {
                        MotorSpeed = -float.Parse(ExtractReceivedMessage[1]);
                        SpdCommand = float.Parse(ExtractReceivedMessage[2]);
                        EncoderPulse = int.Parse(ExtractReceivedMessage[3]);
                        lbMotorSpeed.Text = MotorSpeed.ToString();
                        lbEncoderPulses.Text = EncoderPulse.ToString();
                    }
                    catch { }
                }
                if (ExtractReceivedMessage[0] == "3") // both Driver output and speed data
                {
                    try
                    {
                        //Console.WriteLine(ExtractReceivedMessage[1].ToString());
                        MotorSpeed = float.Parse(ExtractReceivedMessage[1]);
                        EncoderPulse = int.Parse(ExtractReceivedMessage[2]); // Speed command
                        DriverOutput = uint.Parse(ExtractReceivedMessage[3]);
                        //ShowDriverOutput(DriverOutput);
                        lbMotorSpeed.Text = ExtractReceivedMessage[1];
                        lbEncoderPulses.Text = ExtractReceivedMessage[2];
                    }
                    catch { }
                }
            }
            if (ReceivedMessage[0] == 'o') // Only the driver outputs
            {
                ReceivedMessage = (ReceivedMessage.Replace("o", null)).Replace("e", null);
                if (uint.TryParse(ReceivedMessage, out DriverOutput)) // Neu du lieu truyen len la speed
                {
                    ShowDriverOutput(DriverOutput);
                }
            }
            // An episode is completed
            if (ReceivedMessage[0] == '$') // $ means stm32 completes an episode
            {
                if (btnStartDropping.Text == "STOP") // if the system is running
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
                        btnStartDropping.Text = "START";
                        btnStartDropping.BackColor = Color.Lime;
                        StartWaitingFlag = false; // reset flag
                        WaitingCount = 0; // reset timer count

                        TurnOffGraph(); // Turn off the graph
                        ProgressBarInit();
                        MessageBox.Show("Running completed");
                        progressBar.Visible = false;
                    }
                }
            }
            if (ReceivedMessage[0] == 'j') // Check setting jog speed
            {
                ReceivedMessage = (ReceivedMessage.Replace("j", null)).Replace("e", null);
                try
                {
                    uint SettingJogSpeed = uint.Parse(ReceivedMessage);
                    if (SettingJogSpeed == JogSpeed) // Setting done
                    {
                        MessageBox.Show("Setting done");
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        public delegate void CheckRunningData(uint Code, float Param);
        public CheckRunningData _CheckRunningData;
        private void btn_check_start_Click(object sender, EventArgs e)
        {
            ParamSetting _ParamSetting = new ParamSetting(); // Create a new form
            _CheckRunningData = new CheckRunningData(_ParamSetting.CheckParams); // initialize the delegates

            // Assign the delegate to a function in Paramseting Form
            LoadData = new LoadDataToParamSettingForm(_ParamSetting.LoadSavedParams);
            _ParamSetting._SendCommand = new ParamSetting.SendCommand(SendMessage);
            _ParamSetting.Show();
            // Load the data at the beginning
            try
            {
                serialPort1.Write("10" + "$"); // 10 is the funtion code sent to the STM32 to require upload the saved parameters 
            }
            catch
            {
                MessageBox.Show("Can not load the parameters. Check the Communication");
            }
        }
        private void SetRunningParams(int AccelerationTime, int DecclerationTime, int MaxSpeed)
        {
            if (serialPort1.IsOpen) // If the COM is openned
            {
                string Param2Send = AccelerationTime.ToString() + "/" + DecclerationTime.ToString() + "/" + MaxSpeed.ToString();
                serialPort1.WriteTimeout = 500;
                serialPort1.Write("7" + "/" + Param2Send + "$"); // r is the funtion code                
            }
            else return;
        }
        private void btnConsole_Click(object sender, EventArgs e)
        {
            AllocConsole();
            this.Show();
            // Just call the console related methods in here
        }


        private void btnHideConsole_Click(object sender, EventArgs e)
        {
            AllocConsole();
            this.Hide();
        }
        public void InitCOMConfig()
        {
            _COM_Config = new COM_Config();
            _COM_Config._SetCOM = new COM_Config.SetCOM(SetCOMParam);
            _COM_Config._COMConnect = new COM_Config.COMConnect(ConnectCOM);
            _COM_Config._COMDisconnect = new COM_Config.COMDisconnect(COMDisconnect);
            _COM_Config._COMRefresh = new COM_Config.COMRefresh(COMRefresh);
        }
        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_COM_Config == null)
            {
                InitCOMConfig();
                _COM_Config.Show();
            }
            else
            {
                if (_COM_Config.IsDisposed)
                {
                    InitCOMConfig();
                    _COM_Config.Show();
                }

                if (!IsFormOpen(_COM_Config)) // Check if form is openned or not
                {
                    try
                    {
                        InitCOMConfig();
                        _COM_Config.Show();
                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.ToString());
                    }
                }
                else
                {
                    _COM_Config.BringToFront();
                }
            }            
        }
        #region Main_Control
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
        
        private bool PositionControlMode;

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
        

        float MotorSpeed; // Motor speed
        float SpdCommand; // Speed Command
        int EncoderPulse;
        private const int EncoderResolution = 2048; // Encoder Resolution
        
        uint DriverOutput;
        uint JogSpeed;

        private GraphPane MyPane = new GraphPane();
        private bool IsRunning = false;        
        

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
                if (ExtractReceivedMessage[0] == "2") // Only the speed data
                {
                    try
                    {
                        MotorSpeed = -float.Parse(ExtractReceivedMessage[1]);
                        SpdCommand = float.Parse(ExtractReceivedMessage[2]);
                        EncoderPulse = int.Parse(ExtractReceivedMessage[3]);
                        lbMotorSpeed.Text = MotorSpeed.ToString();
                        lbEncoderPulses.Text = EncoderPulse.ToString();
                    }
                    catch { }
                }
                if (ExtractReceivedMessage[0] == "3") // both Driver output and speed data
                {
                    try
                    {
                        //Console.WriteLine(ExtractReceivedMessage[1].ToString());
                        MotorSpeed = float.Parse(ExtractReceivedMessage[1]);
                        EncoderPulse = int.Parse(ExtractReceivedMessage[2]); // Speed command
                        DriverOutput = uint.Parse(ExtractReceivedMessage[3]);
                        //ShowDriverOutput(DriverOutput);
                        lbMotorSpeed.Text = ExtractReceivedMessage[1];
                        lbEncoderPulses.Text = ExtractReceivedMessage[2];
                    }
                    catch { }
                }
            }
            if (ReceivedMessage[0] == 'o') // Only the driver outputs
            {
                ReceivedMessage = (ReceivedMessage.Replace("o", null)).Replace("e", null);
                if (uint.TryParse(ReceivedMessage, out DriverOutput)) // Neu du lieu truyen len la speed
                {
                    ShowDriverOutput(DriverOutput);
                }
            }
            // An episode is completed
            if (ReceivedMessage[0] == '$') // $ means stm32 completes an episode
            {
                if (btnStartDropping.Text == "STOP") // if the system is running
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
                        btnStartDropping.Text = "START";
                        btnStartDropping.BackColor = Color.Lime;
                        StartWaitingFlag = false; // reset flag
                        WaitingCount = 0; // reset timer count

                        TurnOffGraph(); // Turn off the graph
                        ProgressBarInit();
                        MessageBox.Show("Running completed");
                        progressBar.Visible = false;
                    }
                }
            }
            if (ReceivedMessage[0] == 'j') // Check setting jog speed
            {
                ReceivedMessage = (ReceivedMessage.Replace("j", null)).Replace("e", null);
                try
                {
                    uint SettingJogSpeed = uint.Parse(ReceivedMessage);
                    if (SettingJogSpeed == JogSpeed) // Setting done
                    {
                        MessageBox.Show("Setting done");
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        public void SetSampleTime(int _SampleTime)
        {
            SampleTime = _SampleTime;
            timer1.Interval = SampleTime;
        }
        private void ShowDriverOutput(uint DriverOutput) // Visual the driver's output
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
               
        private void btnMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Jog Move Down");
            SendMessage(JogDown);
        }

        private void btnMoveDown_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Stop");
            SendMessage(STOP);
        }
        private void btnSetJogSpeed_Click(object sender, EventArgs e)
        {
            if (PositionControlMode)
            {
                try
                {
                    JogSpeed = uint.Parse(txtSetSpeed.Text);
                    string Command = "5" + "/" + JogSpeed.ToString();
                    SendMessage(Command);
                    Console.WriteLine("> Set Speed: " + Command);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input data type");
                }
            }
            else
            {
                int RegisterAddress = 401; //  P4-02, Speed Command
                float value;
                try
                {
                    value = float.Parse(txtSetSpeed.Text);
                    string Command = "5" + "/" + "1" + "/" + RegisterAddress.ToString() + "/" + value.ToString();
                    SendMessage(Command);
                    Console.WriteLine("> Set Speed: " + Command);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input data type");
                }
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
        private void Main_Control_Load()
        {
            GraphInit();
            ProgressBarInit();
            //DisableJogControl();
            TickStart = Environment.TickCount;

            // Consider to get the driver status from the board
            PositionControlMode = true;

            timer1.Interval = SampleTime; //ms
            timer1.Enabled = false;
            ShowCurrentEpisodeLabel(CurrentEpisode, TotalEpisodes);
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

            cbSpeed.CheckState = CheckState.Unchecked;
            cbSpdCmd.CheckState = CheckState.Unchecked;     
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
            ws.Cells[1, 3] = "Ref Speed (rpm)";            
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
            { }

        }
        private void Data_Listview()
        {
            if (!GraphOn)
                return;
            else
            {
                ListViewItem item = new ListViewItem(time.ToString()); // Gán biến realtime vào cột đầu tiên của ListView
                item.SubItems.Add(MotorSpeed.ToString());                

                listData.Items.Add(item); // Gán biến datas vào cột tiếp theo của ListView
                                          // Không nên gán string SDatas vì khi xuất dữ liệu sang Excel sẽ là dạng string, không thực hiện các phép toán được

                listData.Items[listData.Items.Count - 1].EnsureVisible(); // Hiện thị dòng được gán gần nhất ở ListView, tức là mình cuộn ListView theo dữ liệu gần nhất đó
            }
        }
        //private void Draw(double time, double speed, double spdcmd, double accelerationX, double accelerationY, double accelerationZ)
        private void Draw(double time, double speed, double spdcmd)
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
        private void TurnOnGraph()
        {
            try
            {
                GraphOn = true;
                btnGraphOn.Text = "Graph OFF";
                SendMessage("6/1"); // command to turn on
                timer2.Enabled = true;
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
            timer2.Enabled = false;
            GraphOn = false;
            btnGraphOn.Text = "Graph ON";
            SendMessage("6/0");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //SendMessage("12"  ); // 12 means request StE03 = Motor Speed
            timercount++;
            time = (timercount * timer1.Interval) / 1000.0;  // to seconds
            //Draw(time, MotorSpeed, SpdCommand, AccelerationX, AccelerationY, AccelerationZ);
            Draw(time, MotorSpeed, SpdCommand);
            //Draw(time, MotorSpeed, 1, 2, 3);
            Data_Listview(); // view data to the list view

            if (StartWaitingFlag) // stm32 finishes an episode, then delay for seconds before the next one
            {
                WaitingCount++;
                if (WaitingCount >= 40) // Delay for 2 seconds, 50*40 = 2000ms
                {
                    StartWaitingFlag = false;
                    WaitingCount = 0;
                    SendMessage(StartRunning); // Send command to STM32 to run next episode
                }
            }
            if (WaitingBeforeRunning)
            {
                CountBeforeRunning++;
                if (CountBeforeRunning >= 40) // delay for 2 secs
                {
                    WaitingBeforeRunning = false;
                    CountBeforeRunning = 0;
                    SendMessage(StartRunning); // Send command to start running
                }
            }
        }
        private void ResetGraph()
        {
            btnGraphOn.Text = "Graph ON";
            GraphOn = false;
            //SendMessage("6/0" ); // Stop transmit speed data;
            timer2.Enabled = false; // Stop receive speed data            
            timer2.Interval = SampleTime; //ms Sample time 
            timercount = 0;
            time = 0;

            SendMessage("6/0"); // turn off receiving

            SpeedGraph.GraphPane.CurveList.Clear(); // Xoa do thi

            //GraphInit(); // Reinitialize the Graph

            SpeedGraph.GraphPane.XAxis.Scale.Max = 10;
            SpeedGraph.GraphPane.XAxis.Scale.Min = 0;
            SpeedGraph.GraphPane.YAxis.Scale.Max = 100;
            SpeedGraph.GraphPane.YAxis.Scale.Min = -100;            

            RollingPointPairList Speedlist = new RollingPointPairList(60000);
            LineItem SpeedCurve = SpeedGraph.GraphPane.AddCurve("Motor Speed", Speedlist, Color.Red, SymbolType.None);
            SpeedCurve.Line.Width = (float)3.0;

            RollingPointPairList SpdCmdList = new RollingPointPairList(60000);
            LineItem SpdCurve = SpeedGraph.GraphPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
            SpdCurve.Line.Width = (float)3.0;

            SpeedGraph.AxisChange();
            SpeedGraph.Invalidate();
            listData.Items.Clear(); // Clear data in the list view
        }
        private void btnResetGraph_Click(object sender, EventArgs e)
        {
            ResetGraph();
        }       

        private void Main_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Response;
            Response = MessageBox.Show("Do you want to exit? ESTOP will be triggered on", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Response == DialogResult.OK)
            {
                Console.WriteLine("> Emergency Stop");
                SendMessage(ESTOP);
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
                SendMessage("8/1"); // 8/1 = request output data
            }
            else
            {
                SendMessage("8/0"); // 8/1 = stop Reading output data
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
            btnMoveUp.Enabled = true;
            btnSetJogSpeed.Enabled = true;
            txtSetSpeed.Enabled = true;

            btnMoveDown.BackColor = Color.FromArgb(192, 255, 192);
            btnMoveUp.BackColor = Color.FromArgb(192, 255, 192);
            btnSetJogSpeed.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void btnRstMcu_Click(object sender, EventArgs e)
        {
            SendMessage("17");
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleServoEnable.CheckState == CheckState.Checked) // Servo Enable ON
            {
                SendMessage("18/1");
            }
            else
            {
                SendMessage("18/0");
            }
        }        

        private void toglePLSCLR_CheckedChanged(object sender, EventArgs e)
        {
            if (toglePLSCLR.CheckState == CheckState.Checked)
            {
                SendMessage("21/1");
            }
            else
            {
                SendMessage("21/0");
            }
        }

        private void togleSPLIM_CheckedChanged(object sender, EventArgs e)
        {
            if (togleSPLIM.CheckState == CheckState.Checked)
            {
                SendMessage("22/1");
            }
            else
            {
                SendMessage("22/0");
            }
        }

        private void toglePLSINH_CheckedChanged(object sender, EventArgs e)
        {
            if (toglePLSINH.CheckState == CheckState.Checked)
            {
                SendMessage("23/1");
            }
            else
            {
                SendMessage("23/0");
            }
        }

        private void togleCWLIM_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCWLIM.CheckState == CheckState.Checked)
            {
                SendMessage("24/1");
            }
            else
            {
                SendMessage("24/0");
            }
        }

        private void togleCCWLIM_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCCWLIM.CheckState == CheckState.Checked)
            {
                SendMessage("25/1");
            }
            else
            {
                SendMessage("25/0");
            }
        }

        private void rjToggleButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (togleDIR.CheckState == CheckState.Checked)
            {
                SendMessage("26/1");
            }
            else
            {
                SendMessage("26/0");
            }
        }
        #endregion

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            //SendMessage("12"  ); // 12 means request StE03 = Motor Speed
            timercount++;
            time = (timercount * timer2.Interval) / 1000.0;  // to seconds
            //Draw(time, MotorSpeed, SpdCommand, AccelerationX, AccelerationY, AccelerationZ);
            Draw(time, MotorSpeed, SpdCommand);
            //Draw(time, MotorSpeed, 1, 2, 3);
            Data_Listview(); // view data to the list view

            if (StartWaitingFlag) // stm32 finishes an episode, then delay for seconds before the next one
            {
                WaitingCount++;
                if (WaitingCount >= 40) // Delay for 2 seconds, 50*40 = 2000ms
                {
                    StartWaitingFlag = false;
                    WaitingCount = 0;
                    SendMessage(StartRunning); // Send command to STM32 to run next episode
                }
            }
            if (WaitingBeforeRunning)
            {
                CountBeforeRunning++;
                if (CountBeforeRunning >= 40) // delay for 2 secs
                {
                    WaitingBeforeRunning = false;
                    CountBeforeRunning = 0;
                    SendMessage(StartRunning); // Send command to start running
                }
            }
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

        private void btnResetGraph_Click_1(object sender, EventArgs e)
        {
            ResetGraph();
            ProgressBarInit();
        }

        private void btnResetAlarm_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("> Alarm Reset");
            SendMessage(AlarmReset);
        }

        private void btnEstop_Click_1(object sender, EventArgs e)
        {
            SendMessage(ESTOP);
            Console.WriteLine("> Emergency Stop");
        }

        private void btnStartDropping_Click_1(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
            if (IsRunning) // if is not running > Start running
            {
                btnStartDropping.BackColor = Color.Orange;
                btnStartDropping.Text = "STOP";

                progressBar.Visible = true;
                TurnOnGraph(); // Turn on the graph
                WaitingBeforeRunning = true;
            }
            else // If it is running > Stop running
            {
                btnStartDropping.BackColor = Color.Lime;
                btnStartDropping.Text = "START";
                SendMessage(StopRunning);
                ResetGraph();
                ProgressBarInit();
            }
            Console.WriteLine("> Start Running");
        }

        private void btnStartPulling_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("> Stop");
            SendMessage(STOP);
        }

        private void toggleServoEnable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSetEpisode_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalEpisodes.Text, out TotalEpisodes))
            {
                SendMessage("9" + "/" + TotalEpisodes.ToString());
                // 9 is the function code indicates setting the total number of episodes.               
                progressBar.Maximum = TotalEpisodes;
                ShowCurrentEpisodeLabel(CurrentEpisode, TotalEpisodes);
                MessageBox.Show("Setting done");
            }
        }

        private void btnScroll_Click_1(object sender, EventArgs e)
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                SaveToExcel(0); // Thực thi hàm lưu ListView sang Excel
            }
        }

        private void btnMoveDown_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void btnMoveDown_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void btnMoveUp_MouseDown_1(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Jog Move Up");
            SendMessage(JogUp);
        }

        private void btnMoveUp_MouseUp_1(object sender, MouseEventArgs e)
        {
            Console.WriteLine("> Stop");
            SendMessage(STOP);
        }

        private void cbSpeed_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbSpeed.CheckState == CheckState.Checked)
            {
                SpeedView = true;
            }
            else SpeedView = false;
        }

        private void cbSpdCmd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbSpdCmd.CheckState == CheckState.Checked)
            {
                SpdCmdView = true;
            }
            else SpdCmdView = false;
        }

        private void parameterSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamSetting _ParamSetting = new ParamSetting(); // Create a new form
            _CheckRunningData = new CheckRunningData(_ParamSetting.CheckParams); // initialize the delegates

            // Assign the delegate to a function in Paramseting Form
            LoadData = new LoadDataToParamSettingForm(_ParamSetting.LoadSavedParams);           
            _ParamSetting._SendCommand = new ParamSetting.SendCommand(SendMessage);
            _ParamSetting.Show();
            // Load the data at the beginning
            try
            {
                serialPort1.Write("10" + "$"); // 10 is the funtion code sent to the STM32 to require upload the saved parameters 
            }
            catch
            {
                MessageBox.Show("Can not load the parameters. Check the Communication");
            }
        }
    }
}

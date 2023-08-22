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
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Net.Sockets;
using SimpleTCP;

namespace FreeFall_GUI
{
    public partial class Form1 : Form
    {
        #region Variables

        public static Form1 instance;
        

        private string ReceivedMessage;

        private string AccelDataToSend;

        COM_Config _COM_Config = new COM_Config();
        
        Main_Control _MainCOntrol = new Main_Control();

        _2ndDataGraph GyroAndDistGraph = new _2ndDataGraph();
        public delegate void Draw2ndGraph(double time, double _GyroX, double _GyroY, double _GyroZ, double _Position, double _PositionCmd);
        public Draw2ndGraph DrawGyroAndDistance;
        public delegate void Set2ndGraphViewMode(bool Mode);
        public Set2ndGraphViewMode SetGyroGraphViewMode;
        public delegate void ReSetGyroDisGraph();
        public ReSetGyroDisGraph _ReSetGyroDisGraph;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        
        // Delegate to load the saved params to the ParamSetting Form
        public delegate void LoadDataToParamSettingForm(float[] Params);
        public LoadDataToParamSettingForm LoadData; // creat an instance

        
        //# is the charater indicating the ending of the frame
        // '/' is the spliting character: function code/value
        private const string STOP = "1/1";
        private const string ESTOP = "44/0";
        private const string AlarmReset = "44/1";
        private const string PositionMode = "2/0";
        private const string SpeedMode = "2/1";
        private const string JogUp = "3/1";
        private const string JogDown = "3/0";
        private const string StartRunning = "4/1";
        private const string StopRunning = "4/0";
        private const string StopPulse = "28/1";

        private bool TYPEOUT;
        private bool BRAKE;
        private bool RDY;
        private bool CmdReach;
        private bool TorqueLimit;
        private bool Alarm;
        private bool CcwTorqueLimit;
        private bool CwTorqueLimit;
        private bool ZeroSpeedReach;
        
        private bool RunningMode; // true = automatic, false = manual
        private uint ExperimentMode = 1; // 1 = Dropping Mode, 2 = PullingMode, 3 = Pulling+Dropping
        private int TotalEpisodes = 1; // default value is 1
        private int CurrentEpisode;
        private bool StartWaitingFlag = false; // Flag to wait for running next episode
        private uint WaitingCount; // To count the timer for waiting
        private uint CountBeforeRunning;
        private bool WaitingBeforeRunning = false;
        private int PulseCmd; // to count the pulse cmd generate by the mcu

        private bool SimuOrRunning = false;

        private double AccZ; // m/s^2
        private double AccRef;

        private volatile int timercount; // to measure the timer counter

        int PreviousTime;

        private int SampleTime = 50;
        private const UInt16 EgearRatio = 8;
        double time;

        double TickStart;

        bool ViewMode = true; // SCROLL view mode
        bool GraphOn = false;
        bool SpeedView = false;
        bool SpdCmdView = false;
        bool MotorDriver = true; // true -> FDA7000, false -> ASDA-A3
        bool AccZView = false;
        bool AccRefView = false;

        float MotorSpeed; // Motor speed
        float SpdCommand; // Speed Command
        int CurrentPulse = 0;
        int PulseError;

        float DrumRadius = (float)0.05; //m - big model
        
        private const int HIGENEncoderRes = 8192; // =2048*4, quarter count Encoder Resolution
        private const int ASDAEncoderRes = 1024; // 
        //private int EncoderRes;
        private float ObjectPosition;

        uint DriverOutput;
        uint JogSpeed;

        private GraphPane MyPane = new GraphPane();        

        //private string FolderPath;

        #endregion

        public Form1()
        {
            InitializeComponent();
            instance = this;
            //Sender = new TransData(SendMessage);
        }
 
        #region Button Callback
        private bool ConnectCOM(int index)
        {
            try
            {
                switch (index)
                {
                    case 0: // serial 1 com port, for UI control
                        serialPort1.Open();
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.Write("6/0" + "$");
                            timer1.Enabled = true;
                            lb_com_status.Text = serialPort1.PortName.ToString() + " is connected";
                            lb_com_status.BackColor = Color.Lime;
                        }
                        return serialPort1.IsOpen;                        
                    case 1: // serail 2 com port, for transmit Accel data
                        serialPort2.Open();
                        if (serialPort2.IsOpen)
                        {
                            //lbSerialPort2Status.BackColor = Color.Lime;
                            //lbSerialPort2Status.Text = serialPort2.PortName.ToString() + " is connected";
                        }
                        
                        return serialPort2.IsOpen;                      

                    default:
                        break;
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            return false;
        }
        private string[] COMRefresh()
        {
            string[] port = SerialPort.GetPortNames();
            return port;
        }
        private bool COMDisconnect(int index)
        {
            try
            {
                switch (index)
                {
                    case 0: // serial1, UI control
                        serialPort1.Close();
                        return serialPort1.IsOpen;
                    case 1: // serial 2, Data transfer
                        serialPort2.Close();
                        return serialPort2.IsOpen;
                    default:
                        break;
                }                
            }
            catch
            {  }
            return true;
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

        public void SetCOMParam (int index, string PortName, int _BauRate, int _DataBits, string _StopBits, string _Parity)
        {
            switch (index)
            {
                case 0: // GUI port
                    if (serialPort1.IsOpen)
                    {
                        break;
                    }
                    else
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
                        break;
                    }
                    
                case 1: // Data port
                    if (serialPort2.IsOpen)
                    {
                        break;
                    }
                    else
                    {
                        serialPort2.PortName = PortName;
                        serialPort2.BaudRate = _BauRate;
                        serialPort2.DataBits = _DataBits;
                        switch (_StopBits)
                        {
                            case "One":
                                serialPort2.StopBits = StopBits.One;// default value
                                break;
                            case "Two":
                                serialPort2.StopBits = StopBits.Two;
                                break;
                            default:
                                serialPort2.StopBits = StopBits.One;// default value
                                break;
                        }
                        switch (_Parity)
                        {
                            case "None":
                                serialPort2.Parity = Parity.None;
                                break;
                            case "Even":
                                serialPort2.Parity = Parity.Even;
                                break;
                            case "Odd":
                                serialPort2.Parity = Parity.Odd;
                                break;
                            default:
                                serialPort2.Parity = Parity.None;
                                break;
                        }
                        break;
                    }                    
                default:
                    break;
            }                     
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            //serialPort1.PortName = cb_com_comport.Text;
            serialPort1.BaudRate = 115200; // default value
            serialPort1.DataBits = 8; // default value
            serialPort1.StopBits = StopBits.One;// default value
            serialPort1.Parity = Parity.None;// default value

            serialPort2.BaudRate = 115200; // default value
            serialPort2.DataBits = 8; // default value
            serialPort2.StopBits = StopBits.One;// default value
            serialPort2.Parity = Parity.None;// default value            

            Main_Control_Load();
            txtSetSpeed.Text = "30";
            if (!serialPort1.IsOpen)
            {
                lb_com_status.BackColor = Color.Yellow;
                lb_com_status.Text = "Require connection to the MCU";
            }
        }
        #endregion
        private void Main_Control_Load()
        {
            GraphInit();

            DisableJogControl();

            btnSetHome.Enabled = true;

            btnHoming.Enabled = false;
            
           

            btnStartDropping.Enabled = false;
            btnStartDropping.BackColor = Color.LightGray;
            TickStart = Environment.TickCount;            

            //timer2.Interval = SampleTime; //ms
            timer2.Enabled = false;
            
            //Initial output states color
            lbAlarm.BackColor = Color.Gray;
            lbBrake.BackColor = Color.Gray;
            lbCcwTorqueLimit.BackColor = Color.Gray;
            lbCwTorqueLimit.BackColor = Color.Gray;
            lbReady.BackColor = Color.Gray;
            lbSpeedReach.BackColor = Color.Gray;
            lbTorqueLimit.BackColor = Color.Gray;
            
            
            TotalEpisodes = 1; // Set default #of Episodes to 1

            // Data checkbox
            cbSpeed.CheckState = CheckState.Checked;
            cbSpdCmd.CheckState = CheckState.Checked;
            cbAccZ.CheckState = CheckState.Checked;
            cbAccRef.CheckState = CheckState.Checked;

            cbDriverType.SelectedIndex = 0;
            cbExperimentMode.SelectedIndex = 0;

            // Load Ip and port
            // Initialize TCP server parameters
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); // Get computers' IP address
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpAddress = address.ToString();
                    lbServerIP.Text = address.ToString();
                }
            }
            Port = 8000; // Default value
            lbPort.Text = Port.ToString();

            listener = new TcpListener(IPAddress.Any, Port); // create an instance of the listener
            InitTcpServer();

            GyroAndDistGraph.Show();
            _COM_Config._SetCOM = new COM_Config.SetCOM(SetCOMParam);
            
            DrawGyroAndDistance = new Draw2ndGraph(GyroAndDistGraph.DrawAllData);
            SetGyroGraphViewMode = new Set2ndGraphViewMode(GyroAndDistGraph.SetViewMode);
            _ReSetGyroDisGraph = new ReSetGyroDisGraph(GyroAndDistGraph.ReSetGraph);
        }
        bool ScanClient = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                lb_com_status.BackColor = Color.Red;
                lb_com_status.Text = "GUI COM discon";
                //timer1.Enabled = false;
                //gb_System_Check.Enabled = false;
            }
            
            if (!RDY) // Servo is ready
            {
                IsEStop = false; // Clear the Estop flag
                toggleServoEnable.Enabled = true;
                lbServoEnable.Enabled = true;               
            }
            else // Not ready
            {
                toggleServoEnable.Enabled = false;
                toggleServoEnable.CheckState = CheckState.Unchecked;
                lbServoEnable.Enabled = false;
                
            }

            if (IsServerOn)
            {
                if (client == null) // no client
                {
                    ServerOn();
                    return;
                }
                else
                {
                    if (client.Connected)
                    {
                        return;
                    }
                    else
                    {
                        ServerOn();
                        return;
                    }
                }
            }
            
            if (ScanClient) // Scanning connection is true
            {
                try
                { 
                    if (!isClientConnected())
                    {
                        togServerOnOff.CheckState = CheckState.Unchecked;
                        ScanClient = false;
                    }
                    else
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }                
            }                        
        }
        public bool isClientConnected()
        {
            try
            {
                if (client.Client.Poll(0, SelectMode.SelectRead))
                {
                    if (!client.Connected) return false;
                    else
                    {
                        byte[] b = new byte[1];
                        try
                        {
                            if (client.Client.Receive(b, SocketFlags.Peek) == 0)
                            {
                                // Client disconnected
                                return false;
                            }
                        }
                        catch { return false; }
                    }
                }
                return true;
            }
            catch
            {
                return false;
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


        #region Circular Buffer
        // Implement a circular buffer
        const int SIZE_OF_SPDCMD_BUFFER = 5; // Size of the buffer

        float[] SpdCmdCircularBuffer; // declare an array for the buffer
        int SpdCmdBufferLength = 0;
        int SpdCmdReadIndex = 0; // Reading index
        int SpdCmdWriteIndex = 0; // Writing index

        float[] SpdCircularBuffer; // declare an array for the buffer
        int SpdBufferLength = 0;
        int SpdReadIndex = 0; // Reading index
        int SpdWriteIndex = 0; // Writing index

        void ResetBuffer ()
        {
            SpdCmdBufferLength = 0;
            SpdCmdReadIndex = 0; 
            SpdCmdWriteIndex = 0; 
            SpdCmdCircularBuffer = null;

            SpdCircularBuffer = null; // declare an array for the buffer
            SpdBufferLength = 0;
            SpdReadIndex = 0; // Reading index
            SpdWriteIndex = 0; // Writing index
        }

        void InitSpdCmdBuffer()
        {
            SpdCmdCircularBuffer = new float[SIZE_OF_SPDCMD_BUFFER]; // declare an array for the buffer
            SpdCmdBufferLength = 0;
            SpdCmdReadIndex = 0; // Reading index
            SpdCmdWriteIndex = 0; // Writing index

            SpdCircularBuffer = new float[SIZE_OF_SPDCMD_BUFFER]; // declare an array for the buffer
            SpdBufferLength = 0;
            SpdReadIndex = 0; // Reading index
            SpdWriteIndex = 0; // Writing index
        }
        void WriteToSpdCmdBuffer (float value) // Write a value to the buffer
        {

            if (SpdCmdCircularBuffer == null)
            {
                return;
            }
            else
            {
                if (SpdCmdBufferLength == SIZE_OF_SPDCMD_BUFFER) // Check if the buffer is full or not
                {
                    return; // exit the function
                }
                SpdCmdCircularBuffer[SpdCmdWriteIndex] = value; // Store the value to the buffer

                SpdCmdBufferLength++;
                SpdCmdWriteIndex++;

                if (SpdCmdWriteIndex == SIZE_OF_SPDCMD_BUFFER)
                {
                    SpdCmdWriteIndex = 0;
                }
            }            
        }

        void WriteToSpdBuffer(float value) // Write a value to the buffer
        {            
            if (SpdCircularBuffer == null)
            {
                return;
            }
            else
            {
                if (SpdBufferLength == SIZE_OF_SPDCMD_BUFFER) // Check if the buffer is full or not
                {
                    return; // exit the function
                }
                SpdCircularBuffer[SpdWriteIndex] = value; // Store the value to the buffer

                SpdBufferLength++;
                SpdWriteIndex++;

                if (SpdWriteIndex == SIZE_OF_SPDCMD_BUFFER)
                {
                    SpdWriteIndex = 0;
                }
            }
        }

        float GetValueOutOfSpdBuffer()
        {
            if (SpdBufferLength == 0) // There is no data in the buffer
            {
                return 0; // return 0
            }
            else
            {
                SpdBufferLength--;
                SpdReadIndex++;

                if (SpdReadIndex == SIZE_OF_SPDCMD_BUFFER)
                {
                    SpdReadIndex = 0;
                }
                return SpdCircularBuffer[SpdReadIndex];
            }            
        }

        float GetValueOutOfSpdCmdBuffer ()
        {
            if (SpdCmdBufferLength == 0) // There is no data in the buffer
            {
                return 0; // return 0
            }

            SpdCmdBufferLength--;
            SpdCmdReadIndex++;

            if (SpdCmdReadIndex == SIZE_OF_SPDCMD_BUFFER)
            {
                SpdCmdReadIndex = 0;
            }
            return SpdCmdCircularBuffer[SpdCmdReadIndex];
        }
        #endregion

        
        public delegate void ShowFeedbackDriverDataFrame(string DataFrame);
        public ShowFeedbackDriverDataFrame _ShowFeedbackDriverDataFrame; // create an instance of delegate
        private void ProcessMessage(object sender, EventArgs e)
        {
            ReceivedMessage = ReceivedMessage.Replace("\n", null).Replace("\r", null);

            if (ReceivedMessage[0] == 'g')
            {
                ReceivedMessage = ReceivedMessage.Replace("g", null).Replace("e", null);
                string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string
                try
                {
                    uint ParamCode = uint.Parse(RunningParamString[0]);
                    float Param = float.Parse(RunningParamString[1]);
                    switch (ParamCode)
                    {
                        case 27: // Set Running Param
                            if (Param == 0)
                            {
                                MessageBox.Show("Set Running Mode to Manual");
                            }
                            if (Param == 1)
                            {
                                MessageBox.Show("Set Running Mode to Automactic");
                            }

                            break;
                        case 39:
                            if (Param == 1)
                            {
                                MessageBox.Show("Set Driver Type to HIGEN FDA7000");
                            }
                            if (Param == 0)
                            {
                                MessageBox.Show("Set Driver Type to DELTA ASDA(A3)");
                            }
                            break;
                        case 47:                            
                            break;
                        case 48:
                            if (Param == 1)
                            {
                                MessageBox.Show("Software Limit is ON");
                            }
                            if (Param == 0)
                            {
                                MessageBox.Show("Software Limit is OFF");
                            }
                            break;
                        case 14:
                            MessageBox.Show("Simulation finished\n Dropping distance is" + Param.ToString() + "m");
                            break;
                        case 15:
                            MessageBox.Show("Simulation finished\n Pulling distance is" + Param.ToString() + "m");
                            break;
                        case 16:
                            MessageBox.Show("Pulling distance is" + RunningParamString[1] + "m" + "\n Dropping Distance: " + RunningParamString[2]);
                            break;
                        case 4: // Start Running Experiment response
                            if (Param != 1) // Can not start the experiment
                            {
                                MessageBox.Show("CAN NOT START!!\n Please Initialize the Experiment First");
                                ResetGraph();
                                btnStartDropping.Text = "START";
                                btnStartDropping.BackColor = Color.Lime;
                                btnSimulate.Enabled = true;
                            }
                            else // Param = 1, then start the experiment
                            {
                                btnStartDropping.Text = "STOP";
                            }
                            break;
                        default:
                            break;
                    }
                    return;
                }
                catch
                {
                    return;
                }
            }
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
                    catch 
                    {
                        return;
                    }
                }
                return;
            }
            if (ReceivedMessage[0] == 't') // Check testing params
            {
                if (_CheckSpeedTestParam == null)
                {
                    return;
                }
                else
                {
                    ReceivedMessage = (ReceivedMessage.Replace("t", null)).Replace("e", null); // remove the character s in the string
                    string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string

                    try
                    {
                        uint ParamCode = uint.Parse(RunningParamString[0]);
                        float Param = float.Parse(RunningParamString[1]);
                        _CheckSpeedTestParam(ParamCode, Param); // Check if setting is done or not
                    }
                    catch
                    {
                        return;
                    }
                }
                return;
            }
            if (ReceivedMessage[0] == 'p') // Load running (controller params)
            {
                if (LoadData == null)
                    return;
                ReceivedMessage = (ReceivedMessage.Replace("p", null)).Replace("e", null); // remove the character s in the string
                string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string
                float[] RunningParamFloat = new float[19];

                try
                {
                    for (int i = 0; i < RunningParamFloat.Length; i++)
                    {
                        RunningParamFloat[i] = float.Parse(RunningParamString[i]);
                    }
                    LoadData(RunningParamFloat); // Load the data
                }
                catch (Exception)
                {

                }
                return;
            }
            if (ReceivedMessage[0] == 'w') // Driver send a feedback frame due to Writing to a Register
            {                
                ReceivedMessage = (ReceivedMessage.Replace("w", null)).Replace("e", null); // remove the character s in the string
                if (_ShowFeedbackDriverDataFrame == null)
                {
                    return; // if null, then exit
                }
                else
                {
                    _ShowFeedbackDriverDataFrame(ReceivedMessage);
                }
                return;
            }
            
            if (ReceivedMessage[0] == 's') // s means data from the driver
            {
                ReceivedMessage = (ReceivedMessage.Replace("s", null)).Replace("e", null); // remove the character s in the string
                // After remove 's' and 'e': functioncode/data1/data2
                string[] ExtractReceivedMessage = ReceivedMessage.Split('/');
                //if (ExtractReceivedMessage[0] == "2") // Only the speed data
                //{                
                try
                {
                    MotorSpeed = float.Parse(ExtractReceivedMessage[0]);
                    SpdCommand = float.Parse(ExtractReceivedMessage[1]);

                    ObjectPosition = float.Parse(ExtractReceivedMessage[2]);
                    PositionCmd = double.Parse(ExtractReceivedMessage[3]);

                    AccRef = double.Parse(ExtractReceivedMessage[4]);
                    // Write to the Buffer

                    //WriteToSpdCmdBuffer(SpdCommand);
                    //WriteToSpdBuffer(MotorSpeed);                    

                    lbMotorSpeed.Text = MotorSpeed.ToString() + " rpm";
                    //lbEncoderPulses.Text = CurrentPulse.ToString();
                    lbObjectPosition.Text = (ObjectPosition).ToString() + " m";

                   

                    //SpdCmdData = GetValueOutOfSpdCmdBuffer();
                    //SpdData = GetValueOutOfSpdBuffer();
                    if (btnGraphOn.Text == "Graph OFF")
                    {
                        time += (timer2.Interval) / 1000.0;  // to seconds
                        DrawAllData(time, MotorSpeed, SpdCommand, AccX, AccY, AccZ, AccRef);

                        if ((Application.OpenForms["_2ndDataGraph"] as _2ndDataGraph) != null) // Check if the form is opened or not
                        {
                            DrawGyroAndDistance(time, 0, 0, 0, ObjectPosition, PositionCmd);
                        }

                        Data_Listview(); // view data to the list view
                    }                    
                }
                catch { }                
                return;
            }
            
            if (ReceivedMessage[0] == 'o') // Only the driver outputs
            {
                ReceivedMessage = (ReceivedMessage.Replace("o", null)).Replace("e", null);
                if (uint.TryParse(ReceivedMessage, out DriverOutput)) // Neu du lieu truyen len la speed
                {
                    ShowDriverOutput(DriverOutput);
                }
                return;
            }
            if (ReceivedMessage[0] == 'm')
            {
                ReceivedMessage = (ReceivedMessage.Replace("m", null)).Replace("e", null);
                if (ReceivedMessage == "1")
                {
                    MessageBox.Show("Set to Dropping Mode");
                }
                if (ReceivedMessage == "2")
                {
                    MessageBox.Show("Set to Pulling Mode");
                }
                if (ReceivedMessage == "3")
                {
                    MessageBox.Show("Set to Dropping + Pulling Mode");
                }
                return;
            }
            // An episode is completed
            if (ReceivedMessage[0] == '$') // $ means stm32 completes an episode
            {
                if (btnStartDropping.Text == "STOP") // if the system is running
                {                  
                    
                    string DataPath = @"C:\Users\thanh\OneDrive\문서\Liintech\Data\Episode" + CurrentEpisode.ToString() + ".txt";
                    SaveDataToTxtFile(DataPath);

                    CurrentEpisode++;

                    ResetGraph(); // Reset the graph
                    TurnOnGraph(); // Turn on the graph
                    progressBar.PerformStep(); // visual the progress
                    StartWaitingFlag = true;

                    if (CurrentEpisode >= TotalEpisodes) // Complete all the episodes
                    {
                        CurrentEpisode = 0; // Set back to zero                        
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
                return;
            }
            if (ReceivedMessage[0] == 'j') // Check setting jog speed setting
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
                return;
            }
        }
        public delegate void CheckRunningData(uint Code, float Param);
        public CheckRunningData _CheckRunningData;
        public delegate void CheckSpeedTestParam(uint Code, float Param);
        public CheckSpeedTestParam _CheckSpeedTestParam;
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
          
        

        // User functions
        
        public void SetSampleTime(int _SampleTime)
        {
            SampleTime = _SampleTime;
            //timer2.Interval = SampleTime;
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

                if (!TorqueLimit) { lbTorqueLimit.BackColor = Color.Yellow; }
                else { lbTorqueLimit.BackColor = Color.Gray; }

                if (!Alarm) { lbAlarm.BackColor = Color.Gray; }
                else { lbAlarm.BackColor = Color.Yellow; }

                if (!CcwTorqueLimit) { lbCcwTorqueLimit.BackColor = Color.Yellow; }
                else { lbCcwTorqueLimit.BackColor = Color.Gray; }

                if (!CwTorqueLimit) { lbCwTorqueLimit.BackColor = Color.Yellow; }
                else { lbCwTorqueLimit.BackColor = Color.Gray; }

                if (!ZeroSpeedReach) { lbZeroSpeedReach.BackColor = Color.Lime; }
                else { lbZeroSpeedReach.BackColor = Color.Gray; }
            }
        }
        public bool GetBit(uint b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }              

        
        private void btnSetJogSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                JogSpeed = uint.Parse(txtSetSpeed.Text);
                if (Math.Abs(JogSpeed) >= 100)
                {
                    MessageBox.Show("Setting is out of range! (-100~100rpm)");
                }
                else
                {
                    string Command = "5" + "/" + JogSpeed.ToString();
                    SendMessage(Command);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input data type");
            }

        }
        private void GraphInit()
        {
            //GraphPane myPane = SpeedGraph.GraphPane;
            SpeedGraph.GraphPane.Title.Text = "Data";
            SpeedGraph.GraphPane.XAxis.Title.Text = "time (s)";
            SpeedGraph.GraphPane.YAxis.Title.Text = "Speed(rpm)";
            SpeedGraph.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            SpeedGraph.GraphPane.YAxis.Title.FontSpec.FontColor = Color.Red;

            SpeedGraph.GraphPane.XAxis.Scale.Min = 0;
            SpeedGraph.GraphPane.XAxis.Scale.Max = 10;
            SpeedGraph.GraphPane.XAxis.Scale.MinorStep = 1;
            SpeedGraph.GraphPane.XAxis.Scale.MajorStep = 5;
            SpeedGraph.GraphPane.YAxis.Scale.Min = -100;
            SpeedGraph.GraphPane.YAxis.Scale.Max = 100;

            
            SpeedGraph.GraphPane.Y2Axis.Title.Text = "Acc(m/s2)";
            SpeedGraph.GraphPane.Y2Axis.Scale.Min = -20;
            SpeedGraph.GraphPane.Y2Axis.Scale.Max = 2;
            SpeedGraph.GraphPane.Y2Axis.Scale.MinorStep = 2;
            SpeedGraph.GraphPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            SpeedGraph.GraphPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
            SpeedGraph.GraphPane.Y2Axis.IsVisible = true;

            SpeedGraph.GraphPane.IsAlignGrids = true;

            

            RollingPointPairList MotorSpeedList = new RollingPointPairList(60000);
            LineItem MotorSpeedCurve = SpeedGraph.GraphPane.AddCurve("Motor Speed", MotorSpeedList, Color.Red, SymbolType.None);
            MotorSpeedCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList SpdCmdList = new RollingPointPairList(60000); // speed command curve
            LineItem SpdCmdCurve = SpeedGraph.GraphPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
            SpdCmdCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList AccXList = new RollingPointPairList(60000);
            LineItem AccXCurve = SpeedGraph.GraphPane.AddCurve("AccX", AccXList, Color.Brown, SymbolType.None);
            AccXCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList AccYList = new RollingPointPairList(60000);
            LineItem AccYCurve = SpeedGraph.GraphPane.AddCurve("AccY", AccYList, Color.Black, SymbolType.None);
            AccYCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList AccZList = new RollingPointPairList(60000);
            LineItem AccZCurve = SpeedGraph.GraphPane.AddCurve("AccZ", AccZList, Color.Blue, SymbolType.None);
            AccZCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList AccRefList = new RollingPointPairList(60000);
            LineItem AccRefCurve = SpeedGraph.GraphPane.AddCurve("AccRef", AccRefList, Color.Green, SymbolType.None);
            AccRefCurve.Line.Width = (float)3; // Set LineWidth

            
            AccXCurve.IsY2Axis = true;
            AccYCurve.IsY2Axis = true;
            AccZCurve.IsY2Axis = true;

            AccRefCurve.IsY2Axis = true;

            SpeedGraph.GraphPane.AxisChange();
        }
        private void ProgressBarInit()
        {
            progressBar.Visible = false; // hide the progress bar
            progressBar.Minimum = 0;
            if (!RunningMode)
            {
                progressBar.Maximum = 1;
            }
            progressBar.Step = 1;
            progressBar.Value = 1;
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
            ws.Cells[1, 4] = "AccZ";
            ws.Cells[1, 5] = "Local Time";
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
            //string DataPath = FolderPath + index.ToString() + ".xlsx";
            try
            {
                wb.SaveAs(DataPath);
                wb.Close();
            }
            catch
            {
                MessageBox.Show("Saving Failed!");
            }

        }

        private void SaveToExcel(string DataPath)
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
            ws.Cells[1, 4] = "AccZ";
            ws.Cells[1, 5] = "Local Time";
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

            //string FullDataPath = DataPath + "\" + FileName;

            try
            {
                wb.SaveAs(DataPath);
                wb.Close();
            }
            catch
            {
                MessageBox.Show("Saving Failed!");
            }
        }
        private DateTime LocalTime;
        string TimeString;
        private void Data_Listview()
        {
            if (!GraphOn)
                return;
            else
            {                
                ListViewItem item = new ListViewItem(time.ToString()); // Gán biến realtime vào cột đầu tiên của ListView
                item.SubItems.Add(MotorSpeed.ToString());
                item.SubItems.Add(SpdCmdData.ToString());
                item.SubItems.Add(AccX.ToString());
                item.SubItems.Add(AccY.ToString());
                item.SubItems.Add(AccZ.ToString());
                item.SubItems.Add(AccRef.ToString());
                item.SubItems.Add(ObjectPosition.ToString());
                //LocalTime = DateTime.Now;

                TimeString = System.DateTimeOffset.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt");

                //item.SubItems.Add(LocalTime.ToString("h:mm:ss tt"));

                item.SubItems.Add(TimeString);

                listData.Items.Add(item); // Gán biến datas vào cột tiếp theo của ListView
                                          // Không nên gán string SDatas vì khi xuất dữ liệu sang Excel sẽ là dạng string, không thực hiện các phép toán được

                listData.Items[listData.Items.Count - 1].EnsureVisible(); // Hiện thị dòng được gán gần nhất ở ListView, tức là mình cuộn ListView theo dữ liệu gần nhất đó
            }
        }
        //private void Draw(double time, double speed, double spdcmd, double accelerationX, double accelerationY, double accelerationZ)
        private void Draw(double time, double speed, double spdcmd, double _AccZ, double _AccRef)
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

            if (AccZView)
            {
                LineItem AccZCurve = SpeedGraph.GraphPane.CurveList[2] as LineItem;
                if (AccZCurve == null) return;
                IPointListEdit AccZList = AccZCurve.Points as IPointListEdit;
                if (AccZList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccZCurve.IsY2Axis = true;
                AccZList.Add(time, _AccZ);
            }

            if (AccRefView)
            {
                LineItem AccRefCurve = SpeedGraph.GraphPane.CurveList[3] as LineItem;
                if (AccRefCurve == null) return;
                IPointListEdit AccRefList = AccRefCurve.Points as IPointListEdit;
                if (AccRefList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccRefCurve.IsY2Axis = true;
                AccRefList.Add(time, _AccRef);
            }


            Scale xScale = SpeedGraph.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (ViewMode) // SCROLL view Mode
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = time - xScale.MajorStep;
                }
                else // COMPACR view Mode
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            Scale Y1Scale = SpeedGraph.GraphPane.YAxis.Scale;
            Scale Y2Scale = SpeedGraph.GraphPane.Y2Axis.Scale;

            if (speed > Y1Scale.Max) // Auto scale the Speed axis
            {
                Y1Scale.Max = speed + 2*Y1Scale.MajorStep;
            }
            if (spdcmd > Y1Scale.Max) // Auto scale the Speed axis
            {
                Y1Scale.Max = spdcmd + 2*Y1Scale.MajorStep;
            }
            if (speed < Y1Scale.Min) // Auto scale the Speed axis
            {
                Y1Scale.Min = speed - 2*Y1Scale.MajorStep;
            }
            if (spdcmd < Y1Scale.Min) // Auto scale the Speed axis
            {
                Y1Scale.Min = spdcmd - 2*Y1Scale.MajorStep;
            }

            if (_AccZ > Y2Scale.Max)
            {
                Y2Scale.Max = _AccZ + 2 * Y2Scale.MajorStep;
            }
            if (_AccZ < Y2Scale.Min)
            {
                Y2Scale.Min = _AccZ - 2 * Y2Scale.MajorStep;
            }
            SpeedGraph.GraphPane.IsAlignGrids = true;
            SpeedGraph.AxisChange();
            SpeedGraph.Invalidate();
        }
        private void DrawAllData(double time, double speed, double spdcmd, double _AccX, double _AccY, double _AccZ, double _AccRef)
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

            if (AccZView)
            {
                // X axis
                LineItem AccXCurve = SpeedGraph.GraphPane.CurveList[2] as LineItem;
                if (AccXCurve == null) return;
                IPointListEdit AccXList = AccXCurve.Points as IPointListEdit;
                if (AccXList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccXCurve.IsY2Axis = true;
                AccXList.Add(time, _AccX);

                // Y axis
                LineItem AccYCurve = SpeedGraph.GraphPane.CurveList[3] as LineItem;
                if (AccYCurve == null) return;
                IPointListEdit AccYList = AccYCurve.Points as IPointListEdit;
                if (AccYList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccYCurve.IsY2Axis = true;
                AccYList.Add(time, _AccY);

                // Z axis
                LineItem AccZCurve = SpeedGraph.GraphPane.CurveList[4] as LineItem;
                if (AccZCurve == null) return;
                IPointListEdit AccZList = AccZCurve.Points as IPointListEdit;
                if (AccZList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccZCurve.IsY2Axis = true;
                AccZList.Add(time, _AccZ);                
            }

            if (AccRefView)
            {
                LineItem AccRefCurve = SpeedGraph.GraphPane.CurveList[5] as LineItem;
                if (AccRefCurve == null) return;
                IPointListEdit AccRefList = AccRefCurve.Points as IPointListEdit;
                if (AccRefList == null) return;
                //time = (Environment.TickCount - TickStart) / 1000.0;
                AccRefCurve.IsY2Axis = true;
                AccRefList.Add(time, _AccRef);
            }



            Scale xScale = SpeedGraph.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (ViewMode) // SCROLL view Mode
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = time - xScale.MajorStep;
                }
                else // COMPACR view Mode
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            Scale Y1Scale = SpeedGraph.GraphPane.YAxis.Scale;
            Scale Y2Scale = SpeedGraph.GraphPane.Y2Axis.Scale;

            if (speed > Y1Scale.Max) // Auto scale the Speed axis
            {
                Y1Scale.Max = speed + 2 * Y1Scale.MajorStep;
            }
            if (spdcmd > Y1Scale.Max) // Auto scale the Speed axis
            {
                Y1Scale.Max = spdcmd + 2 * Y1Scale.MajorStep;
            }
            if (speed < Y1Scale.Min) // Auto scale the Speed axis
            {
                Y1Scale.Min = speed - 2 * Y1Scale.MajorStep;
            }
            if (spdcmd < Y1Scale.Min) // Auto scale the Speed axis
            {
                Y1Scale.Min = spdcmd - 2 * Y1Scale.MajorStep;
            }

            if (_AccZ > Y2Scale.Max)
            {
                Y2Scale.Max = _AccZ + 2 * Y2Scale.MajorStep;
            }
            if (_AccZ < Y2Scale.Min)
            {
                Y2Scale.Min = _AccZ - 2 * Y2Scale.MajorStep;
            }
            SpeedGraph.GraphPane.IsAlignGrids = true;
            SpeedGraph.AxisChange();
            SpeedGraph.Invalidate();
        }
        private void TurnOnGraph()
        {
            try
            {
                InitSpdCmdBuffer();
                GraphOn = true;
                btnGraphOn.Text = "Graph OFF";
                //SendMessage("6/1"); // command to get the data
                timer2.Enabled = true;
                TickStart = Environment.TickCount;
                if (SpeedGraph.GraphPane.CurveList.Count <= 0) // Neu chua co duong Curve thi khoi tao
                {
                    RollingPointPairList MotorSpeedList = new RollingPointPairList(60000);
                    LineItem MotorSpeedCurve = SpeedGraph.GraphPane.AddCurve("Motor Speed", MotorSpeedList, Color.Red, SymbolType.None);
                    MotorSpeedCurve.Line.Width = (float)3; // Set LineWidth

                    RollingPointPairList SpdCmdList = new RollingPointPairList(60000); // speed command curve
                    LineItem SpdCmdCurve = SpeedGraph.GraphPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
                    SpdCmdCurve.Line.Width = (float)3; // Set LineWidth

                    RollingPointPairList AccXList = new RollingPointPairList(60000);
                    LineItem AccXCurve = SpeedGraph.GraphPane.AddCurve("AccX", AccXList, Color.Brown, SymbolType.None);
                    AccXCurve.Line.Width = (float)1.5; // Set LineWidth

                    RollingPointPairList AccYList = new RollingPointPairList(60000);
                    LineItem AccYCurve = SpeedGraph.GraphPane.AddCurve("AccY", AccYList, Color.Black, SymbolType.None);
                    AccYCurve.Line.Width = (float)1.5; // Set LineWidth

                    RollingPointPairList AccZList = new RollingPointPairList(60000);
                    LineItem AccZCurve = SpeedGraph.GraphPane.AddCurve("AccZ", AccZList, Color.Blue, SymbolType.None);
                    AccZCurve.Line.Width = (float)3; // Set LineWidth

                    RollingPointPairList AccRefList = new RollingPointPairList(60000);
                    LineItem AccRefCurve = SpeedGraph.GraphPane.AddCurve("AccRef", AccRefList, Color.Green, SymbolType.None);
                    AccRefCurve.Line.Width = (float)3; // Set LineWidth

                    RollingPointPairList PositionList = new RollingPointPairList(60000);
                    LineItem PositionCurve = SpeedGraph.GraphPane.AddCurve("Position", PositionList, Color.Pink, SymbolType.None);
                    AccZCurve.Line.Width = (float)2; // Set LineWidth

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
            ResetBuffer();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //SendMessage("12"  ); // 12 means request StE03 = Motor Speed
            timercount++;
            time = (timercount * timer2.Interval) / 1000.0;  // to seconds
            //Draw(time, MotorSpeed, SpdCommand, AccelerationX, AccelerationY, AccelerationZ);
            Draw(time, MotorSpeed, SpdCommand, AccZ, AccRef);
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
            //timer2.Interval = SampleTime; //ms Sample time 
            timercount = 0;
            time = 0;            

            SpeedGraph.GraphPane.CurveList.Clear(); // Xoa do thi

            //GraphInit(); // Reinitialize the Graph

            SpeedGraph.GraphPane.XAxis.Scale.Max = 10;
            SpeedGraph.GraphPane.XAxis.Scale.Min = 0;
            SpeedGraph.GraphPane.YAxis.Scale.Max = 100;
            SpeedGraph.GraphPane.YAxis.Scale.Min = -100;
            SpeedGraph.GraphPane.YAxis.Scale.MajorStep = 50;
            SpeedGraph.GraphPane.YAxis.Scale.MinorStep = 10;

            SpeedGraph.GraphPane.Y2Axis.Scale.Min = -20;
            SpeedGraph.GraphPane.Y2Axis.Scale.Max = 2;
            SpeedGraph.GraphPane.Y2Axis.Scale.MajorStep = 5;
            SpeedGraph.GraphPane.Y2Axis.Scale.MinorStep = 1;


            SpeedGraph.GraphPane.IsAlignGrids = true;

            RollingPointPairList MotorSpeedList = new RollingPointPairList(60000);
            LineItem MotorSpeedCurve = SpeedGraph.GraphPane.AddCurve("Motor Speed", MotorSpeedList, Color.Red, SymbolType.None);
            MotorSpeedCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList SpdCmdList = new RollingPointPairList(60000); // speed command curve
            LineItem SpdCmdCurve = SpeedGraph.GraphPane.AddCurve("Speed Command", SpdCmdList, Color.Orange, SymbolType.None);
            SpdCmdCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList AccXList = new RollingPointPairList(60000);
            LineItem AccXCurve = SpeedGraph.GraphPane.AddCurve("AccX", AccXList, Color.Brown, SymbolType.None);
            AccXCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList AccYList = new RollingPointPairList(60000);
            LineItem AccYCurve = SpeedGraph.GraphPane.AddCurve("AccY", AccYList, Color.Black, SymbolType.None);
            AccYCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList AccZList = new RollingPointPairList(60000);
            LineItem AccZCurve = SpeedGraph.GraphPane.AddCurve("AccZ", AccZList, Color.Blue, SymbolType.None);
            AccZCurve.Line.Width = (float)3; // Set LineWidth

            RollingPointPairList AccRefList = new RollingPointPairList(60000);
            LineItem AccRefCurve = SpeedGraph.GraphPane.AddCurve("AccRef", AccRefList, Color.Green, SymbolType.None);
            AccRefCurve.Line.Width = (float)3; // Set LineWidth

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
            serialPort1.Close();
            timer1.Enabled = false;
            timer2.Enabled = false;

            ResetGraph();
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
                //DisableJogControl();
            }
        }
        private void DisableJogControl()
        {
            //gbJogControl.Enabled = false;
            btnMoveDown.Enabled = false;
            btnMoveUp.Enabled = false;
            txtSetSpeed.Enabled = false;
            btnSetJogSpeed.Enabled = false;

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
        #endregion
        float SpdCmdData; // Speed command data
        float SpdData; // Speed data
        double PositionCmd;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            //SendMessage("12"  ); // 12 means request StE03 = Motor Speed
            //timercount++;
            //time = (timercount * timer2.Interval) / 1000.0;  // to seconds

            ////SpdCmdData = GetValueOutOfSpdCmdBuffer();
            ////SpdData = GetValueOutOfSpdBuffer();
            ////Draw(time, SpdData, SpdCmdData, AccZ, AccRef);
            ////DrawAllData(time, SpdData, SpdCmdData, AccX, AccY, AccZ, AccRef);

            //DrawAllData(time, MotorSpeed, SpdCommand, AccX, AccY, AccZ, AccRef);

            //if ((Application.OpenForms["_2ndDataGraph"] as _2ndDataGraph) != null) // Check if the form is opened or not
            //{
            //    DrawGyroAndDistance(time, 0, 0, 0, ObjectPosition, PositionCmd);
            //}
            
            //Data_Listview(); // view data to the list view

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
                    if (SimuOrRunning) // Simulation Mode
                    {
                        SendMessage("14/1");
                    }
                    else //Running Mode
                    {
                        SendMessage(StartRunning); // Send command to start running
                    }                    
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
            _ReSetGyroDisGraph();
        }

        private void btnResetAlarm_Click_1(object sender, EventArgs e)
        {            
            SendMessage(AlarmReset);
            IsEStop = false;
        }
        private volatile bool IsEStop;
        private void btnEstop_Click_1(object sender, EventArgs e)
        {
            SendMessage(ESTOP);

            DisableJogControl();
            
            IsEStop = true;
            if (btnStartDropping.Text == "START")
            {
                btnStartDropping.Enabled = false;
                btnStartDropping.BackColor = Color.LightGray;
            }
            //Console.WriteLine("> Emergency Stop");
        }
        private void InitSimulation()
        {
            TurnOnGraph(); // Turn on the graph
            WaitingBeforeRunning = true;                    

            DisableJogControl();
            btnHoming.Enabled = false;
            cbExperimentMode.Enabled = false;
            cbDriverType.Enabled = false;

            cbExperimentMode.Enabled = false;
            btnHoming.Enabled = false;

            btnStartDropping.Enabled = false;
        }
        private void InitExperiment()
        {
            SimuOrRunning = false; // Running cmd

            TurnOnGraph(); // Turn on the graph
            WaitingBeforeRunning = true;                      

            DisableJogControl();
            btnHoming.Enabled = false;
            cbExperimentMode.Enabled = false;
            cbDriverType.Enabled = false;
            btnStartDropping.BackColor = Color.Orange;
            btnStartDropping.Text = "STOP";

            cbExperimentMode.Enabled = false;
            btnHoming.Enabled = false;
        }

        TcpClient CmdClient;
        NetworkStream CmdClientStream;

        string ServerIP = "192.168.0.141";
        int PiServerPort = 5000;
        string StartMessage = "POST /recording HTTP/1.1";
        bool StartRecording;

        private bool ConnectToPi ()
        {
            try
            {
                CmdClient = new TcpClient(ServerIP, PiServerPort);
                return true;
            }
            catch
            {
                
            }
            return false;
        }
        private bool SendRecordingCmd ()
        {
            if (ConnectToPi()) // Connect successful
            {
                try
                {
                    int bytecount = Encoding.ASCII.GetByteCount(StartMessage + 1);
                    byte[] DataToSend = new byte[bytecount];
                    DataToSend = Encoding.ASCII.GetBytes(StartMessage);

                    CmdClientStream = CmdClient.GetStream();
                    CmdClientStream.WriteTimeout = 1000; 
                    CmdClientStream.Write(DataToSend, 0, DataToSend.Length);

                    StartRecording = !StartRecording;

                    if (StartRecording)
                    {
                        lbStartRecording.BackColor = Color.Lime;
                    }
                    else
                    {
                        lbStartRecording.BackColor = Color.Red;
                    }

                    CmdClientStream.Close();
                    CmdClient.Close();
                    CmdClient.Dispose();

                    return true;
                }
                catch
                {
                    MessageBox.Show("Check the connection");
                }
            }            
            return false;
        }
        private void btnStartDropping_Click_1(object sender, EventArgs e)
        {   
            // Checking conditions to start
            if (btnSimulate.Text == "Stop Init")
            {
                MessageBox.Show("Please Stop Init");
                return;
            }
            
            if(toggleServoEnable.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please Turn on Servo");
                return;
            }
            if(tongleDataOnOff.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please Turn on DATA");
                return;
            }

            // Start/Stop Experiment
            if (btnStartDropping.Text == "START") // if is not running > Start running
            {
                btnStartDropping.Text = "STOP";
                btnSimulate.Enabled = false;
                InitExperiment();
                return;
            }
            if (btnStartDropping.Text == "STOP") // if is not running > Start running
            {
                SendMessage(StopRunning);
                DialogResult Response;
                Response = MessageBox.Show("Do you want to Save the Data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Response == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //SaveToExcel(saveFileDialog1.FileName);
                        SaveDataToTxtFile(saveFileDialog1.FileName);
                        ResetGraph();
                        _ReSetGyroDisGraph();
                    }                    
                }
                else
                {
                    ResetGraph();
                    _ReSetGyroDisGraph();
                }
                
                btnStartDropping.BackColor = Color.Lime;
                btnStartDropping.Text = "START";

                EnableJogControl();

                btnSetJogSpeed.Enabled = true;
                
                btnHoming.Enabled = true;
                cbExperimentMode.Enabled = true;                
                
                cbDriverType.Enabled = true;
                btnSimulate.Enabled = true;
                return;
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            //Console.WriteLine("> Stop");
            SendMessage(STOP);
        }
        
        private void toggleServoEnable_CheckedChanged(object sender, EventArgs e)
        {
            
            if (toggleServoEnable.CheckState == CheckState.Checked) // Servo Enable ON
            {
                if (Alarm) // Require Reset Alarm before Servo ON
                {
                    MessageBox.Show("Reset Alarm is required!");
                    toggleServoEnable.CheckState = CheckState.Unchecked;
                    return;
                }
                else
                {
                    SendMessage("18/1");
                    EnableJogControl();
                    //btnSimulate.Enabled = false;
                    btnStartDropping.Enabled = true;
                    btnStartDropping.BackColor = Color.Lime;
                    btnHoming.Enabled = true;
                }                
            }
            else // Servo Enable OFF
            {
                if (IsEStop) // EStop is pressed
                {
                    return;
                }
                else
                {
                    SendMessage("18/0");                    
                    DisableJogControl();

                    btnSimulate.Enabled = true;
                    btnStartDropping.Enabled = false;
                    btnStartDropping.BackColor = Color.LightGray;

                    btnHoming.Enabled = false;
                }                
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
            //DialogResult traloi;
            //traloi = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if (traloi == DialogResult.OK)
            //{
            //    SaveToExcel(0); // Thực thi hàm lưu ListView sang Excel
            //}
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //SaveToExcel(saveFileDialog1.FileName); // Save to excel file

                SaveDataToTxtFile(saveFileDialog1.FileName);
            }
        }

        private void btnMoveDown_MouseDown_1(object sender, MouseEventArgs e)
        {            
            SendMessage(JogDown);
            //Console.WriteLine("> Jog Move Down");
        }

        private void btnMoveDown_MouseUp_1(object sender, MouseEventArgs e)
        {
            SendMessage(StopPulse); // Stop generating Pulses;
        }

        private void btnMoveUp_MouseDown_1(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("> Jog Move Up");
            SendMessage(JogUp);

        }

        private void btnMoveUp_MouseUp_1(object sender, MouseEventArgs e)
        {
            SendMessage(StopPulse); // Stop generating Pulses;                        
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
            

            //_ShowFeedbackDriverDataFrame = new ShowFeedbackDriverDataFrame(_ParamSetting.ShowDriverDataFrame);
            tongleDataOnOff.CheckState = CheckState.Unchecked;
            _ParamSetting.ShowDialog();            
        }

        private void cbReadOutputs_CheckedChanged_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
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
        }

        private void btnRstMcu_Click_1(object sender, EventArgs e)
        {
            DialogResult CheckCmd;
            CheckCmd = MessageBox.Show("Are you sure you want to Reset the MCU?\n Homing should be performed", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (CheckCmd == DialogResult.OK)
            {
                SendMessage("17"); // Reset MCU
                tongleDataOnOff.CheckState = CheckState.Unchecked;
                cbReadOutputs.CheckState = CheckState.Unchecked;
            }            
        }
               

        private void btnSetHome_Click(object sender, EventArgs e)
        {

            // Homing task
            if (btnStartDropping.Text == "STOP") // 
            {
                MessageBox.Show("System is Running. Please Stop Running and then homing");
                return;
            }
            if(tongleDataOnOff.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please TUNR ON DATA");
                return;
            }
            if (toggleServoEnable.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please TURN ON SERVO");
                return;
            }
            SendMessage("38/1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbExperimentMode.SelectedIndex == 0) // Dropping Mode
            {
                if (serialPort1.IsOpen)
                {
                    SendMessage("31/1");
                }

                ExperimentMode = 1;

            }
            if (cbExperimentMode.SelectedIndex == 1) // Pulling Mode
            {
                if (serialPort1.IsOpen)
                {
                    SendMessage("31/2");
                }                
                ExperimentMode = 2;
            }
            if (cbExperimentMode.SelectedIndex == 2) // Pulling Mode
            {
                if (serialPort1.IsOpen)
                {
                    SendMessage("31/3");
                }                
                ExperimentMode = 3;
            }
        }

        private void driverInputControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverInputControl _DriverInputControl = new DriverInputControl();
            _DriverInputControl._SendCommand = new DriverInputControl.SendCommand(SendMessage);
            _DriverInputControl.Show();
        }

        private void cbDriverType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDriverType.SelectedIndex == 0) // HIGEN FDA7000 Driver
            {
                MotorDriver = true;
                DrumRadius = (float)0.3;
                if (serialPort1.IsOpen)
                {
                    SendMessage("39/1");
                }                
            }
            else // ASDA-A3, small model
            {
                MotorDriver = false;
                DrumRadius = (float)0.05;
                SendMessage("39/0");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbAccZ.CheckState == CheckState.Checked)
            {
                AccZView = true;
            }
            else AccZView = false;
        }
        private void cbAccRef_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccRef.CheckState == CheckState.Checked)
            {
                AccRefView = true;
            }
            else AccRefView = false;
        }
        private void lb_com_status_Click(object sender, EventArgs e)
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

        // TCP Server variables

        private TcpClient client;
        private StreamReader STR;
        TcpListener listener;
        NetworkStream ns;
        string IpAddress;
        int Port;

        private const int ServerPort = 8000;
        UdpClient server;
        IPEndPoint endPoint;
        private bool ConnectToESP = false;

        private void ServerStart()
        {
            while (ConnectToESP)
            {
                try
                {
                    byte[] bytes = server.Receive(ref endPoint);
                    string ReceievedESPMess = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        try
                        {
                            DataByteRegion = ReceievedESPMess.Replace("a", null).Replace("e", null);
                            string[] ExtractAccelData = DataByteRegion.Split('/'); // split data frame
                            try
                            {
                                AccX = double.Parse(ExtractAccelData[0]) * 9.8 / 1000; // get acceleration value
                                AccY = double.Parse(ExtractAccelData[1]) * 9.8 / 1000; // get acceleration value
                                AccZData = Math.Round(double.Parse(ExtractAccelData[2]) * 9.8 / 1000, 2);
                                AccZ = AccZData;
                                if (ExtractAccelData.Length >= 4)
                                {
                                    // get acceleration value
                                    Temp = double.Parse(ExtractAccelData[3]);
                                    lbTemp.Text = Temp.ToString() + " C";
                                }

                                lbAccZ.Text = AccZ.ToString(); // Show on the Screen

                                DataByteRegion = "";
                            }
                            catch { }
                        }
                        catch { }

                    }));
                }
                catch (Exception ex)
                {

                }
            }
        }

        //string ServerReceivedMessage;
       
        bool IsServerOn;
        double AccX;
        double AccY;
        
        private bool CheckFormOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void ServerOn()
        {
            try
            {       

                listener.Start(); // Start listening for incoming connection request
                if (listener.Pending()) // There is a pending connection request
                {
                    client = listener.AcceptTcpClient();
                    ns = client.GetStream(); // network stream
                    STR = new StreamReader(client.GetStream());
                    backgroundWorker1.RunWorkerAsync(); //Start receiving data in background
                    backgroundWorker1.WorkerSupportsCancellation = true; // ability to cancel
                    
                    ScanClient = true;
                    listener.Stop();                    
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        private void ServerOff()
        {
            try
            {
                backgroundWorker1.CancelAsync();                
                client.Close();
                client.Dispose(); // dispose to null
                //client = null;
                listener.Stop();                
            }
            catch { }
        }

        private void togServerOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (togServerOnOff.CheckState == CheckState.Unchecked) // Server off
            {
                server.Close();
                server.Dispose();
                ConnectToESP = false;
                backgroundWorker1.CancelAsync();               

                //ServerOff();
                IsServerOn = false;
                
            }
            else
            {
                server = new UdpClient(ServerPort);
                endPoint = new IPEndPoint(IPAddress.Any, 0);
                ConnectToESP = true;

                backgroundWorker1.RunWorkerAsync();
                backgroundWorker1.WorkerSupportsCancellation = true; // ability to cancel

                //ServerOn();
                IsServerOn = true;
                timer1.Enabled = true;

                //System.Net.IPAddress ip = System.Net.IPAddress.Parse(lbServerIP.Text);
                //server.Start(ip, Port);
            }
        }
        
        string DataByteRegion = "";
       
        double AccZData;
        double Temp; // Temperature sensor       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ServerStart();            
        }

        SimpleTcpServer TCPserver;
        void InitTcpServer()
        {
            TCPserver = new SimpleTcpServer();
            TCPserver.Delimiter = 0x13;
            TCPserver.StringEncoder = Encoding.UTF8;
            TCPserver.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                string ServerReceivedMessage = e.MessageString.Replace("a", null).Replace("e", null);
                
                string[] ExtractAccelData = ServerReceivedMessage.Split('/'); // split data frame
                try
                {
                    AccX = double.Parse(ExtractAccelData[0]); // get acceleration value
                    AccY = double.Parse(ExtractAccelData[1]); // get acceleration value
                    AccZ = double.Parse(ExtractAccelData[2]); // get acceleration value                    
                }
                catch { }
                //e.MessageString = null;
            });
        }

        string Uart3ReceivedMessage;
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string TemperoryData = serialPort2.ReadExisting();
            Uart3ReceivedMessage += TemperoryData; // keep adding to the data
            if (Uart3ReceivedMessage[Uart3ReceivedMessage.Length - 1] == 'e') // read up to the ending character e
            {
                this.Invoke(new EventHandler(Uart3ProcessMessage));
                Uart3ReceivedMessage = null;
            }
        }

        private void Uart3ProcessMessage(object sender, EventArgs e)
        {
            Uart3ReceivedMessage = Uart3ReceivedMessage.Replace("\n", null).Replace("\r", null);
            try
            {
                AccZ = double.Parse(Uart3ReceivedMessage);
            }
            catch 
            {
                throw;
            }
        }
        private void SaveDataToTxtFile(string DataPath)
        {
            TextWriter writer = new StreamWriter(DataPath);
            int j = 1;
            foreach (ListViewItem comp in listData.Items)
            {                
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    if (j>=9)
                    {
                        writer.WriteLine(drv.Text.ToString());
                        j = 1;
                    }
                    else
                    {
                        writer.Write(drv.Text.ToString() + "$");
                        j++;
                    }                   
                }                
            }
            writer.Close(); //remember to close the file again.
            writer.Dispose(); //remember to dispose it from the memory.
        }
        private void openAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string[] datafield = line.Split('$');
                    try
                    {
                        double _time = double.Parse(datafield[0]);
                        double _Speed = double.Parse(datafield[1]);
                        double _RefSpd = double.Parse(datafield[2]);

                        double _AccX = double.Parse(datafield[3]);
                        double _AccY = double.Parse(datafield[4]);
                        double _AccZ = double.Parse(datafield[5]);
                        double _AccRef = double.Parse(datafield[6]);
                        double ObjectPos = double.Parse(datafield[7]);

                        DrawAllData(_time, _Speed, _RefSpd, _AccX, _AccY, _AccZ, _AccRef);
                        
                    }
                    catch
                    {  }
                    line = sr.ReadLine();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SendMessage("46/1"); // Set Origin Pulse Position
        }

        private void tongleDataOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (tongleDataOnOff.CheckState == CheckState.Checked)
            {
                PreviousTime = Environment.TickCount; // Initialize 
                SendMessage("6/1"); // Request data from MCU

            }
            else
            {
                SendMessage("6/0");
                lbMotorSpeed.Text = null;
                //lbEncoderPulses.Text = null;
                lbObjectPosition.Text = null;
                lbAccZ.Text = null;
            }
        }

        private void tongleSoftLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (tongleSoftLimit.CheckState == CheckState.Checked) // turn on the software limit
            {
                SendMessage("48/1"); // Request data from MCU
            }
            else
            {
                SendMessage("48/0"); // Request data from MCU
            }
        }

        private void gyroAndDisGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GyroAndDistGraph = new _2ndDataGraph();
            GyroAndDistGraph.Show();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            
            if (btnSimulate.Text == "Start Init") // Start Simulation
            {
                if (tongleDataOnOff.CheckState == CheckState.Unchecked)
                {
                    MessageBox.Show("Please TURN ON Data");
                    return;
                }

                {
                    DisableJogControl();
                    SimuOrRunning = true; // true = simulation, false = Start Running
                    InitSimulation();
                    btnSimulate.Text = "Stop Init";
                }
                return;
            }
            if (btnSimulate.Text == "Stop Init") // Stop Simulation
            {
                SendMessage("14/0");


                ResetGraph();
                btnSimulate.Text = "Start Init";

                EnableJogControl();

                btnSetJogSpeed.Enabled = true;
                btnStartDropping.Enabled = true;
                btnHoming.Enabled = true;
                cbExperimentMode.Enabled = true;                
                

                cbDriverType.Enabled = true;
                return;
            }
        }
        void StartSpeedTesting ()
        {
            ResetGraph();
            TurnOnGraph();
        }
        private void speedControlTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedControlTest _SpeedControlTest = new SpeedControlTest();
            _CheckSpeedTestParam = new CheckSpeedTestParam(_SpeedControlTest.CheckParams);
            _SpeedControlTest._SendCommand = new SpeedControlTest.SendCommand(SendMessage);
            _SpeedControlTest._StartTesting = new SpeedControlTest.StartTesting(StartSpeedTesting);
            _SpeedControlTest.Show();            
        }
    }
}

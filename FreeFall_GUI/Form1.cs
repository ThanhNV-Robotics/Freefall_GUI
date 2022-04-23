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


namespace FreeFall_GUI
{
    public partial class Form1 : Form
    {
        #region Variables

        public static Form1 instance;
        public Label CheckStatusLabel;

        private string ReceivedMessage;
        private string MessageToWrite;
        private string AccelDataToSend;

        COM_Config _COM_Config = new COM_Config();
        COM_Testing TestCOM = new COM_Testing();
        Main_Control _MainCOntrol = new Main_Control();

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        // Delegate to Send the collected data to the MainContol
        public delegate void SendData2MainControlForm(string data);
        public SendData2MainControlForm Pass2MainControl; // Create an instance 
        // Delegate to load the saved params to the ParamSetting Form
        public delegate void LoadDataToParamSettingForm(float _AccelerationTime, float MaxSpeed, float kp, float Ki, float AccRef);
        public LoadDataToParamSettingForm LoadData; // creat an instance
        #endregion

        public Form1()
        {
            InitializeComponent();
            instance = this;
            //Sender = new TransData(SendMessage);
        }
 
        #region Button Callback
        private void btn_connect(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("6.0/0.0" + "$");
                    lb_com_status.Text = serialPort1.PortName + " is connected";
                    lb_com_status.BackColor = Color.Green;
                    timer1.Enabled = true;
                    gb_System_Check.Enabled = true;
                    btnTestCOM.Enabled = true;
                    btn_com_config.Enabled = false;
                    
                    /*serialPort1.WriteTimeout = 200;
                    serialPort1.Write("Initializing"+"$");
                    serialPort1.Write("Initializing"+"$");*/

                }
                //else
                //{
                //    lb_com_status.Text = serialPort1.PortName + "is connected";
                //    lb_com_status.BackColor = Color.Red;
                //}
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
 
        public void TestSendMessage(string message)
        {            
            serialPort1.Write(message); //$ is the ending character
            serialPort1.WriteTimeout = 500;
            // 1 is the function code, means testing communication
        }
        //public delegate void COMTestShowMessage (string message)
 

        private void btnTestCOM_Click(object sender, EventArgs e)
        {
            //COM_Testing TestCOM = new COM_Testing();
            TestCOM._Sender = new COM_Testing.SendMessage(SendMessage);
            TestCOM.ShowDialog();
        }
        private void cb_com_comport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cb_com_comport.SelectedItem.ToString();
                btn_com_config.Enabled = true;
                btn_com_connect.Enabled = true;
                btn_com_disconnect.Enabled = true;
            }
            catch (Exception)
            {
               
            }
            
        }
        private void btn_com_refresh_Click(object sender, EventArgs e)
        {
            cb_com_comport.Items.Clear();
            cb_com_comport.Text = null;
            string[] port = SerialPort.GetPortNames();
            if ((port == null) || (port.Length == 0))
            {
                lb_com_status.Text = "No COM is found";
                lb_com_status.BackColor = Color.Yellow;
                btn_com_config.Enabled = false;
                btn_com_connect.Enabled = false;
                btn_com_disconnect.Enabled = false;
            }
            else
            {
                lb_com_status.Text = "A COM is found";
                cb_com_comport.Items.AddRange(port);
                lb_com_status.BackColor = Color.Yellow;
            }
        }
        private void btn_com_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                if (!serialPort1.IsOpen)
                {
                    lb_com_status.BackColor = Color.Red;
                    lb_com_status.Text = serialPort1.PortName + " is disconnected";
                    btn_com_config.Enabled = true;
                    btn_com_connect.Enabled = true;
                    btn_com_disconnect.Enabled = true;
                    btnTestCOM.Enabled = false;
                    gb_System_Check.Enabled = false;
                    //btn_com_config.Enabled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_com_config_Click(object sender, EventArgs e)
        {
            
            _COM_Config.lb_com_name.Text = cb_com_comport.SelectedItem.ToString();
            _COM_Config._SetParam = new COM_Config.SetParam(SetCOMParam);
            _COM_Config.ShowDialog();
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
        private void button1_Click(object sender, EventArgs e) // Main control button callback
        {
            _MainCOntrol.SendCommand = new Main_Control._SendCommand(SendMessage); // Set the delegate to SendMessage()
            _MainCOntrol.SendAccZ = new Main_Control._SendAccZ(SendAccZData);
            // Assign the delegate to the function of the MainControl Form
            Pass2MainControl = new SendData2MainControlForm(_MainCOntrol.ProcessMessage); 

            if (_MainCOntrol.IsDisposed)
            {
                _MainCOntrol = new Main_Control();
                _MainCOntrol.SendCommand = new Main_Control._SendCommand(SendMessage); // Set the delegate to SendMessage()
                _MainCOntrol.SendAccZ = new Main_Control._SendAccZ(SendAccZData);
                Pass2MainControl = new SendData2MainControlForm(_MainCOntrol.ProcessMessage);
                _MainCOntrol.Show();
                return;
            }

            if (!IsFormOpen(_MainCOntrol)) // Check if form is openned or not
            {
                try
                {
                    //serialPort1.Write("6.0/1.0" + "$"); request speed data
                    _MainCOntrol.Show();
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.ToString());
                }
            }
            else
            {
                _MainCOntrol.BringToFront();
            }
        }
        #endregion

        #region Function
        public void SendMessage(string message) // Function to send a message to STM32
        {
            MessageToWrite = message;
        }
        public void SendAccZData(float AccZ)
        {
            string AccData2Send = "9" + "/" + AccZ.ToString() +"$";
            serialPort1.Write(AccData2Send); // r is the funtion code
        } 
        public void SetCOMParam (int _BauRate, int _DataBits, string _StopBits, string _Parity)
        {
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
            string COM_Param = @serialPort1.PortName + "/"
                               + serialPort1.BaudRate.ToString() + "/"
                               + serialPort1.DataBits.ToString() + "/"
                               + serialPort1.StopBits.ToString() + "/"
                               + serialPort1.Parity.ToString();
            lb_com_status.Text = COM_Param;                
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_com_config.Enabled = false;
            btn_com_connect.Enabled = false;
            btn_com_disconnect.Enabled = false;
            //gb_System_Check.Enabled = false;
            btnTestCOM.Enabled = false;

            //serialPort1.PortName = cb_com_comport.Text;
            serialPort1.BaudRate = 9600; // default value
            serialPort1.DataBits = 8; // default value
            serialPort1.StopBits = StopBits.One;// default value
            serialPort1.Parity = Parity.None;// default value

            string[] port = SerialPort.GetPortNames();
            if ((port == null) || (port.Length == 0))
            {
                lb_com_status.Text = "No COM is found";
                lb_com_status.BackColor = Color.Red;
            }
            else
            {
                lb_com_status.Text = "A COM is found";
                cb_com_comport.Items.AddRange(port);
                lb_com_status.BackColor = Color.Yellow;
            }
            
        }
        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                lb_com_status.BackColor = Color.Red;
                lb_com_status.Text = "COM is disconnected";
                btn_com_config.Enabled = false;
                btn_com_connect.Enabled = false;
                btn_com_disconnect.Enabled = false;
                btnTestCOM.Enabled = false;

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
            if (IsFormOpen(_MainCOntrol))
            {
                Pass2MainControl(ReceivedMessage);
            }
            
            if (ReceivedMessage[0] == 'r') // r meean running parameters, check the running parameters
            {
                ReceivedMessage = (ReceivedMessage.Replace("r", null)).Replace("e", null); // remove the character s in the string
                string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string
                float[] RunningParamInt = new float[5];
                try
                {
                    for (int i = 0; i < RunningParamInt.Length; i++)
                    {
                        RunningParamInt[i] = float.Parse(RunningParamString[i]);
                    }
                    _CheckRunningData(RunningParamInt[0], RunningParamInt[1], RunningParamInt[2], RunningParamInt[3], RunningParamInt[4]); // Check if setting is done or not
                }
                catch (Exception)
                {
                  
                }                
            }
            if (ReceivedMessage[0] == 'p') // Load running (controller params)
            {
                ReceivedMessage = (ReceivedMessage.Replace("p", null)).Replace("e", null); // remove the character s in the string
                string[] RunningParamString = ReceivedMessage.Split('/'); // Split the string
                float[] RunningParamFloat = new float[5];
                try
                {
                    for (int i = 0; i < RunningParamFloat.Length; i++)
                    {
                        RunningParamFloat[i] = float.Parse(RunningParamString[i]);
                    }
                    LoadData(RunningParamFloat[0], RunningParamFloat[1], RunningParamFloat[2], RunningParamFloat[3], RunningParamFloat[4]); // Load the data
                }
                catch (Exception)
                {

                }
            }
        }
        public delegate void CheckRunningData(float AccelerationTime, float MaxSpeed, float Kp, float Ki, float AccRef);
        public CheckRunningData _CheckRunningData;
        private void btn_check_start_Click(object sender, EventArgs e)
        {
            ParamSetting _ParamSetting = new ParamSetting();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (MessageToWrite != null)
            {
                try
                {
                    serialPort1.WriteTimeout = 500;
                    serialPort1.Write(MessageToWrite);
                    MessageToWrite = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("Check the communication");
                    //throw;
                }
            }
            if (AccelDataToSend != null)
            {
                try
                {
                    serialPort1.WriteTimeout = 500;
                    serialPort1.Write(AccelDataToSend);
                    AccelDataToSend = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("Check the communication");
                    //throw;
                }
            }
        }
    }
}

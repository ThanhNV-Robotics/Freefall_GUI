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
namespace FreeFall_GUI
{

    public partial class ParamSetting : Form
    {
        private float AccelerationTime;
        private float MaxSpeed;
        private float Kp;
        private float Ki;
        private float AccRef;
        private uint SampleTime;
        // delegate to set parameters using serialport1 of the main UI
        
        public delegate void SendCommand(string Command);

        //public SetParameters _SetParameters;
        public SendCommand _SendCommand;
        public ParamSetting()
        {
            InitializeComponent();
        }
        public void SetParameters(float AccelerationTime, float MaxSpeed, float Kp, float Ki)
        {
            string Param2Send = "7" + "/" + AccelerationTime.ToString() + "/" + MaxSpeed.ToString() + "/" + Kp.ToString()+ "/" + Ki.ToString() + "$";

            _SendCommand(Param2Send); // 7 is the function code, means set params
        }

        public void LoadSavedParams (float _AccelerationTime, float _MaxSpeed, float _Kp, float _Ki, float _AccRef, uint _SampleTime)
        {
            AccelerationTime = _AccelerationTime;
            MaxSpeed = _MaxSpeed;
            Kp = _Kp;
            Ki = _Ki;
            AccRef = _AccRef;
            SampleTime = _SampleTime;

            txtAcclerationTime.Text = AccelerationTime.ToString();
            txtMaxSpeed.Text = MaxSpeed.ToString();
            txtKp.Text = Kp.ToString();
            txtKi.Text = Ki.ToString();
            txtAccRef.Text = AccRef.ToString();
            txtSampleTime.Text = SampleTime.ToString();
        }
        public void CheckParams(uint ParamCode, float Param)
        {
            switch (ParamCode)
            {
                case 7:
                    MessageBox.Show("Saving Done!");
                    break;
                case 11:
                    if (AccelerationTime == Param)
                    {
                        MessageBox.Show("Successfully Set Acceleration Time");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 12:
                    if (MaxSpeed == Param)
                    {
                        MessageBox.Show("Successfully Set MaxSpeed");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 13:
                    if (Kp == Param)
                    {
                        MessageBox.Show("Successfully Set Kp");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 14:
                    if (Ki == Param)
                    {
                        MessageBox.Show("Successfully Set Kp");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 15:
                    if (AccRef == Param)
                    {
                        MessageBox.Show("Successfully Set Reference Acceleration");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 16:
                    if (SampleTime == Param)
                    {
                        MessageBox.Show("Successfully Set Sample Time");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                default:
                    break;
            }
        }
        private void SetLineHeight()
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 24);// Set the width and height of ImageList
            lstParam.SmallImageList = imgList;
        }
        private void System_Check_Load(object sender, EventArgs e)
        {
            // Visualize parameter
            SetLineHeight();
            lstParam.FullRowSelect = true;
            lstParam.GridLines = true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _SendCommand("7" + "$");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _SendCommand("10" + "$");
        }

        private void btnAccTimeSet_Click(object sender, EventArgs e)
        {
            try
            {
                AccelerationTime = float.Parse(txtAcclerationTime.Text);
                _SendCommand("11" + "/" + AccelerationTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnMaxSpdSet_Click(object sender, EventArgs e)
        {
            try
            {
                MaxSpeed = float.Parse(txtMaxSpeed.Text);
                _SendCommand("12" + "/" + MaxSpeed.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnKpSet_Click(object sender, EventArgs e)
        {
            try
            {
                Kp = float.Parse(txtKp.Text);
                _SendCommand("13" + "/" + Kp.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnKiSet_Click(object sender, EventArgs e)
        {
            try
            {
                Ki = float.Parse(txtKi.Text);
                _SendCommand("14" + "/" + Ki.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnRefAccSet_Click(object sender, EventArgs e)
        {
            try
            {
                AccRef = float.Parse(txtAccRef.Text);
                _SendCommand("15" + "/" + AccRef.ToString() +  "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        public delegate void SetSampleTime(int _SampleTime);
        public SetSampleTime _SetSampleTime;

        private void btnSampleTimeSet_Click(object sender, EventArgs e)
        {
            try
            {
                SampleTime = uint.Parse(txtSampleTime.Text);
                _SetSampleTime((int)SampleTime); // Set Sample Time for data recording => MainControl form, timer1 interval
                _SendCommand("16" + "/" + SampleTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
    }
}

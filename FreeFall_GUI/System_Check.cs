﻿using System;
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
        private float DrumRadius;
        private float MaxDistance;
        private float Kp;
        private float Ki;
        private float AccRef;
        private uint SampleTime;
        private float FloatFeedbackValue;
        private int IntFeedbackValue;
        // delegate to set parameters using serialport1 of the main UI
        
        public delegate void SendCommand(string Command);

        //public SetParameters _SetParameters;
        public SendCommand _SendCommand;
        public ParamSetting()
        {
            InitializeComponent();
        }
        public void SetParameters(float DrumRadius, float MaxDistance, float Kp, float Ki)
        {
            string Param2Send = "7" + "/" + DrumRadius.ToString() + "/" + MaxDistance.ToString() + "/" + Kp.ToString()+ "/" + Ki.ToString() + "$";

            _SendCommand(Param2Send); // 7 is the function code, means set params
        }

        public void LoadSavedParams (float _DrumRadius, float _MaxDistance, float _Kp, float _Ki, float _AccRef, uint _SampleTime)
        {
            DrumRadius = _DrumRadius;
            MaxDistance = _MaxDistance;
            Kp = _Kp;
            Ki = _Ki;
            AccRef = _AccRef;
            SampleTime = _SampleTime;

            txtDrumRadius.Text = DrumRadius.ToString();
            txtMaxDistance.Text = MaxDistance.ToString();
            txtKp.Text = Kp.ToString();
            txtKi.Text = Ki.ToString();
            txtAccRef.Text = AccRef.ToString();
            txtSampleTime.Text = SampleTime.ToString();
        }
        public void ShowDriverDataFrame (string DataFrame)
        {
            lbFeedbackFrame.Text = DataFrame;
            string[] SplitDataFrame = DataFrame.Split('/'); // Split the string
            byte[] DataByte = new byte[4];
            try
            {
                DataByte[0] = byte.Parse(SplitDataFrame[7]);
                DataByte[1] = byte.Parse(SplitDataFrame[6]);
                DataByte[2] = byte.Parse(SplitDataFrame[5]);
                DataByte[3] = byte.Parse(SplitDataFrame[4]);

                FloatFeedbackValue = System.BitConverter.ToSingle(DataByte,0);
                IntFeedbackValue = System.BitConverter.ToInt32(DataByte, 0);

                lbFeedbackValueFloat.Text = FloatFeedbackValue.ToString();
                lbFeedbackValueInt.Text = IntFeedbackValue.ToString();
            }
            catch
            { return;   }

            string Register = cbRegister.SelectedItem.ToString();
            string[] ExtractRegister = Register.Split('-'); // Split the string
            try
            {
                string DataType = ExtractRegister[3];                

                if (DataType == "Float") // Float Type
                {
                    float SettingValue = float.Parse(txtSetingValue.Text);
                    if (FloatFeedbackValue == SettingValue)
                    {
                        MessageBox.Show("Setting is successful");
                    }
                }
                if (DataType == "Int") // Int type
                {
                    float SettingValue = int.Parse(txtSetingValue.Text);
                    if (IntFeedbackValue == SettingValue)
                    {
                        MessageBox.Show("Setting is successful");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data");
            }
        }
        public void CheckParams(uint ParamCode, float Param)
        {
            switch (ParamCode)
            {
                case 7:
                    MessageBox.Show("Saving Done!");
                    break;
                case 11:
                    if (DrumRadius == Param)
                    {
                        MessageBox.Show("Successfully Set the Drum Radius");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 12:
                    if (MaxDistance == Param)
                    {
                        MessageBox.Show("Successfully Set MaxDistance");
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

        private void btnDrumRadiusSet_Click(object sender, EventArgs e)
        {
            try
            {
                DrumRadius = float.Parse(txtDrumRadius.Text);
                _SendCommand("11" + "/" + DrumRadius.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        private void btnMaxDistSet_Click(object sender, EventArgs e)
        {
            try
            {
                MaxDistance = float.Parse(txtMaxDistance.Text);
                _SendCommand("12" + "/" + MaxDistance.ToString() + "$");
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
                _SendCommand("16" + "/" + SampleTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetDriverParam_Click(object sender, EventArgs e)
        {
            string Register = cbRegister.SelectedItem.ToString();
            string[] ExtractRegister = Register.Split('-'); // Split the string
            try
            {
                int Address = int.Parse(ExtractRegister[2]);
                string DataType = ExtractRegister[3];
                float MinValue = float.Parse(ExtractRegister[4]);
                float MaxValue = float.Parse(ExtractRegister[5]);

                if (DataType == "Float") // Float Type
                {
                    try
                    {
                        float SettingValue = float.Parse(txtSetingValue.Text);
                        if (SettingValue > MaxValue || SettingValue < MinValue) // Out of range
                        {
                            MessageBox.Show("Setting range is between: " + MinValue.ToString() + " and " + MaxValue.ToString());
                        }
                        else
                        {
                            _SendCommand("30/1/" + Address.ToString() + "/" + SettingValue.ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input Data Type");
                    }
                }
                if (DataType == "Int") // Int type
                {
                    try
                    {
                        int SettingValue = int.Parse(txtSetingValue.Text);
                        if (SettingValue > (int)MaxValue || SettingValue < (int)MinValue) // Out of range
                        {
                            MessageBox.Show("Setting range is between: " + MinValue.ToString() + " and " + MaxValue.ToString());
                        }
                        else
                        {
                            _SendCommand("30/0/" + Address.ToString() + "/" + SettingValue.ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input Data Type");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Register");
            }
        }
    }
}

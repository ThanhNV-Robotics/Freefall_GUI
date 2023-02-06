using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeFall_GUI
{
    public partial class DriverSetingParams : Form
    {
        public DriverSetingParams()
        {
            InitializeComponent();
        }
        /*
        public void ShowDriverDataFrame(string DataFrame)
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

                FloatFeedbackValue = System.BitConverter.ToSingle(DataByte, 0);
                IntFeedbackValue = System.BitConverter.ToInt32(DataByte, 0);

                lbFeedbackValueFloat.Text = FloatFeedbackValue.ToString();
                lbFeedbackValueInt.Text = IntFeedbackValue.ToString();
            }
            catch
            { return; }

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
        }*/
    }
}

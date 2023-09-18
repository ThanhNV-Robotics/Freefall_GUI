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
    public partial class SpeedControlTest : Form
    {
        public delegate void SendCommand(string Command);
        //public SetParameters _SetParameters;
        public SendCommand _SendCommand;

        public delegate void StartTesting();
        public StartTesting _StartTesting;

        public SpeedControlTest()
        {
            InitializeComponent();
        }
        public void CheckParams(uint ParamCode, float Param)
        {
            switch (ParamCode)
            {
                case 61:
                    if (Param == float.Parse(txtMaxSpd.Text))
                    {
                        MessageBox.Show("Setting Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed");
                    }
                    break;
                case 62:
                    if (Param == float.Parse(txtAccelTime.Text))
                    {
                        MessageBox.Show("Setting Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed");
                    }
                    break;
                case 63:
                    if (Param == float.Parse(txtDecelTime.Text))
                    {
                        MessageBox.Show("Setting Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed");
                    }
                    break;
                case 64:
                    if (Param == float.Parse(txtHoldOnTime.Text))
                    {
                        MessageBox.Show("Setting Done");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed");
                    }
                    break;
                default: break;
            }
        }
        private void btnSetMaxSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                uint MaxTestSpeed = uint.Parse(txtMaxSpd.Text);

                _SendCommand("61/" + MaxTestSpeed.ToString() + "$");
            }
            catch
            {

                MessageBox.Show("Invalid Input data type");
            }            
        }
        private void btnSetAccelTime_Click(object sender, EventArgs e)
        {
            try
            {
                uint AccelTime = uint.Parse(txtAccelTime.Text);

                _SendCommand("62/" + AccelTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input data type");
            }
        }
        private void btnSetDecelTime_Click(object sender, EventArgs e)
        {
            try
            {
                uint DeccelTime = uint.Parse(txtDecelTime.Text);

                _SendCommand("63/" + DeccelTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input data type");
            }
        }
        private void btnHoldOnTime_Click(object sender, EventArgs e)
        {
            try
            {
                uint HoldOnTime = uint.Parse(txtHoldOnTime.Text);

                _SendCommand("64/" + HoldOnTime.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input data type");
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START") // Start the test
            {
                _SendCommand("69/1" + "$");
                _StartTesting();

                btnStart.Text = "STOP";
                btnStart.BackColor = Color.Orange;
                return;
            }
            if (btnStart.Text == "STOP")
            {
                _SendCommand("69/0" + "$");
                btnStart.Text = "START";
                btnStart.BackColor = Color.Lime;
                return;
            }
        }       

        private void SpeedControlTest_Load(object sender, EventArgs e)
        {
            txtAccelTime.Text = "4";
            txtDecelTime.Text = "4";
            txtHoldOnTime.Text = "2";
            txtMaxSpd.Text = "0";
        }
    }
}

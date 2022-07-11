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
    public partial class DriverInputControl : Form
    {
        public DriverInputControl()
        {
            InitializeComponent();
        }
        public delegate void SendCommand (string cmd);
        public SendCommand _SendCommand;
        private void ControlDriverInputPanel(bool _ControlMode)
        {
            if (_ControlMode) // Position Mode
            {
                lbCN1_13.Visible = true;
                lbCN1_13.Text = "CCWLIM-CN1 13";
                togleCN1_13.Visible = true;

                lbCN1_14.Visible = true;
                lbCN1_14.Text = "PLSCLR-CN1 14";
                togleCN1_14.Visible = true;

                lbCN1_15.Visible = true;
                lbCN1_15.Text = "SP/T LIM-CN1 15";
                togleCN1_15.Visible = true;

                lbCN1_38.Visible = true;
                lbCN1_38.Text = "CWLIM-CN1 38";
                togleCN1_38.Visible = true;

                lbCN1_39.Visible = true;
                lbCN1_39.Text = "PLSINH-CN1 39";
                togleCN1_39.Visible = true;

                lbCN1_40.Visible = true;
                lbCN1_40.Text = "DIR-CN1 40";
                togleCN1_40.Visible = true;
            }
            else // Speed Mode
            {
                lbCN1_13.Visible = true;
                lbCN1_13.Text = "CWLIM-CN1 13";

                lbCN1_14.Visible = true;
                lbCN1_14.Text = "DIR-CN1 14";

                lbCN1_15.Visible = false;
                togleCN1_15.Visible = false;


                lbCN1_38.Visible = true;
                lbCN1_38.Text = "SPDLIM-CN1 38";

                lbCN1_39.Visible = true;
                lbCN1_39.Text = "CCWLIM-CN1 39";

                lbCN1_40.Visible = false;
                togleCN1_40.Visible = false;
            }
        }
        #region Tongle Functions
        // tongle functions
        private void togleCN1_14_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_14.CheckState == CheckState.Checked)
            {
                _SendCommand("21/1");
            }
            else
            {
                _SendCommand("21/0");
            }
        }

        private void togleCN1_15_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_15.CheckState == CheckState.Checked)
            {
                _SendCommand("22/1");
            }
            else
            {
                _SendCommand("22/0");
            }
        }

        private void togleCN1_39_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_39.CheckState == CheckState.Checked)
            {
                _SendCommand("23/1");
            }
            else
            {
                _SendCommand("23/0");
            }
        }

        private void togleCN1_38_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_38.CheckState == CheckState.Checked)
            {
                _SendCommand("24/1");
            }
            else
            {
                _SendCommand("24/0");
            }
        }

        private void togleCN1_13_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_13.CheckState == CheckState.Checked)
            {
                _SendCommand("25/1");
            }
            else
            {
                _SendCommand("25/0");
            }
        }

        private void togleCN1_40_CheckedChanged(object sender, EventArgs e)
        {
            if (togleCN1_40.CheckState == CheckState.Checked)
            {
                _SendCommand("26/1");
            }
            else
            {
                _SendCommand("26/0");
            }
        }
        #endregion
    }
}

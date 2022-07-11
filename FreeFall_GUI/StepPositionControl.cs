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
    public partial class StepPositionControl : Form
    {
        public StepPositionControl()
        {
            InitializeComponent();
        }

        public delegate void SendCommand(string Command); // delegate to send Message
        public SendCommand _SendCommand;
        private void StepPositionControl_Load(object sender, EventArgs e)
        {

        }
        
        public delegate int GetCurrentPosition();
        public GetCurrentPosition _GetCurrentPosition;
        private void btnSetPulseCmd_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentPositionPulse = _GetCurrentPosition();
                int PositionPulseCmd = int.Parse(txtPulseCmd.Text);

                int DeltaPulseCmd = (PositionPulseCmd - CurrentPositionPulse);

                if (DeltaPulseCmd >= 0) // CW direction
                {
                    _SendCommand("20/1/" + DeltaPulseCmd.ToString()); // 1 mean CW dir
                }
                else // CCW Direction
                {
                    _SendCommand("20/0/" + DeltaPulseCmd.ToString()); // 0 mean CCW dir
                }
                
            }
            catch 
            {
                MessageBox.Show("Invalid Input Data Type");
            }
        }
    }
}

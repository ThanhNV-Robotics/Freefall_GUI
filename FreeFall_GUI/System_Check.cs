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
using System.IO;
namespace FreeFall_GUI
{

    public partial class ParamSetting : Form
    {
        private float DrumRadius;
        private float DroppingDistance;
        private UInt16 PullingSpeed;
        private UInt16 StoppingTime;
       
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
        public void SetParameters(float DrumRadius, UInt16 DroppingDistance, UInt16 PullingSpeed, UInt16 StoppingTime)
        {
            string Param2Send = "7" + "/" + DrumRadius.ToString() + "/" + DroppingDistance.ToString() + "/" + PullingSpeed.ToString()+ "/" + StoppingTime.ToString() + "$";

            _SendCommand(Param2Send); // 7 is the function code, means set params
        }

        public void LoadSavedParams (float[]Params)
        {
            // General Params
            DrumRadius = Params[0];            
            PullingSpeed = (UInt16)Params[1];
            StoppingTime = (UInt16)Params[2];
            SampleTime = (uint)Params[3];

            DroppingAccelDistance = (double)Params[4];
            DroppingAccel = Params[5];
            DroppingDecel = Params[6];

            PullingAccelDistance = Params[7];
            PullingAccel = Params[8];
            PullingDecel = Params[9];

            //PID controller Params
            Kp = Params[10];
            Ki = Params[11];
            Kd = Params[12];

            txtDrumRadius.Text = DrumRadius.ToString();
            txtPullingSpeed.Text = PullingSpeed.ToString();
            txtStoppingTime.Text = StoppingTime.ToString();
            txtSampleTime.Text = SampleTime.ToString();

            txtDroppingAccelDistance.Text = DroppingAccelDistance.ToString();           
            txtDroppingAccRef.Text = DroppingAccel.ToString();
            txtDropDecel.Text = DroppingDecel.ToString();

            txtAccelPullingDistance.Text = PullingAccelDistance.ToString();
            txtPullingAccRef.Text = PullingAccel.ToString();
            txtPullingDecel.Text = PullingDecel.ToString();

            txtKp.Text = Kp.ToString();
            txtKi.Text = Ki.ToString();
            txtKd.Text = Kd.ToString();
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
                    if (DroppingDistance == Param)
                    {
                        MessageBox.Show("Successfully Set DroppingDistance");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 13:
                    if (PullingSpeed == Param)
                    {
                        MessageBox.Show("Successfully Set PullingSpeed");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 37:
                    if (StoppingTime == Param)
                    {
                        MessageBox.Show("Successfully Set PullingSpeed");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 15:
                    if (DroppingAccel == Param)
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
                case 32:
                    if (PullingAccelDistance == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling Distance");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 33:
                    if (PullingAccel == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling AccRef");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 34:
                    if (DroppingDecel == Param)
                    {
                        MessageBox.Show("Successfully Set Dropping Decceleration");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 35:
                    if (PullingDecel == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling Decceleration");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 41:
                    if (Kp == Param)
                    {
                        MessageBox.Show("Successfully Set Kp");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed!");
                    }
                    break;
                case 42:
                    if (Ki == Param)
                    {
                        MessageBox.Show("Successfully Set Ki");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed!");
                    }
                    break;
                case 43:
                    if (Kd == Param)
                    {
                        MessageBox.Show("Successfully Set Kd");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed!");
                    }
                    break;
                //case 36:
                //    if (PD_DroppingAccRef == Param)
                //    {
                //        MessageBox.Show("Successfully Set PD_DroppingAccRef");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Setting Failed! Set Again");
                //    }
                //    break;

                //case 41:
                //    if (kbrake == Param)
                //    {
                //        MessageBox.Show("Successfully Set kbrake");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Setting Failed! Set Again");
                //    }
                //    break;
                default:
                    break;
            }
        }
        
        private void System_Check_Load(object sender, EventArgs e)
        {
            MOb = 5; // kg
            Jd = 2.9; // kgm2
            Fs = 1.2;

            txtJd.Text = Jd.ToString();
            txtMOb.Text = MOb.ToString();
            txtFs.Text = Fs.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _SendCommand("7" + "$");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _SendCommand("45/1" + "$");
        }
        public delegate void SetDrumRadius(float radius);
        public SetDrumRadius _SetDrumRadius;
        private void btnDrumRadiusSet_Click(object sender, EventArgs e)
        {
            try
            {
                DrumRadius = float.Parse(txtDrumRadius.Text);
                _SetDrumRadius(DrumRadius);
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
                DroppingDistance = float.Parse(txtDroppingAccelDistance.Text);
                _SendCommand("12" + "/" + DroppingDistance.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        private void btnPullingSpeedSet_Click(object sender, EventArgs e)
        {
            try
            {
                PullingSpeed = UInt16.Parse(txtPullingSpeed.Text);
                if (PullingSpeed > 0 && PullingSpeed < 1000)
                {
                   _SendCommand("13" + "/" + PullingSpeed.ToString() + "$");
                }
                else
                {
                    MessageBox.Show("Setting is Out of range (0:1000rpm)");
                }
                
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnStoppingTimeSet_Click(object sender, EventArgs e)
        {
            try
            {
                StoppingTime = UInt16.Parse(txtStoppingTime.Text);
                _SendCommand("37" + "/" + StoppingTime.ToString() + "$");
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
                DroppingAccel = float.Parse(txtDroppingAccRef.Text);
                _SendCommand("15" + "/" + DroppingAccel.ToString() +  "$");
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
        
        // Dropping Stage
        double DroppingAccel; // m/s2
        double DroppingDecel; // m/s2 
        double DroppingAccleratingTime; //s
        double DroppingDecelTime; //s
        
        double DroppingMaxSpeed; // rpm

        double DroppingDecelDistance; // m
        double DroppingAccelDistance; // m
        
        double DroppingTotalDistance; // m

        // Pulling Stage
        double PullingAccel; // m/s2
        double PullingDecel; // m/s2

        double PullingAccleratingTime; // s
        double PullingDecelTime; // s

        double PullingMaxSpeed; // rpm

        double PullingDecelDistance; // m
        double PullingAccelDistance; // m

        double PullingTotalDistance; // m

        double MaxSpeed; // rpm
        double TotalDistance; // m

        double DropAccTorque; //Nm
        double DropDecelTorque; //Nm

        double PullAccTorque; // Nm
        double PullDecelTorque; // Nm

        double MaxTorque; // Nm

        double Jd; // kgm2 , drum's moment of inertial
        double MOb; // kg , object's mass
        double Fs; // Safety factor

        // PID controller parameters
        float Kp;
        float Ki;
        float Kd;

        const double g = 9.8; // m/s2 gravity acc
        //public delegate void
        private void CalculateRunningParameters ()
        {
            try
            {
                DrumRadius = float.Parse(txtDrumRadius.Text); // m

                // Dropping Params
                DroppingAccelDistance = float.Parse(txtDroppingAccelDistance.Text); //m
                DroppingAccel = double.Parse(txtDroppingAccRef.Text); // m/s2
                DroppingDecel = double.Parse(txtDropDecel.Text); // m/s2

                // Pulling Params
                PullingAccelDistance = float.Parse(txtAccelPullingDistance.Text); //m
                PullingAccel = double.Parse(txtPullingAccRef.Text); // m/s2
                PullingDecel = double.Parse(txtPullingDecel.Text); // m/s2

                Jd = double.Parse(txtJd.Text);
                MOb = double.Parse(txtMOb.Text);
                Fs = double.Parse(txtFs.Text);

                // Dropping stage calculation
                DroppingAccleratingTime = Math.Round(Math.Sqrt(2 * DroppingAccelDistance / DroppingAccel), 1); // s

                DroppingMaxSpeed = Math.Round((Math.Sqrt(2 * DroppingAccel * DroppingAccelDistance) / DrumRadius) * 60 / (2 * Math.PI), 1); // rpm

                DroppingDecelTime = Math.Round(((DroppingMaxSpeed * 2 * Math.PI / 60) * DrumRadius) / DroppingDecel, 1); // s

                DroppingDecelDistance = Math.Round(0.5 * (DroppingMaxSpeed * 2 * Math.PI / 60) * DrumRadius * DroppingDecelTime, 1);

                DroppingTotalDistance = Math.Round(DroppingDecelDistance + DroppingAccelDistance,1);

                // Pulling Stage Calculation
                PullingAccleratingTime = Math.Round(Math.Sqrt(2 * PullingAccelDistance / PullingAccel), 1); // s

                PullingMaxSpeed = Math.Round((Math.Sqrt(2 * PullingAccel * PullingAccelDistance) / DrumRadius) * 60 / (2 * Math.PI), 1);// rpm

                PullingDecelTime = Math.Round(((PullingMaxSpeed * 2 * Math.PI / 60) * DrumRadius) / 9.8, 1); // s

                //PullingDecelTime = Math.Round(((PullingMaxSpeed * 2 * Math.PI / 60) * DrumRadius) / PullingDecel, 1); // s

                //PullingDecelDistance = Math.Round(0.5 * (PullingMaxSpeed * 2 * Math.PI / 60) * DrumRadius * PullingDecelTime, 1);
                PullingDecelDistance = Math.Round((Math.Pow(PullingMaxSpeed * 2 * 3.14 * DrumRadius / 60, 2)) / (2 * 9.8),1);

                PullingTotalDistance = Math.Round(PullingDecelDistance + PullingAccelDistance,1);

                //Torque calculation
                DropAccTorque = -Jd * DroppingAccel / DrumRadius - MOb * (DroppingAccel - g) * DrumRadius;
                DropDecelTorque = Jd * DroppingDecel / DrumRadius - MOb * (-DroppingDecel - g) * DrumRadius;
                DropAccTorque = Math.Abs(Math.Round(Fs * DropAccTorque, 1));
                DropDecelTorque = Math.Abs(Math.Round(Fs * DropDecelTorque, 1));

                PullAccTorque = Jd * PullingAccel / DrumRadius - MOb * (-PullingAccel - g) * DrumRadius;
                PullDecelTorque = -Jd * PullingDecel / DrumRadius - MOb * (PullingDecel - g) * DrumRadius;
                PullAccTorque = Math.Abs(Math.Round(Fs * PullAccTorque, 1));
                PullDecelTorque = Math.Abs(Math.Round(Fs * PullDecelTorque, 1));

                
                // Max Values
                MaxSpeed = Math.Max(PullingMaxSpeed, DroppingMaxSpeed);
                TotalDistance = Math.Max(PullingTotalDistance, DroppingTotalDistance);
                MaxTorque = Math.Max(Math.Max(PullAccTorque, PullDecelTorque), Math.Max(DropAccTorque, DropDecelTorque));


                // Visualize the data
                // Dropping Stage
                lbDropAcceleratingTime.Text = DroppingAccleratingTime.ToString();
                lbDropMaxSpeed.Text = DroppingMaxSpeed.ToString();
                lbDropDecelDistance.Text = DroppingDecelDistance.ToString();
                lbDropDecelTime.Text = DroppingDecelTime.ToString();
                lbDropTotalDistance.Text = DroppingTotalDistance.ToString();

                // Pulling Stage
                lbPullingAccTime.Text = PullingAccleratingTime.ToString();
                lbPullingMaxSpeed.Text = PullingMaxSpeed.ToString();
                lbPullingBrakingDis.Text = PullingDecelDistance.ToString();
                lbPullingBrakingTime.Text = PullingDecelTime.ToString();
                lbPullingTotalDis.Text = PullingTotalDistance.ToString();
                double PullingMaxSpeedInKph = Math.Round((Math.Sqrt(2 * PullingAccel * PullingAccelDistance) * 3.6), 1);// km/h
                lbPullingMaxSpdInKph.Text = PullingMaxSpeedInKph.ToString();

                // Torque
                lbDropAccTorque.Text = DropAccTorque.ToString();
                lbDropDecelTorque.Text = DropDecelTorque.ToString();

                lbPullAccTorque.Text = PullAccTorque.ToString();
                lbPullDecelTorque.Text = PullDecelTorque.ToString();

                // Max Speed and Total Distance
                lbMaxSpeed.Text = MaxSpeed.ToString() + " rpm";
                lbTotalDistance.Text = TotalDistance.ToString() + " m";
                lbMaxTorque.Text = MaxTorque.ToString() + " Nm";               
            }
            catch
            {
                return;
            }
        }
        private void bnCalculate_Click(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }
        // Pulling Exp Mode
        private void btnPullingDistance_Click(object sender, EventArgs e)
        {
            try
            {
                PullingAccelDistance = float.Parse(txtAccelPullingDistance.Text);
                _SendCommand("32" + "/" + PullingAccelDistance.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        
        private void btnPullingAccRef_Click(object sender, EventArgs e)
        {
            try
            {
                PullingAccel = float.Parse(txtPullingAccRef.Text);
                _SendCommand("33" + "/" + PullingAccel.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetDropDecel_Click(object sender, EventArgs e)
        {
            try
            {
                DroppingDecel = float.Parse(txtDropDecel.Text);
                _SendCommand("34" + "/" + DroppingDecel.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnPullingDecel_Click(object sender, EventArgs e)
        {
            try
            {
                PullingDecel = float.Parse(txtPullingDecel.Text);
                _SendCommand("35" + "/" + PullingDecel.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void txtDroppingAccelDistance_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtDroppingAccRef_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtDropDecel_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtAccelPullingDistance_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtPullingAccRef_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtPullingDecel_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtJd_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtMOb_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtFs_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void txtDrumRadius_TextChanged(object sender, EventArgs e)
        {
            CalculateRunningParameters();
        }

        private void btnSetKp_Click(object sender, EventArgs e)
        {
            try
            {
                Kp = float.Parse(txtKp.Text);
                _SendCommand("41" + "/" + Kp.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetKi_Click(object sender, EventArgs e)
        {
            try
            {
                Ki = float.Parse(txtKi.Text);
                _SendCommand("42" + "/" + Ki.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetKd_Click(object sender, EventArgs e)
        {
            try
            {
                Kd = float.Parse(txtKd.Text);
                _SendCommand("43" + "/" + Kd.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        
    }
}

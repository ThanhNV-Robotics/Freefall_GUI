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

            txtDrumRadius.Text = DrumRadius.ToString();
            txtPullingSpeed.Text = PullingSpeed.ToString();
            txtStoppingTime.Text = StoppingTime.ToString();
            txtSampleTime.Text = SampleTime.ToString();

            txtPullingPoint1.Text = Params[4].ToString();
            txtPullingPoint2.Text = Params[5].ToString();
            txtPullingPoint3.Text = Params[6].ToString();
            txtPullingPoint4.Text = Params[7].ToString();

            txtPullingAcc1.Text = Params[8].ToString();
            txtPullingAcc2.Text = Params[9].ToString();
            txtPullingAcc3.Text = Params[10].ToString();
            txtPullingAcc4.Text = Params[11].ToString();
            txtPullingAcc5.Text = Params[12].ToString();

            txtDisCoeff.Text = Params[13].ToString();

            txtDroppingAccRef.Text = Params[14].ToString();
            txtDroppingAccelDistance.Text = Params[15].ToString();
            txtDroppingAccelSlope.Text = Params[16].ToString();
            txtDropDecel.Text = Params[17].ToString();
            txtDropDecelSlope.Text = Params[18].ToString();

            CalculatePullingSpeed();
        }
        public void CalculatePullingSpeed ()
        {
            try
            {
                float a1 = float.Parse(txtPullingAcc1.Text);
                float a2 = float.Parse(txtPullingAcc2.Text);
                float a3 = float.Parse(txtPullingAcc3.Text);
                float a4 = float.Parse(txtPullingAcc4.Text);

                float s1 = float.Parse(txtPullingPoint1.Text);
                float s2 = float.Parse(txtPullingPoint2.Text);
                float s3 = float.Parse(txtPullingPoint3.Text);
                float s4 = float.Parse(txtPullingPoint4.Text);

                DrumRadius = float.Parse(txtDrumRadius.Text);

                double PullingSpeedPoint1 = Math.Round(Math.Sqrt(2 * a1 * s1),1); // to rpm
                double PullingSpeedPoint2 = Math.Round(Math.Sqrt(2 * a2 * s2 + PullingSpeedPoint1* PullingSpeedPoint1),1);
                double PullingSpeedPoint3 = Math.Round(Math.Sqrt(-2 * a3 * s3 + PullingSpeedPoint2* PullingSpeedPoint2),1);
                double PullingSpeedPoint4 = Math.Round(Math.Sqrt(-2 * a4 * s4 + PullingSpeedPoint3* PullingSpeedPoint3),1);

                lbPullingSpeedPoint1.Text = Math.Round((PullingSpeedPoint1 * 10 / DrumRadius), 1).ToString() + " rpm";
                lbPullingSpeedPoint2.Text = Math.Round((PullingSpeedPoint2 * 10 / DrumRadius), 1).ToString() + " rpm";
                lbPullingSpeedPoint3.Text = Math.Round((PullingSpeedPoint3 * 10 / DrumRadius), 1).ToString() + " rpm";
                lbPullingSpeedPoint4.Text = Math.Round((PullingSpeedPoint4 * 10 / DrumRadius), 1).ToString() + " rpm";

                double TotalPullingDist = PullingSpeedPoint4 * PullingSpeedPoint4 / (2 * float.Parse(txtPullingAcc5.Text)) +s1 +s2 +s3 +s4;

                lbTotalPullingDist.Text = TotalPullingDist.ToString() + " m";
            }
            catch (Exception)
            {
                return;
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
                    if (float.Parse(txtPullingPoint1.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling Point1");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 33:
                    if (float.Parse(txtPullingPoint2.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling Point2");
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
                    if (float.Parse(txtPullingPoint3.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Pulling Point3");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;

                case 36:
                    if (float.Parse(txtPullingAcc1.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingAcc1");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;

                case 41:
                    if (float.Parse(txtPullingAcc2.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingAcc2");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 42:
                    if (float.Parse(txtDisCoeff.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set DistCoeff");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 43:
                    if (float.Parse(txtPullingAcc3.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingAcc3");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 47:
                    if (float.Parse(txtPullingAcc4.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingAcc4");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;

                case 51:
                    if (float.Parse(txtPullingAcc5.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingAcc5");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 49:
                    if (uint.Parse(txtDroppingAccelSlope.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Drop Accel Slope");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 52:
                    if (float.Parse(txtDroppingAccelDistance.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Drop Accel Distance");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 54:
                    if (uint.Parse(txtDropDecelSlope.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set Drop Accel Slope");
                    }
                    else
                    {
                        MessageBox.Show("Setting Failed! Set Again");
                    }
                    break;
                case 9:
                    if (float.Parse(txtPullingPoint4.Text) == Param)
                    {
                        MessageBox.Show("Successfully Set PullingPoint4");
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
        
        private void System_Check_Load(object sender, EventArgs e)
        {
            MOb = 5; // kg
            Jd = 2.9; // kgm2
            Fs = 1.2;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _SendCommand("7" + "$");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _SendCommand("45/1" + "$");
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
                PullingAccelDistance = float.Parse(txtPullingPoint1.Text); //m
                PullingAccel = double.Parse(txtPullingPoint2.Text); // m/s2
                PullingDecel = double.Parse(txtPullingPoint3.Text); // m/s2

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
            
        }

        private void btnSetDisCoeff_Click(object sender, EventArgs e)
        {
            try
            {
                Ki = float.Parse(txtDisCoeff.Text);
                _SendCommand("42" + "/" + Ki.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetKd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingAcc1 = float.Parse(txtPullingAcc1.Text);
                CalculatePullingSpeed();
                _SendCommand("36" + "/" + PullingAcc1.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingAcc2_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingAcc2 = float.Parse(txtPullingAcc2.Text);
                CalculatePullingSpeed();
                _SendCommand("41" + "/" + PullingAcc2.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingAcc3_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingAcc2 = float.Parse(txtPullingAcc3.Text);
                CalculatePullingSpeed();
                _SendCommand("43" + "/" + PullingAcc2.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingAcc4_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingAcc4 = float.Parse(txtPullingAcc4.Text);
                CalculatePullingSpeed();
                _SendCommand("47" + "/" + PullingAcc4.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingAcc5_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingAcc5 = float.Parse(txtPullingAcc5.Text);
                CalculatePullingSpeed();
                _SendCommand("51" + "/" + PullingAcc5.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingPoint1_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingPoint1 = float.Parse(txtPullingPoint1.Text);
                CalculatePullingSpeed();
                _SendCommand("32" + "/" + PullingPoint1.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void btnSetPullingPoint2_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingPoint2 = float.Parse(txtPullingPoint2.Text);
                CalculatePullingSpeed();
                _SendCommand("33" + "/" + PullingPoint2.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
        private void btnSetPullingPoint3_Click(object sender, EventArgs e)
        {
            try
            {
                float PullingPoint3 = float.Parse(txtPullingPoint3.Text);
                CalculatePullingSpeed();
                _SendCommand("35" + "/" + PullingPoint3.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        // Dropping Setting Params
        private void btnDropAccelSlope_Click(object sender, EventArgs e)
        {
            try
            {
                uint DropAccelSlope = UInt16.Parse(txtDroppingAccelSlope.Text);
                _SendCommand("49" + "/" + DropAccelSlope.ToString() + "$");
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
                float DropAcceleDist = float.Parse(txtDroppingAccelDistance.Text);
                _SendCommand("52" + "/" + DropAcceleDist.ToString() + "$");
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
                _SendCommand("15" + "/" + DroppingAccel.ToString() + "$");
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
        private void btnDropDecelSlope_Click(object sender, EventArgs e)
        {
            try
            {
               uint DropDecelSlope = uint.Parse(txtDropDecelSlope.Text);
                _SendCommand("54" + "/" + DropDecelSlope.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                float PullingPoint4 = float.Parse(txtPullingPoint4.Text);
                CalculatePullingSpeed();
                _SendCommand("9" + "/" + PullingPoint4.ToString() + "$");
            }
            catch
            {
                MessageBox.Show("Invalid Input Type");
            }
        }
    }
}

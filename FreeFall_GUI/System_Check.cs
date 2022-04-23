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
        // delegate to set parameters using serialport1 of the main UI
        
        public delegate void SendCommand(string Command);

        //public SetParameters _SetParameters;
        public SendCommand _SendCommand;
        public ParamSetting()
        {
            InitializeComponent();
        }
        public void SetParameters(float AccelerationTime, float MaxSpeed, float Kp, float Ki, float AccRef)
        {
            string Param2Send = "7" + "/" + AccelerationTime.ToString() + "/" + MaxSpeed.ToString() + "/" + Kp.ToString()+"/"+ Ki.ToString() + "/" + AccRef.ToString();

            _SendCommand(Param2Send + "$"); // 7 is the function code, means set params
        }

        public void LoadSavedParams (float _AccelerationTime, float _MaxSpeed, float _Kp, float _Ki, float _AccRef)
        {
            AccelerationTime = _AccelerationTime;
            MaxSpeed = _MaxSpeed;
            Kp = _Kp;
            Ki = _Ki;
            AccRef = _AccRef;

            txtAcclerationTime.Text = AccelerationTime.ToString();
            txtMaxSpeed.Text = MaxSpeed.ToString();
            txtKp.Text = Kp.ToString();
            txtKi.Text = Ki.ToString();
            txtAccRef.Text = AccRef.ToString();
        }
        public void CheckParams(float _AccelerationTime, float _MaxSpeed, float _Kp, float _Ki, float _AccRef)
        {
            if ((_AccelerationTime== AccelerationTime)&&(_MaxSpeed == MaxSpeed) &&(_Kp==Kp)&&(_Ki==Ki) && (_AccRef == AccRef)) 
            {
                MessageBox.Show("Successfully Set");
            }
            else
            {
                MessageBox.Show("Setting failed, please set again");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                AccelerationTime = float.Parse(txtAcclerationTime.Text);
                MaxSpeed = float.Parse(txtMaxSpeed.Text);
                Kp = float.Parse(txtKp.Text);
                Ki = float.Parse(txtKi.Text);
                AccRef = float.Parse(txtAccRef.Text);
                SetParameters(AccelerationTime, MaxSpeed, Kp, Ki, AccRef);
            }
            catch
            {
                MessageBox.Show("Invalid Input Value!!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _SendCommand("10" + "$");
        }
    }
}

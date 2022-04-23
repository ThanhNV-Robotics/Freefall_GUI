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
    public partial class COM_Testing : Form
    {
        //public delegate void ShowMessage(string message);
        //public ShowMessage _ShowMessage;
        public static COM_Testing instance;
        public Label _lbReceivedMessage;
        public TextBox txtReceivedData;
        public COM_Testing()
        {
            InitializeComponent();
            instance = this;
            //_ShowMessage = new ShowMessage(ShowMessageFcn);
            _lbReceivedMessage = lbReceive;
            txtReceivedData = txtDataReceive;
        }
        public void ShowMessageFcn (string message)
        {
            lbReceive.Text = message;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            lbReceive.Text = null;
            txtDataReceive.Clear();
        }
        public delegate void SendMessage(string _message); // Khai bao 1 delegate
        public SendMessage _Sender;
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = tbText.Text;
            lbReceive.Text = null;
            _Sender("1" + message + "$");
            //tbText.Text = null;
            //this.SendMessage(message);
        }
    }
}

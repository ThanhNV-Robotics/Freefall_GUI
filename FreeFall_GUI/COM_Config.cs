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
    public partial class COM_Config : Form
    {
        bool IsApplied;
        string PortName;
        int BaudRate;
        public COM_Config()
        {
            InitializeComponent();
            IsApplied = false;
        }
        
        public delegate void SetCOM(int index, string PortName, int _BauRate, int _DataBits, string _StopBits, string _Parity);
        public delegate bool COMConnect(int index);
        public delegate bool COMDisconnect(int index);
        public delegate string[] COMRefresh();

        public SetCOM _SetCOM; // tao mot ham uy quyen
        public COMConnect _COMConnect;
        public COMDisconnect _COMDisconnect;
        public COMRefresh _COMRefresh;

        private void COM_Config_Load(object sender, EventArgs e)
        {
            _COMRefresh();
            cb_baud_rate.SelectedIndex = 3;
            cb_data_bits.SelectedIndex = 2;
            cb_parity_bits.SelectedIndex = 0;
            cb_stop_bits.SelectedIndex = 0;
        }

        private void cb_stop_bits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetCOMParams()
        {
            //string _PortName = cbPortName.SelectedItem.ToString();
            int _BaudRate = int.Parse(cb_baud_rate.SelectedItem.ToString());
            int _DataBits = int.Parse(cb_data_bits.SelectedItem.ToString());
            string _StopBits = cb_stop_bits.SelectedItem.ToString();
            string _Parity = cb_parity_bits.SelectedItem.ToString();
            _SetCOM(cbPortName.SelectedIndex ,PortName, _BaudRate, _DataBits, _StopBits, _Parity);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
 
        }
        private void DisableControl ()
        {
            //cbPortName.Enabled = false;
            cb_baud_rate.Enabled = false;
            cb_data_bits.Enabled = false;
            cb_parity_bits.Enabled = false;
            cb_stop_bits.Enabled = false;
        }
        private void EnabaleControl ()
        {
            cbPortName.Enabled = true;
            cb_baud_rate.Enabled = true;
            cb_data_bits.Enabled = true;
            cb_parity_bits.Enabled = true;
            cb_stop_bits.Enabled = true;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            PortName = cbPortName.SelectedItem.ToString();
            EnabaleControl();
            SetCOMParams();
            bool COMIsOpen = _COMConnect(cbPortName.SelectedIndex);
            if (COMIsOpen)
            {
                DisableControl();
            }            
        }

        private void btn_com_disconnect_Click(object sender, EventArgs e)
        {
            bool  COMIsOpen  = _COMDisconnect(cbPortName.SelectedIndex); // thuc hien uy quyen
            if (!COMIsOpen)
            {
                EnabaleControl();
            }
        }

        private void btn_com_refresh_Click(object sender, EventArgs e)
        {
            cbPortName.Items.Clear();
            string[] _PortName = _COMRefresh();
            cbPortName.Items.AddRange(_PortName);
        }

        private void cbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }        
    }
}

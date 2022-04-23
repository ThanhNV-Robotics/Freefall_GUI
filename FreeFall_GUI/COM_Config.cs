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
        public COM_Config()
        {
            InitializeComponent();
            IsApplied = false;
        }
        
        public delegate void SetParam(int _BauRate, int _DataBits, string _StopBits, string _Parity);
        
private void COM_Config_Load(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;

            cb_baud_rate.SelectedIndex = 2;
            cb_data_bits.SelectedIndex = 2;
            cb_parity_bits.SelectedIndex = 0;
            cb_stop_bits.SelectedIndex = 0;
        }

        private void cb_stop_bits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public SetParam _SetParam; // tao mot ham uy quyen
        private void btn_apply_Click(object sender, EventArgs e)
        {
            int _BaudRate = int.Parse(cb_baud_rate.SelectedItem.ToString());
            int _DataBits = int.Parse(cb_data_bits.SelectedItem.ToString());
            string _StopBits = cb_stop_bits.SelectedItem.ToString();
            string _Parity = cb_parity_bits.SelectedItem.ToString();
            _SetParam(_BaudRate, _DataBits, _StopBits, _Parity);
            btn_apply.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (IsApplied)
            {
                Close();
            }
            else
            {
                int _BaudRate = int.Parse(cb_baud_rate.SelectedItem.ToString());
                int _DataBits = int.Parse(cb_data_bits.SelectedItem.ToString());
                string _StopBits = cb_stop_bits.SelectedItem.ToString();
                string _Parity = cb_parity_bits.SelectedItem.ToString();
                _SetParam(_BaudRate, _DataBits, _StopBits, _Parity);
                btn_apply.Enabled = false;

                Close();
            }
        }
    }
}

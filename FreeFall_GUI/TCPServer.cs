using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace FreeFall_GUI
{
    public partial class TCPServer : Form
    {
        private TcpClient client;
        private StreamReader STR;
        TcpListener listener;
        NetworkStream ns;
        string IpAddress;
        int Port;
        string ServerReceivedMessage;

        public TCPServer()
        {
            InitializeComponent();
        }

        private void TCPServer_Load(object sender, EventArgs e)
        {
            // Initialize TCP server parameters
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); // Get computers' IP address
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpAddress = address.ToString();
                    lbServerIP.Text = address.ToString();
                }
            }
            Port = 8000; // Default value
            lbPort.Text = Port.ToString();                       
        }
    }
}

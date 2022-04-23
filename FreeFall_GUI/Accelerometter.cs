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
    public partial class Accelerometter : Form
    {
        private GraphPane MyPane = new GraphPane();
        public Accelerometter()
        {
            InitializeComponent();
        }
    }
}

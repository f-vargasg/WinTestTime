using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            txtTimeWait.Text = ConfigurationManager.AppSettings["defTimeWait"];
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            ProcessSimulator ps = new ProcessSimulator();

            ps.
        }
    }
}

using System;
using System.Reflection;
using System.Windows.Forms;

namespace EasyModbusServerSimulator
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

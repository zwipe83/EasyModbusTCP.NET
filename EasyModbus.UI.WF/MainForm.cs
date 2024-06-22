namespace EasyModbus.UI.WF
{
    public partial class MainForm : Form
    {
        ModbusClient client;
        int[] regs;

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            InitGUI();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitGUI()
        {
            this.WindowState = FormWindowState.Maximized;

            txtIpAddress.Text = "127.0.0.1";
            txtPort.Text = "502";
            txtStartAddress.Text = "0";
            txtQuantity.Text = "10";
            lblHoldingRegisters.Text = "Holding Registers:";
            btnReadHoldingRegisters.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new ModbusClient(txtIpAddress.Text, int.Parse(txtPort.Text));

            client.Connect();

            if (client.Connected)
            {
                btnReadHoldingRegisters.Enabled = true;
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();

            if (!client.Connected)
            {
                btnReadHoldingRegisters.Enabled = false;
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadHoldingRegisters_Click(object sender, EventArgs e)
        {
            bool ok;

            ok = !(txtStartAddress.Text == string.Empty);
            ok &= !(txtQuantity.Text == string.Empty);
            ok &= int.TryParse(txtStartAddress.Text, out int startAddress);
            ok &= int.TryParse(txtQuantity.Text, out int quantity);

            if (!ok)
            {
                return;
            }

            regs = client.ReadHoldingRegisters(startAddress, quantity);

            string s = string.Empty;

            foreach (var reg in regs)
            {
                s += $"{reg}\n";
            }

            lblHoldingRegisters.Text = $"Holding Registers:\n{s}";
        }
    }
}

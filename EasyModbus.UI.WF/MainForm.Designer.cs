namespace EasyModbus.UI.WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIpAddress = new TextBox();
            txtPort = new TextBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            btnReadHoldingRegisters = new Button();
            lblHoldingRegisters = new Label();
            txtStartAddress = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(12, 12);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(100, 23);
            txtIpAddress.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(12, 41);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 70);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 28);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(118, 70);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(100, 28);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnReadHoldingRegisters
            // 
            btnReadHoldingRegisters.Location = new Point(12, 133);
            btnReadHoldingRegisters.Name = "btnReadHoldingRegisters";
            btnReadHoldingRegisters.Size = new Size(206, 28);
            btnReadHoldingRegisters.TabIndex = 3;
            btnReadHoldingRegisters.Text = "Read Holding Registers";
            btnReadHoldingRegisters.UseVisualStyleBackColor = true;
            btnReadHoldingRegisters.Click += btnReadHoldingRegisters_Click;
            // 
            // lblHoldingRegisters
            // 
            lblHoldingRegisters.AutoSize = true;
            lblHoldingRegisters.Location = new Point(12, 164);
            lblHoldingRegisters.Name = "lblHoldingRegisters";
            lblHoldingRegisters.Size = new Size(38, 15);
            lblHoldingRegisters.TabIndex = 4;
            lblHoldingRegisters.Text = "label1";
            // 
            // txtStartAddress
            // 
            txtStartAddress.Location = new Point(76, 104);
            txtStartAddress.Name = "txtStartAddress";
            txtStartAddress.Size = new Size(36, 23);
            txtStartAddress.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(177, 104);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(41, 23);
            txtQuantity.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Start addr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 107);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 8;
            label2.Text = "Quantity";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtStartAddress);
            Controls.Add(lblHoldingRegisters);
            Controls.Add(btnReadHoldingRegisters);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(txtPort);
            Controls.Add(txtIpAddress);
            Name = "MainForm";
            Text = "Modbus Studio 0.0.0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIpAddress;
        private TextBox txtPort;
        private Button btnConnect;
        private Button btnDisconnect;
        private Button btnReadHoldingRegisters;
        private Label lblHoldingRegisters;
        private TextBox txtStartAddress;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
    }
}

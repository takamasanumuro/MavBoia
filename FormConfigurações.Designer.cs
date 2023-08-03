namespace SimpleExample
{
    partial class FormConfigurações
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rjTextBoxLocalHostname = new CustomControls.RJControls.RJTextBox();
            this.labelConfigurações = new System.Windows.Forms.Label();
            this.labelLocalHostName = new System.Windows.Forms.Label();
            this.labelVPNHostname = new System.Windows.Forms.Label();
            this.rjTextBoxVPNHostname = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxVPNInterval = new CustomControls.RJControls.RJTextBox();
            this.labelVPNRequisitionInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNetConnectionType = new System.Windows.Forms.Label();
            this.fancyComboBoxNetConnectionType = new CustomControls.FancyComboBox();
            this.comboBoxSerialPort = new CustomControls.FancyComboBox();
            this.comboBoxBaudRate = new CustomControls.FancyComboBox();
            this.labelLogDirectory = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // rjTextBoxLocalHostname
            // 
            this.rjTextBoxLocalHostname.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxLocalHostname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLocalHostname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxLocalHostname.BorderRadius = 0;
            this.rjTextBoxLocalHostname.BorderSize = 2;
            this.rjTextBoxLocalHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxLocalHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxLocalHostname.Location = new System.Drawing.Point(233, 204);
            this.rjTextBoxLocalHostname.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxLocalHostname.Multiline = false;
            this.rjTextBoxLocalHostname.Name = "rjTextBoxLocalHostname";
            this.rjTextBoxLocalHostname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxLocalHostname.PasswordChar = false;
            this.rjTextBoxLocalHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLocalHostname.PlaceholderText = "";
            this.rjTextBoxLocalHostname.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxLocalHostname.TabIndex = 0;
            this.rjTextBoxLocalHostname.Texts = "boat-companion";
            this.rjTextBoxLocalHostname.UnderlinedStyle = false;
            // 
            // labelConfigurações
            // 
            this.labelConfigurações.AutoSize = true;
            this.labelConfigurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurações.ForeColor = System.Drawing.Color.Coral;
            this.labelConfigurações.Location = new System.Drawing.Point(24, 41);
            this.labelConfigurações.Name = "labelConfigurações";
            this.labelConfigurações.Size = new System.Drawing.Size(211, 32);
            this.labelConfigurações.TabIndex = 16;
            this.labelConfigurações.Text = "Configurações";
            // 
            // labelLocalHostName
            // 
            this.labelLocalHostName.AutoSize = true;
            this.labelLocalHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalHostName.ForeColor = System.Drawing.Color.Coral;
            this.labelLocalHostName.Location = new System.Drawing.Point(61, 204);
            this.labelLocalHostName.Name = "labelLocalHostName";
            this.labelLocalHostName.Size = new System.Drawing.Size(147, 17);
            this.labelLocalHostName.TabIndex = 17;
            this.labelLocalHostName.Text = "Nome de host local";
            this.labelLocalHostName.Click += new System.EventHandler(this.labelControlData_Click);
            // 
            // labelVPNHostname
            // 
            this.labelVPNHostname.AutoSize = true;
            this.labelVPNHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVPNHostname.ForeColor = System.Drawing.Color.Coral;
            this.labelVPNHostname.Location = new System.Drawing.Point(64, 243);
            this.labelVPNHostname.Name = "labelVPNHostname";
            this.labelVPNHostname.Size = new System.Drawing.Size(144, 17);
            this.labelVPNHostname.TabIndex = 18;
            this.labelVPNHostname.Text = "Nome de host VPN";
            // 
            // rjTextBoxVPNHostname
            // 
            this.rjTextBoxVPNHostname.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxVPNHostname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxVPNHostname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxVPNHostname.BorderRadius = 0;
            this.rjTextBoxVPNHostname.BorderSize = 2;
            this.rjTextBoxVPNHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNHostname.Location = new System.Drawing.Point(233, 243);
            this.rjTextBoxVPNHostname.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxVPNHostname.Multiline = false;
            this.rjTextBoxVPNHostname.Name = "rjTextBoxVPNHostname";
            this.rjTextBoxVPNHostname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxVPNHostname.PasswordChar = false;
            this.rjTextBoxVPNHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNHostname.PlaceholderText = "";
            this.rjTextBoxVPNHostname.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxVPNHostname.TabIndex = 19;
            this.rjTextBoxVPNHostname.Texts = "boat32";
            this.rjTextBoxVPNHostname.UnderlinedStyle = false;
            // 
            // rjTextBoxVPNInterval
            // 
            this.rjTextBoxVPNInterval.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxVPNInterval.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxVPNInterval.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxVPNInterval.BorderRadius = 0;
            this.rjTextBoxVPNInterval.BorderSize = 2;
            this.rjTextBoxVPNInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNInterval.Location = new System.Drawing.Point(233, 290);
            this.rjTextBoxVPNInterval.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxVPNInterval.Multiline = false;
            this.rjTextBoxVPNInterval.Name = "rjTextBoxVPNInterval";
            this.rjTextBoxVPNInterval.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxVPNInterval.PasswordChar = false;
            this.rjTextBoxVPNInterval.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNInterval.PlaceholderText = "";
            this.rjTextBoxVPNInterval.Size = new System.Drawing.Size(116, 30);
            this.rjTextBoxVPNInterval.TabIndex = 21;
            this.rjTextBoxVPNInterval.Texts = "2000";
            this.rjTextBoxVPNInterval.UnderlinedStyle = false;
            // 
            // labelVPNRequisitionInterval
            // 
            this.labelVPNRequisitionInterval.AutoSize = true;
            this.labelVPNRequisitionInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVPNRequisitionInterval.ForeColor = System.Drawing.Color.Coral;
            this.labelVPNRequisitionInterval.Location = new System.Drawing.Point(53, 290);
            this.labelVPNRequisitionInterval.Name = "labelVPNRequisitionInterval";
            this.labelVPNRequisitionInterval.Size = new System.Drawing.Size(174, 34);
            this.labelVPNRequisitionInterval.TabIndex = 20;
            this.labelVPNRequisitionInterval.Text = "Intervalo de requisição\r\n            VPN";
            this.labelVPNRequisitionInterval.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(90, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Porta serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(75, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Taxa de baud";
            // 
            // labelNetConnectionType
            // 
            this.labelNetConnectionType.AutoSize = true;
            this.labelNetConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetConnectionType.ForeColor = System.Drawing.Color.Coral;
            this.labelNetConnectionType.Location = new System.Drawing.Point(53, 149);
            this.labelNetConnectionType.Name = "labelNetConnectionType";
            this.labelNetConnectionType.Size = new System.Drawing.Size(163, 17);
            this.labelNetConnectionType.TabIndex = 29;
            this.labelNetConnectionType.Text = "Tipo de conexão LAN";
            // 
            // fancyComboBoxNetConnectionType
            // 
            this.fancyComboBoxNetConnectionType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fancyComboBoxNetConnectionType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.fancyComboBoxNetConnectionType.BorderSize = 1;
            this.fancyComboBoxNetConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fancyComboBoxNetConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyComboBoxNetConnectionType.ForeColor = System.Drawing.Color.DimGray;
            this.fancyComboBoxNetConnectionType.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.fancyComboBoxNetConnectionType.Items.AddRange(new object[] {
            "Local",
            "VPN"});
            this.fancyComboBoxNetConnectionType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.fancyComboBoxNetConnectionType.ListTextColor = System.Drawing.Color.DimGray;
            this.fancyComboBoxNetConnectionType.Location = new System.Drawing.Point(233, 149);
            this.fancyComboBoxNetConnectionType.MinimumSize = new System.Drawing.Size(30, 10);
            this.fancyComboBoxNetConnectionType.Name = "fancyComboBoxNetConnectionType";
            this.fancyComboBoxNetConnectionType.Padding = new System.Windows.Forms.Padding(1);
            this.fancyComboBoxNetConnectionType.Size = new System.Drawing.Size(116, 29);
            this.fancyComboBoxNetConnectionType.TabIndex = 28;
            this.fancyComboBoxNetConnectionType.Texts = "";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSerialPort.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.BorderSize = 1;
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSerialPort.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxSerialPort.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(233, 342);
            this.comboBoxSerialPort.MinimumSize = new System.Drawing.Size(30, 10);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSerialPort.Size = new System.Drawing.Size(116, 31);
            this.comboBoxSerialPort.TabIndex = 22;
            this.comboBoxSerialPort.Texts = "";
            this.comboBoxSerialPort.Click += new System.EventHandler(this.comboBoxSerialPort_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxBaudRate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.BorderSize = 1;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            "915200"});
            this.comboBoxBaudRate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxBaudRate.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(233, 379);
            this.comboBoxBaudRate.MinimumSize = new System.Drawing.Size(30, 10);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxBaudRate.Size = new System.Drawing.Size(116, 31);
            this.comboBoxBaudRate.TabIndex = 23;
            this.comboBoxBaudRate.Texts = "";
            // 
            // labelLogDirectory
            // 
            this.labelLogDirectory.AutoSize = true;
            this.labelLogDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogDirectory.ForeColor = System.Drawing.Color.Coral;
            this.labelLogDirectory.Location = new System.Drawing.Point(56, 425);
            this.labelLogDirectory.Name = "labelLogDirectory";
            this.labelLogDirectory.Size = new System.Drawing.Size(160, 17);
            this.labelLogDirectory.TabIndex = 31;
            this.labelLogDirectory.Text = "Diretório para logger";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(232, 424);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(116, 30);
            this.rjTextBox1.TabIndex = 30;
            this.rjTextBox1.Texts = "C://logs";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // FormConfigurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.labelLogDirectory);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.labelNetConnectionType);
            this.Controls.Add(this.fancyComboBoxNetConnectionType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.rjTextBoxVPNInterval);
            this.Controls.Add(this.labelVPNRequisitionInterval);
            this.Controls.Add(this.rjTextBoxVPNHostname);
            this.Controls.Add(this.labelVPNHostname);
            this.Controls.Add(this.labelLocalHostName);
            this.Controls.Add(this.labelConfigurações);
            this.Controls.Add(this.rjTextBoxLocalHostname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfigurações";
            this.Text = "FormConfigurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelConfigurações;
        public System.Windows.Forms.Label labelLocalHostName;
        public System.Windows.Forms.Label labelVPNHostname;
        public System.Windows.Forms.Label labelVPNRequisitionInterval;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        internal CustomControls.RJControls.RJTextBox rjTextBoxLocalHostname;
        internal CustomControls.RJControls.RJTextBox rjTextBoxVPNHostname;
        internal CustomControls.RJControls.RJTextBox rjTextBoxVPNInterval;
        internal CustomControls.FancyComboBox comboBoxSerialPort;
        internal CustomControls.FancyComboBox comboBoxBaudRate;
        public System.Windows.Forms.Label labelNetConnectionType;
        internal CustomControls.FancyComboBox fancyComboBoxNetConnectionType;
        public System.Windows.Forms.Label labelLogDirectory;
        internal CustomControls.RJControls.RJTextBox rjTextBox1;
    }
}
namespace SimpleExample
{
    partial class FormPixhawk
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new CustomControls.FancyComboBox();
            this.comboBoxBaudRate = new CustomControls.FancyComboBox();
            this.buttonConnect = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxEntrada = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelTitle.Location = new System.Drawing.Point(362, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(127, 32);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Pixhawk";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSerialPort.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.BorderSize = 1;
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSerialPort.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSerialPort.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxSerialPort.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(649, 48);
            this.comboBoxSerialPort.MinimumSize = new System.Drawing.Size(30, 10);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSerialPort.Size = new System.Drawing.Size(80, 23);
            this.comboBoxSerialPort.TabIndex = 18;
            this.comboBoxSerialPort.Texts = "";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxBaudRate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.BorderSize = 1;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxBaudRate.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "57600",
            "115200",
            "915200"});
            this.comboBoxBaudRate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxBaudRate.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(735, 48);
            this.comboBoxBaudRate.MinimumSize = new System.Drawing.Size(30, 10);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxBaudRate.Size = new System.Drawing.Size(83, 23);
            this.comboBoxBaudRate.TabIndex = 19;
            this.comboBoxBaudRate.Texts = "";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConnect.BorderRadius = 10;
            this.buttonConnect.BorderSize = 0;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Coral;
            this.buttonConnect.Location = new System.Drawing.Point(833, 48);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(74, 25);
            this.buttonConnect.TabIndex = 20;
            this.buttonConnect.Text = "Abrir";
            this.buttonConnect.TextColor = System.Drawing.Color.Coral;
            this.buttonConnect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pixhawk Port";
            // 
            // richTextBoxEntrada
            // 
            this.richTextBoxEntrada.Location = new System.Drawing.Point(242, 108);
            this.richTextBoxEntrada.Name = "richTextBoxEntrada";
            this.richTextBoxEntrada.Size = new System.Drawing.Size(665, 317);
            this.richTextBoxEntrada.TabIndex = 22;
            this.richTextBoxEntrada.Text = "";
            // 
            // FormPixhawk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(937, 480);
            this.Controls.Add(this.richTextBoxEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPixhawk";
            this.Text = "FormPixhawk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private CustomControls.FancyComboBox comboBoxSerialPort;
        private CustomControls.FancyComboBox comboBoxBaudRate;
        private CustomControls.RJControls.RJButton buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxEntrada;
    }
}
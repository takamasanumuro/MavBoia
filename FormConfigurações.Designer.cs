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
            this.SuspendLayout();
            // 
            // rjTextBoxLocalHostname
            // 
            this.rjTextBoxLocalHostname.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxLocalHostname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLocalHostname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxLocalHostname.BorderRadius = 0;
            this.rjTextBoxLocalHostname.BorderSize = 2;
            this.rjTextBoxLocalHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxLocalHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxLocalHostname.Location = new System.Drawing.Point(199, 116);
            this.rjTextBoxLocalHostname.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxLocalHostname.Multiline = false;
            this.rjTextBoxLocalHostname.Name = "rjTextBoxLocalHostname";
            this.rjTextBoxLocalHostname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxLocalHostname.PasswordChar = false;
            this.rjTextBoxLocalHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxLocalHostname.PlaceholderText = "";
            this.rjTextBoxLocalHostname.Size = new System.Drawing.Size(95, 28);
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
            this.labelLocalHostName.Location = new System.Drawing.Point(19, 116);
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
            this.labelVPNHostname.Location = new System.Drawing.Point(19, 155);
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
            this.rjTextBoxVPNHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNHostname.Location = new System.Drawing.Point(199, 155);
            this.rjTextBoxVPNHostname.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxVPNHostname.Multiline = false;
            this.rjTextBoxVPNHostname.Name = "rjTextBoxVPNHostname";
            this.rjTextBoxVPNHostname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxVPNHostname.PasswordChar = false;
            this.rjTextBoxVPNHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNHostname.PlaceholderText = "";
            this.rjTextBoxVPNHostname.Size = new System.Drawing.Size(95, 28);
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
            this.rjTextBoxVPNInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxVPNInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBoxVPNInterval.Location = new System.Drawing.Point(199, 191);
            this.rjTextBoxVPNInterval.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxVPNInterval.Multiline = false;
            this.rjTextBoxVPNInterval.Name = "rjTextBoxVPNInterval";
            this.rjTextBoxVPNInterval.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxVPNInterval.PasswordChar = false;
            this.rjTextBoxVPNInterval.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxVPNInterval.PlaceholderText = "";
            this.rjTextBoxVPNInterval.Size = new System.Drawing.Size(95, 28);
            this.rjTextBoxVPNInterval.TabIndex = 21;
            this.rjTextBoxVPNInterval.Texts = "2000";
            this.rjTextBoxVPNInterval.UnderlinedStyle = false;
            // 
            // labelVPNRequisitionInterval
            // 
            this.labelVPNRequisitionInterval.AutoSize = true;
            this.labelVPNRequisitionInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVPNRequisitionInterval.ForeColor = System.Drawing.Color.Coral;
            this.labelVPNRequisitionInterval.Location = new System.Drawing.Point(19, 191);
            this.labelVPNRequisitionInterval.Name = "labelVPNRequisitionInterval";
            this.labelVPNRequisitionInterval.Size = new System.Drawing.Size(174, 34);
            this.labelVPNRequisitionInterval.TabIndex = 20;
            this.labelVPNRequisitionInterval.Text = "Intervalo de requisição\r\n            VPN";
            this.labelVPNRequisitionInterval.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormConfigurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
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

        private CustomControls.RJControls.RJTextBox rjTextBoxLocalHostname;
        private System.Windows.Forms.Label labelConfigurações;
        public System.Windows.Forms.Label labelLocalHostName;
        public System.Windows.Forms.Label labelVPNHostname;
        private CustomControls.RJControls.RJTextBox rjTextBoxVPNHostname;
        private CustomControls.RJControls.RJTextBox rjTextBoxVPNInterval;
        public System.Windows.Forms.Label labelVPNRequisitionInterval;
    }
}
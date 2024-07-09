namespace SimpleExample
{
    partial class FormDados
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
            this.labelInstrumentationData = new System.Windows.Forms.Label();
            this.labelInstrumentationTitle = new System.Windows.Forms.Label();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelTemperatureData = new System.Windows.Forms.Label();
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelRPMTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstrumentationData
            // 
            this.labelInstrumentationData.AutoSize = true;
            this.labelInstrumentationData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationData.ForeColor = System.Drawing.Color.Coral;
            this.labelInstrumentationData.Location = new System.Drawing.Point(69, 63);
            this.labelInstrumentationData.Name = "labelInstrumentationData";
            this.labelInstrumentationData.Size = new System.Drawing.Size(179, 20);
            this.labelInstrumentationData.TabIndex = 13;
            this.labelInstrumentationData.Text = "Aguardando dados...";
            // 
            // labelInstrumentationTitle
            // 
            this.labelInstrumentationTitle.AutoSize = true;
            this.labelInstrumentationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelInstrumentationTitle.Location = new System.Drawing.Point(33, 9);
            this.labelInstrumentationTitle.Name = "labelInstrumentationTitle";
            this.labelInstrumentationTitle.Size = new System.Drawing.Size(252, 37);
            this.labelInstrumentationTitle.TabIndex = 14;
            this.labelInstrumentationTitle.Text = "Instrumentação";
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.ForeColor = System.Drawing.Color.Coral;
            this.labelTemperatura.Location = new System.Drawing.Point(332, 9);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(212, 37);
            this.labelTemperatura.TabIndex = 17;
            this.labelTemperatura.Text = "Temperatura";
            // 
            // labelTemperatureData
            // 
            this.labelTemperatureData.AutoSize = true;
            this.labelTemperatureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureData.ForeColor = System.Drawing.Color.Coral;
            this.labelTemperatureData.Location = new System.Drawing.Point(365, 63);
            this.labelTemperatureData.Name = "labelTemperatureData";
            this.labelTemperatureData.Size = new System.Drawing.Size(179, 20);
            this.labelTemperatureData.TabIndex = 18;
            this.labelTemperatureData.Text = "Aguardando dados...";
            // 
            // labelRPMText
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPM.ForeColor = System.Drawing.Color.Coral;
            this.labelRPM.Location = new System.Drawing.Point(642, 63);
            this.labelRPM.Name = "labelRPMText";
            this.labelRPM.Size = new System.Drawing.Size(179, 20);
            this.labelRPM.TabIndex = 20;
            this.labelRPM.Text = "Aguardando dados...";
            // 
            // labelRPMTitle
            // 
            this.labelRPMTitle.AutoSize = true;
            this.labelRPMTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPMTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelRPMTitle.Location = new System.Drawing.Point(676, 9);
            this.labelRPMTitle.Name = "labelRPMTitle";
            this.labelRPMTitle.Size = new System.Drawing.Size(89, 37);
            this.labelRPMTitle.TabIndex = 19;
            this.labelRPMTitle.Text = "RPM";
            this.labelRPMTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRPMTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.labelRPMTitle);
            this.Controls.Add(this.labelTemperatureData);
            this.Controls.Add(this.labelTemperatura);
            this.Controls.Add(this.labelInstrumentationData);
            this.Controls.Add(this.labelInstrumentationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDados";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelInstrumentationData;
        public System.Windows.Forms.Label labelInstrumentationTitle;
        public System.Windows.Forms.Label labelTemperatura;
        public System.Windows.Forms.Label labelTemperatureData;
        public System.Windows.Forms.Label labelRPM;
        public System.Windows.Forms.Label labelRPMTitle;
    }
}
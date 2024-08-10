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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInstrumentationData
            // 
            this.labelInstrumentationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInstrumentationData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelInstrumentationData.Location = new System.Drawing.Point(0, 140);
            this.labelInstrumentationData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstrumentationData.Name = "labelInstrumentationData";
            this.labelInstrumentationData.Size = new System.Drawing.Size(432, 235);
            this.labelInstrumentationData.TabIndex = 13;
            this.labelInstrumentationData.Text = "Aguardando dados...";
            this.labelInstrumentationData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInstrumentationTitle
            // 
            this.labelInstrumentationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInstrumentationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelInstrumentationTitle.Location = new System.Drawing.Point(0, 0);
            this.labelInstrumentationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstrumentationTitle.Name = "labelInstrumentationTitle";
            this.labelInstrumentationTitle.Size = new System.Drawing.Size(432, 55);
            this.labelInstrumentationTitle.TabIndex = 14;
            this.labelInstrumentationTitle.Text = "Instrumentação";
            this.labelInstrumentationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelTemperatura.Location = new System.Drawing.Point(0, 0);
            this.labelTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(406, 55);
            this.labelTemperatura.TabIndex = 17;
            this.labelTemperatura.Text = "Temperatura";
            this.labelTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemperatureData
            // 
            this.labelTemperatureData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemperatureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelTemperatureData.Location = new System.Drawing.Point(-2, 144);
            this.labelTemperatureData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemperatureData.Name = "labelTemperatureData";
            this.labelTemperatureData.Size = new System.Drawing.Size(404, 233);
            this.labelTemperatureData.TabIndex = 18;
            this.labelTemperatureData.Text = "Aguardando dados...";
            this.labelTemperatureData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRPM
            // 
            this.labelRPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelRPM.Location = new System.Drawing.Point(5, 147);
            this.labelRPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(360, 233);
            this.labelRPM.TabIndex = 20;
            this.labelRPM.Text = "Aguardando dados...";
            this.labelRPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRPMTitle
            // 
            this.labelRPMTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRPMTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRPMTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelRPMTitle.Location = new System.Drawing.Point(0, 0);
            this.labelRPMTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRPMTitle.Name = "labelRPMTitle";
            this.labelRPMTitle.Size = new System.Drawing.Size(365, 55);
            this.labelRPMTitle.TabIndex = 19;
            this.labelRPMTitle.Text = "RPM";
            this.labelRPMTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 180);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(1226, 380);
            this.panel1.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.labelRPMTitle);
            this.panel4.Controls.Add(this.labelRPM);
            this.panel4.Location = new System.Drawing.Point(848, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 375);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.labelTemperatureData);
            this.panel3.Controls.Add(this.labelTemperatura);
            this.panel3.Location = new System.Drawing.Point(445, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 372);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.labelInstrumentationTitle);
            this.panel2.Controls.Add(this.labelInstrumentationData);
            this.panel2.Location = new System.Drawing.Point(7, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 375);
            this.panel2.TabIndex = 0;
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDados";
            this.Text = "Dados";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}
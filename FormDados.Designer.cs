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
            this.labelControlData = new System.Windows.Forms.Label();
            this.labelControlTitle = new System.Windows.Forms.Label();
            this.labelInstrumentationData = new System.Windows.Forms.Label();
            this.labelInstrumentationTitle = new System.Windows.Forms.Label();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelTemperaturaDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelControlData
            // 
            this.labelControlData.AutoSize = true;
            this.labelControlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlData.ForeColor = System.Drawing.Color.Coral;
            this.labelControlData.Location = new System.Drawing.Point(52, 365);
            this.labelControlData.Name = "labelControlData";
            this.labelControlData.Size = new System.Drawing.Size(79, 25);
            this.labelControlData.TabIndex = 15;
            this.labelControlData.Text = "Dados";
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.AutoSize = true;
            this.labelControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelControlTitle.Location = new System.Drawing.Point(51, 311);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(130, 32);
            this.labelControlTitle.TabIndex = 16;
            this.labelControlTitle.Text = "Controle";
            // 
            // labelInstrumentationData
            // 
            this.labelInstrumentationData.AutoSize = true;
            this.labelInstrumentationData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationData.ForeColor = System.Drawing.Color.Coral;
            this.labelInstrumentationData.Location = new System.Drawing.Point(52, 114);
            this.labelInstrumentationData.Name = "labelInstrumentationData";
            this.labelInstrumentationData.Size = new System.Drawing.Size(79, 25);
            this.labelInstrumentationData.TabIndex = 13;
            this.labelInstrumentationData.Text = "Dados";
            // 
            // labelInstrumentationTitle
            // 
            this.labelInstrumentationTitle.AutoSize = true;
            this.labelInstrumentationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrumentationTitle.ForeColor = System.Drawing.Color.Coral;
            this.labelInstrumentationTitle.Location = new System.Drawing.Point(51, 60);
            this.labelInstrumentationTitle.Name = "labelInstrumentationTitle";
            this.labelInstrumentationTitle.Size = new System.Drawing.Size(223, 32);
            this.labelInstrumentationTitle.TabIndex = 14;
            this.labelInstrumentationTitle.Text = "Instrumentação";
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.ForeColor = System.Drawing.Color.Coral;
            this.labelTemperatura.Location = new System.Drawing.Point(464, 60);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(187, 32);
            this.labelTemperatura.TabIndex = 17;
            this.labelTemperatura.Text = "Temperatura";
            // 
            // labelTemperaturaDados
            // 
            this.labelTemperaturaDados.AutoSize = true;
            this.labelTemperaturaDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperaturaDados.ForeColor = System.Drawing.Color.Coral;
            this.labelTemperaturaDados.Location = new System.Drawing.Point(465, 114);
            this.labelTemperaturaDados.Name = "labelTemperaturaDados";
            this.labelTemperaturaDados.Size = new System.Drawing.Size(79, 25);
            this.labelTemperaturaDados.TabIndex = 18;
            this.labelTemperaturaDados.Text = "Dados";
            // 
            // FormDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.labelTemperaturaDados);
            this.Controls.Add(this.labelTemperatura);
            this.Controls.Add(this.labelControlData);
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.labelInstrumentationData);
            this.Controls.Add(this.labelInstrumentationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDados";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelControlData;
        public System.Windows.Forms.Label labelControlTitle;
        public System.Windows.Forms.Label labelInstrumentationData;
        public System.Windows.Forms.Label labelInstrumentationTitle;
        public System.Windows.Forms.Label labelTemperatura;
        public System.Windows.Forms.Label labelTemperaturaDados;
    }
}
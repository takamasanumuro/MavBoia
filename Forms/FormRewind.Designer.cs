namespace MavBoia.Forms
{
    partial class FormRewind
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
            this.panelMap = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.trackBarRewind = new System.Windows.Forms.TrackBar();
            this.buttonUpload = new CustomControls.RJControls.RJButton();
            this.panelData = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRewind)).BeginInit();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(825, 720);
            this.panelMap.TabIndex = 0;
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.labelData.Location = new System.Drawing.Point(17, 30);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(383, 439);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Informação não carregada";
            // 
            // trackBarRewind
            // 
            this.trackBarRewind.Location = new System.Drawing.Point(50, 521);
            this.trackBarRewind.Name = "trackBarRewind";
            this.trackBarRewind.Size = new System.Drawing.Size(312, 69);
            this.trackBarRewind.TabIndex = 1;
            this.trackBarRewind.Scroll += new System.EventHandler(this.trackBarRewind_Scroll);
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonUpload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpload.BorderRadius = 20;
            this.buttonUpload.BorderSize = 0;
            this.buttonUpload.FlatAppearance.BorderSize = 0;
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpload.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonUpload.Location = new System.Drawing.Point(119, 631);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(174, 55);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload CSV";
            this.buttonUpload.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(23)))));
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelData.Controls.Add(this.buttonUpload);
            this.panelData.Controls.Add(this.trackBarRewind);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(825, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(412, 720);
            this.panelData.TabIndex = 1;
            // 
            // FormRewind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1237, 720);
            this.Name = "FormRewind";
            this.ShowIcon = false;
            this.Text = "FormRewind";
            this.Load += new System.EventHandler(this.FormRewind_Load);
            this.Resize += new System.EventHandler(this.FormRewind_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRewind)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TrackBar trackBarRewind;
        private CustomControls.RJControls.RJButton buttonUpload;
        private System.Windows.Forms.Panel panelData;
    }
}
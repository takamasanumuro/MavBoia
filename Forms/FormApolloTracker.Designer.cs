namespace MavBoia.Forms
{
    partial class FormApolloTracker
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
            this.SuspendLayout();
            // 
            // ApolloTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 720);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1238, 720);
            this.Name = "ApolloTracker";
            this.Text = "ApolloTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApolloTracker_FormClosing);
            this.Load += new System.EventHandler(this.ApolloTracker_Load);
            this.Resize += new System.EventHandler(this.ApolloTracker_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
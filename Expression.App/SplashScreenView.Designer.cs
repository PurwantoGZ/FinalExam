namespace Expression.App
{
    partial class SplashScreenView
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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar2.Location = new System.Drawing.Point(0, 238);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(444, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Teal;
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Status.Location = new System.Drawing.Point(3, 223);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 2;
            this.Status.Text = "Staus:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.BGScreen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 238);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreenView
            // 
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Status;
    }
}
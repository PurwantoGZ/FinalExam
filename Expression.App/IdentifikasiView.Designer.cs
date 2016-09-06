namespace Expression.App
{
    partial class IdentifikasiView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifikasiView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviewImage = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.vF1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vF2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vF3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vF4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vF5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vF6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vOutput = new System.Windows.Forms.ToolStripStatusLabel();
            this.CamList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(33, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 59);
            this.panel2.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "Identifikasi Data Citra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.Facial_Recognition_Scan_484;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Ekspresi User";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PreviewImage);
            this.panel1.Location = new System.Drawing.Point(33, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 327);
            this.panel1.TabIndex = 29;
            // 
            // PreviewImage
            // 
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.Location = new System.Drawing.Point(0, 0);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(488, 325);
            this.PreviewImage.TabIndex = 3;
            this.PreviewImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pratinjau Citra";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vF1,
            this.vF2,
            this.vF3,
            this.vF4,
            this.vF5,
            this.vF6,
            this.vOutput});
            this.StatusBar.Location = new System.Drawing.Point(30, 464);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(499, 22);
            this.StatusBar.TabIndex = 31;
            this.StatusBar.Text = "statusStrip1";
            // 
            // vF1
            // 
            this.vF1.AutoSize = false;
            this.vF1.Name = "vF1";
            this.vF1.Size = new System.Drawing.Size(60, 17);
            this.vF1.Text = "F1:";
            this.vF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vF2
            // 
            this.vF2.AutoSize = false;
            this.vF2.Name = "vF2";
            this.vF2.Size = new System.Drawing.Size(60, 17);
            this.vF2.Text = "F2";
            this.vF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vF3
            // 
            this.vF3.AutoSize = false;
            this.vF3.Name = "vF3";
            this.vF3.Size = new System.Drawing.Size(60, 17);
            this.vF3.Text = "F3";
            this.vF3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vF4
            // 
            this.vF4.AutoSize = false;
            this.vF4.Name = "vF4";
            this.vF4.Size = new System.Drawing.Size(60, 17);
            this.vF4.Text = "F4";
            this.vF4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vF5
            // 
            this.vF5.AutoSize = false;
            this.vF5.Name = "vF5";
            this.vF5.Size = new System.Drawing.Size(60, 17);
            this.vF5.Text = "F5";
            this.vF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vF6
            // 
            this.vF6.AutoSize = false;
            this.vF6.Name = "vF6";
            this.vF6.Size = new System.Drawing.Size(60, 17);
            this.vF6.Text = "F6";
            this.vF6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vOutput
            // 
            this.vOutput.AutoSize = false;
            this.vOutput.Name = "vOutput";
            this.vOutput.Size = new System.Drawing.Size(100, 17);
            this.vOutput.Text = "Output:";
            this.vOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CamList
            // 
            this.CamList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamList.FormattingEnabled = true;
            this.CamList.Location = new System.Drawing.Point(272, 426);
            this.CamList.Name = "CamList";
            this.CamList.Size = new System.Drawing.Size(136, 27);
            this.CamList.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Pilih Kamera :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder-48.png");
            this.imageList1.Images.SetKeyName(1, "Next-48.png");
            this.imageList1.Images.SetKeyName(2, "Stop-48.png");
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.ImageIndex = 1;
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(424, 424);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 33);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Mulai";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.ImageIndex = 0;
            this.btnOpenImage.ImageList = this.imageList1;
            this.btnOpenImage.Location = new System.Drawing.Point(33, 424);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(122, 33);
            this.btnOpenImage.TabIndex = 32;
            this.btnOpenImage.Text = "Buka Citra";
            this.btnOpenImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // IdentifikasiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 496);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CamList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdentifikasiView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 10);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox PreviewImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel vF1;
        private System.Windows.Forms.ToolStripStatusLabel vF2;
        private System.Windows.Forms.ToolStripStatusLabel vF3;
        private System.Windows.Forms.ToolStripStatusLabel vF4;
        private System.Windows.Forms.ToolStripStatusLabel vF5;
        private System.Windows.Forms.ToolStripStatusLabel vF6;
        private System.Windows.Forms.ToolStripStatusLabel vOutput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox CamList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.ImageList imageList1;
    }
}
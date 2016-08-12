namespace Expression.App
{
    partial class CamSettingView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviewImage = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sharpness_LBL = new System.Windows.Forms.Label();
            this.Contrast_LBL = new System.Windows.Forms.Label();
            this.Brigthness_LBL = new System.Windows.Forms.Label();
            this.Sharpness_SLD = new System.Windows.Forms.TrackBar();
            this.Contrast_SLD = new System.Windows.Forms.TrackBar();
            this.Brigtness_SLD = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.CamList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brigtness_SLD)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PreviewImage);
            this.panel1.Location = new System.Drawing.Point(33, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 312);
            this.panel1.TabIndex = 0;
            // 
            // PreviewImage
            // 
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.Location = new System.Drawing.Point(0, 0);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(459, 310);
            this.PreviewImage.TabIndex = 4;
            this.PreviewImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera View";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Sharpness_LBL);
            this.panel2.Controls.Add(this.Contrast_LBL);
            this.panel2.Controls.Add(this.Brigthness_LBL);
            this.panel2.Controls.Add(this.Sharpness_SLD);
            this.panel2.Controls.Add(this.Contrast_SLD);
            this.panel2.Controls.Add(this.Brigtness_SLD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.CamList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(500, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 312);
            this.panel2.TabIndex = 2;
            // 
            // Sharpness_LBL
            // 
            this.Sharpness_LBL.AutoSize = true;
            this.Sharpness_LBL.Location = new System.Drawing.Point(207, 256);
            this.Sharpness_LBL.Name = "Sharpness_LBL";
            this.Sharpness_LBL.Size = new System.Drawing.Size(18, 19);
            this.Sharpness_LBL.TabIndex = 11;
            this.Sharpness_LBL.Text = "0";
            // 
            // Contrast_LBL
            // 
            this.Contrast_LBL.AutoSize = true;
            this.Contrast_LBL.Location = new System.Drawing.Point(207, 193);
            this.Contrast_LBL.Name = "Contrast_LBL";
            this.Contrast_LBL.Size = new System.Drawing.Size(18, 19);
            this.Contrast_LBL.TabIndex = 10;
            this.Contrast_LBL.Text = "0";
            // 
            // Brigthness_LBL
            // 
            this.Brigthness_LBL.AutoSize = true;
            this.Brigthness_LBL.Location = new System.Drawing.Point(207, 137);
            this.Brigthness_LBL.Name = "Brigthness_LBL";
            this.Brigthness_LBL.Size = new System.Drawing.Size(18, 19);
            this.Brigthness_LBL.TabIndex = 9;
            this.Brigthness_LBL.Text = "0";
            // 
            // Sharpness_SLD
            // 
            this.Sharpness_SLD.AutoSize = false;
            this.Sharpness_SLD.Location = new System.Drawing.Point(16, 255);
            this.Sharpness_SLD.Name = "Sharpness_SLD";
            this.Sharpness_SLD.Size = new System.Drawing.Size(196, 36);
            this.Sharpness_SLD.TabIndex = 8;
            this.Sharpness_SLD.Scroll += new System.EventHandler(this.Sharpness_SLD_Scroll);
            // 
            // Contrast_SLD
            // 
            this.Contrast_SLD.AutoSize = false;
            this.Contrast_SLD.Location = new System.Drawing.Point(16, 194);
            this.Contrast_SLD.Name = "Contrast_SLD";
            this.Contrast_SLD.Size = new System.Drawing.Size(196, 36);
            this.Contrast_SLD.TabIndex = 7;
            this.Contrast_SLD.Scroll += new System.EventHandler(this.Contrast_SLD_Scroll);
            // 
            // Brigtness_SLD
            // 
            this.Brigtness_SLD.AutoSize = false;
            this.Brigtness_SLD.Location = new System.Drawing.Point(16, 136);
            this.Brigtness_SLD.Name = "Brigtness_SLD";
            this.Brigtness_SLD.Size = new System.Drawing.Size(196, 36);
            this.Brigtness_SLD.TabIndex = 6;
            this.Brigtness_SLD.Scroll += new System.EventHandler(this.Brigtness_SLD_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shrapness:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contrast:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brightness:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(118, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Mulai";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CamList
            // 
            this.CamList.FormattingEnabled = true;
            this.CamList.Location = new System.Drawing.Point(16, 34);
            this.CamList.Name = "CamList";
            this.CamList.Size = new System.Drawing.Size(220, 27);
            this.CamList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "List Kamera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(518, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pengaturan";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(33, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 52);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pengaturan Kamera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.camera_addon_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.BackColor = System.Drawing.Color.White;
            this.cbDefault.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault.ForeColor = System.Drawing.Color.Black;
            this.cbDefault.Location = new System.Drawing.Point(34, 409);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(192, 26);
            this.cbDefault.TabIndex = 11;
            this.cbDefault.Text = "Pengaturan Bawaan";
            this.cbDefault.UseVisualStyleBackColor = false;
            this.cbDefault.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // CamSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 490);
            this.Controls.Add(this.cbDefault);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamSettingView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brigtness_SLD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CamList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar Brigtness_SLD;
        private System.Windows.Forms.TrackBar Sharpness_SLD;
        private System.Windows.Forms.TrackBar Contrast_SLD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Emgu.CV.UI.ImageBox PreviewImage;
        private System.Windows.Forms.Label Brigthness_LBL;
        private System.Windows.Forms.Label Sharpness_LBL;
        private System.Windows.Forms.Label Contrast_LBL;
        private System.Windows.Forms.CheckBox cbDefault;
    }
}
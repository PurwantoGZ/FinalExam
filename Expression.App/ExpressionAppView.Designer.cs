namespace Expression.App
{
    partial class ExpressionAppView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressionAppView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.statusF1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.yValuesText = new System.Windows.Forms.ToolStripStatusLabel();
            this.Accuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorText = new System.Windows.Forms.ToolStripStatusLabel();
            this.FaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ProsentaseText = new System.Windows.Forms.Label();
            this.ExpressionText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtJam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Notification = new NotificationWindow.PopupNotifier();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.picCropped = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.PreviewImage = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(30, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 52);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistem Cerdas Stimulun Ekspresi Sedih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Assistant";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusF1,
            this.statusF2,
            this.statusF3,
            this.statusF4,
            this.statusF5,
            this.statusF6,
            this.yValuesText,
            this.Accuracy,
            this.ErrorText,
            this.FaceCount});
            this.StatusBar.Location = new System.Drawing.Point(30, 449);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(686, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // statusF1
            // 
            this.statusF1.AutoSize = false;
            this.statusF1.Name = "statusF1";
            this.statusF1.Size = new System.Drawing.Size(48, 17);
            this.statusF1.Text = "F1";
            this.statusF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusF2
            // 
            this.statusF2.AutoSize = false;
            this.statusF2.Name = "statusF2";
            this.statusF2.Size = new System.Drawing.Size(48, 17);
            this.statusF2.Text = "F2";
            this.statusF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusF3
            // 
            this.statusF3.AutoSize = false;
            this.statusF3.Name = "statusF3";
            this.statusF3.Size = new System.Drawing.Size(48, 17);
            this.statusF3.Text = "F3";
            this.statusF3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusF4
            // 
            this.statusF4.AutoSize = false;
            this.statusF4.Name = "statusF4";
            this.statusF4.Size = new System.Drawing.Size(48, 17);
            this.statusF4.Text = "F4";
            this.statusF4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusF5
            // 
            this.statusF5.AutoSize = false;
            this.statusF5.Name = "statusF5";
            this.statusF5.Size = new System.Drawing.Size(60, 17);
            this.statusF5.Text = "F5";
            this.statusF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusF6
            // 
            this.statusF6.AutoSize = false;
            this.statusF6.Name = "statusF6";
            this.statusF6.Size = new System.Drawing.Size(60, 17);
            this.statusF6.Text = "F6";
            this.statusF6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yValuesText
            // 
            this.yValuesText.AutoSize = false;
            this.yValuesText.Name = "yValuesText";
            this.yValuesText.Size = new System.Drawing.Size(80, 17);
            this.yValuesText.Text = "Output";
            this.yValuesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Accuracy
            // 
            this.Accuracy.AutoSize = false;
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(60, 17);
            this.Accuracy.Text = "Accuracy";
            this.Accuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = false;
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(220, 17);
            this.ErrorText.Text = "Error";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FaceCount
            // 
            this.FaceCount.AutoSize = false;
            this.FaceCount.Name = "FaceCount";
            this.FaceCount.Size = new System.Drawing.Size(200, 17);
            this.FaceCount.Text = "Faces:";
            this.FaceCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Settings-48.png");
            this.imageList1.Images.SetKeyName(1, "User Menu Male-48.png");
            this.imageList1.Images.SetKeyName(2, "Next-48.png");
            this.imageList1.Images.SetKeyName(3, "Pause-48.png");
            this.imageList1.Images.SetKeyName(4, "Stop-48 (1).png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(30, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(686, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "MenuBar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.PreviewImage);
            this.panel1.Location = new System.Drawing.Point(30, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 355);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.picCropped);
            this.panel3.Controls.Add(this.ProsentaseText);
            this.panel3.Controls.Add(this.ExpressionText);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(493, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 355);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(4, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Citra Ekspresi";
            // 
            // ProsentaseText
            // 
            this.ProsentaseText.AutoSize = true;
            this.ProsentaseText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProsentaseText.Location = new System.Drawing.Point(12, 88);
            this.ProsentaseText.Name = "ProsentaseText";
            this.ProsentaseText.Size = new System.Drawing.Size(0, 17);
            this.ProsentaseText.TabIndex = 3;
            // 
            // ExpressionText
            // 
            this.ExpressionText.AutoSize = true;
            this.ExpressionText.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressionText.Location = new System.Drawing.Point(8, 45);
            this.ExpressionText.Name = "ExpressionText";
            this.ExpressionText.Size = new System.Drawing.Size(156, 43);
            this.ExpressionText.TabIndex = 2;
            this.ExpressionText.Text = "SENANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ekspresi Saat Ini:";
            // 
            // TxtJam
            // 
            this.TxtJam.AutoSize = true;
            this.TxtJam.BackColor = System.Drawing.Color.Teal;
            this.TxtJam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtJam.Location = new System.Drawing.Point(30, 88);
            this.TxtJam.Name = "TxtJam";
            this.TxtJam.Size = new System.Drawing.Size(102, 21);
            this.TxtJam.TabIndex = 22;
            this.TxtJam.Text = "Preview Citra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(494, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hasil Identifikasi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notification
            // 
            this.Notification.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.Notification.ContentText = null;
            this.Notification.Expression = null;
            this.Notification.ExpressionFont = null;
            this.Notification.HeaderColor = System.Drawing.Color.Teal;
            this.Notification.HeaderHeight = 15;
            this.Notification.Image = null;
            this.Notification.MessageInfo = null;
            this.Notification.MessageInfoFont = null;
            this.Notification.OptionsMenu = null;
            this.Notification.ShowOptionsButton = true;
            this.Notification.Size = new System.Drawing.Size(400, 100);
            this.Notification.TitleColor = System.Drawing.Color.Black;
            this.Notification.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Notification.TitleText = null;
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.BalloonTipText = "My Assistant Minimaze";
            this.TrayIcon.BalloonTipTitle = "Information";
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Sistem Cerdas";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMenu,
            this.AdminMenu,
            this.HelpMenu,
            this.toolStripSeparator2,
            this.ExitMenu});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(171, 120);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(170, 22);
            this.ShowMenu.Text = "My Assistant";
            this.ShowMenu.Click += new System.EventHandler(this.ShowMenu_Click);
            // 
            // AdminMenu
            // 
            this.AdminMenu.Enabled = false;
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(170, 22);
            this.AdminMenu.Text = "Dashboard Admin";
            this.AdminMenu.Click += new System.EventHandler(this.AdminMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(170, 22);
            this.HelpMenu.Text = "Bantuan";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(170, 22);
            this.ExitMenu.Text = "Keluar";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // picCropped
            // 
            this.picCropped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCropped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCropped.Location = new System.Drawing.Point(4, 144);
            this.picCropped.Name = "picCropped";
            this.picCropped.Size = new System.Drawing.Size(212, 206);
            this.picCropped.TabIndex = 4;
            this.picCropped.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.ImageIndex = 2;
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(176, 297);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PreviewImage
            // 
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.Location = new System.Drawing.Point(0, 0);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(455, 353);
            this.PreviewImage.TabIndex = 5;
            this.PreviewImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.Facial_Recognition_Scan_483;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeMenu
            // 
            this.HomeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDetail,
            this.toolSetting,
            this.toolStripSeparator1,
            this.toolExit});
            this.HomeMenu.Image = global::Expression.App.Properties.Resources.Menu_481;
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(105, 23);
            this.HomeMenu.Text = "Purwanto";
            this.HomeMenu.Click += new System.EventHandler(this.HomeMenu_Click);
            // 
            // toolDetail
            // 
            this.toolDetail.Image = global::Expression.App.Properties.Resources.Administrator_Male_96;
            this.toolDetail.Name = "toolDetail";
            this.toolDetail.Size = new System.Drawing.Size(202, 24);
            this.toolDetail.Text = "Data Diri";
            this.toolDetail.Click += new System.EventHandler(this.toolDetail_Click);
            // 
            // toolSetting
            // 
            this.toolSetting.Enabled = false;
            this.toolSetting.Image = global::Expression.App.Properties.Resources.Settings_48;
            this.toolSetting.Name = "toolSetting";
            this.toolSetting.Size = new System.Drawing.Size(202, 24);
            this.toolSetting.Text = "Pengaturan Akun";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // toolExit
            // 
            this.toolExit.Image = global::Expression.App.Properties.Resources.Close_Window_321;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(202, 24);
            this.toolExit.Text = "Keluar";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // ExpressionAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtJam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExpressionAppView";
            this.Padding = new System.Windows.Forms.Padding(30, 60, 30, 29);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.ExpressionAppView_Load);
            this.Resize += new System.EventHandler(this.ExpressionAppView_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeMenu;
        private System.Windows.Forms.ToolStripMenuItem toolDetail;
        private System.Windows.Forms.ToolStripMenuItem toolSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TxtJam;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox PreviewImage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusF1;
        private System.Windows.Forms.ToolStripStatusLabel statusF2;
        private System.Windows.Forms.ToolStripStatusLabel statusF3;
        private System.Windows.Forms.ToolStripStatusLabel statusF4;
        private System.Windows.Forms.ToolStripStatusLabel statusF5;
        private System.Windows.Forms.ToolStripStatusLabel statusF6;
        private System.Windows.Forms.ToolStripStatusLabel yValuesText;
        private System.Windows.Forms.ToolStripStatusLabel Accuracy;
        private System.Windows.Forms.ToolStripStatusLabel ErrorText;
        private NotificationWindow.PopupNotifier Notification;
        private System.Windows.Forms.ToolStripStatusLabel FaceCount;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem AdminMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowMenu;
        private System.Windows.Forms.Label ExpressionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProsentaseText;
        private System.Windows.Forms.PictureBox picCropped;
        private System.Windows.Forms.Label label5;
    }
}
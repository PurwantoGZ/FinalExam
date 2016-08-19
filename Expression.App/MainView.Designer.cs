namespace Expression.App
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUserData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHasilTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTesting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolJST = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.newUserTool = new System.Windows.Forms.ToolStripButton();
            this.trainingTool = new System.Windows.Forms.ToolStripButton();
            this.testingTool = new System.Windows.Forms.ToolStripButton();
            this.helpTool = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconBar = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMenu,
            this.ProcessMenu,
            this.toolSetting,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.MdiWindowListItem = this.ProcessMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(960, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dataMenu
            // 
            this.dataMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUserData,
            this.toolHasilTraining});
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.Size = new System.Drawing.Size(43, 19);
            this.dataMenu.Text = "&Data";
            // 
            // toolUserData
            // 
            this.toolUserData.Image = global::Expression.App.Properties.Resources.manager_48;
            this.toolUserData.Name = "toolUserData";
            this.toolUserData.Size = new System.Drawing.Size(156, 22);
            this.toolUserData.Text = "Data User";
            this.toolUserData.Click += new System.EventHandler(this.toolUserData_Click);
            // 
            // toolHasilTraining
            // 
            this.toolHasilTraining.Image = global::Expression.App.Properties.Resources.Combo_Chart_48;
            this.toolHasilTraining.Name = "toolHasilTraining";
            this.toolHasilTraining.Size = new System.Drawing.Size(156, 22);
            this.toolHasilTraining.Text = "Hasil Pengujian";
            // 
            // ProcessMenu
            // 
            this.ProcessMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTraining,
            this.toolTesting});
            this.ProcessMenu.Name = "ProcessMenu";
            this.ProcessMenu.Size = new System.Drawing.Size(53, 19);
            this.ProcessMenu.Text = "&Proses";
            // 
            // toolTraining
            // 
            this.toolTraining.Image = global::Expression.App.Properties.Resources.Training_482;
            this.toolTraining.Name = "toolTraining";
            this.toolTraining.Size = new System.Drawing.Size(157, 22);
            this.toolTraining.Text = "Pelatihan Data";
            this.toolTraining.Click += new System.EventHandler(this.toolTraining_Click);
            // 
            // toolTesting
            // 
            this.toolTesting.Image = global::Expression.App.Properties.Resources.survey_481;
            this.toolTesting.Name = "toolTesting";
            this.toolTesting.Size = new System.Drawing.Size(157, 22);
            this.toolTesting.Text = "Pengujian Data ";
            this.toolTesting.Click += new System.EventHandler(this.toolTesting_Click);
            // 
            // toolSetting
            // 
            this.toolSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCamera,
            this.toolJST});
            this.toolSetting.Name = "toolSetting";
            this.toolSetting.Size = new System.Drawing.Size(80, 19);
            this.toolSetting.Text = "Pengaturan";
            // 
            // toolCamera
            // 
            this.toolCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolCamera.Image = global::Expression.App.Properties.Resources.automatic_24;
            this.toolCamera.Name = "toolCamera";
            this.toolCamera.Size = new System.Drawing.Size(184, 22);
            this.toolCamera.Text = "Kamera";
            this.toolCamera.Click += new System.EventHandler(this.toolCamera_Click);
            // 
            // toolJST
            // 
            this.toolJST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolJST.Image = global::Expression.App.Properties.Resources.mind_map_24;
            this.toolJST.Name = "toolJST";
            this.toolJST.Size = new System.Drawing.Size(184, 22);
            this.toolJST.Text = "Jaringan Saraf Tiruan";
            this.toolJST.Click += new System.EventHandler(this.toolJST_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StepToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(63, 19);
            this.helpMenu.Text = "&Bantuan";
            // 
            // StepToolStripMenuItem
            // 
            this.StepToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StepToolStripMenuItem.Image")));
            this.StepToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.StepToolStripMenuItem.Name = "StepToolStripMenuItem";
            this.StepToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.StepToolStripMenuItem.Text = "&Cara Penggunaan";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&Tentang";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatus});
            this.statusStrip.Location = new System.Drawing.Point(20, 658);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(960, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MainStatus
            // 
            this.MainStatus.AutoSize = false;
            this.MainStatus.ForeColor = System.Drawing.Color.Teal;
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(200, 17);
            this.MainStatus.Text = "Status";
            this.MainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolBar
            // 
            this.toolBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.newUserTool,
            this.trainingTool,
            this.testingTool,
            this.helpTool});
            this.toolBar.Location = new System.Drawing.Point(20, 85);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(960, 39);
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 36);
            this.toolStripLabel1.Text = "|";
            // 
            // newUserTool
            // 
            this.newUserTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newUserTool.Image = global::Expression.App.Properties.Resources.add_image_48;
            this.newUserTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newUserTool.Name = "newUserTool";
            this.newUserTool.Size = new System.Drawing.Size(165, 36);
            this.newUserTool.Text = "Tambah Data Pelatihan";
            this.newUserTool.Click += new System.EventHandler(this.newUserTool_Click);
            // 
            // trainingTool
            // 
            this.trainingTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainingTool.Image = global::Expression.App.Properties.Resources.Training_48;
            this.trainingTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trainingTool.Name = "trainingTool";
            this.trainingTool.Size = new System.Drawing.Size(119, 36);
            this.trainingTool.Text = "Pelatihan Data";
            this.trainingTool.Click += new System.EventHandler(this.trainingTool_Click);
            // 
            // testingTool
            // 
            this.testingTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testingTool.Image = global::Expression.App.Properties.Resources.survey_48;
            this.testingTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testingTool.Name = "testingTool";
            this.testingTool.Size = new System.Drawing.Size(126, 36);
            this.testingTool.Text = "Pengujian Data ";
            this.testingTool.Click += new System.EventHandler(this.testingTool_Click);
            // 
            // helpTool
            // 
            this.helpTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpTool.Image = global::Expression.App.Properties.Resources.Help_48;
            this.helpTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpTool.Name = "helpTool";
            this.helpTool.Size = new System.Drawing.Size(87, 36);
            this.helpTool.Text = "Bantuan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IconBar);
            this.panel1.Location = new System.Drawing.Point(20, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 44);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard Admin ||Sistem Deteksi Ekspresi";
            // 
            // IconBar
            // 
            this.IconBar.BackgroundImage = global::Expression.App.Properties.Resources.Expression;
            this.IconBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconBar.Location = new System.Drawing.Point(0, 0);
            this.IconBar.Name = "IconBar";
            this.IconBar.Size = new System.Drawing.Size(55, 44);
            this.IconBar.TabIndex = 0;
            this.IconBar.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Dashboard Admin";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel MainStatus;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMenu;
        private System.Windows.Forms.ToolStripMenuItem ProcessMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem StepToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolTraining;
        private System.Windows.Forms.ToolStripMenuItem toolTesting;
        private System.Windows.Forms.ToolStripMenuItem toolUserData;
        private System.Windows.Forms.ToolStripMenuItem toolHasilTraining;
        private System.Windows.Forms.ToolStripMenuItem toolSetting;
        private System.Windows.Forms.ToolStripMenuItem toolCamera;
        private System.Windows.Forms.ToolStripMenuItem toolJST;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton newUserTool;
        private System.Windows.Forms.ToolStripButton trainingTool;
        private System.Windows.Forms.ToolStripButton testingTool;
        private System.Windows.Forms.ToolStripButton helpTool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IconBar;
        private System.Windows.Forms.Label label1;
    }
}




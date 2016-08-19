namespace Expression.App
{
    partial class TrainingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Terminal = new System.Windows.Forms.ListBox();
            this.cbLearnRate = new System.Windows.Forms.NumericUpDown();
            this.cbGalat = new System.Windows.Forms.NumericUpDown();
            this.txtMaxEpoch = new System.Windows.Forms.TextBox();
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewData = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Grafik = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TestingResult = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusInfo = new System.Windows.Forms.StatusStrip();
            this.ProgressInfo = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TrueValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.FalseValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLearnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGalat)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.StatusInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cbLearnRate);
            this.panel1.Controls.Add(this.cbGalat);
            this.panel1.Controls.Add(this.txtMaxEpoch);
            this.panel1.Controls.Add(this.btnStartTraining);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnViewData);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.Terminal);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.SystemColors.InfoText;
            this.Terminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Terminal, "Terminal");
            this.Terminal.ForeColor = System.Drawing.Color.Turquoise;
            this.Terminal.FormattingEnabled = true;
            this.Terminal.Name = "Terminal";
            // 
            // cbLearnRate
            // 
            this.cbLearnRate.DecimalPlaces = 1;
            resources.ApplyResources(this.cbLearnRate, "cbLearnRate");
            this.cbLearnRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cbLearnRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbLearnRate.Name = "cbLearnRate";
            this.cbLearnRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // cbGalat
            // 
            this.cbGalat.DecimalPlaces = 2;
            resources.ApplyResources(this.cbGalat, "cbGalat");
            this.cbGalat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cbGalat.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbGalat.Name = "cbGalat";
            this.cbGalat.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // txtMaxEpoch
            // 
            resources.ApplyResources(this.txtMaxEpoch, "txtMaxEpoch");
            this.txtMaxEpoch.Name = "txtMaxEpoch";
            // 
            // btnStartTraining
            // 
            resources.ApplyResources(this.btnStartTraining, "btnStartTraining");
            this.btnStartTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTraining.ImageList = this.imageList1;
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            this.btnStartTraining.Click += new System.EventHandler(this.btnStartTraining_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Class-48.png");
            this.imageList1.Images.SetKeyName(1, "Curriculum-48.png");
            this.imageList1.Images.SetKeyName(2, "Google Classroom-48.png");
            this.imageList1.Images.SetKeyName(3, "Identity Theft-48.png");
            this.imageList1.Images.SetKeyName(4, "Knowledge Sharing-48.png");
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnViewData
            // 
            this.btnViewData.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnViewData, "btnViewData");
            this.btnViewData.FlatAppearance.BorderSize = 0;
            this.btnViewData.ImageList = this.imageList1;
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Tag = "Detail Profil User";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // cbUser
            // 
            resources.ApplyResources(this.cbUser, "cbUser");
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Name = "cbUser";
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Grafik);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Grafik
            // 
            resources.ApplyResources(this.Grafik, "Grafik");
            this.Grafik.Name = "Grafik";
            this.Grafik.ScrollGrace = 0D;
            this.Grafik.ScrollMaxX = 0D;
            this.Grafik.ScrollMaxY = 0D;
            this.Grafik.ScrollMaxY2 = 0D;
            this.Grafik.ScrollMinX = 0D;
            this.Grafik.ScrollMinY = 0D;
            this.Grafik.ScrollMinY2 = 0D;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TestingResult);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // TestingResult
            // 
            this.TestingResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TestingResult, "TestingResult");
            this.TestingResult.ForeColor = System.Drawing.Color.Teal;
            this.TestingResult.FormattingEnabled = true;
            this.TestingResult.Name = "TestingResult";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // StatusInfo
            // 
            resources.ApplyResources(this.StatusInfo, "StatusInfo");
            this.StatusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressInfo,
            this.toolStripStatusLabel1,
            this.TrueValue,
            this.FalseValue});
            this.StatusInfo.Name = "StatusInfo";
            // 
            // ProgressInfo
            // 
            this.ProgressInfo.ForeColor = System.Drawing.Color.Teal;
            this.ProgressInfo.Name = "ProgressInfo";
            resources.ApplyResources(this.ProgressInfo, "ProgressInfo");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Teal;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // TrueValue
            // 
            this.TrueValue.BackColor = System.Drawing.Color.Transparent;
            this.TrueValue.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.TrueValue, "TrueValue");
            this.TrueValue.Name = "TrueValue";
            // 
            // FalseValue
            // 
            this.FalseValue.BackColor = System.Drawing.Color.Transparent;
            this.FalseValue.ForeColor = System.Drawing.Color.Teal;
            this.FalseValue.Name = "FalseValue";
            resources.ApplyResources(this.FalseValue, "FalseValue");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.Training_481;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TrainingView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.StatusInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingView";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.TrainingView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbLearnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGalat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.StatusInfo.ResumeLayout(false);
            this.StatusInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox Terminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.TextBox txtMaxEpoch;
        private System.Windows.Forms.NumericUpDown cbGalat;
        private System.Windows.Forms.NumericUpDown cbLearnRate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private ZedGraph.ZedGraphControl Grafik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox TestingResult;
        private System.Windows.Forms.StatusStrip StatusInfo;
        private System.Windows.Forms.ToolStripProgressBar ProgressInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripStatusLabel TrueValue;
        private System.Windows.Forms.ToolStripStatusLabel FalseValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}
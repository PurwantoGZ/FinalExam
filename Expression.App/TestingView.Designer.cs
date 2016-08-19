namespace Expression.App
{
    partial class TestingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.LblTerlatih = new System.Windows.Forms.Label();
            this.LblTakTerlatih = new System.Windows.Forms.Label();
            this.btnTesting = new System.Windows.Forms.Button();
            this.ResultTerlatih = new System.Windows.Forms.Label();
            this.ResultTakTerlatih = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkmark-48.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(33, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 55);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.survey_482;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengujian Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pengujian Data Terlatih dan Tidak Terlatih";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(40, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 262);
            this.panel1.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Teal;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(8, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 224);
            this.listBox1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(432, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 262);
            this.panel2.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Teal;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(11, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(360, 224);
            this.listBox2.TabIndex = 0;
            // 
            // LblTerlatih
            // 
            this.LblTerlatih.AutoSize = true;
            this.LblTerlatih.BackColor = System.Drawing.Color.Teal;
            this.LblTerlatih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTerlatih.Location = new System.Drawing.Point(45, 91);
            this.LblTerlatih.Name = "LblTerlatih";
            this.LblTerlatih.Size = new System.Drawing.Size(98, 19);
            this.LblTerlatih.TabIndex = 27;
            this.LblTerlatih.Text = "Data Terlatih";
            // 
            // LblTakTerlatih
            // 
            this.LblTakTerlatih.AutoSize = true;
            this.LblTakTerlatih.BackColor = System.Drawing.Color.Teal;
            this.LblTakTerlatih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTakTerlatih.Location = new System.Drawing.Point(438, 89);
            this.LblTakTerlatih.Name = "LblTakTerlatih";
            this.LblTakTerlatih.Size = new System.Drawing.Size(140, 19);
            this.LblTakTerlatih.TabIndex = 28;
            this.LblTakTerlatih.Text = "Data Tidak Terlatih";
            // 
            // btnTesting
            // 
            this.btnTesting.ImageIndex = 0;
            this.btnTesting.ImageList = this.imageList1;
            this.btnTesting.Location = new System.Drawing.Point(688, 394);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(130, 39);
            this.btnTesting.TabIndex = 29;
            this.btnTesting.Text = "Uji Data";
            this.btnTesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // ResultTerlatih
            // 
            this.ResultTerlatih.AutoSize = true;
            this.ResultTerlatih.ForeColor = System.Drawing.Color.Teal;
            this.ResultTerlatih.Location = new System.Drawing.Point(45, 368);
            this.ResultTerlatih.Name = "ResultTerlatih";
            this.ResultTerlatih.Size = new System.Drawing.Size(235, 19);
            this.ResultTerlatih.TabIndex = 30;
            this.ResultTerlatih.Text = "Ketepatan : 0 %, Kesalahan : 0 %";
            // 
            // ResultTakTerlatih
            // 
            this.ResultTakTerlatih.AutoSize = true;
            this.ResultTakTerlatih.ForeColor = System.Drawing.Color.Teal;
            this.ResultTakTerlatih.Location = new System.Drawing.Point(440, 368);
            this.ResultTakTerlatih.Name = "ResultTakTerlatih";
            this.ResultTakTerlatih.Size = new System.Drawing.Size(235, 19);
            this.ResultTakTerlatih.TabIndex = 31;
            this.ResultTakTerlatih.Text = "Ketepatan : 0 %, Kesalahan : 0 %";
            // 
            // TestingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 465);
            this.Controls.Add(this.LblTakTerlatih);
            this.Controls.Add(this.LblTerlatih);
            this.Controls.Add(this.ResultTakTerlatih);
            this.Controls.Add(this.ResultTerlatih);
            this.Controls.Add(this.btnTesting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestingView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.TestingView_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTerlatih;
        private System.Windows.Forms.Label LblTakTerlatih;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Label ResultTerlatih;
        private System.Windows.Forms.Label ResultTakTerlatih;
    }
}
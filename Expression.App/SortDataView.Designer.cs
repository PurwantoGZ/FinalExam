namespace Expression.App
{
    partial class SortDataView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trainingData = new System.Windows.Forms.DataGridView();
            this.checkList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFinishData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trainingData);
            this.panel1.Location = new System.Drawing.Point(30, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 271);
            this.panel1.TabIndex = 0;
            // 
            // trainingData
            // 
            this.trainingData.AllowUserToAddRows = false;
            this.trainingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkList});
            this.trainingData.Dock = System.Windows.Forms.DockStyle.Top;
            this.trainingData.Location = new System.Drawing.Point(0, 0);
            this.trainingData.Name = "trainingData";
            this.trainingData.Size = new System.Drawing.Size(664, 275);
            this.trainingData.TabIndex = 0;
            this.trainingData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainingData_CellClick);
            // 
            // checkList
            // 
            this.checkList.HeaderText = "";
            this.checkList.Name = "checkList";
            this.checkList.Width = 25;
            // 
            // btnFinishData
            // 
            this.btnFinishData.Enabled = false;
            this.btnFinishData.Location = new System.Drawing.Point(587, 371);
            this.btnFinishData.Name = "btnFinishData";
            this.btnFinishData.Size = new System.Drawing.Size(105, 35);
            this.btnFinishData.TabIndex = 1;
            this.btnFinishData.Text = "Pilih";
            this.btnFinishData.UseVisualStyleBackColor = true;
            this.btnFinishData.Click += new System.EventHandler(this.btnFinishData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(30, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 56);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Pelatihan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expression.App.Properties.Resources.todo_list_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(96, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pemilihan Data Pelatihan";
            // 
            // SortDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 431);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFinishData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SortDataView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.SortDataView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinishData;
        private System.Windows.Forms.DataGridView trainingData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Expression.App
{
    partial class HistoryView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TableHistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.GrafikHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrafikHistory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grafik Riwayat";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 61);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purwanto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Riwayat Identifikasi Ekspresi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Expression.App.Properties.Resources.statistics_481;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TableHistory);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(481, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // TableHistory
            // 
            this.TableHistory.AllowUserToAddRows = false;
            this.TableHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableHistory.Location = new System.Drawing.Point(3, 22);
            this.TableHistory.Name = "TableHistory";
            this.TableHistory.Size = new System.Drawing.Size(424, 290);
            this.TableHistory.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tabel Riwayat";
            // 
            // GrafikHistory
            // 
            this.GrafikHistory.BorderlineWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.GrafikHistory.ChartAreas.Add(chartArea4);
            this.GrafikHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.GrafikHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.GrafikHistory.Legends.Add(legend4);
            this.GrafikHistory.Location = new System.Drawing.Point(3, 22);
            this.GrafikHistory.Name = "GrafikHistory";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.EmptyPointStyle.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Sedih";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.EmptyPointStyle.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Senang";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.GrafikHistory.Series.Add(series7);
            this.GrafikHistory.Series.Add(series8);
            this.GrafikHistory.Size = new System.Drawing.Size(436, 290);
            this.GrafikHistory.TabIndex = 1;
            this.GrafikHistory.Text = "chart1";
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.HistoryView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TableHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikHistory;
    }
}
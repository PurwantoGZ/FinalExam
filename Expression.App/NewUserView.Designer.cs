namespace Expression.App
{
    partial class NewUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserView));
            this.label15 = new System.Windows.Forms.Label();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.Daftar = new System.Windows.Forms.Button();
            this.notif = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFavorite = new System.Windows.Forms.Panel();
            this.notification = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtGambar = new System.Windows.Forms.TextBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtMusic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelExkpresi = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cbOutput = new MetroFramework.Controls.MetroComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelCapture = new System.Windows.Forms.Panel();
            this.btnCapture = new System.Windows.Forms.Button();
            this.PreviewImage = new Emgu.CV.UI.ImageBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelUser.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            this.panelExkpresi.SuspendLayout();
            this.PanelCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Isilah data pribadi anda dengan benar.";
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelUser.Controls.Add(this.PassWordText);
            this.PanelUser.Controls.Add(this.Daftar);
            this.PanelUser.Controls.Add(this.notif);
            this.PanelUser.Controls.Add(this.fullName);
            this.PanelUser.Controls.Add(this.userID);
            this.PanelUser.Controls.Add(this.label4);
            this.PanelUser.Controls.Add(this.label3);
            this.PanelUser.Controls.Add(this.label2);
            this.PanelUser.Controls.Add(this.label1);
            this.PanelUser.Location = new System.Drawing.Point(27, 91);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(376, 194);
            this.PanelUser.TabIndex = 17;
            // 
            // PassWordText
            // 
            this.PassWordText.Location = new System.Drawing.Point(22, 151);
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.PasswordChar = '*';
            this.PassWordText.Size = new System.Drawing.Size(233, 26);
            this.PassWordText.TabIndex = 2;
            this.PassWordText.Text = "-";
            // 
            // Daftar
            // 
            this.Daftar.Enabled = false;
            this.Daftar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daftar.ImageKey = "add_user-48.png";
            this.Daftar.Location = new System.Drawing.Point(265, 149);
            this.Daftar.Name = "Daftar";
            this.Daftar.Size = new System.Drawing.Size(87, 34);
            this.Daftar.TabIndex = 3;
            this.Daftar.Text = "Daftar";
            this.Daftar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Daftar.UseVisualStyleBackColor = true;
            // 
            // notif
            // 
            this.notif.AutoSize = true;
            this.notif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif.Location = new System.Drawing.Point(239, 42);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(16, 15);
            this.notif.TabIndex = 8;
            this.notif.Text = "*)";
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fullName.Location = new System.Drawing.Point(22, 98);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(330, 29);
            this.fullName.TabIndex = 1;
            this.fullName.Text = "Masukkan nama lengkap anda";
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userID.Location = new System.Drawing.Point(22, 42);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(211, 29);
            this.userID.TabIndex = 0;
            this.userID.Text = "Masukkan email anda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Lengkap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Akun";
            // 
            // panelFavorite
            // 
            this.panelFavorite.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelFavorite.Controls.Add(this.notification);
            this.panelFavorite.Controls.Add(this.btnFavorite);
            this.panelFavorite.Controls.Add(this.txtWarna);
            this.panelFavorite.Controls.Add(this.txtBook);
            this.panelFavorite.Controls.Add(this.txtGambar);
            this.panelFavorite.Controls.Add(this.txtVideo);
            this.panelFavorite.Controls.Add(this.txtMovie);
            this.panelFavorite.Controls.Add(this.txtMusic);
            this.panelFavorite.Controls.Add(this.label12);
            this.panelFavorite.Controls.Add(this.label11);
            this.panelFavorite.Controls.Add(this.label10);
            this.panelFavorite.Controls.Add(this.label9);
            this.panelFavorite.Controls.Add(this.label8);
            this.panelFavorite.Controls.Add(this.label7);
            this.panelFavorite.Controls.Add(this.label5);
            this.panelFavorite.Location = new System.Drawing.Point(27, 291);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Size = new System.Drawing.Size(376, 417);
            this.panelFavorite.TabIndex = 18;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Green;
            this.notification.Location = new System.Drawing.Point(19, 358);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(66, 15);
            this.notification.TabIndex = 21;
            this.notification.Text = "notification";
            // 
            // btnFavorite
            // 
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.ImageKey = "save-48.png";
            this.btnFavorite.Location = new System.Drawing.Point(265, 367);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(87, 36);
            this.btnFavorite.TabIndex = 10;
            this.btnFavorite.Text = "Simpan";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // txtWarna
            // 
            this.txtWarna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarna.Location = new System.Drawing.Point(22, 326);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(330, 29);
            this.txtWarna.TabIndex = 9;
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(22, 270);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(330, 29);
            this.txtBook.TabIndex = 8;
            // 
            // txtGambar
            // 
            this.txtGambar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGambar.Location = new System.Drawing.Point(22, 214);
            this.txtGambar.Name = "txtGambar";
            this.txtGambar.Size = new System.Drawing.Size(330, 29);
            this.txtGambar.TabIndex = 7;
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideo.Location = new System.Drawing.Point(22, 160);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(330, 29);
            this.txtVideo.TabIndex = 6;
            // 
            // txtMovie
            // 
            this.txtMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.Location = new System.Drawing.Point(22, 104);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(330, 29);
            this.txtMovie.TabIndex = 5;
            // 
            // txtMusic
            // 
            this.txtMusic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusic.Location = new System.Drawing.Point(22, 48);
            this.txtMusic.Name = "txtMusic";
            this.txtMusic.Size = new System.Drawing.Size(330, 29);
            this.txtMusic.TabIndex = 4;
            this.txtMusic.Text = "Masukkan musik kesukaan anda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(18, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Apa warna favoritmu ?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(18, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Buku apa yang sering kamu baca ?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(18, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Gambar tentang apa yang suka ?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(18, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Video lucu apa yang kamus suka ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(18, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Film apa yang sering kamu tonton ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Musik apa yang sering kamu dengarkan ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ketika kamu sedih, ";
            // 
            // panelExkpresi
            // 
            this.panelExkpresi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelExkpresi.Controls.Add(this.label14);
            this.panelExkpresi.Controls.Add(this.cbOutput);
            this.panelExkpresi.Controls.Add(this.btnStart);
            this.panelExkpresi.Controls.Add(this.label13);
            this.panelExkpresi.Controls.Add(this.PanelCapture);
            this.panelExkpresi.Controls.Add(this.label6);
            this.panelExkpresi.Location = new System.Drawing.Point(409, 91);
            this.panelExkpresi.Name = "panelExkpresi";
            this.panelExkpresi.Size = new System.Drawing.Size(476, 615);
            this.panelExkpresi.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "*) Setiap Ekspresi min. 5 posisi";
            // 
            // cbOutput
            // 
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.ItemHeight = 23;
            this.cbOutput.Location = new System.Drawing.Point(20, 44);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(234, 29);
            this.cbOutput.TabIndex = 11;
            this.cbOutput.UseSelectable = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.ImageIndex = 2;
            this.btnStart.Location = new System.Drawing.Point(260, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Mulai";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Pilih Ekspresimu";
            // 
            // PanelCapture
            // 
            this.PanelCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCapture.Controls.Add(this.btnCapture);
            this.PanelCapture.Controls.Add(this.PreviewImage);
            this.PanelCapture.Location = new System.Drawing.Point(19, 98);
            this.PanelCapture.Name = "PanelCapture";
            this.PanelCapture.Size = new System.Drawing.Size(439, 505);
            this.PanelCapture.TabIndex = 10;
            // 
            // btnCapture
            // 
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.ImageIndex = 1;
            this.btnCapture.Location = new System.Drawing.Point(0, 458);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(437, 45);
            this.btnCapture.TabIndex = 12;
            this.btnCapture.UseVisualStyleBackColor = true;
            // 
            // PreviewImage
            // 
            this.PreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage.Location = new System.Drawing.Point(0, 0);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(437, 503);
            this.PreviewImage.TabIndex = 2;
            this.PreviewImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Perkenalkan Ekspresimu:";
            // 
            // NewUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 727);
            this.Controls.Add(this.panelExkpresi);
            this.Controls.Add(this.panelFavorite);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserView";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Formulir Pendaftaraan User";
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.panelFavorite.ResumeLayout(false);
            this.panelFavorite.PerformLayout();
            this.panelExkpresi.ResumeLayout(false);
            this.panelExkpresi.PerformLayout();
            this.PanelCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.TextBox PassWordText;
        private System.Windows.Forms.Button Daftar;
        private System.Windows.Forms.Label notif;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFavorite;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtGambar;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelExkpresi;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroComboBox cbOutput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel PanelCapture;
        private System.Windows.Forms.Button btnCapture;
        private Emgu.CV.UI.ImageBox PreviewImage;
        private System.Windows.Forms.Label label6;
    }
}
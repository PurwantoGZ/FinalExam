﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Expression;
namespace Expression.App
{
    public partial class NewUserView : MetroForm
    {
        Database db = new Database();
        Face _face = new Face();
        Helper help = new Helper();
        string idUser;
        string[] favoriteName = new string[6];
        int[] idFavorite = new int[6];
        int[] priority = new int[6];
        public int numCapture = 0;
        string idOutput = null;
        string F1, F2, F3, F4, F5, F6;
        #region Capture Properties
        Mat frame = new Mat();
        private Capture _capture = null;
        #endregion
        #region PROPERTIES FEATURES
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
        int[] mataX1 = new int[3];
        int[] mataX2 = new int[3];
        int[] mataY1 = new int[3];
        int[] mataY2 = new int[3];

        int[] alisX1 = new int[3];
        int[] alisX2 = new int[3];
        int[] alisY1 = new int[3];
        int[] alisY2 = new int[3];
        double f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0;
        #endregion
        public NewUserView()
        {
            InitializeComponent();
            panelFavorite.Enabled = false;
            PanelCapture.Enabled = false;
            panelExkpresi.Enabled = false;
            userID.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {

                if (numCapture == 1 || numCapture == 0)
                {
                    MessageBox.Show("Anda belum mengidentifikasi ekspresi anda. \n Silahkan identifisikan dahulu :)", "Konfirmasi");
                }
                else
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void runCapture()
        {
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> mouths = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            String faceFileName = "haarcascade_frontalface_default.xml";
            String mouthFileName = "haarcascade_mcs_mouth.xml";
            String eyeFileName = "haarcascade_eye.xml";


            _face.Detect(frame, faceFileName, mouthFileName, eyeFileName, faces, mouths, eyes, ref x1, ref y1, ref x2, ref y2,
                ref mataX1, ref mataY1, ref mataX2, ref mataY2,
                ref alisX1, ref alisY1, ref alisX2, ref alisY2);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);

            foreach (Rectangle mouth in mouths)
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Aquamarine).MCvScalar, 2);

            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            PreviewImage.Image = frame;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            _capture.Retrieve(frame, 0); runCapture();
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void ComputeFeature()
        {
            _face.Mouth(x1, y1, x2, y2, ref f3);
            _face.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
            _face.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);

            F1 = f1.ToString("#.##");
            F2 = f2.ToString("#.##");
            F3 = f3.ToString("#.##");
            F4 = f4.ToString("#.##");
            F5 = f5.ToString("#.##");
            F6 = f6.ToString("#.##");
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                idUser = userID.Text;
                favoriteName[0] =txtMusic.Text;
                favoriteName[1] =txtMovie.Text;
                favoriteName[2] =txtVideo.Text;
                favoriteName[3] =txtGambar.Text;
                favoriteName[4] =txtBook.Text;
                favoriteName[5] = "Pemandangan dengan warna "+txtWarna.Text;
                bool message = false;
                if (btnSaveData.Text.Equals("Simpan"))
                {
                    #region Simpan
                    for (int i = 0; i < favoriteName.Length; i++)
                    {
                        message = (db.saveFavorite(favoriteName[i], idUser, i)) ? true : false;
                    }
                    if (message)
                    {
                        notification.Text = "Sukses";
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipTitle = "Sukses";
                        notifyIcon1.BalloonTipText = "Data telah disimpan";
                        notifyIcon1.ShowBalloonTip(100);

                        btnSaveData.Text = "Ubah";
                        txtMusic.Clear();
                        txtMovie.Clear();
                        txtVideo.Clear();
                        txtGambar.Clear();
                        txtBook.Clear();
                        txtWarna.Clear();
                        db.getFavorite(idUser, out favoriteName, out priority, out idFavorite);
                        txtMusic.Text = favoriteName[0];
                        txtMovie.Text = favoriteName[1];
                        txtVideo.Text = favoriteName[2];
                        txtGambar.Text = favoriteName[3];
                        txtBook.Text = favoriteName[4];
                        txtWarna.Text = favoriteName[5];
                        PanelCapture.Enabled = true;
                        panelExkpresi.Enabled = true;
                    }
                    else
                    {
                        notification.ForeColor = Color.Red;
                        notification.Text = "Gagal, Terjadi Kesalahan.";
                    }
                    #endregion
                }
                else
                {
                    #region Ubah
                    for (int i = 0; i < favoriteName.Length; i++)
                    {
                        message = (db.updateFavorite(idFavorite[i], favoriteName[i])) ? true : false;
                    }
                    if (message)
                    {
                        notification.Text = "Data telah dirubah";
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipTitle = "Sukses";
                        notifyIcon1.BalloonTipText = "Data telah dirubah";
                        notifyIcon1.ShowBalloonTip(100);
                        txtMusic.Clear();
                        txtMovie.Clear();
                        txtVideo.Clear();
                        txtGambar.Clear();
                        txtBook.Clear();
                        txtWarna.Clear();
                        db.getFavorite(idUser, out favoriteName, out priority, out idFavorite);
                        txtMusic.Text = favoriteName[0];
                        txtMovie.Text = favoriteName[1];
                        txtVideo.Text = favoriteName[2];
                        txtGambar.Text = favoriteName[3];
                        txtBook.Text = favoriteName[4];
                        txtWarna.Text = favoriteName[5];
                    }
                    else
                    {
                        notification.Text = "Gagal";
                        notification.ForeColor = Color.Red;
                    }
                    #endregion
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {

                if (numCapture <= 5)
                {
                    _capture.Pause(); ComputeFeature();
                    if (db.saveTrainingData(idUser, idOutput, F1, F2, F3, F4, F5, F6))
                    {
                        DialogResult dialogResult = MessageBox.Show("Ambil Ekspresi Lagi ?", "Berhasil, "
                            + numCapture + " Capture.", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _capture.Start();
                            numCapture++;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            _capture.Dispose();
                            btnStart.Text = "Mulai"; btnStart.ImageIndex = 2;
                        }

                    }
                    else
                    {
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        notifyIcon1.BalloonTipTitle = "Informasi";
                        notifyIcon1.BalloonTipText = "User ID gagal didaftarkan";
                        notifyIcon1.ShowBalloonTip(100);
                    }
                }
                else
                {
                    MessageBox.Show("Anda sudah memasukkan 5 kali, \nSilahkan tutup form ini\n kemudian login", "Maksimal Capture 5 kali.");
                    _capture.Dispose();
                    btnStart.Text = "Mulai"; btnStart.ImageIndex = 2;
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {

                if (db.saveUser(userID.Text, fullName.Text, PassWordText.Text) == true)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Informasi";
                    notifyIcon1.BalloonTipText = "User ID Siap digunakan.";
                    notifyIcon1.ShowBalloonTip(100);
                    userID.Enabled = false;
                    fullName.Enabled = false;
                    panelFavorite.Enabled = true; txtMusic.Focus();
                }
                else
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.BalloonTipTitle = "Informasi";
                    notifyIcon1.BalloonTipText = "User ID gagal didaftarkan";
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Mulai"))
            {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture = new Capture();
                    _capture.ImageGrabbed += ProcessFrame;
                    btnStart.Text = "Berhenti";
                    btnStart.ImageIndex = 3;
                    _capture.Start();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else
            {
                _capture.Dispose();
                btnStart.Text = "Mulai"; btnStart.ImageIndex = 2;
            }
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {
            if (userID.Text == "")
            {
                notif.Text = "";
            }
            else
            {
                if (help.IsValidEmail(userID.Text))
                {
                    if (db.checkId(userID.Text) == true)
                    {
                        notif.Text = "User id sudah digunakan !";
                        btnSignUp.Enabled = false;
                        this.Refresh();
                    }
                    else
                    {
                        notif.Text = "User id tersedia";
                        btnSignUp.Enabled = true;
                        this.Refresh();
                    }
                }
                else
                {
                    notif.Text = "user id tidak valid";
                    btnSignUp.Enabled = false;
                    this.Refresh();
                }
            }
        }

        private void userID_Click(object sender, EventArgs e)
        {
            userID.Clear();
        }

        private void fullName_Click(object sender, EventArgs e)
        {
            fullName.Clear();
        }

        private void txtMusic_Click(object sender, EventArgs e)
        {
            txtMusic.Clear();
        }

        private void NewUserView_Load(object sender, EventArgs e)
        {
            db.getOutput(ref cbOutput);
            cbOutput.SelectedIndex = 0;
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.getIdOutput(cbOutput.Text, ref idOutput);
            btnStart.Enabled = true;
            numCapture = 1;
        }

    }
}

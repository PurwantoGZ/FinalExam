using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Expression;
namespace Expression.App
{
    public partial class DetailProfilView : MetroForm
    {
        string IdUser;
        Database db = new Database();
        string[] favoriteName = new string[6];
        int[] idFavorite = new int[6];
        int[] priority = new int[6];
        Bitmap ImageProfil;
        NotifyIcon trayIcon;
        public DetailProfilView(string _idUser,Bitmap imgProfil,NotifyIcon notification)
        {
            InitializeComponent();
            IdUser = _idUser;
            this.ImageProfil = imgProfil;
            ProfilPicture.Image = ImageProfil;
            Email.Text = IdUser;
            trayIcon = notification;
        }
        public DetailProfilView(string _idUser) {
            InitializeComponent();
            IdUser = _idUser;
            ProfilPicture.Image = ImageProfil;
            Email.Text = IdUser;
        }
        private void getFullName()
        {
            FullName.Text = (db.getUser(IdUser).Length <= 8) ? db.getUser(IdUser).ToUpper() : db.getUser(IdUser).Substring(0,11).ToUpper();
            //FullName.Text = db.getUser(IdUser);
        }
        private void getFavorite()
        {
            try
            {
                db.getFavorite(IdUser, out favoriteName, out priority, out idFavorite);
                txtMusic.Text = favoriteName[0];
                txtFilm.Text = favoriteName[1];
                txtVideo.Text = favoriteName[2];
                txtImage.Text = favoriteName[3];
                txtBook.Text = favoriteName[4];
                txtColor.Text = favoriteName[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DetailProfilView_Load(object sender, EventArgs e)
        {
            getFullName();
            getFavorite();
        }

        private void CheckConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckConfirm.Checked)
            {
                btnSaveData.Enabled = true;
            }else
            {
                btnSaveData.Enabled = false;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            favoriteName[0] = txtMusic.Text;
            favoriteName[1] = txtFilm.Text;
            favoriteName[2] = txtVideo.Text;
            favoriteName[3] = txtImage.Text;
            favoriteName[4] = txtBook.Text;
            favoriteName[5] = txtColor.Text;
            for (int i = 0; i < 6; i++)
            {
                db.updateFavoriteAll(favoriteName[i], IdUser, i);
            }

            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.BalloonTipTitle = "Informasi";
            trayIcon.BalloonTipText = "Data telah diperbaharui.";
            trayIcon.ShowBalloonTip(700);
            CheckConfirm.Checked = false;
            btnSaveData.Enabled = false;
        }
    }
}

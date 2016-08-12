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
    public partial class LoginView : MetroForm
    {
        Database db = new Database();
        private string idUser = null;
        NewUserView fView = null;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.loginCheck(txtUser.Text, txtPassword.Text, ref idUser) == true)
            {
                var writer = new System.IO.StreamWriter("session.ind");
                writer.WriteLine(idUser);
                writer.WriteLine(txtPassword.Text);
                writer.Close();
                txtPassword.Clear();
                txtUser.Clear();
                txtUser.Focus();
                this.Hide();
            }
            else
            {
                txtPassword.Clear();
                txtUser.Clear();
                txtUser.Focus();
                notif.Text = "Password/User Id tidak ditemukan !";
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            fView = new NewUserView();
            fView.FormClosed += new FormClosedEventHandler(formulirFormClosed);
            fView.ShowDialog();
        }
        delegate void loginUnloaded(object sender, FormClosedEventArgs e);
        private void formulirFormClosed(object sender, FormClosedEventArgs e)
        {
            if (RegisterLabel.InvokeRequired)
            {
                loginUnloaded f = new loginUnloaded(formulirFormClosed);
                this.Invoke(f, new object[] { sender, e });
            }
            else
            {
                fView = null;
            }
        }
    }
}

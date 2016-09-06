using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Expression.App
{
    public partial class MainView : MetroForm
    {
        InputDataUser inputData = null;
        public MainView()
        {
            InitializeComponent();
        }

        #region Event
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region Event New User
        private void newUserTool_Click(object sender, EventArgs e)
        {
            inputData = new InputDataUser();
            newUserTool.Enabled = false;
            inputData.MdiParent = this;
            inputData.FormClosed += new FormClosedEventHandler(inputData_Closed);
            inputData.Show();
            MainStatus.Text = "Input Data...(berjalan)";
        }

        delegate void inputData_Loaded(object sender, FormClosedEventArgs e);
         void inputData_Closed(object sender, FormClosedEventArgs e)
        {
            newUserTool.Enabled = true;
            MainStatus.Text = "Input Data...(selesai)";
        }

        #endregion

        private void trainingTool_Click(object sender, EventArgs e)
        {
            TrainingView trainingView = new TrainingView();
            trainingTool.Enabled = false;
            trainingView.MdiParent = this;
            trainingView.FormClosed += new FormClosedEventHandler(trainingViewClosed);
            trainingView.Show();
            MainStatus.Text = "Pelatihan Data...(berjalan)";
        }

        private void trainingViewClosed(object sender, FormClosedEventArgs e)
        {
            trainingTool.Enabled = true;
            MainStatus.Text = "Pelatihan Data...(selesai)";
        }

        private void testingTool_Click(object sender, EventArgs e)
        {
            TestingView testingView = new TestingView();
            testingTool.Enabled = false;
            testingView.MdiParent = this;
            testingView.FormClosed += new FormClosedEventHandler(testingViewClosed);
            testingView.Show();
            MainStatus.Text = "Pengujian Data...(berjalan)";
        }

        private void testingViewClosed(object sender, FormClosedEventArgs e)
        {
            testingTool.Enabled = true;
            MainStatus.Text = "Pengujian Data...(selesai)";
        }

        private void toolJST_Click(object sender, EventArgs e)
        {
            var settingJST = new NeSettingView();
            settingJST.FormClosed += new FormClosedEventHandler(settingJSTClosed);
            settingJST.MdiParent = this;
            settingJST.Show();
            toolJST.Enabled = false;
        }

        private void settingJSTClosed(object sender, FormClosedEventArgs e)
        {
            toolJST.Enabled = true;
        }

        private void toolTraining_Click(object sender, EventArgs e)
        {
            var trainView = new TrainingView();
            trainView.FormClosed += new FormClosedEventHandler(trainViewClosed);
            trainView.MdiParent = this;
            trainView.Show();
            toolTraining.Enabled = false;
        }

        private void trainViewClosed(object sender, FormClosedEventArgs e)
        {
            toolTraining.Enabled = true;
        }

        private void toolTesting_Click(object sender, EventArgs e)
        {
            var testView = new TestingView();
            testView.FormClosed += new FormClosedEventHandler(testViewClosed);
            testView.MdiParent = this;
            testView.Show();
            toolTesting.Enabled = false;
        }

        private void testViewClosed(object sender, FormClosedEventArgs e)
        {
            toolTesting.Enabled = true;
        }

        private void toolCamera_Click(object sender, EventArgs e)
        {
            var camSett = new CamSettingView();
            camSett.FormClosed += new FormClosedEventHandler(camSettClosed);
            camSett.MdiParent = this;
            toolCamera.Enabled = false;
            camSett.Show();
        }

        private void camSettClosed(object sender, FormClosedEventArgs e)
        {
            toolCamera.Enabled = true;
        }

        private void toolUserData_Click(object sender, EventArgs e)
        {
            var FUserData = new UserDataView();
            FUserData.FormClosed += new FormClosedEventHandler(FUserDataClosed);
            FUserData.MdiParent = this;
            toolUserData.Enabled = false;
            FUserData.Show();
        }

        private void FUserDataClosed(object sender, FormClosedEventArgs e)
        {
            toolUserData.Enabled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutView = new AboutView();
            aboutView.FormClosed += new FormClosedEventHandler(aboutViewClosed);
            aboutView.MdiParent = this;
            aboutToolStripMenuItem.Enabled = false;
            aboutView.Show();
        }

        private void aboutViewClosed(object sender, FormClosedEventArgs e)
        {
            aboutToolStripMenuItem.Enabled = true;
        }

        private void toolIdentification_Click(object sender, EventArgs e)
        {
            var idenView = new IdentifikasiView();
            idenView.FormClosed += new FormClosedEventHandler(idenViewClode);
            idenView.MdiParent = this;
            toolIdentification.Enabled = false;
            idenView.Show();
        }

        private void idenViewClode(object sender, FormClosedEventArgs e)
        {
            toolIdentification.Enabled = true;
        }
    }
}

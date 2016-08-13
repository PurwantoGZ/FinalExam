using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Expression.App
{
    public partial class SplashScreenView :Form
    {
        public SplashScreenView()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}

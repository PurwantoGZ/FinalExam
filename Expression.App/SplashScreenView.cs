using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Expression.App
{
    public partial class SplashScreenView :Form
    {
        Helper help = new Helper();
        BackgroundWorker worker;
        public SplashScreenView()
        {
            InitializeComponent();
            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            worker.WorkerReportsProgress = true;
            worker.DoWork += _doWork;
            worker.ProgressChanged += _ProgressChanged;
            worker.RunWorkerCompleted += _RunWorkerCompleted;
            runWorker();
        }

        private void _RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.Value = 100;
            Status.Text = "Selesai";
        }

        private void _ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            Status.Text = e.UserState.ToString();
        }

        private void _doWork(object sender, DoWorkEventArgs e)
        {
            worker.ReportProgress(0, "working...");
            Thread.Sleep(1000);
            for (int i = 0; i < 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    string stats = null;
                    worker.ReportProgress(i,"...");
                    if (i==10)
                    {stats= (help.isCheckFile(@"setting.jst")) ? "Checking...setting-true" : "Checking...setting-false";
                        worker.ReportProgress(i, stats);
                        Thread.Sleep(100);
                    }
                    if (i==20)
                    {stats= (help.isCheckFile(@"session.ind")) ? "Checking...sessio-true" : "Checking...session-false";
                        worker.ReportProgress(i, stats);
                        Thread.Sleep(100);
                    }
                    if (i==30)
                    {stats = (help.isCheckFile(@"weight.ghz")) ? "Checking...weight-true" : "Checking...weight-false";
                        worker.ReportProgress(i, stats);
                        Thread.Sleep(100);
                    }
                    //if (i==40)
                    //{stats = (help.isConnected()) ? "Checking...server-true" : "Checking...server-false";
                    //    if (help.isConnected()==false)
                    //    {
                    //        MessageBox.Show("Koneksi Gagal!\n Silahkan hubungi administartor purwanto@outlook.com", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        Application.Exit();
                    //        break;
                    //    }
                    //    worker.ReportProgress(i, stats);
                    //    Thread.Sleep(100);
                    //}

                }
                Thread.Sleep(70);
            }
        }

        private void runWorker()
        {
            worker.RunWorkerAsync();
            progressBar2.Maximum = 100;
        }  
    }
}

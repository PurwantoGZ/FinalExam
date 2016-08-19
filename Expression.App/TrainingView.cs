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
using System.Diagnostics;
using System.Threading;
using ZedGraph;
namespace Expression.App
{
    public partial class TrainingView : MetroForm
    {

        #region Properties
        Database db = new Database();
        Helper help = new Helper();
        Dictionary<int, double> mse = new Dictionary<int, double>();
        GraphPane myPane;
        PointPairList list = new PointPairList();
        int numDataTraining = 0;
        int[] keys;
        double[][] trainData;
        double[][] testData;
        double[] setting = new double[4];
        int numInput;
        int numHidden;
        int numOutput;
        double momentum;
        int numWeight1,numWeight2;
        Fann nn;
        private BackgroundWorker worker;
        public Stopwatch stopWatch;
        #endregion

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _sortData = new SortDataView(cbUser.Text);
            _sortData.FormClosed += new FormClosedEventHandler(_sortDataClosed);
            _sortData.ShowDialog();

            numDataTraining = help.TotalLines(@"terlatih.ghz");
            keys = new int[numDataTraining];
            keys = help.GetKeyData("terlatih");
            btnStartTraining.Text = (numDataTraining > 1) ? "Proses " + numDataTraining.ToString() + " Data" : "Proses";
            btnStartTraining.Enabled = (numDataTraining > 1) ? true : false;
            btnViewData.Enabled = true;
            cbGalat.Enabled = (numDataTraining > 1) ? true : false;
            cbLearnRate.Enabled = (numDataTraining > 1) ? true : false;
            txtMaxEpoch.Enabled = (numDataTraining > 1) ? true : false;
        }

        private void _sortDataClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            initiliazedJst();
            string message = "Latih Data dengan momentum:"+momentum+"\n"+"Hidden Layer:"+numHidden;
            DialogResult dlgConfirm = MessageBox.Show(message, "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlgConfirm==DialogResult.OK)
            {
                #region YES
                
                worker.RunWorkerAsync();
                list.Clear();
                Grafik.GraphPane.CurveList.Clear();
                Grafik.GraphPane.GraphObjList.Clear();
                Grafik.Invalidate();
                Grafik.Refresh();
                Terminal.Items.Clear();
                TestingResult.Items.Clear();
                TrueValue.Text = "Ketepatan";
                FalseValue.Text = "Kesalahan";
                _training();
                ProgressInfo.Maximum = mse.Count;
                TestingResult.Visible = false;
                btnStartTraining.Enabled = false;

                DialogResult dlgResult = MessageBox.Show("Batalkan Proses Pelaihan Data ?", "Konfirmasi", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (dlgResult == DialogResult.OK)
                {
                    if (worker.IsBusy) worker.CancelAsync();
                }
                else
                {

                    if (worker.IsBusy)
                    {
                        btnStartTraining.Enabled = false;
                        TestingResult.Visible = false;
                    }
                    else
                    {
                        btnStartTraining.Enabled = true;
                    }
                }
                #endregion
            }
            else
            {
                btnStartTraining.Enabled = false;
                cbUser.Focus();
                cbGalat.Enabled = false;
                cbLearnRate.Enabled = false;
                txtMaxEpoch.Enabled = false;
            }
        }

        private void TrainingView_Load(object sender, EventArgs e)
        {
            db.getUserID(ref cbUser);
            initializedGrafik();
        }

        public TrainingView()
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
            TestingResult.Visible = false;
        }

        private void _RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled==true)
            {
                Terminal.Items.Add("Dibatalkan");
            }
            else if (!(e.Error==null))
            {
                Terminal.Items.Add("Error : " + e.Error.Message);
            }else
            {
                TestingResult.Visible = true;
                btnStartTraining.Enabled = true;
                LineItem curva = myPane.AddCurve("MSE", list, Color.Teal, SymbolType.None);
                myPane.AxisChange();
                Grafik.Refresh();
                _testing();
            }
        }

        private void _ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressInfo.Value = e.ProgressPercentage;
            if (Terminal.Items.Count==10)
            {
                Terminal.Items.Clear();
            }
            Terminal.Items.Add("Epoch-" + e.ProgressPercentage + " :" + e.UserState.ToString());       
        }

        private void _doWork(object sender, DoWorkEventArgs e)
        {
            worker.ReportProgress(0, "working...");
            Thread.Sleep(1000);

            foreach (var item in mse)
            {
                if (worker.CancellationPending==true)
                {
                    e.Cancel = true;
                    break;
                }else
                {
                    worker.ReportProgress(item.Key, item.Value);
                    list.Add(item.Key, item.Value);
                    Thread.Sleep(50);
                }
            }
            worker.ReportProgress(mse.Count, "Done");
        }

        private void _training()
        {
            trainData = new double[numDataTraining][];
            testData = new double[numDataTraining][];
            double f1 = 0;
            double f2 = 0;
            double f3 = 0;
            double f4 = 0;
            double f5 = 0;
            double f6 = 0;
            double target = 0;
            for (int i = 0; i < numDataTraining; i++)
            {
                Console.WriteLine(keys[i].ToString());
                db.populateDataChoosed(ref f1, ref f2, ref f3, ref f4, ref f5, ref f6, ref target, keys[i].ToString());
                trainData[i] = new double[] {f1,f2,f3,f4,f5,f6,target };
                testData[i] = new double[] { f1,f2,f3,f4,f5,f6,target };
            }
            #region Create NeuronNetwork
            nn = new Fann(numInput, numHidden, numOutput);
            if ((help.isFileFound("weight"))&&(numWeight1==numWeight2))
            {
                nn.InitializedWeightsDB(help._oldweight("weight"));
            }
            else
            {
                nn.InitializedWeights();
            }
            #endregion
            nn.ShowVector(nn.Getweights(), 10, 8, true);
            //nn.ShowMatrix(trainData, numDataTraining, 2, true);
            string hasilBP = null;
            mse = nn.TrainBP(trainData, double.Parse(cbGalat.Text), int.Parse(txtMaxEpoch.Text), double.Parse(cbLearnRate.Text), 0.5,ref hasilBP);
            help.saveWeightNote(nn.Getweights(), "weight");
            nn.ShowVector(nn.Getweights(), 10, 8, true);
        }

        private void _testing()
        {
            TestingResult.Items.Clear();
            TrueValue.Text = "Ketepatan";
            FalseValue.Text = "Kesalahan";
            double _accuracy = 0;
            nn = new Fann(numInput, numHidden, numOutput);
            nn.InitializedWeightsDB(help._oldweight("weight"));
            nn.TestBP(testData, ref TestingResult,ref _accuracy);
            TrueValue.Text ="Ketepatan = "+ (_accuracy*100).ToString()+"%";
            FalseValue.Text = "Kesalahan = " + (100 - (_accuracy * 100)).ToString() + "%";
        }

        private void initializedGrafik()
        {
            myPane = Grafik.GraphPane;
            myPane.Title.Text = "Grafik Mean Square Error (MSE)";
            myPane.YAxis.Title.Text = "MSE";
            myPane.XAxis.Title.Text = "Epoch";
            
        }

        private void initiliazedJst()
        {
            setting = help.GetSetJST("setting");
            numInput = Convert.ToInt32(setting[0]);
            numHidden = Convert.ToInt32(setting[1]);
            numOutput = Convert.ToInt32(setting[2]);
            momentum = setting[3];
            numWeight1 = help.TotalLines(@"weight.ghz");
            numWeight2 = (numInput * numHidden) + numHidden + (numHidden * numOutput) + numOutput;
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            //var profilUser = new DetailProfilView(cbUser.Text);
            //profilUser.FormClosed += new FormClosedEventHandler(profilUserClosed);
            //profilUser.ShowDialog();
        }

        private void profilUserClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}

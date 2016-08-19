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
    public partial class TestingView : MetroForm
    {
        #region Properties
        Database db = new Database();
        Helper help = new Helper();
        Fann nn;
        int numInput;
        int numHidden;
        int numOutput;
        double[] setting = new double[4];
        double[][] DataTerlatih;
        double[][] DataTakTerlatih;
        int numTerlatih = 0;
        int numTakTerlatih = 0;
        int[] keyTerlatih, keyTakTerlatih;
        #endregion

        public TestingView()
        {
            InitializeComponent();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            numTerlatih = help.TotalLines(@"terlatih.ghz");
            
            numTakTerlatih = help.TotalLines(@"takTerlatih.ghz");
            LblTerlatih.Text =numTerlatih.ToString() +" Data Telatih";
            LblTakTerlatih.Text =numTakTerlatih.ToString() + " Data Tidak Telatih";
            keyTerlatih = new int[numTerlatih];
            keyTerlatih = help.GetKeyData("terlatih");

            keyTakTerlatih = new int[numTakTerlatih];
            keyTakTerlatih = help.GetKeyData("takTerlatih");

            DataTerlatih = new double[numTerlatih][];
            DataTakTerlatih = new double[numTakTerlatih][];
            double f1 = 0;
            double f2 = 0;
            double f3 = 0;
            double f4 = 0;
            double f5 = 0;
            double f6 = 0;
            double target = 0;
            for (int i = 0; i < numTerlatih; i++)
            {
                Console.WriteLine(keyTerlatih[i].ToString());
                db.populateDataChoosed(ref f1, ref f2, ref f3, ref f4, ref f5, ref f6, ref target, keyTerlatih[i].ToString());
                DataTerlatih[i] = new double[] { f1, f2, f3, f4, f5, f6, target };
            }
            for (int i = 0; i < numTakTerlatih; i++)
            {
                Console.WriteLine(keyTakTerlatih[i].ToString());
                db.populateDataChoosed(ref f1, ref f2, ref f3, ref f4, ref f5, ref f6, ref target, keyTakTerlatih[i].ToString());
                DataTakTerlatih[i] = new double[] { f1, f2, f3, f4, f5, f6, target };
            }
            double accuracyY = 0;
            double accuracyX = 0;
            nn = new Fann(numInput, numHidden, numOutput);
            nn.InitializedWeightsDB(help._oldweight("weight"));
            nn.ShowMatrix(DataTerlatih, numTerlatih, 2, true);
            nn.ShowMatrix(DataTakTerlatih, numTakTerlatih, 2, true);
            nn.TestBP(DataTerlatih, ref listBox1, ref accuracyX);
            nn.TestBP(DataTakTerlatih, ref listBox2, ref accuracyY);
            ResultTerlatih.Text = "Ketepatan : " + (accuracyX * 100).ToString() + " %, Kesalahan : " + (100 - (accuracyX * 100)).ToString() + "%";
            ResultTakTerlatih.Text = "Ketepatan : " + (accuracyY * 100).ToString() + " %, Kesalahan : " + (100 - (accuracyY * 100)).ToString() + "%";
        }

        private void TestingView_Load(object sender, EventArgs e)
        {
            initiliazedJst();
        }

        private void initiliazedJst()
        {
            setting = help.GetSetJST("setting");
            numInput = Convert.ToInt32(setting[0]);
            numHidden = Convert.ToInt32(setting[1]);
            numOutput = Convert.ToInt32(setting[2]);
        }
    }
}

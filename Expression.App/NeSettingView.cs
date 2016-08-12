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
    public partial class NeSettingView : MetroForm
    {
        Helper help = new Helper();
        double[] data;
        private int numData;
        public NeSettingView()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            data[0] =double.Parse( InputLayer.Value.ToString());
            data[1] =double.Parse( HiddenLayer.Value.ToString());
            data[2] =double.Parse( OutputLayer.Value.ToString());
            data[3] =double.Parse( Momentum.Value.ToString());
            help.saveSettingJst(data, "setting");
            MessageBox.Show("Pengaturan Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void readSetting()
        {
            data = help.GetSetJST("setting");
            InputLayer.Value = Convert.ToDecimal(data[0]);
            HiddenLayer.Value = Convert.ToDecimal(data[1]);
            OutputLayer.Value = Convert.ToDecimal(data[2]);
            Momentum.Value = Convert.ToDecimal(data[3]);
        }

        private void NeSettingView_Load(object sender, EventArgs e)
        {
            numData = help.TotalLines(@"setting.jst");
            data = new double[numData];
            readSetting();
        }
    }
}

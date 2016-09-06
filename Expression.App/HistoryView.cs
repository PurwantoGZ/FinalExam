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
using System.Windows.Forms.DataVisualization.Charting;
namespace Expression.App
{
    public partial class HistoryView : MetroForm
    {
        Dictionary<string, int> JumSedih = new Dictionary<string, int>();
        Dictionary<string, int> JumSenang = new Dictionary<string, int>();

        Database db = new Database();
        string UserId;

        public HistoryView()
        {
            InitializeComponent();
        }
        // Overriding Constructor
        public HistoryView(string _userId)
        {
            InitializeComponent();
            this.UserId = _userId;
        }

        private void HistoryView_Load(object sender, EventArgs e)
        {
            //1. Tampil Data dalam Table History
            db.PopulateDataEkspresiLog(ref TableHistory, UserId);

            //2. Ambil Data History Untuk Grafik
            db.getCountExpresiLogUser(ref JumSedih, ref JumSenang, UserId,"");

            //3. Inisialisasi Grafik
            
            GrafikHistory.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            GrafikHistory.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            GrafikHistory.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            //GrafikHistory.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            GrafikHistory.ChartAreas[0].AxisX2.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            //GrafikHistory.ChartAreas[0].AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            foreach (var item in JumSedih)
            {
                GrafikHistory.Series[0].Points.AddXY( item.Key, item.Value);
            }
            foreach (var item in JumSenang)
            {
                GrafikHistory.Series[1].Points.AddXY(item.Key, item.Value);
            }
            GrafikHistory.Invalidate();
        }
    }
}

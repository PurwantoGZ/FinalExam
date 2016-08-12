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
    public partial class SortDataView : MetroForm
    {
        public string _userId;
        Database db = new Database();
        CheckBox checkboxHeader = new CheckBox();
        bool isChecked = false;
        Helper help = new Helper();
        int i = 0;
        public SortDataView(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        #region Event Handle
        private void populateData()
        {
            db.viewDataTable(ref trainingData, _userId);
        }
        #endregion

        private void btnFinishData_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            
            #region Count Checked
            foreach (DataGridViewRow row in trainingData.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);
                if (isSelected)
                {
                    i++;
                }
            }
            #endregion

            #region save Key
            int[] saveK = new int[i];
            int j = 0;
            foreach (DataGridViewRow row in trainingData.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[0].Value);
                if (isSelected)
                {
                    saveK[j] = int.Parse(row.Cells[1].Value.ToString());
                    j++;
                }
            }
            help.saveKeyNote(saveK, "key");
            #endregion

            this.Close();
        }

        private void SortDataView_Load(object sender, EventArgs e)
        {
            populateData();
            //show_chkBox();
        }

        private void trainingData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isChecked = true;
            btnFinishData.Enabled = isChecked;
            
        }
    }
}

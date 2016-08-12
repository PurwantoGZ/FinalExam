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
    public partial class UserDataView : MetroForm
    {
        Database db = new Database();
        public UserDataView()
        {
            InitializeComponent();
        }

        private void UserDataView_Load(object sender, EventArgs e)
        {
            db.ViewDataAll(ref dataGridUser);
        }

        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex < 0)
            //{
            //    return;
            //}

            //if (dataGridUser.Columns[e.ColumnIndex].Name == "btnDetail")
            //{

            //}
            //else if (dataGridUser.Columns[e.ColumnIndex].Name == "btnDel")
            //{
            //    MessageBox.Show("Delete");
            //}
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dataGridUser.Columns[e.ColumnIndex].Name == "btnDetail")
            {

            }
            else if (dataGridUser.Columns[e.ColumnIndex].Name == "btnDel")
            {
                MessageBox.Show("Delete");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expression;
namespace PreviewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Database db = new Database();
        private void button1_Click(object sender, EventArgs e)
        {
            //Dictionary<string, int> countSad = new Dictionary<string, int>();
            //Dictionary<string, int> countHappy = new Dictionary<string, int>();
            //db.getCountExpresiLogUser(ref countSad, ref countHappy, "purwanto@outlook.com");

            //Console.WriteLine(" Jumlah Sedih");
            //int i = 1;
            //foreach (var item in countSad)
            //{
            //    Console.WriteLine("{0}: {1}->{2}",i,item.Key,item.Value);
            //    i++;
            //}
            //Console.WriteLine("Jumlah Senang");
            //int j = 1;
            //foreach (var item in countHappy)
            //{
            //    Console.WriteLine("{0}: {1}->{2}", j, item.Key, item.Value);
            //    j++;
            //}
        }
    }
}

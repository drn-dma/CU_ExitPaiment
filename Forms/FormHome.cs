using CU_ExitPaiment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace CU_ExitPaiment.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = datePicker.Value.ToShortDateString().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Dictionary<string, object>> sqlResult = SQLConnect.readDataFromSQL("SELECT * FROM Clients");




            TextBox tb1 = new TextBox();
            tb1.Text = "Cell 1";
            TextBox tb2 = new TextBox();
            tb2.Text = "Cell 2";
            TextBox tb3 = new TextBox();
            tb3.Text = "Cell 3";
            TextBox tb4 = new TextBox();
            tb4.Text = "Cell 4";
                
            TextBox tb5 = new TextBox();
            tb5.Text = "Cell 5";
            TextBox tb6 = new TextBox();
            tb6.Text = "Cell 6";
            TextBox tb7 = new TextBox();
            tb7.Text = "Cell 7";
            TextBox tb8 = new TextBox();
            tb8.Text = "Cell 8";


            tablePnl.Controls.Add(tb1,0,0);
            tablePnl.Controls.Add(tb2, 1, 0);
            tablePnl.Controls.Add(tb3, 2, 0);
            tablePnl.Controls.Add(tb4, 0, 1);
            tablePnl.Controls.Add(tb5, 1, 1);
            tablePnl.Controls.Add(tb6, 2, 1);
            tablePnl.Controls.Add(tb7, 0, 2);
            tablePnl.Controls.Add(tb8, 1, 2);

        }
    }
}

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

namespace CU_ExitPaiment.Forms
{
    public partial class FormAllConso : Form
    {
        private List<Dictionary<string, object>> sqlConso;
        private Dictionary<string, object> sqlSoft;
        private Dictionary<string, object> sqlAlcool;
        private Dictionary<string, object> sqlResto;
        private Dictionary<string, object> sqlDessert;

        public FormAllConso()
        {
            InitializeComponent();
        }

        private void FormAllConso_Load(object sender, EventArgs e)
        {
            this.sqlConso = SQLConnect.getAllConsos();

            this.sqlSoft = new Dictionary<string, object> { };
            this.sqlAlcool = new Dictionary<string, object> { };
            this.sqlResto = new Dictionary<string, object> { };
            this.sqlDessert = new Dictionary<string, object> { };

            foreach (var row in sqlConso)
            {
                switch (row["Id_TypeConso"])
                {
                    case 1:
                        this.sqlSoft.Add(row["Id_Consommation"].ToString(), row["libelle"]);
                        break;
                    case 2:
                        this.sqlAlcool.Add(row["Id_Consommation"].ToString(), row["libelle"]);
                        break;
                    case 3:
                        this.sqlResto.Add(row["Id_Consommation"].ToString(), row["libelle"]);
                        break;
                    case 4:
                        this.sqlDessert.Add(row["Id_Consommation"].ToString(), row["libelle"]);
                        break;

                }
            }

            this.btn_Soft.Select();
        }

        private void btn_Soft_Click(object sender, EventArgs e)
        {
            this.lstView_Consos.Items.Clear();
            foreach (var row in this.sqlSoft)
            {
                this.lstView_Consos.Items.Add(row.Value.ToString());
            }
        }
    }
}

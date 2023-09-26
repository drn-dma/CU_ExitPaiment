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
        private string idArdoise;

        public FormAllConso(string idArdoise)
        {
            InitializeComponent();
            this.idArdoise = idArdoise;
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

            btn_Soft_Click(sender, e);
        }

        private void btn_Soft_Click(object sender, EventArgs e)
        {
            this.lstView_Consos.Items.Clear();
            foreach (var row in this.sqlSoft)
            {
                var item = this.lstView_Consos.Items.Add(row.Value.ToString());
                item.Tag = row.Key;
            }
        }

        private void btn_Alcool_Click(object sender, EventArgs e)
        {
            this.lstView_Consos.Items.Clear();
            foreach (var row in this.sqlAlcool)
            {
                var item = this.lstView_Consos.Items.Add(row.Value.ToString());
                item.Tag = row.Key;
            }
        }

        private void btn_Resto_Click(object sender, EventArgs e)
        {
            this.lstView_Consos.Items.Clear();
            foreach (var row in this.sqlResto)
            {
                var item = this.lstView_Consos.Items.Add(row.Value.ToString());
                item.Tag = row.Key;
            }
        }

        private void btn_Dessert_Click(object sender, EventArgs e)
        {
            this.lstView_Consos.Items.Clear();
            foreach (var row in this.sqlDessert)
            {
                var item = this.lstView_Consos.Items.Add(row.Value.ToString());
                item.Tag = row.Key;
            }
        }

        private void lstView_Consos_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstView_Consos.SelectedItems.Count > 0)
            {
                string selectedLibelle = this.lstView_Consos.SelectedItems[0].Text;

                // Recherche si le libellé existe déjà dans la deuxième ListView
                bool found = false;
                foreach (ListViewItem item in this.lstView_Basket.Items)
                {
                    if (item.SubItems[0].Text == selectedLibelle)
                    {
                        // Incrémentation de la quantité
                        int quantite = int.Parse(item.SubItems[1].Text);
                        quantite++;
                        item.SubItems[1].Text = quantite.ToString();
                        found = true;
                        break;
                    }
                }

                // Si le libellé n'a pas été trouvé, l'ajouter avec une quantité de 1
                if (!found)
                {
                    ListViewItem newItem = new ListViewItem(selectedLibelle);
                    newItem.SubItems.Add("1");
                    newItem.Tag = this.lstView_Consos.SelectedItems[0].Tag;
                    this.lstView_Basket.Items.Add(newItem);
                }
            }
        }

        private void lstView_Basket_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstView_Basket.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = this.lstView_Basket.SelectedItems[0];
                string selectedLibelle = selectedItem.SubItems[0].Text;
                int quantite = int.Parse(selectedItem.SubItems[1].Text);

                // Réduire la quantité de 1
                quantite--;

                if (quantite <= 0)
                {
                    // Si la quantité est <= 0, supprimer l'élément
                    this.lstView_Basket.Items.Remove(selectedItem);
                }
                else
                {
                    // Sinon, mettre à jour la quantité
                    selectedItem.SubItems[1].Text = quantite.ToString();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Voulez-vous vraiment supprimer toutes les consommations ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.lstView_Basket.Items.Clear();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> itemQuantity = new Dictionary<string, int> { };

            foreach (ListViewItem item in this.lstView_Basket.Items)
            {
                int quantity = int.Parse(item.SubItems[1].Text);

                itemQuantity.Add(item.Tag.ToString(), quantity);
            }

            SQLConnect.addConsoToArdoise(this.idArdoise, itemQuantity);

        }

        private void viewTag_DEBUGONLY(object sender, EventArgs e)
        {
            MessageBox.Show(this.lstView_Consos.SelectedItems[0].Tag.ToString());
        }
    }
}

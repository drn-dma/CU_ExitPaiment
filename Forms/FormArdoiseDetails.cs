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
    public partial class FormArdoiseDetails : Form
    {
        private string idArdoise;
        private DateTime date;
        List<Dictionary<string, object>> sqlArdoise;
        List<Dictionary<string, object>> sqlMatos;
        List<Dictionary<string, object>> sqlConso;

        public FormArdoiseDetails(string idArdoise, DateTime date)
        {
            InitializeComponent();
            this.idArdoise = idArdoise;
            this.date = date;

            for (int i = 0; i < 10; i++)
            {
                this.cBox_Adulte.Items.Add(i);
                this.cBox_Enfant.Items.Add(i);
                this.cBox_Reduit.Items.Add(i);
            }


            this.cBox_Adulte.SelectedIndex = 0;
            this.cBox_Enfant.SelectedIndex = 0;
            this.cBox_Reduit.SelectedIndex = 0;

        }

        private void FormArdoiseDetails_Load(object sender, EventArgs e)
        {
            this.sqlArdoise = SQLConnect.readDataFromSQL($"SELECT a.Id_Ardoise, CONCAT(c.nom, ' ', c.prenom) as nomPrenom ,a.dateArdoise ,a.isPaid ,a.aRegler ,a.isLoyal FROM Ardoise a JOIN Clients c on c.Id_Clients = a.Id_Clients where a.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{this.date.ToShortDateString()}'");
            this.sqlMatos = SQLConnect.readDataFromSQL($"Select r.Id_EntreeMatos,r.quantite FROM regler r JOIN Ardoise a on a.Id_Ardoise = r.Id_Ardoise where r.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{date.ToShortDateString()}'");
            this.sqlConso = SQLConnect.readDataFromSQL($"SELECT c.Id_Consommation, c.quantite FROM consommer c JOIN Ardoise a on a.Id_Ardoise = c.Id_Ardoise where c.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{date.ToShortDateString()}'");
            
            this.lbl_NomClient.Text = sqlArdoise[0]["nomPrenom"].ToString();


            if (this.sqlMatos != null)
            {
                foreach (Dictionary<string, object> row in sqlMatos)
                {
                    switch (row["Id_EntreeMatos"])
                    {
                        case 1:
                            this.cBox_Adulte.SelectedIndex = (int)row["quantite"];
                            break;
                        case 2:
                            this.cBox_Enfant.SelectedIndex = (int)row["quantite"];
                            break;
                        case 3:
                            this.cBox_Reduit.SelectedIndex = (int)row["quantite"];
                            break;
                    }
                }
            }
            else
            {
                this.cBox_Adulte.SelectedIndex = 0;
                this.cBox_Enfant.SelectedIndex = 0;
                this.cBox_Reduit.SelectedIndex = 0;
            }
            


        }

    }
}

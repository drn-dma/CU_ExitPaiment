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
    public partial class FormStats_Day_Month_Year : Form
    {

        public FormStats_Day_Month_Year()
        {
            InitializeComponent();
            pnl_Main.Visible = false;

            CBox cBoxDefault = new CBox("Tous les clients", "default");
            comboBox_Clients.Items.Add(cBoxDefault);

            foreach(var client in SQLConnect.getClientInfo())
            {
                CBox cBox = new CBox(client["nomPrenom"].ToString(), client["Id_Clients"].ToString());
                comboBox_Clients.AutoCompleteCustomSource.Add(client["nomPrenom"].ToString());
                comboBox_Clients.Items.Add(cBox);
            }

            comboBox_Clients.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CBox cBox = (comboBox_Clients.SelectedItem as CBox);
            var totalEntry = SQLConnect.getAllEntryByUsernameAndTwoDate(cBox.Value.ToString(), dateP_1.Value, dateP_2.Value);
            if (cBox.Text.Equals("default"))
            {
                lbl_AllUnitEntry.Text = totalEntry[0]["nbrEntree"].ToString();

                grpBox_DetailsClient.Visible = false;
            }
            else
            {
                lbl_AllUnitEntry.Text = totalEntry[0]["nbrEntree"].ToString();
                lbl_TotPaiementSortie.Text = SQLConnect.countClientVisit(int.Parse(cBox.Value.ToString())).ToString();
                var totPaye = SQLConnect.getAllDepenseForClient(cBox.Value.ToString(), dateP_1.Value, dateP_2.Value);
               
                if(totPaye.Equals("False"))
                {
                    lbl_TotDepense.Text = "0 €";
                }
                else
                {
                    lbl_TotDepense.Text = totPaye + " €";
                }

                var dateFidel = SQLConnect.getLoyalClient(cBox.Value.ToString())[0]["dateFidelisation"];
                if (dateFidel != null)
                {
                    lbl_FidelDate.Text = dateFidel.ToString();
                    lbl_TotEntryBefLoyal.Text = SQLConnect.getAllEntryBefLoyal(cBox.Value.ToString(), dateFidel.ToString())[0]["nbrEntree"].ToString();
                }
                grpBox_DetailsClient.Visible = true;
            }



            pnl_Main.Visible = true;
        }
    }
}

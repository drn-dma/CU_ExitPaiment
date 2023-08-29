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
            refreshCustomers(csDatePicker1.Value);
            calculLoyality(csDatePicker1.Value);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        #region Init Customers
        private void refreshCustomers()
        {
            
            List<Dictionary<string, object>> sqlGetArdoise = SQLConnect.readDataFromSQL($"SELECT isLoyal, isPaid, Id_Clients FROM Ardoise");
            int i = 0;

            foreach (Dictionary<string, object> row in sqlGetArdoise)
            {

                List<Dictionary<string, object>> sqlGetClient = SQLConnect.readDataFromSQL($"SELECT * FROM Clients where Id_Clients = {row["Id_Clients"]}");
                Button button = new Button();
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.Font = new Font("Arial", 12);
                button.FlatAppearance.BorderColor = Color.White;
                button.Anchor = AnchorStyles.None;
                button.Size = new Size(200, 50);
                button.Margin = new Padding(10, 10, 10, 10);
                button.Name = sqlGetClient[0]["Id_Clients"].ToString();
                button.Click += new EventHandler(clickOnClient);

                if ((bool)row["isLoyal"])
                {
                    button.BackColor = Color.FromArgb(50, 184, 177);
                }
                else if ((bool)row["isPaid"] && (!(bool)row["isLoyal"] || (bool)row["isLoyal"] == null))
                {
                    button.BackColor = Color.FromArgb(67, 163, 33);
                }
                else
                {
                    button.BackColor = Color.FromArgb(163, 26, 26);
                }



                button.Text = sqlGetClient[0]["nom"].ToString() + " " + sqlGetClient[0]["prenom"].ToString();
                tablePnl.Controls.Add(button);
                i++;
            }

            
        }

        private void refreshCustomers(DateTime date)
        {

            List<Dictionary<string, object>> sqlGetArdoise = SQLConnect.readDataFromSQL($"SELECT Id_Ardoise, isLoyal, isPaid, Id_Clients FROM Ardoise where dateArdoise = '{date.ToShortDateString()}'");
            int i = 0;

            foreach (Dictionary<string, object> row in sqlGetArdoise)
            {

                List<Dictionary<string, object>> sqlGetClient = SQLConnect.readDataFromSQL($"SELECT * FROM Clients where Id_Clients = {row["Id_Clients"]}");
                Button button = new Button();
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.Font = new Font("Arial", 12);
                button.FlatAppearance.BorderColor = Color.White;
                button.Anchor = AnchorStyles.None;
                button.Size = new Size(200, 50);
                button.Margin = new Padding(10, 10, 10, 10);
                button.Name = row["Id_Ardoise"].ToString();
                button.Click += new EventHandler(clickOnClient);


                if ((bool)row["isLoyal"])
                {
                    button.BackColor = Color.FromArgb(50, 184, 177);
                }
                else if ((bool)row["isPaid"] && (!(bool)row["isLoyal"] || (bool)row["isLoyal"] == null))
                {
                    button.BackColor = Color.FromArgb(67, 163, 33);
                }
                else
                {
                    button.BackColor = Color.FromArgb(163, 26, 26);
                }



                button.Text = sqlGetClient[0]["nom"].ToString() + " " + sqlGetClient[0]["prenom"].ToString() + " : " + row["Id_Ardoise"].ToString();
                tablePnl.Controls.Add(button);
                i++;
            }


        }

        #endregion 


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tablePnl.Controls.Clear();
            refreshCustomers(csDatePicker1.Value);   
            calculLoyality(csDatePicker1.Value);
        }

        private void btnBackToToday_Click(object sender, EventArgs e)
        {
            csDatePicker1.Value = DateTime.Now;
            tablePnl.Controls.Clear();
            refreshCustomers(csDatePicker1.Value);
            calculLoyality(csDatePicker1.Value);
        }


        private void calculLoyality(DateTime date)
        {
            List<Dictionary<string, object>> sqlGetArdoise = SQLConnect.readDataFromSQL($"SELECT isLoyal, isPaid, Id_Clients FROM Ardoise where dateArdoise = '{date.ToShortDateString()}'");
            decimal loyal = 0;
            decimal countArdoise = 0;

            foreach(Dictionary<string,object> ardoise in sqlGetArdoise)
            {
                countArdoise++;
                if ((bool)ardoise["isPaid"] && (bool)ardoise["isLoyal"])
                {
                    loyal++;
                }
            }

            if(countArdoise == 0)
            {
                lbl_TauxFidel.Text = "0 %";
                return;
            }
         

            lbl_TauxFidel.Text = Math.Floor((loyal / countArdoise) * 100) + " %";
        }

        private void csDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablePnl.Controls.Clear();
            refreshCustomers(csDatePicker1.Value);
            calculLoyality(csDatePicker1.Value);
        }

        private void clickOnClient(object sender, EventArgs e)
        {
            using(FormArdoiseDetails formArdoiseDetails = new FormArdoiseDetails(((Button)sender).Name, csDatePicker1.Value))
            {
                DialogResult dr = formArdoiseDetails.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    tablePnl.Controls.Clear();
                    refreshCustomers(csDatePicker1.Value);
                    calculLoyality(csDatePicker1.Value);
                }
            }
        }

        private void btn_NewCusto_Click(object sender, EventArgs e)
        {
            using(FormNewClient formNewCustomer = new FormNewClient())
            {
                DialogResult dr = formNewCustomer.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    
                    if(!SQLConnect.checkExistingClient(formNewCustomer._name, formNewCustomer._firstname, csDatePicker1.Value))
                    {
                        SQLConnect.addArdoise(formNewCustomer._name, formNewCustomer._firstname, formNewCustomer._newClient, formNewCustomer.entreMatos, csDatePicker1.Value);
                    }
                    else
                    {
                        MessageBox.Show("Ce client existe déjà pour cette date");
                    }
                    
                    
                    tablePnl.Controls.Clear();
                    refreshCustomers(csDatePicker1.Value);
                    calculLoyality(csDatePicker1.Value);
                }
            }
        }
    }
}

﻿using CU_ExitPaiment.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_ExitPaiment.Forms
{
    public partial class FormArdoiseDetails : Form
    {
        private string idArdoise;
        private DateTime date;
        private int nbVisite;
        List<Dictionary<string, object>> sqlArdoise;
        List<Dictionary<string, object>> sqlMatos;
        List<Dictionary<string, object>> sqlConso;
        List<Dictionary<string, object>> sqlClients;
        FormAllConso formConso;

        public FormArdoiseDetails(string idArdoise, DateTime date)
        {
            InitializeComponent();
            this.formConso = new FormAllConso();
            this.idArdoise = idArdoise;
            this.date = date;


            for (int i = 0; i < 10; i++)
            {   
                this.cBox_AdulteEntry__1.Items.Add(i);
                this.cBox_EnfantEntry__3.Items.Add(i);
                this.cBox_ReduitEntry__2.Items.Add(i);
                this.cBox_AdulteBaud__4.Items.Add(i);
                this.cBox_EnfantBaud__8.Items.Add(i);
                this.cBox_ReduitBaud__6.Items.Add(i);
                this.cBox_AdulteChauss__5.Items.Add(i);
                this.cBox_EnfantChauss__9.Items.Add(i);
                this.cBox_ReduitChauss__7.Items.Add(i);

            }


            this.cBox_AdulteEntry__1.SelectedIndex = 0;
            this.cBox_EnfantEntry__3.SelectedIndex = 0;
            this.cBox_ReduitEntry__2.SelectedIndex = 0;
            this.cBox_AdulteBaud__4.SelectedIndex = 0;
            this.cBox_EnfantBaud__8.SelectedIndex = 0;
            this.cBox_ReduitBaud__6.SelectedIndex = 0;
            this.cBox_AdulteChauss__5.SelectedIndex = 0;
            this.cBox_EnfantChauss__9.SelectedIndex = 0;
            this.cBox_ReduitChauss__7.SelectedIndex = 0;


            
        
        }

        private void FormArdoiseDetails_Load(object sender, EventArgs e)
        {
            this.sqlArdoise = SQLConnect.getArdoiseDetails(this.idArdoise, this.date);
            this.sqlMatos = SQLConnect.readDataFromSQL_NoParameters($"Select r.Id_EntreeMatos,r.quantite, e.prix FROM regler r JOIN Ardoise a on a.Id_Ardoise = r.Id_Ardoise JOIN EntreeMatos e ON e.Id_EntreeMatos = r.Id_EntreeMatos where r.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{date.ToShortDateString()}'");
            this.sqlConso = SQLConnect.readDataFromSQL_NoParameters($"SELECT c.Id_Consommation, c.quantite FROM consommer c JOIN Ardoise a on a.Id_Ardoise = c.Id_Ardoise where c.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{date.ToShortDateString()}'");
            this.sqlClients = SQLConnect.readDataFromSQL_NoParameters($"SELECT c.Id_Clients, CONCAT(c.nom, ' ', c.prenom) as nomPrenom, c.isNew FROM Clients c JOIN Ardoise a on a.Id_Clients = c.Id_Clients where a.Id_Ardoise = {this.idArdoise} and a.dateArdoise = '{date.ToShortDateString()}'");
            
            this.Text = $"Ardoise de {sqlClients[0]["nomPrenom"]} du {this.date.ToShortDateString()}";

            this.btn_NewClient.Text = sqlArdoise[0]["nomPrenom"].ToString();
            

            if ((bool)sqlArdoise[0]["isPaid"])
            {
                this.btn_Checkout.Visible = false;
                this.btn_CancelCheckout.Visible = true;
            }

            if (this.sqlMatos.Count > 0)
            {
                foreach (Dictionary<string, object> row in sqlMatos)
                {
                    switch (row["Id_EntreeMatos"])
                    {
                        case 1:
                            this.cBox_AdulteEntry__1.SelectedIndex = (int)row["quantite"];
                            this.cBox_AdulteEntry__1.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 2:
                            this.cBox_ReduitEntry__2.SelectedIndex = (int)row["quantite"];
                            this.cBox_ReduitEntry__2.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 3:
                            this.cBox_EnfantEntry__3.SelectedIndex = (int)row["quantite"];
                            this.cBox_EnfantEntry__3.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 4:
                            this.cBox_AdulteBaud__4.SelectedIndex = (int)row["quantite"];
                            this.cBox_AdulteBaud__4.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 5:
                            this.cBox_AdulteChauss__5.SelectedIndex = (int)row["quantite"];
                            this.cBox_AdulteChauss__5.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 6:
                            this.cBox_ReduitBaud__6.SelectedIndex = (int)row["quantite"];
                            this.cBox_ReduitBaud__6.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 7:
                            this.cBox_ReduitChauss__7.SelectedIndex = (int)row["quantite"];
                            this.cBox_ReduitChauss__7.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 8:
                            
                            this.cBox_EnfantBaud__8.SelectedIndex = (int)row["quantite"];
                            this.cBox_EnfantBaud__8.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                        case 9:
                            this.cBox_EnfantChauss__9.SelectedIndex = (int)row["quantite"];
                            this.cBox_EnfantChauss__9.SelectedValueChanged += new System.EventHandler(this.onQuantityChange);
                            break;
                    }
                }
            }

            var allCombo = grpBox_Entry.Controls.OfType<ComboBox>().ToList();
            allCombo.AddRange(grpBox_Matos.Controls.OfType<ComboBox>().ToList());

            foreach(ComboBox combo in allCombo)
            {
                
                if (combo.SelectedIndex != 0)
                { 
                    combo.Font = new Font(combo.Font, FontStyle.Bold);
                    
                }
                else
                {
                    combo.Font = new Font(combo.Font, FontStyle.Regular);
                }
                
            }

            if(this.sqlClients.Count > 0 && (bool)this.sqlClients[0]["isNew"])
            {
                this.btn_NewClient.IconChar = IconChar.Crown;
            }
            else
            {
                this.btn_NewClient.IconChar = IconChar.None;
            }

            

            this.nbVisite = SQLConnect.countClientVisit((int)sqlClients[0]["Id_Clients"]);
            this.lbl_nbVisite.Text = this.nbVisite.ToString();


            float coutTotalApprox = 0;

            foreach (Dictionary<string, object> row in sqlMatos)
            {
                coutTotalApprox += (int)row["prix"] * (int)row["quantite"];
            }   

            SQLConnect.setAReglerForArdoise(coutTotalApprox,this.idArdoise,this.date);

            this.lbl_PrixApprox.Text = coutTotalApprox.ToString() + " €";

            this.ActiveControl = null;








            if (!(bool)this.sqlArdoise[0]["isLoyal"])
            {
                this.grpBox_Comment.Visible = true;
                
                this.txtBox_Comment.Text = sqlArdoise[0]["commentLoyality"].ToString();
            }
            else
            {
                this.grpBox_Comment.Visible = false;
            }


        }


        private void onQuantityChange(object sender, EventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;
            int idItem = int.Parse(cBox.Name.Split(new string[] {"__"}, StringSplitOptions.None)[1]);
            SQLConnect.setMatosQuantityForArdoise(cBox.SelectedIndex, this.idArdoise, idItem);

        }


        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            string raison = "Ne veut pas";

            SQLConnect.setPaidForArdoise(this.idArdoise, this.date);
            DialogResult dg = MessageBox.Show("Le client a t-il été fidélisé ? (carte 10 / abo)", "Client Fidélisé ?", MessageBoxButtons.YesNo);

            if (dg == DialogResult.Yes)
            {

                SQLConnect.setIsNewFalseForClient((int)this.sqlClients[0]["Id_Clients"]);
                SQLConnect.setLoyalTrueForArdoise(this.idArdoise, this.date);
            }
            else
            {
                if(FunctionsLibs.InputBox("Pourquoi ?", "Raison de la non fidélisation :", ref raison) == DialogResult.OK)
                {
                    SQLConnect.setLoyalFalseAndCommentForArdoise(this.idArdoise, this.date, raison);
                }

                SQLConnect.setIsNewFalseForClient((int)this.sqlClients[0]["Id_Clients"]);
            }

            this.Close();
        }

        private void btn_CancelCheckout_Click(object sender, EventArgs e)
        {
            SQLConnect.cancelPaiement(this.idArdoise, this.date);
            DialogResult dg = MessageBox.Show("Le client est-il nouveau ?", "Client Nouveau ?", MessageBoxButtons.YesNo);
            
            if(dg == DialogResult.Yes)
            {
                SQLConnect.setIsNewTrueForClient((int)this.sqlClients[0]["Id_Clients"]);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult dg = this.formConso.ShowDialog();
            if(dg == DialogResult.Yes)
            {

            }
        }
    }
}

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
    public partial class FormNewClient : Form
    {
        public string _name;
        public string _firstname;
        public bool _newClient;
        public bool _existingClientToday;

        public Dictionary<int, int> entreMatos = new Dictionary<int, int> { };

        public FormNewClient()
        {
            InitializeComponent();
        }
        private void FormNewClient_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.cBox_AdulteEntry.Items.Add(i);
                this.cBox_EnfantEntry.Items.Add(i);
                this.cBox_ReduitEntry.Items.Add(i);
                this.cBox_AdulteBaud.Items.Add(i);
                this.cBox_EnfantBaud.Items.Add(i);
                this.cBox_ReduitBaud.Items.Add(i);
                this.cBox_AdulteChauss.Items.Add(i);
                this.cBox_EnfantChauss.Items.Add(i);
                this.cBox_ReduitChauss.Items.Add(i);

            }


            this.cBox_AdulteEntry.SelectedIndex = 0;
            this.cBox_EnfantEntry.SelectedIndex = 0;
            this.cBox_ReduitEntry.SelectedIndex = 0;
            this.cBox_AdulteBaud.SelectedIndex = 0;
            this.cBox_EnfantBaud.SelectedIndex = 0;
            this.cBox_ReduitBaud.SelectedIndex = 0;
            this.cBox_AdulteChauss.SelectedIndex = 0;
            this.cBox_EnfantChauss.SelectedIndex = 0;
            this.cBox_ReduitChauss.SelectedIndex = 0;

        }


        private void btn_Valider_Click(object sender, EventArgs e)
        {
            _name = txtBox_Nom.Text;
            _firstname = txtBox_Prenom.Text;
            _newClient = chkBox_New.Checked;

            this.entreMatos.Add(1, (int)cBox_AdulteEntry.SelectedItem);
            this.entreMatos.Add(2, (int)cBox_ReduitEntry.SelectedItem);
            this.entreMatos.Add(3, (int)cBox_EnfantEntry.SelectedItem);
            this.entreMatos.Add(4, (int)cBox_AdulteBaud.SelectedItem);
            this.entreMatos.Add(5, (int)cBox_ReduitBaud.SelectedItem);
            this.entreMatos.Add(6, (int)cBox_EnfantBaud.SelectedItem);
            this.entreMatos.Add(7, (int)cBox_AdulteChauss.SelectedItem);
            this.entreMatos.Add(8, (int)cBox_ReduitChauss.SelectedItem);
            this.entreMatos.Add(9, (int)cBox_EnfantChauss.SelectedItem);

            
        }

        
    }
}

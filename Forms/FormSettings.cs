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
using System.Xml.Linq;

namespace CU_ExitPaiment.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtBox_ServerAddr.Text = SQLConnect._dataSource;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Logger.UpdateParam("Server_Adress", txtBox_ServerAddr.Text);
        }

        private void btn_SaveNewPsw_Click(object sender, EventArgs e)
        {
            var checkedButton = grpBox_UpdatePsw.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            switch (checkedButton.Text)
            {
                case "Utilisateur":
                    SQLConnect.changeUserPassword("user", this.txtBox_NewPsw.Text);
                    break;
                case "Administrateur":
                    SQLConnect.changeUserPassword("admin", this.txtBox_NewPsw.Text);
                    break;
            }
        }
    }
}

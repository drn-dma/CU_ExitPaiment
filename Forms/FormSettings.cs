using CU_ExitPaiment.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CU_ExitPaiment.Forms
{
    public partial class FormSettings : Form
    {
        private Form1 parentForm;
        public FormSettings(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            comboBox_Users.Items.Clear();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtBox_ServerAddr.Text = SQLConnect._dataSource;

            var allUsername = SQLConnect.getAllUsername();

            foreach(var user in allUsername)
            {
                comboBox_Users.Items.Add(user["name"]);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Logger.UpdateParam("Server_Adress", txtBox_ServerAddr.Text);
        }

        private void btn_SaveNewPsw_Click(object sender, EventArgs e)
        {
            if (txtBox_NewPsw.Text.Equals(txtBox_VerifPsw.Text))
            {
                SQLConnect.changeUserPassword(comboBox_Users.Text, txtBox_NewPsw.Text);

                txtBox_NewPsw.Text = null;

                parentForm.btn_Home_Click(this, new EventArgs());
            }else
            {

            }

        }

        private void comboBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cBox = (ComboBox)sender;
            Console.WriteLine(cBox.Text);
        }

        private void txtBox_VerifPsw_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (!txtBox.Text.Equals(txtBox_NewPsw.Text))
            {
                txtBox.ForeColor = Color.Red;
            }
            else
            {
                txtBox.ForeColor = SystemColors.ControlLight;
            }
        }
    }
}

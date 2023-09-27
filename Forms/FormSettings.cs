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
    }
}

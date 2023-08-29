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

        public FormNewClient()
        {
            InitializeComponent();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            _name = txtBox_Nom.Text;
            _firstname = txtBox_Prenom.Text;
            _newClient = chkBox_New.Checked;
        }
    }
}

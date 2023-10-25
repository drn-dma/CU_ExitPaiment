using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CU_ExitPaiment.Classes;

namespace CU_ExitPaiment.Forms
{
    public partial class FormStats : Form
    {
        private Form currentChildForm;
        private FormStats_Day_Month_Year formStats_DM;

        public FormStats()
        {
            InitializeComponent();
            
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            formStats_DM = new FormStats_Day_Month_Year();
            OpenChildForm(formStats_DM);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Visible = false;
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(childForm);
            pnl_Main.Tag = childForm;
            pnl_Main.BringToFront();
            childForm.Show();

        }
    }
}

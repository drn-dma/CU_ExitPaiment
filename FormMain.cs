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

namespace CU_ExitPaiment
{
    public partial class Form1 : Form
    {
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 768);

        }


        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Desktop.Controls.Add(childForm);
            pnl_Desktop.Tag = childForm;
            pnl_Desktop.BringToFront();
            childForm.Show();

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome());
        }
    }
}

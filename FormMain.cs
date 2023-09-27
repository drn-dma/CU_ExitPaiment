using CU_ExitPaiment.Classes;
using CU_ExitPaiment.Forms;
using FontAwesome.Sharp;
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
        private FormHome formHome;
        private FormStats formStats;
        private FormSettings formSettings;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 768);
            this.formHome = new FormHome();
            this.formStats = new FormStats();
            this.formSettings = new FormSettings();
            OpenChildForm(formHome);
            this.btn_Home.Enabled = false;
            this.btn_Stats.Enabled = true;
            this.btn_Settings.Enabled = true;

        }


        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Visible = false;
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
            OpenChildForm(formHome);
            this.btn_Home.Enabled = false;
            this.btn_Stats.Enabled = true;
            this.btn_Settings.Enabled = true;
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            OpenChildForm(formStats);
            this.btn_Home.Enabled = true;
            this.btn_Stats.Enabled = false;
            this.btn_Settings.Enabled = true;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            string pin = "";

            if(FunctionsLibs.InputBox_General("Connexion administrateur", "Code Pin", ref pin) == DialogResult.OK)
            {
                if (SQLConnect.isAdmin(pin))
                {
                    OpenChildForm(formSettings);
                    this.btn_Home.Enabled = true;
                    this.btn_Stats.Enabled = true;
                    this.btn_Settings.Enabled = false;

                }
                else
                {
                    OpenChildForm(formHome);
                    this.btn_Home.Enabled = false;
                    this.btn_Stats.Enabled = true;
                    this.btn_Settings.Enabled = true;
                }
            }

            
            

        }

        private void btn_EnabledChanged(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = btn.Enabled == false ? Color.White : Color.LightGray;
            btn.IconColor = btn.Enabled == false ? Color.White : Color.SlateGray;
            btn.BackColor = btn.Enabled == false ? Color.SlateGray : Color.FromArgb(58, 59, 64);
        }
    }
}

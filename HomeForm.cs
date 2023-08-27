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
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnl_Sub_Home.Visible = false;
            pnl_Sub_Stats.Visible = false;
        }


        private void viewHideSubs(Panel subs)
        {
            
            if(subs.Visible == true)
            {
                subs.Visible = false;
            }
            else
            {
                subs.Visible = true;
            }
        }


        private void ShowSub(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.Name)
            {
                case "btn_Main_Home":
                    viewHideSubs(pnl_Sub_Home);
                    break;
                case "btn_Main_Stats":
                    viewHideSubs(pnl_Sub_Stats);
                    break;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 768);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

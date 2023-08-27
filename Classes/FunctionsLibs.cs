using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_ExitPaiment.Classes
{
    internal class FunctionsLibs
    {

        #region add_UControls Methods

        /// <summary>
        //! Ajout d'un UserControl 'uc' dans un Panel 'panelObject' et le met au premier plan (BringToFront) 
        //// </summary>
        /// <param name="uc"></param>
        /// <param name="panelObject"></param>
        public static void add_UControls(UserControl uc, Panel panelObject)
        {

            uc.Dock = DockStyle.Fill;       //! Permet de remplir le panel avec l'UC
            panelObject.Controls.Clear();
            panelObject.Controls.Add(uc);
            uc.BringToFront();
        }


        //! Fonction alternative utilisant un Control à la place d'un Panel
        public static void add_UControls(UserControl uc, Control control)
        {

            uc.Dock = DockStyle.Fill;       //! Permet de remplir le panel avec l'UC
            control.Controls.Clear();
            control.Controls.Add(uc);
            uc.BringToFront();
        }

        #endregion
    }
}

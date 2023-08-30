using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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


        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            
            var source = new AutoCompleteStringCollection();
            var allComments = SQLConnect.getAllLoyalComment();
            foreach (var item in allComments)
            {
                source.Add(item["commentLoyality"].ToString());
            }


            label.Text = promptText;
            textBox.Text = value;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteCustomSource = source;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(12, 20, 250, 13);
            textBox.SetBounds(12, 36, 250, 20);
            buttonOk.SetBounds(185, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.ClientSize = new Size(Math.Min(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
               
            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(buttonOk);


            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        #endregion
    }
}

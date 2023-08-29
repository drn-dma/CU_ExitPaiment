namespace CU_ExitPaiment.Forms
{
    partial class FormNewClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkBox_New = new System.Windows.Forms.CheckBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Prenom = new System.Windows.Forms.TextBox();
            this.txtBox_Nom = new System.Windows.Forms.TextBox();
            this.cBox_EnfantEntry = new System.Windows.Forms.ComboBox();
            this.cBox_ReduitEntry = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteEntry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_EnfantBaud = new System.Windows.Forms.ComboBox();
            this.cBox_ReduitBaud = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteBaud = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox_EnfantChauss = new System.Windows.Forms.ComboBox();
            this.cBox_ReduitChauss = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteChauss = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cBox_EnfantChauss);
            this.panel2.Controls.Add(this.cBox_ReduitChauss);
            this.panel2.Controls.Add(this.cBox_AdulteChauss);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cBox_EnfantBaud);
            this.panel2.Controls.Add(this.cBox_ReduitBaud);
            this.panel2.Controls.Add(this.cBox_AdulteBaud);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cBox_EnfantEntry);
            this.panel2.Controls.Add(this.cBox_ReduitEntry);
            this.panel2.Controls.Add(this.cBox_AdulteEntry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.chkBox_New);
            this.panel2.Controls.Add(this.btn_Valider);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBox_Prenom);
            this.panel2.Controls.Add(this.txtBox_Nom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 372);
            this.panel2.TabIndex = 1;
            // 
            // chkBox_New
            // 
            this.chkBox_New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBox_New.AutoSize = true;
            this.chkBox_New.ForeColor = System.Drawing.Color.LightGray;
            this.chkBox_New.Location = new System.Drawing.Point(497, 59);
            this.chkBox_New.Name = "chkBox_New";
            this.chkBox_New.Size = new System.Drawing.Size(82, 17);
            this.chkBox_New.TabIndex = 5;
            this.chkBox_New.Text = "Nouveau ? ";
            this.chkBox_New.UseVisualStyleBackColor = true;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Valider.Location = new System.Drawing.Point(336, 230);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 4;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(387, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // txtBox_Prenom
            // 
            this.txtBox_Prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_Prenom.Location = new System.Drawing.Point(373, 59);
            this.txtBox_Prenom.Name = "txtBox_Prenom";
            this.txtBox_Prenom.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Prenom.TabIndex = 1;
            // 
            // txtBox_Nom
            // 
            this.txtBox_Nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_Nom.Location = new System.Drawing.Point(251, 59);
            this.txtBox_Nom.Name = "txtBox_Nom";
            this.txtBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Nom.TabIndex = 0;
            // 
            // cBox_EnfantEntry
            // 
            this.cBox_EnfantEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantEntry.FormattingEnabled = true;
            this.cBox_EnfantEntry.Location = new System.Drawing.Point(255, 168);
            this.cBox_EnfantEntry.Name = "cBox_EnfantEntry";
            this.cBox_EnfantEntry.Size = new System.Drawing.Size(30, 21);
            this.cBox_EnfantEntry.TabIndex = 14;
            // 
            // cBox_ReduitEntry
            // 
            this.cBox_ReduitEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitEntry.FormattingEnabled = true;
            this.cBox_ReduitEntry.Location = new System.Drawing.Point(255, 145);
            this.cBox_ReduitEntry.Name = "cBox_ReduitEntry";
            this.cBox_ReduitEntry.Size = new System.Drawing.Size(30, 21);
            this.cBox_ReduitEntry.TabIndex = 13;
            // 
            // cBox_AdulteEntry
            // 
            this.cBox_AdulteEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteEntry.FormattingEnabled = true;
            this.cBox_AdulteEntry.Location = new System.Drawing.Point(255, 122);
            this.cBox_AdulteEntry.Name = "cBox_AdulteEntry";
            this.cBox_AdulteEntry.Size = new System.Drawing.Size(30, 21);
            this.cBox_AdulteEntry.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(138, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Entrée Enfant :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(138, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entrée Réduite :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(138, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entrée Adulte :";
            // 
            // cBox_EnfantBaud
            // 
            this.cBox_EnfantBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantBaud.FormattingEnabled = true;
            this.cBox_EnfantBaud.Location = new System.Drawing.Point(431, 168);
            this.cBox_EnfantBaud.Name = "cBox_EnfantBaud";
            this.cBox_EnfantBaud.Size = new System.Drawing.Size(30, 21);
            this.cBox_EnfantBaud.TabIndex = 20;
            // 
            // cBox_ReduitBaud
            // 
            this.cBox_ReduitBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitBaud.FormattingEnabled = true;
            this.cBox_ReduitBaud.Location = new System.Drawing.Point(431, 145);
            this.cBox_ReduitBaud.Name = "cBox_ReduitBaud";
            this.cBox_ReduitBaud.Size = new System.Drawing.Size(30, 21);
            this.cBox_ReduitBaud.TabIndex = 19;
            // 
            // cBox_AdulteBaud
            // 
            this.cBox_AdulteBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteBaud.FormattingEnabled = true;
            this.cBox_AdulteBaud.Location = new System.Drawing.Point(431, 122);
            this.cBox_AdulteBaud.Name = "cBox_AdulteBaud";
            this.cBox_AdulteBaud.Size = new System.Drawing.Size(30, 21);
            this.cBox_AdulteBaud.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(307, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Baudrier Enfant :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(307, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Baudrier Réduit :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(307, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Baudrier Adulte :";
            // 
            // cBox_EnfantChauss
            // 
            this.cBox_EnfantChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantChauss.FormattingEnabled = true;
            this.cBox_EnfantChauss.Location = new System.Drawing.Point(609, 168);
            this.cBox_EnfantChauss.Name = "cBox_EnfantChauss";
            this.cBox_EnfantChauss.Size = new System.Drawing.Size(30, 21);
            this.cBox_EnfantChauss.TabIndex = 26;
            // 
            // cBox_ReduitChauss
            // 
            this.cBox_ReduitChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitChauss.FormattingEnabled = true;
            this.cBox_ReduitChauss.Location = new System.Drawing.Point(609, 145);
            this.cBox_ReduitChauss.Name = "cBox_ReduitChauss";
            this.cBox_ReduitChauss.Size = new System.Drawing.Size(30, 21);
            this.cBox_ReduitChauss.TabIndex = 25;
            // 
            // cBox_AdulteChauss
            // 
            this.cBox_AdulteChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteChauss.FormattingEnabled = true;
            this.cBox_AdulteChauss.Location = new System.Drawing.Point(609, 122);
            this.cBox_AdulteChauss.Name = "cBox_AdulteChauss";
            this.cBox_AdulteChauss.Size = new System.Drawing.Size(30, 21);
            this.cBox_AdulteChauss.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(476, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Chausson Enfant :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(476, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chausson Réduit :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(476, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Chausson Adulte :";
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewClient";
            this.Text = "FormNewClient";
            this.Load += new System.EventHandler(this.FormNewClient_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Prenom;
        private System.Windows.Forms.TextBox txtBox_Nom;
        private System.Windows.Forms.CheckBox chkBox_New;
        private System.Windows.Forms.ComboBox cBox_EnfantEntry;
        private System.Windows.Forms.ComboBox cBox_ReduitEntry;
        private System.Windows.Forms.ComboBox cBox_AdulteEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox_EnfantChauss;
        private System.Windows.Forms.ComboBox cBox_ReduitChauss;
        private System.Windows.Forms.ComboBox cBox_AdulteChauss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBox_EnfantBaud;
        private System.Windows.Forms.ComboBox cBox_ReduitBaud;
        private System.Windows.Forms.ComboBox cBox_AdulteBaud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
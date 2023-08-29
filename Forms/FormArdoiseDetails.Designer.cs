namespace CU_ExitPaiment.Forms
{
    partial class FormArdoiseDetails
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
            this.lbl_NomClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_Adulte = new System.Windows.Forms.ComboBox();
            this.cBox_Reduit = new System.Windows.Forms.ComboBox();
            this.cBox_Enfant = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_NomClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // lbl_NomClient
            // 
            this.lbl_NomClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NomClient.AutoSize = true;
            this.lbl_NomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomClient.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_NomClient.Location = new System.Drawing.Point(356, 30);
            this.lbl_NomClient.Name = "lbl_NomClient";
            this.lbl_NomClient.Size = new System.Drawing.Size(64, 25);
            this.lbl_NomClient.TabIndex = 0;
            this.lbl_NomClient.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cBox_Enfant);
            this.panel2.Controls.Add(this.cBox_Reduit);
            this.panel2.Controls.Add(this.cBox_Adulte);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 370);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrée Adulte :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(72, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrée Réduite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(72, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrée Enfant :";
            // 
            // cBox_Adulte
            // 
            this.cBox_Adulte.FormattingEnabled = true;
            this.cBox_Adulte.Location = new System.Drawing.Point(189, 51);
            this.cBox_Adulte.Name = "cBox_Adulte";
            this.cBox_Adulte.Size = new System.Drawing.Size(30, 21);
            this.cBox_Adulte.TabIndex = 6;
            // 
            // cBox_Reduit
            // 
            this.cBox_Reduit.FormattingEnabled = true;
            this.cBox_Reduit.Location = new System.Drawing.Point(189, 74);
            this.cBox_Reduit.Name = "cBox_Reduit";
            this.cBox_Reduit.Size = new System.Drawing.Size(30, 21);
            this.cBox_Reduit.TabIndex = 7;
            // 
            // cBox_Enfant
            // 
            this.cBox_Enfant.FormattingEnabled = true;
            this.cBox_Enfant.Location = new System.Drawing.Point(189, 97);
            this.cBox_Enfant.Name = "cBox_Enfant";
            this.cBox_Enfant.Size = new System.Drawing.Size(30, 21);
            this.cBox_Enfant.TabIndex = 8;
            // 
            // FormArdoiseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormArdoiseDetails";
            this.Text = "FormArdoiseDetails";
            this.Load += new System.EventHandler(this.FormArdoiseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_NomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Enfant;
        private System.Windows.Forms.ComboBox cBox_Reduit;
        private System.Windows.Forms.ComboBox cBox_Adulte;
    }
}
namespace CU_ExitPaiment.Forms
{
    partial class FormStats_Day_Month_Year
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Clients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_AllUnitEntry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateP_2 = new CU_ExitPaiment.Classes.CSDatePicker();
            this.dateP_1 = new CU_ExitPaiment.Classes.CSDatePicker();
            this.grpBox_DetailsClient = new System.Windows.Forms.GroupBox();
            this.lbl_FidelDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_TotEntryBefLoyal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TotDepense = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TotPaiementSortie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_Top.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.grpBox_DetailsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_Search);
            this.pnl_Top.Controls.Add(this.label3);
            this.pnl_Top.Controls.Add(this.label2);
            this.pnl_Top.Controls.Add(this.comboBox_Clients);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Controls.Add(this.dateP_2);
            this.pnl_Top.Controls.Add(this.dateP_1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 112);
            this.pnl_Top.TabIndex = 14;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Location = new System.Drawing.Point(364, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Rechercher";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(587, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Clients :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Du";
            // 
            // comboBox_Clients
            // 
            this.comboBox_Clients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Clients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Clients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Clients.FormattingEnabled = true;
            this.comboBox_Clients.Location = new System.Drawing.Point(661, 32);
            this.comboBox_Clients.Name = "comboBox_Clients";
            this.comboBox_Clients.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Clients.TabIndex = 17;
            this.comboBox_Clients.Text = "Selectionner...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(290, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "jusqu\'au";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.grpBox_DetailsClient);
            this.pnl_Main.Controls.Add(this.lbl_AllUnitEntry);
            this.pnl_Main.Controls.Add(this.label4);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 112);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(800, 338);
            this.pnl_Main.TabIndex = 15;
            // 
            // lbl_AllUnitEntry
            // 
            this.lbl_AllUnitEntry.AutoSize = true;
            this.lbl_AllUnitEntry.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_AllUnitEntry.Location = new System.Drawing.Point(231, 55);
            this.lbl_AllUnitEntry.Name = "lbl_AllUnitEntry";
            this.lbl_AllUnitEntry.Size = new System.Drawing.Size(37, 13);
            this.lbl_AllUnitEntry.TabIndex = 1;
            this.lbl_AllUnitEntry.Text = "99999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre total d\'entrées unitaire :";
            // 
            // dateP_2
            // 
            this.dateP_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateP_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(108)))));
            this.dateP_2.BorderSize = 1;
            this.dateP_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateP_2.Location = new System.Drawing.Point(364, 22);
            this.dateP_2.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateP_2.Name = "dateP_2";
            this.dateP_2.Size = new System.Drawing.Size(205, 35);
            this.dateP_2.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(182)))), ((int)(((byte)(86)))));
            this.dateP_2.TabIndex = 14;
            this.dateP_2.TextColor = System.Drawing.Color.White;
            // 
            // dateP_1
            // 
            this.dateP_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateP_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(108)))));
            this.dateP_1.BorderSize = 1;
            this.dateP_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateP_1.Location = new System.Drawing.Point(79, 22);
            this.dateP_1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateP_1.Name = "dateP_1";
            this.dateP_1.Size = new System.Drawing.Size(205, 35);
            this.dateP_1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(182)))), ((int)(((byte)(86)))));
            this.dateP_1.TabIndex = 12;
            this.dateP_1.TextColor = System.Drawing.Color.White;
            // 
            // grpBox_DetailsClient
            // 
            this.grpBox_DetailsClient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpBox_DetailsClient.Controls.Add(this.lbl_TotPaiementSortie);
            this.grpBox_DetailsClient.Controls.Add(this.label8);
            this.grpBox_DetailsClient.Controls.Add(this.lbl_TotDepense);
            this.grpBox_DetailsClient.Controls.Add(this.label9);
            this.grpBox_DetailsClient.Controls.Add(this.lbl_TotEntryBefLoyal);
            this.grpBox_DetailsClient.Controls.Add(this.label7);
            this.grpBox_DetailsClient.Controls.Add(this.lbl_FidelDate);
            this.grpBox_DetailsClient.Controls.Add(this.label6);
            this.grpBox_DetailsClient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_DetailsClient.Location = new System.Drawing.Point(513, 32);
            this.grpBox_DetailsClient.Name = "grpBox_DetailsClient";
            this.grpBox_DetailsClient.Size = new System.Drawing.Size(258, 141);
            this.grpBox_DetailsClient.TabIndex = 2;
            this.grpBox_DetailsClient.TabStop = false;
            this.grpBox_DetailsClient.Text = "Détails Client";
            // 
            // lbl_FidelDate
            // 
            this.lbl_FidelDate.AutoSize = true;
            this.lbl_FidelDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_FidelDate.Location = new System.Drawing.Point(137, 24);
            this.lbl_FidelDate.Name = "lbl_FidelDate";
            this.lbl_FidelDate.Size = new System.Drawing.Size(65, 13);
            this.lbl_FidelDate.TabIndex = 3;
            this.lbl_FidelDate.Text = "01/01/1900";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date de fidélisation :";
            // 
            // lbl_TotEntryBefLoyal
            // 
            this.lbl_TotEntryBefLoyal.AutoSize = true;
            this.lbl_TotEntryBefLoyal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TotEntryBefLoyal.Location = new System.Drawing.Point(167, 47);
            this.lbl_TotEntryBefLoyal.Name = "lbl_TotEntryBefLoyal";
            this.lbl_TotEntryBefLoyal.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotEntryBefLoyal.TabIndex = 5;
            this.lbl_TotEntryBefLoyal.Text = "9999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total entrées avant Fidél. :";
            // 
            // lbl_TotDepense
            // 
            this.lbl_TotDepense.AutoSize = true;
            this.lbl_TotDepense.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TotDepense.Location = new System.Drawing.Point(138, 73);
            this.lbl_TotDepense.Name = "lbl_TotDepense";
            this.lbl_TotDepense.Size = new System.Drawing.Size(40, 13);
            this.lbl_TotDepense.TabIndex = 7;
            this.lbl_TotDepense.Text = "9999 €";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total des dépenses :";
            // 
            // lbl_TotPaiementSortie
            // 
            this.lbl_TotPaiementSortie.AutoSize = true;
            this.lbl_TotPaiementSortie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_TotPaiementSortie.Location = new System.Drawing.Point(206, 97);
            this.lbl_TotPaiementSortie.Name = "lbl_TotPaiementSortie";
            this.lbl_TotPaiementSortie.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotPaiementSortie.TabIndex = 9;
            this.lbl_TotPaiementSortie.Text = "9999";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total apparition paiement sortie :";
            // 
            // FormStats_Day_Month_Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Top);
            this.Name = "FormStats_Day_Month_Year";
            this.Text = "FormStats_Day_Month_Year";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.grpBox_DetailsClient.ResumeLayout(false);
            this.grpBox_DetailsClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.CSDatePicker dateP_1;
        private System.Windows.Forms.Panel pnl_Top;
        private Classes.CSDatePicker dateP_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Clients;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_AllUnitEntry;
        private System.Windows.Forms.GroupBox grpBox_DetailsClient;
        private System.Windows.Forms.Label lbl_TotPaiementSortie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_TotDepense;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TotEntryBefLoyal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_FidelDate;
        private System.Windows.Forms.Label label6;
    }
}
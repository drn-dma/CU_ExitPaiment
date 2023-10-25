namespace CU_ExitPaiment.Forms
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_ServerAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new FontAwesome.Sharp.IconButton();
            this.grpBox_UpdatePsw = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_VerifPsw = new System.Windows.Forms.TextBox();
            this.comboBox_Users = new System.Windows.Forms.ComboBox();
            this.btn_SaveNewPsw = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_NewPsw = new System.Windows.Forms.TextBox();
            this.grpBox_UpdatePsw.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramètres";
            // 
            // txtBox_ServerAddr
            // 
            this.txtBox_ServerAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_ServerAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ServerAddr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_ServerAddr.Location = new System.Drawing.Point(325, 100);
            this.txtBox_ServerAddr.Name = "txtBox_ServerAddr";
            this.txtBox_ServerAddr.Size = new System.Drawing.Size(199, 20);
            this.txtBox_ServerAddr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(98, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serveur de base de données :";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSize = true;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_Save.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Save.Location = new System.Drawing.Point(528, 83);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 56);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Sauvegarder";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // grpBox_UpdatePsw
            // 
            this.grpBox_UpdatePsw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpBox_UpdatePsw.Controls.Add(this.label5);
            this.grpBox_UpdatePsw.Controls.Add(this.label4);
            this.grpBox_UpdatePsw.Controls.Add(this.txtBox_VerifPsw);
            this.grpBox_UpdatePsw.Controls.Add(this.comboBox_Users);
            this.grpBox_UpdatePsw.Controls.Add(this.btn_SaveNewPsw);
            this.grpBox_UpdatePsw.Controls.Add(this.label3);
            this.grpBox_UpdatePsw.Controls.Add(this.txtBox_NewPsw);
            this.grpBox_UpdatePsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_UpdatePsw.Location = new System.Drawing.Point(21, 205);
            this.grpBox_UpdatePsw.Name = "grpBox_UpdatePsw";
            this.grpBox_UpdatePsw.Size = new System.Drawing.Size(246, 233);
            this.grpBox_UpdatePsw.TabIndex = 6;
            this.grpBox_UpdatePsw.TabStop = false;
            this.grpBox_UpdatePsw.Text = "Modification du mot de passe";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Utilisateur : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirmer mot de passe : ";
            // 
            // txtBox_VerifPsw
            // 
            this.txtBox_VerifPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_VerifPsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_VerifPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_VerifPsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_VerifPsw.Location = new System.Drawing.Point(20, 130);
            this.txtBox_VerifPsw.Name = "txtBox_VerifPsw";
            this.txtBox_VerifPsw.Size = new System.Drawing.Size(199, 20);
            this.txtBox_VerifPsw.TabIndex = 10;
            this.txtBox_VerifPsw.UseSystemPasswordChar = true;
            this.txtBox_VerifPsw.TextChanged += new System.EventHandler(this.txtBox_VerifPsw_TextChanged);
            // 
            // comboBox_Users
            // 
            this.comboBox_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Users.FormattingEnabled = true;
            this.comboBox_Users.Location = new System.Drawing.Point(56, 36);
            this.comboBox_Users.Name = "comboBox_Users";
            this.comboBox_Users.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Users.TabIndex = 9;
            this.comboBox_Users.SelectedIndexChanged += new System.EventHandler(this.comboBox_Users_SelectedIndexChanged);
            // 
            // btn_SaveNewPsw
            // 
            this.btn_SaveNewPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveNewPsw.AutoSize = true;
            this.btn_SaveNewPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveNewPsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SaveNewPsw.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_SaveNewPsw.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SaveNewPsw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SaveNewPsw.Location = new System.Drawing.Point(56, 164);
            this.btn_SaveNewPsw.Margin = new System.Windows.Forms.Padding(1);
            this.btn_SaveNewPsw.Name = "btn_SaveNewPsw";
            this.btn_SaveNewPsw.Size = new System.Drawing.Size(128, 56);
            this.btn_SaveNewPsw.TabIndex = 8;
            this.btn_SaveNewPsw.Text = "Sauvegarder";
            this.btn_SaveNewPsw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveNewPsw.UseVisualStyleBackColor = true;
            this.btn_SaveNewPsw.Click += new System.EventHandler(this.btn_SaveNewPsw_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nouveau mot de passe : ";
            // 
            // txtBox_NewPsw
            // 
            this.txtBox_NewPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_NewPsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_NewPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_NewPsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_NewPsw.Location = new System.Drawing.Point(20, 85);
            this.txtBox_NewPsw.Name = "txtBox_NewPsw";
            this.txtBox_NewPsw.Size = new System.Drawing.Size(199, 20);
            this.txtBox_NewPsw.TabIndex = 6;
            this.txtBox_NewPsw.UseSystemPasswordChar = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox_UpdatePsw);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_ServerAddr);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.grpBox_UpdatePsw.ResumeLayout(false);
            this.grpBox_UpdatePsw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_ServerAddr;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_Save;
        private System.Windows.Forms.GroupBox grpBox_UpdatePsw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_NewPsw;
        private FontAwesome.Sharp.IconButton btn_SaveNewPsw;
        private System.Windows.Forms.ComboBox comboBox_Users;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_VerifPsw;
        private System.Windows.Forms.Label label5;
    }
}
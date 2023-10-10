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
            this.rdb_User = new System.Windows.Forms.RadioButton();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.grpBox_UpdatePsw = new System.Windows.Forms.GroupBox();
            this.txtBox_NewPsw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SaveNewPsw = new FontAwesome.Sharp.IconButton();
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
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // txtBox_ServerAddr
            // 
            this.txtBox_ServerAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_ServerAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ServerAddr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_ServerAddr.Location = new System.Drawing.Point(400, 92);
            this.txtBox_ServerAddr.Name = "txtBox_ServerAddr";
            this.txtBox_ServerAddr.Size = new System.Drawing.Size(199, 20);
            this.txtBox_ServerAddr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(173, 92);
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
            this.btn_Save.Location = new System.Drawing.Point(574, 259);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(136, 73);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Sauvegarder";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // rdb_User
            // 
            this.rdb_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_User.AutoSize = true;
            this.rdb_User.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdb_User.Location = new System.Drawing.Point(72, 48);
            this.rdb_User.Name = "rdb_User";
            this.rdb_User.Size = new System.Drawing.Size(71, 17);
            this.rdb_User.TabIndex = 4;
            this.rdb_User.TabStop = true;
            this.rdb_User.Tag = "userSelect";
            this.rdb_User.Text = "Utilisateur";
            this.rdb_User.UseVisualStyleBackColor = true;
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdb_Admin.Location = new System.Drawing.Point(72, 74);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(91, 17);
            this.rdb_Admin.TabIndex = 5;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Tag = "userSelect";
            this.rdb_Admin.Text = "Administrateur";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // grpBox_UpdatePsw
            // 
            this.grpBox_UpdatePsw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpBox_UpdatePsw.Controls.Add(this.btn_SaveNewPsw);
            this.grpBox_UpdatePsw.Controls.Add(this.label3);
            this.grpBox_UpdatePsw.Controls.Add(this.txtBox_NewPsw);
            this.grpBox_UpdatePsw.Controls.Add(this.rdb_Admin);
            this.grpBox_UpdatePsw.Controls.Add(this.rdb_User);
            this.grpBox_UpdatePsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpBox_UpdatePsw.Location = new System.Drawing.Point(21, 205);
            this.grpBox_UpdatePsw.Name = "grpBox_UpdatePsw";
            this.grpBox_UpdatePsw.Size = new System.Drawing.Size(247, 233);
            this.grpBox_UpdatePsw.TabIndex = 6;
            this.grpBox_UpdatePsw.TabStop = false;
            this.grpBox_UpdatePsw.Text = "Modification du mot de passe";
            // 
            // txtBox_NewPsw
            // 
            this.txtBox_NewPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_NewPsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_NewPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_NewPsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_NewPsw.Location = new System.Drawing.Point(20, 128);
            this.txtBox_NewPsw.Name = "txtBox_NewPsw";
            this.txtBox_NewPsw.Size = new System.Drawing.Size(199, 20);
            this.txtBox_NewPsw.TabIndex = 6;
            this.txtBox_NewPsw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nouveau mot de passe : ";
            // 
            // btn_SaveNewPsw
            // 
            this.btn_SaveNewPsw.AutoSize = true;
            this.btn_SaveNewPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveNewPsw.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SaveNewPsw.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_SaveNewPsw.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SaveNewPsw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SaveNewPsw.Location = new System.Drawing.Point(56, 163);
            this.btn_SaveNewPsw.Margin = new System.Windows.Forms.Padding(1);
            this.btn_SaveNewPsw.Name = "btn_SaveNewPsw";
            this.btn_SaveNewPsw.Size = new System.Drawing.Size(128, 56);
            this.btn_SaveNewPsw.TabIndex = 8;
            this.btn_SaveNewPsw.Text = "Sauvegarder";
            this.btn_SaveNewPsw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveNewPsw.UseVisualStyleBackColor = true;
            this.btn_SaveNewPsw.Click += new System.EventHandler(this.btn_SaveNewPsw_Click);
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
            this.Text = "Settings";
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
        private System.Windows.Forms.RadioButton rdb_User;
        private System.Windows.Forms.RadioButton rdb_Admin;
        private System.Windows.Forms.GroupBox grpBox_UpdatePsw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_NewPsw;
        private FontAwesome.Sharp.IconButton btn_SaveNewPsw;
    }
}
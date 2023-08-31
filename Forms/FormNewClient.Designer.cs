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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBox_New = new System.Windows.Forms.CheckBox();
            this.txtBox_NomPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_EnfantEntry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_ReduitEntry = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteEntry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_EnfantChauss = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox_ReduitChauss = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_AdulteChauss = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteBaud = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBox_ReduitBaud = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_EnfantBaud = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(208, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création d\'une nouvelle ardoise :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 372);
            this.panel2.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.AutoSize = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 2;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Cancel.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btn_Cancel.IconColor = System.Drawing.Color.White;
            this.btn_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancel.Location = new System.Drawing.Point(260, 304);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(126, 60);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Annuler";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(182)))), ((int)(((byte)(86)))));
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(108)))));
            this.iconButton1.FlatAppearance.BorderSize = 2;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.LightGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(392, 304);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(121, 60);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Valider";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.chkBox_New);
            this.groupBox3.Controls.Add(this.txtBox_NomPrenom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(45, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 88);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information Client";
            // 
            // chkBox_New
            // 
            this.chkBox_New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBox_New.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBox_New.AutoSize = true;
            this.chkBox_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.chkBox_New.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(182)))), ((int)(((byte)(86)))));
            this.chkBox_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBox_New.ForeColor = System.Drawing.Color.LightGray;
            this.chkBox_New.Location = new System.Drawing.Point(152, 44);
            this.chkBox_New.Name = "chkBox_New";
            this.chkBox_New.Size = new System.Drawing.Size(73, 23);
            this.chkBox_New.TabIndex = 1;
            this.chkBox_New.Text = "Nouveau ? ";
            this.chkBox_New.UseVisualStyleBackColor = false;
            this.chkBox_New.CheckedChanged += new System.EventHandler(this.chkBox_New_CheckedChanged);
            // 
            // txtBox_NomPrenom
            // 
            this.txtBox_NomPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_NomPrenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBox_NomPrenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBox_NomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_NomPrenom.Location = new System.Drawing.Point(20, 43);
            this.txtBox_NomPrenom.Name = "txtBox_NomPrenom";
            this.txtBox_NomPrenom.Size = new System.Drawing.Size(126, 26);
            this.txtBox_NomPrenom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOM Prénom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cBox_EnfantEntry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cBox_ReduitEntry);
            this.groupBox2.Controls.Add(this.cBox_AdulteEntry);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(477, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrée";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Entrée Enfant :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entrée Adulte :";
            // 
            // cBox_EnfantEntry
            // 
            this.cBox_EnfantEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantEntry.FormattingEnabled = true;
            this.cBox_EnfantEntry.Location = new System.Drawing.Point(140, 82);
            this.cBox_EnfantEntry.Name = "cBox_EnfantEntry";
            this.cBox_EnfantEntry.Size = new System.Drawing.Size(35, 21);
            this.cBox_EnfantEntry.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(23, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entrée Réduite :";
            // 
            // cBox_ReduitEntry
            // 
            this.cBox_ReduitEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitEntry.FormattingEnabled = true;
            this.cBox_ReduitEntry.Location = new System.Drawing.Point(140, 55);
            this.cBox_ReduitEntry.Name = "cBox_ReduitEntry";
            this.cBox_ReduitEntry.Size = new System.Drawing.Size(35, 21);
            this.cBox_ReduitEntry.TabIndex = 3;
            // 
            // cBox_AdulteEntry
            // 
            this.cBox_AdulteEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteEntry.BackColor = System.Drawing.SystemColors.Window;
            this.cBox_AdulteEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteEntry.FormattingEnabled = true;
            this.cBox_AdulteEntry.Location = new System.Drawing.Point(140, 27);
            this.cBox_AdulteEntry.Name = "cBox_AdulteEntry";
            this.cBox_AdulteEntry.Size = new System.Drawing.Size(35, 21);
            this.cBox_AdulteEntry.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cBox_EnfantChauss);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cBox_ReduitChauss);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBox_AdulteChauss);
            this.groupBox1.Controls.Add(this.cBox_AdulteBaud);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cBox_ReduitBaud);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cBox_EnfantBaud);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(387, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 116);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matériel";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(11, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Baudrier Enfant :";
            // 
            // cBox_EnfantChauss
            // 
            this.cBox_EnfantChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantChauss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantChauss.FormattingEnabled = true;
            this.cBox_EnfantChauss.Location = new System.Drawing.Point(313, 76);
            this.cBox_EnfantChauss.Name = "cBox_EnfantChauss";
            this.cBox_EnfantChauss.Size = new System.Drawing.Size(35, 21);
            this.cBox_EnfantChauss.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Baudrier Adulte :";
            // 
            // cBox_ReduitChauss
            // 
            this.cBox_ReduitChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitChauss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitChauss.FormattingEnabled = true;
            this.cBox_ReduitChauss.Location = new System.Drawing.Point(313, 49);
            this.cBox_ReduitChauss.Name = "cBox_ReduitChauss";
            this.cBox_ReduitChauss.Size = new System.Drawing.Size(35, 21);
            this.cBox_ReduitChauss.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(11, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Baudrier Réduit :";
            // 
            // cBox_AdulteChauss
            // 
            this.cBox_AdulteChauss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteChauss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteChauss.FormattingEnabled = true;
            this.cBox_AdulteChauss.Location = new System.Drawing.Point(313, 21);
            this.cBox_AdulteChauss.Name = "cBox_AdulteChauss";
            this.cBox_AdulteChauss.Size = new System.Drawing.Size(35, 21);
            this.cBox_AdulteChauss.TabIndex = 6;
            // 
            // cBox_AdulteBaud
            // 
            this.cBox_AdulteBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteBaud.FormattingEnabled = true;
            this.cBox_AdulteBaud.Location = new System.Drawing.Point(135, 21);
            this.cBox_AdulteBaud.Name = "cBox_AdulteBaud";
            this.cBox_AdulteBaud.Size = new System.Drawing.Size(35, 21);
            this.cBox_AdulteBaud.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(180, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Chausson Enfant :";
            // 
            // cBox_ReduitBaud
            // 
            this.cBox_ReduitBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitBaud.FormattingEnabled = true;
            this.cBox_ReduitBaud.Location = new System.Drawing.Point(135, 49);
            this.cBox_ReduitBaud.Name = "cBox_ReduitBaud";
            this.cBox_ReduitBaud.Size = new System.Drawing.Size(35, 21);
            this.cBox_ReduitBaud.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(180, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chausson Réduit :";
            // 
            // cBox_EnfantBaud
            // 
            this.cBox_EnfantBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantBaud.FormattingEnabled = true;
            this.cBox_EnfantBaud.Location = new System.Drawing.Point(135, 76);
            this.cBox_EnfantBaud.Name = "cBox_EnfantBaud";
            this.cBox_EnfantBaud.Size = new System.Drawing.Size(35, 21);
            this.cBox_EnfantBaud.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(180, 22);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormNewClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_NomPrenom;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_Cancel;
    }
}
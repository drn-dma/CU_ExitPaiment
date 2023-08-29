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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArdoiseDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_NewClient = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_PrixApprox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nbVisite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_AdulteEntry__1 = new System.Windows.Forms.ComboBox();
            this.cBox_EnfantEntry__3 = new System.Windows.Forms.ComboBox();
            this.cBox_ReduitEntry__2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_ReduitBaud__6 = new System.Windows.Forms.ComboBox();
            this.cBox_EnfantBaud__8 = new System.Windows.Forms.ComboBox();
            this.cBox_EnfantChauss__9 = new System.Windows.Forms.ComboBox();
            this.cBox_AdulteBaud__4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cBox_ReduitChauss__7 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_AdulteChauss__5 = new System.Windows.Forms.ComboBox();
            this.btn_Checkout = new FontAwesome.Sharp.IconButton();
            this.btn_CancelCheckout = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_NewClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // btn_NewClient
            // 
            this.btn_NewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NewClient.AutoSize = true;
            this.btn_NewClient.FlatAppearance.BorderSize = 0;
            this.btn_NewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btn_NewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btn_NewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewClient.ForeColor = System.Drawing.Color.LightGray;
            this.btn_NewClient.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.btn_NewClient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NewClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NewClient.Location = new System.Drawing.Point(327, 12);
            this.btn_NewClient.Name = "btn_NewClient";
            this.btn_NewClient.Size = new System.Drawing.Size(184, 62);
            this.btn_NewClient.TabIndex = 1;
            this.btn_NewClient.Text = "Nom Prenom";
            this.btn_NewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_NewClient.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_PrixApprox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_nbVisite);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 370);
            this.panel2.TabIndex = 1;
            // 
            // lbl_PrixApprox
            // 
            this.lbl_PrixApprox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_PrixApprox.AutoSize = true;
            this.lbl_PrixApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixApprox.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_PrixApprox.Location = new System.Drawing.Point(471, 327);
            this.lbl_PrixApprox.Name = "lbl_PrixApprox";
            this.lbl_PrixApprox.Size = new System.Drawing.Size(40, 17);
            this.lbl_PrixApprox.TabIndex = 44;
            this.lbl_PrixApprox.Text = "9999";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(301, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Coût total (approx.) : ";
            // 
            // lbl_nbVisite
            // 
            this.lbl_nbVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nbVisite.AutoSize = true;
            this.lbl_nbVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbVisite.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_nbVisite.Location = new System.Drawing.Point(755, 327);
            this.lbl_nbVisite.Name = "lbl_nbVisite";
            this.lbl_nbVisite.Size = new System.Drawing.Size(32, 17);
            this.lbl_nbVisite.TabIndex = 42;
            this.lbl_nbVisite.Text = "999";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(596, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre de visites : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cBox_AdulteEntry__1);
            this.groupBox2.Controls.Add(this.cBox_EnfantEntry__3);
            this.groupBox2.Controls.Add(this.cBox_ReduitEntry__2);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(60, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 117);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrée Enfant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(27, 26);
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
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrée Réduite :";
            // 
            // cBox_AdulteEntry__1
            // 
            this.cBox_AdulteEntry__1.FormattingEnabled = true;
            this.cBox_AdulteEntry__1.Location = new System.Drawing.Point(156, 25);
            this.cBox_AdulteEntry__1.Name = "cBox_AdulteEntry__1";
            this.cBox_AdulteEntry__1.Size = new System.Drawing.Size(38, 21);
            this.cBox_AdulteEntry__1.TabIndex = 6;
            // 
            // cBox_EnfantEntry__3
            // 
            this.cBox_EnfantEntry__3.FormattingEnabled = true;
            this.cBox_EnfantEntry__3.Location = new System.Drawing.Point(156, 71);
            this.cBox_EnfantEntry__3.Name = "cBox_EnfantEntry__3";
            this.cBox_EnfantEntry__3.Size = new System.Drawing.Size(38, 21);
            this.cBox_EnfantEntry__3.TabIndex = 8;
            // 
            // cBox_ReduitEntry__2
            // 
            this.cBox_ReduitEntry__2.FormattingEnabled = true;
            this.cBox_ReduitEntry__2.Location = new System.Drawing.Point(156, 48);
            this.cBox_ReduitEntry__2.Name = "cBox_ReduitEntry__2";
            this.cBox_ReduitEntry__2.Size = new System.Drawing.Size(38, 21);
            this.cBox_ReduitEntry__2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cBox_ReduitBaud__6);
            this.groupBox1.Controls.Add(this.cBox_EnfantBaud__8);
            this.groupBox1.Controls.Add(this.cBox_EnfantChauss__9);
            this.groupBox1.Controls.Add(this.cBox_AdulteBaud__4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cBox_ReduitChauss__7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cBox_AdulteChauss__5);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(60, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 203);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matériel";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(23, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Chausson Réduit :";
            // 
            // cBox_ReduitBaud__6
            // 
            this.cBox_ReduitBaud__6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitBaud__6.FormattingEnabled = true;
            this.cBox_ReduitBaud__6.Location = new System.Drawing.Point(156, 45);
            this.cBox_ReduitBaud__6.Name = "cBox_ReduitBaud__6";
            this.cBox_ReduitBaud__6.Size = new System.Drawing.Size(38, 21);
            this.cBox_ReduitBaud__6.TabIndex = 31;
            // 
            // cBox_EnfantBaud__8
            // 
            this.cBox_EnfantBaud__8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantBaud__8.FormattingEnabled = true;
            this.cBox_EnfantBaud__8.Location = new System.Drawing.Point(156, 68);
            this.cBox_EnfantBaud__8.Name = "cBox_EnfantBaud__8";
            this.cBox_EnfantBaud__8.Size = new System.Drawing.Size(38, 21);
            this.cBox_EnfantBaud__8.TabIndex = 32;
            // 
            // cBox_EnfantChauss__9
            // 
            this.cBox_EnfantChauss__9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantChauss__9.FormattingEnabled = true;
            this.cBox_EnfantChauss__9.Location = new System.Drawing.Point(156, 159);
            this.cBox_EnfantChauss__9.Name = "cBox_EnfantChauss__9";
            this.cBox_EnfantChauss__9.Size = new System.Drawing.Size(38, 21);
            this.cBox_EnfantChauss__9.TabIndex = 38;
            // 
            // cBox_AdulteBaud__4
            // 
            this.cBox_AdulteBaud__4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteBaud__4.FormattingEnabled = true;
            this.cBox_AdulteBaud__4.Location = new System.Drawing.Point(156, 22);
            this.cBox_AdulteBaud__4.Name = "cBox_AdulteBaud__4";
            this.cBox_AdulteBaud__4.Size = new System.Drawing.Size(38, 21);
            this.cBox_AdulteBaud__4.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(23, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Baudrier Adulte :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(23, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Chausson Adulte :";
            // 
            // cBox_ReduitChauss__7
            // 
            this.cBox_ReduitChauss__7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitChauss__7.FormattingEnabled = true;
            this.cBox_ReduitChauss__7.Location = new System.Drawing.Point(156, 136);
            this.cBox_ReduitChauss__7.Name = "cBox_ReduitChauss__7";
            this.cBox_ReduitChauss__7.Size = new System.Drawing.Size(38, 21);
            this.cBox_ReduitChauss__7.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(23, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chausson Enfant :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(23, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Baudrier Réduit :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(23, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Baudrier Enfant :";
            // 
            // cBox_AdulteChauss__5
            // 
            this.cBox_AdulteChauss__5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteChauss__5.FormattingEnabled = true;
            this.cBox_AdulteChauss__5.Location = new System.Drawing.Point(156, 113);
            this.cBox_AdulteChauss__5.Name = "cBox_AdulteChauss__5";
            this.cBox_AdulteChauss__5.Size = new System.Drawing.Size(38, 21);
            this.cBox_AdulteChauss__5.TabIndex = 36;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.AutoSize = true;
            this.btn_Checkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Checkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Checkout.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Checkout.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btn_Checkout.IconColor = System.Drawing.Color.LightGray;
            this.btn_Checkout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Checkout.IconSize = 40;
            this.btn_Checkout.Location = new System.Drawing.Point(0, 85);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(200, 48);
            this.btn_Checkout.TabIndex = 45;
            this.btn_Checkout.Text = "Passer à la caisse";
            this.btn_Checkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // btn_CancelCheckout
            // 
            this.btn_CancelCheckout.AutoSize = true;
            this.btn_CancelCheckout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CancelCheckout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_CancelCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CancelCheckout.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_CancelCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelCheckout.ForeColor = System.Drawing.Color.LightGray;
            this.btn_CancelCheckout.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            this.btn_CancelCheckout.IconColor = System.Drawing.Color.LightGray;
            this.btn_CancelCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelCheckout.IconSize = 40;
            this.btn_CancelCheckout.Location = new System.Drawing.Point(0, 133);
            this.btn_CancelCheckout.Name = "btn_CancelCheckout";
            this.btn_CancelCheckout.Size = new System.Drawing.Size(200, 48);
            this.btn_CancelCheckout.TabIndex = 46;
            this.btn_CancelCheckout.Text = "Annuler règlement";
            this.btn_CancelCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelCheckout.UseVisualStyleBackColor = true;
            this.btn_CancelCheckout.Visible = false;
            this.btn_CancelCheckout.Click += new System.EventHandler(this.btn_CancelCheckout_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.btn_Checkout);
            this.panel3.Controls.Add(this.btn_CancelCheckout);
            this.panel3.Location = new System.Drawing.Point(587, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 181);
            this.panel3.TabIndex = 47;
            // 
            // FormArdoiseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormArdoiseDetails";
            this.Text = "Ardoise de ... du ...";
            this.Load += new System.EventHandler(this.FormArdoiseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_EnfantEntry__3;
        private System.Windows.Forms.ComboBox cBox_ReduitEntry__2;
        private System.Windows.Forms.ComboBox cBox_AdulteEntry__1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox_EnfantChauss__9;
        private System.Windows.Forms.ComboBox cBox_ReduitChauss__7;
        private System.Windows.Forms.ComboBox cBox_AdulteChauss__5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBox_EnfantBaud__8;
        private System.Windows.Forms.ComboBox cBox_ReduitBaud__6;
        private System.Windows.Forms.ComboBox cBox_AdulteBaud__4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_nbVisite;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_NewClient;
        private System.Windows.Forms.Label lbl_PrixApprox;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_Checkout;
        private FontAwesome.Sharp.IconButton btn_CancelCheckout;
        private System.Windows.Forms.Panel panel3;
    }
}
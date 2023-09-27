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
            this.btn_DeleteArdoise = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_ToClipboard = new System.Windows.Forms.Label();
            this.btn_NewClient = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_PrixEntreeApprox = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_PrixConsoApprox = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpBox_Comment = new System.Windows.Forms.GroupBox();
            this.txtBox_Comment = new System.Windows.Forms.TextBox();
            this.grpBox_Conso = new System.Windows.Forms.GroupBox();
            this.lstView_Conso = new System.Windows.Forms.ListView();
            this.clLibelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Consos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Checkout = new FontAwesome.Sharp.IconButton();
            this.btn_CancelCheckout = new FontAwesome.Sharp.IconButton();
            this.lbl_PrixTotalApprox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nbVisite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBox_Entry = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_AdulteEntry__1 = new System.Windows.Forms.ComboBox();
            this.cBox_EnfantEntry__3 = new System.Windows.Forms.ComboBox();
            this.cBox_ReduitEntry__2 = new System.Windows.Forms.ComboBox();
            this.grpBox_Matos = new System.Windows.Forms.GroupBox();
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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpBox_Comment.SuspendLayout();
            this.grpBox_Conso.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpBox_Entry.SuspendLayout();
            this.grpBox_Matos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_DeleteArdoise);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_ToClipboard);
            this.panel1.Controls.Add(this.btn_NewClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // btn_DeleteArdoise
            // 
            this.btn_DeleteArdoise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_DeleteArdoise.AutoSize = true;
            this.btn_DeleteArdoise.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_DeleteArdoise.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_DeleteArdoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteArdoise.ForeColor = System.Drawing.Color.LightGray;
            this.btn_DeleteArdoise.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_DeleteArdoise.IconColor = System.Drawing.Color.LightGray;
            this.btn_DeleteArdoise.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btn_DeleteArdoise.IconSize = 24;
            this.btn_DeleteArdoise.Location = new System.Drawing.Point(657, 24);
            this.btn_DeleteArdoise.Name = "btn_DeleteArdoise";
            this.btn_DeleteArdoise.Size = new System.Drawing.Size(131, 32);
            this.btn_DeleteArdoise.TabIndex = 56;
            this.btn_DeleteArdoise.Text = "Supprimer l\'ardoise";
            this.btn_DeleteArdoise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteArdoise.UseVisualStyleBackColor = true;
            this.btn_DeleteArdoise.Click += new System.EventHandler(this.btn_DeleteArdoise_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(337, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "(Clique pour copier le nom)";
            // 
            // lbl_ToClipboard
            // 
            this.lbl_ToClipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ToClipboard.AutoSize = true;
            this.lbl_ToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToClipboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_ToClipboard.Location = new System.Drawing.Point(400, 53);
            this.lbl_ToClipboard.Name = "lbl_ToClipboard";
            this.lbl_ToClipboard.Size = new System.Drawing.Size(58, 17);
            this.lbl_ToClipboard.TabIndex = 2;
            this.lbl_ToClipboard.Text = "Copié !";
            this.lbl_ToClipboard.Visible = false;
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
            this.btn_NewClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_NewClient.Location = new System.Drawing.Point(327, 12);
            this.btn_NewClient.Name = "btn_NewClient";
            this.btn_NewClient.Size = new System.Drawing.Size(186, 62);
            this.btn_NewClient.TabIndex = 1;
            this.btn_NewClient.Text = "Nom Prenom";
            this.btn_NewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_NewClient.UseVisualStyleBackColor = true;
            this.btn_NewClient.Click += new System.EventHandler(this.btn_NewClient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lbl_PrixEntreeApprox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_PrixConsoApprox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.grpBox_Comment);
            this.panel2.Controls.Add(this.grpBox_Conso);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_PrixTotalApprox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_nbVisite);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.grpBox_Entry);
            this.panel2.Controls.Add(this.grpBox_Matos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 370);
            this.panel2.TabIndex = 1;
            // 
            // lbl_PrixEntreeApprox
            // 
            this.lbl_PrixEntreeApprox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_PrixEntreeApprox.AutoSize = true;
            this.lbl_PrixEntreeApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixEntreeApprox.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_PrixEntreeApprox.Location = new System.Drawing.Point(251, 334);
            this.lbl_PrixEntreeApprox.Name = "lbl_PrixEntreeApprox";
            this.lbl_PrixEntreeApprox.Size = new System.Drawing.Size(40, 17);
            this.lbl_PrixEntreeApprox.TabIndex = 54;
            this.lbl_PrixEntreeApprox.Text = "9999";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(57, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Coût Entrées (approx.) : ";
            // 
            // lbl_PrixConsoApprox
            // 
            this.lbl_PrixConsoApprox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_PrixConsoApprox.AutoSize = true;
            this.lbl_PrixConsoApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixConsoApprox.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_PrixConsoApprox.Location = new System.Drawing.Point(471, 298);
            this.lbl_PrixConsoApprox.Name = "lbl_PrixConsoApprox";
            this.lbl_PrixConsoApprox.Size = new System.Drawing.Size(40, 17);
            this.lbl_PrixConsoApprox.TabIndex = 52;
            this.lbl_PrixConsoApprox.Text = "9999";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(301, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Coût Consos (approx.) : ";
            // 
            // grpBox_Comment
            // 
            this.grpBox_Comment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpBox_Comment.Controls.Add(this.txtBox_Comment);
            this.grpBox_Comment.ForeColor = System.Drawing.Color.LightGray;
            this.grpBox_Comment.Location = new System.Drawing.Point(590, 5);
            this.grpBox_Comment.Name = "grpBox_Comment";
            this.grpBox_Comment.Size = new System.Drawing.Size(196, 74);
            this.grpBox_Comment.TabIndex = 50;
            this.grpBox_Comment.TabStop = false;
            this.grpBox_Comment.Text = "Raison de la non-fidélisation";
            // 
            // txtBox_Comment
            // 
            this.txtBox_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.txtBox_Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Comment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBox_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Comment.ForeColor = System.Drawing.Color.LightGray;
            this.txtBox_Comment.Location = new System.Drawing.Point(6, 16);
            this.txtBox_Comment.Multiline = true;
            this.txtBox_Comment.Name = "txtBox_Comment";
            this.txtBox_Comment.ReadOnly = true;
            this.txtBox_Comment.Size = new System.Drawing.Size(182, 48);
            this.txtBox_Comment.TabIndex = 0;
            // 
            // grpBox_Conso
            // 
            this.grpBox_Conso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBox_Conso.AutoSize = true;
            this.grpBox_Conso.Controls.Add(this.lstView_Conso);
            this.grpBox_Conso.ForeColor = System.Drawing.Color.LightGray;
            this.grpBox_Conso.Location = new System.Drawing.Point(301, 5);
            this.grpBox_Conso.Name = "grpBox_Conso";
            this.grpBox_Conso.Size = new System.Drawing.Size(268, 290);
            this.grpBox_Conso.TabIndex = 49;
            this.grpBox_Conso.TabStop = false;
            this.grpBox_Conso.Text = "Consommations";
            // 
            // lstView_Conso
            // 
            this.lstView_Conso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.lstView_Conso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clLibelle,
            this.clQuantity});
            this.lstView_Conso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView_Conso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView_Conso.ForeColor = System.Drawing.Color.LightGray;
            this.lstView_Conso.FullRowSelect = true;
            this.lstView_Conso.HideSelection = false;
            this.lstView_Conso.Location = new System.Drawing.Point(3, 16);
            this.lstView_Conso.Name = "lstView_Conso";
            this.lstView_Conso.Size = new System.Drawing.Size(262, 271);
            this.lstView_Conso.TabIndex = 1;
            this.lstView_Conso.UseCompatibleStateImageBehavior = false;
            this.lstView_Conso.View = System.Windows.Forms.View.Details;
            // 
            // clLibelle
            // 
            this.clLibelle.Text = "Libelle";
            this.clLibelle.Width = 160;
            // 
            // clQuantity
            // 
            this.clQuantity.Text = "Quantité";
            this.clQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clQuantity.Width = 80;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.btn_Consos);
            this.panel4.Location = new System.Drawing.Point(587, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 72);
            this.panel4.TabIndex = 48;
            // 
            // btn_Consos
            // 
            this.btn_Consos.AutoSize = true;
            this.btn_Consos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Consos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Consos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Consos.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Consos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Consos.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btn_Consos.IconColor = System.Drawing.Color.LightGray;
            this.btn_Consos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Consos.IconSize = 40;
            this.btn_Consos.Location = new System.Drawing.Point(0, 24);
            this.btn_Consos.Name = "btn_Consos";
            this.btn_Consos.Size = new System.Drawing.Size(199, 48);
            this.btn_Consos.TabIndex = 13;
            this.btn_Consos.Text = "Ajouter / Supprimer des Consos";
            this.btn_Consos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consos.UseVisualStyleBackColor = true;
            this.btn_Consos.Click += new System.EventHandler(this.btn_Consos_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.btn_Checkout);
            this.panel3.Controls.Add(this.btn_CancelCheckout);
            this.panel3.Location = new System.Drawing.Point(587, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 117);
            this.panel3.TabIndex = 47;
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
            this.btn_Checkout.Location = new System.Drawing.Point(0, 21);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(200, 48);
            this.btn_Checkout.TabIndex = 0;
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
            this.btn_CancelCheckout.Location = new System.Drawing.Point(0, 69);
            this.btn_CancelCheckout.Name = "btn_CancelCheckout";
            this.btn_CancelCheckout.Size = new System.Drawing.Size(200, 48);
            this.btn_CancelCheckout.TabIndex = 0;
            this.btn_CancelCheckout.Text = "Annuler règlement";
            this.btn_CancelCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelCheckout.UseVisualStyleBackColor = true;
            this.btn_CancelCheckout.Visible = false;
            this.btn_CancelCheckout.Click += new System.EventHandler(this.btn_CancelCheckout_Click);
            // 
            // lbl_PrixTotalApprox
            // 
            this.lbl_PrixTotalApprox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_PrixTotalApprox.AutoSize = true;
            this.lbl_PrixTotalApprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixTotalApprox.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_PrixTotalApprox.Location = new System.Drawing.Point(531, 344);
            this.lbl_PrixTotalApprox.Name = "lbl_PrixTotalApprox";
            this.lbl_PrixTotalApprox.Size = new System.Drawing.Size(40, 17);
            this.lbl_PrixTotalApprox.TabIndex = 44;
            this.lbl_PrixTotalApprox.Text = "9999";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(361, 344);
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
            this.lbl_nbVisite.Location = new System.Drawing.Point(752, 344);
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
            this.label4.Location = new System.Drawing.Point(593, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nombre de visites : ";
            // 
            // grpBox_Entry
            // 
            this.grpBox_Entry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpBox_Entry.Controls.Add(this.label3);
            this.grpBox_Entry.Controls.Add(this.label1);
            this.grpBox_Entry.Controls.Add(this.label2);
            this.grpBox_Entry.Controls.Add(this.cBox_AdulteEntry__1);
            this.grpBox_Entry.Controls.Add(this.cBox_EnfantEntry__3);
            this.grpBox_Entry.Controls.Add(this.cBox_ReduitEntry__2);
            this.grpBox_Entry.ForeColor = System.Drawing.Color.LightGray;
            this.grpBox_Entry.Location = new System.Drawing.Point(60, 5);
            this.grpBox_Entry.Name = "grpBox_Entry";
            this.grpBox_Entry.Size = new System.Drawing.Size(220, 117);
            this.grpBox_Entry.TabIndex = 40;
            this.grpBox_Entry.TabStop = false;
            this.grpBox_Entry.Text = "Entrée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(27, 80);
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
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrée Réduite :";
            // 
            // cBox_AdulteEntry__1
            // 
            this.cBox_AdulteEntry__1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteEntry__1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteEntry__1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_AdulteEntry__1.FormattingEnabled = true;
            this.cBox_AdulteEntry__1.Location = new System.Drawing.Point(156, 25);
            this.cBox_AdulteEntry__1.Name = "cBox_AdulteEntry__1";
            this.cBox_AdulteEntry__1.Size = new System.Drawing.Size(46, 24);
            this.cBox_AdulteEntry__1.TabIndex = 1;
            this.cBox_AdulteEntry__1.TabStop = false;
            // 
            // cBox_EnfantEntry__3
            // 
            this.cBox_EnfantEntry__3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantEntry__3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantEntry__3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_EnfantEntry__3.FormattingEnabled = true;
            this.cBox_EnfantEntry__3.Location = new System.Drawing.Point(156, 79);
            this.cBox_EnfantEntry__3.Name = "cBox_EnfantEntry__3";
            this.cBox_EnfantEntry__3.Size = new System.Drawing.Size(46, 24);
            this.cBox_EnfantEntry__3.TabIndex = 3;
            // 
            // cBox_ReduitEntry__2
            // 
            this.cBox_ReduitEntry__2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitEntry__2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitEntry__2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_ReduitEntry__2.FormattingEnabled = true;
            this.cBox_ReduitEntry__2.Location = new System.Drawing.Point(156, 52);
            this.cBox_ReduitEntry__2.Name = "cBox_ReduitEntry__2";
            this.cBox_ReduitEntry__2.Size = new System.Drawing.Size(46, 24);
            this.cBox_ReduitEntry__2.TabIndex = 2;
            this.cBox_ReduitEntry__2.TabStop = false;
            // 
            // grpBox_Matos
            // 
            this.grpBox_Matos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpBox_Matos.Controls.Add(this.label10);
            this.grpBox_Matos.Controls.Add(this.cBox_ReduitBaud__6);
            this.grpBox_Matos.Controls.Add(this.cBox_EnfantBaud__8);
            this.grpBox_Matos.Controls.Add(this.cBox_EnfantChauss__9);
            this.grpBox_Matos.Controls.Add(this.cBox_AdulteBaud__4);
            this.grpBox_Matos.Controls.Add(this.label8);
            this.grpBox_Matos.Controls.Add(this.label11);
            this.grpBox_Matos.Controls.Add(this.cBox_ReduitChauss__7);
            this.grpBox_Matos.Controls.Add(this.label9);
            this.grpBox_Matos.Controls.Add(this.label7);
            this.grpBox_Matos.Controls.Add(this.label6);
            this.grpBox_Matos.Controls.Add(this.cBox_AdulteChauss__5);
            this.grpBox_Matos.ForeColor = System.Drawing.Color.LightGray;
            this.grpBox_Matos.Location = new System.Drawing.Point(60, 128);
            this.grpBox_Matos.Name = "grpBox_Matos";
            this.grpBox_Matos.Size = new System.Drawing.Size(220, 203);
            this.grpBox_Matos.TabIndex = 39;
            this.grpBox_Matos.TabStop = false;
            this.grpBox_Matos.Text = "Matériel";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(23, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Chausson Réduit :";
            // 
            // cBox_ReduitBaud__6
            // 
            this.cBox_ReduitBaud__6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitBaud__6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitBaud__6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_ReduitBaud__6.FormattingEnabled = true;
            this.cBox_ReduitBaud__6.Location = new System.Drawing.Point(156, 49);
            this.cBox_ReduitBaud__6.Name = "cBox_ReduitBaud__6";
            this.cBox_ReduitBaud__6.Size = new System.Drawing.Size(46, 24);
            this.cBox_ReduitBaud__6.TabIndex = 5;
            // 
            // cBox_EnfantBaud__8
            // 
            this.cBox_EnfantBaud__8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantBaud__8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantBaud__8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_EnfantBaud__8.FormattingEnabled = true;
            this.cBox_EnfantBaud__8.Location = new System.Drawing.Point(156, 76);
            this.cBox_EnfantBaud__8.Name = "cBox_EnfantBaud__8";
            this.cBox_EnfantBaud__8.Size = new System.Drawing.Size(46, 24);
            this.cBox_EnfantBaud__8.TabIndex = 6;
            // 
            // cBox_EnfantChauss__9
            // 
            this.cBox_EnfantChauss__9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_EnfantChauss__9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnfantChauss__9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_EnfantChauss__9.FormattingEnabled = true;
            this.cBox_EnfantChauss__9.Location = new System.Drawing.Point(156, 168);
            this.cBox_EnfantChauss__9.Name = "cBox_EnfantChauss__9";
            this.cBox_EnfantChauss__9.Size = new System.Drawing.Size(46, 24);
            this.cBox_EnfantChauss__9.TabIndex = 9;
            // 
            // cBox_AdulteBaud__4
            // 
            this.cBox_AdulteBaud__4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteBaud__4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteBaud__4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_AdulteBaud__4.FormattingEnabled = true;
            this.cBox_AdulteBaud__4.Location = new System.Drawing.Point(156, 22);
            this.cBox_AdulteBaud__4.Name = "cBox_AdulteBaud__4";
            this.cBox_AdulteBaud__4.Size = new System.Drawing.Size(46, 24);
            this.cBox_AdulteBaud__4.TabIndex = 4;
            this.cBox_AdulteBaud__4.TabStop = false;
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
            this.label11.Location = new System.Drawing.Point(23, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Chausson Adulte :";
            // 
            // cBox_ReduitChauss__7
            // 
            this.cBox_ReduitChauss__7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_ReduitChauss__7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_ReduitChauss__7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_ReduitChauss__7.FormattingEnabled = true;
            this.cBox_ReduitChauss__7.Location = new System.Drawing.Point(156, 141);
            this.cBox_ReduitChauss__7.Name = "cBox_ReduitChauss__7";
            this.cBox_ReduitChauss__7.Size = new System.Drawing.Size(46, 24);
            this.cBox_ReduitChauss__7.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(23, 169);
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
            this.label7.Location = new System.Drawing.Point(23, 50);
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
            this.label6.Location = new System.Drawing.Point(23, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Baudrier Enfant :";
            // 
            // cBox_AdulteChauss__5
            // 
            this.cBox_AdulteChauss__5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_AdulteChauss__5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_AdulteChauss__5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_AdulteChauss__5.FormattingEnabled = true;
            this.cBox_AdulteChauss__5.Location = new System.Drawing.Point(156, 114);
            this.cBox_AdulteChauss__5.Name = "cBox_AdulteChauss__5";
            this.cBox_AdulteChauss__5.Size = new System.Drawing.Size(46, 24);
            this.cBox_AdulteChauss__5.TabIndex = 7;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ardoise de ... du ...";
            this.Load += new System.EventHandler(this.FormArdoiseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpBox_Comment.ResumeLayout(false);
            this.grpBox_Comment.PerformLayout();
            this.grpBox_Conso.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpBox_Entry.ResumeLayout(false);
            this.grpBox_Entry.PerformLayout();
            this.grpBox_Matos.ResumeLayout(false);
            this.grpBox_Matos.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBox_Matos;
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
        private System.Windows.Forms.GroupBox grpBox_Entry;
        private System.Windows.Forms.Label lbl_nbVisite;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_NewClient;
        private System.Windows.Forms.Label lbl_PrixTotalApprox;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_Checkout;
        private FontAwesome.Sharp.IconButton btn_CancelCheckout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Consos;
        private System.Windows.Forms.GroupBox grpBox_Conso;
        private System.Windows.Forms.GroupBox grpBox_Comment;
        private System.Windows.Forms.TextBox txtBox_Comment;
        private System.Windows.Forms.ListView lstView_Conso;
        private System.Windows.Forms.ColumnHeader clLibelle;
        private System.Windows.Forms.ColumnHeader clQuantity;
        private System.Windows.Forms.Label lbl_PrixEntreeApprox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_PrixConsoApprox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_ToClipboard;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btn_DeleteArdoise;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

namespace CU_ExitPaiment.Forms
{
    partial class FormAllConso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllConso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dessert = new FontAwesome.Sharp.IconButton();
            this.btn_Resto = new FontAwesome.Sharp.IconButton();
            this.btn_Alcool = new FontAwesome.Sharp.IconButton();
            this.btn_Soft = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstView_Consos = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Dessert);
            this.panel1.Controls.Add(this.btn_Resto);
            this.panel1.Controls.Add(this.btn_Alcool);
            this.panel1.Controls.Add(this.btn_Soft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 0;
            // 
            // btn_Dessert
            // 
            this.btn_Dessert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Dessert.AutoSize = true;
            this.btn_Dessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.btn_Dessert.FlatAppearance.BorderSize = 0;
            this.btn_Dessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dessert.ForeColor = System.Drawing.Color.White;
            this.btn_Dessert.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.btn_Dessert.IconColor = System.Drawing.Color.White;
            this.btn_Dessert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Dessert.Location = new System.Drawing.Point(540, 26);
            this.btn_Dessert.Name = "btn_Dessert";
            this.btn_Dessert.Size = new System.Drawing.Size(145, 60);
            this.btn_Dessert.TabIndex = 3;
            this.btn_Dessert.Text = "Dessert";
            this.btn_Dessert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dessert.UseVisualStyleBackColor = false;
            // 
            // btn_Resto
            // 
            this.btn_Resto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Resto.AutoSize = true;
            this.btn_Resto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(159)))), ((int)(((byte)(4)))));
            this.btn_Resto.FlatAppearance.BorderSize = 0;
            this.btn_Resto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Resto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resto.ForeColor = System.Drawing.Color.White;
            this.btn_Resto.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.btn_Resto.IconColor = System.Drawing.Color.White;
            this.btn_Resto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Resto.Location = new System.Drawing.Point(347, 26);
            this.btn_Resto.Name = "btn_Resto";
            this.btn_Resto.Size = new System.Drawing.Size(187, 60);
            this.btn_Resto.TabIndex = 2;
            this.btn_Resto.Text = "Restauration";
            this.btn_Resto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Resto.UseVisualStyleBackColor = false;
            // 
            // btn_Alcool
            // 
            this.btn_Alcool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Alcool.AutoSize = true;
            this.btn_Alcool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Alcool.FlatAppearance.BorderSize = 0;
            this.btn_Alcool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alcool.ForeColor = System.Drawing.Color.White;
            this.btn_Alcool.IconChar = FontAwesome.Sharp.IconChar.MartiniGlassCitrus;
            this.btn_Alcool.IconColor = System.Drawing.Color.White;
            this.btn_Alcool.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alcool.Location = new System.Drawing.Point(219, 26);
            this.btn_Alcool.Name = "btn_Alcool";
            this.btn_Alcool.Size = new System.Drawing.Size(124, 60);
            this.btn_Alcool.TabIndex = 1;
            this.btn_Alcool.Text = "Alcool";
            this.btn_Alcool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alcool.UseVisualStyleBackColor = false;
            // 
            // btn_Soft
            // 
            this.btn_Soft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Soft.AutoSize = true;
            this.btn_Soft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(174)))), ((int)(((byte)(60)))));
            this.btn_Soft.FlatAppearance.BorderSize = 0;
            this.btn_Soft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Soft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soft.ForeColor = System.Drawing.Color.White;
            this.btn_Soft.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
            this.btn_Soft.IconColor = System.Drawing.Color.White;
            this.btn_Soft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Soft.Location = new System.Drawing.Point(103, 26);
            this.btn_Soft.Name = "btn_Soft";
            this.btn_Soft.Size = new System.Drawing.Size(110, 60);
            this.btn_Soft.TabIndex = 0;
            this.btn_Soft.Text = "Soft";
            this.btn_Soft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Soft.UseVisualStyleBackColor = false;
            this.btn_Soft.Click += new System.EventHandler(this.btn_Soft_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lstView_Consos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(800, 341);
            this.panel2.TabIndex = 1;
            // 
            // lstView_Consos
            // 
            this.lstView_Consos.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lstView_Consos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView_Consos.HideSelection = false;
            this.lstView_Consos.Location = new System.Drawing.Point(10, 10);
            this.lstView_Consos.MultiSelect = false;
            this.lstView_Consos.Name = "lstView_Consos";
            this.lstView_Consos.Size = new System.Drawing.Size(780, 321);
            this.lstView_Consos.TabIndex = 0;
            this.lstView_Consos.UseCompatibleStateImageBehavior = false;
            // 
            // FormAllConso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAllConso";
            this.Text = "Consommations";
            this.Load += new System.EventHandler(this.FormAllConso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Soft;
        private FontAwesome.Sharp.IconButton btn_Dessert;
        private FontAwesome.Sharp.IconButton btn_Resto;
        private FontAwesome.Sharp.IconButton btn_Alcool;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstView_Consos;
    }
}
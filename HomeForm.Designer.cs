namespace CU_ExitPaiment
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Sub_Home = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Main_Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Main_Stats = new System.Windows.Forms.Button();
            this.pnl_Sub_Stats = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_Sub_Home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Sub_Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pnl_Sub_Stats);
            this.panel2.Controls.Add(this.btn_Main_Stats);
            this.panel2.Controls.Add(this.pnl_Sub_Home);
            this.panel2.Controls.Add(this.btn_Main_Home);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 838);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnl_Sub_Home
            // 
            this.pnl_Sub_Home.BackColor = System.Drawing.Color.Silver;
            this.pnl_Sub_Home.Controls.Add(this.button5);
            this.pnl_Sub_Home.Controls.Add(this.button4);
            this.pnl_Sub_Home.Controls.Add(this.button3);
            this.pnl_Sub_Home.Controls.Add(this.button2);
            this.pnl_Sub_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Sub_Home.Location = new System.Drawing.Point(0, 322);
            this.pnl_Sub_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Sub_Home.Name = "pnl_Sub_Home";
            this.pnl_Sub_Home.Size = new System.Drawing.Size(287, 190);
            this.pnl_Sub_Home.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 138);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(287, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 92);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Main_Home
            // 
            this.btn_Main_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Main_Home.Location = new System.Drawing.Point(0, 250);
            this.btn_Main_Home.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Main_Home.Name = "btn_Main_Home";
            this.btn_Main_Home.Size = new System.Drawing.Size(287, 72);
            this.btn_Main_Home.TabIndex = 1;
            this.btn_Main_Home.Text = "Main Button";
            this.btn_Main_Home.UseVisualStyleBackColor = true;
            this.btn_Main_Home.Click += new System.EventHandler(this.ShowSub);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 250);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Main_Stats
            // 
            this.btn_Main_Stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Main_Stats.Location = new System.Drawing.Point(0, 512);
            this.btn_Main_Stats.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Main_Stats.Name = "btn_Main_Stats";
            this.btn_Main_Stats.Size = new System.Drawing.Size(287, 72);
            this.btn_Main_Stats.TabIndex = 3;
            this.btn_Main_Stats.Text = "Statistiques";
            this.btn_Main_Stats.UseVisualStyleBackColor = true;
            this.btn_Main_Stats.Click += new System.EventHandler(this.ShowSub);
            // 
            // pnl_Sub_Stats
            // 
            this.pnl_Sub_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_Sub_Stats.Controls.Add(this.button7);
            this.pnl_Sub_Stats.Controls.Add(this.button6);
            this.pnl_Sub_Stats.Controls.Add(this.button1);
            this.pnl_Sub_Stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Sub_Stats.Location = new System.Drawing.Point(0, 584);
            this.pnl_Sub_Stats.Name = "pnl_Sub_Stats";
            this.pnl_Sub_Stats.Size = new System.Drawing.Size(287, 142);
            this.pnl_Sub_Stats.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 46);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(287, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 92);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(287, 46);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CU_ExitPaiment.Properties.Resources.ICO_Cuw;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 726);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(287, 72);
            this.button8.TabIndex = 5;
            this.button8.Text = "Paramètres";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(946, 838);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CUW - Paiement Sortie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.pnl_Sub_Home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Sub_Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Sub_Home;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Main_Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Sub_Stats;
        private System.Windows.Forms.Button btn_Main_Stats;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
    }
}


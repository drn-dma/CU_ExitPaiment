﻿namespace CU_ExitPaiment.Forms
{
    partial class FormHome
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
            this.lbl_TauxFidel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePnl = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackToToday = new System.Windows.Forms.Button();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.csDatePicker1 = new CU_ExitPaiment.Classes.CSDatePicker();
            this.btn_NewCusto = new FontAwesome.Sharp.IconButton();
            this.pnl_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_NewCusto);
            this.pnl_Top.Controls.Add(this.btn_Refresh);
            this.pnl_Top.Controls.Add(this.btnBackToToday);
            this.pnl_Top.Controls.Add(this.lbl_TauxFidel);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Controls.Add(this.csDatePicker1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(854, 79);
            this.pnl_Top.TabIndex = 2;
            // 
            // lbl_TauxFidel
            // 
            this.lbl_TauxFidel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TauxFidel.AutoSize = true;
            this.lbl_TauxFidel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TauxFidel.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_TauxFidel.Location = new System.Drawing.Point(188, 32);
            this.lbl_TauxFidel.Name = "lbl_TauxFidel";
            this.lbl_TauxFidel.Size = new System.Drawing.Size(44, 17);
            this.lbl_TauxFidel.TabIndex = 5;
            this.lbl_TauxFidel.Text = "100%";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taux de Fidélisation : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.panel1.Size = new System.Drawing.Size(854, 672);
            this.panel1.TabIndex = 4;
            // 
            // tablePnl
            // 
            this.tablePnl.AutoScroll = true;
            this.tablePnl.AutoSize = true;
            this.tablePnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePnl.ColumnCount = 3;
            this.tablePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablePnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePnl.Location = new System.Drawing.Point(50, 30);
            this.tablePnl.Name = "tablePnl";
            this.tablePnl.Padding = new System.Windows.Forms.Padding(20);
            this.tablePnl.RowCount = 2;
            this.tablePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePnl.Size = new System.Drawing.Size(754, 43);
            this.tablePnl.TabIndex = 0;
            // 
            // btnBackToToday
            // 
            this.btnBackToToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToToday.BackColor = System.Drawing.Color.Lime;
            this.btnBackToToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToToday.Location = new System.Drawing.Point(481, 29);
            this.btnBackToToday.Name = "btnBackToToday";
            this.btnBackToToday.Size = new System.Drawing.Size(75, 23);
            this.btnBackToToday.TabIndex = 6;
            this.btnBackToToday.Text = "Aujourd\'hui";
            this.btnBackToToday.UseVisualStyleBackColor = false;
            this.btnBackToToday.Click += new System.EventHandler(this.btnBackToToday_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btn_Refresh.IconColor = System.Drawing.Color.LightGray;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.IconSize = 40;
            this.btn_Refresh.Location = new System.Drawing.Point(755, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(65, 65);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Actualiser";
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // csDatePicker1
            // 
            this.csDatePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.csDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.csDatePicker1.BorderSize = 0;
            this.csDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.csDatePicker1.Location = new System.Drawing.Point(289, 21);
            this.csDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.csDatePicker1.Name = "csDatePicker1";
            this.csDatePicker1.Size = new System.Drawing.Size(186, 35);
            this.csDatePicker1.SkinColor = System.Drawing.Color.SandyBrown;
            this.csDatePicker1.TabIndex = 3;
            this.csDatePicker1.TextColor = System.Drawing.Color.White;
            this.csDatePicker1.ValueChanged += new System.EventHandler(this.csDatePicker1_ValueChanged);
            // 
            // btn_NewCusto
            // 
            this.btn_NewCusto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_NewCusto.AutoSize = true;
            this.btn_NewCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewCusto.ForeColor = System.Drawing.Color.LightGray;
            this.btn_NewCusto.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btn_NewCusto.IconColor = System.Drawing.Color.LightGray;
            this.btn_NewCusto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NewCusto.IconSize = 40;
            this.btn_NewCusto.Location = new System.Drawing.Point(657, 8);
            this.btn_NewCusto.Name = "btn_NewCusto";
            this.btn_NewCusto.Size = new System.Drawing.Size(92, 65);
            this.btn_NewCusto.TabIndex = 8;
            this.btn_NewCusto.Text = "Nouveau Client";
            this.btn_NewCusto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_NewCusto.UseVisualStyleBackColor = true;
            this.btn_NewCusto.Click += new System.EventHandler(this.btn_NewCusto_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(854, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Top);
            this.MinimumSize = new System.Drawing.Size(450, 750);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tablePnl;
        private Classes.CSDatePicker csDatePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TauxFidel;
        private System.Windows.Forms.Button btnBackToToday;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_NewCusto;
    }
}
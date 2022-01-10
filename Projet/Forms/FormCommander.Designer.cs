namespace Projet.Forms
{
    partial class FormCommander
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCommander = new System.Windows.Forms.Button();
            this.lbPanier = new System.Windows.Forms.ListBox();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblValide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Commander";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(36, 468);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 23);
            this.lblTotal.TabIndex = 15;
            // 
            // btnCommander
            // 
            this.btnCommander.FlatAppearance.BorderSize = 2;
            this.btnCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommander.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommander.ForeColor = System.Drawing.Color.White;
            this.btnCommander.Location = new System.Drawing.Point(613, 495);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(150, 50);
            this.btnCommander.TabIndex = 1;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // lbPanier
            // 
            this.lbPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPanier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPanier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbPanier.FormattingEnabled = true;
            this.lbPanier.ItemHeight = 23;
            this.lbPanier.Location = new System.Drawing.Point(250, 188);
            this.lbPanier.Name = "lbPanier";
            this.lbPanier.Size = new System.Drawing.Size(268, 207);
            this.lbPanier.TabIndex = 16;
            // 
            // btnMoins
            // 
            this.btnMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoins.ForeColor = System.Drawing.Color.White;
            this.btnMoins.Location = new System.Drawing.Point(351, 433);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(30, 30);
            this.btnMoins.TabIndex = 17;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(397, 433);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.ForeColor = System.Drawing.Color.IndianRed;
            this.lblValide.Location = new System.Drawing.Point(36, 510);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(0, 23);
            this.lblValide.TabIndex = 19;
            // 
            // FormCommander
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.lbPanier);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommander";
            this.Text = "FormCommander";
            this.Load += new System.EventHandler(this.FormCommander_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.ListBox lbPanier;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblValide;
    }
}
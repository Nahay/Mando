namespace Projet.Forms
{
    partial class FormAjouter
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
            this.lblReussite = new System.Windows.Forms.Label();
            this.lblValide = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbArticles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblReussite
            // 
            this.lblReussite.AutoSize = true;
            this.lblReussite.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblReussite.Location = new System.Drawing.Point(495, 441);
            this.lblReussite.Name = "lblReussite";
            this.lblReussite.Size = new System.Drawing.Size(0, 23);
            this.lblReussite.TabIndex = 20;
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.ForeColor = System.Drawing.Color.IndianRed;
            this.lblValide.Location = new System.Drawing.Point(492, 440);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(0, 23);
            this.lblValide.TabIndex = 19;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(493, 362);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 50);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-2, 87);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(806, 39);
            this.lblTitre.TabIndex = 15;
            this.lblTitre.Text = "Ajouter un article";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(499, 232);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(138, 40);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrix
            // 
            this.txtPrix.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(499, 299);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(138, 40);
            this.txtPrix.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Libellé de l\'article ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Prix";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbArticles
            // 
            this.lbArticles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbArticles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbArticles.FormattingEnabled = true;
            this.lbArticles.ItemHeight = 23;
            this.lbArticles.Location = new System.Drawing.Point(49, 208);
            this.lbArticles.Name = "lbArticles";
            this.lbArticles.Size = new System.Drawing.Size(268, 207);
            this.lbArticles.TabIndex = 24;
            // 
            // FormAjouter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.lbArticles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.lblReussite);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouter";
            this.Text = "FormAjouter";
            this.Load += new System.EventHandler(this.FormAjouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReussite;
        private System.Windows.Forms.Label lblValide;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbArticles;
    }
}
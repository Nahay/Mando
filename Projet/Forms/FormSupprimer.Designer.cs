namespace Projet.Forms
{
    partial class FormSupprimer
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbProduits = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblReussite = new System.Windows.Forms.Label();
            this.lblValide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(311, 342);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cbProduits
            // 
            this.cbProduits.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduits.FormattingEnabled = true;
            this.cbProduits.IntegralHeight = false;
            this.cbProduits.ItemHeight = 22;
            this.cbProduits.Location = new System.Drawing.Point(282, 259);
            this.cbProduits.Name = "cbProduits";
            this.cbProduits.Size = new System.Drawing.Size(217, 30);
            this.cbProduits.TabIndex = 1;
            this.cbProduits.Text = "Liste des produits";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(-3, 82);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(807, 39);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "Voici la page pour supprimer un article !";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReussite
            // 
            this.lblReussite.AutoSize = true;
            this.lblReussite.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblReussite.Location = new System.Drawing.Point(278, 422);
            this.lblReussite.Name = "lblReussite";
            this.lblReussite.Size = new System.Drawing.Size(0, 21);
            this.lblReussite.TabIndex = 23;
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.ForeColor = System.Drawing.Color.IndianRed;
            this.lblValide.Location = new System.Drawing.Point(275, 421);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(0, 21);
            this.lblValide.TabIndex = 22;
            // 
            // FormSupprimer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.lblReussite);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbProduits);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupprimer";
            this.Text = "FormSupprimer";
            this.Load += new System.EventHandler(this.FormSupprimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblReussite;
        private System.Windows.Forms.Label lblValide;
        public System.Windows.Forms.ComboBox cbProduits;
    }
}
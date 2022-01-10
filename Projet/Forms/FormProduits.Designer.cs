namespace Projet.Forms
{
    partial class FormProduits
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduits = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtQtt = new System.Windows.Forms.TextBox();
            this.lblValide = new System.Windows.Forms.Label();
            this.lblReussite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des produits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbProduits
            // 
            this.cbProduits.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduits.FormattingEnabled = true;
            this.cbProduits.IntegralHeight = false;
            this.cbProduits.ItemHeight = 30;
            this.cbProduits.Location = new System.Drawing.Point(282, 258);
            this.cbProduits.Name = "cbProduits";
            this.cbProduits.Size = new System.Drawing.Size(213, 38);
            this.cbProduits.TabIndex = 9;
            this.cbProduits.Text = "Liste des produits";
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(361, 319);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(134, 37);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtQtt
            // 
            this.txtQtt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtt.Location = new System.Drawing.Point(282, 319);
            this.txtQtt.Name = "txtQtt";
            this.txtQtt.Size = new System.Drawing.Size(49, 44);
            this.txtQtt.TabIndex = 11;
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.ForeColor = System.Drawing.Color.IndianRed;
            this.lblValide.Location = new System.Drawing.Point(275, 392);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(0, 23);
            this.lblValide.TabIndex = 13;
            // 
            // lblReussite
            // 
            this.lblReussite.AutoSize = true;
            this.lblReussite.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblReussite.Location = new System.Drawing.Point(278, 393);
            this.lblReussite.Name = "lblReussite";
            this.lblReussite.Size = new System.Drawing.Size(0, 23);
            this.lblReussite.TabIndex = 14;
            // 
            // FormProduits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.lblReussite);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.txtQtt);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbProduits);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduits";
            this.Text = "FormProduits";
            this.Load += new System.EventHandler(this.FormProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtQtt;
        private System.Windows.Forms.Label lblValide;
        private System.Windows.Forms.Label lblReussite;
        public System.Windows.Forms.ComboBox cbProduits;
    }
}
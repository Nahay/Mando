using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projet.Forms
{
    public partial class FormAjouter : Form
    {
        public FormAjouter()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrix.Text != "")
            {
                if (!Article.nameExists(txtNom.Text))
                {
                    string nom = txtNom.Text;
                    int prix;

                    if (int.TryParse(txtPrix.Text, out prix)) 
                    {
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO Article (libelle, prixVente) VALUES ('"+nom+"','"+prix+"')", FormMain.cnGC);
                        cmdInsert.ExecuteNonQuery();

                        lblReussite.Text = "L'article " +nom+ " a été ajouté.";
                        lblValide.Text = "";
                        txtNom.Text = "";
                        txtPrix.Text = "";
                        setCb();
                    }
                    else 
                    {
                        lblValide.Text = "Veuillez entrer un prix valide.";
                        lblReussite.Text = "";
                    }
                }
                else 
                {
                    lblValide.Text = "Ce nom existe déjà.";
                    lblReussite.Text = "";
                }
            }
            else
            {
                lblValide.Text = "Veuillez remplir les champs.";
                lblReussite.Text = "";
            }
        }

        private void FormAjouter_Load(object sender, EventArgs e)
        {
            setCb();
        }

        public void setCb()
        {
            Article.getAllProductsWithId();
            lbArticles.Items.Clear();

            foreach (Article a in Article.getAllProducts())
            {
                lbArticles.Items.Add(a.Nom + "          " + a.Prix + "€");
            }
        }
    }
}

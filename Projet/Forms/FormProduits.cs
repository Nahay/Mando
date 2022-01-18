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
    public partial class FormProduits : Form
    {

        public FormProduits()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtQtt.Text != "" && cbProduits.SelectedIndex != -1)
            {
                int nb;

                if (int.TryParse(txtQtt.Text, out nb)) {
                    if (nb > 0)
                    {
                        if (Panier.getPanierByUser(FormMain.currentUser) == null)
                        {
                            Panier.creerPanier(FormMain.currentUser);
                        }

                        string nom = Article.getAllProducts()[cbProduits.SelectedIndex].Nom;
                        Panier.getPanierByUser(FormMain.currentUser).ajouterArticle(nom, nb);
                        
                        lblReussite.Text = nb + " " + nom + " ont été ajoutés au panier !";
                        lblValide.Text = "";
                        txtQtt.Text = "";
                        cbProduits.SelectedIndex = -1;
                        cbProduits.Text = "Liste des produits";
                    }
                    else
                    {
                        lblReussite.Text = "";
                        lblValide.Text = "Veuillez saisir une valeur supérieure à 0.";
                    }
                }
                else 
                {
                    lblReussite.Text = "";
                    lblValide.Text = "Veuillez saisir une quantité valide.";
                }
                
            }
            else
            {
                lblReussite.Text = "";
                lblValide.Text = "Veuillez saisir une quantité valide.";
            }
        }

        private void FormProduits_Load(object sender, EventArgs e)
        {
            Article.getAllProductsWithId();
            cbProduits.Items.Clear();

            foreach (Article a in Article.getAllProducts())
            {
                cbProduits.Items.Add(a.Nom + "          " + a.Prix + "€");
            }
        }
    }
}

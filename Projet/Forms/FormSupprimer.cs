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
    public partial class FormSupprimer : Form
    {
        public FormSupprimer()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (cbProduits.SelectedIndex != -1)
            {
                // vérifie si l'article n'est pas commandé (contrainte de clé étrangère)
                string nom = Article.getAllProducts()[cbProduits.SelectedIndex].Nom;

                SqlCommand cmdCount = new SqlCommand("SELECT count(*) nb FROM LigneCmd JOIN Article ON LigneCmd.idArticle = Article.id WHERE Article.libelle ='"+nom+"'", FormMain.cnGC);

                if ((int)cmdCount.ExecuteScalar() == 0)
                {

                    for (int i = 0; i < Panier.listePaniers.Count; i++)
                    {
                        for (int j = 0; j < Panier.listePaniers[i].contenuPanier.Count; j++)
                        {
                            if (Panier.listePaniers[i].contenuPanier.ElementAt(j).Key.Nom == nom) {
                                Panier.listePaniers[i].contenuPanier.Remove(Panier.listePaniers[i].contenuPanier.ElementAt(j).Key);
                            }
                        }

                        
                        Panier.listePaniers[i].getPanierInfo();

                        
                        Panier.getPanierByUser(FormMain.currentUser).getPanierInfo();
                    }

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Article WHERE libelle ='" + nom + "'", FormMain.cnGC);
                    cmdDelete.ExecuteNonQuery();

                    lblReussite.Text = "L'article " + nom + " a été supprimé.";
                    lblValide.Text = "";
                    cbProduits.SelectedIndex = -1;

                    setCb();
                }
                else
                {
                    lblValide.Text = "Cet article a été commandé, il ne peut pas être supprimé.";
                    lblReussite.Text = "";
                }
            }
            else
            {
                lblValide.Text = "Veuillez sélectionner un article à supprimer.";
                lblReussite.Text = "";
            }
        }

        private void FormSupprimer_Load(object sender, EventArgs e)
        {
            setCb();
        }

        public void setCb()
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

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
    public partial class FormCommander : Form
    {
        public FormCommander()
        {
            InitializeComponent();
        }

        private void FormCommander_Load(object sender, EventArgs e)
        {
            if (Panier.getPanierByUser(Form1.currentUser) != null)
            {
                setLb();
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            if (lbPanier.SelectedIndex > -1)
            {
                string nom = lbPanier.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[0];

                Panier.getPanierByUser(Form1.currentUser).retirerArticle(nom);

                setLb();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lbPanier.SelectedIndex > -1)
            {
                string nom = lbPanier.SelectedItem.ToString().Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[0];

                Panier.getPanierByUser(Form1.currentUser).ajouterArticle(nom,1);
                setLb();
            }
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            if (Panier.getPanierByUser(Form1.currentUser) != null)
            {
                if (Panier.getPanierByUser(Form1.currentUser).contenuPanier.Count > 0)
                {
                    Panier p = Panier.getPanierByUser(Form1.currentUser);

                    DateTime date = DateTime.Now;
                    double total = Panier.getPanierByUser(Form1.currentUser).getPrice();

                    // SELECT SCOPE pour récupérer l'id qui lui sera attribué à l'insert
                    SqlCommand cmdInsertCommand = new SqlCommand("INSERT INTO Commande (dateC, total, idClient) VALUES ('" + date + "', " + total + ", " + Form1.id + "); SELECT SCOPE_IDENTITY()", Form1.cnGC);
                    int id = int.Parse(cmdInsertCommand.ExecuteScalar().ToString());

                    foreach (KeyValuePair<Article, int> kvp in p.contenuPanier)
                    {
                        SqlCommand cmdInsertLigneCmd = new SqlCommand("INSERT INTO LigneCmd (idCommande, idArticle, quantite) VALUES (" + id + ", " + kvp.Key.Id + ", " + kvp.Value + ")", Form1.cnGC);
                        cmdInsertLigneCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Commande effectuée !\nTotal : " + Panier.getPanierByUser(Form1.currentUser).getPrice() + "€");
                    Panier.getPanierByUser(Form1.currentUser).viderPanier();
                    lbPanier.Items.Clear();
                    lblTotal.Text = "Total : 0€";
                    lblValide.Text = "";
                }
                else
                {
                    lblValide.Text = "Vous devez avoir un article dans votre panier pour commander.";
                } 
            }
            else lblValide.Text = "Vous devez avoir un article dans votre panier pour commander.";
        }

        public void setLb()
        {
            Panier p = Panier.getPanierByUser(Form1.currentUser);
            lbPanier.Items.Clear();
            foreach (KeyValuePair<Article, int> kvp in p.contenuPanier)
            {
                lbPanier.Items.Add(kvp.Key.Nom + "   x" + kvp.Value);
            }
            lblTotal.Text = "Total : " + p.getPrice()+ "€";
        }
    }
}

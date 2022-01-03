using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.Forms
{
    internal class Panier
    {
        public static List<Panier> listePaniers = new List<Panier>();
        public Dictionary<Article, int> contenuPanier = new Dictionary<Article, int>();
        private string Username { get; set; }

        public Panier(string username)
        {
            Username = username;
        }

        public static void creerPanier(string username) { listePaniers.Add(new Panier(username)); }

        public static void supprimerPanier(string username) { listePaniers.Remove(listePaniers.Find(x => x.Username == username)); }

        public void ajouterArticle(string nom, int qtt)
        {
            for (int j = 0; j < contenuPanier.Count; j++)
            {
                if (contenuPanier.ElementAt(j).Key.Nom == nom)
                {
                    contenuPanier[contenuPanier.ElementAt(j).Key] += qtt;
                    return;
                }
            }
            contenuPanier.Add(Article.getArticleByName(nom), qtt);
        }

        public void retirerArticle(string nom)
        {
            for (int j = 0; j < contenuPanier.Count; j++)
            {
                if (contenuPanier.ElementAt(j).Key.Nom == nom)
                {
                    if (contenuPanier[contenuPanier.ElementAt(j).Key] == 1)
                    {
                        contenuPanier.Remove(contenuPanier.ElementAt(j).Key);
                    }
                    else
                    {
                        contenuPanier[contenuPanier.ElementAt(j).Key]--;
                    }
                    return;
                }
            }
        }

        public void viderPanier()
        {
            contenuPanier.Clear();
        }

        public void getPanierInfo()
        {
            foreach (KeyValuePair<Article, int> kvp in contenuPanier)
            {
                Console.WriteLine(kvp.Key.Nom + " x" + kvp.Value);
            }
        }

        public static Panier getPanierByUser(string username) { return listePaniers.Find(x => x.Username == username); }

        public double getPrice()
        {
            double price = 0;
            foreach (KeyValuePair<Article, int> kvp in contenuPanier)
            {
                price += kvp.Key.Prix * kvp.Value;
            }
            return price;
        }

        public void acheter()
        {
            double price = getPrice();

            string message = "Le prix Total sera de " + price + " Euros.\nConfirmez-vous l'achat ?";
            string title = "Commander";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show(message, title, buttons);

            if (res == DialogResult.Yes) viderPanier();
        }
    }
}

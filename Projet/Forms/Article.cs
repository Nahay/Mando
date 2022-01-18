using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet.Forms
{
    internal class Article
    {
        private static List<Article> listeArticles = new List<Article>();

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Prix { get; set; }

        public Article(int id, string nom, int prix)
        {
            Id = id;
            Nom = nom;
            Prix = prix;
        }

        public static Boolean nameExists(string nom)
        {
            return listeArticles.Exists(x => x.Nom == nom);
        }

        public static void creerArticle(string nom, int prix)
        {
            if (!nameExists(nom))
            {
                SqlCommand cmdInsertArticle = new SqlCommand("INSERT INTO Article (libelle, prixVente) VALUES ('"+ nom + "','" + prix + "')", FormMain.cnGC);
                cmdInsertArticle.ExecuteNonQuery();
            }
            else MessageBox.Show("Ce produit existe déjà !");
        }

        public static void supprimerArticle(string nom)
        {
            listeArticles.Remove(getArticleByName(nom));
        }

        public static void getAllProductsWithId()
        {
            listeArticles.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM article", FormMain.cnGC);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listeArticles.Add(new Article(dr.GetInt32(0), dr.GetString(1), (int)dr.GetDouble(2)));
                }

                dr.Close();
                dr = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dataReader :" + ex.Message);
            }
        }
        public static List<Article> getAllProducts()
        {
            return listeArticles;
        }

        public static Article getArticleByName(string nom)
        {
            return listeArticles.Find(x => x.Nom == nom);
        }
    }
}

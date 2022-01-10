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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtMdp.Text != "")
            {
                try
                {
                    SqlCommand cmdExists = new SqlCommand("SELECT * FROM Utilisateur WHERE pseudo='" + txtUsername.Text.Trim() + "' AND mdp=HASHBYTES('SHA2_256','" + txtMdp.Text.Trim() + "')", Form1.cnGC);

                    SqlDataReader dr = cmdExists.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Form1.isAdmin = (int)dr["isAdmin"];
                            Form1.id = (int)dr["id"];
                            Form1.name = (string)dr["nom"];
                            Form1.surname = (string)dr["prenom"];
                        }

                        Form1.currentUser = txtUsername.Text;
                        Form1.CurrentForm = new FormAccueil();
                        Form1.setMenu(true);
                    }
                    else lblRemplir.Text = "Nom d'utilisateur ou mot de passe incorrect.";

                    dr.Close();
                    dr = null;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de requête :" + ex.Message);
                }
            }
            else lblRemplir.Text = "Veuillez remplir tous les champs.";
        }
    }
}

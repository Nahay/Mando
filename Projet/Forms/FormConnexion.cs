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
                    SqlCommand cmdExists = new SqlCommand("SELECT * FROM Utilisateur WHERE pseudo='" + txtUsername.Text.Trim() + "' AND mdp=HASHBYTES('SHA2_256','" + txtMdp.Text.Trim() + "')", FormMain.cnGC);

                    SqlDataReader dr = cmdExists.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            FormMain.isAdmin = (int)dr["isAdmin"];
                            FormMain.id = (int)dr["id"];
                            FormMain.name = (string)dr["nom"];
                            FormMain.surname = (string)dr["prenom"];
                        }

                        FormMain.currentUser = txtUsername.Text;
                        FormMain.CurrentForm = new FormAccueil();
                        FormMain.setMenu(true);
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

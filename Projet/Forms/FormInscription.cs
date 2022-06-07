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
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            lblNomPris.Visible = false;
            lblValide.Visible = false;

            if (txtNom.Text != "" && txtPrenom.Text != "" && txtUsername.Text != "" && txtMdp.Text != "")
            {
                try
                {
                    SqlCommand cmdInsertUser = new SqlCommand("INSERT INTO Utilisateur (pseudo, mdp, nom, prenom, isAdmin) VALUES ('"
                        + txtUsername.Text.Trim() + "'," +
                        "HASHBYTES('SHA2_256','" + txtMdp.Text.Trim() + "'),'"
                        + txtNom.Text.Trim() + "','"
                        + txtPrenom.Text.Trim() + "',0)"
                    , FormMain.cnGC);
                    cmdInsertUser.ExecuteNonQuery();
                    FormMain.CurrentForm = new FormConnexion();
                }

                catch (Exception ex)
                {
                    lblNomPris.Visible = true;
                    Console.WriteLine("Erreur de requête :" + ex.Message);
                }
            }
            else lblValide.Visible = true;
        }

        private void FormInscription_Load(object sender, EventArgs e)
        {

        }
    }
}

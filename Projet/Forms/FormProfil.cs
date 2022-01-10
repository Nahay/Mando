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
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            lblNom.Text = "Nom : "+Form1.name;
            lblPrenom.Text = "Prénom : "+Form1.surname;

            try
            {
                SqlCommand cmdExists = new SqlCommand("SELECT * FROM Commande WHERE idClient=" + Form1.id, Form1.cnGC);

                SqlDataReader dr = cmdExists.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbCommande.Items.Add(Convert.ToDateTime(dr["dateC"]).ToString("dd/MM/yyyy hh:mm")+ " "+dr["total"]+"€");
                    }
                }

                dr.Close();
                dr = null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur de requête :" + ex.Message);
            }
        }
    }
}

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

namespace Projet
{
    public partial class Form1 : Form
    {
         public static Form CurrentForm
        {
            get { return _currentForm; }

            set
            {
                _currentForm = value;
                OpenChildForm(_currentForm, panelContent);
            }
        }

        private static Form _currentForm;

        public static string currentUser;
        public static int  isAdmin;

        public static Form activeForm;

        public static SqlConnection cnGC;

        public Form1()
        {
            InitializeComponent();

            try
            {
                cnGC = new SqlConnection("Server=localhost;Integrated security=SSPI;database=Projet");
                cnGC.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : "+ ex.Message);
            }
        }


        // OPEN CHILD FORM --------------------------------------------------------------------------------------

        public static void OpenChildForm(Form childForm, Panel panel)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            switch (childForm.Text)
            {
                case "FormAccueil":
                    btnLeave.Visible = false;
                    lblPanel.Text = "ACCUEIL";
                    break;
                case "FormProduits":
                    btnLeave.Visible = true;
                    lblPanel.Text = "PRODUITS";
                    break;
                case "FormCommander":
                    btnLeave.Visible = true;
                    lblPanel.Text = "COMMANDER";
                    break;
                case "FormAjouter":
                    btnLeave.Visible = true;
                    lblPanel.Text = "AJOUTER ARTICLE";
                    break;
                case "FormSupprimer":
                    btnLeave.Visible = true;
                    lblPanel.Text = "SUPPRIMER ARTICLE";
                    break;
                case "FormConnexion":
                    btnLeave.Visible = false;
                    lblPanel.Text = "CONNEXION";
                    break;
                case "FormInscription":
                    btnLeave.Visible = false;
                    lblPanel.Text = "INSCRIPTION";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            OpenChildForm(new Forms.FormConnexion(), panelContent);
        }

        private void btnMInscription_Click(object sender, EventArgs e)
        {            
            OpenChildForm(new Forms.FormInscription(), panelContent);
        }

        private void btnMConnexion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConnexion(), panelContent);
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccueil(), panelContent);
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduits(), panelContent);
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCommander(), panelContent);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAjouter(), panelContent);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSupprimer(), panelContent);
        }

        private void reset()
        {
            btnLeave.Visible = false;
            lblPanel.Text = "ACCUEIL";
            OpenChildForm(new Forms.FormAccueil(), panelContent);
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            currentUser = "";
            setMenu(false);
            btnLeave.Visible = false;
            lblPanel.Text = "CONNEXION";
            OpenChildForm(new Forms.FormConnexion(), panelContent);
        }

        // ----------------------------------------------------------------------------------------------------------


        private void btnLeave_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            reset();
        }

        public static void setMenu(bool display)
        {
            if (display)
            {
                btnAccueil.Visible = true;
                btnCommander.Visible = true;
                btnProduits.Visible = true;
                btnDeco.Visible = true;

                if (isAdmin == 1)
                {
                    btnAdd.Visible = true;
                    btnRemove.Visible = true;
                }

                btnMConnexion.Visible = false;
                btnMInscription.Visible = false;
            }
            else
            {
                btnAccueil.Visible = false;
                btnCommander.Visible = false;
                btnProduits.Visible = false;
                btnAdd.Visible = false;
                btnRemove.Visible=false;
                btnDeco.Visible = false;
                btnMConnexion.Visible = true;
                btnMInscription.Visible = true;
            }
        }

    }
}

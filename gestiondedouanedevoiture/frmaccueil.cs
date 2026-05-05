using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using gestiondedouanedevoiture.modeles;

namespace gestiondedouanedevoiture
{
    public partial class frmaccueil : Form
    {
        public frmaccueil()
        {
            InitializeComponent();
        }

        private void frmaccueil_Load(object sender, EventArgs e)
        {
            // On vérifie juste que la base de données répond au démarrage
            try
            {
                if (connexion.connected() == null)
                {
                    MessageBox.Show("Attention : Impossible de joindre la base de données.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        // NAVIGATION VERS LES AUTRES FORMULAIRES
        private void btndetailsrecettes_Click(object sender, EventArgs e)
        {
            frmversement frm = new frmversement();
            frm.Show();
        }

        private void btndetailsdeclarations_Click(object sender, EventArgs e)
        {
            // Ouvre ton interface de déclaration de voiture
            frmdeclarationvoiture frm = new frmdeclarationvoiture();
            frm.Show();
        }

        private void btndetailsclients_Click(object sender, EventArgs e)
        {
            // Ouvre l'interface des propriétaires/clients
            frmproprietaire frm = new frmproprietaire();
            frm.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
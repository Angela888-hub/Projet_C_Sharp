using System;
using System.Windows.Forms;

namespace gestiondedouanedevoiture
{
    public partial class frmaccueil : Form
    {
        public frmaccueil()
        {
            InitializeComponent();
        }

        // Chargement des formulaires sur toute la surface
        // 1. Assure-toi que loadform est bien "public"
        public void loadform(Form f)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = this.Controls[i];
                if (ctrl.Name != "pnlMenu") // Garde ton menu de gauche
                {
                    this.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        // 2. Crée cette fonction pour revenir à l'état initial
        public void RetourAccueil()
        {
            // On vide tout pour réafficher le design de base défini dans InitializeComponent
            this.Controls.Clear();
            InitializeComponent();
        }
        // ====================== BOUTONS ======================
        private void btnvoiture_Click(object sender, EventArgs e)
        {
            loadform(new frmdeclarationvoiture());
        }

        private void btnproprietaire_Click(object sender, EventArgs e)
        {
            loadform(new frmproprietaire());
        }

        private void btnpaiement_Click(object sender, EventArgs e)
        {
            loadform(new paiement());
        }

        private void btngenerer_Click(object sender, EventArgs e)
        {
            loadform(new frmquittance());
        }

        private void btnaccueil_Click(object sender, EventArgs e)
        {
            // Recharger le dashboard (à créer plus tard)
            this.Controls.Clear();
            InitializeComponent();   // Recharge le design original
        }

        private void btndetailsrecettes_Click(object sender, EventArgs e)
        {
            loadform(new frmversement());
        }

        private void btndetailsdeclarations_Click(object sender, EventArgs e)
        {
            loadform(new frmdeclarationvoiture());
        }

        private void btndetailsclients_Click(object sender, EventArgs e)
        {
            loadform(new frmproprietaire());
        }
    }
}
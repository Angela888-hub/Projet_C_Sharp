using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using gestiondedouanedevoiture.modeles;

namespace gestiondedouanedevoiture
{
    
    public partial class paiement : Form
    {
        public string IdDeclarationTransmis { get; set; }
        public paiement()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void paiement_Load(object sender, EventArgs e)
        {
            txtIdDeclaration.Text = IdDeclarationTransmis;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. On récupère les vraies valeurs saisies par l'utilisateur
                int idPaiement = 0; // Si auto-increment, tu peux mettre 0
                int idDecl = int.Parse(txtIdDeclaration.Text);
                string montant = txtMontant.Text;
                string date = DateTime.Now.ToString("dd MMMM");
                string mode = comboModePaiement.Text;
                string statut = "Payé";

                // 2. On crée l'objet modèle
                paiement_modeles modèle = new paiement_modeles();

                // 3. On ENVOIE les variables à la méthode ajouter
                // L'ordre doit être le même que dans le fichier paiement_modeles.cs
                modèle.ajouter(idPaiement, idDecl, montant, date, mode, statut);

                MessageBox.Show("Données enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message);
            }
        }
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            // 1. Récupérer la valeur saisie dans l'interface
            double valeur = double.Parse(txtMontant.Text);

            // 2. Appeler le "cerveau" (le modèle)
            TaxeModele modele = new TaxeModele();
            double total = modele.CalculerTotalTaxes(valeur);

            // 3. Afficher le résultat dans un label ou une autre textbox
            txtcalcultotal.Text = total.ToString("N2") + " €";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbltva_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    

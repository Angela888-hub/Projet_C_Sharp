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
    public partial class frmdeclarationvoiture : Form
    {
        public frmdeclarationvoiture()
        {
            InitializeComponent();
        }

        private void frmdeclarationvoiture_Load(object sender, EventArgs e)
        {
            ChargerProprietaires();
            ChargerDeclarations();
        }

        // ====================== CHARGEMENT DES DONNÉES ======================
        private void ChargerProprietaires()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Database=gestiondedouanedevoituredb;"))
                {
                    conn.Open();
                    string query = @"SELECT id_proprietaire, CONCAT(nom, ' ', prenoms) as nom_complet 
                                     FROM proprietaire ORDER BY nom, prenoms";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboModeproprietaire.DataSource = dt;
                    comboModeproprietaire.DisplayMember = "nom_complet";
                    comboModeproprietaire.ValueMember = "id_proprietaire";
                    comboModeproprietaire.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement propriétaires :\n" + ex.Message, "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerDeclarations()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Database=gestiondedouanedevoituredb;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT d.id_declaration, d.numero_repertoire, d.date_declaration,
                               CONCAT(p.nom, ' ', p.prenoms) AS proprietaire,
                               v.marque, v.modele, v.vin_numero_chassis, 
                               v.annee_fabrication, d.statut
                        FROM declaration d
                        JOIN proprietaire p ON d.id_proprietaire = p.id_proprietaire
                        JOIN voiture v ON d.vin_numero_chassis = v.vin_numero_chassis
                        ORDER BY d.date_declaration DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDeclarations.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement :\n" + ex.Message, "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== BOUTON ENREGISTRER ======================
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtvin.Text) ||
                    string.IsNullOrWhiteSpace(txtmarque.Text) ||
                    string.IsNullOrWhiteSpace(txtmodele.Text) ||
                    string.IsNullOrWhiteSpace(txtannee.Text) ||
                    string.IsNullOrWhiteSpace(txtvaleur.Text) ||
                    string.IsNullOrWhiteSpace(txtnumero.Text) ||
                    comboModeproprietaire.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires !", "Attention",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtannee.Text, out int annee))
                {
                    MessageBox.Show("L'année de fabrication doit être un nombre valide.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idNouvelleDeclaration = declaration_modeles.ajouter(txtnumero.Text.Trim(), DateTime.Now);

                if (idNouvelleDeclaration > 0)
                {
                    bool voitureAjoutee = voiture_modeles.ajouter(
                        txtvin.Text.Trim(), txtmarque.Text.Trim(), txtmodele.Text.Trim(),
                        annee, txtvaleur.Text.Trim(),
                        Convert.ToInt32(comboModeproprietaire.SelectedValue),
                        idNouvelleDeclaration);

                    if (voitureAjoutee)
                    {
                        MessageBox.Show("Enregistrement réussi !", "Succès",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChargerDeclarations();
                        ViderChamps();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement de la voiture.", "Erreur",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue :\n" + ex.Message, "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== MÉTHODE VIDER CHAMPS ======================
        private void ViderChamps()
        {
            txtvin.Clear();
            txtmarque.Clear();
            txtmodele.Clear();
            txtannee.Clear();
            txtvaleur.Clear();
            txtnumero.Clear();
            comboModeproprietaire.SelectedIndex = -1;
            txtvin.Focus();
        }

        // ====================== AUTRES ÉVÉNEMENTS (tu peux les supprimer plus tard) ======================
        private void dgvDeclarations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // À compléter plus tard
        }

        private void btnsuivant_Click(object sender, EventArgs e) { }
        private void btnsuivant_Click_1(object sender, EventArgs e) { }
        private void btnenregistrer_Click_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void grpdeclaration_Enter(object sender, EventArgs e)
        {
        }
    }
}
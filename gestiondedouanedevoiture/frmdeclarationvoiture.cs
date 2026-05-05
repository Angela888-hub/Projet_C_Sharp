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
        private void frmdeclarationvoiture_Load(object sender, EventArgs e)
        {
            ChargerProprietaires();
            ChargerDeclarations();
        }
        private void ChargerProprietaires()
        {
            try
            {
                string connectionString = "Server=localhost;User ID=root;Database=gestiondedouanedevoituredb;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT id_proprietaire, 
                                   CONCAT(nom, ' ', prenoms) as nom_complet 
                            FROM proprietaire 
                            ORDER BY nom, prenoms";

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
                MessageBox.Show("Erreur chargement propriétaires :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SELECT 
                    d.id_declaration,
                    d.numero_repertoire,
                    d.date_declaration,
                    CONCAT(p.nom, ' ', p.prenoms) AS proprietaire,
                    v.marque,
                    v.modele,
                    v.vin_numero_chassis,
                    v.annee_fabrication,
                    d.statut
                FROM declaration d
                JOIN proprietaire p ON d.id_proprietaire = p.id_proprietaire
                JOIN voiture v ON d.vin_numero_chassis = v.vin_numero_chassis
                ORDER BY d.date_declaration DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDeclarations.DataSource = dt;   // ← Change si le nom est différent
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement :\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDeclarations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDeclarations.Rows[e.RowIndex];
                // On remplit tes TextBox avec les valeurs de la ligne sélectionnée
                txtvin.Text = row.Cells["vin_numero_chassis"].Value.ToString();
                txtmarque.Text = row.Cells["marque"].Value.ToString();
                txtmodele.Text = row.Cells["modele"].Value.ToString();
                txtannee.Text = row.Cells["annee de fabrication"].Value.ToString();
                txtvaleur.Text = row.Cells["valeur d'achat"].Value.ToString();
                comboModeproprietaire.Text = row.Cells["valeur d'achat"].Value.ToString();
                txtvaleur.Text = row.Cells["valeur d'achat"].Value.ToString();

                // ... etc
            }
        }
        // ====================== BOUTON ENREGISTRER (à compléter) ======================
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                // A. On enregistre d'abord la déclaration pour obtenir son ID
                // On récupère le numéro de répertoire et la date actuelle
                int nouvelIdDecl = declaration_modeles.ajouter(txtnumero.Text, DateTime.Now);

                if (nouvelIdDecl > 0)
                {
                    // B. On récupère les autres infos de l'interface
                    string vin = txtvin.Text;
                    string marque = txtmarque.Text;
                    string modele = txtmodele.Text;
                    int annee = int.Parse(txtannee.Text); // Doit être un nombre
                    string valeur = txtvaleur.Text;
                    int idProp = int.Parse(comboModeproprietaire.SelectedValue.ToString());

                    // C. On appelle la méthode avec les 7 arguments demandés
                    bool voitureOk = voiture_modeles.ajouter(vin, marque, modele, annee, valeur, idProp, nouvelIdDecl);

                    if (voitureOk)
                    {
                        MessageBox.Show("La voiture et sa déclaration ont été enregistrées avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement de la voiture.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création de la déclaration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vérifiez que tous les champs sont bien remplis : " + ex.Message);
            }
        }
        public frmdeclarationvoiture()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblvin_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpdeclaration_Enter(object sender, EventArgs e)
        {

        }

        private void txtmarque_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

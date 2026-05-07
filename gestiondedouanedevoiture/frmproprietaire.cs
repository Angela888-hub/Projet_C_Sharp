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
    public partial class frmproprietaire : Form
    {
        public frmproprietaire()
        {
            InitializeComponent();
        }

        private void ChargerProprietaires()
        {
            // On utilise ta classe centralisée pour éviter les erreurs de frappe
            using (MySqlConnection conn = connexion.connected())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_proprietaire, nom, prenoms, nif_cin, telephone, adresse FROM proprietaire ORDER BY nom";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProprietaires.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des propriétaires : " + ex.Message);
                }
            }
        }

        private void lblgestion_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            // On récupère les textes de tes TextBox
            string nom = txtnom.Text;
            string prenoms = txtprenoms.Text;
            int nif = int.Parse(txtnif.Text);
            string adresse = txtadresse.Text;
            string tel = txttelephone.Text;

            // Appel du modèle que nous venons de compléter
            if (proprietaire_modeles.Ajouter(nom, prenoms, nif, adresse, tel))
            {
                MessageBox.Show("Propriétaire ajouté !");
                ChargerProprietaires(); // Pour rafraîchir ton DataGridView
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtidproprietaire.Text))
            {
                MessageBox.Show("Sélectionnez un propriétaire dans le tableau d'abord.");
                return;
            }

            int id = int.Parse(txtidproprietaire.Text);
            if (proprietaire_modeles.Modifier(id, txtnom.Text, txtprenoms.Text, int.Parse(txtnif.Text), txtadresse.Text, txttelephone.Text))
            {
                MessageBox.Show("Mise à jour réussie !");
                ChargerProprietaires();
            }
        }


        private void btnvider_Click(object sender, EventArgs e)
        {
            txtnom.Clear();
            txtprenoms.Clear();
            txtnif.Clear();
            txttelephone.Clear();
            txtadresse.Clear();
            txtidproprietaire.Clear(); // Même s'il est en ReadOnly, on le vide pour la suite
        }

        private void btnsuivant_Click(object sender, EventArgs e)
        {

            frmdeclarationvoiture frm = new frmdeclarationvoiture();
            frm.Show();
            this.Hide(); // Cache la fenêtre actuelle
        }

        private void dgvProprietaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProprietaires.Rows[e.RowIndex];
                txtidproprietaire.Text = row.Cells["id_proprietaire"].Value.ToString();
                txtnom.Text = row.Cells["nom"].Value.ToString();
                txtprenoms.Text = row.Cells["prenoms"].Value.ToString();
                txtnif.Text = row.Cells["nif_cin"].Value.ToString();
                txttelephone.Text = row.Cells["telephone"].Value.ToString();
                txtadresse.Text = row.Cells["adresse"].Value.ToString();
            }
        }
        private void frmproprietaire_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
            ChargerProprietaires(); // C'est cette ligne qui remplit ton tableau dès l'ouverture
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            
                // On cherche le formulaire parent (frmaccueil) et on appelle sa méthode de retour
                if (this.ParentForm is frmaccueil accueil)
                {
                    accueil.RetourAccueil();
                }

                // On ferme le formulaire actuel pour libérer la mémoire
                this.Close();
        }
    }
}

    
    



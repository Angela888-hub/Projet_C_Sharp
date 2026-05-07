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
    public partial class frmversement : Form
    {
        private void Frmversement_Load(object sender, EventArgs e)
        {
            ChargerVersements();
        }

        private void ChargerVersements()
        {
            try
            {
                // On utilise ta classe de connexion existante au lieu du texte bidon
                MySqlConnection conn = connexion.connected();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = @"
    SELECT p.id_paiement, d.numero_repertoire, 
           p.montant_paye, p.date_paiement, p.mode_paiement, p.statut
    FROM paiement p
    JOIN declaration d ON p.id_declaration = d.id_declaration
    -- On enlève temporairement les autres JOIN pour tester si ça s'affiche
    WHERE DATE(p.date_paiement) = CURDATE() 
    ORDER BY p.date_paiement DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvVersements.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        public frmversement()
        {
            InitializeComponent();
            dgvVersements.Dock = DockStyle.Fill;
            dgvVersements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
    this.AutoScaleMode = AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace gestiondedouanedevoiture.modeles
{
    class paiement_modeles
    {

        public string Id_paiement { get; set; }
        public string Id_declaration { get; set; }
        public string Montant_paye { get; set; }
        public string Date_paiement { get; set; }
        public string Mode_paiement { get; set; }
        public string Statut { get; set; }
        public string Id_taxes { get; set; }
        public string Tva { get; set; }
        public string Montant { get; set; }
        public string Vin_numero_chassis { get; set; }
        // On ajoute des paramètres entre les parenthèses ()
        public void ajouter(int id_p, int id_d, string montant, string date, string mode, string statut)
        {
            MySqlConnection conn = connexion.connected();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                string sql = @"INSERT INTO paiement (id_paiement, id_declaration, montant_paye, date_paiement, mode_paiement, statut) 
                       VALUES (@id_p, @id_d, @montant, @date, @mode, @statut)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Ici, on lie les paramètres SQL aux variables reçues de l'interface
                    cmd.Parameters.AddWithValue("@id_p", id_p);
                    cmd.Parameters.AddWithValue("@id_d", id_d);
                    cmd.Parameters.AddWithValue("@montant", montant);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@mode", mode);
                    cmd.Parameters.AddWithValue("@statut", statut);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex) { Console.WriteLine("Erreur : " + ex.Message); }
            finally { conn.Close(); }
        }


    }
}

public class TaxeModele
{
    // Constantes pour les taux (plus facile à modifier si la loi change)
    private const double TAUX_TVA = 0.20;
    private const double DROIT_DOUANE = 0.10;

    public double CalculerTotalTaxes(double valeurAchat)
    {
        double montantTVA = valeurAchat * TAUX_TVA;
        double montantDroits = valeurAchat * DROIT_DOUANE;

        return montantTVA + montantDroits;
    }
}
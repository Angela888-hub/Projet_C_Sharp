using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace gestiondedouanedevoiture.modeles
{
    public class proprietaire_modeles
    {
        public DataTable ListerProprietaires()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connexion.connected())
            {
                try
                {
                    conn.Open();
                    // On sélectionne les colonnes importantes pour ton projet
                    string sql = "SELECT id_proprietaire, nom, prenom, adresse, telephone FROM proprietaire";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    adapter.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    // Message d'erreur si la table n'existe pas encore ou si le serveur est éteint
                    System.Windows.Forms.MessageBox.Show("Erreur de chargement : " + ex.Message);
                }
            }
            return dt;
        }
        // Ajoute ceci dans ta classe proprietaire_modeles
        public static bool Ajouter(string nom, string prenoms, int nif, string adresse, string tel)
        {
            bool success = false;
            using (MySqlConnection conn = connexion.connected())
            {
                // On utilise les noms de colonnes exacts de ton phpMyAdmin
                string sql = "INSERT INTO proprietaire (nom, prenoms, nif_cin, adresse, telephone) VALUES (@nom, @prenoms, @nif, @adresse, @tel)";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenoms", prenoms);
                    cmd.Parameters.AddWithValue("@nif", nif);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@tel", tel);

                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Erreur : " + ex.Message); }
            }
            return success;
        }
        public static bool Modifier(int id, string nom, string prenoms, int nif, string adresse, string tel)
        {
            bool success = false;
            using (MySqlConnection conn = connexion.connected())
            {
                string sql = "UPDATE proprietaire SET nom=@nom, prenoms=@prenoms, nif_cin=@nif, adresse=@adresse, telephone=@tel WHERE id_proprietaire=@id";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenoms", prenoms);
                    cmd.Parameters.AddWithValue("@nif", nif);
                    cmd.Parameters.AddWithValue("@adresse", adresse);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex) { Console.WriteLine("Erreur modification : " + ex.Message); }
            }
            return success;
        }

        public static bool Supprimer(int id)
        {
            bool success = false;
            using (MySqlConnection conn = connexion.connected())
            {
                string sql = "DELETE FROM proprietaire WHERE id_proprietaire=@id";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception ex) { Console.WriteLine("Erreur suppression : " + ex.Message); }
            }
            return success;
        }
    }
}

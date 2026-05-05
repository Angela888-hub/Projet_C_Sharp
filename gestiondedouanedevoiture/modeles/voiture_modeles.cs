//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;

namespace gestiondedouanedevoiture.modeles
{
    class voiture_modeles
    {
        public static MySqlConnection connected()
        {
            string connectionString = "Server= localhost;user id=root;Database=gestiondedouanedevoituredb";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("connection réussie!");
            }

            catch (MySqlException ex)
            {
                Console.WriteLine($"erreur Mysql : {ex: Message}");
            }


            return conn;
        }

        
            public static bool ajouter(string vin, string marque, string modele, int annee, string valeur, int idProp, int idDecl)
            {
                bool success = false;
                MySqlConnection conn = connexion.connected();
                string sql = "INSERT INTO voiture (vin_numero_chassis, marque, modele, annee_fabrication, valeur_achat, id_proprietaire, id_declaration) " +
                             "VALUES (@vin, @marque, @modele, @annee, @valeur, @idProp, @idDecl)";

                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@vin", vin);
                        cmd.Parameters.AddWithValue("@marque", marque);
                        cmd.Parameters.AddWithValue("@modele", modele);
                        cmd.Parameters.AddWithValue("@annee", annee);
                        cmd.Parameters.AddWithValue("@valeur", valeur);
                        cmd.Parameters.AddWithValue("@idProp", idProp);
                        cmd.Parameters.AddWithValue("@idDecl", idDecl);

                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                }
                catch (Exception ex) { Console.WriteLine("Erreur Voiture: " + ex.Message); }
                return success;
            }
        }
    }
        


    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestiondedouanedevoiture;
using MySql.Data.MySqlClient;
namespace gestiondedouanedevoiture
{
    class declaration_modeles
    {
        public static int ajouter(string numeroRepertoire, DateTime dateDeclaration)
        {
            int lastId = 0;
            MySqlConnection conn = gestiondedouanedevoiture.modeles.connexion.connected();
            // On ne met pas id_declaration car il est auto-increment
            string sql = "INSERT INTO declaration (numero_repertoire, date_declaration) VALUES (@num, @date); SELECT LAST_INSERT_ID();";

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@num", numeroRepertoire);
                    cmd.Parameters.AddWithValue("@date", dateDeclaration);

                    // ExecuteScalar permet de récupérer le LAST_INSERT_ID pour le donner à la voiture après
                    lastId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex) { Console.WriteLine("Erreur Déclaration: " + ex.Message); }
            return lastId;
        }
    }
}


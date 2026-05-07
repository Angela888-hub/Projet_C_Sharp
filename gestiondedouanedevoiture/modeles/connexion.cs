//using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;

namespace gestiondedouanedevoiture.modeles
{
    public class connexion
    {
      public static MySqlConnection connected ()
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
           
                
              
    }
}
*/
using MySql.Data.MySqlClient;
using System;

namespace gestiondedouanedevoiture.modeles
{
    public static class connexion   // ← static c'est mieux
    {
        public static MySqlConnection connected()
        {
            string connectionString = "Server=localhost;User ID=root;Database=gestiondedouanedevoituredb;Convert Zero Datetime=True;AllowZeroDateTime=True";

            MySqlConnection conn = new MySqlConnection(connectionString);

            // On NE PAS ouvre la connexion ici, on la retourne fermée
            // On l'ouvrira seulement quand on en a besoin

            return conn;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using gestiondedouanedevoiture.modeles;

namespace gestiondedouanedevoiture
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            connexion.connected();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /*voiture_modeles obj = new voiture_modeles();
            obj.ajouter();

            */ Application.Run(new frmaccueil());
            /*Console.WriteLine("hello world");
            string connectionString = "Server= localhost;user id=root;Database=gestiondedouanedevoituredb";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
             {
                 try 
                 {
                     conn.Open();
                     Console.WriteLine("connection réussie!");
                 }

                 catch(MySqlException ex) 
                 {
                     Console.WriteLine($"erreur Mysql : {ex: Message}");
                 }
             }*/
            /*{

               
                string sql = "INSERT INTO voiture(vin_numero_chassis,marque,modele,annee_fabrication,valeur_achat,id_proprietaire) VALUES (@vin_numero_chassis,@marque,@modele,@annee_fabrication,@valeur_achat,@id_proprietaire)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@vin_numero_chassis", "1HG CR2 F5 4 H A 042637");
                    cmd.Parameters.AddWithValue("@marque", "Ford");
                    cmd.Parameters.AddWithValue("@modele", "R9999999999999aptor");
                    cmd.Parameters.AddWithValue("@annee_fabrication", 2000);
                    cmd.Parameters.AddWithValue("@valeur_achat", "80M Ar");
                    cmd.Parameters.AddWithValue("@id_proprietaire", 0002);


                    conn.Open();
                    int lignesAffectees = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{lignesAffectees} vehicule(s) ajouté(s)");

                }*/
        ///}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Levesek_KB
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = "localhost";
            db.UserID = "root";
            db.Password = "";
            db.Database = "etelek";
            db.CharacterSet = "utf8";
            connection = new MySqlConnection(db.ConnectionString);
            connection.Open();
            command = connection.CreateCommand();
            connection.Close();
        }

        public List<Leves> Leveslista() 
        {
            List<Leves> llista = new List<Leves>();
            command.CommandText = "SELECT * FROM `levesek`;";

            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    llista.Add(new Leves(dr.GetString("megnevezes"), dr.GetInt32("kaloria"), dr.GetDouble("feherje"), dr.GetDouble("zsir"), dr.GetDouble("szenhidrat"), dr.GetDouble("hamu"), dr.GetDouble("rost")));
                }
            }
            connection.Close();
            return llista;
        }

    }
}

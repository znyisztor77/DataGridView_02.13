using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataGridView_02._13
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        //SELECT  * FROM lakopark NATURAL JOIN epuletek;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();

            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "lakopark";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();

            try
            {
                kapcsolatNyit();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal List<Orszag> orszagAdatokBetoltese()
        {
            List<Orszag> orzsagok = new List<Orszag>();
            sql.CommandText = "SELECT 'orszag', 'fovaros', 'terulte' FROM `orszagok` WHERE 1";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    
                    while (dr.Read())
                    {
                       
                        
                            orzsagok.Add(new Orszag(dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetDouble("terulet")));
                            
                        
                       
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return orzsagok;
        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed) connection.Close();
        }

        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

        }
    }
}


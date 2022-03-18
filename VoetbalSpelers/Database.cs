using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VoetbalSpelers
{
    class Database
    {
        private string connString = string.Format("Server=localhost; database=voetbal_algoritme; UID=root; password=");
        private MySqlConnection connection = null;

        public bool IsConnect()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connString);
                connection.Open();
            }
            return true;
        }
        public List<Player> GetSpelers()
        {
            List<Player> spelersList = new List<Player>();
            if (IsConnect())
            {
                string query = "SELECT * FROM players";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    string position = reader.GetString("position");
                    string teamname = reader.GetString("teamname");
                    Player st = new Player(firstname, lastname, position, teamname);
                    spelersList.Add(st);
                }
                reader.Close();
                Close();
            }
            return spelersList;
        }
        public void AddPlayer(Player player)
        {
            if (IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO players(firstname, lastname, position, teamname) VALUES " +
                    "(@firstname, @lastname, @position, @teamname)",
                    connection);
                cmd.Parameters.AddWithValue("@firstname", player.Firstname);
                cmd.Parameters.AddWithValue("@lastname", player.Lastname);
                cmd.Parameters.AddWithValue("@position", player.Position);
                cmd.Parameters.AddWithValue("@teamname", player.Teamname);
                cmd.Prepare();
                
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                Close();
            }
        }
        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
        }
    }
}

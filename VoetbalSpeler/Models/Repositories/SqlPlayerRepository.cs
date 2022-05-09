//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace VoetbalSpeler.Models
//{
//    public class SqlPlayerRepository
//    {
//        public Database _dbase;
//        public SqlPlayerRepository()
//        {
//            _dbase = new Database();
//        }

//        public List<Player> GetPlayersByTeamId(int id)
//        {
//            List<Player> spelersList = new List<Player>();
//            if (_dbase.IsConnect())
//            {
//                string query = "SELECT * FROM players WHERE teamname=@team_id ";
//                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
//                cmd.Parameters.AddWithValue("@team_id", id);
//                MySqlDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                {
//                    int player_id = reader.GetInt32("id");
//                    string firstname = reader.GetString("firstname");
//                    string lastname = reader.GetString("lastname");
//                    string position = reader.GetString("position");
//                    int team_id = reader.GetInt32("teamname");
//                    Player result = new(player_id, firstname, lastname, position, team_id);
//                    spelersList.Add(result);
//                }
//                reader.Close();
//                _dbase.Close();
//            }
//            return spelersList;
//        }
//    }

//}

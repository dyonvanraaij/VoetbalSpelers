//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace VoetbalSpeler.Models
//{
//    public class SqlTeamRepository
//    {
//        public Database _dbase;
//        public SqlTeamRepository()
//        {
//            _dbase = new Database();
//        }

//        public List<Team> GetTeams()
//        {
//            List<Team> teamsList = new List<Team>();
//            if (_dbase.IsConnect())
//            {
//                string query = "SELECT * FROM teams ";
//                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
//                MySqlDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                {
//                    int team_id = reader.GetInt32("team_id");
//                    string teamname = reader.GetString("teamname");
//                    int coach_id = reader.GetInt32("coach_id");
//                    Team result = new(team_id, teamname, coach_id);
//                    teamsList.Add(result);
//                }
//                reader.Close();
//                _dbase.Close();
//            }
//            return teamsList;
//        }
//    }
//}

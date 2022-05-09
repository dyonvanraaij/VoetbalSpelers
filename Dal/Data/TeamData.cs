using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Dto;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class TeamData
    {
        public Database _dbase;
        public TeamData()
        {
            _dbase = new Database();
        }

        public List<TeamDTO> GetTeams()
        {
            List<TeamDTO> teamsList = new List<TeamDTO>();
            if (_dbase.IsConnect())
            {
                string query = "SELECT * FROM teams ";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int team_id = reader.GetInt32("team_id");
                    string teamname = reader.GetString("teamname");
                    int coach_id = reader.GetInt32("coach_id");
                    TeamDTO result = new(team_id, teamname, coach_id);
                    teamsList.Add(result);
                }
                reader.Close();
                _dbase.Close();
            }
            return teamsList;
        }

        public TeamDTO GetTeamById(int id)
        {
            TeamDTO temp = null;
            if (_dbase.IsConnect())
            {
                string query = "SELECT * FROM teams " +
                    "WHERE team_id=@team_id " +
                    "LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@team_id", id);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int new_id = reader.GetInt32("team_id");
                    string teamname = reader.GetString("teamname");
                    int coach_id = reader.GetInt32("coach_id");
                    temp = new TeamDTO(new_id, teamname, coach_id);
                }
                reader.Close();
                _dbase.Close();
            }
            return temp;
        }

        public void Create(TeamDTO team)
        {
            if (_dbase.IsConnect())
            {
                string query = "INSERT INTO teams(teamname, coach_id) VALUES (@teamname, @coach_id)";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@teamname", team.GetTeamname());
                cmd.Parameters.AddWithValue("@coach_id", team.GetCoachId());
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                _dbase.Close();
            }
        }
    }

}

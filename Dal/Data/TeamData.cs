using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class TeamData : Database, ITeamData
    {       
        public List<TeamDTO> GetTeams()
        {
            List<TeamDTO> teamsList = new List<TeamDTO>();

            if (IsConnect())
            {
                string query = "SELECT * FROM teams ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int team_id = reader.GetInt32("team_id");
                    string teamname = reader.GetString("teamname");
                    int coach_id = reader.GetInt32("coach_id");
                    TeamDTO result = new();

                    result.Id = team_id;
                    result.Teamname = teamname;
                    result.CoachId = coach_id;
                    
                    teamsList.Add(result);

                }
                reader.Close();
                Close();
            }
            return teamsList;
        }

        public TeamDTO GetTeamById(int id)
        {
            TeamDTO result = new();
            if (IsConnect())
            {
                string query = "SELECT * FROM teams " +
                    "WHERE team_id=@team_id " +
                    "LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@team_id", id);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int new_id = reader.GetInt32("team_id");
                    string teamname = reader.GetString("teamname");
                    int coach_id = reader.GetInt32("coach_id");
                    result.Id = new_id;
                    result.Teamname = teamname;
                    result.CoachId = coach_id;
                }
                reader.Close();
                Close();
            }
            return result;
        }

        public TeamDTO GetTeamByPlayerId(int id)
        {
            TeamDTO result = new();
            int teamId = 0;
            if (IsConnect())
            {
                string query = "SELECT teamname FROM players " +
                    "WHERE id=@id " +
                    "LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    teamId = reader.GetInt32("teamname");
                }
                reader.Close();
                Close();
            }

            if (IsConnect())
            {
                string query = "SELECT * FROM teams " +
                    "WHERE team_id=@id " +
                    "LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", teamId);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int new_id = reader.GetInt32("team_id");
                    string teamname = reader.GetString("teamname");
                    int coach_id = reader.GetInt32("coach_id");
                    result.Id = new_id;
                    result.Teamname = teamname;
                    result.CoachId = coach_id;
                }
                reader.Close();
                Close();
            }
            return result;
        }

        public void Create(TeamDTO team)
        {
            if (IsConnect())
            {
                string query = "INSERT INTO teams(teamname, coach_id) VALUES (@teamname, @coach_id)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@teamname", team.Teamname);
                cmd.Parameters.AddWithValue("@coach_id", team.CoachId);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Close();
            }
        }

        public void Edit(TeamDTO team)
        {
            if (IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE teams SET teamname=@teamname, coach_id=@coach_id WHERE team_id=@team_id LIMIT 1",
                    connection);
                cmd.Parameters.AddWithValue("@teamname", team.Teamname);
                cmd.Parameters.AddWithValue("@coach_id", team.CoachId);
                cmd.Parameters.AddWithValue("@team_id", team.Id);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                Close();
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class PlayerData : Database, IPlayerData
    {
        public List<PlayerDTO> GetPlayersByTeamId(int id)
        {
            List<PlayerDTO> spelersList = new List<PlayerDTO>();
            if (IsConnect())
            {
                string query = "SELECT * FROM players WHERE teamname=@team_id ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@team_id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int player_id = reader.GetInt32("id");
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    string position = reader.GetString("position");
                    int team_id = reader.GetInt32("teamname");
                    PlayerDTO result = new();
                    result.Id = player_id;
                    result.Firstname = firstname;
                    result.Lastname = lastname;
                    result.Position = position;
                    result.Teamname = team_id;
                    spelersList.Add(result);
                }
                reader.Close();
                Close();
            }
            return spelersList;
        }

        public PlayerDTO GetPlayerById(int id)
        {
            PlayerDTO player = new();
            if (IsConnect())
            {
                string query = "SELECT * FROM players WHERE id=@player_id LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@player_id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int player_id = reader.GetInt32("id");
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    string position = reader.GetString("position");
                    int team_id = reader.GetInt32("teamname");
                    player.Id = player_id;
                    player.Firstname = firstname;
                    player.Lastname = lastname;
                    player.Position = position;
                    player.Teamname = team_id;
                }
                reader.Close();
                Close();
            }
            return player;
        }

        public PlayerDTO CreatePlayer(PlayerDTO player)
        {
            PlayerDTO temp = null;
            if (IsConnect())
            {
                string query = "INSERT INTO players(firstname, lastname, position, teamname) VALUES (@firstname, @lastname, @position, @teamname)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@firstname", player.Firstname);
                cmd.Parameters.AddWithValue("@lastname", player.Lastname);
                cmd.Parameters.AddWithValue("@position", player.Position);
                cmd.Parameters.AddWithValue("@teamname", player.Teamname);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Close();
            }
            return temp;
        }
    }
}

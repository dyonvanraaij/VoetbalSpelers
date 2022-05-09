using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Dto;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class PlayerData
    {
        public Database _dbase;
        public PlayerData()
        {
            _dbase = new Database();
        }
        public List<PlayerDTO> GetPlayersByTeamId(int id)
        {
            List<PlayerDTO> spelersList = new List<PlayerDTO>();
            if (_dbase.IsConnect())
            {
                string query = "SELECT * FROM players WHERE teamname=@team_id ";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@team_id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int player_id = reader.GetInt32("id");
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    string position = reader.GetString("position");
                    int team_id = reader.GetInt32("teamname");
                    PlayerDTO result = new(player_id, firstname, lastname, position, team_id);
                    spelersList.Add(result);
                }
                reader.Close();
                _dbase.Close();
            }
            return spelersList;
        }

        public PlayerDTO GetPlayerById(int id)
        {
            PlayerDTO player = null;
            if (_dbase.IsConnect())
            {
                string query = "SELECT * FROM players WHERE id=@player_id LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@player_id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int player_id = reader.GetInt32("id");
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    string position = reader.GetString("position");
                    int team_id = reader.GetInt32("teamname");
                    player = new PlayerDTO(player_id, firstname, lastname, position, team_id);
                }
                reader.Close();
                _dbase.Close();
            }
            return player;
        }

        public PlayerDTO CreatePlayer(PlayerDTO player)
        {
            PlayerDTO temp = null;
            if (_dbase.IsConnect())
            {
                string query = "INSERT INTO players(firstname, lastname, position, teamname) VALUES (@firstname, @lastname, @position, @teamname)";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@firstname", player.GetFirstname());
                cmd.Parameters.AddWithValue("@lastname", player.GetLastname());
                cmd.Parameters.AddWithValue("@position", player.GetPosition());
                cmd.Parameters.AddWithValue("@teamname", player.GetTeamname());
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                _dbase.Close();
            }
            return temp;
        }
    }
}

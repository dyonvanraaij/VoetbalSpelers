using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class StatsData : Database, IStatsData
    {
      
        public StatsDTO GetStatsByPlayerId(int player_id)
        {
            StatsDTO st = null;
            if (IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM player_stats Where player_id=@player_id LIMIT 1",
                    connection);
                cmd.Parameters.AddWithValue("@player_id", player_id);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int goals_scored = reader.GetInt32("goals_scored");
                    int assists = reader.GetInt32("assists_given");
                    bool injury = bool.Parse(reader.GetString("injury"));
                    int keeper_clean_sheet = reader.GetInt32("keeper_clean_sheet");
                    int yellow_carts = reader.GetInt32("yellow_carts");
                    int red_carts = reader.GetInt32("red_carts");
                    int penalties_held = reader.GetInt32("penalties_held");
                    int penalties_created_defence = reader.GetInt32("penalties_created_defence");
                    int training_commitment = reader.GetInt32("training_commitment");
                    int caused_offside = reader.GetInt32("caused_offside");
                    st = new StatsDTO(player_id, goals_scored, assists, injury, keeper_clean_sheet, yellow_carts, red_carts, penalties_held,
                        penalties_created_defence, training_commitment, caused_offside);
                }
                reader.Close();
                Close();
            }
            return st;
        }

        public StatsDTO AddStats(StatsDTO stats)
        {
            if (IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO player_stats(player_id, injury, yellow_carts, red_carts, training_commitment, " +
                    "goals_scored, assists_given, caused_offside, keeper_clean_sheet, penalties_created_defence, penalties_held) VALUES " +
                    "(@player_id, @injury, @yellow, @red, @training, @goals, @assists, @caused, @keeper_clean, @penal_created, @penal_held)",
                    connection);
                cmd.Parameters.AddWithValue("@player_id", stats.GetPlayerId());
                cmd.Parameters.AddWithValue("@injury", stats.GetInjury());
                cmd.Parameters.AddWithValue("@yellow", stats.GetYellow());
                cmd.Parameters.AddWithValue("@red", stats.GetRed());
                cmd.Parameters.AddWithValue("@training", stats.GetTraining());
                cmd.Parameters.AddWithValue("@goals", stats.GetGoals());
                cmd.Parameters.AddWithValue("@assists", stats.GetAssists());
                cmd.Parameters.AddWithValue("@caused", stats.GetCaused());
                cmd.Parameters.AddWithValue("@keeper_clean", stats.GetKeeperClean());
                cmd.Parameters.AddWithValue("@penal_created", stats.GetPenalCreated());
                cmd.Parameters.AddWithValue("@penal_held", stats.GetPenalHeld());
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                Close();
            }
            return stats;
        }

        public StatsDTO UpdateStats(StatsDTO stats)
        {
            if (IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE player_stats SET injury=@injury, yellow_carts=@yellow, red_carts=@red, training_commitment=@training, " +
                    "goals_scored=@goals, assists_given=@assists, caused_offside=@caused, keeper_clean_sheet=@keeper_clean, " +
                    "penalties_created_defence=@penal_created, penalties_held=@penal_held WHERE player_id=@player_id LIMIT 1",
                    connection);
                cmd.Parameters.AddWithValue("@player_id", stats.GetPlayerId());
                cmd.Parameters.AddWithValue("@injury", stats.GetInjury());
                cmd.Parameters.AddWithValue("@yellow", stats.GetYellow());
                cmd.Parameters.AddWithValue("@red", stats.GetRed());
                cmd.Parameters.AddWithValue("@training", stats.GetTraining());
                cmd.Parameters.AddWithValue("@goals", stats.GetGoals());
                cmd.Parameters.AddWithValue("@assists", stats.GetAssists());
                cmd.Parameters.AddWithValue("@caused", stats.GetCaused());
                cmd.Parameters.AddWithValue("@keeper_clean", stats.GetKeeperClean());
                cmd.Parameters.AddWithValue("@penal_created", stats.GetPenalCreated());
                cmd.Parameters.AddWithValue("@penal_held", stats.GetPenalHeld());
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                Close();
            }
            return stats;
        }
    }
}

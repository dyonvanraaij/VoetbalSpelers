using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Dal
{
    // XUNIT gebruiken
    public class Database
    {
        public string connString = string.Format("Server=localhost; database=voetbal_algoritme; UID=root; password=");
        public MySqlConnection connection = null;

        public bool IsConnect()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connString);
                connection.Open();
            }
            return true;
        }
        //public List<Team> GetTeams()
        //{
        //    List<Team> teamsList = new List<Team>();
        //    if (IsConnect())
        //    {
        //        string query = "SELECT * FROM teams ";
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int team_id = reader.GetInt32("team_id");
        //            string teamname = reader.GetString("teamname");
        //            int coach_id = reader.GetInt32("coach_id");
        //            Team result = new Team(team_id, teamname, coach_id);
        //            teamsList.Add(result);
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return teamsList;
        //}

        //public Team GetTeamByName(string teamname)
        //{
        //    Team temp = null;
        //    if (IsConnect())
        //    {
        //        string query = "SELECT * FROM teams " +
        //            "WHERE teamname=@teamname " +
        //            "LIMIT 1";
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@teamname", teamname);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            int id = reader.GetInt32("team_id");
        //            int coach_id = reader.GetInt32("coach_id");
        //            temp = new Team(id, teamname, coach_id);
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return temp;
        //}
        //public List<Player> GetSpelers()
        //{
        //    List<Player> spelersList = new List<Player>();
        //    if (IsConnect())
        //    {
        //        string query = "SELECT * FROM players";
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int id = reader.GetInt32("id");
        //            string firstname = reader.GetString("firstname");
        //            string lastname = reader.GetString("lastname");
        //            string position = reader.GetString("position");
        //            string teamname = reader.GetString("teamname");
        //            Player st = new Player(id, firstname, lastname, position, teamname);
        //            spelersList.Add(st);
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return spelersList;
        //}
        //public Player GetPlayerFromNameAndPosition(string firstname, string lastname, string position)
        //{
        //    Player st = null;
        //    if (IsConnect())
        //    {
        //        string query = "SELECT * FROM players " +
        //            "WHERE firstname=@firstname " +
        //            "AND lastname=@lastname " +
        //            "AND position=@position " +
        //            "LIMIT 1";
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@firstname", firstname);
        //        cmd.Parameters.AddWithValue("@lastname", lastname);
        //        cmd.Parameters.AddWithValue("@position", position);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            int id = reader.GetInt32("id");
        //            string teamname = reader.GetString("teamname");
        //            st = new Player(id, firstname, lastname, position, teamname);
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return st;
        //}
        //public void AddPlayer(string firstname, string lastname, string position, string teamname)
        //{
        //    if (IsConnect())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(
        //            "INSERT INTO players(firstname, lastname, position, teamname) VALUES " +
        //            "(@firstname, @lastname, @position, @teamname)",
        //            connection);
        //        cmd.Parameters.AddWithValue("@firstname", firstname);
        //        cmd.Parameters.AddWithValue("@lastname", lastname);
        //        cmd.Parameters.AddWithValue("@position", position);
        //        cmd.Parameters.AddWithValue("@teamname", teamname);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        reader.Close();
        //        Close();
        //    }
        //}
        //public void AddStats(Stats stats)
        //{
        //    if (IsConnect())
        //    {
        //        int injuryCheck = InjuryToInt(stats.Injury);
        //        MySqlCommand cmd = new MySqlCommand(
        //            "INSERT INTO player_stats(player_id, injury, yellow_carts, red_carts, training_commitment, " +
        //            "goals_scored, assists_given, caused_offside, keeper_clean_sheet, penalties_created_defence, penalties_held) VALUES " +
        //            "(@player_id, @injury, @yellow, @red, @training, @goals, @assists, @caused, @keeper_clean, @penal_created, @penal_held)",
        //            connection);
        //        cmd.Parameters.AddWithValue("@player_id", stats.Player_id);
        //        cmd.Parameters.AddWithValue("@injury", injuryCheck);
        //        cmd.Parameters.AddWithValue("@yellow", stats.Yellow);
        //        cmd.Parameters.AddWithValue("@red", stats.Red);
        //        cmd.Parameters.AddWithValue("@training", stats.Training);
        //        cmd.Parameters.AddWithValue("@goals", stats.Goals);
        //        cmd.Parameters.AddWithValue("@assists", stats.Assists);
        //        cmd.Parameters.AddWithValue("@caused", stats.Caused);
        //        cmd.Parameters.AddWithValue("@keeper_clean", stats.Keeper_clean);
        //        cmd.Parameters.AddWithValue("@penal_created", stats.Penal_created);
        //        cmd.Parameters.AddWithValue("@penal_held", stats.Penal_held);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        reader.Close();
        //        Close();
        //    }
        //}

        //public void UpdateStats(Stats stats)
        //{
        //    Stats statsByPlayerId = StatsByPlayerId(stats.Player_id);
        //    if (IsConnect())
        //    {
        //        int injuryCheck = InjuryToInt(stats.Injury);
        //        int goals_scored = statsByPlayerId.Goals + stats.Goals;
        //        int assists_given = statsByPlayerId.Assists + stats.Assists;
        //        int keeper_clean = statsByPlayerId.Keeper_clean + stats.Keeper_clean;
        //        int yellow = statsByPlayerId.Yellow + stats.Yellow;
        //        int red = statsByPlayerId.Red + stats.Red;
        //        int penal_held = statsByPlayerId.Penal_held + stats.Penal_held;
        //        int penal_created = statsByPlayerId.Penal_created + stats.Penal_created;
        //        int caused_offside = statsByPlayerId.Caused + stats.Caused;

        //        Stats updated = new Stats(stats.Player_id, goals_scored, assists_given, stats.Injury, keeper_clean, yellow, red, penal_held,
        //            penal_created, stats.Training, caused_offside);

        //        MySqlCommand cmd = new MySqlCommand(
        //            "UPDATE player_stats SET injury=@injury, yellow_carts=@yellow, red_carts=@red, training_commitment=@training, " +
        //            "goals_scored=@goals, assists_given=@assists, caused_offside=@caused, keeper_clean_sheet=@keeper_clean, " +
        //            "penalties_created_defence=@penal_created, penalties_held=@penal_held WHERE player_id=@player_id LIMIT 1",
        //            connection);
        //        cmd.Parameters.AddWithValue("@player_id", updated.Player_id);
        //        cmd.Parameters.AddWithValue("@injury", injuryCheck);
        //        cmd.Parameters.AddWithValue("@yellow", updated.Yellow);
        //        cmd.Parameters.AddWithValue("@red", updated.Red);
        //        cmd.Parameters.AddWithValue("@training", updated.Training);
        //        cmd.Parameters.AddWithValue("@goals", updated.Goals);
        //        cmd.Parameters.AddWithValue("@assists", updated.Assists);
        //        cmd.Parameters.AddWithValue("@caused", updated.Caused);
        //        cmd.Parameters.AddWithValue("@keeper_clean", updated.Keeper_clean);
        //        cmd.Parameters.AddWithValue("@penal_created", updated.Penal_created);
        //        cmd.Parameters.AddWithValue("@penal_held", updated.Penal_held);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        reader.Close();
        //        Close();
        //    }
        //}
        //public Stats StatsByPlayerId(int player_id)
        //{
        //    Stats st = null;
        //    if (IsConnect())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(
        //            "SELECT * FROM player_stats Where player_id=@player_id LIMIT 1",
        //            connection);
        //        cmd.Parameters.AddWithValue("@player_id", player_id);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            int goals_scored = reader.GetInt32("goals_scored");
        //            int assists = reader.GetInt32("assists_given");
        //            bool injury = bool.Parse(reader.GetString("injury"));
        //            int keeper_clean_sheet = reader.GetInt32("keeper_clean_sheet");
        //            int yellow_carts = reader.GetInt32("yellow_carts");
        //            int red_carts = reader.GetInt32("red_carts");
        //            int penalties_held = reader.GetInt32("penalties_held");
        //            int penalties_created_defence = reader.GetInt32("penalties_created_defence");
        //            int training_commitment = reader.GetInt32("training_commitment");
        //            int caused_offside = reader.GetInt32("caused_offside");
        //            st = new Stats(player_id, goals_scored, assists, injury, keeper_clean_sheet, yellow_carts, red_carts, penalties_held,
        //                penalties_created_defence, training_commitment, caused_offside);
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return st;
        //}
        //public bool DoesStatsExistsById(int player_id)
        //{
        //    if (IsConnect())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(
        //            "SELECT * FROM player_stats WHERE player_id=@player_id LIMIT 1",
        //            connection);
        //        cmd.Parameters.AddWithValue("@player_id", player_id);
        //        cmd.Prepare();

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (reader.HasRows == true)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        reader.Close();
        //        Close();
        //    }
        //    return false;
        //}
        //static int InjuryToInt(bool injury)
        //{
        //    int injuryCheck = 0;
        //    if (injury)
        //    {
        //        injuryCheck = 1;
        //    }
        //    return injuryCheck;
        //}
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

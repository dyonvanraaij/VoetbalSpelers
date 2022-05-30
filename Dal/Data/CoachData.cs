using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoachData : Database, ICoachData
    {
        public void CreateCoach(CoachDTO coach)
        {
            if (IsConnect())
            {
                string query = "INSERT INTO coach(firstname, lastname) VALUES (@firstname, @lastname)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@firstname", coach.GetFirstname());
                cmd.Parameters.AddWithValue("@lastname", coach.GetLastname());

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Close();
            }
        }
        public List<CoachDTO> GetCoaches()
        {
            List<CoachDTO> coachList = new List<CoachDTO>();
            if (IsConnect())
            {
                string query = "SELECT * FROM coach ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int coach_id = reader.GetInt32("coach_id");
                    string firstname = reader.GetString("firstname");
                    string lastname = reader.GetString("lastname");
                    CoachDTO result = new(coach_id, firstname, lastname);
                    coachList.Add(result);
                }
                reader.Close();
                Close();
            }
            return coachList;
        }
    }
}

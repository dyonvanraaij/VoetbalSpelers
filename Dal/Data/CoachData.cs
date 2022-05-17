using Dal.Dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Data
{
    public class CoachData : Database
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
    }
}

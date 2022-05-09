using Dal.Dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Data
{
    public class CoachData
    {
        public Database _dbase;
        public CoachData()
        {
            _dbase = new Database();
        }

        public void CreateCoach(CoachDTO coach)
        {
            if (_dbase.IsConnect())
            {
                string query = "INSERT INTO coach(firstname, lastname) VALUES (@firstname, @lastname)";
                MySqlCommand cmd = new MySqlCommand(query, _dbase.connection);
                cmd.Parameters.AddWithValue("@firstname", coach.GetFirstname());
                cmd.Parameters.AddWithValue("@lastname", coach.GetLastname());

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                _dbase.Close();
            }
        }
    }
}

using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Dal
{
    // XUNIT gebruiken
    public class Database
    {
        private string _connString = string.Format("Server=localhost; database=voetbal_algoritme; UID=root; password=");
        public MySqlConnection connection = null;

        public bool IsConnect()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(_connString);
                connection.Open();
            }
            return true;
        }
        
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

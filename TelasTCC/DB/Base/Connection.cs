using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasTCC.DB.Base
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=restaurante;uid=root;password=vertrigo";

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            return connection;
        }
    }
}

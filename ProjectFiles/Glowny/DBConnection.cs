using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInżynierska.Glowny
{
    class DBConnection
    {
        string server;
        string database;
        string uid;
        string pwd;
        string connectionString;
        public MySqlConnection connection;
        public DBConnection()
        {
            server = "localhost";
            database = "zm_praca";
            uid = "root";
            pwd = "";
            connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + pwd + ";";
            //connectionString = "SERVER=localhost;DATABASE=zm_praca;UID=root;PASSWORD=;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
    }
}

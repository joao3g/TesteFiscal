using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Fiscal.Model
{
    internal class Database
    {
        public static Database _instance;
        public NpgsqlConnection connection;

        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Fiscal";
        private static string Password = "root";
        private static string Port = "5432";

        public static Database Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Database();
                    _instance.connect();
                }

                return _instance;
            }
        }

        public void connect()
        {

            string connString =
                    string.Format(
                        "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                        Host,
                        User,
                        DBname,
                        Port,
                        Password);

            this.connection = new NpgsqlConnection(connString);
            this.connection.Open();
        }
    }
}

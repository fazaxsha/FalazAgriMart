using Npgsql;
using System;

namespace FalazAgriMart.Database
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance = null;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private DatabaseConnection()
        {
            // Connection string untuk Neon PostgreSQL
            _connectionString = "Host=ep-square-frost-a1m3k7e4-pooler.ap-southeast-1.aws.neon.tech;" +
                                "Username=neondb_owner;" +
                                "Password=npg_YVmdng4T1awI;" +
                                "Database=FalazAgriMart;" +
                                "Ssl Mode=Require;" +
                                "Trust Server Certificate=true;";
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnection();
                        }
                    }
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error testing connection: {ex.Message}");
                return false;
            }
        }
    }
}

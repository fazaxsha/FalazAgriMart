using Npgsql;
using System;

namespace FalazAgriMart.Database
{
    /// <summary>
    /// Singleton class untuk mengelola koneksi database PostgreSQL (Neon)
    /// Memastikan hanya ada 1 instance koneksi di seluruh aplikasi
    /// </summary>
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance = null;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        // Private constructor agar tidak bisa di-instantiate dari luar
        private DatabaseConnection()
        {
            // Connection string untuk Neon PostgreSQL
            // Data telah disesuaikan dengan URI yang Anda berikan
            _connectionString = "Host=ep-square-frost-a1m3k7e4-pooler.ap-southeast-1.aws.neon.tech;" +
                                "Username=neondb_owner;" +
                                "Password=npg_YVmdng4T1awI;" +
                                "Database=FalazAgriMart;" +
                                "Ssl Mode=Require;" +
                                "Trust Server Certificate=true;";
        }

        /// <summary>
        /// Mendapatkan instance tunggal dari DatabaseConnection (Singleton)
        /// </summary>
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

        /// <summary>
        /// Membuat koneksi baru ke database
        /// </summary>
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        /// <summary>
        /// Test koneksi database
        /// </summary>
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

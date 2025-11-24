// ============================================
// File: Program.cs
// Entry Point Aplikasi FALAZ AgriMart
// ============================================

using FalazAgriMart.Forms.Auth;
using FalazAgriMart.Database;
using System;
using System.Windows.Forms;

namespace FalazAgriMart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test koneksi database dulu sebelum login
            if (TestDatabaseConnection())
            {
                // Jika koneksi berhasil, buka form login
                Application.Run(new FormLogin());
            }
            else
            {
                // Jika koneksi gagal, tampilkan error dan tutup aplikasi
                MessageBox.Show(
                    "Tidak dapat terhubung ke database!\n\n" +
                    "Pastikan:\n" +
                    "1. Connection string di DatabaseConnection.cs sudah benar\n" +
                    "2. Database Neon sudah aktif\n" +
                    "3. Koneksi internet stabil\n" +
                    "4. Tabel sudah dibuat (jalankan query.txt)",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Test koneksi ke database
        /// </summary>
        private static bool TestDatabaseConnection()
        {
            try
            {
                bool isConnected = DatabaseConnection.Instance.TestConnection();

                if (isConnected)
                {
                    Console.WriteLine("✅ Database connection successful!");
                    return true;
                }
                else
                {
                    Console.WriteLine("❌ Database connection failed!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Database connection error: {ex.Message}");
                MessageBox.Show(
                    $"Error detail:\n{ex.Message}\n\n{ex.StackTrace}",
                    "Connection Error Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
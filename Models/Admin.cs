using System;

namespace FalazAgriMart.Models
{
    /// <summary>
    /// Class Admin mewarisi dari User - INHERITANCE
    /// Memiliki hak akses penuh untuk manajemen sistem
    /// </summary>
    public class Admin : User
    {
        // Constructor
        public Admin() : base() { }

        public Admin(int userId, string username, string password, string namaLengkap, bool status)
            : base(userId, username, password, namaLengkap, "Admin", status)
        {
        }

        // Implementasi abstract method - POLYMORPHISM (Method Overriding)
        public override void TampilkanInfo()
        {
            Console.WriteLine("=== INFO ADMIN ===");
            Console.WriteLine($"User ID: {UserId}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Nama: {NamaLengkap}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Status: {(Status ? "Aktif" : "Nonaktif")}");
        }

        // Override virtual method - POLYMORPHISM
        public override string GetDashboardTitle()
        {
            return $"Dashboard Administrator - {NamaLengkap}";
        }

        // Method khusus Admin
        public bool KelolaProduk(string aksi)
        {
            Console.WriteLine($"Admin melakukan aksi: {aksi} pada produk");
            return true;
        }

        public bool KelolaPegawai(string aksi)
        {
            Console.WriteLine($"Admin melakukan aksi: {aksi} pada pegawai");
            return true;
        }

        public bool KelolaSupplier(string aksi)
        {
            Console.WriteLine($"Admin melakukan aksi: {aksi} pada supplier");
            return true;
        }

        public bool KelolaKategori(string aksi)
        {
            Console.WriteLine($"Admin melakukan aksi: {aksi} pada kategori");
            return true;
        }

        public void LihatLaporanKeuangan()
        {
            Console.WriteLine("Admin mengakses laporan keuangan");
        }
    }
}

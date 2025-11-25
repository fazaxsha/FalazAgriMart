using System;

namespace FalazAgriMart.Models
{
    /// Class Pegawai mewarisi dari User - INHERITANCE
    /// Fokus pada operasional kasir dan transaksi
    public class Pegawai : User
    {
        // Constructor
        public Pegawai() : base() { }

        public Pegawai(int userId, string username, string password, string namaLengkap, bool status)
            : base(userId, username, password, namaLengkap, "Pegawai", status)
        {
        }

        // Implementasi abstract method - POLYMORPHISM (Method Overriding)
        public override void TampilkanInfo()
        {
            Console.WriteLine("=== INFO PEGAWAI ===");
            Console.WriteLine($"User ID: {UserId}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Nama: {NamaLengkap}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Status: {(Status ? "Aktif" : "Nonaktif")}");
        }

        // Override virtual method - POLYMORPHISM
        public override string GetDashboardTitle()
        {
            return $"Dashboard Kasir - {NamaLengkap}";
        }

        // Method khusus Pegawai
        public void InputNamaPelanggan(string namaPelanggan)
        {
            Console.WriteLine($"Pegawai menginput nama pelanggan: {namaPelanggan}");
        }

        public bool CekStok(int produkId)
        {
            Console.WriteLine($"Pegawai mengecek stok produk ID: {produkId}");
            return true;
        }

        public void LihatRiwayatPribadi()
        {
            Console.WriteLine($"Pegawai {NamaLengkap} melihat riwayat transaksi pribadi");
        }

        public void MelakukanPenjualan()
        {
            Console.WriteLine($"Pegawai {NamaLengkap} melakukan transaksi penjualan");
        }
    }
}
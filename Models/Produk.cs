using System;

namespace FalazAgriMart.Models
{
    /// Class Produk dengan ENCAPSULATION
    public class Produk
    {
        // Private fields
        private int _produkId;
        private string _namaProduk;
        private string _kategori;
        private string _satuan;
        private decimal _harga;
        private int _stok;
        private int? _supplierId;

        // Properties
        public int ProdukId
        {
            get { return _produkId; }
            set { _produkId = value; }
        }

        public string NamaProduk
        {
            get { return _namaProduk; }
            set { _namaProduk = value; }
        }

        public string Kategori
        {
            get { return _kategori; }
            set { _kategori = value; }
        }

        public string Satuan
        {
            get { return _satuan; }
            set { _satuan = value; }
        }

        public decimal Harga
        {
            get { return _harga; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga tidak boleh negatif");
                _harga = value;
            }
        }

        public int Stok
        {
            get { return _stok; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok tidak boleh negatif");
                _stok = value;
            }
        }

        public int? SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        // Constructor
        public Produk() { }

        public Produk(int produkId, string namaProduk, string kategori, string satuan, decimal harga, int stok, int? supplierId)
        {
            _produkId = produkId;
            _namaProduk = namaProduk;
            _kategori = kategori;
            _satuan = satuan;
            _harga = harga;
            _stok = stok;
            _supplierId = supplierId;
        }

        // Method untuk update stok
        public bool UpdateStok(int quantity)
        {
            if (_stok - quantity < 0)
            {
                throw new InvalidOperationException("Stok tidak mencukupi");
            }

            _stok -= quantity;

            // Smart Stock Alert Logic
            if (_stok <= 10)
            {
                Console.WriteLine($"⚠️ ALERT: Stok {_namaProduk} tinggal {_stok} {_satuan}!");
                return false; // Stok menipis
            }

            return true; // Stok aman
        }

        // Method untuk tambah stok (restock)
        public void TambahStok(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("Quantity harus positif");

            _stok += quantity;
        }

        // Method untuk validasi stok tersedia
        public bool IsStokTersedia(int quantity)
        {
            return _stok >= quantity;
        }
    }
}
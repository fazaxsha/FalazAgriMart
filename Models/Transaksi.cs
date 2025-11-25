using System;

namespace FalazAgriMart.Models
{
    /// Model Transaksi (Header)
    public class Transaksi
    {
        private int _transaksiId;
        private string _noTransaksi;
        private DateTime _tanggalTransaksi;
        private string _namaPelanggan;
        private decimal _totalBayar;
        private decimal _jumlahBayar;
        private decimal _kembalian;
        private int _userId;
        private string _catatan;

        public int TransaksiId
        {
            get { return _transaksiId; }
            set { _transaksiId = value; }
        }

        public string NoTransaksi
        {
            get { return _noTransaksi; }
            set { _noTransaksi = value; }
        }

        public DateTime TanggalTransaksi
        {
            get { return _tanggalTransaksi; }
            set { _tanggalTransaksi = value; }
        }

        public string NamaPelanggan
        {
            get { return _namaPelanggan; }
            set { _namaPelanggan = value; }
        }

        public decimal TotalBayar
        {
            get { return _totalBayar; }
            set { _totalBayar = value; }
        }

        public decimal JumlahBayar
        {
            get { return _jumlahBayar; }
            set { _jumlahBayar = value; }
        }

        public decimal Kembalian
        {
            get { return _kembalian; }
            set { _kembalian = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Catatan
        {
            get { return _catatan; }
            set { _catatan = value; }
        }

        public Transaksi()
        {
            _tanggalTransaksi = DateTime.Now;
        }

        public Transaksi(string noTransaksi, string namaPelanggan, decimal totalBayar,
                        decimal jumlahBayar, decimal kembalian, int userId)
        {
            _noTransaksi = noTransaksi;
            _tanggalTransaksi = DateTime.Now;
            _namaPelanggan = namaPelanggan;
            _totalBayar = totalBayar;
            _jumlahBayar = jumlahBayar;
            _kembalian = kembalian;
            _userId = userId;
        }
    }
}

using System;

namespace FalazAgriMart.Models
{
    /// Model DetailTransaksi (Item dalam transaksi)
    public class DetailTransaksi
    {
        private int _detailId;
        private int _transaksiId;
        private int _produkId;
        private string _namaProduk;
        private decimal _hargaSatuan;
        private int _quantity;
        private decimal _subtotal;

        public int DetailId
        {
            get { return _detailId; }
            set { _detailId = value; }
        }

        public int TransaksiId
        {
            get { return _transaksiId; }
            set { _transaksiId = value; }
        }

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

        public decimal HargaSatuan
        {
            get { return _hargaSatuan; }
            set { _hargaSatuan = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity harus lebih dari 0");
                _quantity = value;
                HitungSubtotal();
            }
        }

        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public DetailTransaksi() { }

        public DetailTransaksi(int produkId, string namaProduk, decimal hargaSatuan, int quantity)
        {
            _produkId = produkId;
            _namaProduk = namaProduk;
            _hargaSatuan = hargaSatuan;
            _quantity = quantity;
            HitungSubtotal();
        }

        private void HitungSubtotal()
        {
            _subtotal = _hargaSatuan * _quantity;
        }
    }
}
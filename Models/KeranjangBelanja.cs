using System;
using System.Collections.Generic;
using System.Linq;

namespace FalazAgriMart.Models
{
    /// Helper class untuk keranjang belanja temporary
    /// Data di memory, belum disimpan ke database
    public class KeranjangBelanja
    {
        private List<DetailTransaksi> _items;

        public List<DetailTransaksi> Items
        {
            get { return _items; }
        }

        public KeranjangBelanja()
        {
            _items = new List<DetailTransaksi>();
        }

        /// Tambah produk ke keranjang
        /// Jika produk sudah ada, tambah quantity
        public void TambahItem(int produkId, string namaProduk, decimal hargaSatuan, int quantity, int stokTersedia)
        {
            // Cek apakah produk sudah ada di keranjang
            var existingItem = _items.FirstOrDefault(i => i.ProdukId == produkId);

            if (existingItem != null)
            {
                // Produk sudah ada, tambah quantity
                int newQuantity = existingItem.Quantity + quantity;

                // Validasi stok
                if (newQuantity > stokTersedia)
                {
                    throw new InvalidOperationException(
                        $"Stok tidak mencukupi! Stok tersedia: {stokTersedia}, " +
                        $"sudah di keranjang: {existingItem.Quantity}"
                    );
                }

                existingItem.Quantity = newQuantity;
            }
            else
            {
                // Produk baru, tambah ke keranjang
                if (quantity > stokTersedia)
                {
                    throw new InvalidOperationException($"Stok tidak mencukupi! Stok tersedia: {stokTersedia}");
                }

                var newItem = new DetailTransaksi(produkId, namaProduk, hargaSatuan, quantity);
                _items.Add(newItem);
            }
        }

        /// Update quantity item di keranjang
        public void UpdateQuantity(int produkId, int newQuantity, int stokTersedia)
        {
            var item = _items.FirstOrDefault(i => i.ProdukId == produkId);

            if (item == null)
                throw new InvalidOperationException("Produk tidak ditemukan di keranjang");

            if (newQuantity <= 0)
            {
                // Hapus dari keranjang jika quantity 0 atau negatif
                _items.Remove(item);
            }
            else
            {
                // Validasi stok
                if (newQuantity > stokTersedia)
                {
                    throw new InvalidOperationException($"Stok tidak mencukupi! Stok tersedia: {stokTersedia}");
                }

                item.Quantity = newQuantity;
            }
        }

        /// Hapus item dari keranjang
        public void HapusItem(int produkId)
        {
            var item = _items.FirstOrDefault(i => i.ProdukId == produkId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        /// Hitung total belanja
        public decimal GetTotalBelanja()
        {
            return _items.Sum(i => i.Subtotal);
        }

        /// Get jumlah item di keranjang
        public int GetJumlahItem()
        {
            return _items.Count;
        }

        /// Get total quantity semua item
        public int GetTotalQuantity()
        {
            return _items.Sum(i => i.Quantity);
        }

        /// Kosongkan keranjang
        public void Clear()
        {
            _items.Clear();
        }

        /// Cek apakah keranjang kosong
        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        /// Get item by produk ID
        public DetailTransaksi GetItemByProdukId(int produkId)
        {
            return _items.FirstOrDefault(i => i.ProdukId == produkId);
        }
    }
}
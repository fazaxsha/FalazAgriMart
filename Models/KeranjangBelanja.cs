using System;
using System.Collections.Generic;
using System.Linq;

namespace FalazAgriMart.Models
{
    /// <summary>
    /// Helper class untuk keranjang belanja temporary
    /// Data di memory, belum disimpan ke database
    /// </summary>
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

        /// <summary>
        /// Tambah produk ke keranjang
        /// Jika produk sudah ada, tambah quantity
        /// </summary>
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

        /// <summary>
        /// Update quantity item di keranjang
        /// </summary>
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

        /// <summary>
        /// Hapus item dari keranjang
        /// </summary>
        public void HapusItem(int produkId)
        {
            var item = _items.FirstOrDefault(i => i.ProdukId == produkId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        /// <summary>
        /// Hitung total belanja
        /// </summary>
        public decimal GetTotalBelanja()
        {
            return _items.Sum(i => i.Subtotal);
        }

        /// <summary>
        /// Get jumlah item di keranjang
        /// </summary>
        public int GetJumlahItem()
        {
            return _items.Count;
        }

        /// <summary>
        /// Get total quantity semua item
        /// </summary>
        public int GetTotalQuantity()
        {
            return _items.Sum(i => i.Quantity);
        }

        /// <summary>
        /// Kosongkan keranjang
        /// </summary>
        public void Clear()
        {
            _items.Clear();
        }

        /// <summary>
        /// Cek apakah keranjang kosong
        /// </summary>
        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        /// <summary>
        /// Get item by produk ID
        /// </summary>
        public DetailTransaksi GetItemByProdukId(int produkId)
        {
            return _items.FirstOrDefault(i => i.ProdukId == produkId);
        }
    }
}
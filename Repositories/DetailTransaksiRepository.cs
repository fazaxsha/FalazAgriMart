using FalazAgriMart.Database;
using FalazAgriMart.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace FalazAgriMart.Repositories
{
    /// <summary>
    /// Repository untuk operasi CRUD Detail Transaksi
    /// </summary>
    public class DetailTransaksiRepository
    {
        /// <summary>
        /// Insert detail transaksi (single item)
        /// Biasanya dipanggil dari TransaksiRepository dalam satu transaction
        /// </summary>
        public bool Insert(DetailTransaksi detail, NpgsqlConnection connection = null, NpgsqlTransaction transaction = null)
        {
            bool shouldCloseConnection = false;

            try
            {
                // Jika tidak ada koneksi dari luar, buat koneksi baru
                if (connection == null)
                {
                    connection = DatabaseConnection.Instance.GetConnection();
                    connection.Open();
                    shouldCloseConnection = true;
                }

                string query = @"
                    INSERT INTO detail_transaksi 
                        (transaksi_id, produk_id, nama_produk, harga_satuan, quantity, subtotal)
                    VALUES 
                        (@transaksi_id, @produk_id, @nama_produk, @harga_satuan, @quantity, @subtotal)
                ";

                using (var command = new NpgsqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@transaksi_id", detail.TransaksiId);
                    command.Parameters.AddWithValue("@produk_id", detail.ProdukId);
                    command.Parameters.AddWithValue("@nama_produk", detail.NamaProduk);
                    command.Parameters.AddWithValue("@harga_satuan", detail.HargaSatuan);
                    command.Parameters.AddWithValue("@quantity", detail.Quantity);
                    command.Parameters.AddWithValue("@subtotal", detail.Subtotal);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting detail transaksi: {ex.Message}", ex);
            }
            finally
            {
                if (shouldCloseConnection)
                {
                    connection?.Close();
                }
            }
        }

        /// <summary>
        /// Get detail transaksi by detail_id
        /// </summary>
        public DetailTransaksi GetById(int detailId)
        {
            try
            {
                string query = @"
                    SELECT 
                        detail_id,
                        transaksi_id,
                        produk_id,
                        nama_produk,
                        harga_satuan,
                        quantity,
                        subtotal
                    FROM detail_transaksi
                    WHERE detail_id = @detailId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@detailId", detailId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DetailTransaksi
                    {
                        DetailId = Convert.ToInt32(row["detail_id"]),
                        TransaksiId = Convert.ToInt32(row["transaksi_id"]),
                        ProdukId = Convert.ToInt32(row["produk_id"]),
                        NamaProduk = row["nama_produk"].ToString(),
                        HargaSatuan = Convert.ToDecimal(row["harga_satuan"]),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"])
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting detail by ID: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Get semua detail transaksi berdasarkan transaksi_id
        /// </summary>
        public List<DetailTransaksi> GetByTransaksiId(int transaksiId)
        {
            try
            {
                string query = @"
                    SELECT 
                        detail_id,
                        transaksi_id,
                        produk_id,
                        nama_produk,
                        harga_satuan,
                        quantity,
                        subtotal
                    FROM detail_transaksi
                    WHERE transaksi_id = @transaksiId
                    ORDER BY detail_id ASC
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksiId", transaksiId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                List<DetailTransaksi> detailList = new List<DetailTransaksi>();

                foreach (DataRow row in dt.Rows)
                {
                    detailList.Add(new DetailTransaksi
                    {
                        DetailId = Convert.ToInt32(row["detail_id"]),
                        TransaksiId = Convert.ToInt32(row["transaksi_id"]),
                        ProdukId = Convert.ToInt32(row["produk_id"]),
                        NamaProduk = row["nama_produk"].ToString(),
                        HargaSatuan = Convert.ToDecimal(row["harga_satuan"]),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"])
                    });
                }

                return detailList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting detail by transaksi ID: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Get semua detail transaksi (untuk laporan)
        /// </summary>
        public DataTable GetAll()
        {
            try
            {
                string query = @"
                    SELECT 
                        dt.detail_id,
                        dt.transaksi_id,
                        t.no_transaksi,
                        dt.produk_id,
                        dt.nama_produk,
                        dt.harga_satuan,
                        dt.quantity,
                        dt.subtotal,
                        t.tanggal_transaksi
                    FROM detail_transaksi dt
                    JOIN transaksi t ON dt.transaksi_id = t.transaksi_id
                    ORDER BY t.tanggal_transaksi DESC, dt.detail_id ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all detail transaksi: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Update detail transaksi (untuk koreksi jika diperlukan)
        /// PERHATIAN: Jarang digunakan karena transaksi biasanya immutable
        /// </summary>
        public bool Update(DetailTransaksi detail)
        {
            try
            {
                string query = @"
                    UPDATE detail_transaksi 
                    SET 
                        produk_id = @produk_id,
                        nama_produk = @nama_produk,
                        harga_satuan = @harga_satuan,
                        quantity = @quantity,
                        subtotal = @subtotal
                    WHERE detail_id = @detail_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@produk_id", detail.ProdukId),
                    new NpgsqlParameter("@nama_produk", detail.NamaProduk),
                    new NpgsqlParameter("@harga_satuan", detail.HargaSatuan),
                    new NpgsqlParameter("@quantity", detail.Quantity),
                    new NpgsqlParameter("@subtotal", detail.Subtotal),
                    new NpgsqlParameter("@detail_id", detail.DetailId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating detail transaksi: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Delete single detail transaksi by detail_id
        /// </summary>
        public bool Delete(int detailId)
        {
            try
            {
                string query = @"
                    DELETE FROM detail_transaksi 
                    WHERE detail_id = @detail_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@detail_id", detailId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting detail transaksi: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Delete semua detail transaksi berdasarkan transaksi_id
        /// Biasanya digunakan saat hapus transaksi (cascade delete)
        /// </summary>
        public bool DeleteByTransaksiId(int transaksiId)
        {
            try
            {
                string query = @"
                    DELETE FROM detail_transaksi 
                    WHERE transaksi_id = @transaksi_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksi_id", transaksiId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting detail by transaksi ID: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Hitung total item dalam satu transaksi
        /// </summary>
        public int GetTotalItems(int transaksiId)
        {
            try
            {
                string query = @"
                    SELECT COALESCE(SUM(quantity), 0) 
                    FROM detail_transaksi 
                    WHERE transaksi_id = @transaksiId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksiId", transaksiId)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting total items: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Hitung total subtotal (untuk verifikasi dengan total_bayar di transaksi)
        /// </summary>
        public decimal GetTotalSubtotal(int transaksiId)
        {
            try
            {
                string query = @"
                    SELECT COALESCE(SUM(subtotal), 0) 
                    FROM detail_transaksi 
                    WHERE transaksi_id = @transaksiId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksiId", transaksiId)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting total subtotal: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Get produk terlaris berdasarkan quantity yang terjual
        /// </summary>
        public DataTable GetProdukTerlaris(DateTime? tanggalMulai = null, DateTime? tanggalAkhir = null, int limit = 10)
        {
            try
            {
                string query = @"
                    SELECT 
                        dt.produk_id,
                        dt.nama_produk,
                        SUM(dt.quantity) as total_terjual,
                        SUM(dt.subtotal) as total_pendapatan,
                        COUNT(DISTINCT dt.transaksi_id) as jumlah_transaksi
                    FROM detail_transaksi dt
                    JOIN transaksi t ON dt.transaksi_id = t.transaksi_id
                    WHERE 1=1
                ";

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

                if (tanggalMulai.HasValue)
                {
                    query += " AND DATE(t.tanggal_transaksi) >= @tanggalMulai";
                    parameters.Add(new NpgsqlParameter("@tanggalMulai", tanggalMulai.Value.Date));
                }

                if (tanggalAkhir.HasValue)
                {
                    query += " AND DATE(t.tanggal_transaksi) <= @tanggalAkhir";
                    parameters.Add(new NpgsqlParameter("@tanggalAkhir", tanggalAkhir.Value.Date));
                }

                query += @"
                    GROUP BY dt.produk_id, dt.nama_produk
                    ORDER BY total_terjual DESC
                    LIMIT @limit
                ";

                parameters.Add(new NpgsqlParameter("@limit", limit));

                return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting produk terlaris: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Get laporan penjualan per produk (untuk analisis)
        /// </summary>
        public DataTable GetLaporanPenjualanPerProduk(DateTime? tanggalMulai = null, DateTime? tanggalAkhir = null)
        {
            try
            {
                string query = @"
                    SELECT 
                        dt.produk_id,
                        dt.nama_produk,
                        SUM(dt.quantity) as total_terjual,
                        SUM(dt.subtotal) as total_pendapatan,
                        COUNT(DISTINCT dt.transaksi_id) as jumlah_transaksi,
                        AVG(dt.harga_satuan) as rata_rata_harga,
                        MIN(t.tanggal_transaksi) as tanggal_pertama,
                        MAX(t.tanggal_transaksi) as tanggal_terakhir
                    FROM detail_transaksi dt
                    JOIN transaksi t ON dt.transaksi_id = t.transaksi_id
                    WHERE 1=1
                ";

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

                if (tanggalMulai.HasValue)
                {
                    query += " AND DATE(t.tanggal_transaksi) >= @tanggalMulai";
                    parameters.Add(new NpgsqlParameter("@tanggalMulai", tanggalMulai.Value.Date));
                }

                if (tanggalAkhir.HasValue)
                {
                    query += " AND DATE(t.tanggal_transaksi) <= @tanggalAkhir";
                    parameters.Add(new NpgsqlParameter("@tanggalAkhir", tanggalAkhir.Value.Date));
                }

                query += @"
                    GROUP BY dt.produk_id, dt.nama_produk
                    ORDER BY total_pendapatan DESC
                ";

                return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting laporan penjualan per produk: {ex.Message}", ex);
            }
        }
    }
}
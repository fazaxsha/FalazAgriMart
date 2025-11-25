using FalazAgriMart.Database;
using FalazAgriMart.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace FalazAgriMart.Repositories
{
    /// Repository untuk operasi transaksi
    public class TransaksiRepository
    {
        /// Generate nomor transaksi otomatis
        public string GenerateNoTransaksi()
        {
            try
            {
                string tanggal = DateTime.Now.ToString("yyyyMMdd");
                string prefix = $"TRX-{tanggal}-";

                // Ambil nomor terakhir hari ini
                string query = @"
                    SELECT no_transaksi 
                    FROM transaksi 
                    WHERE no_transaksi LIKE @prefix || '%'
                    ORDER BY no_transaksi DESC 
                    LIMIT 1
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@prefix", prefix)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                int nomorUrut = 1;
                if (dt.Rows.Count > 0)
                {
                    string lastNo = dt.Rows[0]["no_transaksi"].ToString();
                    // Extract nomor urut (4 digit terakhir)
                    string lastNumber = lastNo.Substring(lastNo.Length - 4);
                    nomorUrut = int.Parse(lastNumber) + 1;
                }

                return prefix + nomorUrut.ToString("D4");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating no transaksi: {ex.Message}", ex);
            }
        }

        /// Simpan transaksi lengkap (header + detail)
        /// Return: transaksi_id jika sukses
        public int SimpanTransaksi(Transaksi transaksi, List<DetailTransaksi> detailList)
        {
            NpgsqlConnection connection = null;
            NpgsqlTransaction transaction = null;

            try
            {
                connection = DatabaseConnection.Instance.GetConnection();
                connection.Open();

                // Mulai transaction
                transaction = connection.BeginTransaction();

                // 1. Insert header transaksi
                string queryHeader = @"
                    INSERT INTO transaksi 
                        (no_transaksi, tanggal_transaksi, nama_pelanggan, total_bayar, 
                         jumlah_bayar, kembalian, user_id, catatan)
                    VALUES 
                        (@no_transaksi, @tanggal_transaksi, @nama_pelanggan, @total_bayar,
                         @jumlah_bayar, @kembalian, @user_id, @catatan)
                    RETURNING transaksi_id
                ";

                NpgsqlParameter[] parametersHeader = {
                    new NpgsqlParameter("@no_transaksi", transaksi.NoTransaksi),
                    new NpgsqlParameter("@tanggal_transaksi", transaksi.TanggalTransaksi),
                    new NpgsqlParameter("@nama_pelanggan", transaksi.NamaPelanggan ?? (object)DBNull.Value),
                    new NpgsqlParameter("@total_bayar", transaksi.TotalBayar),
                    new NpgsqlParameter("@jumlah_bayar", transaksi.JumlahBayar),
                    new NpgsqlParameter("@kembalian", transaksi.Kembalian),
                    new NpgsqlParameter("@user_id", transaksi.UserId),
                    new NpgsqlParameter("@catatan", transaksi.Catatan ?? (object)DBNull.Value)
                };

                using (var cmdHeader = new NpgsqlCommand(queryHeader, connection, transaction))
                {
                    cmdHeader.Parameters.AddRange(parametersHeader);
                    int transaksiId = Convert.ToInt32(cmdHeader.ExecuteScalar());

                    // 2. Insert detail transaksi
                    string queryDetail = @"
                        INSERT INTO detail_transaksi 
                            (transaksi_id, produk_id, nama_produk, harga_satuan, quantity, subtotal)
                        VALUES 
                            (@transaksi_id, @produk_id, @nama_produk, @harga_satuan, @quantity, @subtotal)
                    ";

                    foreach (var detail in detailList)
                    {
                        using (var cmdDetail = new NpgsqlCommand(queryDetail, connection, transaction))
                        {
                            cmdDetail.Parameters.AddWithValue("@transaksi_id", transaksiId);
                            cmdDetail.Parameters.AddWithValue("@produk_id", detail.ProdukId);
                            cmdDetail.Parameters.AddWithValue("@nama_produk", detail.NamaProduk);
                            cmdDetail.Parameters.AddWithValue("@harga_satuan", detail.HargaSatuan);
                            cmdDetail.Parameters.AddWithValue("@quantity", detail.Quantity);
                            cmdDetail.Parameters.AddWithValue("@subtotal", detail.Subtotal);

                            cmdDetail.ExecuteNonQuery();
                        }

                        // 3. Update stok produk
                        string queryUpdateStok = @"
                            UPDATE produk 
                            SET stok = stok - @quantity 
                            WHERE produk_id = @produk_id
                        ";

                        using (var cmdStok = new NpgsqlCommand(queryUpdateStok, connection, transaction))
                        {
                            cmdStok.Parameters.AddWithValue("@quantity", detail.Quantity);
                            cmdStok.Parameters.AddWithValue("@produk_id", detail.ProdukId);
                            cmdStok.ExecuteNonQuery();
                        }
                    }

                    // Commit transaction
                    transaction.Commit();
                    return transaksiId;
                }
            }
            catch (Exception ex)
            {
                // Rollback jika ada error
                transaction?.Rollback();
                throw new Exception($"Error saving transaksi: {ex.Message}", ex);
            }
            finally
            {
                transaction?.Dispose();
                connection?.Close();
            }
        }

        /// Get transaksi by ID dengan detail
        public DataTable GetTransaksiById(int transaksiId)
        {
            try
            {
                string query = @"
                    SELECT 
                        t.transaksi_id,
                        t.no_transaksi,
                        t.tanggal_transaksi,
                        t.nama_pelanggan,
                        t.total_bayar,
                        t.jumlah_bayar,
                        t.kembalian,
                        u.nama_lengkap as nama_kasir
                    FROM transaksi t
                    JOIN users u ON t.user_id = u.user_id
                    WHERE t.transaksi_id = @transaksiId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksiId", transaksiId)
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting transaksi: {ex.Message}", ex);
            }
        }

        /// Get detail transaksi by transaksi_id
        public DataTable GetDetailTransaksi(int transaksiId)
        {
            try
            {
                string query = @"
                    SELECT 
                        detail_id,
                        produk_id,
                        nama_produk,
                        harga_satuan,
                        quantity,
                        subtotal
                    FROM detail_transaksi
                    WHERE transaksi_id = @transaksiId
                    ORDER BY detail_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@transaksiId", transaksiId)
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting detail transaksi: {ex.Message}", ex);
            }
        }

        /// Get riwayat transaksi (untuk admin/pegawai)
        public DataTable GetRiwayatTransaksi(int? userId = null, DateTime? tanggalMulai = null, DateTime? tanggalAkhir = null)
        {
            try
            {
                string query = @"
                    SELECT 
                        t.transaksi_id,
                        t.no_transaksi,
                        t.tanggal_transaksi,
                        t.nama_pelanggan,
                        t.total_bayar,
                        u.nama_lengkap as nama_kasir
                    FROM transaksi t
                    JOIN users u ON t.user_id = u.user_id
                    WHERE 1=1
                ";

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

                if (userId.HasValue)
                {
                    query += " AND t.user_id = @userId";
                    parameters.Add(new NpgsqlParameter("@userId", userId.Value));
                }

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

                query += " ORDER BY t.tanggal_transaksi DESC";

                return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting riwayat transaksi: {ex.Message}", ex);
            }
        }
    }
}
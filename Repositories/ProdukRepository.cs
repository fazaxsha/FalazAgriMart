using FalazAgriMart.Database;
using FalazAgriMart.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace FalazAgriMart.Repositories
{
    /// <summary>
    /// Repository untuk operasi CRUD Produk
    /// </summary>
    public class ProdukRepository
    {
        /// <summary>
        /// Get semua produk (dengan join kategori & supplier)
        /// </summary>
        public DataTable GetAllProduk()
        {
            try
            {
                string query = @"
                    SELECT 
                        p.produk_id,
                        p.nama_produk,
                        p.kategori_id,
                        k.nama_kategori,
                        p.satuan,
                        p.harga,
                        p.stok,
                        p.stok_minimum,
                        p.supplier_id,
                        s.nama_supplier,
                        p.status,
                        p.created_at
                    FROM produk p
                    LEFT JOIN kategori k ON p.kategori_id = k.kategori_id
                    LEFT JOIN supplier s ON p.supplier_id = s.supplier_id
                    ORDER BY p.nama_produk ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all produk: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Get produk by ID
        /// </summary>
        public Produk GetProdukById(int produkId)
        {
            try
            {
                string query = @"
                    SELECT 
                        produk_id, nama_produk, kategori_id, satuan, 
                        harga, stok, stok_minimum, supplier_id, status
                    FROM produk 
                    WHERE produk_id = @produkId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@produkId", produkId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new Produk(
                        Convert.ToInt32(row["produk_id"]),
                        row["nama_produk"].ToString(),
                        row["kategori_id"] != DBNull.Value ? row["kategori_id"].ToString() : "",
                        row["satuan"].ToString(),
                        Convert.ToDecimal(row["harga"]),
                        Convert.ToInt32(row["stok"]),
                        row["supplier_id"] != DBNull.Value ? Convert.ToInt32(row["supplier_id"]) : (int?)null
                    );
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting produk by ID: {ex.Message}", ex);
            }
        }

        public bool InsertProduk(Produk produk)
        {
            try
            {
                string query = @"
                    INSERT INTO produk 
                        (nama_produk, kategori_id, satuan, harga, stok, stok_minimum, supplier_id, status)
                    VALUES 
                        (@nama_produk, @kategori_id, @satuan, @harga, @stok, @stok_minimum, @supplier_id, @status)
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_produk", produk.NamaProduk),
                    new NpgsqlParameter("@kategori_id", string.IsNullOrEmpty(produk.Kategori) ? DBNull.Value : (object)int.Parse(produk.Kategori)),
                    new NpgsqlParameter("@satuan", produk.Satuan),
                    new NpgsqlParameter("@harga", produk.Harga),
                    new NpgsqlParameter("@stok", produk.Stok),
                    new NpgsqlParameter("@stok_minimum", 10), // Default 10
                    new NpgsqlParameter("@supplier_id", produk.SupplierId.HasValue ? (object)produk.SupplierId.Value : DBNull.Value),
                    new NpgsqlParameter("@status", true)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting produk: {ex.Message}", ex);
            }
        }

        public bool UpdateProduk(Produk produk)
        {
            try
            {
                string query = @"
                    UPDATE produk 
                    SET 
                        nama_produk = @nama_produk,
                        kategori_id = @kategori_id,
                        satuan = @satuan,
                        harga = @harga,
                        stok = @stok,
                        supplier_id = @supplier_id
                    WHERE produk_id = @produk_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_produk", produk.NamaProduk),
                    new NpgsqlParameter("@kategori_id", string.IsNullOrEmpty(produk.Kategori) ? DBNull.Value : (object)int.Parse(produk.Kategori)),
                    new NpgsqlParameter("@satuan", produk.Satuan),
                    new NpgsqlParameter("@harga", produk.Harga),
                    new NpgsqlParameter("@stok", produk.Stok),
                    new NpgsqlParameter("@supplier_id", produk.SupplierId.HasValue ? (object)produk.SupplierId.Value : DBNull.Value),
                    new NpgsqlParameter("@produk_id", produk.ProdukId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating produk: {ex.Message}", ex);
            }
        }

        public bool DeleteProduk(int produkId)
        {
            try
            {
                string query = @"
                    UPDATE produk 
                    SET status = FALSE 
                    WHERE produk_id = @produk_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@produk_id", produkId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting produk: {ex.Message}", ex);
            }
        }

        // Perbaikan: Menambahkan parameter opsional 'kategori'
        public DataTable SearchProduk(string keyword, string kategori = null)
        {
            try
            {
                // Base Query
                string query = @"
                    SELECT 
                        p.produk_id,
                        p.nama_produk,
                        k.nama_kategori,
                        p.satuan,
                        p.harga,
                        p.stok,
                        s.nama_supplier
                    FROM produk p
                    LEFT JOIN kategori k ON p.kategori_id = k.kategori_id
                    LEFT JOIN supplier s ON p.supplier_id = s.supplier_id
                    WHERE p.status = TRUE 
                    AND (LOWER(p.nama_produk) LIKE LOWER(@keyword) OR LOWER(k.nama_kategori) LIKE LOWER(@keyword))";

                // Tambahkan filter kategori jika ada (tidak null)
                if (!string.IsNullOrEmpty(kategori))
                {
                    query += " AND k.nama_kategori = @kategori";
                }

                query += " ORDER BY p.nama_produk ASC";

                // Setup Parameters
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@keyword", "%" + keyword + "%")
                };

                if (!string.IsNullOrEmpty(kategori))
                {
                    parameters.Add(new NpgsqlParameter("@kategori", kategori));
                }

                return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching produk: {ex.Message}", ex);
            }
        }


        public bool ToggleStatusProduk(int produkId)
        {
            try
            {
                string query = @"
            UPDATE produk 
            SET status = NOT status 
            WHERE produk_id = @produk_id
        ";

                NpgsqlParameter[] parameters = {
            new NpgsqlParameter("@produk_id", produkId)
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error toggling produk status: {ex.Message}", ex);
            }
        }


        public bool AktifkanProduk(int produkId)
        {
            try
            {
                string query = @"
            UPDATE produk 
            SET status = TRUE 
            WHERE produk_id = @produk_id
        ";

                NpgsqlParameter[] parameters = {
            new NpgsqlParameter("@produk_id", produkId)
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error aktivasi produk: {ex.Message}", ex);
            }
        }


        public DataTable GetKategoriList()
        {
            try
            {
                string query = @"
                    SELECT kategori_id, nama_kategori 
                    FROM kategori 
                    WHERE status = TRUE
                    ORDER BY nama_kategori ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting kategori list: {ex.Message}", ex);
            }
        }

        public DataTable GetSupplierList()
        {
            try
            {
                string query = @"
                    SELECT supplier_id, nama_supplier 
                    FROM supplier 
                    WHERE status = TRUE
                    ORDER BY nama_supplier ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting supplier list: {ex.Message}", ex);
            }
        }

        public bool IsNamaProdukExists(string namaProduk, int? excludeProdukId = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM produk WHERE LOWER(nama_produk) = LOWER(@namaProduk) AND status = TRUE";

                if (excludeProdukId.HasValue)
                {
                    query += " AND produk_id != @produkId";
                }

                NpgsqlParameter[] parameters = excludeProdukId.HasValue
                    ? new[] {
                        new NpgsqlParameter("@namaProduk", namaProduk),
                        new NpgsqlParameter("@produkId", excludeProdukId.Value)
                    }
                    : new[] {
                        new NpgsqlParameter("@namaProduk", namaProduk)
                    };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking nama produk: {ex.Message}", ex);
            }
        }
    }
}
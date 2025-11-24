using FalazAgriMart.Database;
using FalazAgriMart.Models;
using Npgsql;
using System;
using System.Data;

namespace FalazAgriMart.Repositories
{
    public class KategoriRepository
    {
        public DataTable GetAllKategori()
        {
            try
            {
                string query = @"
                    SELECT 
                        kategori_id,
                        nama_kategori,
                        deskripsi,
                        status,
                        created_at
                    FROM kategori
                    ORDER BY nama_kategori ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all kategori: {ex.Message}", ex);
            }
        }

        public Kategori GetKategoriById(int kategoriId)
        {
            try
            {
                string query = @"
                    SELECT kategori_id, nama_kategori, deskripsi, status
                    FROM kategori
                    WHERE kategori_id = @kategoriId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kategoriId", kategoriId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new Kategori(
                        Convert.ToInt32(row["kategori_id"]),
                        row["nama_kategori"].ToString(),
                        row["deskripsi"].ToString(),
                        Convert.ToBoolean(row["status"])
                    );
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting kategori by ID: {ex.Message}", ex);
            }
        }

        public bool InsertKategori(Kategori kategori)
        {
            try
            {
                string query = @"
                    INSERT INTO kategori 
                        (nama_kategori, deskripsi, status)
                    VALUES 
                        (@nama_kategori, @deskripsi, TRUE)
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_kategori", kategori.NamaKategori),
                    new NpgsqlParameter("@deskripsi", kategori.Deskripsi ?? (object)DBNull.Value)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting kategori: {ex.Message}", ex);
            }
        }

        public bool UpdateKategori(Kategori kategori)
        {
            try
            {
                string query = @"
                    UPDATE kategori 
                    SET 
                        nama_kategori = @nama_kategori,
                        deskripsi = @deskripsi
                    WHERE kategori_id = @kategori_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_kategori", kategori.NamaKategori),
                    new NpgsqlParameter("@deskripsi", kategori.Deskripsi ?? (object)DBNull.Value),
                    new NpgsqlParameter("@kategori_id", kategori.KategoriId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating kategori: {ex.Message}", ex);
            }
        }

        public bool DeleteKategori(int kategoriId)
        {
            try
            {
                string query = @"
                    UPDATE kategori 
                    SET status = FALSE 
                    WHERE kategori_id = @kategori_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kategori_id", kategoriId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting kategori: {ex.Message}", ex);
            }
        }

        public DataTable SearchKategori(string keyword)
        {
            try
            {
                string query = @"
                    SELECT 
                        kategori_id, nama_kategori, deskripsi, status
                    FROM kategori
                    WHERE 
                        LOWER(nama_kategori) LIKE LOWER(@keyword) OR
                        LOWER(deskripsi) LIKE LOWER(@keyword)
                    ORDER BY nama_kategori ASC
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@keyword", "%" + keyword + "%")
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching kategori: {ex.Message}", ex);
            }
        }

        public bool IsNamaKategoriExists(string namaKategori, int? excludeKategoriId = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM kategori WHERE LOWER(nama_kategori) = LOWER(@namaKategori) AND status = TRUE";

                if (excludeKategoriId.HasValue)
                {
                    query += " AND kategori_id != @kategoriId";
                }

                NpgsqlParameter[] parameters = excludeKategoriId.HasValue
                    ? new[] {
                        new NpgsqlParameter("@namaKategori", namaKategori),
                        new NpgsqlParameter("@kategoriId", excludeKategoriId.Value)
                    }
                    : new[] {
                        new NpgsqlParameter("@namaKategori", namaKategori)
                    };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking nama kategori: {ex.Message}", ex);
            }
        }

        public int CountProdukByKategori(int kategoriId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM produk WHERE kategori_id = @kategoriId AND status = TRUE";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@kategoriId", kategoriId)
                };

                return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting produk: {ex.Message}", ex);
            }
        }
    }
}
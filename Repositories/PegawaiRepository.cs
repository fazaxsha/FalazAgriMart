using FalazAgriMart.Database;
using FalazAgriMart.Utils;
using Npgsql;
using System;
using System.Data;

namespace FalazAgriMart.Repositories
{
    /// Repository untuk operasi CRUD Pegawai
    /// Khusus untuk user dengan role 'Pegawai'
    public class PegawaiRepository
    {
        /// Get semua pegawai (role = 'Pegawai')
        public DataTable GetAllPegawai()
        {
            try
            {
                string query = @"
                    SELECT 
                        user_id,
                        username,
                        nama_lengkap,
                        role,
                        status,
                        created_at
                    FROM users
                    WHERE role = 'Pegawai'
                    ORDER BY nama_lengkap ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all pegawai: {ex.Message}", ex);
            }
        }

        /// Get pegawai by ID
        public DataRow GetPegawaiById(int userId)
        {
            try
            {
                string query = @"
                    SELECT 
                        user_id,
                        username,
                        password,
                        nama_lengkap,
                        role,
                        status
                    FROM users
                    WHERE user_id = @userId AND role = 'Pegawai'
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@userId", userId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting pegawai by ID: {ex.Message}", ex);
            }
        }

        /// Insert pegawai baru
        public bool InsertPegawai(string username, string password, string namaLengkap)
        {
            try
            {
                // Untuk production, hash password dulu
                // string hashedPassword = PasswordHelper.HashPassword(password);

                string query = @"
                    INSERT INTO users 
                        (username, password, nama_lengkap, role, status)
                    VALUES 
                        (@username, @password, @nama_lengkap, 'Pegawai', TRUE)
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@username", username),
                    new NpgsqlParameter("@password", password), // Ganti dengan hashedPassword untuk production
                    new NpgsqlParameter("@nama_lengkap", namaLengkap)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting pegawai: {ex.Message}", ex);
            }
        }

        /// Update pegawai (tanpa password)
        public bool UpdatePegawai(int userId, string username, string namaLengkap)
        {
            try
            {
                string query = @"
                    UPDATE users 
                    SET 
                        username = @username,
                        nama_lengkap = @nama_lengkap
                    WHERE user_id = @user_id AND role = 'Pegawai'
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@username", username),
                    new NpgsqlParameter("@nama_lengkap", namaLengkap),
                    new NpgsqlParameter("@user_id", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating pegawai: {ex.Message}", ex);
            }
        }

        /// Update password pegawai
        public bool UpdatePasswordPegawai(int userId, string newPassword)
        {
            try
            {
                // Untuk production, hash password dulu
                // string hashedPassword = PasswordHelper.HashPassword(newPassword);

                string query = @"
                    UPDATE users 
                    SET password = @password 
                    WHERE user_id = @user_id AND role = 'Pegawai'
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@password", newPassword), // Ganti dengan hashedPassword
                    new NpgsqlParameter("@user_id", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating password pegawai: {ex.Message}", ex);
            }
        }

        /// Delete pegawai (soft delete - ubah status jadi false)
        public bool DeletePegawai(int userId)
        {
            try
            {
                string query = @"
                    UPDATE users 
                    SET status = FALSE 
                    WHERE user_id = @user_id AND role = 'Pegawai'
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@user_id", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting pegawai: {ex.Message}", ex);
            }
        }

        /// Search pegawai by nama atau username
        public DataTable SearchPegawai(string keyword)
        {
            try
            {
                string query = @"
                    SELECT 
                        user_id,
                        username,
                        nama_lengkap,
                        role,
                        status,
                        created_at
                    FROM users
                    WHERE 
                        role = 'Pegawai' AND
                        (LOWER(nama_lengkap) LIKE LOWER(@keyword) OR
                         LOWER(username) LIKE LOWER(@keyword))
                    ORDER BY nama_lengkap ASC
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@keyword", "%" + keyword + "%")
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching pegawai: {ex.Message}", ex);
            }
        }

        /// Cek apakah username sudah ada
        public bool IsUsernameExists(string username, int? excludeUserId = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE LOWER(username) = LOWER(@username)";

                if (excludeUserId.HasValue)
                {
                    query += " AND user_id != @userId";
                }

                NpgsqlParameter[] parameters = excludeUserId.HasValue
                    ? new[] {
                        new NpgsqlParameter("@username", username),
                        new NpgsqlParameter("@userId", excludeUserId.Value)
                    }
                    : new[] {
                        new NpgsqlParameter("@username", username)
                    };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking username: {ex.Message}", ex);
            }
        }

        /// Get jumlah pegawai aktif
        public int GetTotalPegawaiAktif()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE role = 'Pegawai' AND status = TRUE";
                return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting total pegawai aktif: {ex.Message}", ex);
            }
        }

        /// Aktifkan kembali pegawai (set status = true)
        public bool AktifkanPegawai(int userId)
        {
            try
            {
                string query = @"
                    UPDATE users 
                    SET status = TRUE 
                    WHERE user_id = @user_id AND role = 'Pegawai'
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@user_id", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error aktivasi pegawai: {ex.Message}", ex);
            }
        }

        /// Get statistik transaksi pegawai (untuk evaluasi kinerja)
        public DataTable GetStatistikPegawai(int userId)
        {
            try
            {
                string query = @"
                    SELECT 
                        COUNT(transaksi_id) as total_transaksi,
                        COALESCE(SUM(total_bayar), 0) as total_penjualan,
                        COALESCE(AVG(total_bayar), 0) as rata_rata_transaksi,
                        MIN(tanggal_transaksi) as transaksi_pertama,
                        MAX(tanggal_transaksi) as transaksi_terakhir
                    FROM transaksi
                    WHERE user_id = @userId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@userId", userId)
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting statistik pegawai: {ex.Message}", ex);
            }
        }
    }
}
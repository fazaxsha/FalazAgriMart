using FalazAgriMart.Database;
using FalazAgriMart.Models;
using FalazAgriMart.Utils;
using Npgsql;
using System;
using System.Data;
// TAMBAHKAN ALIAS:
using UserModel = FalazAgriMart.Models.User;
using AdminModel = FalazAgriMart.Models.Admin;
using PegawaiModel = FalazAgriMart.Models.Pegawai;

namespace FalazAgriMart.Repositories
{
    public class UserRepository
    {
        // GUNAKAN ALIAS UserModel sebagai return type
        public UserModel Login(string username, string password)
        {
            try
            {
                string query = @"SELECT user_id, username, password, nama_lengkap, role, status 
                               FROM users 
                               WHERE username = @username AND status = TRUE";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@username", username)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string storedPassword = row["password"].ToString();

                    if (storedPassword == password)
                    {
                        int userId = Convert.ToInt32(row["user_id"]);
                        string namaLengkap = row["nama_lengkap"].ToString();
                        string role = row["role"].ToString();
                        bool status = Convert.ToBoolean(row["status"]);

                        // GUNAKAN ALIAS
                        if (role == "Admin")
                        {
                            return new AdminModel(userId, username, storedPassword, namaLengkap, status);
                        }
                        else if (role == "Pegawai")
                        {
                            return new PegawaiModel(userId, username, storedPassword, namaLengkap, status);
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saat login: {ex.Message}", ex);
            }
        }

        // GUNAKAN ALIAS untuk return type
        public UserModel GetUserById(int userId)
        {
            try
            {
                string query = @"SELECT user_id, username, password, nama_lengkap, role, status 
                               FROM users 
                               WHERE user_id = @userId";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@userId", userId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string username = row["username"].ToString();
                    string password = row["password"].ToString();
                    string namaLengkap = row["nama_lengkap"].ToString();
                    string role = row["role"].ToString();
                    bool status = Convert.ToBoolean(row["status"]);

                    if (role == "Admin")
                    {
                        return new AdminModel(userId, username, password, namaLengkap, status);
                    }
                    else
                    {
                        return new PegawaiModel(userId, username, password, namaLengkap, status);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting user: {ex.Message}", ex);
            }
        }

        public bool UpdatePassword(int userId, string newPassword)
        {
            try
            {
                string query = @"UPDATE users 
                               SET password = @password 
                               WHERE user_id = @userId";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@password", newPassword),
                    new NpgsqlParameter("@userId", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating password: {ex.Message}", ex);
            }
        }

        public bool IsUsernameExists(string username, int? excludeUserId = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";

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
    }
}
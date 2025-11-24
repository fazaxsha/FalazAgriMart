using FalazAgriMart.Database;
using FalazAgriMart.Models;
using Npgsql;
using System;
using System.Data;

namespace FalazAgriMart.Repositories
{
    public class SupplierRepository
    {
        public DataTable GetAllSupplier()
        {
            try
            {
                string query = @"
                    SELECT 
                        supplier_id,
                        nama_supplier,
                        alamat,
                        no_telp,
                        email,
                        status,
                        created_at
                    FROM supplier
                    ORDER BY nama_supplier ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all supplier: {ex.Message}", ex);
            }
        }

        public Supplier GetSupplierById(int supplierId)
        {
            try
            {
                string query = @"
                    SELECT supplier_id, nama_supplier, alamat, no_telp, email, status
                    FROM supplier
                    WHERE supplier_id = @supplierId
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@supplierId", supplierId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new Supplier(
                        Convert.ToInt32(row["supplier_id"]),
                        row["nama_supplier"].ToString(),
                        row["alamat"].ToString(),
                        row["no_telp"].ToString(),
                        row["email"].ToString(),
                        Convert.ToBoolean(row["status"])
                    );
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting supplier by ID: {ex.Message}", ex);
            }
        }

        public bool InsertSupplier(Supplier supplier)
        {
            try
            {
                string query = @"
                    INSERT INTO supplier 
                        (nama_supplier, alamat, no_telp, email, status)
                    VALUES 
                        (@nama_supplier, @alamat, @no_telp, @email, TRUE)
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_supplier", supplier.NamaSupplier),
                    new NpgsqlParameter("@alamat", supplier.Alamat ?? (object)DBNull.Value),
                    new NpgsqlParameter("@no_telp", supplier.NoTelp ?? (object)DBNull.Value),
                    new NpgsqlParameter("@email", supplier.Email ?? (object)DBNull.Value)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting supplier: {ex.Message}", ex);
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                string query = @"
                    UPDATE supplier 
                    SET 
                        nama_supplier = @nama_supplier,
                        alamat = @alamat,
                        no_telp = @no_telp,
                        email = @email
                    WHERE supplier_id = @supplier_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@nama_supplier", supplier.NamaSupplier),
                    new NpgsqlParameter("@alamat", supplier.Alamat ?? (object)DBNull.Value),
                    new NpgsqlParameter("@no_telp", supplier.NoTelp ?? (object)DBNull.Value),
                    new NpgsqlParameter("@email", supplier.Email ?? (object)DBNull.Value),
                    new NpgsqlParameter("@supplier_id", supplier.SupplierId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating supplier: {ex.Message}", ex);
            }
        }

        public bool DeleteSupplier(int supplierId)
        {
            try
            {
                string query = @"
                    UPDATE supplier 
                    SET status = FALSE 
                    WHERE supplier_id = @supplier_id
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@supplier_id", supplierId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting supplier: {ex.Message}", ex);
            }
        }

        public DataTable SearchSupplier(string keyword)
        {
            try
            {
                string query = @"
                    SELECT 
                        supplier_id, nama_supplier, alamat, no_telp, email, status
                    FROM supplier
                    WHERE 
                        LOWER(nama_supplier) LIKE LOWER(@keyword) OR
                        LOWER(alamat) LIKE LOWER(@keyword) OR
                        LOWER(email) LIKE LOWER(@keyword)
                    ORDER BY nama_supplier ASC
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@keyword", "%" + keyword + "%")
                };

                return DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching supplier: {ex.Message}", ex);
            }
        }

        public bool IsNamaSupplierExists(string namaSupplier, int? excludeSupplierId = null)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM supplier WHERE LOWER(nama_supplier) = LOWER(@namaSupplier) AND status = TRUE";

                if (excludeSupplierId.HasValue)
                {
                    query += " AND supplier_id != @supplierId";
                }

                NpgsqlParameter[] parameters = excludeSupplierId.HasValue
                    ? new[] {
                        new NpgsqlParameter("@namaSupplier", namaSupplier),
                        new NpgsqlParameter("@supplierId", excludeSupplierId.Value)
                    }
                    : new[] {
                        new NpgsqlParameter("@namaSupplier", namaSupplier)
                    };

                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking nama supplier: {ex.Message}", ex);
            }
        }
    }
}

using Npgsql;
using System;
using System.Data;

namespace FalazAgriMart.Database
{
    public class DatabaseHelper
    {
        /// Execute query yang tidak mengembalikan data (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing non-query: {ex.Message}", ex);
            }
        }

        /// Execute query yang mengembalikan single value (COUNT, SUM, dll)
        public static object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing scalar: {ex.Message}", ex);
            }
        }

        /// Execute query yang mengembalikan banyak data (SELECT)
        public static DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing query: {ex.Message}", ex);
            }
        }

        /// Execute query dengan DataReader (untuk performance lebih baik pada data besar)
        public static NpgsqlDataReader ExecuteReader(string query, NpgsqlConnection connection, NpgsqlParameter[] parameters = null)
        {
            try
            {
                var command = new NpgsqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error executing reader: {ex.Message}", ex);
            }
        }
    }
}
using FalazAgriMart.Database;
using Npgsql;
using System;
using System.Data;

namespace FalazAgriMart.Repositories
{
    /// Repository untuk data statistik dashboard
    public class DashboardRepository
    {
        /// Get statistik untuk Dashboard Admin
        public DashboardAdminStats GetAdminStatistics()
        {
            try
            {
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM produk WHERE status = TRUE) as total_produk,
                        (SELECT COUNT(*) FROM users WHERE role = 'Pegawai' AND status = TRUE) as total_pegawai,
                        (SELECT COUNT(*) FROM transaksi WHERE DATE(tanggal_transaksi) = CURRENT_DATE) as transaksi_hari_ini,
                        (SELECT COALESCE(SUM(total_bayar), 0) FROM transaksi WHERE DATE(tanggal_transaksi) = CURRENT_DATE) as pendapatan_hari_ini
                ";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DashboardAdminStats
                    {
                        TotalProduk = Convert.ToInt32(row["total_produk"]),
                        TotalPegawai = Convert.ToInt32(row["total_pegawai"]),
                        TransaksiHariIni = Convert.ToInt32(row["transaksi_hari_ini"]),
                        PendapatanHariIni = Convert.ToDecimal(row["pendapatan_hari_ini"])
                    };
                }

                return new DashboardAdminStats();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting admin statistics: {ex.Message}", ex);
            }
        }

        /// Get statistik untuk Dashboard Pegawai berdasarkan user_id
        public DashboardPegawaiStats GetPegawaiStatistics(int userId)
        {
            try
            {
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM transaksi 
                         WHERE user_id = @userId AND DATE(tanggal_transaksi) = CURRENT_DATE) as transaksi_saya,
                        (SELECT COALESCE(SUM(total_bayar), 0) FROM transaksi 
                         WHERE user_id = @userId AND DATE(tanggal_transaksi) = CURRENT_DATE) as penjualan_saya
                ";

                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@userId", userId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DashboardPegawaiStats
                    {
                        TransaksiSayaHariIni = Convert.ToInt32(row["transaksi_saya"]),
                        PenjualanSayaHariIni = Convert.ToDecimal(row["penjualan_saya"])
                    };
                }

                return new DashboardPegawaiStats();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting pegawai statistics: {ex.Message}", ex);
            }
        }

        /// Get daftar produk dengan stok rendah (Smart Stock Alert)
        public DataTable GetLowStockProducts()
        {
            try
            {
                string query = @"
                    SELECT 
                        p.produk_id,
                        p.nama_produk,
                        p.stok,
                        p.stok_minimum,
                        p.satuan,
                        k.nama_kategori,
                        s.nama_supplier
                    FROM produk p
                    LEFT JOIN kategori k ON p.kategori_id = k.kategori_id
                    LEFT JOIN supplier s ON p.supplier_id = s.supplier_id
                    WHERE p.stok <= p.stok_minimum AND p.status = TRUE
                    ORDER BY p.stok ASC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting low stock products: {ex.Message}", ex);
            }
        }

        /// Get jumlah produk dengan stok rendah (untuk notifikasi)
        public int GetLowStockCount()
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM produk 
                    WHERE stok <= stok_minimum AND status = TRUE
                ";

                object result = DatabaseHelper.ExecuteScalar(query);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting low stock count: {ex.Message}", ex);
            }
        }

        /// Get laporan penjualan per hari (untuk chart/grafik)
        public DataTable GetSalesReport(int days = 7)
        {
            try
            {
                string query = @"
                    SELECT 
                        DATE(tanggal_transaksi) as tanggal,
                        COUNT(*) as jumlah_transaksi,
                        SUM(total_bayar) as total_pendapatan
                    FROM transaksi
                    WHERE tanggal_transaksi >= CURRENT_DATE - INTERVAL '" + days + @" days'
                    GROUP BY DATE(tanggal_transaksi)
                    ORDER BY tanggal DESC
                ";

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting sales report: {ex.Message}", ex);
            }
        }

        /// Get produk terlaris
        public DataTable GetTopSellingProducts(int limit = 10)
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
                    GROUP BY dt.produk_id, dt.nama_produk
                    ORDER BY total_terjual DESC
                    LIMIT " + limit;

                return DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting top selling products: {ex.Message}", ex);
            }
        }
    }

    // ============================================
    // Model untuk statistik dashboard
    // ============================================

    /// Model untuk statistik Dashboard Admin
    public class DashboardAdminStats
    {
        public int TotalProduk { get; set; }
        public int TotalPegawai { get; set; }
        public int TransaksiHariIni { get; set; }
        public decimal PendapatanHariIni { get; set; }

        public DashboardAdminStats()
        {
            TotalProduk = 0;
            TotalPegawai = 0;
            TransaksiHariIni = 0;
            PendapatanHariIni = 0;
        }
    }

    /// Model untuk statistik Dashboard Pegawai
    public class DashboardPegawaiStats
    {
        public int TransaksiSayaHariIni { get; set; }
        public decimal PenjualanSayaHariIni { get; set; }

        public DashboardPegawaiStats()
        {
            TransaksiSayaHariIni = 0;
            PenjualanSayaHariIni = 0;
        }
    }
}
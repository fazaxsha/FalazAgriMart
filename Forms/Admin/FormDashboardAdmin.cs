using FalazAgriMart.Utils;
using FalazAgriMart.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormDashboardAdmin : Form
    {
        private DashboardRepository _dashboardRepository;
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        //private DashboardRepository _dashboardRepository;

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Tampilkan info user yang login
            lblWelcome.Text = $"Selamat Datang, {SessionManager.Instance.GetNamaLengkap()}!";
            lblRole.Text = $"Role: {SessionManager.Instance.GetRole()}";
            lblLoginTime.Text = $"Login: {SessionManager.Instance.GetLoginTime():dd/MM/yyyy HH:mm}";

            // Initialize repository
            _dashboardRepository = new DashboardRepository();

            // Load statistik dashboard
            LoadDashboardStatistics();

            // Check Smart Stock Alert
            CheckSmartStockAlert();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                // Tampilkan loading
                lblTotalProduk.Text = "...";
                lblTotalPegawai.Text = "...";
                lblTotalTransaksi.Text = "...";
                lblTotalPendapatan.Text = "...";

                // Refresh UI
                Application.DoEvents();

                // Get data dari database
                var stats = _dashboardRepository.GetAdminStatistics();

                // Update UI dengan data
                lblTotalProduk.Text = stats.TotalProduk.ToString();
                lblTotalPegawai.Text = stats.TotalPegawai.ToString();
                lblTotalTransaksi.Text = stats.TransaksiHariIni.ToString();
                lblTotalPendapatan.Text = $"Rp {stats.PendapatanHariIni:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat statistik:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set default values jika error
                lblTotalProduk.Text = "0";
                lblTotalPegawai.Text = "0";
                lblTotalTransaksi.Text = "0";
                lblTotalPendapatan.Text = "Rp 0";
            }
        }

        private void CheckSmartStockAlert()
        {
            try
            {
                // Get jumlah produk stok rendah
                int lowStockCount = _dashboardRepository.GetLowStockCount();

                if (lowStockCount > 0)
                {
                    // Tampilkan notifikasi
                    DialogResult result = MessageBox.Show(
                        $"⚠️ SMART STOCK ALERT!\n\n" +
                        $"Ada {lowStockCount} produk dengan stok menipis!\n\n" +
                        $"Apakah ingin melihat daftar produk?",
                        "Peringatan Stok",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        ShowLowStockProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                // Silent error untuk alert, tidak perlu tampilkan ke user
                Console.WriteLine($"Error checking stock alert: {ex.Message}");
            }
        }

        private void ShowLowStockProducts()
        {
            try
            {
                var lowStockData = _dashboardRepository.GetLowStockProducts();

                if (lowStockData.Rows.Count > 0)
                {
                    string message = "📊 PRODUK DENGAN STOK RENDAH:\n\n";

                    foreach (System.Data.DataRow row in lowStockData.Rows)
                    {
                        string namaProduk = row["nama_produk"].ToString();
                        int stok = Convert.ToInt32(row["stok"]);
                        int stokMin = Convert.ToInt32(row["stok_minimum"]);
                        string satuan = row["satuan"].ToString();

                        message += $"• {namaProduk}: {stok} {satuan} (Min: {stokMin})\n";
                    }

                    message += "\n💡 Segera lakukan restocking!";

                    MessageBox.Show(message, "Daftar Stok Rendah",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data stok rendah:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== MENU BUTTONS ==========

        private void btnManajemenProduk_Click(object sender, EventArgs e)
        {
            FormManajemenProduk form = new FormManajemenProduk();
            form.ShowDialog();

            // Refresh dashboard setelah form ditutup
            LoadDashboardStatistics();
        }

        private void btnManajemenPegawai_Click(object sender, EventArgs e)
        {
            FormManajemenPegawai form = new FormManajemenPegawai();
            form.ShowDialog();

            // Refresh dashboard setelah form ditutup
            LoadDashboardStatistics();
        }

        private void btnManajemenSupplier_Click(object sender, EventArgs e)
        {
            FormManajemenSupplier form = new FormManajemenSupplier();
            form.ShowDialog();
            LoadDashboardStatistics();
        }

        private void btnManajemenKategori_Click(object sender, EventArgs e)
        {
            FormManajemenKategori form = new FormManajemenKategori();
            form.ShowDialog();
            LoadDashboardStatistics();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi form = new FormRiwayatTransaksi();
            form.ShowDialog();
            MessageBox.Show("Membuka Form Riwayat Transaksi", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLaporanKeuangan_Click(object sender, EventArgs e)
        {
            FormLaporanKeuangan form = new FormLaporanKeuangan();
            form.ShowDialog();
            MessageBox.Show("Membuka Form Laporan Keuangan", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCekStok_Click(object sender, EventArgs e)
        {
            //FormCekStok form = new FormCekStok();
            //form.ShowDialog();
            //MessageBox.Show("Membuka Form Cek Stok Produk", "Info",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            FormUbahPassword form = new FormUbahPassword();
            form.ShowDialog();
            MessageBox.Show("Membuka Form Ubah Password", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Clear session
                SessionManager.Instance.ClearSession();

                // Kembali ke form login
                this.Hide();
                FalazAgriMart.Forms.Auth.FormLogin formLogin = new FalazAgriMart.Forms.Auth.FormLogin();
                formLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            MessageBox.Show("Dashboard berhasil direfresh!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDashboardAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Konfirmasi sebelum close
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin keluar dari aplikasi?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    SessionManager.Instance.ClearSession();
                    Application.Exit();
                }
            }
        }
    }
}
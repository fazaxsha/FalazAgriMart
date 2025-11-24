using FalazAgriMart.Utils;
using FalazAgriMart.Repositories;
using System;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Pegawai
{
    public partial class FormDashboardPegawai : Form
    {
        private DashboardRepository _dashboardRepository;
        public FormDashboardPegawai()
        {
            InitializeComponent();
        }

        private void FormDashboardPegawai_Load(object sender, EventArgs e)
        {
            // Tampilkan info user yang login
            lblWelcome.Text = $"Selamat Datang, {SessionManager.Instance.GetNamaLengkap()}!";
            lblRole.Text = $"Role: {SessionManager.Instance.GetRole()}";
            lblLoginTime.Text = $"Login: {SessionManager.Instance.GetLoginTime():dd/MM/yyyy HH:mm}";

            // Initialize repository
            _dashboardRepository = new DashboardRepository();

            // Load statistik dashboard
            LoadDashboardStatistics();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                // Tampilkan loading
                lblTotalTransaksiSaya.Text = "...";
                lblTotalPenjualanSaya.Text = "...";

                // Refresh UI
                Application.DoEvents();

                // Get user ID dari session
                int userId = SessionManager.Instance.GetUserId();

                // Get data dari database
                var stats = _dashboardRepository.GetPegawaiStatistics(userId);

                // Update UI dengan data
                lblTotalTransaksiSaya.Text = stats.TransaksiSayaHariIni.ToString();
                lblTotalPenjualanSaya.Text = $"Rp {stats.PenjualanSayaHariIni:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat statistik:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set default values jika error
                lblTotalTransaksiSaya.Text = "0";
                lblTotalPenjualanSaya.Text = "Rp 0";
            }
        }

        // ========== MENU BUTTONS ==========

        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            FormPointOfSale form = new FormPointOfSale();
            form.ShowDialog();

            // Refresh dashboard setelah transaksi
            LoadDashboardStatistics();
        }

        private void btnCekStok_Click(object sender, EventArgs e)
        {
            FormCekStok form = new FormCekStok();
            form.ShowDialog();
            MessageBox.Show("Membuka Form Cek Stok Produk", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRiwayatPribadi_Click(object sender, EventArgs e)
        {
            FormRiwayatPribadi form = new FormRiwayatPribadi();
            form.ShowDialog();
            MessageBox.Show("Membuka Form Riwayat Transaksi Pribadi", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormDashboardPegawai_FormClosing(object sender, FormClosingEventArgs e)
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
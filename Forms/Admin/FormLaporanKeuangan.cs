using FalazAgriMart.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormLaporanKeuangan : Form
    {
        private TransaksiRepository _transaksiRepository;

        public FormLaporanKeuangan()
        {
            InitializeComponent();
            _transaksiRepository = new TransaksiRepository();
        }

        private void FormLaporanKeuangan_Load(object sender, EventArgs e)
        {
            // Set default periode (bulan ini)
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;

            LoadLaporan();
        }

        private void LoadLaporan()
        {
            try
            {
                DateTime tanggalMulai = dtpMulai.Value;
                DateTime tanggalAkhir = dtpAkhir.Value;

                // Validasi tanggal
                if (tanggalMulai > tanggalAkhir)
                {
                    MessageBox.Show("Tanggal mulai tidak boleh lebih besar dari tanggal akhir!",
                        "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load data transaksi
                DataTable dt = _transaksiRepository.GetRiwayatTransaksi(null, tanggalMulai, tanggalAkhir);
                dgvLaporan.DataSource = dt;

                if (dgvLaporan.Columns.Count > 0)
                {
                    dgvLaporan.Columns["transaksi_id"].HeaderText = "ID";
                    dgvLaporan.Columns["transaksi_id"].Width = 60;
                    dgvLaporan.Columns["no_transaksi"].HeaderText = "No. Transaksi";
                    dgvLaporan.Columns["no_transaksi"].Width = 180;
                    dgvLaporan.Columns["tanggal_transaksi"].HeaderText = "Tanggal";
                    dgvLaporan.Columns["tanggal_transaksi"].Width = 150;
                    dgvLaporan.Columns["tanggal_transaksi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvLaporan.Columns["nama_pelanggan"].HeaderText = "Pelanggan";
                    dgvLaporan.Columns["nama_pelanggan"].Width = 200;
                    dgvLaporan.Columns["total_bayar"].HeaderText = "Total";
                    dgvLaporan.Columns["total_bayar"].Width = 120;
                    dgvLaporan.Columns["total_bayar"].DefaultCellStyle.Format = "N0";
                    dgvLaporan.Columns["total_bayar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLaporan.Columns["nama_kasir"].HeaderText = "Kasir";
                    dgvLaporan.Columns["nama_kasir"].Width = 150;
                }

                // Hitung statistik
                HitungStatistik(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat laporan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HitungStatistik(DataTable dt)
        {
            int totalTransaksi = dt.Rows.Count;
            decimal totalPendapatan = 0;
            decimal rataRataTransaksi = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalPendapatan += Convert.ToDecimal(row["total_bayar"]);
            }

            if (totalTransaksi > 0)
            {
                rataRataTransaksi = totalPendapatan / totalTransaksi;
            }

            // Update labels
            lblTotalTransaksi.Text = $"Total Transaksi: {totalTransaksi}";
            lblTotalPendapatan.Text = $"Total Pendapatan: Rp {totalPendapatan:N0}";
            lblRataRata.Text = $"Rata-rata per Transaksi: Rp {rataRataTransaksi:N0}";

            // Hitung periode
            TimeSpan periode = dtpAkhir.Value - dtpMulai.Value;
            int jumlahHari = periode.Days + 1;
            decimal pendapatanPerHari = jumlahHari > 0 ? totalPendapatan / jumlahHari : 0;
            lblPendapatanPerHari.Text = $"Pendapatan per Hari: Rp {pendapatanPerHari:N0}";
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            LoadLaporan();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;
            LoadLaporan();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggalMulai = dtpMulai.Value;
                DateTime tanggalAkhir = dtpAkhir.Value;

                DataTable dt = _transaksiRepository.GetRiwayatTransaksi(null, tanggalMulai, tanggalAkhir);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada data untuk dicetak!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Generate laporan text
                string laporan = "========================================\n";
                laporan += "       LAPORAN KEUANGAN\n";
                laporan += "      FALAZ AgriMart\n";
                laporan += "========================================\n\n";
                laporan += $"Periode: {tanggalMulai:dd/MM/yyyy} - {tanggalAkhir:dd/MM/yyyy}\n";
                laporan += $"Tanggal Cetak: {DateTime.Now:dd/MM/yyyy HH:mm}\n";
                laporan += "========================================\n\n";

                // Statistik
                int totalTransaksi = dt.Rows.Count;
                decimal totalPendapatan = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalPendapatan += Convert.ToDecimal(row["total_bayar"]);
                }

                decimal rataRata = totalTransaksi > 0 ? totalPendapatan / totalTransaksi : 0;
                TimeSpan periode = tanggalAkhir - tanggalMulai;
                int jumlahHari = periode.Days + 1;
                decimal pendapatanPerHari = jumlahHari > 0 ? totalPendapatan / jumlahHari : 0;

                laporan += "RINGKASAN:\n";
                laporan += $"Total Transaksi       : {totalTransaksi}\n";
                laporan += $"Total Pendapatan      : Rp {totalPendapatan:N0}\n";
                laporan += $"Rata-rata Transaksi   : Rp {rataRata:N0}\n";
                laporan += $"Pendapatan per Hari   : Rp {pendapatanPerHari:N0}\n";
                laporan += "\n========================================\n\n";

                laporan += "DETAIL TRANSAKSI:\n";
                laporan += "----------------------------------------\n";

                foreach (DataRow row in dt.Rows)
                {
                    laporan += $"No. {row["no_transaksi"]}\n";
                    laporan += $"Tanggal: {Convert.ToDateTime(row["tanggal_transaksi"]):dd/MM/yyyy HH:mm}\n";
                    laporan += $"Pelanggan: {row["nama_pelanggan"]}\n";
                    laporan += $"Kasir: {row["nama_kasir"]}\n";
                    laporan += $"Total: Rp {Convert.ToDecimal(row["total_bayar"]):N0}\n";
                    laporan += "----------------------------------------\n";
                }

                laporan += "\n========================================\n";
                laporan += "         Terima Kasih\n";
                laporan += "========================================";

                MessageBox.Show(laporan, "Laporan Keuangan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencetak laporan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = $"Laporan_Keuangan_{DateTime.Now:yyyyMMdd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Export ke CSV
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    // Header
                    sb.AppendLine("No. Transaksi,Tanggal,Pelanggan,Kasir,Total");

                    // Data
                    foreach (DataGridViewRow row in dgvLaporan.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sb.AppendLine($"{row.Cells["no_transaksi"].Value}," +
                                        $"{Convert.ToDateTime(row.Cells["tanggal_transaksi"].Value):dd/MM/yyyy HH:mm}," +
                                        $"{row.Cells["nama_pelanggan"].Value}," +
                                        $"{row.Cells["nama_kasir"].Value}," +
                                        $"{row.Cells["total_bayar"].Value}");
                        }
                    }

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());

                    MessageBox.Show("Laporan berhasil diekspor!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengekspor laporan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
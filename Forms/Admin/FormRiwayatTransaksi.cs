using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormRiwayatTransaksi : Form
    {
        private TransaksiRepository _transaksiRepository;
        private int _selectedTransaksiId = 0;

        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            _transaksiRepository = new TransaksiRepository();
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            // Set default date range (bulan ini)
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DateTime? tanggalMulai = chkFilterTanggal.Checked ? dtpMulai.Value : (DateTime?)null;
                DateTime? tanggalAkhir = chkFilterTanggal.Checked ? dtpAkhir.Value : (DateTime?)null;

                DataTable dt = _transaksiRepository.GetRiwayatTransaksi(null, tanggalMulai, tanggalAkhir);
                dgvTransaksi.DataSource = dt;

                if (dgvTransaksi.Columns.Count > 0)
                {
                    dgvTransaksi.Columns["transaksi_id"].HeaderText = "ID";
                    dgvTransaksi.Columns["transaksi_id"].Width = 60;
                    dgvTransaksi.Columns["no_transaksi"].HeaderText = "No. Transaksi";
                    dgvTransaksi.Columns["no_transaksi"].Width = 180;
                    dgvTransaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal";
                    dgvTransaksi.Columns["tanggal_transaksi"].Width = 150;
                    dgvTransaksi.Columns["tanggal_transaksi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvTransaksi.Columns["nama_pelanggan"].HeaderText = "Pelanggan";
                    dgvTransaksi.Columns["nama_pelanggan"].Width = 200;
                    dgvTransaksi.Columns["total_bayar"].HeaderText = "Total";
                    dgvTransaksi.Columns["total_bayar"].Width = 120;
                    dgvTransaksi.Columns["total_bayar"].DefaultCellStyle.Format = "N0";
                    dgvTransaksi.Columns["total_bayar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTransaksi.Columns["nama_kasir"].HeaderText = "Kasir";
                    dgvTransaksi.Columns["nama_kasir"].Width = 150;
                }

                lblTotal.Text = $"Total: {dt.Rows.Count} transaksi";

                // Hitung total pendapatan
                decimal totalPendapatan = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalPendapatan += Convert.ToDecimal(row["total_bayar"]);
                }
                lblTotalPendapatan.Text = $"Total Pendapatan: Rp {totalPendapatan:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];
                _selectedTransaksiId = Convert.ToInt32(row.Cells["transaksi_id"].Value);

                LoadDetailTransaksi(_selectedTransaksiId);
            }
        }

        private void LoadDetailTransaksi(int transaksiId)
        {
            try
            {
                DataTable dt = _transaksiRepository.GetDetailTransaksi(transaksiId);
                dgvDetail.DataSource = dt;

                if (dgvDetail.Columns.Count > 0)
                {
                    dgvDetail.Columns["detail_id"].Visible = false;
                    dgvDetail.Columns["produk_id"].Visible = false;
                    dgvDetail.Columns["nama_produk"].HeaderText = "Nama Produk";
                    dgvDetail.Columns["nama_produk"].Width = 200;
                    dgvDetail.Columns["harga_satuan"].HeaderText = "Harga";
                    dgvDetail.Columns["harga_satuan"].Width = 100;
                    dgvDetail.Columns["harga_satuan"].DefaultCellStyle.Format = "N0";
                    dgvDetail.Columns["quantity"].HeaderText = "Qty";
                    dgvDetail.Columns["quantity"].Width = 60;
                    dgvDetail.Columns["subtotal"].HeaderText = "Subtotal";
                    dgvDetail.Columns["subtotal"].Width = 120;
                    dgvDetail.Columns["subtotal"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat detail: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chkFilterTanggal.Checked = false;
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;
            LoadData();
        }

        private void chkFilterTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dtpMulai.Enabled = chkFilterTanggal.Checked;
            dtpAkhir.Enabled = chkFilterTanggal.Checked;
        }

        private void btnLihatStruk_Click(object sender, EventArgs e)
        {
            if (_selectedTransaksiId == 0)
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get transaksi info
                DataTable dtTransaksi = _transaksiRepository.GetTransaksiById(_selectedTransaksiId);
                DataTable dtDetail = _transaksiRepository.GetDetailTransaksi(_selectedTransaksiId);

                if (dtTransaksi.Rows.Count > 0)
                {
                    DataRow row = dtTransaksi.Rows[0];

                    string struk = "========================================\n";
                    struk += "         FALAZ AgriMart\n";
                    struk += "    Toko Buah & Sayuran Segar\n";
                    struk += "========================================\n\n";
                    struk += $"No. Transaksi: {row["no_transaksi"]}\n";
                    struk += $"Tanggal: {Convert.ToDateTime(row["tanggal_transaksi"]):dd/MM/yyyy HH:mm}\n";
                    struk += $"Kasir: {row["nama_kasir"]}\n";
                    struk += $"Pelanggan: {row["nama_pelanggan"]}\n";
                    struk += "========================================\n\n";

                    foreach (DataRow detail in dtDetail.Rows)
                    {
                        struk += $"{detail["nama_produk"]}\n";
                        struk += $"  {detail["quantity"]} × Rp {Convert.ToDecimal(detail["harga_satuan"]):N0}";
                        struk += $" = Rp {Convert.ToDecimal(detail["subtotal"]):N0}\n\n";
                    }

                    struk += "========================================\n";
                    struk += $"Total: Rp {Convert.ToDecimal(row["total_bayar"]):N0}\n";
                    struk += $"Bayar: Rp {Convert.ToDecimal(row["jumlah_bayar"]):N0}\n";
                    struk += $"Kembalian: Rp {Convert.ToDecimal(row["kembalian"]):N0}\n";
                    struk += "========================================\n\n";
                    struk += "      Terima Kasih Atas Kunjungan Anda!\n";
                    struk += "========================================";

                    MessageBox.Show(struk, "Struk Transaksi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menampilkan struk: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
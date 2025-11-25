using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System.Data;

namespace FalazAgriMart.Forms.Pegawai
{
    public partial class FormRiwayatPribadi : Form
    {
        private TransaksiRepository _transaksiRepository;
        private int _selectedTransaksiId = 0;

        public FormRiwayatPribadi()
        {
            InitializeComponent();
            _transaksiRepository = new TransaksiRepository();
        }

        private void FormRiwayatPribadi_Load(object sender, EventArgs e)
        {
            // Set default date range (bulan ini)
            dtpMulai.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;

            lblInfo.Text = $"Kasir: {SessionManager.Instance.GetNamaLengkap()}";
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                int userId = SessionManager.Instance.GetUserId();
                DateTime? tanggalMulai = chkFilterTanggal.Checked ? dtpMulai.Value : (DateTime?)null;
                DateTime? tanggalAkhir = chkFilterTanggal.Checked ? dtpAkhir.Value : (DateTime?)null;

                // Filter by user ID (hanya transaksi pegawai ini)
                DataTable dt = _transaksiRepository.GetRiwayatTransaksi(userId, tanggalMulai, tanggalAkhir);
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
                    dgvTransaksi.Columns["nama_kasir"].Visible = false; // Hide karena pasti sama
                }

                lblTotal.Text = $"Total: {dt.Rows.Count} transaksi";

                // Hitung total penjualan saya
                decimal totalPenjualan = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalPenjualan += Convert.ToDecimal(row["total_bayar"]);
                }
                lblTotalPenjualan.Text = $"Total Penjualan Saya: Rp {totalPenjualan:N0}";
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
                    dgvDetail.Columns["harga_satuan"].HeaderText = "Harga";
                    dgvDetail.Columns["harga_satuan"].DefaultCellStyle.Format = "N0";
                    dgvDetail.Columns["quantity"].HeaderText = "Qty";
                    dgvDetail.Columns["subtotal"].HeaderText = "Subtotal";
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

    }
}
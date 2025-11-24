using FalazAgriMart.Models;
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Pegawai
{
    public partial class FormPointOfSale : Form
    {
        private ProdukRepository _produkRepository;
        private TransaksiRepository _transaksiRepository;
        private KeranjangBelanja _keranjang;
        private DataTable _dtProduk;

        public FormPointOfSale()
        {
            InitializeComponent();
            _produkRepository = new ProdukRepository();
            _transaksiRepository = new TransaksiRepository();
            _keranjang = new KeranjangBelanja();
        }

        private void FormPointOfSale_Load(object sender, EventArgs e)
        {
            LoadProduk();
            UpdateKeranjangDisplay();
            UpdateTotalDisplay();

            lblKasir.Text = $"Kasir: {SessionManager.Instance.GetNamaLengkap()}";
            lblTanggal.Text = $"Tanggal: {DateTime.Now:dd/MM/yyyy HH:mm}";
        }

        private void LoadProduk()
        {
            try
            {
                _dtProduk = _produkRepository.GetAllProduk();

                // Filter hanya produk dengan stok > 0
                DataView dv = _dtProduk.DefaultView;
                dv.RowFilter = "stok > 0 AND status = TRUE";

                dgvProduk.DataSource = dv;

                if (dgvProduk.Columns.Count > 0)
                {
                    dgvProduk.Columns["produk_id"].HeaderText = "ID";
                    dgvProduk.Columns["produk_id"].Width = 50;
                    dgvProduk.Columns["nama_produk"].HeaderText = "Nama Produk";
                    dgvProduk.Columns["nama_produk"].Width = 200;
                    dgvProduk.Columns["harga"].HeaderText = "Harga";
                    dgvProduk.Columns["harga"].Width = 100;
                    dgvProduk.Columns["harga"].DefaultCellStyle.Format = "N0";
                    dgvProduk.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvProduk.Columns["stok"].HeaderText = "Stok";
                    dgvProduk.Columns["stok"].Width = 80;
                    dgvProduk.Columns["stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProduk.Columns["satuan"].HeaderText = "Satuan";
                    dgvProduk.Columns["satuan"].Width = 80;

                    // Hide kolom yang tidak perlu
                    dgvProduk.Columns["kategori_id"].Visible = false;
                    dgvProduk.Columns["nama_kategori"].Visible = false;
                    dgvProduk.Columns["supplier_id"].Visible = false;
                    dgvProduk.Columns["nama_supplier"].Visible = false;
                    dgvProduk.Columns["status"].Visible = false;
                    dgvProduk.Columns["created_at"].Visible = false;
                    dgvProduk.Columns["stok_minimum"].Visible = false;
                }

                lblTotalProduk.Text = $"{dv.Count} produk tersedia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat produk: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Double click untuk tambah ke keranjang
                TambahKeKeranjang();
            }
        }

        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            TambahKeKeranjang();
        }

        private void TambahKeKeranjang()
        {
            if (dgvProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih produk terlebih dahulu!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow row = dgvProduk.CurrentRow;

                int produkId = Convert.ToInt32(row.Cells["produk_id"].Value);
                string namaProduk = row.Cells["nama_produk"].Value.ToString();
                decimal harga = Convert.ToDecimal(row.Cells["harga"].Value);
                int stokTersedia = Convert.ToInt32(row.Cells["stok"].Value);
                int quantity = (int)numQuantity.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity harus lebih dari 0!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _keranjang.TambahItem(produkId, namaProduk, harga, quantity, stokTersedia);
                UpdateKeranjangDisplay();
                UpdateTotalDisplay();

                // Reset quantity ke 1
                numQuantity.Value = 1;

                MessageBox.Show($"{namaProduk} berhasil ditambahkan ke keranjang!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateKeranjangDisplay()
        {
            // Buat DataTable untuk display
            DataTable dtKeranjang = new DataTable();
            dtKeranjang.Columns.Add("produk_id", typeof(int));
            dtKeranjang.Columns.Add("nama_produk", typeof(string));
            dtKeranjang.Columns.Add("harga_satuan", typeof(decimal));
            dtKeranjang.Columns.Add("quantity", typeof(int));
            dtKeranjang.Columns.Add("subtotal", typeof(decimal));

            foreach (var item in _keranjang.Items)
            {
                dtKeranjang.Rows.Add(
                    item.ProdukId,
                    item.NamaProduk,
                    item.HargaSatuan,
                    item.Quantity,
                    item.Subtotal
                );
            }

            dgvKeranjang.DataSource = dtKeranjang;

            if (dgvKeranjang.Columns.Count > 0)
            {
                dgvKeranjang.Columns["produk_id"].Visible = false;
                dgvKeranjang.Columns["nama_produk"].HeaderText = "Nama Produk";
                dgvKeranjang.Columns["nama_produk"].Width = 200;
                dgvKeranjang.Columns["harga_satuan"].HeaderText = "Harga";
                dgvKeranjang.Columns["harga_satuan"].Width = 100;
                dgvKeranjang.Columns["harga_satuan"].DefaultCellStyle.Format = "N0";
                dgvKeranjang.Columns["quantity"].HeaderText = "Qty";
                dgvKeranjang.Columns["quantity"].Width = 60;
                dgvKeranjang.Columns["subtotal"].HeaderText = "Subtotal";
                dgvKeranjang.Columns["subtotal"].Width = 120;
                dgvKeranjang.Columns["subtotal"].DefaultCellStyle.Format = "N0";
            }

            lblJumlahItem.Text = $"{_keranjang.GetJumlahItem()} item ({_keranjang.GetTotalQuantity()} pcs)";
        }

        private void UpdateTotalDisplay()
        {
            decimal total = _keranjang.GetTotalBelanja();
            lblTotal.Text = $"Rp {total:N0}";

            // Update kembalian jika ada pembayaran
            decimal jumlahBayar;
            if (decimal.TryParse(txtJumlahBayar.Text, out jumlahBayar))
            {
                decimal kembalian = jumlahBayar - total;
                lblKembalian.Text = $"Rp {kembalian:N0}";

                if (kembalian < 0)
                {
                    lblKembalian.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblKembalian.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblKembalian.Text = "Rp 0";
            }
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.CurrentRow == null)
            {
                MessageBox.Show("Pilih item yang akan dihapus!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int produkId = Convert.ToInt32(dgvKeranjang.CurrentRow.Cells["produk_id"].Value);
                string namaProduk = dgvKeranjang.CurrentRow.Cells["nama_produk"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Hapus {namaProduk} dari keranjang?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _keranjang.HapusItem(produkId);
                    UpdateKeranjangDisplay();
                    UpdateTotalDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatalTransaksi_Click(object sender, EventArgs e)
        {
            if (_keranjang.IsEmpty())
            {
                MessageBox.Show("Keranjang sudah kosong!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Batalkan transaksi dan kosongkan keranjang?",
                "Konfirmasi Batal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _keranjang.Clear();
                UpdateKeranjangDisplay();
                UpdateTotalDisplay();
                txtNamaPelanggan.Clear();
                txtJumlahBayar.Clear();

                MessageBox.Show("Transaksi dibatalkan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtJumlahBayar_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalDisplay();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (_keranjang.IsEmpty())
            {
                MessageBox.Show("Keranjang masih kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalBayar = _keranjang.GetTotalBelanja();
            decimal jumlahBayar;

            if (!decimal.TryParse(txtJumlahBayar.Text, out jumlahBayar))
            {
                MessageBox.Show("Masukkan jumlah pembayaran!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahBayar.Focus();
                return;
            }

            if (jumlahBayar < totalBayar)
            {
                MessageBox.Show("Jumlah pembayaran kurang!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahBayar.Focus();
                return;
            }

            try
            {
                decimal kembalian = jumlahBayar - totalBayar;

                // Generate nomor transaksi
                string noTransaksi = _transaksiRepository.GenerateNoTransaksi();

                // Buat object transaksi
                Transaksi transaksi = new Transaksi(
                    noTransaksi,
                    txtNamaPelanggan.Text.Trim(),
                    totalBayar,
                    jumlahBayar,
                    kembalian,
                    SessionManager.Instance.GetUserId()
                );

                // Simpan ke database
                int transaksiId = _transaksiRepository.SimpanTransaksi(transaksi, _keranjang.Items);

                // Tampilkan struk
                MessageBox.Show(
                    $"✅ TRANSAKSI BERHASIL!\n\n" +
                    $"No. Transaksi: {noTransaksi}\n" +
                    $"Total Belanja: Rp {totalBayar:N0}\n" +
                    $"Jumlah Bayar: Rp {jumlahBayar:N0}\n" +
                    $"Kembalian: Rp {kembalian:N0}\n\n" +
                    $"Terima kasih!",
                    "Transaksi Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Reset form
                _keranjang.Clear();
                UpdateKeranjangDisplay();
                UpdateTotalDisplay();
                txtNamaPelanggan.Clear();
                txtJumlahBayar.Clear();
                LoadProduk(); // Refresh stok produk
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan transaksi:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCariProduk_TextChanged(object sender, EventArgs e)
        {
            if (_dtProduk == null) return;

            try
            {
                DataView dv = _dtProduk.DefaultView;

                if (string.IsNullOrWhiteSpace(txtCariProduk.Text))
                {
                    dv.RowFilter = "stok > 0 AND status = TRUE";
                }
                else
                {
                    string keyword = txtCariProduk.Text.Replace("'", "''");
                    dv.RowFilter = $"stok > 0 AND status = TRUE AND nama_produk LIKE '%{keyword}%'";
                }

                lblTotalProduk.Text = $"{dv.Count} produk tersedia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya angka
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
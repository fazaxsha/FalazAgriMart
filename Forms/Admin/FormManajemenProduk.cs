using FalazAgriMart.Models;
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormManajemenProduk : Form
    {
        private ProdukRepository _produkRepository;
        private int _selectedProdukId = 0;
        private bool _isEditMode = false;

        public FormManajemenProduk()
        {
            InitializeComponent();
            _produkRepository = new ProdukRepository();
        }

        private void FormManajemenProduk_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKategoriDropdown();
            LoadSupplierDropdown();
            SetButtonState(false);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _produkRepository.GetAllProduk();

                // ===== KONVERSI BOOLEAN KE STRING SEBELUM BINDING =====
                if (dt.Columns.Contains("status") && dt.Columns["status"].DataType == typeof(bool))
                {
                    dt.Columns.Add("status_display", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["status"] != DBNull.Value)
                        {
                            bool status = Convert.ToBoolean(row["status"]);
                            row["status_display"] = status ? "✅ Aktif" : "❌ Nonaktif";
                        }
                        else
                        {
                            row["status_display"] = "❌ Nonaktif";
                        }
                    }

                    dt.Columns.Remove("status");
                    dt.Columns["status_display"].ColumnName = "status";
                }
                // ===== AKHIR KONVERSI =====

                dgvProduk.DataSource = dt;

                // Styling DataGridView
                if (dgvProduk.Columns.Count > 0)
                {
                    // PASTIKAN URUTAN KOLOM INI ADA DI DATATABLE
                    if (dgvProduk.Columns.Contains("produk_id"))
                    {
                        dgvProduk.Columns["produk_id"].HeaderText = "ID";
                        dgvProduk.Columns["produk_id"].Width = 50;
                    }

                    if (dgvProduk.Columns.Contains("nama_produk"))
                    {
                        dgvProduk.Columns["nama_produk"].HeaderText = "Nama Produk";
                        dgvProduk.Columns["nama_produk"].Width = 200;
                    }

                    if (dgvProduk.Columns.Contains("nama_kategori"))
                    {
                        dgvProduk.Columns["nama_kategori"].HeaderText = "Kategori";
                        dgvProduk.Columns["nama_kategori"].Width = 120;
                    }

                    if (dgvProduk.Columns.Contains("satuan"))
                    {
                        dgvProduk.Columns["satuan"].HeaderText = "Satuan";
                        dgvProduk.Columns["satuan"].Width = 80;
                    }

                    if (dgvProduk.Columns.Contains("harga"))
                    {
                        dgvProduk.Columns["harga"].HeaderText = "Harga";
                        dgvProduk.Columns["harga"].Width = 100;
                        dgvProduk.Columns["harga"].DefaultCellStyle.Format = "N0";
                        dgvProduk.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    if (dgvProduk.Columns.Contains("stok"))
                    {
                        dgvProduk.Columns["stok"].HeaderText = "Stok";
                        dgvProduk.Columns["stok"].Width = 80;
                        dgvProduk.Columns["stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    if (dgvProduk.Columns.Contains("nama_supplier"))
                    {
                        dgvProduk.Columns["nama_supplier"].HeaderText = "Supplier";
                        dgvProduk.Columns["nama_supplier"].Width = 150;
                    }

                    // Tampilkan kolom status dengan format
                    if (dgvProduk.Columns.Contains("status"))
                    {
                        dgvProduk.Columns["status"].HeaderText = "Status";
                        dgvProduk.Columns["status"].Width = 100;
                    }

                    // Hide kolom yang tidak perlu (JANGAN DIHAPUS, HANYA HIDDEN)
                    if (dgvProduk.Columns.Contains("kategori_id"))
                        dgvProduk.Columns["kategori_id"].Visible = false;

                    if (dgvProduk.Columns.Contains("supplier_id"))
                        dgvProduk.Columns["supplier_id"].Visible = false;

                    if (dgvProduk.Columns.Contains("stok_minimum"))
                        dgvProduk.Columns["stok_minimum"].Visible = false;

                    if (dgvProduk.Columns.Contains("created_at"))
                        dgvProduk.Columns["created_at"].Visible = false;

                    // Format warna untuk produk nonaktif
                    foreach (DataGridViewRow row in dgvProduk.Rows)
                    {
                        if (row.Cells["status"].Value != null)
                        {
                            string statusText = row.Cells["status"].Value.ToString();
                            if (statusText.Contains("Nonaktif"))
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                                row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGray;
                            }
                        }
                    }
                }

                lblTotalProduk.Text = $"Total: {dt.Rows.Count} produk";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKategoriDropdown()
        {
            try
            {
                DataTable dt = _produkRepository.GetKategoriList();
                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "kategori_id";
                cmbKategori.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSupplierDropdown()
        {
            try
            {
                DataTable dt = _produkRepository.GetSupplierList();
                cmbSupplier.DataSource = dt;
                cmbSupplier.DisplayMember = "nama_supplier";
                cmbSupplier.ValueMember = "supplier_id";
                cmbSupplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat supplier: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvProduk.Rows[e.RowIndex];
                    _selectedProdukId = Convert.ToInt32(row.Cells["produk_id"].Value);

                    // Fill form
                    txtNamaProduk.Text = row.Cells["nama_produk"].Value?.ToString() ?? "";

                    // Kategori - CEK DULU APAKAH KOLOM ADA
                    if (dgvProduk.Columns.Contains("kategori_id") && row.Cells["kategori_id"].Value != DBNull.Value)
                        cmbKategori.SelectedValue = row.Cells["kategori_id"].Value;
                    else
                        cmbKategori.SelectedIndex = -1;

                    cmbSatuan.Text = row.Cells["satuan"].Value?.ToString() ?? "";
                    txtHarga.Text = row.Cells["harga"].Value?.ToString() ?? "";
                    txtStok.Text = row.Cells["stok"].Value?.ToString() ?? "";

                    // Supplier - CEK DULU APAKAH KOLOM ADA
                    if (dgvProduk.Columns.Contains("supplier_id") && row.Cells["supplier_id"].Value != DBNull.Value)
                        cmbSupplier.SelectedValue = row.Cells["supplier_id"].Value;
                    else
                        cmbSupplier.SelectedIndex = -1;

                    // Cek status untuk show/hide button Aktifkan
                    if (dgvProduk.Columns.Contains("status"))
                    {
                        string statusText = row.Cells["status"].Value?.ToString() ?? "";
                        bool isAktif = statusText.Contains("Aktif") && !statusText.Contains("Nonaktif");

                        btnAktifkan.Visible = !isAktif; // Tampilkan button Aktifkan jika produk nonaktif
                        btnHapus.Visible = isAktif;     // Sembunyikan Hapus jika nonaktif
                        btnEdit.Enabled = isAktif;       // Disable edit jika nonaktif
                    }

                    SetButtonState(true);
                    _isEditMode = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat memilih produk: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _isEditMode = true;
            _selectedProdukId = 0;
            ClearForm();
            txtNamaProduk.Focus();
            SetButtonState(true);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Produk produk = new Produk
                {
                    NamaProduk = txtNamaProduk.Text.Trim(),
                    Kategori = cmbKategori.SelectedValue?.ToString(),
                    Satuan = cmbSatuan.Text.Trim(),
                    Harga = decimal.Parse(txtHarga.Text),
                    Stok = int.Parse(txtStok.Text),
                    SupplierId = cmbSupplier.SelectedValue != null ?
                        Convert.ToInt32(cmbSupplier.SelectedValue) : (int?)null
                };

                bool success;
                string message;

                if (_selectedProdukId == 0) // Insert
                {
                    // Cek nama produk sudah ada atau belum
                    if (_produkRepository.IsNamaProdukExists(produk.NamaProduk))
                    {
                        MessageBox.Show("Nama produk sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaProduk.Focus();
                        return;
                    }

                    success = _produkRepository.InsertProduk(produk);
                    message = "Produk berhasil ditambahkan!";
                }
                else // Update
                {
                    // Cek nama produk sudah ada atau belum (kecuali produk ini sendiri)
                    if (_produkRepository.IsNamaProdukExists(produk.NamaProduk, _selectedProdukId))
                    {
                        MessageBox.Show("Nama produk sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaProduk.Focus();
                        return;
                    }

                    produk.ProdukId = _selectedProdukId;
                    success = _produkRepository.UpdateProduk(produk);
                    message = "Produk berhasil diupdate!";
                }

                if (success)
                {
                    MessageBox.Show(message, "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                    SetButtonState(false);
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tambahkan method ini di FormManajemenProduk.cs
        private void btnAktifkan_Click(object sender, EventArgs e)
        {
            if (_selectedProdukId == 0)
            {
                MessageBox.Show("Pilih produk yang akan diaktifkan!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin mengaktifkan kembali produk ini?",
                "Konfirmasi Aktifkan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _produkRepository.AktifkanProduk(_selectedProdukId);

                    if (success)
                    {
                        MessageBox.Show("Produk berhasil diaktifkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengaktifkan produk!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedProdukId == 0)
            {
                MessageBox.Show("Pilih produk yang akan diedit!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isEditMode = true;
            txtNamaProduk.Focus();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedProdukId == 0)
            {
                MessageBox.Show("Pilih produk yang akan dihapus!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus produk ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _produkRepository.DeleteProduk(_selectedProdukId);

                    if (success)
                    {
                        MessageBox.Show("Produk berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus produk!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetButtonState(false);
            _isEditMode = false;
            _selectedProdukId = 0;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadData();
            }
            else
            {
                try
                {
                    DataTable dt = _produkRepository.SearchProduk(txtCari.Text);
                    dgvProduk.DataSource = dt;
                    lblTotalProduk.Text = $"Ditemukan: {dt.Rows.Count} produk";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mencari data: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
            SetButtonState(false);
            txtCari.Clear();
        }

        private bool ValidateInput()
        {
            string errorMessage;

            if (!ValidationHelper.IsNotEmpty(txtNamaProduk.Text, "Nama Produk", out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaProduk.Focus();
                return false;
            }

            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kategori produk!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKategori.Focus();
                return false;
            }

            if (cmbSatuan.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan produk!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSatuan.Focus();
                return false;
            }

            decimal harga;
            if (!ValidationHelper.IsValidNumber(txtHarga.Text, "Harga", out harga, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return false;
            }

            int stok;
            if (!ValidationHelper.IsValidInteger(txtStok.Text, "Stok", out stok, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStok.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtNamaProduk.Clear();
            cmbKategori.SelectedIndex = -1;
            cmbSatuan.SelectedIndex = -1;
            txtHarga.Clear();
            txtStok.Clear();
            cmbSupplier.SelectedIndex = -1;
            _selectedProdukId = 0;
        }

        private void SetButtonState(bool hasSelection)
        {
            btnSimpan.Enabled = _isEditMode || _selectedProdukId == 0;
            btnEdit.Enabled = hasSelection && !_isEditMode;
            btnHapus.Enabled = hasSelection && !_isEditMode;
            btnBatal.Enabled = hasSelection || _isEditMode;

            // Tombol Aktifkan akan di-handle di dgvProduk_CellClick
            // Jadi tidak perlu di-set di sini
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya angka dan backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya angka dan backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
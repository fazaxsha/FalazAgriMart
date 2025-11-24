using FalazAgriMart.Models;
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormManajemenKategori : Form
    {
        private KategoriRepository _kategoriRepository;
        private int _selectedKategoriId = 0;
        private bool _isEditMode = false;

        public FormManajemenKategori()
        {
            InitializeComponent();
            _kategoriRepository = new KategoriRepository();
        }

        private void FormManajemenKategori_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(false);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _kategoriRepository.GetAllKategori();
                dgvKategori.DataSource = dt;

                if (dgvKategori.Columns.Count > 0)
                {
                    dgvKategori.Columns["kategori_id"].HeaderText = "ID";
                    dgvKategori.Columns["kategori_id"].Width = 50;
                    dgvKategori.Columns["nama_kategori"].HeaderText = "Nama Kategori";
                    dgvKategori.Columns["nama_kategori"].Width = 200;
                    dgvKategori.Columns["deskripsi"].HeaderText = "Deskripsi";
                    dgvKategori.Columns["deskripsi"].Width = 400;
                    dgvKategori.Columns["status"].HeaderText = "Status";
                    dgvKategori.Columns["status"].Width = 100;

                    // Format status
                    foreach (DataGridViewRow row in dgvKategori.Rows)
                    {
                        if (row.Cells["status"].Value != null)
                        {
                            bool status = Convert.ToBoolean(row.Cells["status"].Value);
                            row.Cells["status"].Value = status ? "✅ Aktif" : "❌ Nonaktif";

                            if (!status)
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                                row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGray;
                            }
                        }
                    }

                    if (dgvKategori.Columns.Contains("created_at"))
                        dgvKategori.Columns["created_at"].Visible = false;
                }

                lblTotalKategori.Text = $"Total: {dt.Rows.Count} kategori";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKategori.Rows[e.RowIndex];
                _selectedKategoriId = Convert.ToInt32(row.Cells["kategori_id"].Value);

                txtNamaKategori.Text = row.Cells["nama_kategori"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value?.ToString() ?? "";

                SetButtonState(true);
                _isEditMode = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _isEditMode = true;
            _selectedKategoriId = 0;
            ClearForm();
            txtNamaKategori.Focus();
            SetButtonState(true);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Kategori kategori = new Kategori
                {
                    NamaKategori = txtNamaKategori.Text.Trim(),
                    Deskripsi = txtDeskripsi.Text.Trim()
                };

                bool success;
                string message;

                if (_selectedKategoriId == 0) // Insert
                {
                    if (_kategoriRepository.IsNamaKategoriExists(kategori.NamaKategori))
                    {
                        MessageBox.Show("Nama kategori sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaKategori.Focus();
                        return;
                    }

                    success = _kategoriRepository.InsertKategori(kategori);
                    message = "Kategori berhasil ditambahkan!";
                }
                else // Update
                {
                    if (_kategoriRepository.IsNamaKategoriExists(kategori.NamaKategori, _selectedKategoriId))
                    {
                        MessageBox.Show("Nama kategori sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaKategori.Focus();
                        return;
                    }

                    kategori.KategoriId = _selectedKategoriId;
                    success = _kategoriRepository.UpdateKategori(kategori);
                    message = "Kategori berhasil diupdate!";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedKategoriId == 0)
            {
                MessageBox.Show("Pilih kategori yang akan diedit!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isEditMode = true;
            txtNamaKategori.Focus();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedKategoriId == 0)
            {
                MessageBox.Show("Pilih kategori yang akan dihapus!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek apakah ada produk yang menggunakan kategori ini
            int jumlahProduk = _kategoriRepository.CountProdukByKategori(_selectedKategoriId);

            if (jumlahProduk > 0)
            {
                MessageBox.Show(
                    $"Tidak dapat menghapus kategori ini!\n\n" +
                    $"Masih ada {jumlahProduk} produk yang menggunakan kategori ini.\n" +
                    $"Hapus atau ubah kategori produk terlebih dahulu.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus kategori ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _kategoriRepository.DeleteKategori(_selectedKategoriId);

                    if (success)
                    {
                        MessageBox.Show("Kategori berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus kategori!", "Error",
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
            _selectedKategoriId = 0;
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
                    DataTable dt = _kategoriRepository.SearchKategori(txtCari.Text);
                    dgvKategori.DataSource = dt;
                    lblTotalKategori.Text = $"Ditemukan: {dt.Rows.Count} kategori";
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

            if (!ValidationHelper.IsNotEmpty(txtNamaKategori.Text, "Nama Kategori", out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaKategori.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtNamaKategori.Clear();
            txtDeskripsi.Clear();
            _selectedKategoriId = 0;
        }

        private void SetButtonState(bool hasSelection)
        {
            btnSimpan.Enabled = _isEditMode || _selectedKategoriId == 0;
            btnEdit.Enabled = hasSelection && !_isEditMode;
            btnHapus.Enabled = hasSelection && !_isEditMode;
            btnBatal.Enabled = hasSelection || _isEditMode;
        }
    }
}
using FalazAgriMart.Models;
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormManajemenSupplier : Form
    {
        private SupplierRepository _supplierRepository;
        private int _selectedSupplierId = 0;
        private bool _isEditMode = false;

        public FormManajemenSupplier()
        {
            InitializeComponent();
            _supplierRepository = new SupplierRepository();
        }

        private void FormManajemenSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(false);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _supplierRepository.GetAllSupplier();

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

                dgvSupplier.DataSource = dt;

                if (dgvSupplier.Columns.Count > 0)
                {
                    dgvSupplier.Columns["supplier_id"].HeaderText = "ID";
                    dgvSupplier.Columns["supplier_id"].Width = 50;
                    dgvSupplier.Columns["nama_supplier"].HeaderText = "Nama Supplier";
                    dgvSupplier.Columns["nama_supplier"].Width = 200;
                    dgvSupplier.Columns["alamat"].HeaderText = "Alamat";
                    dgvSupplier.Columns["alamat"].Width = 250;
                    dgvSupplier.Columns["no_telp"].HeaderText = "No. Telepon";
                    dgvSupplier.Columns["no_telp"].Width = 120;
                    dgvSupplier.Columns["email"].HeaderText = "Email";
                    dgvSupplier.Columns["email"].Width = 150;
                    dgvSupplier.Columns["status"].HeaderText = "Status";
                    dgvSupplier.Columns["status"].Width = 100;

                    // Format warna untuk status nonaktif
                    foreach (DataGridViewRow row in dgvSupplier.Rows)
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

                    if (dgvSupplier.Columns.Contains("created_at"))
                        dgvSupplier.Columns["created_at"].Visible = false;
                }

                lblTotalSupplier.Text = $"Total: {dt.Rows.Count} supplier";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                _selectedSupplierId = Convert.ToInt32(row.Cells["supplier_id"].Value);

                txtNamaSupplier.Text = row.Cells["nama_supplier"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value?.ToString() ?? "";
                txtNoTelp.Text = row.Cells["no_telp"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";

                SetButtonState(true);
                _isEditMode = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _isEditMode = true;
            _selectedSupplierId = 0;
            ClearForm();
            txtNamaSupplier.Focus();
            SetButtonState(true);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Supplier supplier = new Supplier
                {
                    NamaSupplier = txtNamaSupplier.Text.Trim(),
                    Alamat = txtAlamat.Text.Trim(),
                    NoTelp = txtNoTelp.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                bool success;
                string message;

                if (_selectedSupplierId == 0) // Insert
                {
                    if (_supplierRepository.IsNamaSupplierExists(supplier.NamaSupplier))
                    {
                        MessageBox.Show("Nama supplier sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaSupplier.Focus();
                        return;
                    }

                    success = _supplierRepository.InsertSupplier(supplier);
                    message = "Supplier berhasil ditambahkan!";
                }
                else // Update
                {
                    if (_supplierRepository.IsNamaSupplierExists(supplier.NamaSupplier, _selectedSupplierId))
                    {
                        MessageBox.Show("Nama supplier sudah ada!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamaSupplier.Focus();
                        return;
                    }

                    supplier.SupplierId = _selectedSupplierId;
                    success = _supplierRepository.UpdateSupplier(supplier);
                    message = "Supplier berhasil diupdate!";
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
            if (_selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih supplier yang akan diedit!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isEditMode = true;
            txtNamaSupplier.Focus();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == 0)
            {
                MessageBox.Show("Pilih supplier yang akan dihapus!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus supplier ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _supplierRepository.DeleteSupplier(_selectedSupplierId);

                    if (success)
                    {
                        MessageBox.Show("Supplier berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus supplier!", "Error",
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
            _selectedSupplierId = 0;
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
                    DataTable dt = _supplierRepository.SearchSupplier(txtCari.Text);
                    dgvSupplier.DataSource = dt;
                    lblTotalSupplier.Text = $"Ditemukan: {dt.Rows.Count} supplier";
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

            if (!ValidationHelper.IsNotEmpty(txtNamaSupplier.Text, "Nama Supplier", out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaSupplier.Focus();
                return false;
            }

            // Validasi email (optional)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!ValidationHelper.IsValidEmail(txtEmail.Text, out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            // Validasi no telp (optional)
            if (!string.IsNullOrWhiteSpace(txtNoTelp.Text))
            {
                if (!ValidationHelper.IsValidPhoneNumber(txtNoTelp.Text, out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoTelp.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearForm()
        {
            txtNamaSupplier.Clear();
            txtAlamat.Clear();
            txtNoTelp.Clear();
            txtEmail.Clear();
            _selectedSupplierId = 0;
        }

        private void SetButtonState(bool hasSelection)
        {
            btnSimpan.Enabled = _isEditMode || _selectedSupplierId == 0;
            btnEdit.Enabled = hasSelection && !_isEditMode;
            btnHapus.Enabled = hasSelection && !_isEditMode;
            btnBatal.Enabled = hasSelection || _isEditMode;
        }
    }
}
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Admin
{
    public partial class FormManajemenPegawai : Form
    {
        private PegawaiRepository _pegawaiRepository;
        private int _selectedUserId = 0;
        private bool _isEditMode = false;

        public FormManajemenPegawai()
        {
            InitializeComponent();
            _pegawaiRepository = new PegawaiRepository();
        }

        private void FormManajemenPegawai_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(false);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _pegawaiRepository.GetAllPegawai();
                dgvPegawai.DataSource = dt;

                // Styling DataGridView
                if (dgvPegawai.Columns.Count > 0)
                {
                    dgvPegawai.Columns["user_id"].HeaderText = "ID";
                    dgvPegawai.Columns["user_id"].Width = 50;
                    dgvPegawai.Columns["username"].HeaderText = "Username";
                    dgvPegawai.Columns["username"].Width = 150;
                    dgvPegawai.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
                    dgvPegawai.Columns["nama_lengkap"].Width = 250;
                    dgvPegawai.Columns["role"].HeaderText = "Role";
                    dgvPegawai.Columns["role"].Width = 100;
                    dgvPegawai.Columns["status"].HeaderText = "Status";
                    dgvPegawai.Columns["status"].Width = 100;

                    // Format status
                    foreach (DataGridViewRow row in dgvPegawai.Rows)
                    {
                        if (row.Cells["status"].Value != null)
                        {
                            bool status = Convert.ToBoolean(row.Cells["status"].Value);
                            row.Cells["status"].Value = status ? "✅ Aktif" : "❌ Nonaktif";

                            // Warna beda untuk status nonaktif
                            if (!status)
                            {
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                                row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGray;
                            }
                        }
                    }

                    // Hide kolom created_at
                    if (dgvPegawai.Columns.Contains("created_at"))
                        dgvPegawai.Columns["created_at"].Visible = false;
                }

                lblTotalPegawai.Text = $"Total: {dt.Rows.Count} pegawai";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPegawai.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells["user_id"].Value);

                // Fill form
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtNamaLengkap.Text = row.Cells["nama_lengkap"].Value.ToString();

                // Cek status untuk enable/disable button
                string statusText = row.Cells["status"].Value.ToString();
                bool isAktif = statusText.Contains("Aktif");

                SetButtonState(true);
                btnAktifkan.Visible = !isAktif;
                _isEditMode = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _isEditMode = true;
            _selectedUserId = 0;
            ClearForm();
            txtUsername.Focus();
            SetButtonState(true);

            // Tampilkan field password untuk tambah pegawai baru
            panelPassword.Visible = true;
            lblPassword.Text = "Password:";
            txtPassword.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                bool success;
                string message;

                if (_selectedUserId == 0) // Insert
                {
                    // Validasi password tidak boleh kosong untuk pegawai baru
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Focus();
                        return;
                    }

                    // Cek username sudah ada atau belum
                    if (_pegawaiRepository.IsUsernameExists(txtUsername.Text))
                    {
                        MessageBox.Show("Username sudah ada! Gunakan username lain.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    success = _pegawaiRepository.InsertPegawai(
                        txtUsername.Text.Trim(),
                        txtPassword.Text,
                        txtNamaLengkap.Text.Trim()
                    );
                    message = "Pegawai berhasil ditambahkan!";
                }
                else // Update
                {
                    // Cek username sudah ada atau belum (kecuali pegawai ini sendiri)
                    if (_pegawaiRepository.IsUsernameExists(txtUsername.Text, _selectedUserId))
                    {
                        MessageBox.Show("Username sudah ada! Gunakan username lain.", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    success = _pegawaiRepository.UpdatePegawai(
                        _selectedUserId,
                        txtUsername.Text.Trim(),
                        txtNamaLengkap.Text.Trim()
                    );
                    message = "Data pegawai berhasil diupdate!";
                }

                if (success)
                {
                    MessageBox.Show(message, "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                    SetButtonState(false);
                    panelPassword.Visible = false;
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
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Pilih pegawai yang akan diedit!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isEditMode = true;
            txtUsername.Focus();
            panelPassword.Visible = false; // Hide password saat edit
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Pilih pegawai yang akan diubah passwordnya!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan input password
            panelPassword.Visible = true;
            lblPassword.Text = "Password Baru:";
            txtPassword.Clear();
            txtPassword.Focus();

            DialogResult result = MessageBox.Show(
                "Masukkan password baru, kemudian klik OK.",
                "Ubah Password",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bool success = _pegawaiRepository.UpdatePasswordPegawai(_selectedUserId, txtPassword.Text);

                    if (success)
                    {
                        MessageBox.Show("Password berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        panelPassword.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah password!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                panelPassword.Visible = false;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Pilih pegawai yang akan dihapus!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menonaktifkan pegawai ini?\n\n" +
                "Pegawai yang dinonaktifkan tidak dapat login ke sistem.",
                "Konfirmasi Nonaktifkan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _pegawaiRepository.DeletePegawai(_selectedUserId);

                    if (success)
                    {
                        MessageBox.Show("Pegawai berhasil dinonaktifkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menonaktifkan pegawai!", "Error",
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

        private void btnAktifkan_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Pilih pegawai yang akan diaktifkan!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin mengaktifkan kembali pegawai ini?",
                "Konfirmasi Aktifkan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _pegawaiRepository.AktifkanPegawai(_selectedUserId);

                    if (success)
                    {
                        MessageBox.Show("Pegawai berhasil diaktifkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        SetButtonState(false);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengaktifkan pegawai!", "Error",
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
            _selectedUserId = 0;
            panelPassword.Visible = false;
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
                    DataTable dt = _pegawaiRepository.SearchPegawai(txtCari.Text);
                    dgvPegawai.DataSource = dt;
                    lblTotalPegawai.Text = $"Ditemukan: {dt.Rows.Count} pegawai";
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
            panelPassword.Visible = false;
        }

        private bool ValidateInput()
        {
            string errorMessage;

            if (!ValidationHelper.IsNotEmpty(txtUsername.Text, "Username", out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (!ValidationHelper.IsValidLength(txtUsername.Text, "Username", 4, 50, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (!ValidationHelper.IsNotEmpty(txtNamaLengkap.Text, "Nama Lengkap", out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLengkap.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtNamaLengkap.Clear();
            txtPassword.Clear();
            _selectedUserId = 0;
        }

        private void SetButtonState(bool hasSelection)
        {
            btnSimpan.Enabled = _isEditMode || _selectedUserId == 0;
            btnEdit.Enabled = hasSelection && !_isEditMode;
            btnHapus.Enabled = hasSelection && !_isEditMode;
            btnUbahPassword.Enabled = hasSelection && !_isEditMode;
            btnBatal.Enabled = hasSelection || _isEditMode;
        }
    }
}
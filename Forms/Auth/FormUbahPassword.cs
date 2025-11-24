using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
using System;
using System.Windows.Forms;

namespace FalazAgriMart.Forms
{
    public partial class FormUbahPassword : Form
    {
        private UserRepository _userRepository;

        public FormUbahPassword()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void FormUbahPassword_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Username: {SessionManager.Instance.GetUsername()}";
            lblNama.Text = $"Nama: {SessionManager.Instance.GetNamaLengkap()}";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtPasswordLama.Text))
                {
                    MessageBox.Show("Password lama harus diisi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordLama.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPasswordBaru.Text))
                {
                    MessageBox.Show("Password baru harus diisi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordBaru.Focus();
                    return;
                }

                if (txtPasswordBaru.Text.Length < 6)
                {
                    MessageBox.Show("Password baru minimal 6 karakter!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordBaru.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtKonfirmasi.Text))
                {
                    MessageBox.Show("Konfirmasi password harus diisi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKonfirmasi.Focus();
                    return;
                }

                if (txtPasswordBaru.Text != txtKonfirmasi.Text)
                {
                    MessageBox.Show("Password baru dan konfirmasi password tidak sama!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKonfirmasi.Focus();
                    return;
                }

                if (txtPasswordLama.Text == txtPasswordBaru.Text)
                {
                    MessageBox.Show("Password baru tidak boleh sama dengan password lama!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordBaru.Focus();
                    return;
                }

                // Konfirmasi
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin mengubah password?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                // Update password
                int userId = SessionManager.Instance.GetUserId();
                string passwordLama = txtPasswordLama.Text;
                string passwordBaru = txtPasswordBaru.Text;

                bool success = _userRepository.UpdatePassword(userId, passwordLama, passwordBaru);

                if (success)
                {
                    MessageBox.Show("Password berhasil diubah!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password lama tidak sesuai!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswordLama.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah password: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtPasswordLama.Clear();
            txtPasswordBaru.Clear();
            txtKonfirmasi.Clear();
        }

        private void chkLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = chkLihatPassword.Checked ? '\0' : '*';
            txtPasswordLama.PasswordChar = passwordChar;
            txtPasswordBaru.PasswordChar = passwordChar;
            txtKonfirmasi.PasswordChar = passwordChar;
        }
    }
}
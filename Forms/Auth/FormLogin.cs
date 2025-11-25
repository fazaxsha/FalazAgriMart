using System;
using System.Windows.Forms;
using FalazAgriMart.Models;
using FalazAgriMart.Repositories;
using FalazAgriMart.Utils;
// TAMBAHKAN ALIAS INI:
using AdminModel = FalazAgriMart.Models.Admin;
using PegawaiModel = FalazAgriMart.Models.Pegawai;
using UserModel = FalazAgriMart.Models.User;

namespace FalazAgriMart.Forms.Auth
{
    public partial class FormLogin : Form
    {
        private UserRepository _userRepository;

        public FormLogin()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                // GUNAKAN ALIAS UserModel
                UserModel user = _userRepository.Login(txtUsername.Text, txtPassword.Text);

                if (user != null)
                {
                    SessionManager.Instance.SetUser(user);
                    user.TampilkanInfo();

                    MessageBox.Show($"Login berhasil!\n\nSelamat datang, {user.NamaLengkap}\nRole: {user.Role}",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // GUNAKAN ALIAS AdminModel dan PegawaiModel
                    if (user is AdminModel)
                    {
                        this.Hide();
                        var formDashboard = new FalazAgriMart.Forms.Admin.FormDashboardAdmin();
                        formDashboard.ShowDialog();
                        this.Close();
                    }
                    else if (user is PegawaiModel)
                    {
                        this.Hide();
                        var formDashboard = new FalazAgriMart.Forms.Pegawai.FormDashboardPegawai();
                        formDashboard.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Login Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void lblRightTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblQuote_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
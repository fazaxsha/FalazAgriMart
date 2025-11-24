using FalazAgriMart.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace FalazAgriMart.Forms.Pegawai
{
    public partial class FormCekStok : Form
    {
        private ProdukRepository _produkRepository;

        public FormCekStok()
        {
            InitializeComponent();
            _produkRepository = new ProdukRepository();
        }

        private void FormCekStok_Load(object sender, EventArgs e)
        {
            LoadKategori();
            LoadData();
        }

        private void LoadKategori()
        {
            try
            {
                DataTable dt = _produkRepository.GetKategoriList();

                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Semua Kategori");

                foreach (DataRow row in dt.Rows)
                {
                    cmbKategori.Items.Add(row["nama_kategori"].ToString());
                }

                cmbKategori.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string keyword = txtCari.Text.Trim();
                string kategori = cmbKategori.SelectedIndex > 0 ? cmbKategori.Text : null;

                DataTable dt = _produkRepository.SearchProduk(keyword, kategori);
                dgvProduk.DataSource = dt;

                if (dgvProduk.Columns.Count > 0)
                {
                    dgvProduk.Columns["produk_id"].HeaderText = "ID";
                    dgvProduk.Columns["produk_id"].Width = 50;
                    dgvProduk.Columns["nama_produk"].HeaderText = "Nama Produk";
                    dgvProduk.Columns["nama_produk"].Width = 250;
                    dgvProduk.Columns["nama_kategori"].HeaderText = "Kategori";
                    dgvProduk.Columns["nama_kategori"].Width = 120;
                    dgvProduk.Columns["harga"].HeaderText = "Harga";
                    dgvProduk.Columns["harga"].Width = 100;
                    dgvProduk.Columns["harga"].DefaultCellStyle.Format = "N0";
                    dgvProduk.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvProduk.Columns["stok"].HeaderText = "Stok";
                    dgvProduk.Columns["stok"].Width = 80;
                    dgvProduk.Columns["stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProduk.Columns["satuan"].HeaderText = "Satuan";
                    dgvProduk.Columns["satuan"].Width = 80;

                    // Warna untuk stok rendah
                    foreach (DataGridViewRow row in dgvProduk.Rows)
                    {
                        int stok = Convert.ToInt32(row.Cells["stok"].Value);
                        if (stok <= 10)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        }
                        else if (stok <= 20)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
                        }
                    }
                }

                lblTotal.Text = $"Total: {dt.Rows.Count} produk";

                // Hitung stok rendah
                int stokRendah = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToInt32(row["stok"]) <= 10)
                    {
                        stokRendah++;
                    }
                }
                lblStokRendah.Text = $"Stok Rendah: {stokRendah} produk";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            cmbKategori.SelectedIndex = 0;
            LoadData();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadData();
                e.Handled = true;
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.FileName = $"Stok_Produk_{DateTime.Now:yyyyMMdd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    // Header
                    sb.AppendLine("ID,Nama Produk,Kategori,Harga,Stok,Satuan");

                    // Data
                    foreach (DataGridViewRow row in dgvProduk.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sb.AppendLine($"{row.Cells["produk_id"].Value}," +
                                        $"\"{row.Cells["nama_produk"].Value}\"," +
                                        $"{row.Cells["nama_kategori"].Value}," +
                                        $"{row.Cells["harga"].Value}," +
                                        $"{row.Cells["stok"].Value}," +
                                        $"{row.Cells["satuan"].Value}");
                        }
                    }

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());

                    MessageBox.Show("Data berhasil diekspor!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengekspor data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
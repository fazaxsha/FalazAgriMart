// ============================================
// File: Forms/Pegawai/FormPointOfSale.Designer.cs
// Designer code untuk FormPointOfSale
// ============================================

namespace FalazAgriMart.Forms.Pegawai
{
    partial class FormPointOfSale
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelProduk;
        private System.Windows.Forms.Panel panelKeranjang;
        private System.Windows.Forms.Panel panelCheckout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKasir;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblCariProduk;
        private System.Windows.Forms.TextBox txtCariProduk;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Label lblTotalProduk;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnTambahKeranjang;
        private System.Windows.Forms.Label lblKeranjangTitle;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label lblJumlahItem;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblJumlahBayarLabel;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.Label lblKembalianLabel;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnBatalTransaksi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();

            this.panelProduk = new System.Windows.Forms.Panel();
            this.lblCariProduk = new System.Windows.Forms.Label();
            this.txtCariProduk = new System.Windows.Forms.TextBox();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.lblTotalProduk = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnTambahKeranjang = new System.Windows.Forms.Button();

            this.panelKeranjang = new System.Windows.Forms.Panel();
            this.lblKeranjangTitle = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.lblJumlahItem = new System.Windows.Forms.Label();
            this.btnHapusItem = new System.Windows.Forms.Button();

            this.panelCheckout = new System.Windows.Forms.Panel();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblJumlahBayarLabel = new System.Windows.Forms.Label();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.lblKembalianLabel = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnBatalTransaksi = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelProduk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panelKeranjang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.panelCheckout.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.panelTop.Controls.Add(this.lblTanggal);
            this.panelTop.Controls.Add(this.lblKasir);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 70);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.Text = "🛒 POINT OF SALE (KASIR)";

            // lblKasir
            this.lblKasir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKasir.ForeColor = System.Drawing.Color.White;
            this.lblKasir.Location = new System.Drawing.Point(1000, 15);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(380, 25);
            this.lblKasir.Text = "Kasir: -";
            this.lblKasir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTanggal
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.White;
            this.lblTanggal.Location = new System.Drawing.Point(1000, 40);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(380, 25);
            this.lblTanggal.Text = "Tanggal: -";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // panelProduk (Left Panel)
            this.panelProduk.BackColor = System.Drawing.Color.White;
            this.panelProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduk.Controls.Add(this.btnTambahKeranjang);
            this.panelProduk.Controls.Add(this.numQuantity);
            this.panelProduk.Controls.Add(this.lblQuantity);
            this.panelProduk.Controls.Add(this.lblTotalProduk);
            this.panelProduk.Controls.Add(this.dgvProduk);
            this.panelProduk.Controls.Add(this.txtCariProduk);
            this.panelProduk.Controls.Add(this.lblCariProduk);
            this.panelProduk.Location = new System.Drawing.Point(20, 90);
            this.panelProduk.Name = "panelProduk";
            this.panelProduk.Size = new System.Drawing.Size(600, 660);
            this.panelProduk.TabIndex = 1;

            // lblCariProduk
            this.lblCariProduk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCariProduk.Location = new System.Drawing.Point(15, 15);
            this.lblCariProduk.Name = "lblCariProduk";
            this.lblCariProduk.Size = new System.Drawing.Size(100, 25);
            this.lblCariProduk.Text = "🔍 Cari Produk:";
            this.lblCariProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtCariProduk
            this.txtCariProduk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCariProduk.Location = new System.Drawing.Point(120, 15);
            this.txtCariProduk.Name = "txtCariProduk";
            this.txtCariProduk.Size = new System.Drawing.Size(460, 25);
            this.txtCariProduk.TabIndex = 0;
            this.txtCariProduk.TextChanged += new System.EventHandler(this.txtCariProduk_TextChanged);

            // dgvProduk
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Location = new System.Drawing.Point(15, 50);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(565, 490);
            this.dgvProduk.TabIndex = 1;
            this.dgvProduk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellDoubleClick);

            // lblTotalProduk
            this.lblTotalProduk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduk.Location = new System.Drawing.Point(15, 550);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Size = new System.Drawing.Size(200, 20);
            this.lblTotalProduk.Text = "0 produk tersedia";

            // lblQuantity
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(15, 585);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 25);
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // numQuantity
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numQuantity.Location = new System.Drawing.Point(100, 582);
            this.numQuantity.Maximum = 1000;
            this.numQuantity.Minimum = 1;
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 30);
            this.numQuantity.TabIndex = 2;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantity.Value = 1;

            // btnTambahKeranjang
            this.btnTambahKeranjang.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnTambahKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKeranjang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTambahKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnTambahKeranjang.Location = new System.Drawing.Point(220, 575);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.Size = new System.Drawing.Size(360, 45);
            this.btnTambahKeranjang.TabIndex = 3;
            this.btnTambahKeranjang.Text = "➕ TAMBAH KE KERANJANG";
            this.btnTambahKeranjang.UseVisualStyleBackColor = false;
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);

            // panelKeranjang (Center Panel)
            this.panelKeranjang.BackColor = System.Drawing.Color.White;
            this.panelKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKeranjang.Controls.Add(this.btnHapusItem);
            this.panelKeranjang.Controls.Add(this.lblJumlahItem);
            this.panelKeranjang.Controls.Add(this.dgvKeranjang);
            this.panelKeranjang.Controls.Add(this.lblKeranjangTitle);
            this.panelKeranjang.Location = new System.Drawing.Point(640, 90);
            this.panelKeranjang.Name = "panelKeranjang";
            this.panelKeranjang.Size = new System.Drawing.Size(420, 400);
            this.panelKeranjang.TabIndex = 2;

            // lblKeranjangTitle
            this.lblKeranjangTitle.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.lblKeranjangTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKeranjangTitle.ForeColor = System.Drawing.Color.White;
            this.lblKeranjangTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKeranjangTitle.Name = "lblKeranjangTitle";
            this.lblKeranjangTitle.Size = new System.Drawing.Size(418, 40);
            this.lblKeranjangTitle.Text = "🛒 KERANJANG BELANJA";
            this.lblKeranjangTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvKeranjang
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(15, 50);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(390, 280);
            this.dgvKeranjang.TabIndex = 0;

            // lblJumlahItem
            this.lblJumlahItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlahItem.Location = new System.Drawing.Point(15, 340);
            this.lblJumlahItem.Name = "lblJumlahItem";
            this.lblJumlahItem.Size = new System.Drawing.Size(200, 25);
            this.lblJumlahItem.Text = "0 item (0 pcs)";

            // btnHapusItem
            this.btnHapusItem.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnHapusItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapusItem.ForeColor = System.Drawing.Color.White;
            this.btnHapusItem.Location = new System.Drawing.Point(250, 335);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(155, 35);
            this.btnHapusItem.Text = "🗑️ Hapus Item";
            this.btnHapusItem.UseVisualStyleBackColor = false;
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);

            // panelCheckout (Right Panel)
            this.panelCheckout.BackColor = System.Drawing.Color.White;
            this.panelCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCheckout.Controls.Add(this.btnBatalTransaksi);
            this.panelCheckout.Controls.Add(this.btnProses);
            this.panelCheckout.Controls.Add(this.lblKembalian);
            this.panelCheckout.Controls.Add(this.lblKembalianLabel);
            this.panelCheckout.Controls.Add(this.txtJumlahBayar);
            this.panelCheckout.Controls.Add(this.lblJumlahBayarLabel);
            this.panelCheckout.Controls.Add(this.lblTotal);
            this.panelCheckout.Controls.Add(this.lblTotalLabel);
            this.panelCheckout.Controls.Add(this.txtNamaPelanggan);
            this.panelCheckout.Controls.Add(this.lblNamaPelanggan);
            this.panelCheckout.Location = new System.Drawing.Point(640, 510);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(420, 240);
            this.panelCheckout.TabIndex = 3;

            int yPos = 15;

            // lblNamaPelanggan
            this.lblNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaPelanggan.Location = new System.Drawing.Point(15, yPos);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(150, 20);
            this.lblNamaPelanggan.Text = "Nama Pelanggan:";

            // txtNamaPelanggan
            this.txtNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaPelanggan.Location = new System.Drawing.Point(15, yPos + 22);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(390, 25);
            this.txtNamaPelanggan.TabIndex = 0;
            yPos += 60;

            // lblTotalLabel
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(15, yPos);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(200, 25);
            this.lblTotalLabel.Text = "TOTAL BELANJA:";

            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 87, 34);
            this.lblTotal.Location = new System.Drawing.Point(15, yPos + 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(390, 35);
            this.lblTotal.Text = "Rp 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            yPos += 70;

            // lblJumlahBayarLabel
            this.lblJumlahBayarLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlahBayarLabel.Location = new System.Drawing.Point(15, yPos);
            this.lblJumlahBayarLabel.Name = "lblJumlahBayarLabel";
            this.lblJumlahBayarLabel.Size = new System.Drawing.Size(150, 20);
            this.lblJumlahBayarLabel.Text = "Jumlah Bayar:";

            // txtJumlahBayar
            this.txtJumlahBayar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtJumlahBayar.Location = new System.Drawing.Point(15, yPos + 22);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(180, 30);
            this.txtJumlahBayar.TabIndex = 1;
            this.txtJumlahBayar.TextChanged += new System.EventHandler(this.txtJumlahBayar_TextChanged);
            this.txtJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBayar_KeyPress);

            // lblKembalianLabel
            this.lblKembalianLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKembalianLabel.Location = new System.Drawing.Point(220, yPos);
            this.lblKembalianLabel.Name = "lblKembalianLabel";
            this.lblKembalianLabel.Size = new System.Drawing.Size(100, 20);
            this.lblKembalianLabel.Text = "Kembalian:";

            // lblKembalian
            this.lblKembalian.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.lblKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKembalian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKembalian.ForeColor = System.Drawing.Color.Green;
            this.lblKembalian.Location = new System.Drawing.Point(220, yPos + 22);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(185, 30);
            this.lblKembalian.Text = "Rp 0";
            this.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            yPos += 65;

            // btnProses
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProses.ForeColor = System.Drawing.Color.White;
            this.btnProses.Location = new System.Drawing.Point(15, yPos);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(280, 45);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "✅ PROSES TRANSAKSI";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);

            // btnBatalTransaksi
            this.btnBatalTransaksi.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnBatalTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatalTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnBatalTransaksi.Location = new System.Drawing.Point(305, yPos);
            this.btnBatalTransaksi.Name = "btnBatalTransaksi";
            this.btnBatalTransaksi.Size = new System.Drawing.Size(100, 45);
            this.btnBatalTransaksi.TabIndex = 3;
            this.btnBatalTransaksi.Text = "❌ Batal";
            this.btnBatalTransaksi.UseVisualStyleBackColor = false;
            this.btnBatalTransaksi.Click += new System.EventHandler(this.btnBatalTransaksi_Click);

            // FormPointOfSale
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.ClientSize = new System.Drawing.Size(1400, 770);
            this.Controls.Add(this.panelCheckout);
            this.Controls.Add(this.panelKeranjang);
            this.Controls.Add(this.panelProduk);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPointOfSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale - FALAZ AgriMart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPointOfSale_Load);

            this.panelTop.ResumeLayout(false);
            this.panelProduk.ResumeLayout(false);
            this.panelProduk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panelKeranjang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
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
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.Panel panelQuantityBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panelProduk = new System.Windows.Forms.Panel();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblCariProduk = new System.Windows.Forms.Label();
            this.txtCariProduk = new System.Windows.Forms.TextBox();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.lblTotalProduk = new System.Windows.Forms.Label();
            this.panelQuantityBox = new System.Windows.Forms.Panel();
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
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panelQuantityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panelKeranjang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.panelCheckout.SuspendLayout();
            this.SuspendLayout();

            // ============================================
            // PANEL TOP - Header (Soft Leaf Green)
            // ============================================
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(102, 187, 106); // Hijau Daun Lembut
            this.panelTop.Controls.Add(this.lblTanggal);
            this.panelTop.Controls.Add(this.lblKasir);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 80);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.Text = "🌱 AgriMart POS"; // Ganti Icon Daun

            // lblKasir
            this.lblKasir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKasir.ForeColor = System.Drawing.Color.White;
            this.lblKasir.Location = new System.Drawing.Point(1050, 20);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(320, 25);
            this.lblKasir.Text = "👤 Kasir: -";
            this.lblKasir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTanggal
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(232, 245, 233); // Putih Kehijauan
            this.lblTanggal.Location = new System.Drawing.Point(1050, 45);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(320, 25);
            this.lblTanggal.Text = "📅 Tanggal: -";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ============================================
            // PANEL PRODUK (Left)
            // ============================================
            this.panelProduk.BackColor = System.Drawing.Color.White;
            this.panelProduk.Controls.Add(this.btnTambahKeranjang);
            this.panelProduk.Controls.Add(this.panelQuantityBox);
            this.panelProduk.Controls.Add(this.lblTotalProduk);
            this.panelProduk.Controls.Add(this.dgvProduk);
            this.panelProduk.Controls.Add(this.panelSearchBox);
            this.panelProduk.Location = new System.Drawing.Point(20, 100);
            this.panelProduk.Name = "panelProduk";
            this.panelProduk.Size = new System.Drawing.Size(620, 650);
            this.panelProduk.TabIndex = 1;

            // panelSearchBox - Background Mint Lembut
            this.panelSearchBox.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.panelSearchBox.Controls.Add(this.lblCariProduk);
            this.panelSearchBox.Controls.Add(this.txtCariProduk);
            this.panelSearchBox.Location = new System.Drawing.Point(20, 20);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(580, 60);
            this.panelSearchBox.TabIndex = 0;

            // lblCariProduk - Text Hijau Tua
            this.lblCariProduk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCariProduk.ForeColor = System.Drawing.Color.FromArgb(51, 105, 30);
            this.lblCariProduk.Location = new System.Drawing.Point(15, 8);
            this.lblCariProduk.Name = "lblCariProduk";
            this.lblCariProduk.Size = new System.Drawing.Size(150, 25);
            this.lblCariProduk.Text = "🔍 Cari Produk";

            // txtCariProduk
            this.txtCariProduk.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.txtCariProduk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCariProduk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCariProduk.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtCariProduk.Location = new System.Drawing.Point(20, 33);
            this.txtCariProduk.Name = "txtCariProduk";
            this.txtCariProduk.Size = new System.Drawing.Size(545, 20);
            this.txtCariProduk.TabIndex = 0;
            this.txtCariProduk.TextChanged += new System.EventHandler(this.txtCariProduk_TextChanged);

            // dgvProduk
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduk.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(102, 187, 106); // Header Hijau
            this.dgvProduk.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduk.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProduk.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(102, 187, 106);
            this.dgvProduk.EnableHeadersVisualStyles = false;
            this.dgvProduk.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 237, 200); // Highlight Mint
            this.dgvProduk.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduk.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProduk.GridColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.dgvProduk.Location = new System.Drawing.Point(20, 95);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.RowHeadersVisible = false;
            this.dgvProduk.RowTemplate.Height = 35;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(580, 440);
            this.dgvProduk.TabIndex = 1;
            this.dgvProduk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellDoubleClick);

            // lblTotalProduk
            this.lblTotalProduk.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.lblTotalProduk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduk.ForeColor = System.Drawing.Color.FromArgb(85, 139, 47);
            this.lblTotalProduk.Location = new System.Drawing.Point(20, 545);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblTotalProduk.Size = new System.Drawing.Size(200, 30);
            this.lblTotalProduk.Text = "📦 0 produk tersedia";

            // panelQuantityBox
            this.panelQuantityBox.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.panelQuantityBox.Controls.Add(this.lblQuantity);
            this.panelQuantityBox.Controls.Add(this.numQuantity);
            this.panelQuantityBox.Location = new System.Drawing.Point(20, 585);
            this.panelQuantityBox.Name = "panelQuantityBox";
            this.panelQuantityBox.Size = new System.Drawing.Size(220, 50);
            this.panelQuantityBox.TabIndex = 2;

            // numQuantity
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numQuantity.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.numQuantity.Location = new System.Drawing.Point(110, 10);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(95, 29);

            // lblQuantity
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblQuantity.Location = new System.Drawing.Point(5, 12);
            this.lblQuantity.Text = "Qty:";

            // btnTambahKeranjang - Accent Color (Harvest Orange)
            this.btnTambahKeranjang.BackColor = System.Drawing.Color.FromArgb(255, 167, 38); // Oranye Panen
            this.btnTambahKeranjang.FlatAppearance.BorderSize = 0;
            this.btnTambahKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKeranjang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTambahKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnTambahKeranjang.Location = new System.Drawing.Point(260, 585);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.Size = new System.Drawing.Size(340, 50);
            this.btnTambahKeranjang.Text = "➕ TAMBAH (F1)";
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);

            // ============================================
            // PANEL KERANJANG (Center)
            // ============================================
            this.panelKeranjang.BackColor = System.Drawing.Color.White;
            this.panelKeranjang.Controls.Add(this.btnHapusItem);
            this.panelKeranjang.Controls.Add(this.lblJumlahItem);
            this.panelKeranjang.Controls.Add(this.dgvKeranjang);
            this.panelKeranjang.Controls.Add(this.lblKeranjangTitle);
            this.panelKeranjang.Location = new System.Drawing.Point(660, 100);
            this.panelKeranjang.Name = "panelKeranjang";
            this.panelKeranjang.Size = new System.Drawing.Size(480, 420);
            this.panelKeranjang.TabIndex = 2;

            // lblKeranjangTitle - Accent Color
            this.lblKeranjangTitle.BackColor = System.Drawing.Color.FromArgb(255, 167, 38); // Oranye Panen
            this.lblKeranjangTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblKeranjangTitle.ForeColor = System.Drawing.Color.White;
            this.lblKeranjangTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKeranjangTitle.Name = "lblKeranjangTitle";
            this.lblKeranjangTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblKeranjangTitle.Size = new System.Drawing.Size(480, 50);
            this.lblKeranjangTitle.Text = "🛒 Keranjang Belanja";
            this.lblKeranjangTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dgvKeranjang
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKeranjang.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            this.dgvKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKeranjang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvKeranjang.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 224, 178); // Oranye Sangat Muda
            this.dgvKeranjang.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKeranjang.EnableHeadersVisualStyles = false;
            this.dgvKeranjang.Location = new System.Drawing.Point(20, 65);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.RowHeadersVisible = false;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(440, 280);

            // lblJumlahItem
            this.lblJumlahItem.BackColor = System.Drawing.Color.FromArgb(255, 243, 224); // Cream Oranye
            this.lblJumlahItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlahItem.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.lblJumlahItem.Location = new System.Drawing.Point(20, 360);
            this.lblJumlahItem.Name = "lblJumlahItem";
            this.lblJumlahItem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblJumlahItem.Size = new System.Drawing.Size(270, 40);
            this.lblJumlahItem.Text = "📋 0 item (0 pcs)";
            this.lblJumlahItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnHapusItem - Soft Red
            this.btnHapusItem.BackColor = System.Drawing.Color.FromArgb(239, 83, 80); // Merah Lembut
            this.btnHapusItem.FlatAppearance.BorderSize = 0;
            this.btnHapusItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHapusItem.ForeColor = System.Drawing.Color.White;
            this.btnHapusItem.Location = new System.Drawing.Point(305, 360);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(155, 40);
            this.btnHapusItem.Text = "🗑️ Hapus";
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);

            // ============================================
            // PANEL CHECKOUT (Right)
            // ============================================
            this.panelCheckout.BackColor = System.Drawing.Color.White;
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
            this.panelCheckout.Location = new System.Drawing.Point(660, 540);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(480, 290);
            this.panelCheckout.TabIndex = 3;

            // lblNamaPelanggan
            this.lblNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNamaPelanggan.Location = new System.Drawing.Point(20, 15);
            this.lblNamaPelanggan.Text = "👤 Nama Pelanggan";

            // txtNamaPelanggan
            this.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaPelanggan.Location = new System.Drawing.Point(20, 35);
            this.txtNamaPelanggan.Size = new System.Drawing.Size(440, 25);
            this.txtNamaPelanggan.TabIndex = 0;

            // lblTotalLabel
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTotalLabel.Location = new System.Drawing.Point(20, 70);
            this.lblTotalLabel.Text = "💰 TOTAL";

            // lblTotal - Highlight Price (Deep Orange)
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0); // Oranye Tua
            this.lblTotal.Location = new System.Drawing.Point(20, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblTotal.Size = new System.Drawing.Size(440, 50);
            this.lblTotal.Text = "Rp 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtJumlahBayar
            this.txtJumlahBayar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtJumlahBayar.Location = new System.Drawing.Point(20, 175);
            this.txtJumlahBayar.Size = new System.Drawing.Size(200, 29);
            this.txtJumlahBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJumlahBayar.TextChanged += new System.EventHandler(this.txtJumlahBayar_TextChanged);
            this.txtJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBayar_KeyPress);

            // lblJumlahBayarLabel
            this.lblJumlahBayarLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlahBayarLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblJumlahBayarLabel.Location = new System.Drawing.Point(20, 150);
            this.lblJumlahBayarLabel.Text = "💵 Bayar";

            // lblKembalianLabel
            this.lblKembalianLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKembalianLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKembalianLabel.Location = new System.Drawing.Point(240, 150);
            this.lblKembalianLabel.Text = "↩️ Kembalian";

            // lblKembalian - Success Highlight (Soft Green Background)
            this.lblKembalian.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.lblKembalian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(51, 105, 30); // Hijau Tua
            this.lblKembalian.Location = new System.Drawing.Point(240, 175);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(220, 29);
            this.lblKembalian.Text = "Rp 0";
            this.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnProses - Main Action (Deep Green)
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(67, 160, 71); // Hijau Agri Kuat
            this.btnProses.FlatAppearance.BorderSize = 0;
            this.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProses.ForeColor = System.Drawing.Color.White;
            this.btnProses.Location = new System.Drawing.Point(140, 230);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(320, 45);
            this.btnProses.Text = "✅ SELESAI & CETAK";
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);

            // btnBatalTransaksi
            this.btnBatalTransaksi.BackColor = System.Drawing.Color.White;
            this.btnBatalTransaksi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 83, 80);
            this.btnBatalTransaksi.FlatAppearance.BorderSize = 2;
            this.btnBatalTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatalTransaksi.ForeColor = System.Drawing.Color.FromArgb(239, 83, 80);
            this.btnBatalTransaksi.Location = new System.Drawing.Point(20, 230);
            this.btnBatalTransaksi.Name = "btnBatalTransaksi";
            this.btnBatalTransaksi.Size = new System.Drawing.Size(100, 45);
            this.btnBatalTransaksi.Text = "❌ Batal";
            this.btnBatalTransaksi.Click += new System.EventHandler(this.btnBatalTransaksi_Click);

            // Form Background - Mint Cream (Very Soft)
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 245, 236); // Mint Cream Background
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelCheckout);
            this.Controls.Add(this.panelKeranjang);
            this.Controls.Add(this.panelProduk);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.Name = "FormPointOfSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgriMart - Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPointOfSale_Load);

            this.panelTop.ResumeLayout(false);
            this.panelProduk.ResumeLayout(false);
            this.panelProduk.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            this.panelQuantityBox.ResumeLayout(false);
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
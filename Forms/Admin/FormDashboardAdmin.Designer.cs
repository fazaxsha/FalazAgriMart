namespace FalazAgriMart.Forms.Admin
{
    partial class FormDashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Button btnManajemenProduk;
        private System.Windows.Forms.Button btnManajemenPegawai;
        private System.Windows.Forms.Button btnManajemenSupplier;
        private System.Windows.Forms.Button btnManajemenKategori;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnLaporanKeuangan;
        private System.Windows.Forms.Button btnCekStok;
        private System.Windows.Forms.Button btnUbahPassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelStatistik1;
        private System.Windows.Forms.Panel panelStatistik2;
        private System.Windows.Forms.Panel panelStatistik3;
        private System.Windows.Forms.Panel panelStatistik4;
        private System.Windows.Forms.Label lblTotalProduk;
        private System.Windows.Forms.Label lblTotalPegawai;
        private System.Windows.Forms.Label lblTotalTransaksi;
        private System.Windows.Forms.Label lblTotalPendapatan;
        private System.Windows.Forms.Label lblStatTitle1;
        private System.Windows.Forms.Label lblStatTitle2;
        private System.Windows.Forms.Label lblStatTitle3;
        private System.Windows.Forms.Label lblStatTitle4;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnManajemenProduk = new System.Windows.Forms.Button();
            this.btnManajemenPegawai = new System.Windows.Forms.Button();
            this.btnManajemenSupplier = new System.Windows.Forms.Button();
            this.btnManajemenKategori = new System.Windows.Forms.Button();
            this.btnRiwayatTransaksi = new System.Windows.Forms.Button();
            this.btnLaporanKeuangan = new System.Windows.Forms.Button();
            this.btnCekStok = new System.Windows.Forms.Button();
            this.btnUbahPassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelStatistik1 = new System.Windows.Forms.Panel();
            this.lblStatTitle1 = new System.Windows.Forms.Label();
            this.lblTotalProduk = new System.Windows.Forms.Label();
            this.panelStatistik2 = new System.Windows.Forms.Panel();
            this.lblStatTitle2 = new System.Windows.Forms.Label();
            this.lblTotalPegawai = new System.Windows.Forms.Label();
            this.panelStatistik3 = new System.Windows.Forms.Panel();
            this.lblStatTitle3 = new System.Windows.Forms.Label();
            this.lblTotalTransaksi = new System.Windows.Forms.Label();
            this.panelStatistik4 = new System.Windows.Forms.Panel();
            this.lblStatTitle4 = new System.Windows.Forms.Label();
            this.lblTotalPendapatan = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelStatistik1.SuspendLayout();
            this.panelStatistik2.SuspendLayout();
            this.panelStatistik3.SuspendLayout();
            this.panelStatistik4.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.lblLoginTime);
            this.panelHeader.Controls.Add(this.lblRole);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 80);
            this.panelHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌾 FALAZ AgriMart";

            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat Datang, Admin!";

            // lblRole
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(900, 20);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(280, 25);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role: Administrator";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // lblLoginTime
            this.lblLoginTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginTime.ForeColor = System.Drawing.Color.White;
            this.lblLoginTime.Location = new System.Drawing.Point(900, 45);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(280, 25);
            this.lblLoginTime.TabIndex = 3;
            this.lblLoginTime.Text = "Login: 01/01/2025 08:00";
            this.lblLoginTime.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(750, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnUbahPassword);
            this.panelSidebar.Controls.Add(this.btnCekStok);
            this.panelSidebar.Controls.Add(this.btnLaporanKeuangan);
            this.panelSidebar.Controls.Add(this.btnRiwayatTransaksi);
            this.panelSidebar.Controls.Add(this.btnManajemenKategori);
            this.panelSidebar.Controls.Add(this.btnManajemenSupplier);
            this.panelSidebar.Controls.Add(this.btnManajemenPegawai);
            this.panelSidebar.Controls.Add(this.btnManajemenProduk);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 80);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 620);
            this.panelSidebar.TabIndex = 1;

            // Buttons Sidebar
            int yPosition = 20;
            int buttonHeight = 50;
            int spacing = 10;

            // btnManajemenProduk
            this.btnManajemenProduk.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnManajemenProduk.FlatAppearance.BorderSize = 0;
            this.btnManajemenProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenProduk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManajemenProduk.ForeColor = System.Drawing.Color.White;
            this.btnManajemenProduk.Location = new System.Drawing.Point(10, yPosition);
            this.btnManajemenProduk.Name = "btnManajemenProduk";
            this.btnManajemenProduk.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnManajemenProduk.TabIndex = 0;
            this.btnManajemenProduk.Text = "📦 Manajemen Produk";
            this.btnManajemenProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemenProduk.UseVisualStyleBackColor = false;
            this.btnManajemenProduk.Click += new System.EventHandler(this.btnManajemenProduk_Click);
            yPosition += buttonHeight + spacing;

            // btnManajemenPegawai
            this.btnManajemenPegawai.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnManajemenPegawai.FlatAppearance.BorderSize = 0;
            this.btnManajemenPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenPegawai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManajemenPegawai.ForeColor = System.Drawing.Color.White;
            this.btnManajemenPegawai.Location = new System.Drawing.Point(10, yPosition);
            this.btnManajemenPegawai.Name = "btnManajemenPegawai";
            this.btnManajemenPegawai.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnManajemenPegawai.TabIndex = 1;
            this.btnManajemenPegawai.Text = "👥 Manajemen Pegawai";
            this.btnManajemenPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemenPegawai.UseVisualStyleBackColor = false;
            this.btnManajemenPegawai.Click += new System.EventHandler(this.btnManajemenPegawai_Click);
            yPosition += buttonHeight + spacing;

            // btnManajemenSupplier
            this.btnManajemenSupplier.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnManajemenSupplier.FlatAppearance.BorderSize = 0;
            this.btnManajemenSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManajemenSupplier.ForeColor = System.Drawing.Color.White;
            this.btnManajemenSupplier.Location = new System.Drawing.Point(10, yPosition);
            this.btnManajemenSupplier.Name = "btnManajemenSupplier";
            this.btnManajemenSupplier.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnManajemenSupplier.TabIndex = 2;
            this.btnManajemenSupplier.Text = "🚚 Manajemen Supplier";
            this.btnManajemenSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemenSupplier.UseVisualStyleBackColor = false;
            this.btnManajemenSupplier.Click += new System.EventHandler(this.btnManajemenSupplier_Click);
            yPosition += buttonHeight + spacing;

            // btnManajemenKategori
            this.btnManajemenKategori.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnManajemenKategori.FlatAppearance.BorderSize = 0;
            this.btnManajemenKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManajemenKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManajemenKategori.ForeColor = System.Drawing.Color.White;
            this.btnManajemenKategori.Location = new System.Drawing.Point(10, yPosition);
            this.btnManajemenKategori.Name = "btnManajemenKategori";
            this.btnManajemenKategori.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnManajemenKategori.TabIndex = 3;
            this.btnManajemenKategori.Text = "📋 Manajemen Kategori";
            this.btnManajemenKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManajemenKategori.UseVisualStyleBackColor = false;
            this.btnManajemenKategori.Click += new System.EventHandler(this.btnManajemenKategori_Click);
            yPosition += buttonHeight + spacing;

            // btnRiwayatTransaksi
            this.btnRiwayatTransaksi.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnRiwayatTransaksi.FlatAppearance.BorderSize = 0;
            this.btnRiwayatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayatTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRiwayatTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnRiwayatTransaksi.Location = new System.Drawing.Point(10, yPosition);
            this.btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            this.btnRiwayatTransaksi.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnRiwayatTransaksi.TabIndex = 4;
            this.btnRiwayatTransaksi.Text = "📜 Riwayat Transaksi";
            this.btnRiwayatTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            this.btnRiwayatTransaksi.Click += new System.EventHandler(this.btnRiwayatTransaksi_Click);
            yPosition += buttonHeight + spacing;

            // btnLaporanKeuangan
            this.btnLaporanKeuangan.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnLaporanKeuangan.FlatAppearance.BorderSize = 0;
            this.btnLaporanKeuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporanKeuangan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLaporanKeuangan.ForeColor = System.Drawing.Color.White;
            this.btnLaporanKeuangan.Location = new System.Drawing.Point(10, yPosition);
            this.btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            this.btnLaporanKeuangan.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnLaporanKeuangan.TabIndex = 5;
            this.btnLaporanKeuangan.Text = "💰 Laporan Keuangan";
            this.btnLaporanKeuangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporanKeuangan.UseVisualStyleBackColor = false;
            this.btnLaporanKeuangan.Click += new System.EventHandler(this.btnLaporanKeuangan_Click);
            yPosition += buttonHeight + spacing;

            // btnCekStok
            this.btnCekStok.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCekStok.FlatAppearance.BorderSize = 0;
            this.btnCekStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekStok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCekStok.ForeColor = System.Drawing.Color.White;
            this.btnCekStok.Location = new System.Drawing.Point(10, yPosition);
            this.btnCekStok.Name = "btnCekStok";
            this.btnCekStok.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnCekStok.TabIndex = 6;
            this.btnCekStok.Text = "📊 Cek Stok Produk";
            this.btnCekStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCekStok.UseVisualStyleBackColor = false;
            this.btnCekStok.Click += new System.EventHandler(this.btnCekStok_Click);
            yPosition += buttonHeight + spacing;

            // btnUbahPassword
            this.btnUbahPassword.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnUbahPassword.FlatAppearance.BorderSize = 0;
            this.btnUbahPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUbahPassword.ForeColor = System.Drawing.Color.White;
            this.btnUbahPassword.Location = new System.Drawing.Point(10, yPosition);
            this.btnUbahPassword.Name = "btnUbahPassword";
            this.btnUbahPassword.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnUbahPassword.TabIndex = 7;
            this.btnUbahPassword.Text = "🔒 Ubah Password";
            this.btnUbahPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbahPassword.UseVisualStyleBackColor = false;
            this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
            yPosition += buttonHeight + spacing;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, buttonHeight);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.panelContent.Controls.Add(this.panelStatistik4);
            this.panelContent.Controls.Add(this.panelStatistik3);
            this.panelContent.Controls.Add(this.panelStatistik2);
            this.panelContent.Controls.Add(this.panelStatistik1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(950, 620);
            this.panelContent.TabIndex = 2;

            // Statistik Panels
            int panelWidth = 200;
            int panelHeight = 120;
            int startX = 50;
            int startY = 50;
            int gap = 30;

            // panelStatistik1 - Total Produk
            this.panelStatistik1.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.panelStatistik1.Controls.Add(this.lblTotalProduk);
            this.panelStatistik1.Controls.Add(this.lblStatTitle1);
            this.panelStatistik1.Location = new System.Drawing.Point(startX, startY);
            this.panelStatistik1.Name = "panelStatistik1";
            this.panelStatistik1.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelStatistik1.TabIndex = 0;

            this.lblStatTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle1.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle1.Location = new System.Drawing.Point(10, 15);
            this.lblStatTitle1.Name = "lblStatTitle1";
            this.lblStatTitle1.Size = new System.Drawing.Size(180, 25);
            this.lblStatTitle1.TabIndex = 0;
            this.lblStatTitle1.Text = "Total Produk";

            this.lblTotalProduk.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduk.ForeColor = System.Drawing.Color.White;
            this.lblTotalProduk.Location = new System.Drawing.Point(10, 50);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Size = new System.Drawing.Size(180, 50);
            this.lblTotalProduk.TabIndex = 1;
            this.lblTotalProduk.Text = "0";
            this.lblTotalProduk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelStatistik2 - Total Pegawai
            this.panelStatistik2.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.panelStatistik2.Controls.Add(this.lblTotalPegawai);
            this.panelStatistik2.Controls.Add(this.lblStatTitle2);
            this.panelStatistik2.Location = new System.Drawing.Point(startX + panelWidth + gap, startY);
            this.panelStatistik2.Name = "panelStatistik2";
            this.panelStatistik2.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelStatistik2.TabIndex = 1;

            this.lblStatTitle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle2.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle2.Location = new System.Drawing.Point(10, 15);
            this.lblStatTitle2.Name = "lblStatTitle2";
            this.lblStatTitle2.Size = new System.Drawing.Size(180, 25);
            this.lblStatTitle2.TabIndex = 0;
            this.lblStatTitle2.Text = "Total Pegawai";

            this.lblTotalPegawai.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalPegawai.ForeColor = System.Drawing.Color.White;
            this.lblTotalPegawai.Location = new System.Drawing.Point(10, 50);
            this.lblTotalPegawai.Name = "lblTotalPegawai";
            this.lblTotalPegawai.Size = new System.Drawing.Size(180, 50);
            this.lblTotalPegawai.TabIndex = 1;
            this.lblTotalPegawai.Text = "0";
            this.lblTotalPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelStatistik3 - Total Transaksi Hari Ini
            this.panelStatistik3.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.panelStatistik3.Controls.Add(this.lblTotalTransaksi);
            this.panelStatistik3.Controls.Add(this.lblStatTitle3);
            this.panelStatistik3.Location = new System.Drawing.Point(startX + (panelWidth + gap) * 2, startY);
            this.panelStatistik3.Name = "panelStatistik3";
            this.panelStatistik3.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelStatistik3.TabIndex = 2;

            this.lblStatTitle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle3.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle3.Location = new System.Drawing.Point(10, 15);
            this.lblStatTitle3.Name = "lblStatTitle3";
            this.lblStatTitle3.Size = new System.Drawing.Size(180, 25);
            this.lblStatTitle3.TabIndex = 0;
            this.lblStatTitle3.Text = "Transaksi Hari Ini";

            this.lblTotalTransaksi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransaksi.ForeColor = System.Drawing.Color.White;
            this.lblTotalTransaksi.Location = new System.Drawing.Point(10, 50);
            this.lblTotalTransaksi.Name = "lblTotalTransaksi";
            this.lblTotalTransaksi.Size = new System.Drawing.Size(180, 50);
            this.lblTotalTransaksi.TabIndex = 1;
            this.lblTotalTransaksi.Text = "0";
            this.lblTotalTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelStatistik4 - Total Pendapatan Hari Ini
            this.panelStatistik4.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.panelStatistik4.Controls.Add(this.lblTotalPendapatan);
            this.panelStatistik4.Controls.Add(this.lblStatTitle4);
            this.panelStatistik4.Location = new System.Drawing.Point(startX + (panelWidth + gap) * 3, startY);
            this.panelStatistik4.Name = "panelStatistik4";
            this.panelStatistik4.Size = new System.Drawing.Size(panelWidth, panelHeight);
            this.panelStatistik4.TabIndex = 3;

            this.lblStatTitle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle4.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle4.Location = new System.Drawing.Point(10, 15);
            this.lblStatTitle4.Name = "lblStatTitle4";
            this.lblStatTitle4.Size = new System.Drawing.Size(180, 25);
            this.lblStatTitle4.TabIndex = 0;
            this.lblStatTitle4.Text = "Pendapatan Hari Ini";

            this.lblTotalPendapatan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPendapatan.ForeColor = System.Drawing.Color.White;
            this.lblTotalPendapatan.Location = new System.Drawing.Point(10, 50);
            this.lblTotalPendapatan.Name = "lblTotalPendapatan";
            this.lblTotalPendapatan.Size = new System.Drawing.Size(180, 50);
            this.lblTotalPendapatan.TabIndex = 1;
            this.lblTotalPendapatan.Text = "Rp 0";
            this.lblTotalPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormDashboardAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormDashboardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin - FALAZ AgriMart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboardAdmin_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelStatistik1.ResumeLayout(false);
            this.panelStatistik2.ResumeLayout(false);
            this.panelStatistik3.ResumeLayout(false);
            this.panelStatistik4.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
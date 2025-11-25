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
            panelHeader = new Panel();
            btnRefresh = new Button();
            lblLoginTime = new Label();
            lblRole = new Label();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnUbahPassword = new Button();
            btnCekStok = new Button();
            btnLaporanKeuangan = new Button();
            btnRiwayatTransaksi = new Button();
            btnManajemenKategori = new Button();
            btnManajemenSupplier = new Button();
            btnManajemenPegawai = new Button();
            btnManajemenProduk = new Button();
            panelContent = new Panel();
            panelStatistik4 = new Panel();
            lblTotalPendapatan = new Label();
            lblStatTitle4 = new Label();
            panelStatistik3 = new Panel();
            lblTotalTransaksi = new Label();
            lblStatTitle3 = new Label();
            panelStatistik2 = new Panel();
            lblTotalPegawai = new Label();
            lblStatTitle2 = new Label();
            panelStatistik1 = new Panel();
            lblTotalProduk = new Label();
            lblStatTitle1 = new Label();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            panelStatistik4.SuspendLayout();
            panelStatistik3.SuspendLayout();
            panelStatistik2.SuspendLayout();
            panelStatistik1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(46, 125, 50);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(lblLoginTime);
            panelHeader.Controls.Add(lblRole);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1400, 92);
            panelHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(56, 142, 60);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(875, 29);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblLoginTime
            // 
            lblLoginTime.Font = new Font("Segoe UI", 9F);
            lblLoginTime.ForeColor = Color.White;
            lblLoginTime.Location = new Point(1050, 52);
            lblLoginTime.Margin = new Padding(4, 0, 4, 0);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(327, 29);
            lblLoginTime.TabIndex = 3;
            lblLoginTime.Text = "Login: 01/01/2025 08:00";
            lblLoginTime.TextAlign = ContentAlignment.TopRight;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(1050, 23);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(327, 29);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role: Administrator";
            lblRole.TextAlign = ContentAlignment.TopRight;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(23, 58);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(467, 29);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Selamat Datang, Admin!";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 12);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🌱 FALAZ AgriMart";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 94, 32);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnUbahPassword);
            panelSidebar.Controls.Add(btnCekStok);
            panelSidebar.Controls.Add(btnLaporanKeuangan);
            panelSidebar.Controls.Add(btnRiwayatTransaksi);
            panelSidebar.Controls.Add(btnManajemenKategori);
            panelSidebar.Controls.Add(btnManajemenSupplier);
            panelSidebar.Controls.Add(btnManajemenPegawai);
            panelSidebar.Controls.Add(btnManajemenProduk);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 92);
            panelSidebar.Margin = new Padding(4, 3, 4, 3);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(292, 716);
            panelSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(211, 47, 47);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 635);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(268, 58);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUbahPassword
            // 
            btnUbahPassword.BackColor = Color.FromArgb(46, 125, 50);
            btnUbahPassword.FlatAppearance.BorderSize = 0;
            btnUbahPassword.FlatStyle = FlatStyle.Flat;
            btnUbahPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUbahPassword.ForeColor = Color.White;
            btnUbahPassword.Location = new Point(12, 508);
            btnUbahPassword.Margin = new Padding(4, 3, 4, 3);
            btnUbahPassword.Name = "btnUbahPassword";
            btnUbahPassword.Size = new Size(268, 58);
            btnUbahPassword.TabIndex = 7;
            btnUbahPassword.Text = "🔒 Ubah Password";
            btnUbahPassword.TextAlign = ContentAlignment.MiddleLeft;
            btnUbahPassword.UseVisualStyleBackColor = false;
            btnUbahPassword.Click += btnUbahPassword_Click;
            // 
            // btnCekStok
            // 
            btnCekStok.BackColor = Color.FromArgb(46, 125, 50);
            btnCekStok.FlatAppearance.BorderSize = 0;
            btnCekStok.FlatStyle = FlatStyle.Flat;
            btnCekStok.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCekStok.ForeColor = Color.White;
            btnCekStok.Location = new Point(12, 438);
            btnCekStok.Margin = new Padding(4, 3, 4, 3);
            btnCekStok.Name = "btnCekStok";
            btnCekStok.Size = new Size(268, 58);
            btnCekStok.TabIndex = 6;
            btnCekStok.Text = "📊 Cek Stok Produk";
            btnCekStok.TextAlign = ContentAlignment.MiddleLeft;
            btnCekStok.UseVisualStyleBackColor = false;
            btnCekStok.Click += btnCekStok_Click;
            // 
            // btnLaporanKeuangan
            // 
            btnLaporanKeuangan.BackColor = Color.FromArgb(46, 125, 50);
            btnLaporanKeuangan.FlatAppearance.BorderSize = 0;
            btnLaporanKeuangan.FlatStyle = FlatStyle.Flat;
            btnLaporanKeuangan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLaporanKeuangan.ForeColor = Color.White;
            btnLaporanKeuangan.Location = new Point(12, 369);
            btnLaporanKeuangan.Margin = new Padding(4, 3, 4, 3);
            btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            btnLaporanKeuangan.Size = new Size(268, 58);
            btnLaporanKeuangan.TabIndex = 5;
            btnLaporanKeuangan.Text = "💰 Laporan Keuangan";
            btnLaporanKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporanKeuangan.UseVisualStyleBackColor = false;
            btnLaporanKeuangan.Click += btnLaporanKeuangan_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.FromArgb(46, 125, 50);
            btnRiwayatTransaksi.FlatAppearance.BorderSize = 0;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Flat;
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRiwayatTransaksi.ForeColor = Color.White;
            btnRiwayatTransaksi.Location = new Point(12, 300);
            btnRiwayatTransaksi.Margin = new Padding(4, 3, 4, 3);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(268, 58);
            btnRiwayatTransaksi.TabIndex = 4;
            btnRiwayatTransaksi.Text = "📜 Riwayat Transaksi";
            btnRiwayatTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnManajemenKategori
            // 
            btnManajemenKategori.BackColor = Color.FromArgb(46, 125, 50);
            btnManajemenKategori.FlatAppearance.BorderSize = 0;
            btnManajemenKategori.FlatStyle = FlatStyle.Flat;
            btnManajemenKategori.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnManajemenKategori.ForeColor = Color.White;
            btnManajemenKategori.Location = new Point(12, 231);
            btnManajemenKategori.Margin = new Padding(4, 3, 4, 3);
            btnManajemenKategori.Name = "btnManajemenKategori";
            btnManajemenKategori.Size = new Size(268, 58);
            btnManajemenKategori.TabIndex = 3;
            btnManajemenKategori.Text = "📋 Manajemen Kategori";
            btnManajemenKategori.TextAlign = ContentAlignment.MiddleLeft;
            btnManajemenKategori.UseVisualStyleBackColor = false;
            btnManajemenKategori.Click += btnManajemenKategori_Click;
            // 
            // btnManajemenSupplier
            // 
            btnManajemenSupplier.BackColor = Color.FromArgb(46, 125, 50);
            btnManajemenSupplier.FlatAppearance.BorderSize = 0;
            btnManajemenSupplier.FlatStyle = FlatStyle.Flat;
            btnManajemenSupplier.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnManajemenSupplier.ForeColor = Color.White;
            btnManajemenSupplier.Location = new Point(12, 162);
            btnManajemenSupplier.Margin = new Padding(4, 3, 4, 3);
            btnManajemenSupplier.Name = "btnManajemenSupplier";
            btnManajemenSupplier.Size = new Size(268, 58);
            btnManajemenSupplier.TabIndex = 2;
            btnManajemenSupplier.Text = "🚚 Manajemen Supplier";
            btnManajemenSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnManajemenSupplier.UseVisualStyleBackColor = false;
            btnManajemenSupplier.Click += btnManajemenSupplier_Click;
            // 
            // btnManajemenPegawai
            // 
            btnManajemenPegawai.BackColor = Color.FromArgb(46, 125, 50);
            btnManajemenPegawai.FlatAppearance.BorderSize = 0;
            btnManajemenPegawai.FlatStyle = FlatStyle.Flat;
            btnManajemenPegawai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnManajemenPegawai.ForeColor = Color.White;
            btnManajemenPegawai.Location = new Point(12, 92);
            btnManajemenPegawai.Margin = new Padding(4, 3, 4, 3);
            btnManajemenPegawai.Name = "btnManajemenPegawai";
            btnManajemenPegawai.Size = new Size(268, 58);
            btnManajemenPegawai.TabIndex = 1;
            btnManajemenPegawai.Text = "👥 Manajemen Pegawai";
            btnManajemenPegawai.TextAlign = ContentAlignment.MiddleLeft;
            btnManajemenPegawai.UseVisualStyleBackColor = false;
            btnManajemenPegawai.Click += btnManajemenPegawai_Click;
            // 
            // btnManajemenProduk
            // 
            btnManajemenProduk.BackColor = Color.FromArgb(46, 125, 50);
            btnManajemenProduk.FlatAppearance.BorderSize = 0;
            btnManajemenProduk.FlatStyle = FlatStyle.Flat;
            btnManajemenProduk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnManajemenProduk.ForeColor = Color.White;
            btnManajemenProduk.Location = new Point(12, 23);
            btnManajemenProduk.Margin = new Padding(4, 3, 4, 3);
            btnManajemenProduk.Name = "btnManajemenProduk";
            btnManajemenProduk.Size = new Size(268, 58);
            btnManajemenProduk.TabIndex = 0;
            btnManajemenProduk.Text = "📦 Manajemen Produk";
            btnManajemenProduk.TextAlign = ContentAlignment.MiddleLeft;
            btnManajemenProduk.UseVisualStyleBackColor = false;
            btnManajemenProduk.Click += btnManajemenProduk_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(232, 245, 233);
            panelContent.Controls.Add(panelStatistik4);
            panelContent.Controls.Add(panelStatistik3);
            panelContent.Controls.Add(panelStatistik2);
            panelContent.Controls.Add(panelStatistik1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(292, 92);
            panelContent.Margin = new Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1108, 716);
            panelContent.TabIndex = 2;
            // 
            // panelStatistik4
            // 
            panelStatistik4.BackColor = Color.FromArgb(156, 39, 176);
            panelStatistik4.Controls.Add(lblTotalPendapatan);
            panelStatistik4.Controls.Add(lblStatTitle4);
            panelStatistik4.Location = new Point(412, 63);
            panelStatistik4.Margin = new Padding(4, 3, 4, 3);
            panelStatistik4.Name = "panelStatistik4";
            panelStatistik4.Size = new Size(233, 138);
            panelStatistik4.TabIndex = 3;
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPendapatan.ForeColor = Color.White;
            lblTotalPendapatan.Location = new Point(12, 58);
            lblTotalPendapatan.Margin = new Padding(4, 0, 4, 0);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(210, 58);
            lblTotalPendapatan.TabIndex = 1;
            lblTotalPendapatan.Text = "Rp 0";
            lblTotalPendapatan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatTitle4
            // 
            lblStatTitle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatTitle4.ForeColor = Color.White;
            lblStatTitle4.Location = new Point(45, 17);
            lblStatTitle4.Margin = new Padding(4, 0, 4, 0);
            lblStatTitle4.Name = "lblStatTitle4";
            lblStatTitle4.Size = new Size(143, 29);
            lblStatTitle4.TabIndex = 0;
            lblStatTitle4.Text = "Pendapatan Hari Ini";
            // 
            // panelStatistik3
            // 
            panelStatistik3.BackColor = Color.FromArgb(255, 152, 0);
            panelStatistik3.Controls.Add(lblTotalTransaksi);
            panelStatistik3.Controls.Add(lblStatTitle3);
            panelStatistik3.Location = new Point(125, 225);
            panelStatistik3.Margin = new Padding(4, 3, 4, 3);
            panelStatistik3.Name = "panelStatistik3";
            panelStatistik3.Size = new Size(233, 138);
            panelStatistik3.TabIndex = 2;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalTransaksi.ForeColor = Color.White;
            lblTotalTransaksi.Location = new Point(12, 58);
            lblTotalTransaksi.Margin = new Padding(4, 0, 4, 0);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(210, 58);
            lblTotalTransaksi.TabIndex = 1;
            lblTotalTransaksi.Text = "0";
            lblTotalTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatTitle3
            // 
            lblStatTitle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatTitle3.ForeColor = Color.White;
            lblStatTitle3.Location = new Point(54, 17);
            lblStatTitle3.Margin = new Padding(4, 0, 4, 0);
            lblStatTitle3.Name = "lblStatTitle3";
            lblStatTitle3.Size = new Size(124, 29);
            lblStatTitle3.TabIndex = 0;
            lblStatTitle3.Text = "Transaksi Hari Ini";
            // 
            // panelStatistik2
            // 
            panelStatistik2.BackColor = Color.FromArgb(76, 175, 80);
            panelStatistik2.Controls.Add(lblTotalPegawai);
            panelStatistik2.Controls.Add(lblStatTitle2);
            panelStatistik2.Location = new Point(412, 225);
            panelStatistik2.Margin = new Padding(4, 3, 4, 3);
            panelStatistik2.Name = "panelStatistik2";
            panelStatistik2.Size = new Size(233, 138);
            panelStatistik2.TabIndex = 1;
            // 
            // lblTotalPegawai
            // 
            lblTotalPegawai.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalPegawai.ForeColor = Color.White;
            lblTotalPegawai.Location = new Point(12, 58);
            lblTotalPegawai.Margin = new Padding(4, 0, 4, 0);
            lblTotalPegawai.Name = "lblTotalPegawai";
            lblTotalPegawai.Size = new Size(210, 58);
            lblTotalPegawai.TabIndex = 1;
            lblTotalPegawai.Text = "0";
            lblTotalPegawai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatTitle2
            // 
            lblStatTitle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatTitle2.ForeColor = Color.White;
            lblStatTitle2.Location = new Point(68, 17);
            lblStatTitle2.Margin = new Padding(4, 0, 4, 0);
            lblStatTitle2.Name = "lblStatTitle2";
            lblStatTitle2.Size = new Size(106, 29);
            lblStatTitle2.TabIndex = 0;
            lblStatTitle2.Text = "Total Pegawai";
            // 
            // panelStatistik1
            // 
            panelStatistik1.BackColor = Color.FromArgb(33, 150, 243);
            panelStatistik1.Controls.Add(lblTotalProduk);
            panelStatistik1.Controls.Add(lblStatTitle1);
            panelStatistik1.Location = new Point(125, 63);
            panelStatistik1.Margin = new Padding(4, 3, 4, 3);
            panelStatistik1.Name = "panelStatistik1";
            panelStatistik1.Size = new Size(233, 138);
            panelStatistik1.TabIndex = 0;
            // 
            // lblTotalProduk
            // 
            lblTotalProduk.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalProduk.ForeColor = Color.White;
            lblTotalProduk.Location = new Point(12, 58);
            lblTotalProduk.Margin = new Padding(4, 0, 4, 0);
            lblTotalProduk.Name = "lblTotalProduk";
            lblTotalProduk.Size = new Size(210, 58);
            lblTotalProduk.TabIndex = 1;
            lblTotalProduk.Text = "0";
            lblTotalProduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatTitle1
            // 
            lblStatTitle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatTitle1.ForeColor = Color.White;
            lblStatTitle1.Location = new Point(69, 17);
            lblStatTitle1.Margin = new Padding(4, 0, 4, 0);
            lblStatTitle1.Name = "lblStatTitle1";
            lblStatTitle1.Size = new Size(96, 29);
            lblStatTitle1.TabIndex = 0;
            lblStatTitle1.Text = "Total Produk";
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 808);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Admin - FALAZ AgriMart";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormDashboardAdmin_FormClosing;
            Load += FormDashboardAdmin_Load;
            panelHeader.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelStatistik4.ResumeLayout(false);
            panelStatistik3.ResumeLayout(false);
            panelStatistik2.ResumeLayout(false);
            panelStatistik1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
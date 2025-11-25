namespace FalazAgriMart.Forms.Pegawai
{
    partial class FormDashboardPegawai
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Button btnPointOfSale;
        private System.Windows.Forms.Button btnCekStok;
        private System.Windows.Forms.Button btnRiwayatPribadi;
        private System.Windows.Forms.Button btnUbahPassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelStatistik1;
        private System.Windows.Forms.Panel panelStatistik2;
        private System.Windows.Forms.Label lblTotalTransaksiSaya;
        private System.Windows.Forms.Label lblTotalPenjualanSaya;
        private System.Windows.Forms.Label lblStatTitle1;
        private System.Windows.Forms.Label lblStatTitle2;
        private System.Windows.Forms.Label lblInfo;

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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUbahPassword = new System.Windows.Forms.Button();
            this.btnRiwayatPribadi = new System.Windows.Forms.Button();
            this.btnCekStok = new System.Windows.Forms.Button();
            this.btnPointOfSale = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelStatistik2 = new System.Windows.Forms.Panel();
            this.lblTotalPenjualanSaya = new System.Windows.Forms.Label();
            this.lblStatTitle2 = new System.Windows.Forms.Label();
            this.panelStatistik1 = new System.Windows.Forms.Panel();
            this.lblTotalTransaksiSaya = new System.Windows.Forms.Label();
            this.lblStatTitle1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelStatistik2.SuspendLayout();
            this.panelStatistik1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
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
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌾 FALAZ AgriMart";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat Datang, Pegawai!";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(900, 20);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(280, 25);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role: Pegawai";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginTime.ForeColor = System.Drawing.Color.White;
            this.lblLoginTime.Location = new System.Drawing.Point(900, 45);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(280, 25);
            this.lblLoginTime.TabIndex = 3;
            this.lblLoginTime.Text = "Login: 01/01/2025 08:00";
            this.lblLoginTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
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
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnUbahPassword);
            this.panelSidebar.Controls.Add(this.btnRiwayatPribadi);
            this.panelSidebar.Controls.Add(this.btnCekStok);
            this.panelSidebar.Controls.Add(this.btnPointOfSale);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 80);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 620);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnPointOfSale
            // 
            this.btnPointOfSale.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnPointOfSale.FlatAppearance.BorderSize = 0;
            this.btnPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointOfSale.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPointOfSale.ForeColor = System.Drawing.Color.White;
            this.btnPointOfSale.Location = new System.Drawing.Point(10, 20);
            this.btnPointOfSale.Name = "btnPointOfSale";
            this.btnPointOfSale.Size = new System.Drawing.Size(230, 70);
            this.btnPointOfSale.TabIndex = 0;
            this.btnPointOfSale.Text = "🛒 KASIR\n(Point of Sale)";
            this.btnPointOfSale.UseVisualStyleBackColor = false;
            this.btnPointOfSale.Click += new System.EventHandler(this.btnPointOfSale_Click);
            // 
            // btnCekStok
            // 
            this.btnCekStok.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnCekStok.FlatAppearance.BorderSize = 0;
            this.btnCekStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekStok.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCekStok.ForeColor = System.Drawing.Color.White;
            this.btnCekStok.Location = new System.Drawing.Point(10, 120);
            this.btnCekStok.Name = "btnCekStok";
            this.btnCekStok.Size = new System.Drawing.Size(230, 50);
            this.btnCekStok.TabIndex = 1;
            this.btnCekStok.Text = "📊 Cek Stok Produk";
            this.btnCekStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCekStok.UseVisualStyleBackColor = false;
            this.btnCekStok.Click += new System.EventHandler(this.btnCekStok_Click);
            // 
            // btnRiwayatPribadi
            // 
            this.btnRiwayatPribadi.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnRiwayatPribadi.FlatAppearance.BorderSize = 0;
            this.btnRiwayatPribadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayatPribadi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRiwayatPribadi.ForeColor = System.Drawing.Color.White;
            this.btnRiwayatPribadi.Location = new System.Drawing.Point(10, 180);
            this.btnRiwayatPribadi.Name = "btnRiwayatPribadi";
            this.btnRiwayatPribadi.Size = new System.Drawing.Size(230, 50);
            this.btnRiwayatPribadi.TabIndex = 2;
            this.btnRiwayatPribadi.Text = "📜 Riwayat Pribadi";
            this.btnRiwayatPribadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatPribadi.UseVisualStyleBackColor = false;
            this.btnRiwayatPribadi.Click += new System.EventHandler(this.btnRiwayatPribadi_Click);
            // 
            // btnUbahPassword
            // 
            this.btnUbahPassword.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnUbahPassword.FlatAppearance.BorderSize = 0;
            this.btnUbahPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUbahPassword.ForeColor = System.Drawing.Color.White;
            this.btnUbahPassword.Location = new System.Drawing.Point(10, 240);
            this.btnUbahPassword.Name = "btnUbahPassword";
            this.btnUbahPassword.Size = new System.Drawing.Size(230, 50);
            this.btnUbahPassword.TabIndex = 3;
            this.btnUbahPassword.Text = "🔒 Ubah Password";
            this.btnUbahPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbahPassword.UseVisualStyleBackColor = false;
            this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(230, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.panelContent.Controls.Add(this.lblInfo);
            this.panelContent.Controls.Add(this.panelStatistik2);
            this.panelContent.Controls.Add(this.panelStatistik1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(950, 620);
            this.panelContent.TabIndex = 2;
            // 
            // panelStatistik1
            // 
            this.panelStatistik1.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.panelStatistik1.Controls.Add(this.lblTotalTransaksiSaya);
            this.panelStatistik1.Controls.Add(this.lblStatTitle1);
            this.panelStatistik1.Location = new System.Drawing.Point(100, 50);
            this.panelStatistik1.Name = "panelStatistik1";
            this.panelStatistik1.Size = new System.Drawing.Size(300, 120);
            this.panelStatistik1.TabIndex = 0;
            // 
            // lblStatTitle1
            // 
            this.lblStatTitle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle1.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle1.Location = new System.Drawing.Point(15, 15);
            this.lblStatTitle1.Name = "lblStatTitle1";
            this.lblStatTitle1.Size = new System.Drawing.Size(270, 25);
            this.lblStatTitle1.TabIndex = 0;
            this.lblStatTitle1.Text = "Transaksi Saya Hari Ini";
            // 
            // lblTotalTransaksiSaya
            // 
            this.lblTotalTransaksiSaya.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransaksiSaya.ForeColor = System.Drawing.Color.White;
            this.lblTotalTransaksiSaya.Location = new System.Drawing.Point(15, 50);
            this.lblTotalTransaksiSaya.Name = "lblTotalTransaksiSaya";
            this.lblTotalTransaksiSaya.Size = new System.Drawing.Size(270, 55);
            this.lblTotalTransaksiSaya.TabIndex = 1;
            this.lblTotalTransaksiSaya.Text = "0";
            this.lblTotalTransaksiSaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStatistik2
            // 
            this.panelStatistik2.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.panelStatistik2.Controls.Add(this.lblTotalPenjualanSaya);
            this.panelStatistik2.Controls.Add(this.lblStatTitle2);
            this.panelStatistik2.Location = new System.Drawing.Point(450, 50);
            this.panelStatistik2.Name = "panelStatistik2";
            this.panelStatistik2.Size = new System.Drawing.Size(300, 120);
            this.panelStatistik2.TabIndex = 1;
            // 
            // lblStatTitle2
            // 
            this.lblStatTitle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle2.ForeColor = System.Drawing.Color.White;
            this.lblStatTitle2.Location = new System.Drawing.Point(15, 15);
            this.lblStatTitle2.Name = "lblStatTitle2";
            this.lblStatTitle2.Size = new System.Drawing.Size(270, 25);
            this.lblStatTitle2.TabIndex = 0;
            this.lblStatTitle2.Text = "Penjualan Saya Hari Ini";
            // 
            // lblTotalPenjualanSaya
            // 
            this.lblTotalPenjualanSaya.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalPenjualanSaya.ForeColor = System.Drawing.Color.White;
            this.lblTotalPenjualanSaya.Location = new System.Drawing.Point(15, 50);
            this.lblTotalPenjualanSaya.Name = "lblTotalPenjualanSaya";
            this.lblTotalPenjualanSaya.Size = new System.Drawing.Size(270, 55);
            this.lblTotalPenjualanSaya.TabIndex = 1;
            this.lblTotalPenjualanSaya.Text = "Rp 0";
            this.lblTotalPenjualanSaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblInfo.Location = new System.Drawing.Point(100, 220);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(700, 200);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "💡 Tips:\n\n" +
                "• Klik tombol KASIR untuk melakukan transaksi penjualan\n" +
                "• Cek stok produk sebelum melakukan transaksi\n" +
                "• Riwayat transaksi Anda dapat dilihat di menu Riwayat Pribadi\n" +
                "• Jangan lupa logout setelah selesai bertugas";
            // 
            // FormDashboardPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormDashboardPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Pegawai - FALAZ AgriMart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboardPegawai_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboardPegawai_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelStatistik2.ResumeLayout(false);
            this.panelStatistik1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

    }
}
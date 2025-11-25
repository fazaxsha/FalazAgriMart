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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleProdukHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleProdukDefault = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleKeranjangHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleKeranjangDefault = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelProduk = new System.Windows.Forms.Panel();
            this.btnTambahKeranjang = new System.Windows.Forms.Button();
            this.panelQuantityBox = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTotalProduk = new System.Windows.Forms.Label();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblCariProduk = new System.Windows.Forms.Label();
            this.txtCariProduk = new System.Windows.Forms.TextBox();
            this.panelKeranjang = new System.Windows.Forms.Panel();
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.lblJumlahItem = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.lblKeranjangTitle = new System.Windows.Forms.Label();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.btnBatalTransaksi = new System.Windows.Forms.Button();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.lblKembalianLabel = new System.Windows.Forms.Label();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.lblJumlahBayarLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelProduk.SuspendLayout();
            this.panelQuantityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panelSearchBox.SuspendLayout();
            this.panelKeranjang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.panelCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(102, 187, 106);
            this.panelTop.Controls.Add(this.lblTanggal);
            this.panelTop.Controls.Add(this.lblKasir);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1400, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblTanggal
            // 
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.lblTanggal.Location = new System.Drawing.Point(1050, 45);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(320, 25);
            this.lblTanggal.TabIndex = 2;
            this.lblTanggal.Text = "📅 Tanggal: -";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKasir
            // 
            this.lblKasir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKasir.ForeColor = System.Drawing.Color.White;
            this.lblKasir.Location = new System.Drawing.Point(1050, 20);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(320, 25);
            this.lblKasir.TabIndex = 1;
            this.lblKasir.Text = "👤 Kasir: -";
            this.lblKasir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌱 AgriMart POS";
            // 
            // panelProduk
            // 
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
            // 
            // btnTambahKeranjang
            // 
            this.btnTambahKeranjang.BackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            this.btnTambahKeranjang.FlatAppearance.BorderSize = 0;
            this.btnTambahKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKeranjang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTambahKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnTambahKeranjang.Location = new System.Drawing.Point(260, 585);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.Size = new System.Drawing.Size(340, 50);
            this.btnTambahKeranjang.TabIndex = 4;
            this.btnTambahKeranjang.Text = "➕ TAMBAH (F1)";
            this.btnTambahKeranjang.UseVisualStyleBackColor = false;
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);
            // 
            // panelQuantityBox
            // 
            this.panelQuantityBox.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.panelQuantityBox.Controls.Add(this.lblQuantity);
            this.panelQuantityBox.Controls.Add(this.numQuantity);
            this.panelQuantityBox.Location = new System.Drawing.Point(20, 585);
            this.panelQuantityBox.Name = "panelQuantityBox";
            this.panelQuantityBox.Size = new System.Drawing.Size(220, 50);
            this.panelQuantityBox.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblQuantity.Location = new System.Drawing.Point(5, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(60, 23);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Qty:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numQuantity.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.numQuantity.Location = new System.Drawing.Point(110, 10);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(95, 29);
            this.numQuantity.TabIndex = 0;
            // 
            // lblTotalProduk
            // 
            this.lblTotalProduk.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.lblTotalProduk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduk.ForeColor = System.Drawing.Color.FromArgb(85, 139, 47);
            this.lblTotalProduk.Location = new System.Drawing.Point(20, 545);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblTotalProduk.Size = new System.Drawing.Size(200, 30);
            this.lblTotalProduk.TabIndex = 2;
            this.lblTotalProduk.Text = "📦 0 produk tersedia";
            // 
            // dgvProduk
            // 
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyleProdukHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleProdukHeader.BackColor = System.Drawing.Color.FromArgb(102, 187, 106);
            dataGridViewCellStyleProdukHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleProdukHeader.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleProdukHeader.SelectionBackColor = System.Drawing.Color.FromArgb(102, 187, 106);
            dataGridViewCellStyleProdukHeader.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleProdukHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleProdukHeader;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyleProdukDefault.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleProdukDefault.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyleProdukDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleProdukDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyleProdukDefault.SelectionBackColor = System.Drawing.Color.FromArgb(220, 237, 200);
            dataGridViewCellStyleProdukDefault.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleProdukDefault.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduk.DefaultCellStyle = dataGridViewCellStyleProdukDefault;
            this.dgvProduk.EnableHeadersVisualStyles = false;
            this.dgvProduk.GridColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.dgvProduk.Location = new System.Drawing.Point(20, 95);
            this.dgvProduk.MultiSelect = false;
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.RowHeadersVisible = false;
            this.dgvProduk.RowTemplate.Height = 35;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(580, 440);
            this.dgvProduk.TabIndex = 1;
            this.dgvProduk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellDoubleClick);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.panelSearchBox.Controls.Add(this.lblCariProduk);
            this.panelSearchBox.Controls.Add(this.txtCariProduk);
            this.panelSearchBox.Location = new System.Drawing.Point(20, 20);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(580, 60);
            this.panelSearchBox.TabIndex = 0;
            // 
            // lblCariProduk
            // 
            this.lblCariProduk.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCariProduk.ForeColor = System.Drawing.Color.FromArgb(51, 105, 30);
            this.lblCariProduk.Location = new System.Drawing.Point(15, 8);
            this.lblCariProduk.Name = "lblCariProduk";
            this.lblCariProduk.Size = new System.Drawing.Size(150, 25);
            this.lblCariProduk.TabIndex = 0;
            this.lblCariProduk.Text = "🔍 Cari Produk";
            // 
            // txtCariProduk
            // 
            this.txtCariProduk.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.txtCariProduk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCariProduk.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCariProduk.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtCariProduk.Location = new System.Drawing.Point(20, 33);
            this.txtCariProduk.Name = "txtCariProduk";
            this.txtCariProduk.Size = new System.Drawing.Size(545, 20);
            this.txtCariProduk.TabIndex = 0;
            this.txtCariProduk.TextChanged += new System.EventHandler(this.txtCariProduk_TextChanged);
            // 
            // panelKeranjang
            // 
            this.panelKeranjang.BackColor = System.Drawing.Color.White;
            this.panelKeranjang.Controls.Add(this.btnHapusItem);
            this.panelKeranjang.Controls.Add(this.lblJumlahItem);
            this.panelKeranjang.Controls.Add(this.dgvKeranjang);
            this.panelKeranjang.Controls.Add(this.lblKeranjangTitle);
            this.panelKeranjang.Location = new System.Drawing.Point(660, 100);
            this.panelKeranjang.Name = "panelKeranjang";
            this.panelKeranjang.Size = new System.Drawing.Size(480, 420);
            this.panelKeranjang.TabIndex = 2;
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.BackColor = System.Drawing.Color.FromArgb(239, 83, 80);
            this.btnHapusItem.FlatAppearance.BorderSize = 0;
            this.btnHapusItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHapusItem.ForeColor = System.Drawing.Color.White;
            this.btnHapusItem.Location = new System.Drawing.Point(305, 360);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(155, 40);
            this.btnHapusItem.TabIndex = 3;
            this.btnHapusItem.Text = "🗑️ Hapus";
            this.btnHapusItem.UseVisualStyleBackColor = false;
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);
            // 
            // lblJumlahItem
            // 
            this.lblJumlahItem.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.lblJumlahItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlahItem.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.lblJumlahItem.Location = new System.Drawing.Point(20, 360);
            this.lblJumlahItem.Name = "lblJumlahItem";
            this.lblJumlahItem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblJumlahItem.Size = new System.Drawing.Size(270, 40);
            this.lblJumlahItem.TabIndex = 2;
            this.lblJumlahItem.Text = "📋 0 item (0 pcs)";
            this.lblJumlahItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyleKeranjangHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleKeranjangHeader.BackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            dataGridViewCellStyleKeranjangHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleKeranjangHeader.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleKeranjangHeader.SelectionBackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            dataGridViewCellStyleKeranjangHeader.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleKeranjangHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleKeranjangHeader;
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyleKeranjangDefault.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleKeranjangDefault.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyleKeranjangDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleKeranjangDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyleKeranjangDefault.SelectionBackColor = System.Drawing.Color.FromArgb(255, 224, 178);
            dataGridViewCellStyleKeranjangDefault.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleKeranjangDefault.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKeranjang.DefaultCellStyle = dataGridViewCellStyleKeranjangDefault;
            this.dgvKeranjang.EnableHeadersVisualStyles = false;
            this.dgvKeranjang.Location = new System.Drawing.Point(20, 65);
            this.dgvKeranjang.MultiSelect = false;
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.RowHeadersVisible = false;
            this.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeranjang.Size = new System.Drawing.Size(440, 280);
            this.dgvKeranjang.TabIndex = 1;
            // 
            // lblKeranjangTitle
            // 
            this.lblKeranjangTitle.BackColor = System.Drawing.Color.FromArgb(255, 167, 38);
            this.lblKeranjangTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblKeranjangTitle.ForeColor = System.Drawing.Color.White;
            this.lblKeranjangTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKeranjangTitle.Name = "lblKeranjangTitle";
            this.lblKeranjangTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblKeranjangTitle.Size = new System.Drawing.Size(480, 50);
            this.lblKeranjangTitle.TabIndex = 0;
            this.lblKeranjangTitle.Text = "🛒 Keranjang Belanja";
            this.lblKeranjangTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCheckout
            // 
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
            // 
            // btnBatalTransaksi
            // 
            this.btnBatalTransaksi.BackColor = System.Drawing.Color.White;
            this.btnBatalTransaksi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 83, 80);
            this.btnBatalTransaksi.FlatAppearance.BorderSize = 2;
            this.btnBatalTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatalTransaksi.ForeColor = System.Drawing.Color.FromArgb(239, 83, 80);
            this.btnBatalTransaksi.Location = new System.Drawing.Point(20, 230);
            this.btnBatalTransaksi.Name = "btnBatalTransaksi";
            this.btnBatalTransaksi.Size = new System.Drawing.Size(100, 45);
            this.btnBatalTransaksi.TabIndex = 8;
            this.btnBatalTransaksi.Text = "❌ Batal";
            this.btnBatalTransaksi.UseVisualStyleBackColor = false;
            this.btnBatalTransaksi.Click += new System.EventHandler(this.btnBatalTransaksi_Click);
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(67, 160, 71);
            this.btnProses.FlatAppearance.BorderSize = 0;
            this.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProses.ForeColor = System.Drawing.Color.White;
            this.btnProses.Location = new System.Drawing.Point(140, 230);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(320, 45);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "✅ SELESAI & CETAK";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblKembalian
            // 
            this.lblKembalian.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.lblKembalian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(51, 105, 30);
            this.lblKembalian.Location = new System.Drawing.Point(240, 175);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(220, 29);
            this.lblKembalian.TabIndex = 7;
            this.lblKembalian.Text = "Rp 0";
            this.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKembalianLabel
            // 
            this.lblKembalianLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKembalianLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblKembalianLabel.Location = new System.Drawing.Point(240, 150);
            this.lblKembalianLabel.Name = "lblKembalianLabel";
            this.lblKembalianLabel.Size = new System.Drawing.Size(150, 20);
            this.lblKembalianLabel.TabIndex = 6;
            this.lblKembalianLabel.Text = "↩️ Kembalian";
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtJumlahBayar.Location = new System.Drawing.Point(20, 175);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(200, 29);
            this.txtJumlahBayar.TabIndex = 5;
            this.txtJumlahBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJumlahBayar.TextChanged += new System.EventHandler(this.txtJumlahBayar_TextChanged);
            this.txtJumlahBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBayar_KeyPress);
            // 
            // lblJumlahBayarLabel
            // 
            this.lblJumlahBayarLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlahBayarLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblJumlahBayarLabel.Location = new System.Drawing.Point(20, 150);
            this.lblJumlahBayarLabel.Name = "lblJumlahBayarLabel";
            this.lblJumlahBayarLabel.Size = new System.Drawing.Size(150, 20);
            this.lblJumlahBayarLabel.TabIndex = 4;
            this.lblJumlahBayarLabel.Text = "💵 Bayar";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.lblTotal.Location = new System.Drawing.Point(20, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblTotal.Size = new System.Drawing.Size(440, 50);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Rp 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTotalLabel.Location = new System.Drawing.Point(20, 70);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(150, 20);
            this.lblTotalLabel.TabIndex = 2;
            this.lblTotalLabel.Text = "💰 TOTAL";
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaPelanggan.Location = new System.Drawing.Point(20, 35);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(440, 25);
            this.txtNamaPelanggan.TabIndex = 1;
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNamaPelanggan.Location = new System.Drawing.Point(20, 15);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(200, 20);
            this.lblNamaPelanggan.TabIndex = 0;
            this.lblNamaPelanggan.Text = "👤 Nama Pelanggan";
            // 
            // FormPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 245, 236);
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
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            this.panelQuantityBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.panelKeranjang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

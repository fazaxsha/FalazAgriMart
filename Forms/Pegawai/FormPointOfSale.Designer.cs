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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelTop = new Panel();
            lblTanggal = new Label();
            lblKasir = new Label();
            lblTitle = new Label();
            panelProduk = new Panel();
            btnTambahKeranjang = new Button();
            panelQuantityBox = new Panel();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblTotalProduk = new Label();
            dgvProduk = new DataGridView();
            panelSearchBox = new Panel();
            lblCariProduk = new Label();
            txtCariProduk = new TextBox();
            panelKeranjang = new Panel();
            btnHapusItem = new Button();
            lblJumlahItem = new Label();
            dgvKeranjang = new DataGridView();
            lblKeranjangTitle = new Label();
            panelCheckout = new Panel();
            btnBatalTransaksi = new Button();
            btnProses = new Button();
            lblKembalian = new Label();
            lblKembalianLabel = new Label();
            txtJumlahBayar = new TextBox();
            lblJumlahBayarLabel = new Label();
            lblTotal = new Label();
            lblTotalLabel = new Label();
            txtNamaPelanggan = new TextBox();
            lblNamaPelanggan = new Label();
            panelTop.SuspendLayout();
            panelProduk.SuspendLayout();
            panelQuantityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            panelSearchBox.SuspendLayout();
            panelKeranjang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            panelCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(102, 187, 106);
            panelTop.Controls.Add(lblTanggal);
            panelTop.Controls.Add(lblKasir);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1633, 92);
            panelTop.TabIndex = 0;
            // 
            // lblTanggal
            // 
            lblTanggal.Font = new Font("Segoe UI", 9F);
            lblTanggal.ForeColor = Color.FromArgb(232, 245, 233);
            lblTanggal.Location = new Point(1225, 52);
            lblTanggal.Margin = new Padding(4, 0, 4, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(373, 29);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "📅 Tanggal: -";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKasir
            // 
            lblKasir.Font = new Font("Segoe UI", 10F);
            lblKasir.ForeColor = Color.White;
            lblKasir.Location = new Point(1225, 23);
            lblKasir.Margin = new Padding(4, 0, 4, 0);
            lblKasir.Name = "lblKasir";
            lblKasir.Size = new Size(373, 29);
            lblKasir.TabIndex = 1;
            lblKasir.Text = "👤 Kasir: -";
            lblKasir.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(35, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(467, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🌱 AgriMart POS";
            // 
            // panelProduk
            // 
            panelProduk.BackColor = Color.White;
            panelProduk.Controls.Add(btnTambahKeranjang);
            panelProduk.Controls.Add(panelQuantityBox);
            panelProduk.Controls.Add(lblTotalProduk);
            panelProduk.Controls.Add(dgvProduk);
            panelProduk.Controls.Add(panelSearchBox);
            panelProduk.Location = new Point(23, 115);
            panelProduk.Margin = new Padding(4, 3, 4, 3);
            panelProduk.Name = "panelProduk";
            panelProduk.Size = new Size(723, 750);
            panelProduk.TabIndex = 1;
            // 
            // btnTambahKeranjang
            // 
            btnTambahKeranjang.BackColor = Color.FromArgb(255, 167, 38);
            btnTambahKeranjang.FlatAppearance.BorderSize = 0;
            btnTambahKeranjang.FlatStyle = FlatStyle.Flat;
            btnTambahKeranjang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTambahKeranjang.ForeColor = Color.White;
            btnTambahKeranjang.Location = new Point(303, 675);
            btnTambahKeranjang.Margin = new Padding(4, 3, 4, 3);
            btnTambahKeranjang.Name = "btnTambahKeranjang";
            btnTambahKeranjang.Size = new Size(397, 58);
            btnTambahKeranjang.TabIndex = 4;
            btnTambahKeranjang.Text = "➕ TAMBAH";
            btnTambahKeranjang.UseVisualStyleBackColor = false;
            btnTambahKeranjang.Click += btnTambahKeranjang_Click;
            // 
            // panelQuantityBox
            // 
            panelQuantityBox.BackColor = Color.FromArgb(241, 248, 233);
            panelQuantityBox.Controls.Add(lblQuantity);
            panelQuantityBox.Controls.Add(numQuantity);
            panelQuantityBox.Location = new Point(23, 675);
            panelQuantityBox.Margin = new Padding(4, 3, 4, 3);
            panelQuantityBox.Name = "panelQuantityBox";
            panelQuantityBox.Size = new Size(257, 58);
            panelQuantityBox.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.FromArgb(55, 71, 79);
            lblQuantity.Location = new Point(6, 14);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 27);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Qty:";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numQuantity.ForeColor = Color.FromArgb(55, 71, 79);
            numQuantity.Location = new Point(128, 12);
            numQuantity.Margin = new Padding(4, 3, 4, 3);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(111, 29);
            numQuantity.TabIndex = 0;
            // 
            // lblTotalProduk
            // 
            lblTotalProduk.BackColor = Color.FromArgb(241, 248, 233);
            lblTotalProduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalProduk.ForeColor = Color.FromArgb(85, 139, 47);
            lblTotalProduk.Location = new Point(23, 629);
            lblTotalProduk.Margin = new Padding(4, 0, 4, 0);
            lblTotalProduk.Name = "lblTotalProduk";
            lblTotalProduk.Padding = new Padding(12, 6, 12, 6);
            lblTotalProduk.Size = new Size(233, 35);
            lblTotalProduk.TabIndex = 2;
            lblTotalProduk.Text = "📦 0 produk tersedia";
            // 
            // dgvProduk
            // 
            dgvProduk.AllowUserToAddRows = false;
            dgvProduk.AllowUserToDeleteRows = false;
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduk.BackgroundColor = Color.White;
            dgvProduk.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(102, 187, 106);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 187, 106);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 237, 200);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduk.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduk.EnableHeadersVisualStyles = false;
            dgvProduk.GridColor = Color.FromArgb(232, 245, 233);
            dgvProduk.Location = new Point(23, 110);
            dgvProduk.Margin = new Padding(4, 3, 4, 3);
            dgvProduk.MultiSelect = false;
            dgvProduk.Name = "dgvProduk";
            dgvProduk.ReadOnly = true;
            dgvProduk.RowHeadersVisible = false;
            dgvProduk.RowTemplate.Height = 35;
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.Size = new Size(677, 508);
            dgvProduk.TabIndex = 1;
            dgvProduk.CellDoubleClick += dgvProduk_CellDoubleClick;
            // 
            // panelSearchBox
            // 
            panelSearchBox.BackColor = Color.FromArgb(241, 248, 233);
            panelSearchBox.Controls.Add(lblCariProduk);
            panelSearchBox.Controls.Add(txtCariProduk);
            panelSearchBox.Location = new Point(23, 23);
            panelSearchBox.Margin = new Padding(4, 3, 4, 3);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(677, 69);
            panelSearchBox.TabIndex = 0;
            // 
            // lblCariProduk
            // 
            lblCariProduk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCariProduk.ForeColor = Color.FromArgb(51, 105, 30);
            lblCariProduk.Location = new Point(18, 9);
            lblCariProduk.Margin = new Padding(4, 0, 4, 0);
            lblCariProduk.Name = "lblCariProduk";
            lblCariProduk.Size = new Size(175, 29);
            lblCariProduk.TabIndex = 0;
            lblCariProduk.Text = "🔍 Cari Produk";
            // 
            // txtCariProduk
            // 
            txtCariProduk.BackColor = Color.FromArgb(241, 248, 233);
            txtCariProduk.BorderStyle = BorderStyle.None;
            txtCariProduk.Font = new Font("Segoe UI", 11F);
            txtCariProduk.ForeColor = Color.FromArgb(55, 71, 79);
            txtCariProduk.Location = new Point(23, 38);
            txtCariProduk.Margin = new Padding(4, 3, 4, 3);
            txtCariProduk.Name = "txtCariProduk";
            txtCariProduk.Size = new Size(636, 20);
            txtCariProduk.TabIndex = 0;
            txtCariProduk.TextChanged += txtCariProduk_TextChanged;
            // 
            // panelKeranjang
            // 
            panelKeranjang.BackColor = Color.White;
            panelKeranjang.Controls.Add(btnHapusItem);
            panelKeranjang.Controls.Add(lblJumlahItem);
            panelKeranjang.Controls.Add(dgvKeranjang);
            panelKeranjang.Controls.Add(lblKeranjangTitle);
            panelKeranjang.Location = new Point(770, 115);
            panelKeranjang.Margin = new Padding(4, 3, 4, 3);
            panelKeranjang.Name = "panelKeranjang";
            panelKeranjang.Size = new Size(560, 485);
            panelKeranjang.TabIndex = 2;
            // 
            // btnHapusItem
            // 
            btnHapusItem.BackColor = Color.FromArgb(239, 83, 80);
            btnHapusItem.FlatAppearance.BorderSize = 0;
            btnHapusItem.FlatStyle = FlatStyle.Flat;
            btnHapusItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHapusItem.ForeColor = Color.White;
            btnHapusItem.Location = new Point(356, 415);
            btnHapusItem.Margin = new Padding(4, 3, 4, 3);
            btnHapusItem.Name = "btnHapusItem";
            btnHapusItem.Size = new Size(181, 46);
            btnHapusItem.TabIndex = 3;
            btnHapusItem.Text = "🗑️ Hapus";
            btnHapusItem.UseVisualStyleBackColor = false;
            btnHapusItem.Click += btnHapusItem_Click;
            // 
            // lblJumlahItem
            // 
            lblJumlahItem.BackColor = Color.FromArgb(255, 243, 224);
            lblJumlahItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJumlahItem.ForeColor = Color.FromArgb(230, 81, 0);
            lblJumlahItem.Location = new Point(23, 415);
            lblJumlahItem.Margin = new Padding(4, 0, 4, 0);
            lblJumlahItem.Name = "lblJumlahItem";
            lblJumlahItem.Padding = new Padding(18, 0, 0, 0);
            lblJumlahItem.Size = new Size(315, 46);
            lblJumlahItem.TabIndex = 2;
            lblJumlahItem.Text = "📋 0 item (0 pcs)";
            lblJumlahItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToAddRows = false;
            dgvKeranjang.AllowUserToDeleteRows = false;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.White;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 167, 38);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 167, 38);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 224, 178);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.Location = new Point(23, 75);
            dgvKeranjang.Margin = new Padding(4, 3, 4, 3);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.ReadOnly = true;
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(513, 323);
            dgvKeranjang.TabIndex = 1;
            // 
            // lblKeranjangTitle
            // 
            lblKeranjangTitle.BackColor = Color.FromArgb(255, 167, 38);
            lblKeranjangTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblKeranjangTitle.ForeColor = Color.White;
            lblKeranjangTitle.Location = new Point(0, 0);
            lblKeranjangTitle.Margin = new Padding(4, 0, 4, 0);
            lblKeranjangTitle.Name = "lblKeranjangTitle";
            lblKeranjangTitle.Padding = new Padding(23, 0, 0, 0);
            lblKeranjangTitle.Size = new Size(560, 58);
            lblKeranjangTitle.TabIndex = 0;
            lblKeranjangTitle.Text = "\U0001f6d2 Keranjang Belanja";
            lblKeranjangTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCheckout
            // 
            panelCheckout.BackColor = Color.White;
            panelCheckout.Controls.Add(btnBatalTransaksi);
            panelCheckout.Controls.Add(btnProses);
            panelCheckout.Controls.Add(lblKembalian);
            panelCheckout.Controls.Add(lblKembalianLabel);
            panelCheckout.Controls.Add(txtJumlahBayar);
            panelCheckout.Controls.Add(lblJumlahBayarLabel);
            panelCheckout.Controls.Add(lblTotal);
            panelCheckout.Controls.Add(lblTotalLabel);
            panelCheckout.Controls.Add(txtNamaPelanggan);
            panelCheckout.Controls.Add(lblNamaPelanggan);
            panelCheckout.Location = new Point(770, 623);
            panelCheckout.Margin = new Padding(4, 3, 4, 3);
            panelCheckout.Name = "panelCheckout";
            panelCheckout.Size = new Size(560, 335);
            panelCheckout.TabIndex = 3;
            // 
            // btnBatalTransaksi
            // 
            btnBatalTransaksi.BackColor = Color.White;
            btnBatalTransaksi.FlatAppearance.BorderColor = Color.FromArgb(239, 83, 80);
            btnBatalTransaksi.FlatAppearance.BorderSize = 2;
            btnBatalTransaksi.FlatStyle = FlatStyle.Flat;
            btnBatalTransaksi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBatalTransaksi.ForeColor = Color.FromArgb(239, 83, 80);
            btnBatalTransaksi.Location = new Point(23, 265);
            btnBatalTransaksi.Margin = new Padding(4, 3, 4, 3);
            btnBatalTransaksi.Name = "btnBatalTransaksi";
            btnBatalTransaksi.Size = new Size(117, 52);
            btnBatalTransaksi.TabIndex = 8;
            btnBatalTransaksi.Text = "❌ Batal";
            btnBatalTransaksi.UseVisualStyleBackColor = false;
            btnBatalTransaksi.Click += btnBatalTransaksi_Click;
            // 
            // btnProses
            // 
            btnProses.BackColor = Color.FromArgb(67, 160, 71);
            btnProses.FlatAppearance.BorderSize = 0;
            btnProses.FlatStyle = FlatStyle.Flat;
            btnProses.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProses.ForeColor = Color.White;
            btnProses.Location = new Point(163, 265);
            btnProses.Margin = new Padding(4, 3, 4, 3);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(373, 52);
            btnProses.TabIndex = 9;
            btnProses.Text = "✅ SELESAI";
            btnProses.UseVisualStyleBackColor = false;
            btnProses.Click += btnProses_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.BackColor = Color.FromArgb(232, 245, 233);
            lblKembalian.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKembalian.ForeColor = Color.FromArgb(51, 105, 30);
            lblKembalian.Location = new Point(280, 202);
            lblKembalian.Margin = new Padding(4, 0, 4, 0);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(257, 33);
            lblKembalian.TabIndex = 7;
            lblKembalian.Text = "Rp 0";
            lblKembalian.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKembalianLabel
            // 
            lblKembalianLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKembalianLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblKembalianLabel.Location = new Point(280, 173);
            lblKembalianLabel.Margin = new Padding(4, 0, 4, 0);
            lblKembalianLabel.Name = "lblKembalianLabel";
            lblKembalianLabel.Size = new Size(175, 23);
            lblKembalianLabel.TabIndex = 6;
            lblKembalianLabel.Text = "↩️ Kembalian";
            // 
            // txtJumlahBayar
            // 
            txtJumlahBayar.Font = new Font("Segoe UI", 12F);
            txtJumlahBayar.Location = new Point(23, 202);
            txtJumlahBayar.Margin = new Padding(4, 3, 4, 3);
            txtJumlahBayar.Name = "txtJumlahBayar";
            txtJumlahBayar.Size = new Size(233, 29);
            txtJumlahBayar.TabIndex = 5;
            txtJumlahBayar.TextAlign = HorizontalAlignment.Right;
            txtJumlahBayar.TextChanged += txtJumlahBayar_TextChanged;
            txtJumlahBayar.KeyPress += txtJumlahBayar_KeyPress;
            // 
            // lblJumlahBayarLabel
            // 
            lblJumlahBayarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJumlahBayarLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblJumlahBayarLabel.Location = new Point(23, 173);
            lblJumlahBayarLabel.Margin = new Padding(4, 0, 4, 0);
            lblJumlahBayarLabel.Name = "lblJumlahBayarLabel";
            lblJumlahBayarLabel.Size = new Size(175, 23);
            lblJumlahBayarLabel.TabIndex = 4;
            lblJumlahBayarLabel.Text = "💵 Bayar";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(255, 243, 224);
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(230, 81, 0);
            lblTotal.Location = new Point(23, 104);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(18, 0, 18, 0);
            lblTotal.Size = new Size(513, 58);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Rp 0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalLabel.Location = new Point(23, 81);
            lblTotalLabel.Margin = new Padding(4, 0, 4, 0);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(175, 23);
            lblTotalLabel.TabIndex = 2;
            lblTotalLabel.Text = "💰 TOTAL";
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.BorderStyle = BorderStyle.FixedSingle;
            txtNamaPelanggan.Font = new Font("Segoe UI", 10F);
            txtNamaPelanggan.Location = new Point(23, 40);
            txtNamaPelanggan.Margin = new Padding(4, 3, 4, 3);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(513, 25);
            txtNamaPelanggan.TabIndex = 1;
            // 
            // lblNamaPelanggan
            // 
            lblNamaPelanggan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNamaPelanggan.ForeColor = Color.FromArgb(107, 114, 128);
            lblNamaPelanggan.Location = new Point(23, 17);
            lblNamaPelanggan.Margin = new Padding(4, 0, 4, 0);
            lblNamaPelanggan.Name = "lblNamaPelanggan";
            lblNamaPelanggan.Size = new Size(233, 23);
            lblNamaPelanggan.TabIndex = 0;
            lblNamaPelanggan.Text = "👤 Nama Pelanggan";
            // 
            // FormPointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 245, 236);
            ClientSize = new Size(1633, 923);
            Controls.Add(panelCheckout);
            Controls.Add(panelKeranjang);
            Controls.Add(panelProduk);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPointOfSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriMart - Point of Sale";
            WindowState = FormWindowState.Maximized;
            Load += FormPointOfSale_Load;
            panelTop.ResumeLayout(false);
            panelProduk.ResumeLayout(false);
            panelQuantityBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            panelSearchBox.ResumeLayout(false);
            panelSearchBox.PerformLayout();
            panelKeranjang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            panelCheckout.ResumeLayout(false);
            panelCheckout.PerformLayout();
            ResumeLayout(false);

        }
    }
}

namespace FalazAgriMart.Forms.Pegawai
{
    partial class FormRiwayatPribadi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblInfo = new Label();
            lblTitle = new Label();
            panelFilter = new Panel();
            btnRefresh = new Button();
            btnFilter = new Button();
            dtpAkhir = new DateTimePicker();
            dtpMulai = new DateTimePicker();
            chkFilterTanggal = new CheckBox();
            lblSampai = new Label();
            lblDari = new Label();
            panelMain = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            dgvTransaksi = new DataGridView();
            panelInfo = new Panel();
            lblTotalPenjualan = new Label();
            lblTotal = new Label();
            groupBox2 = new GroupBox();
            dgvDetail = new DataGridView();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            panelInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(46, 204, 113);
            panelTop.Controls.Add(lblInfo);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 60);
            panelTop.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(700, 20);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(280, 23);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Kasir: -";
            lblInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(278, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Riwayat Transaksi Pribadi";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(btnRefresh);
            panelFilter.Controls.Add(btnFilter);
            panelFilter.Controls.Add(dtpAkhir);
            panelFilter.Controls.Add(dtpMulai);
            panelFilter.Controls.Add(chkFilterTanggal);
            panelFilter.Controls.Add(lblSampai);
            panelFilter.Controls.Add(lblDari);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 60);
            panelFilter.Name = "panelFilter";
            panelFilter.Padding = new Padding(20);
            panelFilter.Size = new Size(1000, 80);
            panelFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(750, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(46, 204, 113);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(650, 25);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(90, 35);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dtpAkhir
            // 
            dtpAkhir.Enabled = false;
            dtpAkhir.Font = new Font("Segoe UI", 9F);
            dtpAkhir.Format = DateTimePickerFormat.Short;
            dtpAkhir.Location = new Point(500, 30);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(130, 23);
            dtpAkhir.TabIndex = 4;
            // 
            // dtpMulai
            // 
            dtpMulai.Enabled = false;
            dtpMulai.Font = new Font("Segoe UI", 9F);
            dtpMulai.Format = DateTimePickerFormat.Short;
            dtpMulai.Location = new Point(300, 30);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(130, 23);
            dtpMulai.TabIndex = 2;
            // 
            // chkFilterTanggal
            // 
            chkFilterTanggal.AutoSize = true;
            chkFilterTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFilterTanggal.Location = new Point(23, 32);
            chkFilterTanggal.Name = "chkFilterTanggal";
            chkFilterTanggal.Size = new Size(100, 19);
            chkFilterTanggal.TabIndex = 0;
            chkFilterTanggal.Text = "Filter Tanggal";
            chkFilterTanggal.UseVisualStyleBackColor = true;
            chkFilterTanggal.CheckedChanged += chkFilterTanggal_CheckedChanged;
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.Font = new Font("Segoe UI", 9F);
            lblSampai.Location = new Point(440, 34);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(52, 15);
            lblSampai.TabIndex = 3;
            lblSampai.Text = "Sampai :";
            // 
            // lblDari
            // 
            lblDari.AutoSize = true;
            lblDari.Font = new Font("Segoe UI", 9F);
            lblDari.Location = new Point(260, 34);
            lblDari.Name = "lblDari";
            lblDari.Size = new Size(34, 15);
            lblDari.TabIndex = 1;
            lblDari.Text = "Dari :";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(splitContainer1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 140);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 560);
            panelMain.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(960, 520);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTransaksi);
            groupBox1.Controls.Add(panelInfo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaksi Saya";
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Dock = DockStyle.Fill;
            dgvTransaksi.Location = new Point(3, 19);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(954, 238);
            dgvTransaksi.TabIndex = 0;
            dgvTransaksi.CellClick += dgvTransaksi_CellClick;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(46, 204, 113);
            panelInfo.Controls.Add(lblTotalPenjualan);
            panelInfo.Controls.Add(lblTotal);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(3, 257);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(954, 40);
            panelInfo.TabIndex = 1;
            // 
            // lblTotalPenjualan
            // 
            lblTotalPenjualan.AutoSize = true;
            lblTotalPenjualan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPenjualan.ForeColor = Color.White;
            lblTotalPenjualan.Location = new Point(632, 11);
            lblTotalPenjualan.Name = "lblTotalPenjualan";
            lblTotalPenjualan.Size = new Size(185, 19);
            lblTotalPenjualan.TabIndex = 1;
            lblTotalPenjualan.Text = "Total Penjualan Saya: Rp 0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(15, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(121, 19);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: 0 transaksi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDetail);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(960, 216);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detail Transaksi";
            // 
            // dgvDetail
            // 
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Location = new Point(3, 19);
            dgvDetail.MultiSelect = false;
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetail.Size = new Size(954, 194);
            dgvDetail.TabIndex = 0;
            // 
            // FormRiwayatPribadi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelMain);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Name = "FormRiwayatPribadi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Transaksi Pribadi";
            Load += FormRiwayatPribadi_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelMain.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.DateTimePicker dtpMulai;
        private System.Windows.Forms.CheckBox chkFilterTanggal;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTotalPenjualan;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetail;
    }
}
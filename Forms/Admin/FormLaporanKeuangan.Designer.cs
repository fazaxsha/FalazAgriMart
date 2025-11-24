namespace FalazAgriMart.Forms.Admin
{
    partial class FormLaporanKeuangan
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.dtpMulai = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.panelStatistik = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTransaksi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPendapatan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRataRata = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPendapatanPerHari = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.panelStatistik.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Laporan Keuangan";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnExport);
            this.panelFilter.Controls.Add(this.btnCetak);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Controls.Add(this.btnTampilkan);
            this.panelFilter.Controls.Add(this.dtpAkhir);
            this.panelFilter.Controls.Add(this.dtpMulai);
            this.panelFilter.Controls.Add(this.lblSampai);
            this.panelFilter.Controls.Add(this.lblPeriode);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFilter.Size = new System.Drawing.Size(1000, 80);
            this.panelFilter.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(880, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 35);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(780, 25);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(90, 35);
            this.btnCetak.TabIndex = 6;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(680, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor = System.Drawing.Color.White;
            this.btnTampilkan.Location = new System.Drawing.Point(570, 25);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(100, 35);
            this.btnTampilkan.TabIndex = 4;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAkhir.Location = new System.Drawing.Point(410, 30);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(140, 23);
            this.dtpAkhir.TabIndex = 3;
            // 
            // dtpMulai
            // 
            this.dtpMulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMulai.Location = new System.Drawing.Point(190, 30);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.Size = new System.Drawing.Size(140, 23);
            this.dtpMulai.TabIndex = 1;
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSampai.Location = new System.Drawing.Point(345, 34);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(59, 15);
            this.lblSampai.TabIndex = 2;
            this.lblSampai.Text = "Sampai : ";
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeriode.Location = new System.Drawing.Point(23, 34);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(161, 15);
            this.lblPeriode.TabIndex = 0;
            this.lblPeriode.Text = "Periode Laporan (Dari - s/d):";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.panelStatistik);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1000, 560);
            this.panelMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLaporan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Transaksi";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaporan.Location = new System.Drawing.Point(3, 19);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Size = new System.Drawing.Size(954, 378);
            this.dgvLaporan.TabIndex = 0;
            // 
            // panelStatistik
            // 
            this.panelStatistik.Controls.Add(this.tableLayoutPanel1);
            this.panelStatistik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistik.Location = new System.Drawing.Point(20, 20);
            this.panelStatistik.Name = "panelStatistik";
            this.panelStatistik.Size = new System.Drawing.Size(960, 120);
            this.panelStatistik.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.lblTotalTransaksi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 110);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalTransaksi
            // 
            this.lblTotalTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTransaksi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransaksi.ForeColor = System.Drawing.Color.White;
            this.lblTotalTransaksi.Location = new System.Drawing.Point(0, 40);
            this.lblTotalTransaksi.Name = "lblTotalTransaksi";
            this.lblTotalTransaksi.Size = new System.Drawing.Size(230, 70);
            this.lblTotalTransaksi.TabIndex = 1;
            this.lblTotalTransaksi.Text = "0";
            this.lblTotalTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Transaksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.lblTotalPendapatan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(245, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 110);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalPendapatan
            // 
            this.lblTotalPendapatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPendapatan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPendapatan.ForeColor = System.Drawing.Color.White;
            this.lblTotalPendapatan.Location = new System.Drawing.Point(0, 40);
            this.lblTotalPendapatan.Name = "lblTotalPendapatan";
            this.lblTotalPendapatan.Size = new System.Drawing.Size(230, 70);
            this.lblTotalPendapatan.TabIndex = 1;
            this.lblTotalPendapatan.Text = "Rp 0";
            this.lblTotalPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Pendapatan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.lblRataRata);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(485, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 110);
            this.panel3.TabIndex = 2;
            // 
            // lblRataRata
            // 
            this.lblRataRata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRataRata.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRataRata.ForeColor = System.Drawing.Color.White;
            this.lblRataRata.Location = new System.Drawing.Point(0, 40);
            this.lblRataRata.Name = "lblRataRata";
            this.lblRataRata.Size = new System.Drawing.Size(230, 70);
            this.lblRataRata.TabIndex = 1;
            this.lblRataRata.Text = "Rp 0";
            this.lblRataRata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rata-rata per Transaksi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.lblPendapatanPerHari);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(725, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 110);
            this.panel4.TabIndex = 3;
            // 
            // lblPendapatanPerHari
            // 
            this.lblPendapatanPerHari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendapatanPerHari.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPendapatanPerHari.ForeColor = System.Drawing.Color.White;
            this.lblPendapatanPerHari.Location = new System.Drawing.Point(0, 40);
            this.lblPendapatanPerHari.Name = "lblPendapatanPerHari";
            this.lblPendapatanPerHari.Size = new System.Drawing.Size(230, 70);
            this.lblPendapatanPerHari.TabIndex = 1;
            this.lblPendapatanPerHari.Text = "Rp 0";
            this.lblPendapatanPerHari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pendapatan per Hari";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLaporanKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormLaporanKeuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Keuangan";
            this.Load += new System.EventHandler(this.FormLaporanKeuangan_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.panelStatistik.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.DateTimePicker dtpMulai;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Panel panelStatistik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPendapatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRataRata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPendapatanPerHari;
        private System.Windows.Forms.Label label7;
    }
}
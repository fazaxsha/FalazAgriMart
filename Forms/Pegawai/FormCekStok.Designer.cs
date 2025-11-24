namespace FalazAgriMart.Forms.Pegawai
{
    partial class FormCekStok
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
            lblTitle = new Label();
            panelFilter = new Panel();
            btnExport = new Button();
            btnRefresh = new Button();
            btnCari = new Button();
            cmbKategori = new ComboBox();
            txtCari = new TextBox();
            lblKategori = new Label();
            lblCari = new Label();
            panelMain = new Panel();
            groupBox1 = new GroupBox();
            dgvProduk = new DataGridView();
            panelInfo = new Panel();
            lblStokRendah = new Label();
            lblTotal = new Label();
            panelLegend = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            panelMain.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            panelInfo.SuspendLayout();
            panelLegend.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(41, 128, 185);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 60);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cek Stok Produk";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(btnExport);
            panelFilter.Controls.Add(btnRefresh);
            panelFilter.Controls.Add(btnCari);
            panelFilter.Controls.Add(cmbKategori);
            panelFilter.Controls.Add(txtCari);
            panelFilter.Controls.Add(lblKategori);
            panelFilter.Controls.Add(lblCari);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 60);
            panelFilter.Name = "panelFilter";
            panelFilter.Padding = new Padding(20);
            panelFilter.Size = new Size(1000, 80);
            panelFilter.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(52, 152, 219);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(880, 25);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 35);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(780, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 35);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(46, 204, 113);
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(680, 25);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(90, 35);
            btnCari.TabIndex = 4;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 9F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(450, 30);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(200, 23);
            cmbKategori.TabIndex = 3;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 9F);
            txtCari.Location = new Point(100, 30);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(250, 23);
            txtCari.TabIndex = 1;
            txtCari.KeyPress += txtCari_KeyPress;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKategori.Location = new Point(375, 34);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(64, 15);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori : ";
            // 
            // lblCari
            // 
            lblCari.AutoSize = true;
            lblCari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCari.Location = new Point(23, 34);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(69, 15);
            lblCari.TabIndex = 0;
            lblCari.Text = "Cari Nama :";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(groupBox1);
            panelMain.Controls.Add(panelLegend);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 140);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 560);
            panelMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProduk);
            groupBox1.Controls.Add(panelInfo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 460);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar Produk";
            // 
            // dgvProduk
            // 
            dgvProduk.AllowUserToAddRows = false;
            dgvProduk.AllowUserToDeleteRows = false;
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduk.BackgroundColor = Color.White;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Dock = DockStyle.Fill;
            dgvProduk.Location = new Point(3, 19);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.ReadOnly = true;
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.Size = new Size(954, 398);
            dgvProduk.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(41, 128, 185);
            panelInfo.Controls.Add(lblStokRendah);
            panelInfo.Controls.Add(lblTotal);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(3, 417);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(954, 40);
            panelInfo.TabIndex = 1;
            // 
            // lblStokRendah
            // 
            lblStokRendah.AutoSize = true;
            lblStokRendah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStokRendah.ForeColor = Color.White;
            lblStokRendah.Location = new Point(600, 11);
            lblStokRendah.Name = "lblStokRendah";
            lblStokRendah.Size = new Size(143, 19);
            lblStokRendah.TabIndex = 1;
            lblStokRendah.Text = "Stok Rendah: 0 item";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(15, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(111, 19);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: 0 produk";
            // 
            // panelLegend
            // 
            panelLegend.BackColor = Color.White;
            panelLegend.Controls.Add(panel3);
            panelLegend.Controls.Add(panel2);
            panelLegend.Controls.Add(panel1);
            panelLegend.Dock = DockStyle.Bottom;
            panelLegend.Location = new Point(20, 480);
            panelLegend.Name = "panelLegend";
            panelLegend.Padding = new Padding(10);
            panelLegend.Size = new Size(960, 60);
            panelLegend.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Location = new Point(640, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 30);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(30, 7);
            label3.Name = "label3";
            label3.Size = new Size(183, 15);
            label3.TabIndex = 0;
            label3.Text = "= Stok Aman (lebih dari 20 unit)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(241, 196, 15);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(330, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 30);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 0;
            label2.Text = "Stok Menipis (11-20 unit)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 76, 60);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Stok Rendah (≤ 10 unit)";
            // 
            // FormCekStok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelMain);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F);
            Name = "FormCekStok";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cek Stok Produk";
            Load += FormCekStok_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelLegend.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblStokRendah;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
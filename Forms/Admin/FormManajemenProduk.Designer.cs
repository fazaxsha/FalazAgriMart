// ============================================
// File: Forms/Admin/FormManajemenProduk.Designer.cs
// Designer code untuk FormManajemenProduk
// ============================================

namespace FalazAgriMart.Forms.Admin
{
    partial class FormManajemenProduk
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaProduk;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtNamaProduk;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblTotalProduk;

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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.txtNamaProduk = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.lblTotalProduk = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📦 Manajemen Produk";

            // panelForm
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.btnBatal);
            this.panelForm.Controls.Add(this.btnHapus);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnTambah);
            this.panelForm.Controls.Add(this.cmbSupplier);
            this.panelForm.Controls.Add(this.lblSupplier);
            this.panelForm.Controls.Add(this.txtStok);
            this.panelForm.Controls.Add(this.lblStok);
            this.panelForm.Controls.Add(this.txtHarga);
            this.panelForm.Controls.Add(this.lblHarga);
            this.panelForm.Controls.Add(this.cmbSatuan);
            this.panelForm.Controls.Add(this.lblSatuan);
            this.panelForm.Controls.Add(this.cmbKategori);
            this.panelForm.Controls.Add(this.lblKategori);
            this.panelForm.Controls.Add(this.txtNamaProduk);
            this.panelForm.Controls.Add(this.lblNamaProduk);
            this.panelForm.Location = new System.Drawing.Point(20, 80);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(350, 550);
            this.panelForm.TabIndex = 1;

            int yPos = 20;
            int labelWidth = 100;
            int fieldWidth = 220;
            int spacing = 50;

            // lblNamaProduk
            this.lblNamaProduk.Location = new System.Drawing.Point(15, yPos);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblNamaProduk.Text = "Nama Produk:";

            // txtNamaProduk
            this.txtNamaProduk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaProduk.Location = new System.Drawing.Point(15, yPos + 25);
            this.txtNamaProduk.Name = "txtNamaProduk";
            this.txtNamaProduk.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtNamaProduk.TabIndex = 0;
            yPos += spacing;

            // lblKategori
            this.lblKategori.Location = new System.Drawing.Point(15, yPos + 20);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblKategori.Text = "Kategori:";

            // cmbKategori
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(15, yPos + 45);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(fieldWidth, 25);
            this.cmbKategori.TabIndex = 1;
            yPos += spacing;

            // lblSatuan
            this.lblSatuan.Location = new System.Drawing.Point(15, yPos + 20);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblSatuan.Text = "Satuan:";

            // cmbSatuan
            this.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSatuan.FormattingEnabled = true;
            this.cmbSatuan.Items.AddRange(new object[] { "Kg", "Gram", "Buah", "Ikat", "Pack" });
            this.cmbSatuan.Location = new System.Drawing.Point(15, yPos + 45);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(fieldWidth, 25);
            this.cmbSatuan.TabIndex = 2;
            yPos += spacing;

            // lblHarga
            this.lblHarga.Location = new System.Drawing.Point(15, yPos + 20);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblHarga.Text = "Harga (Rp):";

            // txtHarga
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHarga.Location = new System.Drawing.Point(15, yPos + 45);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtHarga.TabIndex = 3;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            yPos += spacing;

            // lblStok
            this.lblStok.Location = new System.Drawing.Point(15, yPos + 20);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblStok.Text = "Stok:";

            // txtStok
            this.txtStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStok.Location = new System.Drawing.Point(15, yPos + 45);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtStok.TabIndex = 4;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
            yPos += spacing;

            // lblSupplier
            this.lblSupplier.Location = new System.Drawing.Point(15, yPos + 20);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblSupplier.Text = "Supplier:";

            // cmbSupplier
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(15, yPos + 45);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(fieldWidth, 25);
            this.cmbSupplier.TabIndex = 5;
            yPos += spacing + 30;

            // Buttons
            int btnWidth = 100;
            int btnHeight = 35;
            int btnY = yPos + 20;

            // btnTambah
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(15, btnY);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnTambah.Text = "➕ Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnSimpan
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(125, btnY);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnSimpan.Text = "💾 Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            btnY += btnHeight + 10;

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(15, btnY);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnHapus
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(125, btnY);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnHapus.Text = "🗑️ Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            btnY += btnHeight + 10;

            // btnBatal
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(15, btnY);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(210, btnHeight);
            this.btnBatal.Text = "❌ Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            // panelGrid
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.lblTotalProduk);
            this.panelGrid.Controls.Add(this.dgvProduk);
            this.panelGrid.Controls.Add(this.btnRefresh);
            this.panelGrid.Controls.Add(this.txtCari);
            this.panelGrid.Controls.Add(this.lblCari);
            this.panelGrid.Location = new System.Drawing.Point(390, 80);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(790, 550);
            this.panelGrid.TabIndex = 2;

            // lblCari
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(15, 15);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(100, 25);
            this.lblCari.Text = "🔍 Cari:";
            this.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtCari
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCari.Location = new System.Drawing.Point(80, 15);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(550, 25);
            this.txtCari.TabIndex = 0;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(650, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 30);
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // dgvProduk
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Location = new System.Drawing.Point(15, 55);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(755, 450);
            this.dgvProduk.TabIndex = 1;
            this.dgvProduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduk_CellClick);

            // lblTotalProduk
            this.lblTotalProduk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduk.Location = new System.Drawing.Point(15, 515);
            this.lblTotalProduk.Name = "lblTotalProduk";
            this.lblTotalProduk.Size = new System.Drawing.Size(300, 25);
            this.lblTotalProduk.Text = "Total: 0 produk";

            // FormManajemenProduk
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManajemenProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajemen Produk - FALAZ AgriMart";
            this.Load += new System.EventHandler(this.FormManajemenProduk_Load);

            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
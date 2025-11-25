namespace FalazAgriMart.Forms.Admin
{
    partial class FormManajemenPegawai
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNamaLengkap;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUbahPassword;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnAktifkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPegawai;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblTotalPegawai;
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNamaLengkap = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUbahPassword = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnAktifkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvPegawai = new System.Windows.Forms.DataGridView();
            this.lblTotalPegawai = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 Manajemen Pegawai";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.btnBatal);
            this.panelForm.Controls.Add(this.btnAktifkan);
            this.panelForm.Controls.Add(this.btnHapus);
            this.panelForm.Controls.Add(this.btnUbahPassword);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnTambah);
            this.panelForm.Controls.Add(this.lblInfo);
            this.panelForm.Controls.Add(this.panelPassword);
            this.panelForm.Controls.Add(this.txtNamaLengkap);
            this.panelForm.Controls.Add(this.lblNamaLengkap);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Location = new System.Drawing.Point(20, 80);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(350, 600);
            this.panelForm.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(15, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(15, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // lblNamaLengkap
            // 
            this.lblNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaLengkap.Location = new System.Drawing.Point(15, 80);
            this.lblNamaLengkap.Name = "lblNamaLengkap";
            this.lblNamaLengkap.Size = new System.Drawing.Size(120, 20);
            this.lblNamaLengkap.TabIndex = 2;
            this.lblNamaLengkap.Text = "Nama Lengkap:";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaLengkap.Location = new System.Drawing.Point(15, 105);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(220, 25);
            this.txtNamaLengkap.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.lblPassword);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Location = new System.Drawing.Point(0, 140);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(350, 60);
            this.panelPassword.TabIndex = 4;
            this.panelPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(15, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(15, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblInfo.Location = new System.Drawing.Point(15, 210);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 40);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "💡 Password hanya muncul saat tambah pegawai baru atau ubah password.";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(15, 270);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 35);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "➕ Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(125, 270);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 35);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "💾 Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(15, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUbahPassword
            // 
            this.btnUbahPassword.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.btnUbahPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbahPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUbahPassword.ForeColor = System.Drawing.Color.White;
            this.btnUbahPassword.Location = new System.Drawing.Point(125, 315);
            this.btnUbahPassword.Name = "btnUbahPassword";
            this.btnUbahPassword.Size = new System.Drawing.Size(100, 35);
            this.btnUbahPassword.TabIndex = 9;
            this.btnUbahPassword.Text = "🔑 Ubah Pass";
            this.btnUbahPassword.UseVisualStyleBackColor = false;
            this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(15, 360);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 35);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "❌ Nonaktifkan";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnAktifkan
            // 
            this.btnAktifkan.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnAktifkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktifkan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAktifkan.ForeColor = System.Drawing.Color.White;
            this.btnAktifkan.Location = new System.Drawing.Point(125, 360);
            this.btnAktifkan.Name = "btnAktifkan";
            this.btnAktifkan.Size = new System.Drawing.Size(100, 35);
            this.btnAktifkan.TabIndex = 11;
            this.btnAktifkan.Text = "✅ Aktifkan";
            this.btnAktifkan.UseVisualStyleBackColor = false;
            this.btnAktifkan.Visible = false;
            this.btnAktifkan.Click += new System.EventHandler(this.btnAktifkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(15, 405);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(210, 35);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "↩️ Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.lblTotalPegawai);
            this.panelGrid.Controls.Add(this.dgvPegawai);
            this.panelGrid.Controls.Add(this.btnRefresh);
            this.panelGrid.Controls.Add(this.txtCari);
            this.panelGrid.Controls.Add(this.lblCari);
            this.panelGrid.Location = new System.Drawing.Point(390, 80);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(790, 600);
            this.panelGrid.TabIndex = 2;
            // 
            // lblCari
            // 
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(15, 15);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(100, 25);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "🔍 Cari:";
            this.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCari.Location = new System.Drawing.Point(80, 15);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(550, 25);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(650, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.AllowUserToAddRows = false;
            this.dgvPegawai.AllowUserToDeleteRows = false;
            this.dgvPegawai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPegawai.BackgroundColor = System.Drawing.Color.White;
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.Location = new System.Drawing.Point(15, 55);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.ReadOnly = true;
            this.dgvPegawai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPegawai.Size = new System.Drawing.Size(755, 500);
            this.dgvPegawai.TabIndex = 3;
            this.dgvPegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPegawai_CellClick);
            // 
            // lblTotalPegawai
            // 
            this.lblTotalPegawai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPegawai.Location = new System.Drawing.Point(15, 565);
            this.lblTotalPegawai.Name = "lblTotalPegawai";
            this.lblTotalPegawai.Size = new System.Drawing.Size(300, 25);
            this.lblTotalPegawai.TabIndex = 4;
            this.lblTotalPegawai.Text = "Total: 0 pegawai";
            // 
            // FormManajemenPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManajemenPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajemen Pegawai - FALAZ AgriMart";
            this.Load += new System.EventHandler(this.FormManajemenPegawai_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

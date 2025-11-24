// ============================================
// File: Forms/Admin/FormManajemenSupplier.Designer.cs
// Designer code untuk FormManajemenSupplier
// ============================================

namespace FalazAgriMart.Forms.Admin
{
    partial class FormManajemenSupplier
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaSupplier;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblTotalSupplier;

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
            this.lblNamaSupplier = new System.Windows.Forms.Label();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.lblTotalSupplier = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
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
            this.lblTitle.Text = "🚚 Manajemen Supplier";

            // panelForm
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.btnBatal);
            this.panelForm.Controls.Add(this.btnHapus);
            this.panelForm.Controls.Add(this.btnEdit);
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnTambah);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.txtNoTelp);
            this.panelForm.Controls.Add(this.lblNoTelp);
            this.panelForm.Controls.Add(this.txtAlamat);
            this.panelForm.Controls.Add(this.lblAlamat);
            this.panelForm.Controls.Add(this.txtNamaSupplier);
            this.panelForm.Controls.Add(this.lblNamaSupplier);
            this.panelForm.Location = new System.Drawing.Point(20, 80);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(350, 600);
            this.panelForm.TabIndex = 1;

            int yPos = 20;
            int labelWidth = 120;
            int fieldWidth = 220;
            int spacing = 60;

            // lblNamaSupplier
            this.lblNamaSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaSupplier.Location = new System.Drawing.Point(15, yPos);
            this.lblNamaSupplier.Name = "lblNamaSupplier";
            this.lblNamaSupplier.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblNamaSupplier.Text = "Nama Supplier:";

            // txtNamaSupplier
            this.txtNamaSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaSupplier.Location = new System.Drawing.Point(15, yPos + 25);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtNamaSupplier.TabIndex = 0;
            yPos += spacing;

            // lblAlamat
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlamat.Location = new System.Drawing.Point(15, yPos);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblAlamat.Text = "Alamat:";

            // txtAlamat
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlamat.Location = new System.Drawing.Point(15, yPos + 25);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(fieldWidth, 60);
            this.txtAlamat.TabIndex = 1;
            yPos += 90;

            // lblNoTelp
            this.lblNoTelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNoTelp.Location = new System.Drawing.Point(15, yPos);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblNoTelp.Text = "No. Telepon:";

            // txtNoTelp
            this.txtNoTelp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoTelp.Location = new System.Drawing.Point(15, yPos + 25);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtNoTelp.TabIndex = 2;
            yPos += spacing;

            // lblEmail
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(15, yPos);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(labelWidth, 20);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(15, yPos + 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(fieldWidth, 25);
            this.txtEmail.TabIndex = 3;
            yPos += spacing + 30;

            // Buttons
            int btnWidth = 100;
            int btnHeight = 35;
            int btnY = yPos;

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
            this.btnBatal.Text = "↩️ Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            // panelGrid
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Controls.Add(this.lblTotalSupplier);
            this.panelGrid.Controls.Add(this.dgvSupplier);
            this.panelGrid.Controls.Add(this.btnRefresh);
            this.panelGrid.Controls.Add(this.txtCari);
            this.panelGrid.Controls.Add(this.lblCari);
            this.panelGrid.Location = new System.Drawing.Point(390, 80);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(790, 600);
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

            // dgvSupplier
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(15, 55);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(755, 500);
            this.dgvSupplier.TabIndex = 1;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);

            // lblTotalSupplier
            this.lblTotalSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSupplier.Location = new System.Drawing.Point(15, 565);
            this.lblTotalSupplier.Name = "lblTotalSupplier";
            this.lblTotalSupplier.Size = new System.Drawing.Size(300, 25);
            this.lblTotalSupplier.Text = "Total: 0 supplier";

            // FormManajemenSupplier
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManajemenSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajemen Supplier - FALAZ AgriMart";
            this.Load += new System.EventHandler(this.FormManajemenSupplier_Load);

            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
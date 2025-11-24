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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblStokRendah = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
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
            this.lblTitle.Size = new System.Drawing.Size(173, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cek Stok Produk";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnExport);
            this.panelFilter.Controls.Add(this.btnRefresh);
            this.panelFilter.Controls.Add(this.btnCari);
            this.panelFilter.Controls.Add(this.cmbKategori);
            this.panelFilter.Controls.Add(this.txtCari);
            this.panelFilter.Controls.Add(this.lblKategori);
            this.panelFilter.Controls.Add(this.lblCari);
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
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(780, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(680, 25);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 35);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(450, 30);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(200, 23);
            this.cmbKategori.TabIndex = 3;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.Location = new System.Drawing.Point(100, 30);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(250, 23);
            this.txtCari.TabIndex = 1;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(375, 34);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(69, 15);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori : ";
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCari.Location = new System.Drawing.Point(23, 34);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(71, 15);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Nama :";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.panelLegend);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1000, 560);
            this.panelMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProduk);
            this.groupBox1.Controls.Add(this.panelInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Produk";
            // 
            // dgvProduk
            // 
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduk.Location = new System.Drawing.Point(3, 19);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(954, 398);
            this.dgvProduk.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelInfo.Controls.Add(this.lblStokRendah);
            this.panelInfo.Controls.Add(this.lblTotal);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(3, 417);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(954, 40);
            this.panelInfo.TabIndex = 1;
            // 
            // lblStokRendah
            // 
            this.lblStokRendah.AutoSize = true;
            this.lblStokRendah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStokRendah.ForeColor = System.Drawing.Color.White;
            this.lblStokRendah.Location = new System.Drawing.Point(600, 11);
            this.lblStokRendah.Name = "lblStokRendah";
            this.lblStokRendah.Size = new System.Drawing.Size(146, 19);
            this.lblStokRendah.TabIndex = 1;
            this.lblStokRendah.Text = "Stok Rendah: 0 item";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(15, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(118, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: 0 produk";
            // 
            // panelLegend
            // 
            this.panelLegend.BackColor = System.Drawing.Color.White;
            this.panelLegend.Controls.Add(this.panel3);
            this.panelLegend.Controls.Add(this.panel2);
            this.panelLegend.Controls.Add(this.panel1);
            this.panelLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLegend.Location = new System.Drawing.Point(20, 480);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Padding = new System.Windows.Forms.Padding(10);
            this.panelLegend.Size = new System.Drawing.Size(960, 60);
            this.panelLegend.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(640, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 30);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "= Stok Aman (lebih dari 20 unit)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(330, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 30);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stok Menipis (11-20 unit)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Rendah (≤ 10 unit)";
            // 
            // FormCekStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormCekStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cek Stok Produk";
            this.Load += new System.EventHandler(this.FormCekStok_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelLegend.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
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
namespace FalazAgriMart.Forms
{
    partial class FormUbahPassword
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLihatPassword = new System.Windows.Forms.CheckBox();
            this.txtKonfirmasi = new System.Windows.Forms.TextBox();
            this.txtPasswordBaru = new System.Windows.Forms.TextBox();
            this.txtPasswordLama = new System.Windows.Forms.TextBox();
            this.lblKonfirmasi = new System.Windows.Forms.Label();
            this.lblPasswordBaru = new System.Windows.Forms.Label();
            this.lblPasswordLama = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(500, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ubah Password";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(500, 390);
            this.panelMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkLihatPassword);
            this.groupBox1.Controls.Add(this.txtKonfirmasi);
            this.groupBox1.Controls.Add(this.txtPasswordBaru);
            this.groupBox1.Controls.Add(this.txtPasswordLama);
            this.groupBox1.Controls.Add(this.lblKonfirmasi);
            this.groupBox1.Controls.Add(this.lblPasswordBaru);
            this.groupBox1.Controls.Add(this.lblPasswordLama);
            this.groupBox1.Controls.Add(this.lblNama);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(460, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Akun";
            // 
            // chkLihatPassword
            // 
            this.chkLihatPassword.AutoSize = true;
            this.chkLihatPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkLihatPassword.Location = new System.Drawing.Point(30, 300);
            this.chkLihatPassword.Name = "chkLihatPassword";
            this.chkLihatPassword.Size = new System.Drawing.Size(112, 19);
            this.chkLihatPassword.TabIndex = 8;
            this.chkLihatPassword.Text = "Lihat Password";
            this.chkLihatPassword.UseVisualStyleBackColor = true;
            this.chkLihatPassword.CheckedChanged += new System.EventHandler(this.chkLihatPassword_CheckedChanged);
            // 
            // txtKonfirmasi
            // 
            this.txtKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKonfirmasi.Location = new System.Drawing.Point(30, 255);
            this.txtKonfirmasi.Name = "txtKonfirmasi";
            this.txtKonfirmasi.PasswordChar = '*';
            this.txtKonfirmasi.Size = new System.Drawing.Size(400, 25);
            this.txtKonfirmasi.TabIndex = 7;
            // 
            // txtPasswordBaru
            // 
            this.txtPasswordBaru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPasswordBaru.Location = new System.Drawing.Point(30, 200);
            this.txtPasswordBaru.Name = "txtPasswordBaru";
            this.txtPasswordBaru.PasswordChar = '*';
            this.txtPasswordBaru.Size = new System.Drawing.Size(400, 25);
            this.txtPasswordBaru.TabIndex = 5;
            // 
            // txtPasswordLama
            // 
            this.txtPasswordLama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPasswordLama.Location = new System.Drawing.Point(30, 145);
            this.txtPasswordLama.Name = "txtPasswordLama";
            this.txtPasswordLama.PasswordChar = '*';
            this.txtPasswordLama.Size = new System.Drawing.Size(400, 25);
            this.txtPasswordLama.TabIndex = 3;
            // 
            // lblKonfirmasi
            // 
            this.lblKonfirmasi.AutoSize = true;
            this.lblKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKonfirmasi.Location = new System.Drawing.Point(30, 235);
            this.lblKonfirmasi.Name = "lblKonfirmasi";
            this.lblKonfirmasi.Size = new System.Drawing.Size(139, 15);
            this.lblKonfirmasi.TabIndex = 6;
            this.lblKonfirmasi.Text = "Konfirmasi Password : *";
            // 
            // lblPasswordBaru
            // 
            this.lblPasswordBaru.AutoSize = true;
            this.lblPasswordBaru.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordBaru.Location = new System.Drawing.Point(30, 180);
            this.lblPasswordBaru.Name = "lblPasswordBaru";
            this.lblPasswordBaru.Size = new System.Drawing.Size(109, 15);
            this.lblPasswordBaru.TabIndex = 4;
            this.lblPasswordBaru.Text = "Password Baru : *";
            // 
            // lblPasswordLama
            // 
            this.lblPasswordLama.AutoSize = true;
            this.lblPasswordLama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordLama.Location = new System.Drawing.Point(30, 125);
            this.lblPasswordLama.Name = "lblPasswordLama";
            this.lblPasswordLama.Size = new System.Drawing.Size(115, 15);
            this.lblPasswordLama.TabIndex = 2;
            this.lblPasswordLama.Text = "Password Lama : *";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNama.Location = new System.Drawing.Point(30, 75);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 19);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama: -";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(30, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: -";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnBatal);
            this.panelBottom.Controls.Add(this.btnSimpan);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 450);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(500, 70);
            this.panelBottom.TabIndex = 2;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(265, 15);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 40);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(135, 15);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 40);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormUbahPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUbahPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ubah Password";
            this.Load += new System.EventHandler(this.FormUbahPassword_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLihatPassword;
        private System.Windows.Forms.TextBox txtKonfirmasi;
        private System.Windows.Forms.TextBox txtPasswordBaru;
        private System.Windows.Forms.TextBox txtPasswordLama;
        private System.Windows.Forms.Label lblKonfirmasi;
        private System.Windows.Forms.Label lblPasswordBaru;
        private System.Windows.Forms.Label lblPasswordLama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
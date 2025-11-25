namespace FalazAgriMart.Forms.Auth
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRightTitle;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblTestimonial;

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
            panelLeft = new Panel();
            btnCancel = new Button();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelRight = new Panel();
            lblTestimonial = new Label();
            lblQuote = new Label();
            lblRightTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(btnCancel);
            panelLeft.Controls.Add(btnLogin);
            panelLeft.Controls.Add(chkShowPassword);
            panelLeft.Controls.Add(txtPassword);
            panelLeft.Controls.Add(lblPassword);
            panelLeft.Controls.Add(txtUsername);
            panelLeft.Controls.Add(lblUsername);
            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(lblTitle);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(500, 650);
            panelLeft.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.FromArgb(100, 100, 100);
            btnCancel.Location = new Point(60, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(380, 45);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 450);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(100, 100, 100);
            chkShowPassword.Location = new Point(60, 395);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.FromArgb(33, 33, 33);
            txtPassword.Location = new Point(60, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(380, 20);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(100, 100, 100);
            lblPassword.Location = new Point(60, 330);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(250, 250, 250);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.FromArgb(33, 33, 33);
            txtUsername.Location = new Point(60, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(380, 20);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.FromArgb(100, 100, 100);
            lblUsername.Location = new Point(60, 250);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblSubtitle.Location = new Point(60, 150);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 50);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "FALAZ AgriMart";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(60, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(46, 125, 50);
            panelRight.Controls.Add(lblTestimonial);
            panelRight.Controls.Add(lblQuote);
            panelRight.Controls.Add(lblRightTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(500, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 650);
            panelRight.TabIndex = 1;
            // 
            // lblTestimonial
            // 
            lblTestimonial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTestimonial.ForeColor = Color.White;
            lblTestimonial.Location = new Point(50, 470);
            lblTestimonial.Name = "lblTestimonial";
            lblTestimonial.Size = new Size(400, 60);
            lblTestimonial.TabIndex = 2;
            lblTestimonial.Text = "FALAZ Team\nAgricultural Solutions";
            // 
            // lblQuote
            // 
            lblQuote.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblQuote.ForeColor = Color.FromArgb(200, 230, 201);
            lblQuote.Location = new Point(50, 370);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(400, 80);
            lblQuote.TabIndex = 1;
            lblQuote.Text = "\"Connecting farmers with quality products and helping agricultural businesses thrive in the digital age.\"";
            // 
            // lblRightTitle
            // 
            lblRightTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblRightTitle.ForeColor = Color.White;
            lblRightTitle.Location = new Point(50, 150);
            lblRightTitle.Name = "lblRightTitle";
            lblRightTitle.Size = new Size(400, 200);
            lblRightTitle.TabIndex = 0;
            lblRightTitle.Text = "Grow Your Farm.";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - FALAZ AgriMart";
            Load += FormLogin_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTestimonial = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnCancel);
            this.panelLeft.Controls.Add(this.btnLogin);
            this.panelLeft.Controls.Add(this.chkShowPassword);
            this.panelLeft.Controls.Add(this.txtPassword);
            this.panelLeft.Controls.Add(this.lblPassword);
            this.panelLeft.Controls.Add(this.txtUsername);
            this.panelLeft.Controls.Add(this.lblUsername);
            this.panelLeft.Controls.Add(this.lblSubtitle);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(500, 650);
            this.panelLeft.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblTitle.Location = new System.Drawing.Point(60, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to";

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblSubtitle.Location = new System.Drawing.Point(60, 150);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(380, 50);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "FALAZ AgriMart";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblUsername.Location = new System.Drawing.Point(60, 250);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";

            // txtUsername
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtUsername.Location = new System.Drawing.Point(60, 275);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "";
            // Add padding effect with a panel wrapper if needed

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblPassword.Location = new System.Drawing.Point(60, 330);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtPassword.Location = new System.Drawing.Point(60, 355);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);

            // chkShowPassword
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.chkShowPassword.Location = new System.Drawing.Point(60, 395);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(108, 19);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(380, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.Location = new System.Drawing.Point(60, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(380, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // panelRight
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.panelRight.Controls.Add(this.lblTestimonial);
            this.panelRight.Controls.Add(this.lblQuote);
            this.panelRight.Controls.Add(this.lblRightTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(500, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(500, 650);
            this.panelRight.TabIndex = 1;

            // lblRightTitle
            this.lblRightTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblRightTitle.ForeColor = System.Drawing.Color.White;
            this.lblRightTitle.Location = new System.Drawing.Point(50, 150);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(400, 200);
            this.lblRightTitle.TabIndex = 0;
            this.lblRightTitle.Text = "Grow Your Farm.";

            // lblQuote
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblQuote.ForeColor = System.Drawing.Color.FromArgb(200, 230, 201);
            this.lblQuote.Location = new System.Drawing.Point(50, 370);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(400, 80);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.Text = "\"Connecting farmers with quality products and helping agricultural businesses thrive in the digital age.\"";

            // lblTestimonial
            this.lblTestimonial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTestimonial.ForeColor = System.Drawing.Color.White;
            this.lblTestimonial.Location = new System.Drawing.Point(50, 470);
            this.lblTestimonial.Name = "lblTestimonial";
            this.lblTestimonial.Size = new System.Drawing.Size(400, 60);
            this.lblTestimonial.TabIndex = 2;
            this.lblTestimonial.Text = "FALAZ Team\nAgricultural Solutions";

            // FormLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - FALAZ AgriMart";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
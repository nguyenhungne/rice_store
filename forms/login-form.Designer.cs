namespace rice_store.forms
{
    partial class LoginForm
    {
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(50, 30);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(50, 70);
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(50, 110);
            this.btnLogin.Size = new System.Drawing.Size(200, 30);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.buttonLoginClick);

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

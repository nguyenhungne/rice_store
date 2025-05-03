using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

using rice_store.models;
using rice_store.services;

namespace rice_store.forms
{

    public partial class LoginForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly AuthenticationService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = Program.ServiceProvider.GetRequiredService<AuthenticationService>();
            _mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();

            // Subscribe to MainForm's FormClosed event
            _mainForm.FormClosed += MainFormClosed;
        }

        private void buttonLoginClick(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User? authenticatedUser = _authService.Authenticate(email, password);

            if (authenticatedUser != null)
        {
            _mainForm.SetUserRole(authenticatedUser.Role);

            this.Hide();
            _mainForm.Show();
        }
        else
        {
            MessageBox.Show("Invalid Email or Password!");
        }
        }

        private void MainFormClosed(object? sender, FormClosedEventArgs e)
            {
                // When MainForm is closed, close the LoginForm as well
                this.Close();
            }

    }
}

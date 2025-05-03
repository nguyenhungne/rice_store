using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;

namespace rice_store.forms
{
    public partial class UserInformationForm : Form
    {
        int? userId;

        private readonly IUserService userService;
        UserManagementForm userManagementForm;
        public UserInformationForm(int? userId, UserManagementForm userManagementForm)
        {
            InitializeComponent();
            this.userId = userId;
            this.userManagementForm = userManagementForm;
            userService = Program.ServiceProvider.GetRequiredService<IUserService>();
        }

        private async void UserInformationForm_Load(object sender, EventArgs e)
        {
            // Load roles in combo box and set the selected value
            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("Warehouse Staff");
            roleComboBox.Items.Add("Sales Staff");
            roleComboBox.Items.Add("Accountant");

            if (userId == null)
            {
                // Handle Add User cases
                titleLabel.Text = "Thêm tài khoản";
                actionButton.Text = "Thêm tài khoản";
                return;
            }

            // Handle Edit User cases
            // Load user information if userId is not null
            // Assuming you have a method to get user by ID in your UserService
            actionButton.Text = "Cập nhật thông tin tài khoản";
            models.User user = await userService.GetUserByIdAsync(userId.Value);
            titleLabel.Text = $"Thông tin của tài khoản {user.Name}";
            nameTextBox.Text = user.Name;
            userNameTextBox.Text = user.Username;
            phoneTextBox.Text = user.Phone;
            emailTextBox.Text = user.Email;
            passwordTextBox.Text = user.Password; // Assuming password is not hashed or encrypted
            salaryNumericUpDown.Text = user.Salary.ToString();

            if (user.Role == "admin")
            {
                roleComboBox.SelectedItem = "Admin";
            }
            else if (user.Role == "warehouse_staff")
            {
                roleComboBox.SelectedItem = "Warehouse Staff";
            }
            else if (user.Role == "sales_staff")
            {
                roleComboBox.SelectedItem = "Sales Staff";
            }
            else if (user.Role == "accountant")
            {
                roleComboBox.SelectedItem = "Accountant";
            }
        }

        private async void actionButton_Click(object sender, EventArgs e)
        {
            string selectedRole = roleComboBox.SelectedItem.ToString();

            string roleValue = selectedRole switch
            {
                "Admin" => "admin",
                "Warehouse Staff" => "warehouse_staff",
                "Sales Staff" => "sales_staff",
                "Accountant" => "accountant",
                _ => throw new InvalidOperationException("Invalid role selected")
            };

            models.User user = new models.User
            {
                Id = userId ?? 0,
                Name = nameTextBox.Text,
                Phone = phoneTextBox.Text,
                Username = userNameTextBox.Text,
                Password = passwordTextBox.Text,
                Email = emailTextBox.Text,
                Salary = decimal.Parse(salaryNumericUpDown.Text),
                Role = roleValue
            };

            if (userId == null)
            {
                // Add new user
                await userService.AddUserAsync(user);
            }
            else
            {
                // Update existing user
                await userService.UpdateUserAsync(user);
            }

            this.Close();  // Close the form after saving
        }
    }
}

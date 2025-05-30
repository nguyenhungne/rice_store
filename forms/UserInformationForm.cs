﻿using System;
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
            passwordLabel.Text = "Mật khẩu mới";
            nameTextBox.Text = user.Name;
            userNameTextBox.Text = user.Username;
            phoneTextBox.Text = user.Phone;
            emailTextBox.Text = user.Email;
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
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(userNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                    string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                    string.IsNullOrWhiteSpace(salaryNumericUpDown.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường: Tên, Username, SĐT, Email và Lương.");
                    return;
                }

                if (roleComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò cho người dùng.");
                    return;
                }

                // Validate email format and phone number
                if (!phoneTextBox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa chữ số.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidEmail(emailTextBox.Text))
                {
                    MessageBox.Show("Email không đúng định dạng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedRole = roleComboBox.SelectedItem.ToString();

                string roleValue = selectedRole switch
                {
                    "Admin" => "admin",
                    "Warehouse Staff" => "warehouse_staff",
                    "Sales Staff" => "sales_staff",
                    "Accountant" => "accountant",
                    _ => throw new InvalidOperationException("Vai trò không hợp lệ.")
                };

                if (!decimal.TryParse(salaryNumericUpDown.Text, out decimal salary))
                {
                    MessageBox.Show("Lương phải là một số hợp lệ.");
                    return;
                }

                models.User user = new models.User
                {
                    Id = userId ?? 0,
                    Name = nameTextBox.Text.Trim(),
                    Phone = phoneTextBox.Text.Trim(),
                    Username = userNameTextBox.Text.Trim(),
                    Password = passwordTextBox.Text,
                    Email = emailTextBox.Text.Trim(),
                    Salary = salary,
                    Role = roleValue
                };

                if (userId == null)
                {
                    await userService.AddUserAsync(user);
                }
                else
                {
                    await userService.UpdateUserAsync(user);
                }

                userManagementForm.UserManagementForm_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

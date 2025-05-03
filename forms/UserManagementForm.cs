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

using rice_store.models;

namespace rice_store.forms
{
    public partial class UserManagementForm : Form
    {
        private readonly IUserService _userService;
        public UserManagementForm()
        {
            InitializeComponent();
            _userService = Program.ServiceProvider.GetRequiredService<IUserService>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            setUpDataGrid();
        }

        private async void UserManagementForm_Load(object sender, EventArgs e)
        {
            setUpDataGrid();
        }

        private async void setUpDataGrid() {
            userDataGridView.Rows.Clear();
            string? searchName = searchNameTextBox.Text;
            string? searchEmail = searchEmailTextBox.Text;
            // Load all users
            IEnumerable<User> users = await _userService.GetAllUsersAsync(searchName, searchEmail);

            foreach (User user in users)
            {
                userDataGridView.Rows.Add(
                    user.Id,
                    user.Name,
                    user.Phone,
                    user.Email,
                    user.Salary
                );
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UserInformationForm userForm = new UserInformationForm(null, this);
            userForm.ShowDialog();
            UserManagementForm_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (userDataGridView.CurrentCell != null)
            {
                int selectedRowIndex = userDataGridView.CurrentCell.RowIndex;

                if (selectedRowIndex >= 0 && selectedRowIndex < userDataGridView.Rows.Count)
                {
                    int userId = (int)userDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                    var userForm = new UserInformationForm(userId, this);
                    userForm.ShowDialog();

                    UserManagementForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Please select a valid user to edit.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }
    }
}

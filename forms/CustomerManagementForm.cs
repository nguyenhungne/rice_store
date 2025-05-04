using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using rice_store.models;

namespace rice_store.forms
{
    public partial class CustomerManagementForm : Form
    {
        private readonly CustomerService customerService;
        public CustomerManagementForm()
        {
            InitializeComponent();
            customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        public async void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            // Set the font for the DataGridView
            customerDataGridView.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // Set font for the header row
            customerDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            // Set font for the rows
            customerDataGridView.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            CustomerFilter filter = new CustomerFilter
            {
                Name = searchNameTextBox.Text,
                Phone = searchPhoneNumberTextBox.Text,
                Email = searchEmailTextBox.Text
            };

            // Load customers based on the filter
            IEnumerable<Customer> customers = await customerService.GetAllCustomersAsync(filter);

            // Clear the DataGridView before binding
            customerDataGridView.Rows.Clear();
            foreach (Customer customer in customers)
            {
                customerDataGridView.Rows.Add(customer.Id, customer.Name, customer.Phone, customer.Email, customer.Address);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Reload the form to apply the filter
            CustomerManagementForm_Load(sender, e);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int selectedRowIndex = customerDataGridView.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                // Get the customer ID from the selected row
                int customerId = (int)customerDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                // Delete the customer using the service
                await customerService.DeleteCustomerAsync(customerId);

                // Reload the form to refresh the data
                CustomerManagementForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Open the CustomerInformationForm for adding a new customer
            CustomerInformationForm customerInfoForm = new CustomerInformationForm(null, this);
            customerInfoForm.ShowDialog();

            // Reload the form to refresh the data
            CustomerManagementForm_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = customerDataGridView.CurrentCell.RowIndex;
                if (selectedRowIndex >= 0)
                {
                    // Get the customer ID from the selected row
                    int customerId = (int)customerDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                    // Open the CustomerInformationForm with the selected customer ID
                    CustomerInformationForm customerInfoForm = new CustomerInformationForm(customerId, this);
                    customerInfoForm.ShowDialog();

                    // Reload the form to refresh the data
                    CustomerManagementForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Please select a customer to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     

        }


        private async void updateRankCustomerButton_Click(object sender, EventArgs e)
        {
            int numberUpgrated = await customerService.UpdateAllCustomerRanksAsync();
            if(numberUpgrated <= 0)
            {
                MessageBox.Show("Không có khách hàng nào đủ điều kiện để thăng hạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show($"Cập nhật thành công: {numberUpgrated} khách hàng được thăng hạng.\nĐã gửi thông báo CSKH.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class CustomerInformationForm : Form
    {
        private int? _customerId;
        private readonly CustomerService customerService;
        private readonly CustomerManagementForm customerManagementForm;

        public CustomerInformationForm(int? customerId, CustomerManagementForm customerManagementForm)
        {
            InitializeComponent();
            this._customerId = customerId;
            this.customerManagementForm = customerManagementForm;
            customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
        }

        private async void CustomerInformationForm_Load(object sender, EventArgs e)
        {
            if (_customerId == null)
            {
                // Handle Add Customer cases
                titleLabel.Text = "Thêm khách hàng mới";
                actionButton.Text = "Thêm khách hàng";
                return;
            }

            // Handle Edit Customer cases
            // Load customer information if _customerId is not null
            // Assuming you have a method to get customer by ID in your CustomerService
            actionButton.Text = "Cập nhật thông tin khách hàng";
            Customer customer = await customerService.GetCustomerByIdAsync(_customerId.Value);
            titleLabel.Text = $"Thông tin của khách hàng {customer.Name}";
            nameTextBox.Text = customer.Name;
            phoneTextBox.Text = customer.Phone;
            emailTextBox.Text = customer.Email;
            addressTextBox.Text = customer.Address;
        }

        private async void actionButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            

            if (_customerId == null)
            {
                // Add new customer
                Customer newCustomer = new Customer
                {
                    Name = name,
                    Phone = phone,
                    Email = email,
                    Address = address,
                    Rank = "Thường" // Default rank for new customers
                };
                await customerService.AddCustomerAsync(newCustomer);
            }
            else
            {
                // Update existing customer
                Customer updatedCustomer = new Customer
                {
                    Id = _customerId.Value,
                    Name = name,
                    Phone = phone,
                    Email = email,
                    Address = address,
                };
                await customerService.UpdateCustomerAsync(updatedCustomer);
            }

            customerManagementForm.CustomerManagementForm_Load(sender, e); // Reload the customer management form to refresh the data
            this.Close(); // Close the form after action is completed
        }
    }
}

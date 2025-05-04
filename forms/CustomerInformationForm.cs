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



            // Validate input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Tên và số điện thoại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_customerId == null)
            {
                // check if the phone number already exists
                Customer existingPhoneCustomer = await customerService.GetCustomerByPhoneAsync(phone);
                if (existingPhoneCustomer != null)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


                //check phone is number and length
                if (!long.TryParse(phone, out long phoneNumber) || phone.Length < 10 || phone.Length > 15)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            //check if address is empty
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the customer already exists
            if (_customerId != null)
            {
                Customer existingCustomer = await customerService.GetCustomerByIdAsync(_customerId.Value);
                if (existingCustomer != null && existingCustomer.Phone != phone)
                {
                    // Check if the new phone number already exists
                    Customer existingPhoneCustomer = await customerService.GetCustomerByPhoneAsync(phone);
                    if (existingPhoneCustomer != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Check if the email already exists
                if (!string.IsNullOrWhiteSpace(email) && existingCustomer.Email != email)
                {
                    Customer existingEmailCustomer = await customerService.GetCustomerByEmailAsync(email);
                    if (existingEmailCustomer != null)
                    {
                        MessageBox.Show("Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            



                if (_customerId == null)
                {
                    try
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
                    catch
                    {
                        MessageBox.Show("Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

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


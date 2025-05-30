﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using rice_store.models;

namespace rice_store.forms
{
    public partial class SupplierInformationForm : Form
    {

        int? supplierId = null;
        SupplierService supplierService;
        SuplierManagementForm supplierManagementForm;
        public SupplierInformationForm(int? supplierId, SuplierManagementForm supplierManagementForm)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            this.supplierManagementForm = supplierManagementForm;
            supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
        }


        private async void SupplierInformationForm_Load(object sender, EventArgs e)
        {
            if (supplierId == null)
            {
                // Handle Add Supplier cases
                titleLabel.Text = "Thêm nhà cung cấp";
                actionButton.Text = "Thêm nhà cung cấp";
                return;
            }

            // Handle Edit Supplier cases
            // Load supplier information if supplierId is not null
            // Assuming you have a method to get supplier by ID in your SupplierService
            actionButton.Text = "Cập nhật thông tin nhà cung cấp";
            Supplier supplier = await supplierService.GetSupplierByIdAsync(supplierId.Value);
            titleLabel.Text = $"Thông tin của nhà cung cấp {supplier.Name}";
            nameTextBox.Text = supplier.Name;
            phoneTextBox.Text = supplier.Phone;
            emailTextBox.Text = supplier.Email;
            addressTextBox.Text = supplier.Address;
        }
        private async void actionButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà cung cấp.");
                return;
            }

            // Validate email format and phone number
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {
                if (supplierId == null)
                {
                    // Kiểm tra email đã tồn tại chưa (chỉ khi thêm mới)
                    bool emailExists = await supplierService.CheckEmailExistsAsync(email);
                    if (emailExists)
                    {
                        MessageBox.Show("Email này đã được sử dụng bởi nhà cung cấp khác.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Thêm nhà cung cấp mới
                    Supplier newSupplier = new Supplier
                    {
                        Name = name,
                        Phone = phone,
                        Email = email,
                        Address = address
                    };
                    await supplierService.AddSupplierAsync(newSupplier);
                    supplierManagementForm.SuplierManagementForm_Load(sender, e);
                }
                else
                {
                    // Kiểm tra email đã tồn tại chưa (chỉ khi thêm mới)
                    bool emailExists = await supplierService.CheckEmailExistsAsync(email);
                    if (emailExists)
                    {
                        MessageBox.Show("Email này đã được sử dụng bởi nhà cung cấp khác.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Supplier updatedSupplier = new Supplier
                    {
                        Id = supplierId.Value,
                        Name = name,
                        Phone = phone,
                        Email = email,
                        Address = address
                    };
                    await supplierService.UpdateSupplierAsync(updatedSupplier);
                    supplierManagementForm.SuplierManagementForm_Load(sender, e);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Validate email format
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

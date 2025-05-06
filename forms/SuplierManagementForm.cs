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
using rice_store.services;
using rice_store.models;
using System.Diagnostics;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class SuplierManagementForm : Form
    {
        private readonly ISupplierService _supplierService;
        public SuplierManagementForm()
        {
            InitializeComponent();
            _supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
        }

        public void SuplierManagementForm_Load(object sender, EventArgs e)
        {
            setUpDataGrid();
        }

        public async void setUpDataGrid()
        {
            string? searchName = searchNameTextBox.Text;
            string? searchEmail = searchEmailTextBox.Text;
            string? searchPhone = searchPhoneNumberTextBox.Text;

            SupplierFilter supplierFilter = new SupplierFilter
            {
                Name = searchName,
                Email = searchEmail,
                Phone = searchPhone
            };
            // Load all suppliers
            IEnumerable<Supplier> suppliers = await _supplierService.GetAllSuppliersAsync(supplierFilter);
            SupplierDataGridView.Rows.Clear();
            foreach (Supplier supplier in suppliers)
            {
                SupplierDataGridView.Rows.Add(
                    supplier.Id,
                    supplier.Name,
                    supplier.Phone,
                    supplier.Email,
                    supplier.Address
                );
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            setUpDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SupplierInformationForm supplierForm = new SupplierInformationForm(null, this);
            supplierForm.ShowDialog();
            SuplierManagementForm_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SupplierDataGridView.CurrentCell != null)
            {
                int selectedRowIndex = SupplierDataGridView.CurrentCell.RowIndex;
                int supplierId = (int)SupplierDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                SupplierInformationForm supplierForm = new SupplierInformationForm(supplierId, this);
                supplierForm.ShowDialog();
                SuplierManagementForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a supplier to edit.");
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SupplierDataGridView.CurrentCell != null)
                {
                    int selectedRowIndex = SupplierDataGridView.CurrentCell.RowIndex;
                    int supplierId = (int)SupplierDataGridView.Rows[selectedRowIndex].Cells[0].Value;
                    var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        await _supplierService.DeleteSupplierAsync(supplierId);
                        SuplierManagementForm_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to delete.");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhà cung cấp tồn tại trong các dữ liệu đơn hàng. Không thể xóa!");
            }
            
        }
    }
}

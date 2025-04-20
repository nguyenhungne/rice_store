using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using rice_store.services;
using System.Diagnostics;
using rice_store.models;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class SaleOrderManagementForm : Form
    {
        CustomerService customerService;
        PurchaseOrderDetailService purchaseOrderDetailService;
        SalesOrderDetailService salesOrderDetailService;
        private IEnumerable<Customer> _allCustomers;
        private IEnumerable<PurchaseOrderDetail> _allPurchaseOrderDetails;
        private List<AddingSalesOrderDetailData> localAddingSaleOrdersData;
        public SaleOrderManagementForm()
        {
            InitializeComponent();
            customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            purchaseOrderDetailService = Program.ServiceProvider.GetRequiredService<PurchaseOrderDetailService>();
            salesOrderDetailService = Program.ServiceProvider.GetRequiredService<SalesOrderDetailService>();
            localAddingSaleOrdersData = new List<AddingSalesOrderDetailData>();
        }

        private void InitializeDataGridView()
        {
        }

        private async void ContractManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            // Load customers into the combo box
            CustomerFilter filter = new CustomerFilter
            {
                Name = null,
                Phone = null,
                Email = null,
            };

            // Load customers into the combo box
            IEnumerable<Customer> customers = await customerService.GetAllCustomersAsync(filter);
            _allCustomers = customers;

            // Add a "No selection" option at the top
            customerComboBox.Items.Add("No selection");

            // Add each customer name to the combo box
            foreach (Customer customer in customers)
            {
                customerComboBox.Items.Add(customer.Name);
            }

            // Set the default selection to "No selection"
            customerComboBox.SelectedIndex = 0; // Set to "No selection" by default

            // Load products into the combo box
            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = await purchaseOrderDetailService.GetAllPurchaseOrderDetailsAsync();
            _allPurchaseOrderDetails = purchaseOrderDetails;
            foreach (PurchaseOrderDetail purchaseOrderDetail in purchaseOrderDetails)
            {
                productComboBox.Items.Add(purchaseOrderDetail.Warehouse.Product.Name + $"({purchaseOrderDetail.ExpirationDate.ToString("dd/MM/yyyy")})");
            }
            productComboBox.SelectedIndex = -1; // Set to no selection

            // Hardcode payment combo box items
            paymentComboBox.Items.Add("Tiền mặt");
            paymentComboBox.Items.Add("Chuyển khoản");
            paymentComboBox.Items.Add("Thẻ tín dụng");
            paymentComboBox.SelectedIndex = -1; // Set to no selection
        }

        private void renderSalesOrderDatagrid()
        {
            previewAddingSalesOrderDataGrid.Rows.Clear();
            foreach (AddingSalesOrderDetailData addingSalesOrder in localAddingSaleOrdersData)
            {

                PurchaseOrderDetail? selectedPurchaseOrderDetail = _allPurchaseOrderDetails.FirstOrDefault(p => p.WarehouseId == addingSalesOrder.salesOrderDetail.warehouseId);

                if (selectedPurchaseOrderDetail == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                previewAddingSalesOrderDataGrid.Rows.Add(
                    selectedPurchaseOrderDetail.Warehouse.Product.Name,
                    selectedPurchaseOrderDetail.Warehouse.Product.Category.Name,
                    selectedPurchaseOrderDetail.ExpirationDate.ToString("dd/MM/yyyy"),
                    addingSalesOrder.salesOrderDetail.quantity,
                    addingSalesOrder.salesOrderDetail.unitPrice.ToString("N0") + " VNĐ",
                    (addingSalesOrder.salesOrderDetail.quantity * addingSalesOrder.salesOrderDetail.unitPrice).ToString("N0") + " VNĐ"
                );
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (productComboBox.SelectedItem == null || customerComboBox.SelectedItem == null || paymentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm, khách hàng và phương thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string productName = productComboBox.SelectedItem?.ToString() ?? string.Empty;
            // Remove the expiration date part from the product name
            if (productName.Contains("(") && productName.Contains(")"))
            {
                int startIndex = productName.IndexOf("(");
                int endIndex = productName.IndexOf(")");
                productName = productName.Remove(startIndex, endIndex - startIndex + 1).Trim();
            }
            string? customerName = customerComboBox.SelectedItem.ToString() == "No selection" ? null : customerComboBox.SelectedItem.ToString();
            string paymentMethod = paymentComboBox.SelectedItem.ToString() ?? string.Empty;
            int quantity = quantityInput.Value > 0 ? (int)quantityInput.Value : 1;
            decimal unitPrice = unitPriceInput.Value > 0 ? unitPriceInput.Value : 0;

            PurchaseOrderDetail? selectedPurchaseOrderDetail = _allPurchaseOrderDetails.FirstOrDefault(p => p.Warehouse.Product.Name == productName);

            if (selectedPurchaseOrderDetail == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Customer selectedCustomer =  _allCustomers.FirstOrDefault(c => c.Name == customerName);
            Customer? selectedCustomer = customerName == null ? null : _allCustomers.FirstOrDefault(c => c.Name == customerName);
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unitPrice <= 0)
            {
                MessageBox.Show("Giá đơn vị phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedPurchaseOrderDetail != null)
            {
                AddingSalesOrderDetailData addingSalesOrderDetailData = new AddingSalesOrderDetailData
                {
                    salesOrder = new AddingSalesOrder
                    {
                        customerId = selectedCustomer != null ? selectedCustomer.Id : null,
                        paymentMethod = paymentMethod ?? "Unknown",
                    },
                    salesOrderDetail = new AddingSalesOrderDetail
                    {
                        warehouseId = selectedPurchaseOrderDetail.WarehouseId,
                        quantity = quantity,
                        unitPrice = unitPrice,
                    }
                };

                // Remove all existing value in inputs
                productComboBox.SelectedIndex = -1; // Set to no selection
                customerComboBox.SelectedIndex = 0; // Set to "No selection" by default
                paymentComboBox.SelectedIndex = -1; // Set to no selection
                quantityInput.Value = 1; // Set to default value
                unitPriceInput.Value = 0; // Set to default value
                localAddingSaleOrdersData.Add(addingSalesOrderDetailData);
                renderSalesOrderDatagrid();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm hoặc khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (previewAddingSalesOrderDataGrid.SelectedRows.Count > 0)
            {
                // Remove the selected row from the DataGridView
                foreach (DataGridViewRow row in previewAddingSalesOrderDataGrid.SelectedRows)
                {
                    previewAddingSalesOrderDataGrid.Rows.RemoveAt(row.Index);
                }

                // Remove the corresponding item from the localAddingSaleOrdersData list
                int index = previewAddingSalesOrderDataGrid.SelectedRows[0].Index;
                if (index >= 0 && index < localAddingSaleOrdersData.Count)
                {
                    localAddingSaleOrdersData.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there are any products to add
                if (localAddingSaleOrdersData.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào để nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call the service to order the purchase
                await salesOrderDetailService.AddInvoicesAsync(localAddingSaleOrdersData);

                // Show success message
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView in the InventoryManagementForm
                previewAddingSalesOrderDataGrid.Rows.Clear();
            }
            catch (Exception ex)
            {
                // Show error message in case of exception
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

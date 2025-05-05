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
using Microsoft.IdentityModel.Tokens;

namespace rice_store.forms
{
    public partial class SaleOrderManagementForm : Form
    {
        private readonly SendNotificationForm sendNotificationForm;
        CustomerService customerService;
        PurchaseOrderDetailService purchaseOrderDetailService;
        SalesOrderDetailService salesOrderDetailService;
        InventoryService inventoryService;
        private IEnumerable<Customer> _allCustomers;
        private IEnumerable<Inventory> _allInventory;
        private IEnumerable<PurchaseOrderDetail> _allPurchaseOrderDetails = null;
        private AddingSalesOrder _newOrder = null;
        private List<AddingSalesOrderDetailData> localAddingSaleOrdersData;
        private List<AddingSalesOrderDetail> _salesOrderDetails = new(); // lưu các chi tiết tạm
        private Customer? _selectedCustomer = null; // lưu khách hàng khi add sản phẩm đầu tiên
        private string _paymentMethod = "";         // lưu phương thức thanh toán

        public SaleOrderManagementForm(SendNotificationForm sendNotificationForm)
        {
            InitializeComponent();
            customerService = Program.ServiceProvider.GetRequiredService<CustomerService>();
            purchaseOrderDetailService = Program.ServiceProvider.GetRequiredService<PurchaseOrderDetailService>();
            inventoryService = Program.ServiceProvider.GetRequiredService<InventoryService>();
            salesOrderDetailService = Program.ServiceProvider.GetRequiredService<SalesOrderDetailService>();
            localAddingSaleOrdersData = new List<AddingSalesOrderDetailData>();
            this.sendNotificationForm = sendNotificationForm;
        }

        private void InitializeDataGridView()
        {
        }

        private async void ContractManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            // Disable all detail inputs initially
            SetControlsEnabled(false);

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

            IEnumerable<Inventory> inventories = await inventoryService.GetAllInventoriesAsync();
            _allInventory = inventories;

            // Add a "No selection" option at the top
            customerComboBox.Items.Add("Khách vãng lai");

            // Add each customer name to the combo box
            foreach (Customer customer in customers)
            {
                customerComboBox.Items.Add(customer.Name);
            }

            //add each inventory name to the combo box
            // Gán danh sách vào ComboBox
            var displayListInventory = new List<Inventory>
            {
                new Inventory { Id = -1, name = "--- Chọn chi nhánh ---" }
            };
            displayListInventory.AddRange(inventories); // Thêm các kho

            inventoryCombobox.DataSource = displayListInventory;
            inventoryCombobox.DisplayMember = "name";
            inventoryCombobox.ValueMember = "Id";
            inventoryCombobox.SelectedIndex = 0; // Hiển thị mặc định dòng đầu tiên

            // Set the default selection to "No selection"
            customerComboBox.SelectedIndex = 0; // Set to "khach vang lai" by default

            // Hardcode payment combo box items
            paymentCombobox.Items.Add("Tiền mặt");
            paymentCombobox.Items.Add("Chuyển khoản");
            paymentCombobox.Items.Add("Thẻ tín dụng");
            paymentCombobox.SelectedIndex = 0; // Set to no selection


        }

        private void SetControlsEnabled(bool enabled)
        {
            productComboBox.Enabled = enabled;
            quantityInput.Enabled = enabled;
            stockTextbox.Enabled = enabled;
            addProductButton.Enabled = enabled;
            deleteProductButton.Enabled = enabled;
            saveButton.Enabled = enabled;
            customerComboBox.Enabled = !enabled;
            inventoryCombobox.Enabled = !enabled;
            paymentCombobox.Enabled = !enabled;
        }


        private void renderSalesOrderDatagrid()
        {
            previewAddingSalesOrderDataGrid.Rows.Clear();
            foreach (AddingSalesOrderDetail addingSalesOrderDetail in _salesOrderDetails)
            {

                PurchaseOrderDetail? selectedPurchaseOrderDetail = _allPurchaseOrderDetails.FirstOrDefault(p => p.Id == addingSalesOrderDetail.purchaseOrderDetailsId);

                if (selectedPurchaseOrderDetail == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                previewAddingSalesOrderDataGrid.Rows.Add(
                    selectedPurchaseOrderDetail.Id.ToString(),
                    selectedPurchaseOrderDetail.Warehouse.Product.Name,
                    selectedPurchaseOrderDetail.Warehouse.Product.Category.Name,
                    selectedPurchaseOrderDetail.ExpirationDate.ToString("dd/MM/yyyy"),
                    addingSalesOrderDetail.quantity.ToString() + " KG",
                    addingSalesOrderDetail.unitPrice.ToString("N0") + " VNĐ",
                    (addingSalesOrderDetail.quantity * addingSalesOrderDetail.unitPrice).ToString("N0") + " VNĐ"
                );
            }
        }



        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (previewAddingSalesOrderDataGrid.SelectedRows.Count > 0)
            {
                int index = previewAddingSalesOrderDataGrid.SelectedRows[0].Index;

                if (index >= 0 && index < previewAddingSalesOrderDataGrid.Rows.Count)
                {
                    previewAddingSalesOrderDataGrid.Rows.RemoveAt(index);
                }

                if (index >= 0 && index < _salesOrderDetails.Count)
                {
                    _salesOrderDetails.RemoveAt(index);
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
                if (_salesOrderDetails.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào để nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((_newOrder == null))
                {
                    _newOrder = new AddingSalesOrder
                    {
                        customerId = _selectedCustomer != null ? _selectedCustomer.Id : null,
                        paymentMethod = _paymentMethod ?? "Unknown",
                        orderDate = DateTime.Now
                    };
                }

                AddingSalesOrderDetailData addingSalesOrderDetailData = new AddingSalesOrderDetailData
                {
                    salesOrder = _newOrder,
                    salesOrderDetail = _salesOrderDetails
                };

                // Call the service to order the purchase
                List<SalesOrderDetail> result = await salesOrderDetailService.AddInvoicesAsync(addingSalesOrderDetailData);

                if (!result.IsNullOrEmpty())
                {
                    // Update the quantity of each product in the inventory
                    foreach (var item in _salesOrderDetails)
                    {
                        await purchaseOrderDetailService.UpdateQuantityPurchaseOrderDetailAsync(item.purchaseOrderDetailsId, item.quantity);
                    }
                }


                    // Show success message
                    if (!result.IsNullOrEmpty())
                    {
                        MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close the form and return to the previous one
                        this.Close();
                        sendNotificationForm.Show();
                        sendNotificationForm.Activate();
                        sendNotificationForm.reloadData();
                    }
                    else
                    {
                        MessageBox.Show("Nhập hàng thất bại, thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }




                    // Refresh the DataGridView in the InventoryManagementForm
                    previewAddingSalesOrderDataGrid.Rows.Clear();

            }
            catch (Exception ex)
            {
                // Show error message in case of exception
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void continueButton_Click(object sender, EventArgs e)
        {
            if (inventoryCombobox.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh trước khi tiếp tục.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (paymentCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán trước khi tiếp tục.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetControlsEnabled(true);
            IEnumerable<PurchaseOrderDetail> products = await purchaseOrderDetailService.GetAllPurchaseOrderDetailsAsync((int)inventoryCombobox.SelectedValue);
            _allPurchaseOrderDetails = products;

            var displayListProduct = products.Select(p => new
            {
                DisplayName = $"{p.Warehouse.Product.Name} (Hạn sử dụng: {p.ExpirationDate.ToString("dd/MM/yyyy")})",
                Id = p.Id
            }).ToList();

            displayListProduct.Insert(0, new
            {
                DisplayName = "---Chọn gạo để bán---",
                Id = -1
            });

            productComboBox.DataSource = displayListProduct;
            productComboBox.DisplayMember = "DisplayName";
            productComboBox.ValueMember = "Id";
            productComboBox.SelectedIndex = 0; // Set to no selection
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous one
            this.Close();
            sendNotificationForm.Show();
            sendNotificationForm.Activate();
        }

        private async void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox.SelectedIndex <= 0)
            {
                stockTextbox.Text = string.Empty;
                return;
            }

            int purchaseOrderDetailID = Convert.ToInt32(productComboBox.SelectedValue);


            PurchaseOrderDetail purchaseOrderDetail = await purchaseOrderDetailService.GetPurchaseOrderDetailByIdAsync(purchaseOrderDetailID);

            stockTextbox.Text = purchaseOrderDetail.QuantityRemaining.ToString();
        }

        private async void addProductButton_Click(object sender, EventArgs e)
        {
            if (productComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int purchaseOrderDetailId = Convert.ToInt32(productComboBox.SelectedValue);


            string productName = productComboBox.Text ?? string.Empty;


            string? customerName = customerComboBox.SelectedItem?.ToString() == "No selection" ? null : customerComboBox.SelectedItem.ToString();
            string paymentMethod = paymentCombobox.SelectedItem?.ToString() ?? string.Empty;
            decimal quantity = quantityInput.Value;


            PurchaseOrderDetail? selectedPurchaseOrderDetail = _allPurchaseOrderDetails.FirstOrDefault(p => p.Id == purchaseOrderDetailId);

            if (selectedPurchaseOrderDetail == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer? selectedCustomer = customerName == null ? null : _allCustomers.FirstOrDefault(c => c.Name == customerName);

            if (_selectedCustomer == null)
            {
                _selectedCustomer = selectedCustomer;
                _paymentMethod = paymentMethod;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (decimal.TryParse(stockTextbox.Text, out var stockQuantity))
            {
                if (quantity > stockQuantity)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng gạo có trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            var existingItem = _salesOrderDetails
                .FirstOrDefault(item => item.purchaseOrderDetailsId == selectedPurchaseOrderDetail.Id);
            if (existingItem != null)
            {
                if (existingItem.quantity + quantity > stockQuantity)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng gạo có trong kho. ở đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existingItem.quantity += quantity;
                productComboBox.SelectedIndex = 0;
                quantityInput.Value = 1;
                renderSalesOrderDatagrid();
            }
            else
            {
                if (selectedPurchaseOrderDetail != null)
                {
                    var detail = new AddingSalesOrderDetail
                    {
                        warehouseId = selectedPurchaseOrderDetail.WarehouseId,
                        quantity = quantity,
                        unitPrice = selectedPurchaseOrderDetail.Warehouse.Product.SellingPrice,
                        purchaseOrderDetailsId = selectedPurchaseOrderDetail.Id,
                    };

                    _salesOrderDetails.Add(detail);


                    // Remove all existing value in inputs
                    productComboBox.SelectedIndex = 0; // Set to no selection
                                                       //customerComboBox.SelectedIndex = 0; // Set to "No selection" by default
                                                       //paymentCombobox.SelectedIndex = -1; // Set to no selection
                    quantityInput.Value = 1; // Set to default value
                                             //unitPriceInput.Value = 0; // Set to default value
                                             //localAddingSaleOrdersData.Add(addingSalesOrderDetailData);
                    renderSalesOrderDatagrid();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm hoặc khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

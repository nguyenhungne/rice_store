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
    public partial class ImportProductForm : Form
    {
        private readonly InventoryManagementForm inventoryManagementForm;
        private readonly int inventoryId;
        private readonly string inventoryName;
        private readonly SupplierService supplierService;
        private readonly ProductService productService;
        private readonly PurchaseOrderDetailService purchaseOrderDetailService;
        private IEnumerable<Supplier> _allSuppliers;
        private IEnumerable<Product> _allProducts;
        private List<AddingProductsData> localAddingProductsData;
        public ImportProductForm(InventoryManagementForm inventoryManagementForm, int inventoryId, string inventoryName)
        {
            InitializeComponent();
            this.inventoryManagementForm = inventoryManagementForm;
            this.inventoryId = inventoryId;
            this.inventoryName = inventoryName;
            this.supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
            this.productService = Program.ServiceProvider.GetRequiredService<ProductService>();
            this.purchaseOrderDetailService = Program.ServiceProvider.GetRequiredService<PurchaseOrderDetailService>();
            this.localAddingProductsData = new List<AddingProductsData>();
        }

        private void backToInventoryButton_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous one
            this.Close();
            inventoryManagementForm.Show();
            inventoryManagementForm.Activate();
        }

        private async void ImportProductForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "NHÂP HÀNG VÀO KHO " + inventoryName.ToUpper();

            // Load suppliers into the combo box
            IEnumerable<Supplier> suppliers = await supplierService.GetAllSuppliersAsync();
            _allSuppliers = suppliers;

            foreach (Supplier supplier in suppliers)
            {
                supplierComboBox.Items.Add(supplier.Name);
            }

            // Load products into the combo box
            ProductFilter filter = new ProductFilter
            {
                ProductId = null,
                ProductName = null,
                CategoryId = null,
            };
            IEnumerable<Product> products = await productService.GetAllProductsAsync(filter);
            _allProducts = products;
            foreach (Product product in products)
            {
                productComboBox.Items.Add(product.Name);
            }
        }

        private void renderPreviewDatagrid(List<AddingProductsData> addingProductsData)
        {
            previewAddingProductsDataGrid.Rows.Clear();

            foreach (AddingProductsData data in localAddingProductsData)
            {
                int rowIndex = previewAddingProductsDataGrid.Rows.Add();
                DataGridViewRow row = previewAddingProductsDataGrid.Rows[rowIndex];
                row.Cells["riceName"].Value = data.warehouse.productName;
                row.Cells["categoryRice"].Value = _allProducts.FirstOrDefault(p => p.Id == data.warehouse.productId)?.Category?.Name;
                row.Cells["supplierName"].Value = data.purchaseOrder.supplierName;
                row.Cells["quantity"].Value = data.purchaseOrderDetail.quantity;
                row.Cells["unitPrice"].Value = data.purchaseOrderDetail.unitPrice;
                row.Cells["amount"].Value = data.purchaseOrderDetail.quantity * data.purchaseOrderDetail.unitPrice;
                row.Cells["expirationDate"].Value = data.warehouse.expirationDate.ToString("dd/MM/yyyy");
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (productComboBox.SelectedItem == null || supplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = productComboBox.SelectedItem.ToString();
            string supplierName = supplierComboBox.SelectedItem.ToString();

            Product selectedProduct = _allProducts.FirstOrDefault(p => p.Name == productName);
            Supplier selectedSupplier = _allSuppliers.FirstOrDefault(s => s.Name == supplierName);

            if (selectedProduct != null && selectedSupplier != null)
            {
                AddingProductsData addingProductsData = new AddingProductsData
                {
                    warehouse = new AddingWarehouseData
                    {
                        productId = selectedProduct.Id,
                        inventoryId = this.inventoryId,
                        //minThreshold = int.Parse(minThresholdInput.Text),
                        expirationDate = expirationDatePicker.Value,
                        productName = selectedProduct.Name,
                    },
                    purchaseOrderDetail = new AddingPurchaseOrderDetailData
                    {
                        quantity = decimal.Parse(quantityInput.Text),
                        unitPrice = decimal.Parse(unitPriceInput.Text),
                        quantityRemaining = decimal.Parse(quantityInput.Text),
                    },
                    purchaseOrder = new AddingPurchaseOrderData
                    {
                        supplierId = selectedSupplier.Id,
                        supplierName = selectedSupplier.Name,
                        orderDate = DateTime.Now,
                    }
                };

                localAddingProductsData.Add(addingProductsData);
                renderPreviewDatagrid(localAddingProductsData);
                productComboBox.SelectedItem = null;
                supplierComboBox.SelectedItem = null;
                quantityInput.Text = string.Empty;
                unitPriceInput.Text = string.Empty;
                //minThresholdInput.Text = string.Empty;
                expirationDatePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm hoặc nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there are any products to add
                if (localAddingProductsData.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào để nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call the service to order the purchase
                await purchaseOrderDetailService.orderPurchaseOrderAsync(localAddingProductsData);

                // Show success message
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView in the InventoryManagementForm
                previewAddingProductsDataGrid.Rows.Clear();
                // Redirect to the InventoryManagementForm
                inventoryManagementForm.InventoryManagementForm_Load(sender, e);
                inventoryManagementForm.Show();
                inventoryManagementForm.Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                // Show error message in case of exception
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (previewAddingProductsDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = previewAddingProductsDataGrid.SelectedRows[0].Index;
                AddingProductsData selectedProductData = localAddingProductsData[selectedRowIndex];

                localAddingProductsData.RemoveAt(selectedRowIndex);

                renderPreviewDatagrid(localAddingProductsData);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            inventoryManagementForm.Show();
            inventoryManagementForm.Activate();
        }
    }
}

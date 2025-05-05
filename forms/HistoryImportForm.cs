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
    public partial class HistoryImportForm : Form
    {
        private readonly InventoryManagementForm inventoryManagementForm;
        private readonly int warehouseId;
        private readonly string productName;
        private readonly PurchaseOrderDetailService purchaseOrderDetailService;
        private readonly SupplierService supplierService;
        private IEnumerable<PurchaseOrderDetail> _allPurchaseOrderDetails;
        public HistoryImportForm(InventoryManagementForm inventoryManagementForm, int warehouseId, string productName)
        {
            InitializeComponent();
            purchaseOrderDetailService = Program.ServiceProvider.GetRequiredService<PurchaseOrderDetailService>();
            supplierService = Program.ServiceProvider.GetRequiredService<SupplierService>();
            this.inventoryManagementForm = inventoryManagementForm;
            this.warehouseId = warehouseId;
            this.productName = productName;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private async void HistoryImportForm_Load(object sender, EventArgs e)
        {
            object? selectedPurchaseOrderId = purchaseOrderCodeComboBox.SelectedItem;

            // Reset the DateTimePickers to default values (e.g., today)
            startDateTimePicker.Value = DateTime.Today.AddYears(-1);  // Default: 1 year ago
            endDateTimePicker.Value = DateTime.Today;  // Default: today

            PurchaseOrderDetailFilter filter = new PurchaseOrderDetailFilter
            {
                purchaseOrderId = selectedPurchaseOrderId != null ? (int?)Convert.ToInt32(selectedPurchaseOrderId) : null,
                supplierId = supplierComboBox.SelectedItem != null ? (int?)Convert.ToInt32(supplierComboBox.SelectedValue) : null
            };

            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = await purchaseOrderDetailService.GetPurchaseOrderDetailByWarehouseIdAsync(warehouseId, filter);

            _allPurchaseOrderDetails = purchaseOrderDetails;

            List<string> currentItems = purchaseOrderCodeComboBox.Items.Cast<string>().ToList();
            purchaseOrderCodeComboBox.Items.Clear();

            foreach (PurchaseOrderDetail purchaseOrderDetail in purchaseOrderDetails)
            {
                string purchaseOrderId = purchaseOrderDetail.Id.ToString();

                if (!currentItems.Contains(purchaseOrderId))
                {
                    purchaseOrderCodeComboBox.Items.Add(purchaseOrderId);
                }
            }

            if (selectedPurchaseOrderId != null && purchaseOrderCodeComboBox.Items.Contains(selectedPurchaseOrderId.ToString()))
            {
                purchaseOrderCodeComboBox.SelectedItem = selectedPurchaseOrderId;
            }

            supplierComboBox.Items.Clear();
            IEnumerable<Supplier> suppliers = await supplierService.GetAllSuppliersAsync();
            foreach (Supplier supplier in suppliers)
            {
                if (!supplierComboBox.Items.Contains(supplier.Name))
                {
                    supplierComboBox.Items.Add(supplier.Name);
                }
            }

            supplierComboBox.DisplayMember = "Text";
            supplierComboBox.ValueMember = "Value";

            purchaseOrderDataGridView.Rows.Clear();
            foreach (PurchaseOrderDetail purchaseOrderDetail in purchaseOrderDetails)
            {
                PurchaseOrder purchaseOrder = purchaseOrderDetail.PurchaseOrder;
                purchaseOrderDataGridView.Rows.Add(purchaseOrderDetail.Id, purchaseOrder.Supplier.Name, purchaseOrder.OrderDate, purchaseOrderDetail.Quantity, purchaseOrderDetail.UnitPrice);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            int? selectedPurchaseOrderId = purchaseOrderCodeComboBox.SelectedItem != null ? (int?)Convert.ToInt32(purchaseOrderCodeComboBox.SelectedItem) : null;
            string? selectedSupplierName = supplierComboBox.SelectedItem?.ToString();
            DateTime startDate = startDateTimePicker.Value.Date;
            DateTime endDate = endDateTimePicker.Value.Date.AddDays(1).AddSeconds(-1);

            List<PurchaseOrderDetail>? filteredPurchaseOrderDetails = _allPurchaseOrderDetails.Where(pod =>
                (selectedPurchaseOrderId == null || pod.Id == (int)selectedPurchaseOrderId) &&
                (selectedSupplierName == null || pod.PurchaseOrder.Supplier.Name == selectedSupplierName) &&
                pod.PurchaseOrder.OrderDate.Date >= startDate && pod.PurchaseOrder.OrderDate.Date <= endDate.Date
            ).ToList();

            purchaseOrderDataGridView.Rows.Clear();
            foreach (PurchaseOrderDetail purchaseOrderDetail in filteredPurchaseOrderDetails)
            {
                PurchaseOrder purchaseOrder = purchaseOrderDetail.PurchaseOrder;
                purchaseOrderDataGridView.Rows.Add(purchaseOrderDetail.Id, purchaseOrder.Supplier.Name, purchaseOrder.OrderDate, purchaseOrderDetail.Quantity, purchaseOrderDetail.UnitPrice);
            }
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            // Reset the ComboBox selections to null (no selection)
            purchaseOrderCodeComboBox.SelectedItem = null;
            supplierComboBox.SelectedItem = null;

            // Reset the DateTimePickers to default values (e.g., today)
            startDateTimePicker.Value = DateTime.Today.AddYears(-1);  // Default: 1 year ago
            endDateTimePicker.Value = DateTime.Today;  // Default: today

            // Create a filter with null values to indicate no filter
            PurchaseOrderDetailFilter filter = new PurchaseOrderDetailFilter
            {
                purchaseOrderId = null,
                supplierId = null
            };

            // Reload all purchase order details without any filters
            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = _allPurchaseOrderDetails;

            // Clear the DataGridView
            purchaseOrderDataGridView.Rows.Clear();

            // Add all purchase order details to the DataGridView
            foreach (PurchaseOrderDetail purchaseOrderDetail in purchaseOrderDetails)
            {
                PurchaseOrder purchaseOrder = purchaseOrderDetail.PurchaseOrder;
                purchaseOrderDataGridView.Rows.Add(purchaseOrderDetail.Id, purchaseOrder.Supplier.Name, purchaseOrder.OrderDate, purchaseOrderDetail.Quantity, purchaseOrderDetail.UnitPrice);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            inventoryManagementForm.Show();
            inventoryManagementForm.Activate();
        }
    }
}

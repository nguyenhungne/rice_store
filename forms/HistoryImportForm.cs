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
    public partial class HistoryImportForm : Form
    {
        private readonly InventoryManagementForm inventoryManagementForm;
        private readonly int warehouseId;
        private readonly string productName;
        private readonly PurchaseOrderDetailService purchaseOrderDetailService;
        public HistoryImportForm(InventoryManagementForm inventoryManagementForm, int warehouseId, string productName)

        {
            InitializeComponent();
            purchaseOrderDetailService = Program.ServiceProvider.GetRequiredService<PurchaseOrderDetailService>();
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

        private void backToInventoryButton_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous one
            this.Close();
            inventoryManagementForm.Show();
            inventoryManagementForm.Activate();
        }

        private async void HistoryImportForm_Load(object sender, EventArgs e)
        {
            IEnumerable<PurchaseOrderDetail> purchaseOrderDetails = await purchaseOrderDetailService.GetPurchaseOrderDetailByWarehouseIdAsync(warehouseId);
            purchaseOrderDataGridView.Rows.Clear();
            foreach (PurchaseOrderDetail purchaseOrderDetail in purchaseOrderDetails)
            {
                PurchaseOrder purchaseOrder = purchaseOrderDetail.PurchaseOrder;
                purchaseOrderDataGridView.Rows.Add(purchaseOrderDetail.Id, purchaseOrder.Supplier.Name, purchaseOrder.OrderDate, purchaseOrderDetail.Quantity, purchaseOrderDetail.UnitPrice);
            }
        }
    }
}

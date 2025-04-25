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
    public partial class SendNotificationForm : Form
    {
        private SalesOrderDetailService salesOrderDetailService;
        private IEnumerable<SalesOrderDetail> allSaleOrdersDetail;
        public SendNotificationForm()
        {
            salesOrderDetailService = Program.ServiceProvider.GetRequiredService<SalesOrderDetailService>();
            InitializeComponent();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void SendNotificationForm_Load(object sender, EventArgs e)
        {
            IEnumerable<SalesOrderDetail> salesOrdersDetail = await salesOrderDetailService.GetAllSalesOrderDetailsAsync();
            allSaleOrdersDetail = salesOrdersDetail;
            renderDataGrid(salesOrdersDetail);
        }

        private void renderDataGrid(IEnumerable<SalesOrderDetail> saleOrdersDetail)
        {
            salePurchaseDataGridView.Rows.Clear();
            foreach (SalesOrderDetail saleOrderDetail in saleOrdersDetail)
            {
                string customerName = saleOrderDetail.SalesOrder.Customer != null ? saleOrderDetail.SalesOrder.Customer.Name : "Unknown";
                salePurchaseDataGridView.Rows.Add(saleOrderDetail.Id, saleOrderDetail.Warehouse.Product.Name, saleOrderDetail.Quantity, saleOrderDetail.UnitPrice, customerName, saleOrderDetail.SalesOrder.OrderDate.ToString("dd/MM/yyyy"));
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string? productName = productNameTextBox.Text;
            string? customerName = customerCombobox.Text;
            DateTime startDate = startDateTimePicker.Value.Date;
            DateTime endDate = endDateTimePicker.Value.Date.AddDays(1).AddTicks(-1);

            IEnumerable<SalesOrderDetail> filteredSalesOrdersDetail = allSaleOrdersDetail
                .Where(s => string.IsNullOrEmpty(productName) || s.Warehouse.Product.Name.Contains(productName, StringComparison.OrdinalIgnoreCase))
                .Where(s => string.IsNullOrEmpty(customerName) || (s.SalesOrder.Customer != null && s.SalesOrder.Customer.Name.Contains(customerName, StringComparison.OrdinalIgnoreCase)))
                .Where(s => s.SalesOrder.OrderDate >= startDate && s.SalesOrder.OrderDate <= endDate);

            renderDataGrid(filteredSalesOrdersDetail);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            SaleOrderManagementForm saleOrderManagementForm = new SaleOrderManagementForm(this);
            saleOrderManagementForm.MdiParent = this.MdiParent;
            saleOrderManagementForm.Dock = DockStyle.Fill;
            saleOrderManagementForm.Show();
        }

    }
}

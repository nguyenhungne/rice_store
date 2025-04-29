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
using rice_store.utils;

namespace rice_store.forms
{
    public partial class SendNotificationForm : Form
    {
        private SalesOrderDetailService salesOrderDetailService;
        private IEnumerable<SalesOrderDetail> allSaleOrdersDetail;
        private SalesOrderService salesOrderService;
        private IEnumerable<SalesOrder> allSaleOrder;
        public SendNotificationForm()
        {
            salesOrderDetailService = Program.ServiceProvider.GetRequiredService<SalesOrderDetailService>();
            salesOrderService = Program.ServiceProvider.GetRequiredService<SalesOrderService>();  
            InitializeComponent();
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void SendNotificationForm_Load(object sender, EventArgs e)
        {
            IEnumerable<SalesOrder> salesOrders = await salesOrderService.GetAllSalesOrdersAsync();
            allSaleOrder = salesOrders;
            renderDataGrid(allSaleOrder);
        }

        public async void reloadData()
        {
            IEnumerable<SalesOrder> salesOrders = await salesOrderService.GetAllSalesOrdersAsync();
            allSaleOrder = salesOrders;
            renderDataGrid(allSaleOrder);
        }

        private void renderDataGrid(IEnumerable<SalesOrder> saleOrders)
        {
            salePurchaseDataGridView.Rows.Clear();
            foreach (SalesOrder saleOrder in saleOrders)
            {
                string customerName = saleOrder.Customer != null ? saleOrder.Customer.Name : "Khách vãng lai";
                string customerRank = saleOrder.Customer != null ? saleOrder.Customer.Rank : "Không có";
                
                salePurchaseDataGridView.Rows.Add(saleOrder.Id, customerName, saleOrder.OrderDate.ToString("dd/MM/yyyy"), CustomerUtils.GetOriginalTotal(saleOrder.Total_amount, customerRank).ToString("N0") + " VND", saleOrder.Total_amount.ToString("N0") + " VND");
            }
        }

        //private void filterButton_Click(object sender, EventArgs e)
        //{
        //    string? productName = productNameTextBox.Text;
        //    string? customerName = customerCombobox.Text;
        //    DateTime startDate = startDateTimePicker.Value.Date;
        //    DateTime endDate = endDateTimePicker.Value.Date.AddDays(1).AddTicks(-1);

        //    IEnumerable<SalesOrderDetail> filteredSalesOrdersDetail = allSaleOrdersDetail
        //        .Where(s => string.IsNullOrEmpty(productName) || s.Warehouse.Product.Name.Contains(productName, StringComparison.OrdinalIgnoreCase))
        //        .Where(s => string.IsNullOrEmpty(customerName) || (s.SalesOrder.Customer != null && s.SalesOrder.Customer.Name.Contains(customerName, StringComparison.OrdinalIgnoreCase)))
        //        .Where(s => s.SalesOrder.OrderDate >= startDate && s.SalesOrder.OrderDate <= endDate);

        //    renderDataGrid();
        //}

        private void importButton_Click(object sender, EventArgs e)
        {
            SaleOrderManagementForm saleOrderManagementForm = new SaleOrderManagementForm(this);
            saleOrderManagementForm.MdiParent = this.MdiParent;
            saleOrderManagementForm.Dock = DockStyle.Fill;
            saleOrderManagementForm.Show();
        }

    }
}

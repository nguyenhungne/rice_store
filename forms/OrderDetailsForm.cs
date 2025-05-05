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
    public partial class OrderDetailsForm : Form
    {
        private readonly SendNotificationForm sendNotificationForm;
        private readonly SalesOrderDetailService salesOrderDetailService;
        private IEnumerable<SalesOrderDetail> _salesOrderDetails;
        private int _orderId;
        public OrderDetailsForm(SendNotificationForm sendNotificationForm, int id)
        {
            this.sendNotificationForm = sendNotificationForm;
            salesOrderDetailService = Program.ServiceProvider.GetRequiredService<SalesOrderDetailService>();
            this._orderId = id;
            InitializeComponent();
        }

        private async void OrderDetailsForm_Load(object sender, EventArgs e)
        {

            _salesOrderDetails = await salesOrderDetailService.GetAllSalesOrderDetailByOrderID(_orderId);
            // Set the font for the DataGridView
            orderDetaildatagridview.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            foreach (SalesOrderDetail salesOrderDetail in _salesOrderDetails)
            {
                orderDetaildatagridview.Rows.Add(salesOrderDetail.Id, salesOrderDetail.Warehouse.Product.Name, salesOrderDetail.Quantity.ToString("N2") + " KG", salesOrderDetail.UnitPrice.ToString("N0") + " VND", (salesOrderDetail.Quantity * salesOrderDetail.UnitPrice).ToString("N0") + " VND");
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
          
        }
    }
}

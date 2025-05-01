using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using rice_store.models;
using rice_store.services.type;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class SendNotificationForm : Form
    {
        private SalesOrderDetailService salesOrderDetailService;
        private IEnumerable<SalesOrderDetail> allSaleOrdersDetail;
        private SalesOrderService salesOrderService;
        private IEnumerable<SalesOrder> allSaleOrder;
        private PrintDocument printDocument = new PrintDocument();
        private InvoiceDTO _currentInvoice = null;
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

        private void importButton_Click(object sender, EventArgs e)
        {
            SaleOrderManagementForm saleOrderManagementForm = new SaleOrderManagementForm(this);
            saleOrderManagementForm.MdiParent = this.MdiParent;
            saleOrderManagementForm.Dock = DockStyle.Fill;
            saleOrderManagementForm.Show();
        }

        private async Task LoadInvoice()
        {
            int selectedRowIndex = salePurchaseDataGridView.CurrentCell.RowIndex;
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để in hóa đơn.");
                return;
            }
            int orderID = (int)salePurchaseDataGridView.Rows[selectedRowIndex].Cells[0].Value;

            IEnumerable<SalesOrderDetail> salesOrderDetails = await salesOrderDetailService.GetAllSalesOrderDetailByOrderID(orderID);

            //set to save all warehouse id distinct
            HashSet<int> warehouseIds = salesOrderDetails
                                        .Select(detail => detail.WarehouseId)
                                        .ToHashSet();


            IEnumerable<InvoiceDetailDTO> invoiceDetails = await salesOrderDetailService.GetAllSalesOrderDetailByOrderIDAndWarehouseID(orderID, warehouseIds);

            SalesOrder salesOrder = salesOrderDetails.First().SalesOrder;
            Customer? customer = salesOrder.Customer;
            string customerName = customer != null ? customer.Name : "Khách vãng lai";
            string customerPhone = customer != null ? customer.Phone : "";
            string customerAddress = customer != null ? customer.Address : "";
            string customerEmail = customer != null ? customer.Email : "";
            string customerRank = customer != null ? customer.Rank : "Không có";
            string inventoryName = salesOrderDetails.First().Warehouse.Inventory.name;

            _currentInvoice = new InvoiceDTO
            {
                OrderID = orderID,
                CustomerName = customerName,
                OrderDate = salesOrder.OrderDate.ToString("dd/MM/yyyy"),
                PaymentMethod = salesOrder.PaymentMethod,
                TotalAmountAfterDiscount = salesOrder.Total_amount,
                TotalAmount = CustomerUtils.GetOriginalTotal(salesOrder.Total_amount, customerRank),
                DiscountAmount = CustomerUtils.GetOriginalTotal(salesOrder.Total_amount, customerRank) - salesOrder.Total_amount,
                InvoiceDetails = invoiceDetails.ToList(),
                CustomerPhone = customerPhone,
                CustomerAddress = customerAddress,
                CustomerEmail = customerEmail,
                Inventory = inventoryName
            };

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_currentInvoice == null) return;

            // Define fonts
            Font fontHeaderBold = new Font("Arial", 14, FontStyle.Bold);
            Font fontCompanyName = new Font("Arial", 12, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontSmall = new Font("Arial", 9);

            // Define positions and sizes
            float pageWidth = e.MarginBounds.Width;
            float left = e.MarginBounds.Left;
            float right = e.MarginBounds.Right;
            float y = e.MarginBounds.Top;

            // Title bar
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(230, 230, 230)))
            {
                e.Graphics.FillRectangle(brush, left, y, pageWidth, 30);
            }

            e.Graphics.DrawRectangle(Pens.Gray, left, y, pageWidth, 30);

            // Center the title
            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("CÔNG TY TNHH GOLDEN RICE STORE", fontNormal, Brushes.Black,
                new RectangleF(left, y + 8, pageWidth, 20), centerFormat);

            // Draw control buttons (simulated)
            e.Graphics.FillEllipse(Brushes.Green, left + pageWidth - 60, y + 10, 10, 10);
            e.Graphics.FillEllipse(Brushes.Yellow, left + pageWidth - 45, y + 10, 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, left + pageWidth - 30, y + 10, 10, 10);

            y += 50;

            // Company info (left side)
            float leftColumnX = left + 30;
       
            e.Graphics.DrawString($"Chi nhánh: {_currentInvoice.Inventory}", fontCompanyName, Brushes.Black, leftColumnX, y);
            y += 25;
            e.Graphics.DrawString("Điện thoại: 028-1234-5678", fontNormal, Brushes.Black, leftColumnX, y);

            // Invoice title (right side)
            float rightColumnX = left + 380;
            y -= 45;

            y += 20; // Adjust y position for invoice title
            StringFormat rightAlignFormat = new StringFormat();
            rightAlignFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", fontHeaderBold, Brushes.Black,
                new RectangleF(rightColumnX - 8, y, pageWidth - rightColumnX + left -25, 25), rightAlignFormat);

            y += 25;

            float labelWidth = 80;
            float valueWidth = 100;

            e.Graphics.DrawString("Số hóa đơn: ", fontNormal, Brushes.Black, rightColumnX, y);
            e.Graphics.DrawString($" {_currentInvoice.OrderID}", fontNormal, Brushes.Black, rightColumnX + labelWidth, y);

            y += 20;
            e.Graphics.DrawString("Ngày bán: ", fontNormal, Brushes.Black, rightColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.OrderDate}", fontNormal, Brushes.Black, rightColumnX + labelWidth, y);

            // Customer info
            y += 30;

            float customerLabelWidth = 90;

            e.Graphics.DrawString("Khách hàng: ", fontNormal, Brushes.Black, leftColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.CustomerName}", fontNormal, Brushes.Black, leftColumnX + customerLabelWidth, y);

            e.Graphics.DrawString("Điện thoại: ", fontNormal, Brushes.Black, rightColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.CustomerPhone}", fontNormal, Brushes.Black, rightColumnX + labelWidth, y);

            y += 20;
            e.Graphics.DrawString("Địa chỉ: ", fontNormal, Brushes.Black, leftColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.CustomerAddress}", fontNormal, Brushes.Black, leftColumnX + customerLabelWidth, y);

            e.Graphics.DrawString("Thanh toán: ", fontNormal, Brushes.Black, rightColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.PaymentMethod}", fontNormal, Brushes.Black, rightColumnX + labelWidth, y);

            y += 20;
            e.Graphics.DrawString("Email: ", fontNormal, Brushes.Black, leftColumnX, y);
            e.Graphics.DrawString($"{_currentInvoice.CustomerEmail}", fontNormal, Brushes.Black, leftColumnX + customerLabelWidth, y);

            y += 30;

            // Product table
            float tableWidth = pageWidth - 60;
            // Adjusted column widths to prevent overflow and balance the layout
            float[] columnWidths = { 50, 170, 90, 110, 120 }; // Increased width for "Tên sản phẩm" (220), reduced others slightly
            string[] headers = { "STT", "Tên sản phẩm", "Số lượng", "Đơn giá", "Thành tiền" };

            float tableX = leftColumnX;
            float currentX = tableX;

            // Define column formats (all left-aligned)
            StringFormat[] columnFormats = new StringFormat[5];
            for (int i = 0; i < columnFormats.Length; i++)
            {
                columnFormats[i] = new StringFormat
                {
                    Alignment = StringAlignment.Near,        // Align left
                    LineAlignment = StringAlignment.Center,  // Center vertically
                    Trimming = StringTrimming.EllipsisCharacter // Trim with ellipsis if too long
                };
            }

            // Header
            using (SolidBrush headerBrush = new SolidBrush(Color.FromArgb(230, 230, 230)))
            {
                e.Graphics.FillRectangle(headerBrush, tableX, y, tableWidth, 25);
                e.Graphics.DrawRectangle(Pens.LightGray, tableX, y, tableWidth, 25);
            }

            currentX = tableX;
            for (int i = 0; i < headers.Length; i++)
            {
                RectangleF headerRect = new RectangleF(currentX + 5, y, columnWidths[i] - 10, 25); // Add padding
                e.Graphics.DrawString(headers[i], fontBold, Brushes.Black, headerRect, columnFormats[i]);

                if (i < headers.Length - 1)
                {
                    e.Graphics.DrawLine(Pens.LightGray, currentX + columnWidths[i], y, currentX + columnWidths[i], y + 25);
                }

                currentX += columnWidths[i];
            }

            y += 25;

            // Product rows
            int stt = 1;
            bool alternateRow = false;

            foreach (var product in _currentInvoice.InvoiceDetails)
            {
                currentX = tableX;

                if (alternateRow)
                {
                    using (SolidBrush rowBrush = new SolidBrush(Color.FromArgb(248, 248, 248)))
                    {
                        e.Graphics.FillRectangle(rowBrush, tableX, y, tableWidth, 25);
                    }
                }

                e.Graphics.DrawRectangle(Pens.LightGray, tableX, y, tableWidth, 25);

                // STT
                RectangleF cellRect = new RectangleF(currentX + 5, y, columnWidths[0] - 10, 25);
                e.Graphics.DrawString(stt.ToString(), fontNormal, Brushes.Black, cellRect, columnFormats[0]);
                currentX += columnWidths[0];

                e.Graphics.DrawLine(Pens.LightGray, currentX, y, currentX, y + 25);

                // Product Name
                cellRect = new RectangleF(currentX + 5, y, columnWidths[1] - 10, 25);
                e.Graphics.DrawString(product.ProductName, fontNormal, Brushes.Black, cellRect, columnFormats[1]);
                currentX += columnWidths[1];

                e.Graphics.DrawLine(Pens.LightGray, currentX, y, currentX, y + 25);

                // Quantity
                cellRect = new RectangleF(currentX + 5, y, columnWidths[2] - 10, 25);
                string formattedQuantity = decimal.Parse(product.Quantity).ToString("N2");
                e.Graphics.DrawString(formattedQuantity + " KG", fontNormal, Brushes.Black, cellRect, columnFormats[2]);
                currentX += columnWidths[2];

                e.Graphics.DrawLine(Pens.LightGray, currentX, y, currentX, y + 25);

                // Unit Price
                cellRect = new RectangleF(currentX + 5, y, columnWidths[3] - 10, 25);
                e.Graphics.DrawString(decimal.Parse(product.UnitPrice).ToString("N0") + " VND", fontNormal, Brushes.Black, cellRect, columnFormats[3]);
                currentX += columnWidths[3];

                e.Graphics.DrawLine(Pens.LightGray, currentX, y, currentX, y + 25);

                // Total Price
                cellRect = new RectangleF(currentX + 5, y, columnWidths[4] - 10, 25);
                e.Graphics.DrawString(decimal.Parse(product.TotalPrice).ToString("N0") + " VND", fontNormal, Brushes.Black, cellRect, columnFormats[4]);

                y += 25;
                stt++;
                alternateRow = !alternateRow;
            }

            // Total row
            e.Graphics.DrawRectangle(Pens.LightGray, tableX, y, tableWidth, 25);

            StringFormat totalFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString("Tổng cộng:", fontBold, Brushes.Black,
                new RectangleF(tableX + 5, y, tableWidth - columnWidths[4] - 10, 25), totalFormat);

            e.Graphics.DrawString($"{_currentInvoice.TotalAmount.ToString("N0")} VND", fontBold, Brushes.Black,
                new RectangleF(tableX + tableWidth - columnWidths[4] + 5, y, columnWidths[4] - 10, 25), totalFormat);

            y += 25;
            e.Graphics.DrawLine(Pens.LightGray, tableX, y, tableX + tableWidth, y);
            y += 10;
            e.Graphics.DrawString("Giảm giá:", fontBold, Brushes.Black,
                new RectangleF(tableX + 5, y, tableWidth - columnWidths[4] - 10, 25), totalFormat);
            e.Graphics.DrawString($"{_currentInvoice.DiscountAmount.ToString("N0")} VND", fontBold, Brushes.Black,
                new RectangleF(tableX + tableWidth - columnWidths[4] + 5, y, columnWidths[4] - 10, 25), totalFormat);
            y += 25;
            e.Graphics.DrawLine(Pens.LightGray, tableX, y, tableX + tableWidth, y);
            y += 10;
            e.Graphics.DrawString("Thành tiền:", fontBold, Brushes.Black,
                new RectangleF(tableX + 5, y, tableWidth - columnWidths[4] - 10, 25), totalFormat);
            e.Graphics.DrawString($"{_currentInvoice.TotalAmountAfterDiscount.ToString("N0")} VND", fontBold, Brushes.Black,
                new RectangleF(tableX + tableWidth - columnWidths[4] + 5, y, columnWidths[4] - 10, 25), totalFormat);

            y += 60;

            // Signatures
            StringFormat signatureFormat = new StringFormat { Alignment = StringAlignment.Center };

            float leftSignatureX = tableX + tableWidth * 0.25f;
            float rightSignatureX = tableX + tableWidth * 0.75f;

            e.Graphics.DrawString("Người mua hàng", fontNormal, Brushes.Black,
                new RectangleF(leftSignatureX - 100, y, 200, 20), signatureFormat);

            e.Graphics.DrawString("Người bán hàng", fontNormal, Brushes.Black,
                new RectangleF(rightSignatureX - 100, y, 200, 20), signatureFormat);

            y += 20;
            e.Graphics.DrawString("(Ký, ghi rõ họ tên)", fontSmall, Brushes.Black,
                new RectangleF(leftSignatureX - 100, y, 200, 20), signatureFormat);

            e.Graphics.DrawString("(Ký, ghi rõ họ tên)", fontSmall, Brushes.Black,
                new RectangleF(rightSignatureX - 100, y, 200, 20), signatureFormat);

            y += 100;
        }

        private async void PrintButton_Click(object sender, EventArgs e)
        {
            await LoadInvoice();
            printDocument.PrintPage -= PrintDocument_PrintPage;
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog dialog = new PrintDialog();
            dialog.Document = printDocument;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


        }

        private async void PrintPreeviewButton_Click(object sender, EventArgs e)
        {
            await LoadInvoice();
            printDocument.PrintPage -= PrintDocument_PrintPage;
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }
    }
}

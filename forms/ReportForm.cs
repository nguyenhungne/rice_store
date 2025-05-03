using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using rice_store.services.type;

namespace rice_store.forms
{
    public partial class ReportForm : Form
    {
        private readonly PurchaseOrderService purchaseOrderService;
        private readonly SalesOrderService salesOrderService;
        private readonly PrintDocument printDocument = new();

        private List<PurchaseReportDTO> purchaseData = new();
        private List<SalesReportDTO> salesData = new();

        // Constants
        private readonly Font fontTitle = new("Arial", 20, FontStyle.Bold);
        private readonly Font fontPeriod = new("Arial", 16, FontStyle.Italic);
        private readonly Font fontHeader = new("Arial", 14, FontStyle.Bold);
        private readonly Font fontRow = new("Arial", 13);
        private readonly Font fontBold = new("Arial", 13, FontStyle.Bold);

        private readonly Brush brown = new SolidBrush(Color.FromArgb(139, 69, 19));
        private readonly Brush green = new SolidBrush(Color.FromArgb(0, 128, 0));
        private readonly Brush red = new SolidBrush(Color.FromArgb(192, 0, 0));
        private readonly Brush periodBrush = new SolidBrush(Color.FromArgb(102, 51, 0));
        private readonly Brush black = Brushes.Black;

        private readonly StringFormat centerAlign = new()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        public ReportForm()
        {
            InitializeComponent();
            purchaseOrderService = Program.ServiceProvider.GetRequiredService<PurchaseOrderService>();
            salesOrderService = Program.ServiceProvider.GetRequiredService<SalesOrderService>();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            await LoadDataAndRenderChartAsync();
        }

        private void InitializeComboBoxes()
        {
            var months = Enumerable.Range(1, 12).Select(i => $"Tháng {i}").ToArray();
            startMonthComboBox.Items.AddRange(months);
            endMonthComboBox.Items.AddRange(months);

            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 2; i <= currentYear + 2; i++)
                yearComboBox.Items.Add(i);

            yearComboBox.SelectedItem = currentYear;
            startMonthComboBox.SelectedIndex = 0;
            endMonthComboBox.SelectedIndex = 11;
        }

        private string GetMonthName(int month) => $"Tháng {month}";

        private async void filterButton_Click_1(object sender, EventArgs e) => await LoadDataAndRenderChartAsync();

        private async Task LoadDataAndRenderChartAsync()
        {
            int start = startMonthComboBox.SelectedIndex + 1;
            int end = endMonthComboBox.SelectedIndex + 1;
            int year = (int)yearComboBox.SelectedItem;

            purchaseData = await purchaseOrderService.GetFilteredPurchaseDataAsync(start, end, year);
            salesData = await salesOrderService.GetFilteredSalesDataAsync(start, end, year);

            UpdateChart();
        }

        private void UpdateChart()
        {
            var merged = salesData.GroupJoin(purchaseData,
                s => s.Month,
                p => p.Month,
                (s, pGroup) => new
                {
                    s.Month,
                    Income = s.TotalAmount,
                    Expense = pGroup.FirstOrDefault()?.TotalAmount ?? 0
                }).OrderBy(x => x.Month).ToList();

            DataTable profitTable = new();
            profitTable.Columns.Add("Month", typeof(string));
            profitTable.Columns.Add("Revenue", typeof(decimal));
            foreach (var item in merged)
                profitTable.Rows.Add(GetMonthName(item.Month), item.Income - item.Expense);

            DataTable incomeTable = new();
            incomeTable.Columns.Add("Month", typeof(string));
            incomeTable.Columns.Add("Revenue", typeof(decimal));
            foreach (var s in salesData.OrderBy(x => x.Month))
                incomeTable.Rows.Add(GetMonthName(s.Month), s.TotalAmount);

            DataTable expenseTable = new();
            expenseTable.Columns.Add("Month", typeof(string));
            expenseTable.Columns.Add("Revenue", typeof(decimal));
            foreach (var p in purchaseData.OrderBy(x => x.Month))
                expenseTable.Rows.Add(GetMonthName(p.Month), p.TotalAmount);

            mainChart.Series["profit"].Points.DataBindXY(
                profitTable.AsEnumerable().Select(r => r["Month"]).ToArray(),
                profitTable.AsEnumerable().Select(r => r["Revenue"]).ToArray());

            mainChart.Series["profitLine"].Points.DataBindXY(
                profitTable.AsEnumerable().Select(r => r["Month"]).ToArray(),
                profitTable.AsEnumerable().Select(r => r["Revenue"]).ToArray());

            mainChart.Series["income"].Points.DataBindXY(
                incomeTable.AsEnumerable().Select(r => r["Month"]).ToArray(),
                incomeTable.AsEnumerable().Select(r => r["Revenue"]).ToArray());

            mainChart.Series["expense"].Points.DataBindXY(
                expenseTable.AsEnumerable().Select(r => r["Month"]).ToArray(),
                expenseTable.AsEnumerable().Select(r => r["Revenue"]).ToArray());
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            }.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float width = e.MarginBounds.Width;
            float left = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float cellWidth = width / 4f;
            float cellHeight = 30f;

            e.Graphics.DrawString("BÁO CÁO DOANH THU & CHI PHÍ", fontTitle, brown,
                new RectangleF(left, y, width, 40), centerAlign);
            y += 60;

            string period = $"Từ tháng {startMonthComboBox.SelectedItem} đến tháng {endMonthComboBox.SelectedItem}, năm {yearComboBox.SelectedItem}";
            e.Graphics.DrawString(period, fontPeriod, periodBrush,
                new RectangleF(left, y, width, 35), centerAlign);
            y += 50;

            string[] headers = { "Tháng", "Doanh thu", "Chi phí", "Lợi nhuận" };
            for (int i = 0; i < headers.Length; i++)
                e.Graphics.DrawString(headers[i], fontHeader, brown, new RectangleF(left + i * cellWidth, y, cellWidth, cellHeight), centerAlign);
            y += cellHeight + 5;

            var merged = salesData.GroupJoin(purchaseData,
                s => s.Month,
                p => p.Month,
                (s, pGroup) => new
                {
                    s.Month,
                    Income = s.TotalAmount,
                    Expense = pGroup.FirstOrDefault()?.TotalAmount ?? 0
                }).OrderBy(x => x.Month).ToList();

            foreach (var item in merged)
            {
                string[] row =
                {
                    GetMonthName(item.Month),
                    item.Income.ToString("N0"),
                    item.Expense.ToString("N0"),
                    (item.Income - item.Expense).ToString("N0")
                };
                for (int i = 0; i < row.Length; i++)
                {
                    Brush brush = i switch
                    {
                        1 => green,
                        2 => red,
                        3 => (item.Income - item.Expense) < 0 ? red : green,
                        _ => black
                    };
                    e.Graphics.DrawString(row[i], fontRow, brush, new RectangleF(left + i * cellWidth, y, cellWidth, cellHeight), centerAlign);
                }
                y += cellHeight;
            }

            y += 5;
            e.Graphics.DrawLine(Pens.Gray, left, y, left + width, y);
            y += 10;

            decimal totalIncome = salesData.Sum(x => x.TotalAmount);
            decimal totalExpense = purchaseData.Sum(x => x.TotalAmount);
            decimal totalProfit = totalIncome - totalExpense;

            string[] totals =
            {
                "Tổng cộng",
                totalIncome.ToString("N0"),
                totalExpense.ToString("N0"),
                totalProfit.ToString("N0")
            };

            for (int i = 0; i < totals.Length; i++)
            {
                Brush brush = i switch
                {
                    1 => green,
                    2 => red,
                    3 => totalProfit < 0 ? red : green,
                    _ => brown
                };
                e.Graphics.DrawString(totals[i], fontBold, brush, new RectangleF(left + i * cellWidth, y, cellWidth, cellHeight), centerAlign);
            }
        }
    }
}

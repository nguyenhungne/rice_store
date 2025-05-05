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

using rice_store.services.type;

namespace rice_store.forms
{
    public partial class HomeForm : Form
    {
        private readonly PurchaseOrderService purchaseOrderService;
        private readonly SalesOrderService salesOrderService;
        private List<PurchaseReportDTO> purchaseData = new();
        private List<SalesReportDTO> salesData = new();
        public HomeForm()
        {
            InitializeComponent();
            purchaseOrderService = Program.ServiceProvider.GetRequiredService<PurchaseOrderService>();
            salesOrderService = Program.ServiceProvider.GetRequiredService<SalesOrderService>();
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            await LoadDataAndRenderChartAsync();
        }

        private async Task LoadDataAndRenderChartAsync()
        {
            int start = 1;
            int end = 12;
            int currentYear = DateTime.Now.Year;
            int year = currentYear;

            purchaseData = await purchaseOrderService.GetFilteredPurchaseDataAsync(start, end, year);
            salesData = await salesOrderService.GetFilteredSalesDataAsync(start, end, year);

            UpdateChart();
        }

        private string GetMonthName(int month) => $"Tháng {month}";

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
    }
}

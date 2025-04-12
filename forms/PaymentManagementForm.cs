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
using rice_store.services;
using rice_store.models;
using System.Diagnostics;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class PaymentManagementForm : Form
    {
        private readonly IPaymentService _paymentService;
        private List<Payment> paymentsList;
        public PaymentManagementForm()
        {
            InitializeComponent();
            _paymentService = Program.ServiceProvider.GetRequiredService<PaymentService>();
        }

        private void PaymentManagementForm_Load(object sender, EventArgs e)
        {
            LoadPaymentsAsync(null, null);
            initialMonthComboBox();
            initialYearComboBox();
        }

        private void initialMonthComboBox()
        {
            monthComboBox.SelectedIndex = 0;
        }

        private void initialYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            yearComboBox.Items.Add("Select A Year");
            for (int year = currentYear; year >= currentYear - 10; year--)
            {
                yearComboBox.Items.Add(year.ToString());
            }
            yearComboBox.SelectedIndex = 0;
        }

        private async void LoadPaymentsAsync(string? selectedMonthName, string? selectedYear)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedMonthName) && selectedMonthName == "Select A Month")
                {
                    MessageBox.Show($"Please Select A Month!");
                    return;
                }

                if (!string.IsNullOrEmpty(selectedYear) && selectedYear == "Select A Year")
                {
                    MessageBox.Show($"Please Select A Year!");
                    return;
                }

                // Get the filtered payments from the service
                IEnumerable<Payment> payments = await _paymentService.GetAllPaymentsAsync(selectedMonthName, selectedYear);

                // Clear previous data
                paymentDataGridView.Rows.Clear();

                paymentsList = payments.ToList(); // Store the payments in a list for later use

                // Display the payments in the data grid
                foreach (Payment payment in payments)
                {
                    paymentDataGridView.Rows.Add(
                        payment.Contract.Id.ToString(),
                        payment.Contract.Tenant.Name,
                        payment.Contract.Property.Name,
                        MoneyFormatter.FormatToVND(payment.Amount),
                        payment.DueDate.ToString("dd/MM/yyyy"),
                        payment.Status == "Completed" ? "Đã thanh toán" : "Chưa thanh toán"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when loading payments: {ex.Message}");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            // Get selected values from ComboBoxes
            String? selectedMonthName = monthComboBox.SelectedItem?.ToString();
            String? selectedYear = yearComboBox.SelectedItem?.ToString();

            // Load payments with selected filters
            LoadPaymentsAsync(selectedMonthName, selectedYear);
        }

        private void editButton_Click(object? sender, EventArgs e)
        {
            bankNametextBox.ReadOnly = false;
            bankAccountNameTextBox.ReadOnly = false;
            bankNumberTextBox.ReadOnly = false;
            editButton.Text = "Save";
            editButton.Click -= editButton_Click;
            editButton.Click += ButtonSave_Click;
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            // Save the changes to the payment information
            // You can implement the logic to save the changes here
            bankNametextBox.ReadOnly = true;
            bankAccountNameTextBox.ReadOnly = true;
            bankNumberTextBox.ReadOnly = true;
            editButton.Text = "Edit";
            editButton.Click -= ButtonSave_Click;
            editButton.Click += editButton_Click;
        }

        private void paymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the click is on a valid row (not the header)
            if (e.RowIndex >= 0 && e.RowIndex < paymentsList.Count)
            {
                DataGridViewRow row = paymentDataGridView.Rows[e.RowIndex];

                if (row == null || row.Cells.Count == 0)
                {
                    MessageBox.Show("Cannot read the payment details!");
                    return; // No valid row clicked
                }

                Payment selectedPayment = paymentsList[e.RowIndex];
                // Display the payment details in the labels
                roomNumberDetailContent.Text = selectedPayment.Contract.Property.Name ?? "-----";
                tentantDetailContent.Text = selectedPayment.Contract.Tenant.Name ?? "-----";
                paymentDateDetailContent.Text = selectedPayment.PaymentDate?.ToString("dd/MM/yyyy") ?? "-----";
                rentDetailContent.Text = MoneyFormatter.FormatToVND(selectedPayment.Contract.PricePerDay) ?? "-----";
                electricityFeeContent.Text = MoneyFormatter.FormatToVND(200) ?? "-----";
                waterFeeContent.Text = MoneyFormatter.FormatToVND(100) ?? "-----";
                additionalFeeContent.Text = MoneyFormatter.FormatToVND(0) ?? "-----";
                totalContent.Text = MoneyFormatter.FormatToVND(selectedPayment.Amount) ?? "-----";

                // Handle status display
                if (selectedPayment.Status == "Completed")
                {
                    statusContent.Text = "Đã thanh toán";
                    statusContent.ForeColor = Color.Green;
                }
                else if (selectedPayment.Status == "Pending")
                {
                    statusContent.Text = "Chưa thanh toán";
                    statusContent.ForeColor = Color.Red;
                }
                else
                {
                    statusContent.Text = "Unknown Status";
                    statusContent.ForeColor = Color.Black;
                }
            }
        }
    }
}

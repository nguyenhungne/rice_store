using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using rice_store.services;
using System.Diagnostics;
using rice_store.models;
using rice_store.utils;

namespace rice_store.forms
{
    public partial class ContractManagementForm : Form
    {
        private readonly IContractService _contractService;
        public ContractManagementForm()
        {
            InitializeComponent();
            _contractService = Program.ServiceProvider.GetRequiredService<ContractService>();
        }

        private void InitializeDataGridView()
        {
        }

        private async void ContractManagementForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadContractsAsync();
        }

        private async Task LoadContractsAsync()
        {
            try
            {
                IEnumerable<Contract> contracts = await _contractService.GetAllContractsAsync();
                Debug.WriteLine($"Number of contracts: {contracts}");
                foreach (Contract contract in contracts)
                {
                    dataGridViewContracts.Rows.Add(
                        contract.Property.Name,
                        contract.Property.Type,
                        MoneyFormatter.FormatToVND(contract.PricePerDay),
                        contract.IsExtended ? "Gia hạn" : "Không gia hạn"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when loading contracts: {ex.Message}");
            }
        }

        private void dataGridViewContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

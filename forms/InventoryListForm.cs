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
    public partial class InventoryListForm : Form
    {
        private readonly InventoryService inventoryService;
        private InventoryManagementForm? inventoryManagementForm;
        public InventoryListForm()
        {
            InitializeComponent();
            inventoryService = Program.ServiceProvider.GetRequiredService<InventoryService>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void InventoryListForm_Load(object sender, EventArgs e)
        {
            await LoadFilteredInventory();
        }

        private async Task LoadFilteredInventory()
        {
            InventoryFilter filter = new InventoryFilter
            {
                inventoryName = inventoryNameTextBox.Text,
            };
            IEnumerable<Inventory> inventories = await inventoryService.GetAllInventoriesAsync(filter);

            inventoryDataGridView.Rows.Clear();
            foreach (Inventory inventory in inventories)
            {
                inventoryDataGridView.Rows.Add(inventory.Id, inventory.name);
            }
        }

        private async void filterButton_Click(object sender, EventArgs e)
        {
            // Reload the form to apply the filter
            await LoadFilteredInventory();
        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == inventoryDataGridView.Columns["InventoryDetail"].Index && e.RowIndex >= 0)
            {
                var row = inventoryDataGridView.Rows[e.RowIndex];
                string? itemId = row.Cells["inventoryId"].Value.ToString();
                string? itemName = row.Cells["inventoryName"].Value.ToString();
                if (itemId == null || itemName == null)
                {
                    MessageBox.Show("Please select a valid inventory item.");
                    return;
                }
                InventoryManagementForm inventoryManagementForm = new InventoryManagementForm(itemId, itemName, this);
                inventoryManagementForm.MdiParent = this.MdiParent;
                inventoryManagementForm.Dock = DockStyle.Fill;
                inventoryManagementForm.Show();
            }
        }
    }
}

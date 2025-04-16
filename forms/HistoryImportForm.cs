using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rice_store.forms
{
    public partial class HistoryImportForm : Form
    {
        private readonly InventoryManagementForm inventoryManagementForm;
        public HistoryImportForm(InventoryManagementForm inventoryManagementForm)
        {
            InitializeComponent();
            this.inventoryManagementForm = inventoryManagementForm;
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
    }
}

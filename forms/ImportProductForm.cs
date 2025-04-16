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
    public partial class ImportProductForm : Form
    {
        private readonly InventoryManagementForm inventoryManagementForm;
        public ImportProductForm(InventoryManagementForm inventoryManagementForm)
        {
            InitializeComponent();
            this.inventoryManagementForm = inventoryManagementForm;
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

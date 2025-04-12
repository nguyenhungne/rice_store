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

namespace rice_store.forms
{
    public partial class ProductManagementForm : Form
    {
        private readonly IProductService productService;
        public ProductManagementForm()
        {
            InitializeComponent();
            productService = Program.ServiceProvider.GetRequiredService<ProductService>();
        }

        private async void ProductManagementForm_Load(object sender, EventArgs e)
        {
            // Set the font for the DataGridView
            productDataGridView.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // Set font for the header row
            productDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            // Set font for the rows
            productDataGridView.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            // Initialize the filter
            ProductFilter filter = new ProductFilter
            {
                ProductId = productIdTextBox.Text,   // Mã SP field
                ProductName = productNameTextBox.Text, // Tên SP field
                CategoryName = null, // productCategoryComboBox
            };

            // Load products data based on the filter
            IEnumerable<Product> products = await productService.GetAllProductsAsync(filter);

            // Populate the grid with product data
            productDataGridView.Rows.Clear();
            foreach (var product in products)
            {
                productDataGridView.Rows.Add(
                    product.Name,
                    product.Weight,
                    product.Origin,
                    product.PurchasePrice,
                    product.SellingPrice,
                    product.ExpirationDate.ToString("yyyy-MM-dd")
                );
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ProductManagementForm_Load(sender, e); // Call the form load method to apply the filter
        }
    }
}

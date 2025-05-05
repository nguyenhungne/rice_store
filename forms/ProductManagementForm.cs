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
        private readonly ICategoryService categoryService;
        private ProductInformationForm productInformationFrom;
        public ProductManagementForm()
        {
            InitializeComponent();
            productService = Program.ServiceProvider.GetRequiredService<ProductService>();
            categoryService = Program.ServiceProvider.GetRequiredService<CategoryService>();
            productInformationFrom = new ProductInformationForm(null, this);
        }

        public async void ProductManagementForm_Load(object sender, EventArgs e)
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
                //ProductId = productIdTextBox.Text,
                ProductName = productNameTextBox.Text,
                CategoryId = (int?)productCategoryComboBox.SelectedValue
            };

            // Load categories
            IEnumerable<Category> categories = await categoryService.GetAllCategoriesAsync();

            // Bind to ComboBox
            productCategoryComboBox.DisplayMember = "Name";
            productCategoryComboBox.ValueMember = "Id";
            productCategoryComboBox.DataSource = categories.ToList();
            productCategoryComboBox.SelectedIndex = -1; // Set to no selection

            // Ensure the selected value is maintained after reloading
            if (filter.CategoryId.HasValue)
            {
                productCategoryComboBox.SelectedValue = filter.CategoryId.Value;
            }

            // Load products data based on the filter
            IEnumerable<Product> products = await productService.GetAllProductsAsync(filter);

            // Populate the grid with product data
            productDataGridView.Rows.Clear();
            foreach (var product in products)
            {
                productDataGridView.Rows.Add(
                    product.Id,
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

        private void editProductButton_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int selectedRowIndex = productDataGridView.CurrentCell.RowIndex;

            // Check if a row is selected
            if (selectedRowIndex >= 0)
            {
                // Get the product ID from the selected row (assuming it's in the first column)
                int productId = (int)productDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                // Open the ProductInformationForm with the selected product ID
                productInformationFrom = new ProductInformationForm(productId, this);
                productInformationFrom.MdiParent = this.MdiParent;
                productInformationFrom.Dock = DockStyle.Fill;
                productInformationFrom.Show(); ;
            }
            else
            {
                MessageBox.Show("Hãy chọn một sản phẩm để chỉnh sửa.");
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            // Open the ProductInformationForm for adding a new product
            productInformationFrom = new ProductInformationForm(null, this);
            productInformationFrom.MdiParent = this.MdiParent;
            productInformationFrom.Dock = DockStyle.Fill;
            productInformationFrom.Show();
        }

        private async void deleteProductButton_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            int selectedRowIndex = productDataGridView.CurrentCell.RowIndex;

            // Check if a row is selected
            if (selectedRowIndex >= 0)
            {
                // Get the product ID from the selected row (assuming it's in the first column)
                int productId = (int)productDataGridView.Rows[selectedRowIndex].Cells[0].Value;

                // Confirm deletion
                var result = MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Call the DeleteProductAsync method
                        await productService.DeleteProductAsync(productId);

                        // Reload the products data
                        ProductManagementForm_Load(sender, e); // Reload the products list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một sản phẩm để xóa.");
            }
        }
    }
}

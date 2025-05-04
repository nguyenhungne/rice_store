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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using rice_store.models;

namespace rice_store.forms
{
    public partial class ProductInformationForm : Form
    {
        private int? _productId;
        private readonly ProductService productService;
        private readonly CategoryService categoryService;
        private readonly ProductManagementForm productManagementForm;
        public ProductInformationForm(int? productId, ProductManagementForm productManagementForm)
        {
            InitializeComponent();
            this._productId = productId;
            this.productManagementForm = productManagementForm;
            productService = Program.ServiceProvider.GetRequiredService<ProductService>();
            categoryService = Program.ServiceProvider.GetRequiredService<CategoryService>();
        }

        private async void ProductInformationForm_Load(object sender, EventArgs e)
        {
            if (_productId == null)
            {
                // Handle Add Product cases
                titleLabel.Text = "Thêm sản phẩm mới";
                actionButton.Text = "Thêm sản phẩm";
                await loadProductCategoryComboBox(null);
                return;
            }

            // Handle Edit Product cases
            // Load product information if _productId is not null
            // Assuming you have a method to get product by ID in your ProductService
            actionButton.Text = "Cập nhật sản phẩm";
            Product product = await productService.GetProductByIdAsync(_productId.Value);
            titleLabel.Text = $"Thông tin của sản phẩm {product.Name}";
            productNameTextBox.Text = product.Name;
            productOriginTextBox.Text = product.Origin;
            purchasePriceTextBox.Text = product.PurchasePrice.ToString();
            sellingPriceTextBox.Text = product.SellingPrice.ToString();
            productQualityTextBox.Text = product.Quality.ToString();
            await loadProductCategoryComboBox(product);
        }

        private async Task loadProductCategoryComboBox(Product? product)
        {
            // Load categories from the database and bind to the ComboBox
            // Assuming you have a method to get all categories in your CategoryService
            IEnumerable<Category> categories = await categoryService.GetAllCategoriesAsync();
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DataSource = categories.ToList();
            // Assuming you have a method to get product by ID in your ProductService
            if (product != null)
            {
                // Set the selected value to the product's category ID
                categoryComboBox.SelectedValue = product.CategoryId;
            }
            else
            {
                // Set to no selection if product is null
                categoryComboBox.SelectedIndex = -1;
            }
        }

        private async void actionButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(purchasePriceTextBox.Text, out decimal purchasePrice))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho giá mua.");
                return;
            }

            if (!decimal.TryParse(sellingPriceTextBox.Text, out decimal sellingPrice))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho giá bán.");
                return;
            }

            if (!float.TryParse("3", out float weight))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho trọng lượng.");
                return;
            }

            if (string.IsNullOrWhiteSpace(productNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(productOriginTextBox.Text) ||
                string.IsNullOrWhiteSpace(productQualityTextBox.Text))
            {
                MessageBox.Show("Tên sản phẩm, Xuất xứ, Chất lượng không thể để trống.");
                return;
            }

            if (_productId == null)
            {
                Product newProduct = new Product
                {
                    Name = productNameTextBox.Text,
                    Weight = weight,
                    Origin = productOriginTextBox.Text,
                    PurchasePrice = purchasePrice,
                    SellingPrice = sellingPrice,
                    Quality = productQualityTextBox.Text,
                    CategoryId = categoryComboBox.SelectedValue != null ? (int)categoryComboBox.SelectedValue : 0,
                    ExpirationDate = DateTime.Now.AddDays(30)
                };

                Product addedProduct = await productService.AddProductAsync(newProduct);

                if (addedProduct != null)
                {
                    productManagementForm.ProductManagementForm_Load(sender, e); // Refresh the product list in the main form
                    backButton_Click(sender, e); // Close the current form
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm sản phẩm.");
                }
            }
            else
            {
                Product updatedProduct = new Product
                {
                    Id = _productId.Value,
                    Name = productNameTextBox.Text,
                    Weight = weight,
                    Origin = productOriginTextBox.Text,
                    PurchasePrice = purchasePrice,
                    SellingPrice = sellingPrice,
                    Quality = productQualityTextBox.Text,
                    CategoryId = (int)categoryComboBox.SelectedValue,
                    ExpirationDate = DateTime.Now.AddDays(30)
                };

                Product updatedProductResult = await productService.UpdateProductAsync(updatedProduct);

                if (updatedProductResult != null)
                {
                    productManagementForm.ProductManagementForm_Load(sender, e); // Refresh the product list in the main form
                    backButton_Click(sender, e); // Close the current form
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật sản phẩm.");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the form and return to the previous one
            this.Close();
            productManagementForm.Show();
            productManagementForm.Activate();
        }
    }
}

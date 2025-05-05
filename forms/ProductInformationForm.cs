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
            try
            {
                // Validate Selling Price
                if (!decimal.TryParse(sellingPriceTextBox.Text, out decimal sellingPrice) || sellingPrice <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho giá bán.");
                    return;
                }

                // Validate Weight
                if (!float.TryParse("3", out float weight) || weight <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho trọng lượng.");
                    return;
                }

                // Validate Product Name, Origin, and Quality
                if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
                {
                    MessageBox.Show("Tên sản phẩm không thể để trống.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(productOriginTextBox.Text))
                {
                    MessageBox.Show("Xuất xứ không thể để trống.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(productQualityTextBox.Text))
                {
                    MessageBox.Show("Chất lượng không thể để trống.");
                    return;
                }

                // Validate Category
                if (categoryComboBox.SelectedValue == null || (int)categoryComboBox.SelectedValue <= 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục cho sản phẩm.");
                    return;
                }

                if (_productId == null)
                {
                    // Add Product
                    Product newProduct = new Product
                    {
                        Name = productNameTextBox.Text,
                        Weight = weight,
                        Origin = productOriginTextBox.Text,
                        SellingPrice = sellingPrice,
                        Quality = productQualityTextBox.Text,
                        CategoryId = (int)categoryComboBox.SelectedValue,
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
                    // Update Product
                    Product updatedProduct = new Product
                    {
                        Id = _productId.Value,
                        Name = productNameTextBox.Text,
                        Weight = weight,
                        Origin = productOriginTextBox.Text,
                        SellingPrice = sellingPrice,
                        Quality = productQualityTextBox.Text,
                        CategoryId = (int)categoryComboBox.SelectedValue
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
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
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

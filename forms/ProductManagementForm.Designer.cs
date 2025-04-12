namespace rice_store.forms
{
    partial class ProductManagementForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            productSearchPanel = new Panel();
            searchButton = new Guna.UI2.WinForms.Guna2Button();
            productIdTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            productCategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            productNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            productDataGridPanel = new Panel();
            productDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            productName = new DataGridViewTextBoxColumn();
            productWeight = new DataGridViewTextBoxColumn();
            productOrigin = new DataGridViewTextBoxColumn();
            purchasePriceProduct = new DataGridViewTextBoxColumn();
            sellingPriceProduct = new DataGridViewTextBoxColumn();
            expirationDateProduct = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            productSearchPanel.SuspendLayout();
            productDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productSearchPanel
            // 
            productSearchPanel.BorderStyle = BorderStyle.Fixed3D;
            productSearchPanel.Controls.Add(searchButton);
            productSearchPanel.Controls.Add(productIdTextBox);
            productSearchPanel.Controls.Add(productCategoryComboBox);
            productSearchPanel.Controls.Add(label4);
            productSearchPanel.Controls.Add(productNameTextBox);
            productSearchPanel.Controls.Add(label3);
            productSearchPanel.Controls.Add(label2);
            productSearchPanel.Controls.Add(label1);
            productSearchPanel.Dock = DockStyle.Right;
            productSearchPanel.Location = new Point(822, 0);
            productSearchPanel.Name = "productSearchPanel";
            productSearchPanel.Size = new Size(328, 586);
            productSearchPanel.TabIndex = 0;
            productSearchPanel.Tag = "";
            // 
            // searchButton
            // 
            searchButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            searchButton.CustomizableEdges = customizableEdges9;
            searchButton.DisabledState.BorderColor = Color.DarkGray;
            searchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            searchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchButton.Font = new Font("Segoe UI", 9F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(14, 467);
            searchButton.Name = "searchButton";
            searchButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            searchButton.Size = new Size(277, 74);
            searchButton.TabIndex = 10;
            searchButton.Text = "Tìm Kiếm";
            searchButton.Click += searchButton_Click;
            // 
            // productIdTextBox
            // 
            productIdTextBox.CustomizableEdges = customizableEdges11;
            productIdTextBox.DefaultText = "";
            productIdTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productIdTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productIdTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productIdTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productIdTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productIdTextBox.Font = new Font("Segoe UI", 9F);
            productIdTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productIdTextBox.Location = new Point(102, 64);
            productIdTextBox.Margin = new Padding(3, 4, 3, 4);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.PlaceholderText = "";
            productIdTextBox.SelectedText = "";
            productIdTextBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            productIdTextBox.Size = new Size(182, 41);
            productIdTextBox.TabIndex = 9;
            // 
            // productCategoryComboBox
            // 
            productCategoryComboBox.BackColor = Color.Transparent;
            productCategoryComboBox.CustomizableEdges = customizableEdges13;
            productCategoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            productCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productCategoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            productCategoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productCategoryComboBox.Font = new Font("Segoe UI", 10F);
            productCategoryComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            productCategoryComboBox.ItemHeight = 30;
            productCategoryComboBox.Location = new Point(102, 191);
            productCategoryComboBox.Name = "productCategoryComboBox";
            productCategoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            productCategoryComboBox.Size = new Size(185, 36);
            productCategoryComboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(14, 191);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 7;
            label4.Text = "Loại SP:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.CustomizableEdges = customizableEdges15;
            productNameTextBox.DefaultText = "";
            productNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productNameTextBox.Font = new Font("Segoe UI", 9F);
            productNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productNameTextBox.Location = new Point(102, 127);
            productNameTextBox.Margin = new Padding(3, 4, 3, 4);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.PlaceholderText = "";
            productNameTextBox.SelectedText = "";
            productNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges16;
            productNameTextBox.Size = new Size(182, 38);
            productNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 127);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 5;
            label3.Text = "Tên SP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            label1.Location = new Point(34, 6);
            label1.Name = "label1";
            label1.Size = new Size(240, 35);
            label1.TabIndex = 2;
            label1.Text = "Thông Tin Sản Phẩm";
            // 
            // productDataGridPanel
            // 
            productDataGridPanel.Controls.Add(productDataGridView);
            productDataGridPanel.Location = new Point(0, 0);
            productDataGridPanel.Name = "productDataGridPanel";
            productDataGridPanel.Size = new Size(816, 512);
            productDataGridPanel.TabIndex = 1;
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            productDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            productDataGridView.ColumnHeadersHeight = 50;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productDataGridView.Columns.AddRange(new DataGridViewColumn[] { productName, productWeight, productOrigin, purchasePriceProduct, sellingPriceProduct, expirationDateProduct });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            productDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            productDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            productDataGridView.Location = new Point(10, 8);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersVisible = false;
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.Size = new Size(799, 499);
            productDataGridView.TabIndex = 0;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            productDataGridView.ThemeStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            productDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            productDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            productDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            productDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            productDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            productDataGridView.ThemeStyle.ReadOnly = false;
            productDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            productDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productDataGridView.ThemeStyle.RowsStyle.Height = 29;
            productDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // productName
            // 
            productName.HeaderText = "Tên sản phẩm";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // productWeight
            // 
            productWeight.HeaderText = "Cân nặng";
            productWeight.MinimumWidth = 6;
            productWeight.Name = "productWeight";
            productWeight.ReadOnly = true;
            // 
            // productOrigin
            // 
            productOrigin.HeaderText = "Xuất xứ";
            productOrigin.MinimumWidth = 6;
            productOrigin.Name = "productOrigin";
            productOrigin.ReadOnly = true;
            // 
            // purchasePriceProduct
            // 
            purchasePriceProduct.HeaderText = "Giá nhập";
            purchasePriceProduct.MinimumWidth = 6;
            purchasePriceProduct.Name = "purchasePriceProduct";
            purchasePriceProduct.ReadOnly = true;
            // 
            // sellingPriceProduct
            // 
            sellingPriceProduct.HeaderText = "Giá bán";
            sellingPriceProduct.MinimumWidth = 6;
            sellingPriceProduct.Name = "sellingPriceProduct";
            sellingPriceProduct.ReadOnly = true;
            // 
            // expirationDateProduct
            // 
            expirationDateProduct.HeaderText = "Ngày hết hạn";
            expirationDateProduct.MinimumWidth = 6;
            expirationDateProduct.Name = "expirationDateProduct";
            expirationDateProduct.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(productDataGridPanel);
            panel1.Controls.Add(productSearchPanel);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 586);
            panel1.TabIndex = 0;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1147, 596);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductManagementForm";
            Text = "DashBoardForm";
            Load += ProductManagementForm_Load;
            productSearchPanel.ResumeLayout(false);
            productSearchPanel.PerformLayout();
            productDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel productSearchPanel;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2TextBox productIdTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox productCategoryComboBox;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox productNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel productDataGridPanel;
        private Guna.UI2.WinForms.Guna2DataGridView productDataGridView;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productWeight;
        private DataGridViewTextBoxColumn productOrigin;
        private DataGridViewTextBoxColumn purchasePriceProduct;
        private DataGridViewTextBoxColumn sellingPriceProduct;
        private DataGridViewTextBoxColumn expirationDateProduct;
        private Panel panel1;
    }
}

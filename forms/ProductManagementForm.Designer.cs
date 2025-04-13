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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Id = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productWeight = new DataGridViewTextBoxColumn();
            productOrigin = new DataGridViewTextBoxColumn();
            purchasePriceProduct = new DataGridViewTextBoxColumn();
            sellingPriceProduct = new DataGridViewTextBoxColumn();
            expirationDateProduct = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            actionButtonsPanel = new Panel();
            editProductButton = new Guna.UI2.WinForms.Guna2Button();
            deleteProductButton = new Guna.UI2.WinForms.Guna2Button();
            addProductButton = new Guna.UI2.WinForms.Guna2Button();
            productSearchPanel.SuspendLayout();
            productDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            panel1.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productSearchPanel
            // 
            productSearchPanel.Anchor = AnchorStyles.None;
            productSearchPanel.Controls.Add(searchButton);
            productSearchPanel.Controls.Add(productIdTextBox);
            productSearchPanel.Controls.Add(productCategoryComboBox);
            productSearchPanel.Controls.Add(label4);
            productSearchPanel.Controls.Add(productNameTextBox);
            productSearchPanel.Controls.Add(label3);
            productSearchPanel.Controls.Add(label2);
            productSearchPanel.Controls.Add(label1);
            productSearchPanel.Location = new Point(822, 20);
            productSearchPanel.Name = "productSearchPanel";
            productSearchPanel.Size = new Size(328, 746);
            productSearchPanel.TabIndex = 0;
            productSearchPanel.Tag = "";
            // 
            // searchButton
            // 
            searchButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            searchButton.CustomizableEdges = customizableEdges1;
            searchButton.DisabledState.BorderColor = Color.DarkGray;
            searchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            searchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchButton.Font = new Font("Segoe UI", 9F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(14, 538);
            searchButton.Name = "searchButton";
            searchButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchButton.Size = new Size(273, 74);
            searchButton.TabIndex = 10;
            searchButton.Text = "Tìm Kiếm";
            searchButton.Click += searchButton_Click;
            // 
            // productIdTextBox
            // 
            productIdTextBox.CustomizableEdges = customizableEdges3;
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
            productIdTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            productIdTextBox.Size = new Size(182, 41);
            productIdTextBox.TabIndex = 9;
            // 
            // productCategoryComboBox
            // 
            productCategoryComboBox.BackColor = Color.Transparent;
            productCategoryComboBox.CustomizableEdges = customizableEdges5;
            productCategoryComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            productCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productCategoryComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            productCategoryComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productCategoryComboBox.Font = new Font("Segoe UI", 10F);
            productCategoryComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            productCategoryComboBox.ItemHeight = 30;
            productCategoryComboBox.Location = new Point(102, 191);
            productCategoryComboBox.Name = "productCategoryComboBox";
            productCategoryComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            productNameTextBox.CustomizableEdges = customizableEdges7;
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
            productNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            productDataGridPanel.Anchor = AnchorStyles.None;
            productDataGridPanel.Controls.Add(productDataGridView);
            productDataGridPanel.Location = new Point(0, 0);
            productDataGridPanel.Name = "productDataGridPanel";
            productDataGridPanel.Size = new Size(816, 614);
            productDataGridPanel.TabIndex = 1;
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productDataGridView.ColumnHeadersHeight = 50;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, productName, productWeight, productOrigin, purchasePriceProduct, sellingPriceProduct, expirationDateProduct });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            productDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            productDataGridView.Location = new Point(10, 20);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersVisible = false;
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.Size = new Size(799, 587);
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
            // Id
            // 
            Id.HeaderText = "Mã SP";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
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
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(actionButtonsPanel);
            panel1.Controls.Add(productDataGridPanel);
            panel1.Controls.Add(productSearchPanel);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 766);
            panel1.TabIndex = 0;
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Anchor = AnchorStyles.None;
            actionButtonsPanel.Controls.Add(editProductButton);
            actionButtonsPanel.Controls.Add(deleteProductButton);
            actionButtonsPanel.Controls.Add(addProductButton);
            actionButtonsPanel.Location = new Point(13, 619);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(807, 136);
            actionButtonsPanel.TabIndex = 5;
            // 
            // editProductButton
            // 
            editProductButton.CustomizableEdges = customizableEdges9;
            editProductButton.DisabledState.BorderColor = Color.DarkGray;
            editProductButton.DisabledState.CustomBorderColor = Color.DarkGray;
            editProductButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editProductButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editProductButton.Font = new Font("Segoe UI", 9F);
            editProductButton.ForeColor = Color.White;
            editProductButton.Location = new Point(303, 13);
            editProductButton.Name = "editProductButton";
            editProductButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            editProductButton.Size = new Size(158, 73);
            editProductButton.TabIndex = 4;
            editProductButton.Text = "Chỉnh sửa sản phẩm";
            editProductButton.Click += editProductButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.CustomizableEdges = customizableEdges11;
            deleteProductButton.DisabledState.BorderColor = Color.DarkGray;
            deleteProductButton.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteProductButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteProductButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteProductButton.Font = new Font("Segoe UI", 9F);
            deleteProductButton.ForeColor = Color.White;
            deleteProductButton.Location = new Point(521, 13);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            deleteProductButton.Size = new Size(162, 71);
            deleteProductButton.TabIndex = 3;
            deleteProductButton.Text = "Xóa sản phẩm";
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // addProductButton
            // 
            addProductButton.CustomizableEdges = customizableEdges13;
            addProductButton.DisabledState.BorderColor = Color.DarkGray;
            addProductButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addProductButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addProductButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addProductButton.Font = new Font("Segoe UI", 9F);
            addProductButton.ForeColor = Color.White;
            addProductButton.Location = new Point(59, 13);
            addProductButton.Name = "addProductButton";
            addProductButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            addProductButton.Size = new Size(165, 71);
            addProductButton.TabIndex = 2;
            addProductButton.Text = "Thêm sản phẩm";
            addProductButton.Click += addProductButton_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1147, 766);
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
            actionButtonsPanel.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button editProductButton;
        private Guna.UI2.WinForms.Guna2Button deleteProductButton;
        private Guna.UI2.WinForms.Guna2Button addProductButton;
        private DataGridViewTextBoxColumn Id;
        private Panel actionButtonsPanel;
    }
}

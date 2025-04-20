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
using rice_store.utils;

namespace rice_store.forms
{
    public partial class InventoryManagementForm : Form
    {
        private readonly InventoryService inventoryService;
        private readonly WarehouseService warehouseService;

        private string inventoryId;
        private string inventoryName;
        private HistoryImportForm historyImportForm;
        private ImportProductForm importProductForm;
        private DataGridViewTextBoxColumn warehouseId;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn stockQuantity;
        private DataGridViewTextBoxColumn minQuantity;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn detail;
        private InventoryListForm inventoryListForm;
        public InventoryManagementForm(string inventoryId, string inventoryName, InventoryListForm inventoryListForm)
        {
            InitializeComponent();
            this.inventoryId = inventoryId;
            this.inventoryName = inventoryName;
            this.inventoryListForm = inventoryListForm;
            statusCombobox.Items.Add("---Chọn trạng thái---");
            statusCombobox.Items.Add("Còn hàng");
            statusCombobox.Items.Add("Sắp hết hàng");
            statusCombobox.Items.Add("Hết hàng");
            statusCombobox.SelectedIndex = 0;

            inventoryService = Program.ServiceProvider.GetRequiredService<InventoryService>();
            warehouseService = Program.ServiceProvider.GetRequiredService<WarehouseService>();
            importProductForm = new ImportProductForm(this, 0, "");
            historyImportForm = new HistoryImportForm(this, 0, "");
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel1 = new Panel();
            titleLabel = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label3 = new Label();
            InventoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            warehouseId = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            stockQuantity = new DataGridViewTextBoxColumn();
            minQuantity = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            detail = new DataGridViewButtonColumn();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            productNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label4 = new Label();
            filterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            importButton = new Guna.UI2.WinForms.Guna2GradientButton();
            statusCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2GradientPanel4.SuspendLayout();
            ((ISupportInitialize)InventoryDataGridView).BeginInit();
            guna2GradientPanel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            //
            // guna2GradientPanel1
            //
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Location = new Point(251, 182);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(0, 0);
            guna2GradientPanel1.TabIndex = 0;
            //
            // guna2GradientPanel2
            //
            guna2GradientPanel2.Anchor = AnchorStyles.None;
            guna2GradientPanel2.AutoSize = true;
            guna2GradientPanel2.BackColor = Color.PapayaWhip;
            guna2GradientPanel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            guna2GradientPanel2.Controls.Add(panel1);
            guna2GradientPanel2.Controls.Add(guna2GradientPanel4);
            guna2GradientPanel2.Controls.Add(guna2GradientPanel3);
            guna2GradientPanel2.CustomizableEdges = customizableEdges19;
            guna2GradientPanel2.Location = new Point(0, 0);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2GradientPanel2.Size = new Size(1150, 766);
            guna2GradientPanel2.TabIndex = 1;
            guna2GradientPanel2.Paint += guna2GradientPanel2_Paint;
            //
            // panel1
            //
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 133);
            panel1.TabIndex = 10;
            //
            // titleLabel
            //
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(111, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(269, 41);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "QUẢN LÍ KHO [...]";
            titleLabel.Click += label1_Click;
            //
            // guna2PictureBox1
            //
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(17, 19);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(88, 86);
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            //
            // guna2GradientPanel4
            //
            guna2GradientPanel4.Anchor = AnchorStyles.None;
            guna2GradientPanel4.Controls.Add(label3);
            guna2GradientPanel4.Controls.Add(InventoryDataGridView);
            guna2GradientPanel4.Controls.Add(guna2HtmlLabel2);
            guna2GradientPanel4.CustomizableEdges = customizableEdges5;
            guna2GradientPanel4.Location = new Point(388, 151);
            guna2GradientPanel4.Name = "guna2GradientPanel4";
            guna2GradientPanel4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel4.Size = new Size(756, 612);
            guna2GradientPanel4.TabIndex = 7;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(235, 31);
            label3.TabIndex = 7;
            label3.Text = "HÀNG HÓA TỒN KHO";
            //
            // InventoryDataGridView
            //
            dataGridViewCellStyle1.BackColor = Color.White;
            InventoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            InventoryDataGridView.BorderStyle = BorderStyle.Fixed3D;
            InventoryDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InventoryDataGridView.ColumnHeadersHeight = 30;
            InventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InventoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { warehouseId, productName, stockQuantity, minQuantity, status, detail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            InventoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            InventoryDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            InventoryDataGridView.Location = new Point(0, 48);
            InventoryDataGridView.Name = "InventoryDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            InventoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            InventoryDataGridView.RowHeadersVisible = false;
            InventoryDataGridView.RowHeadersWidth = 51;
            InventoryDataGridView.Size = new Size(756, 564);
            InventoryDataGridView.TabIndex = 0;
            InventoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            InventoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            InventoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            InventoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            InventoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            InventoryDataGridView.ThemeStyle.BackColor = Color.White;
            InventoryDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            InventoryDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            InventoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            InventoryDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            InventoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            InventoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InventoryDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            InventoryDataGridView.ThemeStyle.ReadOnly = false;
            InventoryDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            InventoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            InventoryDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            InventoryDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            InventoryDataGridView.ThemeStyle.RowsStyle.Height = 29;
            InventoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            InventoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            InventoryDataGridView.CellContentClick += guna2DataGridView1_CellContentClick;
            //
            // warehouseId
            //
            warehouseId.HeaderText = "Mã kho";
            warehouseId.MinimumWidth = 6;
            warehouseId.Name = "warehouseId";
            warehouseId.Visible = false;
            //
            // productName
            //
            productName.HeaderText = "Tên sản phẩm";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            //
            // stockQuantity
            //
            stockQuantity.HeaderText = "Số lượng";
            stockQuantity.MinimumWidth = 6;
            stockQuantity.Name = "stockQuantity";
            //
            // minQuantity
            //
            minQuantity.HeaderText = "Tồn kho tối thiểu";
            minQuantity.MinimumWidth = 6;
            minQuantity.Name = "minQuantity";
            //
            // status
            //
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            //
            // detail
            //
            detail.HeaderText = "Chi tiết";
            detail.MinimumWidth = 6;
            detail.Name = "detail";
            //
            // guna2HtmlLabel2
            //
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(15, 20);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(3, 2);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = null;
            //
            // guna2GradientPanel3
            //
            guna2GradientPanel3.Controls.Add(guna2Panel1);
            guna2GradientPanel3.CustomizableEdges = customizableEdges17;
            guna2GradientPanel3.Location = new Point(3, 151);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2GradientPanel3.Size = new Size(352, 610);
            guna2GradientPanel3.TabIndex = 6;
            //
            // guna2Panel1
            //
            guna2Panel1.Controls.Add(productNameTextBox);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(filterButton);
            guna2Panel1.Controls.Add(importButton);
            guna2Panel1.Controls.Add(statusCombobox);
            guna2Panel1.Controls.Add(guna2HtmlLabel6);
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Location = new Point(3, 45);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.Size = new Size(349, 567);
            guna2Panel1.TabIndex = 5;
            //
            // productNameTextBox
            //
            productNameTextBox.BorderRadius = 17;
            productNameTextBox.CustomizableEdges = customizableEdges7;
            productNameTextBox.DefaultText = "";
            productNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            productNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            productNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            productNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            productNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productNameTextBox.Font = new Font("Segoe UI", 9F);
            productNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            productNameTextBox.Location = new Point(6, 47);
            productNameTextBox.Margin = new Padding(3, 4, 3, 4);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.PlaceholderText = "";
            productNameTextBox.SelectedText = "";
            productNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            productNameTextBox.Size = new Size(340, 36);
            productNameTextBox.TabIndex = 19;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 101);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 16;
            label5.Text = "Trạng thái:";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(45, 28);
            label4.TabIndex = 15;
            label4.Text = "Tên:";
            //
            // filterButton
            //
            filterButton.BorderRadius = 15;
            filterButton.Cursor = Cursors.Hand;
            filterButton.CustomizableEdges = customizableEdges9;
            filterButton.DisabledState.BorderColor = Color.DarkGray;
            filterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            filterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            filterButton.FillColor = Color.BurlyWood;
            filterButton.FillColor2 = Color.Peru;
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(6, 219);
            filterButton.Name = "filterButton";
            filterButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            filterButton.Size = new Size(332, 44);
            filterButton.TabIndex = 14;
            filterButton.Text = "Lọc";
            filterButton.Click += filterButton_Click;
            //
            // importButton
            //
            importButton.BorderRadius = 15;
            importButton.Cursor = Cursors.Hand;
            importButton.CustomizableEdges = customizableEdges11;
            importButton.DisabledState.BorderColor = Color.DarkGray;
            importButton.DisabledState.CustomBorderColor = Color.DarkGray;
            importButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            importButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            importButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            importButton.FillColor = Color.SandyBrown;
            importButton.FillColor2 = Color.SandyBrown;
            importButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importButton.ForeColor = Color.White;
            importButton.Location = new Point(6, 269);
            importButton.Name = "importButton";
            importButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            importButton.Size = new Size(332, 44);
            importButton.TabIndex = 13;
            importButton.Text = "Nhập hàng";
            importButton.Click += importButton_Click;
            //
            // statusCombobox
            //
            statusCombobox.BackColor = Color.Transparent;
            statusCombobox.BorderRadius = 17;
            statusCombobox.CustomizableEdges = customizableEdges13;
            statusCombobox.DrawMode = DrawMode.OwnerDrawFixed;
            statusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCombobox.FocusedColor = Color.FromArgb(94, 148, 255);
            statusCombobox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            statusCombobox.Font = new Font("Segoe UI", 10F);
            statusCombobox.ForeColor = Color.FromArgb(68, 88, 112);
            statusCombobox.ItemHeight = 30;
            statusCombobox.Location = new Point(6, 152);
            statusCombobox.Name = "statusCombobox";
            statusCombobox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            statusCombobox.Size = new Size(340, 36);
            statusCombobox.TabIndex = 4;
            //
            // guna2HtmlLabel6
            //
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel6.Location = new Point(0, 81);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(3, 2);
            guna2HtmlLabel6.TabIndex = 2;
            guna2HtmlLabel6.Text = null;
            //
            // InventoryManagementForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1147, 766);
            ControlBox = false;
            Controls.Add(guna2GradientPanel2);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryManagementForm";
            Load += InventoryManagementForm_Load;
            guna2GradientPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)guna2PictureBox1).EndInit();
            guna2GradientPanel4.ResumeLayout(false);
            guna2GradientPanel4.PerformLayout();
            ((ISupportInitialize)InventoryDataGridView).EndInit();
            guna2GradientPanel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2DataGridView InventoryDataGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox statusCombobox;
        private Guna.UI2.WinForms.Guna2GradientButton filterButton;
        private Guna.UI2.WinForms.Guna2GradientButton importButton;
        private Panel panel1;
        private Label titleLabel;
        private Label label3;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox productNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == InventoryDataGridView.Columns["detail"].Index && e.RowIndex >= 0)
            {
                var row = InventoryDataGridView.Rows[e.RowIndex];
                string? warehouseId = row.Cells["warehouseId"].Value.ToString();
                string? productName = row.Cells["productName"].Value.ToString();

                if (productName == null || warehouseId == null)
                {
                    MessageBox.Show("Please select a valid inventory item.");
                    return;
                }
                int warehouseIdInt = int.Parse(warehouseId);

                HistoryImportForm historyImportForm = new HistoryImportForm(this, warehouseIdInt, productName);
                historyImportForm.MdiParent = this.MdiParent;
                historyImportForm.Dock = DockStyle.Fill;
                historyImportForm.Show();
                this.Close();
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {

            int inventoryIdInt = int.Parse(this.inventoryId);
            ImportProductForm importProductForm = new ImportProductForm(this, inventoryIdInt, inventoryName);
            importProductForm.MdiParent = this.MdiParent;
            importProductForm.Dock = DockStyle.Fill;
            importProductForm.Show();
            this.Close();
        }

        private async void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "QUẢN LÍ KHO " + inventoryName;
            WarehouseFilter filter = new WarehouseFilter
            {
                productName = productNameTextBox.Text,
                status = statusCombobox.Text == "---Chọn trạng thái---" ? null : statusCombobox.Text
            };

            int inventoryIdInt = int.Parse(this.inventoryId);
            IEnumerable<WarehouseDTO> warehouses = await warehouseService.GetAllWarehousesAsync(inventoryIdInt, filter);
            // Clear the existing rows in the DataGridView
            InventoryDataGridView.Rows.Clear();
            foreach (WarehouseDTO warehouse in warehouses)
            {
                int quality = warehouse.totalInboundQuantity - warehouse.totalSalesQuantity;
                InventoryDataGridView.Rows.Add(warehouse.Id, warehouse.Product.Name, quality, warehouse.MinThreshold, WarehouseStatusUtil.GetWarehouseStatus(quality, warehouse.MinThreshold), "Chi tiết");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            InventoryManagementForm_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace rice_store.forms
{
    partial class HistoryImportForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryImportForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            clearFilter = new Guna.UI2.WinForms.Guna2Button();
            startDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            supplierComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            filterButton = new Guna.UI2.WinForms.Guna2Button();
            purchaseOrderCodeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            panel2 = new Panel();
            backToInventoryButton = new Guna.UI2.WinForms.Guna2ImageButton();
            titleLabel = new Label();
            purchaseOrderDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            purchaseID = new DataGridViewTextBoxColumn();
            suplier = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            endDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(purchaseOrderDataGridView);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 766);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(endDateTimePicker);
            panel3.Controls.Add(clearFilter);
            panel3.Controls.Add(startDateTimePicker);
            panel3.Controls.Add(supplierComboBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(filterButton);
            panel3.Controls.Add(purchaseOrderCodeComboBox);
            panel3.Location = new Point(3, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(1144, 135);
            panel3.TabIndex = 3;
            // 
            // clearFilter
            // 
            clearFilter.BorderRadius = 17;
            clearFilter.CustomizableEdges = customizableEdges3;
            clearFilter.DisabledState.BorderColor = Color.DarkGray;
            clearFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            clearFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearFilter.FillColor = Color.FromArgb(255, 192, 128);
            clearFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearFilter.ForeColor = Color.White;
            clearFilter.Location = new Point(1001, 78);
            clearFilter.Name = "clearFilter";
            clearFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            clearFilter.Size = new Size(129, 36);
            clearFilter.TabIndex = 11;
            clearFilter.Text = "Xóa Lọc";
            clearFilter.Click += clearFilter_Click;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.BorderRadius = 17;
            startDateTimePicker.Checked = true;
            startDateTimePicker.CustomizableEdges = customizableEdges5;
            startDateTimePicker.Font = new Font("Segoe UI", 9F);
            startDateTimePicker.Format = DateTimePickerFormat.Long;
            startDateTimePicker.Location = new Point(710, 36);
            startDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            startDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            startDateTimePicker.Size = new Size(260, 36);
            startDateTimePicker.TabIndex = 10;
            startDateTimePicker.Value = new DateTime(2025, 4, 15, 11, 29, 10, 38);
            startDateTimePicker.ValueChanged += guna2DateTimePicker1_ValueChanged;
            // 
            // supplierComboBox
            // 
            supplierComboBox.BackColor = Color.Transparent;
            supplierComboBox.BorderRadius = 17;
            supplierComboBox.CustomizableEdges = customizableEdges7;
            supplierComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            supplierComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            supplierComboBox.Font = new Font("Segoe UI", 10F);
            supplierComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            supplierComboBox.ItemHeight = 30;
            supplierComboBox.Location = new Point(277, 78);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            supplierComboBox.Size = new Size(260, 36);
            supplierComboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(543, 31);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 7;
            label4.Text = "Ngày nhập hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(277, 28);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 6;
            label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 5;
            label2.Text = "Mã lô hàng:";
            // 
            // filterButton
            // 
            filterButton.BorderRadius = 17;
            filterButton.CustomizableEdges = customizableEdges9;
            filterButton.DisabledState.BorderColor = Color.DarkGray;
            filterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            filterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            filterButton.FillColor = Color.FromArgb(255, 192, 128);
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(1001, 31);
            filterButton.Name = "filterButton";
            filterButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            filterButton.Size = new Size(129, 36);
            filterButton.TabIndex = 3;
            filterButton.Text = "Lọc";
            filterButton.Click += filterButton_Click;
            // 
            // purchaseOrderCodeComboBox
            // 
            purchaseOrderCodeComboBox.BackColor = Color.Transparent;
            purchaseOrderCodeComboBox.BorderRadius = 17;
            purchaseOrderCodeComboBox.CustomizableEdges = customizableEdges11;
            purchaseOrderCodeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            purchaseOrderCodeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            purchaseOrderCodeComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            purchaseOrderCodeComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            purchaseOrderCodeComboBox.Font = new Font("Segoe UI", 10F);
            purchaseOrderCodeComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            purchaseOrderCodeComboBox.ItemHeight = 30;
            purchaseOrderCodeComboBox.Location = new Point(11, 78);
            purchaseOrderCodeComboBox.Name = "purchaseOrderCodeComboBox";
            purchaseOrderCodeComboBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            purchaseOrderCodeComboBox.Size = new Size(260, 36);
            purchaseOrderCodeComboBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(backToInventoryButton);
            panel2.Controls.Add(titleLabel);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 97);
            panel2.TabIndex = 2;
            // 
            // backToInventoryButton
            // 
            backToInventoryButton.CheckedState.ImageSize = new Size(64, 64);
            backToInventoryButton.Cursor = Cursors.Hand;
            backToInventoryButton.HoverState.ImageSize = new Size(64, 64);
            backToInventoryButton.Image = (Image)resources.GetObject("backToInventoryButton.Image");
            backToInventoryButton.ImageOffset = new Point(0, 0);
            backToInventoryButton.ImageRotate = 0F;
            backToInventoryButton.Location = new Point(11, 16);
            backToInventoryButton.Name = "backToInventoryButton";
            backToInventoryButton.PressedState.ImageSize = new Size(64, 64);
            backToInventoryButton.ShadowDecoration.CustomizableEdges = customizableEdges13;
            backToInventoryButton.Size = new Size(80, 68);
            backToInventoryButton.TabIndex = 5;
            backToInventoryButton.Click += backToInventoryButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(97, 18);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(301, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "LỊCH SỬ NHẬP KHO";
            titleLabel.Click += label1_Click;
            // 
            // purchaseOrderDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            purchaseOrderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            purchaseOrderDataGridView.BorderStyle = BorderStyle.Fixed3D;
            purchaseOrderDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            purchaseOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            purchaseOrderDataGridView.ColumnHeadersHeight = 24;
            purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            purchaseOrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { purchaseID, suplier, date, quantity, price });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            purchaseOrderDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            purchaseOrderDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            purchaseOrderDataGridView.Location = new Point(0, 254);
            purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            purchaseOrderDataGridView.RowHeadersVisible = false;
            purchaseOrderDataGridView.RowHeadersWidth = 51;
            purchaseOrderDataGridView.Size = new Size(1147, 512);
            purchaseOrderDataGridView.TabIndex = 0;
            purchaseOrderDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            purchaseOrderDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            purchaseOrderDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            purchaseOrderDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            purchaseOrderDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            purchaseOrderDataGridView.ThemeStyle.BackColor = Color.White;
            purchaseOrderDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            purchaseOrderDataGridView.ThemeStyle.HeaderStyle.Height = 24;
            purchaseOrderDataGridView.ThemeStyle.ReadOnly = false;
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.Height = 29;
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            purchaseOrderDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            purchaseOrderDataGridView.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // purchaseID
            // 
            purchaseID.HeaderText = "Mã lô hàng";
            purchaseID.MinimumWidth = 6;
            purchaseID.Name = "purchaseID";
            // 
            // suplier
            // 
            suplier.HeaderText = "Nhà cung cấp";
            suplier.MinimumWidth = 6;
            suplier.Name = "suplier";
            // 
            // date
            // 
            date.HeaderText = "Ngày nhập hàng";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // quantity
            // 
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // price
            // 
            price.HeaderText = "Giá nhập";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Resizable = DataGridViewTriState.True;
            price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.BorderRadius = 17;
            endDateTimePicker.Checked = true;
            endDateTimePicker.CustomizableEdges = customizableEdges1;
            endDateTimePicker.Font = new Font("Segoe UI", 9F);
            endDateTimePicker.Format = DateTimePickerFormat.Long;
            endDateTimePicker.Location = new Point(710, 78);
            endDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            endDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            endDateTimePicker.Size = new Size(260, 36);
            endDateTimePicker.TabIndex = 12;
            endDateTimePicker.Value = new DateTime(2025, 4, 15, 11, 29, 10, 38);
            // 
            // HistoryImportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1147, 766);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoryImportForm";
            Text = "HistoryImportForm";
            Load += HistoryImportForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseOrderDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseOrderDataGridView;
        private Panel panel2;
        private Label titleLabel;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox purchaseOrderCodeComboBox;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox supplierComboBox;
        private Guna.UI2.WinForms.Guna2ImageButton backToInventoryButton;
        private DataGridViewTextBoxColumn purchaseID;
        private DataGridViewTextBoxColumn suplier;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private Guna.UI2.WinForms.Guna2Button clearFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDateTimePikcer;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDateTimePikcer;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDateTimePicker;
    }
}

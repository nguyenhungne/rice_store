﻿namespace rice_store.forms
{
    partial class InventoryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryListForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            filterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            inventoryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            inventoryNameLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            inventoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            inventoryId = new DataGridViewTextBoxColumn();
            inventoryName = new DataGridViewTextBoxColumn();
            InventoryDetail = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2Panel1);
            panel1.Controls.Add(filterButton);
            panel1.Controls.Add(inventoryNameTextBox);
            panel1.Controls.Add(inventoryNameLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 157);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(3, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(184, 154);
            guna2Panel1.TabIndex = 24;
            // 
            // filterButton
            // 
            filterButton.BorderRadius = 15;
            filterButton.Cursor = Cursors.Hand;
            filterButton.CustomizableEdges = customizableEdges3;
            filterButton.DisabledState.BorderColor = Color.DarkGray;
            filterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            filterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            filterButton.FillColor = Color.BurlyWood;
            filterButton.FillColor2 = Color.Peru;
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(952, 110);
            filterButton.Name = "filterButton";
            filterButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            filterButton.Size = new Size(151, 44);
            filterButton.TabIndex = 23;
            filterButton.Text = "Tìm kiếm";
            filterButton.Click += filterButton_Click;
            // 
            // inventoryNameTextBox
            // 
            inventoryNameTextBox.BorderRadius = 17;
            inventoryNameTextBox.CustomizableEdges = customizableEdges5;
            inventoryNameTextBox.DefaultText = "";
            inventoryNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inventoryNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inventoryNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inventoryNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inventoryNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inventoryNameTextBox.Font = new Font("Segoe UI", 9F);
            inventoryNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inventoryNameTextBox.Location = new Point(763, 53);
            inventoryNameTextBox.Margin = new Padding(3, 4, 3, 4);
            inventoryNameTextBox.Name = "inventoryNameTextBox";
            inventoryNameTextBox.PlaceholderText = "";
            inventoryNameTextBox.SelectedText = "";
            inventoryNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            inventoryNameTextBox.Size = new Size(340, 36);
            inventoryNameTextBox.TabIndex = 22;
            // 
            // inventoryNameLabel
            // 
            inventoryNameLabel.AutoSize = true;
            inventoryNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryNameLabel.Location = new Point(763, 9);
            inventoryNameLabel.Name = "inventoryNameLabel";
            inventoryNameLabel.Size = new Size(45, 28);
            inventoryNameLabel.TabIndex = 21;
            inventoryNameLabel.Text = "Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 22);
            label1.Name = "label1";
            label1.Size = new Size(312, 41);
            label1.TabIndex = 11;
            label1.Text = "QUẢN LÍ KHO HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(inventoryDataGridView);
            panel2.Location = new Point(-4, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 548);
            panel2.TabIndex = 1;
            // 
            // inventoryDataGridView
            // 
            inventoryDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            inventoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            inventoryDataGridView.BorderStyle = BorderStyle.Fixed3D;
            inventoryDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            inventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            inventoryDataGridView.ColumnHeadersHeight = 22;
            inventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            inventoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { inventoryId, inventoryName, InventoryDetail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            inventoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            inventoryDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            inventoryDataGridView.Location = new Point(6, 14);
            inventoryDataGridView.Name = "inventoryDataGridView";
            inventoryDataGridView.ReadOnly = true;
            inventoryDataGridView.RowHeadersVisible = false;
            inventoryDataGridView.RowHeadersWidth = 51;
            inventoryDataGridView.Size = new Size(1129, 531);
            inventoryDataGridView.TabIndex = 0;
            inventoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            inventoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            inventoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            inventoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            inventoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            inventoryDataGridView.ThemeStyle.BackColor = Color.White;
            inventoryDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            inventoryDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            inventoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            inventoryDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            inventoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            inventoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            inventoryDataGridView.ThemeStyle.HeaderStyle.Height = 22;
            inventoryDataGridView.ThemeStyle.ReadOnly = true;
            inventoryDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            inventoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            inventoryDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            inventoryDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            inventoryDataGridView.ThemeStyle.RowsStyle.Height = 29;
            inventoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            inventoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            inventoryDataGridView.CellContentClick += inventoryDataGridView_CellContentClick;
            // 
            // inventoryId
            // 
            inventoryId.HeaderText = "Mã Kho Hàng";
            inventoryId.MinimumWidth = 6;
            inventoryId.Name = "inventoryId";
            inventoryId.ReadOnly = true;
            // 
            // inventoryName
            // 
            inventoryName.HeaderText = "Tên Kho Hàng";
            inventoryName.MinimumWidth = 6;
            inventoryName.Name = "inventoryName";
            inventoryName.ReadOnly = true;
            // 
            // InventoryDetail
            // 
            InventoryDetail.HeaderText = "Quản lí kho này";
            InventoryDetail.MinimumWidth = 6;
            InventoryDetail.Name = "InventoryDetail";
            InventoryDetail.ReadOnly = true;
            InventoryDetail.Text = "Chọn";
            InventoryDetail.UseColumnTextForButtonValue = true;
            // 
            // InventoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1129, 719);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryListForm";
            Text = "InventoryListForm";
            Load += InventoryListForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView inventoryDataGridView;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox inventoryNameTextBox;
        private Label inventoryNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton filterButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private DataGridViewTextBoxColumn inventoryId;
        private DataGridViewTextBoxColumn inventoryName;
        private DataGridViewButtonColumn InventoryDetail;
    }
}

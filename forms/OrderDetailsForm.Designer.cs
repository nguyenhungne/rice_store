namespace rice_store.forms
{
    partial class OrderDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            back = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            orderDetaildatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetaildatagridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(back);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2Panel1);
            panel1.Controls.Add(orderDetaildatagridview);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 766);
            panel1.TabIndex = 0;
            // 
            // back
            // 
            back.BorderRadius = 20;
            back.Cursor = Cursors.Hand;
            back.CustomizableEdges = customizableEdges1;
            back.DisabledState.BorderColor = Color.DarkGray;
            back.DisabledState.CustomBorderColor = Color.DarkGray;
            back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            back.FillColor = Color.SandyBrown;
            back.Font = new Font("Segoe UI", 9F);
            back.ForeColor = Color.White;
            back.Location = new Point(894, 127);
            back.Name = "back";
            back.ShadowDecoration.CustomizableEdges = customizableEdges2;
            back.Size = new Size(225, 47);
            back.TabIndex = 3;
            back.Text = "Trở về";
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 20);
            label1.Name = "label1";
            label1.Size = new Size(385, 50);
            label1.TabIndex = 2;
            label1.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(3, 11);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(145, 106);
            guna2Panel1.TabIndex = 1;
            // 
            // orderDetaildatagridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            orderDetaildatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            orderDetaildatagridview.BorderStyle = BorderStyle.Fixed3D;
            orderDetaildatagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            orderDetaildatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            orderDetaildatagridview.ColumnHeadersHeight = 22;
            orderDetaildatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            orderDetaildatagridview.Columns.AddRange(new DataGridViewColumn[] { id, productName, quantity, unitPrice, total });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            orderDetaildatagridview.DefaultCellStyle = dataGridViewCellStyle3;
            orderDetaildatagridview.GridColor = Color.FromArgb(231, 229, 255);
            orderDetaildatagridview.Location = new Point(0, 193);
            orderDetaildatagridview.Name = "orderDetaildatagridview";
            orderDetaildatagridview.ReadOnly = true;
            orderDetaildatagridview.RowHeadersVisible = false;
            orderDetaildatagridview.RowHeadersWidth = 51;
            orderDetaildatagridview.Size = new Size(1131, 526);
            orderDetaildatagridview.TabIndex = 0;
            orderDetaildatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            orderDetaildatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            orderDetaildatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            orderDetaildatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            orderDetaildatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            orderDetaildatagridview.ThemeStyle.BackColor = Color.White;
            orderDetaildatagridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            orderDetaildatagridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            orderDetaildatagridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Raised;
            orderDetaildatagridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            orderDetaildatagridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            orderDetaildatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            orderDetaildatagridview.ThemeStyle.HeaderStyle.Height = 22;
            orderDetaildatagridview.ThemeStyle.ReadOnly = true;
            orderDetaildatagridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            orderDetaildatagridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            orderDetaildatagridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            orderDetaildatagridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            orderDetaildatagridview.ThemeStyle.RowsStyle.Height = 29;
            orderDetaildatagridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            orderDetaildatagridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // productName
            // 
            productName.HeaderText = "Tên sản phẩm";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // unitPrice
            // 
            unitPrice.HeaderText = "Đơn giá";
            unitPrice.MinimumWidth = 6;
            unitPrice.Name = "unitPrice";
            unitPrice.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "Thành tiền";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 719);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetailsForm";
            Text = "OrderDetailsForm";
            Load += OrderDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetaildatagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView orderDetaildatagridview;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn total;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button back;
        private Label label1;
    }
}

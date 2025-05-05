namespace rice_store.forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            productButtonPanel = new Panel();
            dashboardButton = new Button();
            saleManagementPanel = new Panel();
            saleManagementButton = new Button();
            customerManagementPanel = new Panel();
            paymentManagementButton = new Button();
            accountManagementPanel = new Panel();
            accountManagementButton = new Button();
            inventoryManagementPanel = new Panel();
            utilityBillManagementButton = new Button();
            SupplierPanel = new Panel();
            sendNotificationButton = new Button();
            reportPanel = new Panel();
            systemSettingButton = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            productButtonPanel.SuspendLayout();
            saleManagementPanel.SuspendLayout();
            customerManagementPanel.SuspendLayout();
            accountManagementPanel.SuspendLayout();
            inventoryManagementPanel.SuspendLayout();
            SupplierPanel.SuspendLayout();
            reportPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(guna2Panel2);
            panel1.Controls.Add(guna2Panel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 69);
            panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackgroundImage = (Image)resources.GetObject("guna2Panel2.BackgroundImage");
            guna2Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Location = new Point(517, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(78, 63);
            guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(942, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(78, 63);
            guna2Panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(601, 18);
            label1.Name = "label1";
            label1.Size = new Size(335, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản Lí Cửa Hàng Gạo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(38, 50, 56);
            sidebar.Controls.Add(productButtonPanel);
            sidebar.Controls.Add(saleManagementPanel);
            sidebar.Controls.Add(customerManagementPanel);
            sidebar.Controls.Add(accountManagementPanel);
            sidebar.Controls.Add(inventoryManagementPanel);
            sidebar.Controls.Add(SupplierPanel);
            sidebar.Controls.Add(reportPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 69);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(299, 719);
            sidebar.TabIndex = 1;
            // 
            // productButtonPanel
            // 
            productButtonPanel.Controls.Add(dashboardButton);
            productButtonPanel.Location = new Point(3, 60);
            productButtonPanel.Margin = new Padding(3, 60, 3, 20);
            productButtonPanel.Name = "productButtonPanel";
            productButtonPanel.Size = new Size(295, 60);
            productButtonPanel.TabIndex = 6;
            productButtonPanel.Visible = false;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(38, 50, 56);
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(-22, -19);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(35, 0, 0, 0);
            dashboardButton.Size = new Size(349, 97);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "               Quản lí Sản Phẩm";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += handleDashboardButtonClick;
            // 
            // saleManagementPanel
            // 
            saleManagementPanel.Controls.Add(saleManagementButton);
            saleManagementPanel.Cursor = Cursors.Hand;
            saleManagementPanel.Location = new Point(3, 143);
            saleManagementPanel.Margin = new Padding(3, 3, 3, 20);
            saleManagementPanel.Name = "saleManagementPanel";
            saleManagementPanel.Size = new Size(295, 60);
            saleManagementPanel.TabIndex = 7;
            saleManagementPanel.Visible = false;
            // 
            // saleManagementButton
            // 
            saleManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            saleManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saleManagementButton.ForeColor = Color.White;
            saleManagementButton.Image = (Image)resources.GetObject("saleManagementButton.Image");
            saleManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            saleManagementButton.Location = new Point(-22, -19);
            saleManagementButton.Name = "saleManagementButton";
            saleManagementButton.Padding = new Padding(35, 0, 0, 0);
            saleManagementButton.Size = new Size(349, 97);
            saleManagementButton.TabIndex = 4;
            saleManagementButton.Text = "               Quản lí Bán Hàng";
            saleManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            saleManagementButton.UseVisualStyleBackColor = false;
            saleManagementButton.Click += contractManagementButton_Click;
            // 
            // customerManagementPanel
            // 
            customerManagementPanel.Controls.Add(paymentManagementButton);
            customerManagementPanel.Cursor = Cursors.Hand;
            customerManagementPanel.Location = new Point(3, 226);
            customerManagementPanel.Margin = new Padding(3, 3, 3, 20);
            customerManagementPanel.Name = "customerManagementPanel";
            customerManagementPanel.Size = new Size(295, 60);
            customerManagementPanel.TabIndex = 7;
            customerManagementPanel.Visible = false;
            // 
            // paymentManagementButton
            // 
            paymentManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            paymentManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentManagementButton.ForeColor = Color.White;
            paymentManagementButton.Image = (Image)resources.GetObject("paymentManagementButton.Image");
            paymentManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            paymentManagementButton.Location = new Point(-22, -19);
            paymentManagementButton.Name = "paymentManagementButton";
            paymentManagementButton.Padding = new Padding(35, 0, 0, 0);
            paymentManagementButton.Size = new Size(349, 97);
            paymentManagementButton.TabIndex = 4;
            paymentManagementButton.Text = "               Quản Lí Thành Viên";
            paymentManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            paymentManagementButton.UseVisualStyleBackColor = false;
            paymentManagementButton.Click += paymentManagementButton_Click;
            // 
            // accountManagementPanel
            // 
            accountManagementPanel.Controls.Add(accountManagementButton);
            accountManagementPanel.Cursor = Cursors.Hand;
            accountManagementPanel.Location = new Point(3, 309);
            accountManagementPanel.Margin = new Padding(3, 3, 3, 20);
            accountManagementPanel.Name = "accountManagementPanel";
            accountManagementPanel.Size = new Size(295, 60);
            accountManagementPanel.TabIndex = 7;
            accountManagementPanel.Visible = false;
            // 
            // accountManagementButton
            // 
            accountManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            accountManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountManagementButton.ForeColor = Color.White;
            accountManagementButton.Image = (Image)resources.GetObject("accountManagementButton.Image");
            accountManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            accountManagementButton.Location = new Point(-22, -19);
            accountManagementButton.Name = "accountManagementButton";
            accountManagementButton.Padding = new Padding(35, 0, 0, 0);
            accountManagementButton.Size = new Size(349, 97);
            accountManagementButton.TabIndex = 4;
            accountManagementButton.Text = "               Quản Lí TK Nhân Sự";
            accountManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            accountManagementButton.UseVisualStyleBackColor = false;
            accountManagementButton.Click += shortTermRentalManagementButton_Click;
            // 
            // inventoryManagementPanel
            // 
            inventoryManagementPanel.Controls.Add(utilityBillManagementButton);
            inventoryManagementPanel.Cursor = Cursors.Hand;
            inventoryManagementPanel.Location = new Point(3, 392);
            inventoryManagementPanel.Margin = new Padding(3, 3, 3, 20);
            inventoryManagementPanel.Name = "inventoryManagementPanel";
            inventoryManagementPanel.Size = new Size(295, 60);
            inventoryManagementPanel.TabIndex = 7;
            inventoryManagementPanel.Visible = false;
            // 
            // utilityBillManagementButton
            // 
            utilityBillManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            utilityBillManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utilityBillManagementButton.ForeColor = Color.White;
            utilityBillManagementButton.Image = (Image)resources.GetObject("utilityBillManagementButton.Image");
            utilityBillManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            utilityBillManagementButton.Location = new Point(-22, -19);
            utilityBillManagementButton.Name = "utilityBillManagementButton";
            utilityBillManagementButton.Padding = new Padding(35, 0, 0, 0);
            utilityBillManagementButton.Size = new Size(349, 97);
            utilityBillManagementButton.TabIndex = 4;
            utilityBillManagementButton.Text = "               Quản Lí Kho Hàng";
            utilityBillManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            utilityBillManagementButton.UseVisualStyleBackColor = false;
            utilityBillManagementButton.Click += utilityBillManagementButton_Click;
            // 
            // SupplierPanel
            // 
            SupplierPanel.Controls.Add(sendNotificationButton);
            SupplierPanel.Cursor = Cursors.Hand;
            SupplierPanel.Location = new Point(3, 475);
            SupplierPanel.Margin = new Padding(3, 3, 3, 20);
            SupplierPanel.Name = "SupplierPanel";
            SupplierPanel.Size = new Size(295, 60);
            SupplierPanel.TabIndex = 7;
            SupplierPanel.Visible = false;
            // 
            // sendNotificationButton
            // 
            sendNotificationButton.BackColor = Color.FromArgb(38, 50, 56);
            sendNotificationButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendNotificationButton.ForeColor = Color.White;
            sendNotificationButton.Image = (Image)resources.GetObject("sendNotificationButton.Image");
            sendNotificationButton.ImageAlign = ContentAlignment.MiddleLeft;
            sendNotificationButton.Location = new Point(-22, -19);
            sendNotificationButton.Name = "sendNotificationButton";
            sendNotificationButton.Padding = new Padding(35, 0, 0, 0);
            sendNotificationButton.Size = new Size(349, 97);
            sendNotificationButton.TabIndex = 4;
            sendNotificationButton.Text = "               Quản Lí Nhà Cung Cấp";
            sendNotificationButton.TextAlign = ContentAlignment.MiddleLeft;
            sendNotificationButton.UseVisualStyleBackColor = false;
            sendNotificationButton.Click += sendNotificationButton_Click_1;
            // 
            // reportPanel
            // 
            reportPanel.Controls.Add(systemSettingButton);
            reportPanel.Cursor = Cursors.Hand;
            reportPanel.Location = new Point(3, 558);
            reportPanel.Margin = new Padding(3, 3, 3, 20);
            reportPanel.Name = "reportPanel";
            reportPanel.Size = new Size(295, 60);
            reportPanel.TabIndex = 7;
            reportPanel.Visible = false;
            // 
            // systemSettingButton
            // 
            systemSettingButton.BackColor = Color.FromArgb(38, 50, 56);
            systemSettingButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemSettingButton.ForeColor = Color.White;
            systemSettingButton.Image = (Image)resources.GetObject("systemSettingButton.Image");
            systemSettingButton.ImageAlign = ContentAlignment.MiddleLeft;
            systemSettingButton.Location = new Point(-22, -19);
            systemSettingButton.Name = "systemSettingButton";
            systemSettingButton.Padding = new Padding(35, 0, 0, 0);
            systemSettingButton.Size = new Size(349, 97);
            systemSettingButton.TabIndex = 4;
            systemSettingButton.Text = "               Quản Lí Tài Chính";
            systemSettingButton.TextAlign = ContentAlignment.MiddleLeft;
            systemSettingButton.UseVisualStyleBackColor = false;
            systemSettingButton.Click += systemSettingButton_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1446, 788);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidebar.ResumeLayout(false);
            productButtonPanel.ResumeLayout(false);
            saleManagementPanel.ResumeLayout(false);
            customerManagementPanel.ResumeLayout(false);
            accountManagementPanel.ResumeLayout(false);
            inventoryManagementPanel.ResumeLayout(false);
            SupplierPanel.ResumeLayout(false);
            reportPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel productButtonPanel;
        private Button dashboardButton;
        private Panel saleManagementPanel;
        private Button saleManagementButton;
        private Panel customerManagementPanel;
        private Button paymentManagementButton;
        private Panel accountManagementPanel;
        private Button accountManagementButton;
        private Panel inventoryManagementPanel;
        private Button utilityBillManagementButton;
        private Panel SupplierPanel;
        private Button sendNotificationButton;
        private Panel reportPanel;
        private Button systemSettingButton;
        private System.Windows.Forms.Timer sidebarTransition;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

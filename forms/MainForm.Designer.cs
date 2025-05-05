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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            hamburgerButton = new Button();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            dashboardButtonPanel = new Panel();
            dashboardButton = new Button();
            contractManagementPanel = new Panel();
            contractManagementButton = new Button();
            paymentManagementPanel = new Panel();
            paymentManagementButton = new Button();
            shortTermRentalManagementPanel = new Panel();
            shortTermRentalManagementButton = new Button();
            utilityBillManagementPanel = new Panel();
            utilityBillManagementButton = new Button();
            sendNotificationPanel = new Panel();
            sendNotificationButton = new Button();
            systemSettingPanel = new Panel();
            systemSettingButton = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            dashboardButtonPanel.SuspendLayout();
            contractManagementPanel.SuspendLayout();
            paymentManagementPanel.SuspendLayout();
            shortTermRentalManagementPanel.SuspendLayout();
            utilityBillManagementPanel.SuspendLayout();
            sendNotificationPanel.SuspendLayout();
            systemSettingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(guna2Panel2);
            panel1.Controls.Add(guna2Panel1);
            panel1.Controls.Add(hamburgerButton);
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
            guna2Panel2.CustomizableEdges = customizableEdges13;
            guna2Panel2.Location = new Point(517, 3);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel2.Size = new Size(78, 63);
            guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges15;
            guna2Panel1.Location = new Point(942, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel1.Size = new Size(78, 63);
            guna2Panel1.TabIndex = 3;
            // 
            // hamburgerButton
            // 
            hamburgerButton.Location = new Point(21, 24);
            hamburgerButton.Name = "hamburgerButton";
            hamburgerButton.Size = new Size(123, 29);
            hamburgerButton.TabIndex = 2;
            hamburgerButton.Text = "Expand";
            hamburgerButton.UseVisualStyleBackColor = true;
            hamburgerButton.Click += hamburgerButton_Click;
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
            sidebar.Controls.Add(dashboardButtonPanel);
            sidebar.Controls.Add(contractManagementPanel);
            sidebar.Controls.Add(paymentManagementPanel);
            sidebar.Controls.Add(shortTermRentalManagementPanel);
            sidebar.Controls.Add(utilityBillManagementPanel);
            sidebar.Controls.Add(sendNotificationPanel);
            sidebar.Controls.Add(systemSettingPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 69);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(299, 719);
            sidebar.TabIndex = 1;
            // 
            // dashboardButtonPanel
            // 
            dashboardButtonPanel.Controls.Add(dashboardButton);
            dashboardButtonPanel.Location = new Point(3, 60);
            dashboardButtonPanel.Margin = new Padding(3, 60, 3, 20);
            dashboardButtonPanel.Name = "dashboardButtonPanel";
            dashboardButtonPanel.Size = new Size(295, 60);
            dashboardButtonPanel.TabIndex = 6;
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
            // contractManagementPanel
            // 
            contractManagementPanel.Controls.Add(contractManagementButton);
            contractManagementPanel.Cursor = Cursors.Hand;
            contractManagementPanel.Location = new Point(3, 143);
            contractManagementPanel.Margin = new Padding(3, 3, 3, 20);
            contractManagementPanel.Name = "contractManagementPanel";
            contractManagementPanel.Size = new Size(295, 60);
            contractManagementPanel.TabIndex = 7;
            // 
            // contractManagementButton
            // 
            contractManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            contractManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contractManagementButton.ForeColor = Color.White;
            contractManagementButton.Image = (Image)resources.GetObject("contractManagementButton.Image");
            contractManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            contractManagementButton.Location = new Point(-22, -19);
            contractManagementButton.Name = "contractManagementButton";
            contractManagementButton.Padding = new Padding(35, 0, 0, 0);
            contractManagementButton.Size = new Size(349, 97);
            contractManagementButton.TabIndex = 4;
            contractManagementButton.Text = "               Quản lí Bán Hàng";
            contractManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            contractManagementButton.UseVisualStyleBackColor = false;
            contractManagementButton.Click += contractManagementButton_Click;
            // 
            // paymentManagementPanel
            // 
            paymentManagementPanel.Controls.Add(paymentManagementButton);
            paymentManagementPanel.Cursor = Cursors.Hand;
            paymentManagementPanel.Location = new Point(3, 226);
            paymentManagementPanel.Margin = new Padding(3, 3, 3, 20);
            paymentManagementPanel.Name = "paymentManagementPanel";
            paymentManagementPanel.Size = new Size(295, 60);
            paymentManagementPanel.TabIndex = 7;
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
            // shortTermRentalManagementPanel
            // 
            shortTermRentalManagementPanel.Controls.Add(shortTermRentalManagementButton);
            shortTermRentalManagementPanel.Cursor = Cursors.Hand;
            shortTermRentalManagementPanel.Location = new Point(3, 309);
            shortTermRentalManagementPanel.Margin = new Padding(3, 3, 3, 20);
            shortTermRentalManagementPanel.Name = "shortTermRentalManagementPanel";
            shortTermRentalManagementPanel.Size = new Size(295, 60);
            shortTermRentalManagementPanel.TabIndex = 7;
            // 
            // shortTermRentalManagementButton
            // 
            shortTermRentalManagementButton.BackColor = Color.FromArgb(38, 50, 56);
            shortTermRentalManagementButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shortTermRentalManagementButton.ForeColor = Color.White;
            shortTermRentalManagementButton.Image = (Image)resources.GetObject("shortTermRentalManagementButton.Image");
            shortTermRentalManagementButton.ImageAlign = ContentAlignment.MiddleLeft;
            shortTermRentalManagementButton.Location = new Point(-22, -19);
            shortTermRentalManagementButton.Name = "shortTermRentalManagementButton";
            shortTermRentalManagementButton.Padding = new Padding(35, 0, 0, 0);
            shortTermRentalManagementButton.Size = new Size(349, 97);
            shortTermRentalManagementButton.TabIndex = 4;
            shortTermRentalManagementButton.Text = "               Quản Lí TK Nhân Sự";
            shortTermRentalManagementButton.TextAlign = ContentAlignment.MiddleLeft;
            shortTermRentalManagementButton.UseVisualStyleBackColor = false;
            shortTermRentalManagementButton.Click += shortTermRentalManagementButton_Click;
            // 
            // utilityBillManagementPanel
            // 
            utilityBillManagementPanel.Controls.Add(utilityBillManagementButton);
            utilityBillManagementPanel.Cursor = Cursors.Hand;
            utilityBillManagementPanel.Location = new Point(3, 392);
            utilityBillManagementPanel.Margin = new Padding(3, 3, 3, 20);
            utilityBillManagementPanel.Name = "utilityBillManagementPanel";
            utilityBillManagementPanel.Size = new Size(295, 60);
            utilityBillManagementPanel.TabIndex = 7;
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
            // sendNotificationPanel
            // 
            sendNotificationPanel.Controls.Add(sendNotificationButton);
            sendNotificationPanel.Cursor = Cursors.Hand;
            sendNotificationPanel.Location = new Point(3, 475);
            sendNotificationPanel.Margin = new Padding(3, 3, 3, 20);
            sendNotificationPanel.Name = "sendNotificationPanel";
            sendNotificationPanel.Size = new Size(295, 60);
            sendNotificationPanel.TabIndex = 7;
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
            // systemSettingPanel
            // 
            systemSettingPanel.Controls.Add(systemSettingButton);
            systemSettingPanel.Cursor = Cursors.Hand;
            systemSettingPanel.Location = new Point(3, 558);
            systemSettingPanel.Margin = new Padding(3, 3, 3, 20);
            systemSettingPanel.Name = "systemSettingPanel";
            systemSettingPanel.Size = new Size(295, 60);
            systemSettingPanel.TabIndex = 7;
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
            dashboardButtonPanel.ResumeLayout(false);
            contractManagementPanel.ResumeLayout(false);
            paymentManagementPanel.ResumeLayout(false);
            shortTermRentalManagementPanel.ResumeLayout(false);
            utilityBillManagementPanel.ResumeLayout(false);
            sendNotificationPanel.ResumeLayout(false);
            systemSettingPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel dashboardButtonPanel;
        private Button dashboardButton;
        private Panel contractManagementPanel;
        private Button contractManagementButton;
        private Panel paymentManagementPanel;
        private Button paymentManagementButton;
        private Panel shortTermRentalManagementPanel;
        private Button shortTermRentalManagementButton;
        private Panel utilityBillManagementPanel;
        private Button utilityBillManagementButton;
        private Panel sendNotificationPanel;
        private Button sendNotificationButton;
        private Panel systemSettingPanel;
        private Button systemSettingButton;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button hamburgerButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

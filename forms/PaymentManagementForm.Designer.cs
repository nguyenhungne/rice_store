namespace rice_store.forms
{
    partial class PaymentManagementForm
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
            paymentDataGridView = new DataGridView();
            contractId = new DataGridViewTextBoxColumn();
            tenantName = new DataGridViewTextBoxColumn();
            roomName = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            dueDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            paymentDataGridPanel = new Panel();
            paymentLabelLabel = new Label();
            yearComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            filterPanel = new Panel();
            filterButton = new Button();
            headerPanel = new Panel();
            paymentInformationText = new Label();
            separatorPanel = new Panel();
            bankNameLabel = new Label();
            bankAccountNameLabel = new Label();
            bankNumberLabel = new Label();
            bankNametextBox = new TextBox();
            bankAccountNameTextBox = new TextBox();
            bankNumberTextBox = new TextBox();
            editButton = new Button();
            panel1 = new Panel();
            panel8 = new Panel();
            statusContent = new Label();
            totalContent = new Label();
            label1 = new Label();
            statusTitle = new Label();
            totalTitle = new Label();
            waterRateTitle = new Label();
            ElectricityRateContent = new Label();
            ElectricityRateTitle = new Label();
            panel4 = new Panel();
            paymentDateDetailContent = new Label();
            tentantDetailContent = new Label();
            paymentDateDetailTitle = new Label();
            tentantDetailTitle = new Label();
            roomNumberDetailContent = new Label();
            roomNumberDetailTitle = new Label();
            panel3 = new Panel();
            paymentDetailLabel = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            additionalFeeContent = new Label();
            waterFeeContent = new Label();
            electricityFeeContent = new Label();
            additionalFeeTitle = new Label();
            waterFeeTitle = new Label();
            electricityFeeTitle = new Label();
            rentDetailContent = new Label();
            rentDetailTitle = new Label();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)paymentDataGridView).BeginInit();
            paymentDataGridPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            //
            // paymentDataGridView
            //
            paymentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentDataGridView.Columns.AddRange(new DataGridViewColumn[] { contractId, tenantName, roomName, amount, dueDate, status });
            paymentDataGridView.Dock = DockStyle.Fill;
            paymentDataGridView.Location = new Point(0, 0);
            paymentDataGridView.Name = "paymentDataGridView";
            paymentDataGridView.RowHeadersWidth = 51;
            paymentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentDataGridView.Size = new Size(580, 269);
            paymentDataGridView.TabIndex = 0;
            paymentDataGridView.CellClick += paymentDataGridView_CellClick;
            //
            // contractId
            //
            contractId.HeaderText = "Mã Hợp Đồng";
            contractId.MinimumWidth = 6;
            contractId.Name = "contractId";
            contractId.Width = 125;
            //
            // tenantName
            //
            tenantName.HeaderText = "Khách thuê";
            tenantName.MinimumWidth = 6;
            tenantName.Name = "tenantName";
            tenantName.Width = 125;
            //
            // roomName
            //
            roomName.HeaderText = "Phòng";
            roomName.MinimumWidth = 6;
            roomName.Name = "roomName";
            roomName.Width = 125;
            //
            // amount
            //
            amount.HeaderText = "Số tiền";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.Width = 125;
            //
            // dueDate
            //
            dueDate.HeaderText = "Hạn nộp";
            dueDate.MinimumWidth = 6;
            dueDate.Name = "dueDate";
            dueDate.Width = 125;
            //
            // status
            //
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            //
            // paymentDataGridPanel
            //
            paymentDataGridPanel.Controls.Add(paymentDataGridView);
            paymentDataGridPanel.Location = new Point(12, 92);
            paymentDataGridPanel.Name = "paymentDataGridPanel";
            paymentDataGridPanel.Size = new Size(580, 269);
            paymentDataGridPanel.TabIndex = 1;
            //
            // paymentLabelLabel
            //
            paymentLabelLabel.AutoSize = true;
            paymentLabelLabel.Font = new Font("Segoe UI", 12F);
            paymentLabelLabel.Location = new Point(3, 2);
            paymentLabelLabel.Name = "paymentLabelLabel";
            paymentLabelLabel.Size = new Size(235, 28);
            paymentLabelLabel.TabIndex = 2;
            paymentLabelLabel.Text = "Danh sách hóa đơn tháng";
            //
            // yearComboBox
            //
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(173, 7);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(164, 28);
            yearComboBox.TabIndex = 3;
            //
            // monthComboBox
            //
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "Select a month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(3, 7);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(164, 28);
            monthComboBox.TabIndex = 4;
            //
            // filterPanel
            //
            filterPanel.Controls.Add(filterButton);
            filterPanel.Controls.Add(yearComboBox);
            filterPanel.Controls.Add(monthComboBox);
            filterPanel.Location = new Point(12, 47);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(580, 39);
            filterPanel.TabIndex = 5;
            //
            // filterButton
            //
            filterButton.Font = new Font("Segoe UI", 10F);
            filterButton.Location = new Point(459, 0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(100, 39);
            filterButton.TabIndex = 5;
            filterButton.Text = "Lọc";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            //
            // headerPanel
            //
            headerPanel.Controls.Add(paymentLabelLabel);
            headerPanel.Location = new Point(12, 7);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(580, 34);
            headerPanel.TabIndex = 6;
            //
            // paymentInformationText
            //
            paymentInformationText.AutoSize = true;
            paymentInformationText.Font = new Font("Segoe UI", 12F);
            paymentInformationText.Location = new Point(27, 377);
            paymentInformationText.Name = "paymentInformationText";
            paymentInformationText.Size = new Size(196, 28);
            paymentInformationText.TabIndex = 7;
            paymentInformationText.Text = "Thông tin thanh toán";
            //
            // separatorPanel
            //
            separatorPanel.BorderStyle = BorderStyle.Fixed3D;
            separatorPanel.Location = new Point(21, 418);
            separatorPanel.Name = "separatorPanel";
            separatorPanel.Size = new Size(378, 4);
            separatorPanel.TabIndex = 8;
            //
            // bankNameLabel
            //
            bankNameLabel.AutoSize = true;
            bankNameLabel.Location = new Point(24, 430);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new Size(85, 20);
            bankNameLabel.TabIndex = 9;
            bankNameLabel.Text = "Ngân hàng:";
            //
            // bankAccountNameLabel
            //
            bankAccountNameLabel.AutoSize = true;
            bankAccountNameLabel.Location = new Point(27, 460);
            bankAccountNameLabel.Name = "bankAccountNameLabel";
            bankAccountNameLabel.Size = new Size(35, 20);
            bankAccountNameLabel.TabIndex = 10;
            bankAccountNameLabel.Text = "Tên:";
            //
            // bankNumberLabel
            //
            bankNumberLabel.AutoSize = true;
            bankNumberLabel.Location = new Point(24, 489);
            bankNumberLabel.Name = "bankNumberLabel";
            bankNumberLabel.Size = new Size(94, 20);
            bankNumberLabel.TabIndex = 11;
            bankNumberLabel.Text = "Số tài khoản:";
            //
            // bankNametextBox
            //
            bankNametextBox.Location = new Point(115, 427);
            bankNametextBox.Name = "bankNametextBox";
            bankNametextBox.ReadOnly = true;
            bankNametextBox.Size = new Size(167, 27);
            bankNametextBox.TabIndex = 12;
            bankNametextBox.Text = "ACB";
            //
            // bankAccountNameTextBox
            //
            bankAccountNameTextBox.Location = new Point(68, 457);
            bankAccountNameTextBox.Name = "bankAccountNameTextBox";
            bankAccountNameTextBox.ReadOnly = true;
            bankAccountNameTextBox.Size = new Size(167, 27);
            bankAccountNameTextBox.TabIndex = 13;
            bankAccountNameTextBox.Text = "Plumeria Home";
            //
            // bankNumberTextBox
            //
            bankNumberTextBox.Location = new Point(124, 486);
            bankNumberTextBox.Name = "bankNumberTextBox";
            bankNumberTextBox.ReadOnly = true;
            bankNumberTextBox.Size = new Size(167, 27);
            bankNumberTextBox.TabIndex = 14;
            bankNumberTextBox.Text = "1234 567 8910";
            //
            // editButton
            //
            editButton.Location = new Point(27, 519);
            editButton.Name = "editButton";
            editButton.Size = new Size(116, 32);
            editButton.TabIndex = 15;
            editButton.Text = "Chỉnh sửa";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            //
            // panel1
            //
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(598, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 586);
            panel1.TabIndex = 16;
            //
            // panel8
            //
            panel8.Controls.Add(statusContent);
            panel8.Controls.Add(totalContent);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(statusTitle);
            panel8.Controls.Add(totalTitle);
            panel8.Controls.Add(waterRateTitle);
            panel8.Controls.Add(ElectricityRateContent);
            panel8.Controls.Add(ElectricityRateTitle);
            panel8.Location = new Point(3, 369);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 152);
            panel8.TabIndex = 21;
            //
            // statusContent
            //
            statusContent.AutoSize = true;
            statusContent.ForeColor = Color.Green;
            statusContent.Location = new Point(90, 120);
            statusContent.Name = "statusContent";
            statusContent.Size = new Size(93, 20);
            statusContent.TabIndex = 7;
            statusContent.Text = "--------------";
            //
            // totalContent
            //
            totalContent.AutoSize = true;
            totalContent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalContent.Location = new Point(98, 85);
            totalContent.Name = "totalContent";
            totalContent.Size = new Size(93, 20);
            totalContent.TabIndex = 6;
            totalContent.Text = "--------------";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(65, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "----------";
            //
            // statusTitle
            //
            statusTitle.AutoSize = true;
            statusTitle.Location = new Point(11, 120);
            statusTitle.Name = "statusTitle";
            statusTitle.Size = new Size(78, 20);
            statusTitle.TabIndex = 4;
            statusTitle.Text = "Trạng thái:";
            //
            // totalTitle
            //
            totalTitle.AutoSize = true;
            totalTitle.Location = new Point(9, 85);
            totalTitle.Name = "totalTitle";
            totalTitle.Size = new Size(87, 20);
            totalTitle.TabIndex = 3;
            totalTitle.Text = "Tổng cộng: ";
            //
            // waterRateTitle
            //
            waterRateTitle.AutoSize = true;
            waterRateTitle.Location = new Point(9, 48);
            waterRateTitle.Name = "waterRateTitle";
            waterRateTitle.Size = new Size(52, 20);
            waterRateTitle.TabIndex = 2;
            waterRateTitle.Text = "Nước: ";
            //
            // ElectricityRateContent
            //
            ElectricityRateContent.AutoSize = true;
            ElectricityRateContent.Location = new Point(61, 12);
            ElectricityRateContent.Name = "ElectricityRateContent";
            ElectricityRateContent.Size = new Size(69, 20);
            ElectricityRateContent.TabIndex = 1;
            ElectricityRateContent.Text = "----------";
            //
            // ElectricityRateTitle
            //
            ElectricityRateTitle.AutoSize = true;
            ElectricityRateTitle.Location = new Point(9, 12);
            ElectricityRateTitle.Name = "ElectricityRateTitle";
            ElectricityRateTitle.Size = new Size(47, 20);
            ElectricityRateTitle.TabIndex = 0;
            ElectricityRateTitle.Text = "Điện: ";
            //
            // panel4
            //
            panel4.Controls.Add(paymentDateDetailContent);
            panel4.Controls.Add(tentantDetailContent);
            panel4.Controls.Add(paymentDateDetailTitle);
            panel4.Controls.Add(tentantDetailTitle);
            panel4.Controls.Add(roomNumberDetailContent);
            panel4.Controls.Add(roomNumberDetailTitle);
            panel4.Location = new Point(3, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 109);
            panel4.TabIndex = 19;
            //
            // paymentDateDetailContent
            //
            paymentDateDetailContent.AutoSize = true;
            paymentDateDetailContent.Location = new Point(90, 85);
            paymentDateDetailContent.Name = "paymentDateDetailContent";
            paymentDateDetailContent.Size = new Size(45, 20);
            paymentDateDetailContent.TabIndex = 5;
            paymentDateDetailContent.Text = "------";
            //
            // tentantDetailContent
            //
            tentantDetailContent.AutoSize = true;
            tentantDetailContent.Location = new Point(98, 48);
            tentantDetailContent.Name = "tentantDetailContent";
            tentantDetailContent.Size = new Size(45, 20);
            tentantDetailContent.TabIndex = 4;
            tentantDetailContent.Text = "------";
            //
            // paymentDateDetailTitle
            //
            paymentDateDetailTitle.AutoSize = true;
            paymentDateDetailTitle.Location = new Point(9, 85);
            paymentDateDetailTitle.Name = "paymentDateDetailTitle";
            paymentDateDetailTitle.Size = new Size(75, 20);
            paymentDateDetailTitle.TabIndex = 3;
            paymentDateDetailTitle.Text = "Ngày Trả: ";
            //
            // tentantDetailTitle
            //
            tentantDetailTitle.AutoSize = true;
            tentantDetailTitle.Location = new Point(9, 48);
            tentantDetailTitle.Name = "tentantDetailTitle";
            tentantDetailTitle.Size = new Size(88, 20);
            tentantDetailTitle.TabIndex = 2;
            tentantDetailTitle.Text = "Khách Thuê:";
            //
            // roomNumberDetailContent
            //
            roomNumberDetailContent.AutoSize = true;
            roomNumberDetailContent.Location = new Point(61, 12);
            roomNumberDetailContent.Name = "roomNumberDetailContent";
            roomNumberDetailContent.Size = new Size(45, 20);
            roomNumberDetailContent.TabIndex = 1;
            roomNumberDetailContent.Text = "------";
            //
            // roomNumberDetailTitle
            //
            roomNumberDetailTitle.AutoSize = true;
            roomNumberDetailTitle.Location = new Point(9, 12);
            roomNumberDetailTitle.Name = "roomNumberDetailTitle";
            roomNumberDetailTitle.Size = new Size(58, 20);
            roomNumberDetailTitle.TabIndex = 0;
            roomNumberDetailTitle.Text = "Phòng: ";
            //
            // panel3
            //
            panel3.Controls.Add(paymentDetailLabel);
            panel3.Location = new Point(3, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 78);
            panel3.TabIndex = 18;
            //
            // paymentDetailLabel
            //
            paymentDetailLabel.Anchor = AnchorStyles.None;
            paymentDetailLabel.AutoSize = true;
            paymentDetailLabel.Font = new Font("Segoe UI", 12F);
            paymentDetailLabel.Location = new Point(37, 26);
            paymentDetailLabel.Name = "paymentDetailLabel";
            paymentDetailLabel.Size = new Size(160, 28);
            paymentDetailLabel.TabIndex = 17;
            paymentDetailLabel.Text = "Chi Tiết Hóa Đơn";
            //
            // panel2
            //
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(3, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 4);
            panel2.TabIndex = 9;
            //
            // panel5
            //
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(598, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 10);
            panel5.TabIndex = 10;
            //
            // panel6
            //
            panel6.Controls.Add(additionalFeeContent);
            panel6.Controls.Add(waterFeeContent);
            panel6.Controls.Add(electricityFeeContent);
            panel6.Controls.Add(additionalFeeTitle);
            panel6.Controls.Add(waterFeeTitle);
            panel6.Controls.Add(electricityFeeTitle);
            panel6.Controls.Add(rentDetailContent);
            panel6.Controls.Add(rentDetailTitle);
            panel6.Location = new Point(603, 209);
            panel6.Name = "panel6";
            panel6.Size = new Size(241, 152);
            panel6.TabIndex = 20;
            //
            // additionalFeeContent
            //
            additionalFeeContent.AutoSize = true;
            additionalFeeContent.Location = new Point(114, 120);
            additionalFeeContent.Name = "additionalFeeContent";
            additionalFeeContent.Size = new Size(93, 20);
            additionalFeeContent.TabIndex = 7;
            additionalFeeContent.Text = "--------------";
            //
            // waterFeeContent
            //
            waterFeeContent.AutoSize = true;
            waterFeeContent.Location = new Point(95, 85);
            waterFeeContent.Name = "waterFeeContent";
            waterFeeContent.Size = new Size(93, 20);
            waterFeeContent.TabIndex = 6;
            waterFeeContent.Text = "--------------";
            //
            // electricityFeeContent
            //
            electricityFeeContent.AutoSize = true;
            electricityFeeContent.Location = new Point(86, 48);
            electricityFeeContent.Name = "electricityFeeContent";
            electricityFeeContent.Size = new Size(93, 20);
            electricityFeeContent.TabIndex = 5;
            electricityFeeContent.Text = "--------------";
            //
            // additionalFeeTitle
            //
            additionalFeeTitle.AutoSize = true;
            additionalFeeTitle.Location = new Point(11, 120);
            additionalFeeTitle.Name = "additionalFeeTitle";
            additionalFeeTitle.Size = new Size(97, 20);
            additionalFeeTitle.TabIndex = 4;
            additionalFeeTitle.Text = "Phí Phát Sinh:";
            //
            // waterFeeTitle
            //
            waterFeeTitle.AutoSize = true;
            waterFeeTitle.Location = new Point(9, 85);
            waterFeeTitle.Name = "waterFeeTitle";
            waterFeeTitle.Size = new Size(80, 20);
            waterFeeTitle.TabIndex = 3;
            waterFeeTitle.Text = "Tiền Nước:";
            //
            // electricityFeeTitle
            //
            electricityFeeTitle.AutoSize = true;
            electricityFeeTitle.Location = new Point(9, 48);
            electricityFeeTitle.Name = "electricityFeeTitle";
            electricityFeeTitle.Size = new Size(75, 20);
            electricityFeeTitle.TabIndex = 2;
            electricityFeeTitle.Text = "Tiền Điện:";
            //
            // rentDetailContent
            //
            rentDetailContent.AutoSize = true;
            rentDetailContent.Location = new Point(91, 12);
            rentDetailContent.Name = "rentDetailContent";
            rentDetailContent.Size = new Size(93, 20);
            rentDetailContent.TabIndex = 1;
            rentDetailContent.Text = "--------------";
            //
            // rentDetailTitle
            //
            rentDetailTitle.AutoSize = true;
            rentDetailTitle.Location = new Point(9, 12);
            rentDetailTitle.Name = "rentDetailTitle";
            rentDetailTitle.Size = new Size(76, 20);
            rentDetailTitle.TabIndex = 0;
            rentDetailTitle.Text = "Tiền Thuê:";
            //
            // panel7
            //
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Location = new Point(596, 367);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 10);
            panel7.TabIndex = 10;
            //
            // PaymentManagementForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 589);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(editButton);
            Controls.Add(bankNumberTextBox);
            Controls.Add(bankAccountNameTextBox);
            Controls.Add(bankNametextBox);
            Controls.Add(bankNumberLabel);
            Controls.Add(bankAccountNameLabel);
            Controls.Add(bankNameLabel);
            Controls.Add(separatorPanel);
            Controls.Add(paymentInformationText);
            Controls.Add(headerPanel);
            Controls.Add(filterPanel);
            Controls.Add(paymentDataGridPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentManagementForm";
            Text = "PaymentManagementForm";
            Load += PaymentManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)paymentDataGridView).EndInit();
            paymentDataGridPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView paymentDataGridView;
        private Panel paymentDataGridPanel;
        private DataGridViewTextBoxColumn contractId;
        private DataGridViewTextBoxColumn tenantName;
        private DataGridViewTextBoxColumn roomName;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn dueDate;
        private DataGridViewTextBoxColumn status;
        private Label paymentLabelLabel;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private Panel filterPanel;
        private Panel headerPanel;
        private Button filterButton;
        private Label paymentInformationText;
        private Panel separatorPanel;
        private Label bankNameLabel;
        private Label bankAccountNameLabel;
        private Label bankNumberLabel;
        private TextBox bankNametextBox;
        private TextBox bankAccountNameTextBox;
        private TextBox bankNumberTextBox;
        private Button editButton;
        private Panel panel1;
        private Panel panel2;
        private Label paymentDetailLabel;
        private Panel panel3;
        private Panel panel4;
        private Label roomNumberDetailContent;
        private Label roomNumberDetailTitle;
        private Label paymentDateDetailTitle;
        private Label tentantDetailTitle;
        private Panel panel5;
        private Panel panel6;
        private Label waterFeeTitle;
        private Label electricityFeeTitle;
        private Label rentDetailContent;
        private Label rentDetailTitle;
        private Panel panel8;
        private Label statusTitle;
        private Label totalTitle;
        private Label waterRateTitle;
        private Label ElectricityRateContent;
        private Label ElectricityRateTitle;
        private Label additionalFeeTitle;
        private Panel panel7;
        private Label tentantDetailContent;
        private Label paymentDateDetailContent;
        private Label additionalFeeContent;
        private Label waterFeeContent;
        private Label electricityFeeContent;
        private Label statusContent;
        private Label totalContent;
        private Label label1;
    }
}

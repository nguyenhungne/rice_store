namespace rice_store.forms
{
    partial class ContractManagementForm
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
            dataGridViewContracts = new DataGridView();
            panel1 = new Panel();
            RoomNo = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContracts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // dataGridViewContracts
            //
            dataGridViewContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContracts.Columns.AddRange(new DataGridViewColumn[] { RoomNo, RoomType, Price, Status });
            dataGridViewContracts.Dock = DockStyle.Fill;
            dataGridViewContracts.Location = new Point(0, 0);
            dataGridViewContracts.Margin = new Padding(0);
            dataGridViewContracts.Name = "dataGridViewContracts";
            dataGridViewContracts.RowHeadersWidth = 51;
            dataGridViewContracts.Size = new Size(553, 336);
            dataGridViewContracts.TabIndex = 0;
            dataGridViewContracts.CellContentClick += dataGridViewContracts_CellContentClick;
            //
            // panel1
            //
            panel1.Controls.Add(dataGridViewContracts);
            panel1.Location = new Point(12, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 336);
            panel1.TabIndex = 1;
            //
            // RoomNo
            //
            RoomNo.HeaderText = "Số phòng";
            RoomNo.MinimumWidth = 100;
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 125;
            //
            // RoomType
            //
            RoomType.HeaderText = "Loại phòng";
            RoomType.MinimumWidth = 100;
            RoomType.Name = "RoomType";
            RoomType.Width = 125;
            //
            // Price
            //
            Price.HeaderText = "Giá theo ngày";
            Price.MinimumWidth = 100;
            Price.Name = "Price";
            Price.Width = 135;
            //
            // Status
            //
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 100;
            Status.Name = "Status";
            Status.Width = 125;
            //
            // ContractManagementForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ContractManagementForm";
            Text = "ContractManagementForm";
            Load += ContractManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContracts).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewContracts;
        private Panel panel1;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Status;
    }
}

namespace rice_store.forms
{
    partial class UserManagementForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            editButton = new Guna.UI2.WinForms.Guna2Button();
            deleteButton = new Guna.UI2.WinForms.Guna2Button();
            addButton = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            searchEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            searchEmailLabel = new Label();
            searchNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            searchNameLabel = new Label();
            searchButton = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            userDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            anme = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(editButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(addButton);
            panel3.Location = new Point(-6, -21);
            panel3.Name = "panel3";
            panel3.Size = new Size(857, 92);
            panel3.TabIndex = 5;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.CustomizableEdges = customizableEdges1;
            editButton.DisabledState.BorderColor = Color.DarkGray;
            editButton.DisabledState.CustomBorderColor = Color.DarkGray;
            editButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editButton.Font = new Font("Segoe UI", 9F);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(287, 31);
            editButton.Name = "editButton";
            editButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            editButton.Size = new Size(277, 53);
            editButton.TabIndex = 2;
            editButton.Text = "Chỉnh sửa";
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.CustomizableEdges = customizableEdges3;
            deleteButton.DisabledState.BorderColor = Color.DarkGray;
            deleteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            deleteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deleteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deleteButton.Font = new Font("Segoe UI", 9F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(570, 33);
            deleteButton.Name = "deleteButton";
            deleteButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deleteButton.Size = new Size(265, 53);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Xóa";
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.CustomizableEdges = customizableEdges5;
            addButton.DisabledState.BorderColor = Color.DarkGray;
            addButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addButton.Font = new Font("Segoe UI", 9F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(18, 31);
            addButton.Name = "addButton";
            addButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            addButton.Size = new Size(263, 53);
            addButton.TabIndex = 0;
            addButton.Text = "Thêm";
            addButton.Click += addButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(searchEmailTextBox);
            panel2.Controls.Add(searchEmailLabel);
            panel2.Controls.Add(searchNameTextBox);
            panel2.Controls.Add(searchNameLabel);
            panel2.Controls.Add(searchButton);
            panel2.Location = new Point(857, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 713);
            panel2.TabIndex = 4;
            // 
            // searchEmailTextBox
            // 
            searchEmailTextBox.Anchor = AnchorStyles.None;
            searchEmailTextBox.CustomizableEdges = customizableEdges7;
            searchEmailTextBox.DefaultText = "";
            searchEmailTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchEmailTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchEmailTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchEmailTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchEmailTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEmailTextBox.Font = new Font("Segoe UI", 9F);
            searchEmailTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchEmailTextBox.Location = new Point(15, 123);
            searchEmailTextBox.Margin = new Padding(3, 4, 3, 4);
            searchEmailTextBox.Name = "searchEmailTextBox";
            searchEmailTextBox.PlaceholderText = "";
            searchEmailTextBox.SelectedText = "";
            searchEmailTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchEmailTextBox.Size = new Size(251, 35);
            searchEmailTextBox.TabIndex = 6;
            // 
            // searchEmailLabel
            // 
            searchEmailLabel.Anchor = AnchorStyles.None;
            searchEmailLabel.AutoSize = true;
            searchEmailLabel.Location = new Point(3, 99);
            searchEmailLabel.Name = "searchEmailLabel";
            searchEmailLabel.Size = new Size(46, 20);
            searchEmailLabel.TabIndex = 5;
            searchEmailLabel.Text = "Email";
            // 
            // searchNameTextBox
            // 
            searchNameTextBox.Anchor = AnchorStyles.None;
            searchNameTextBox.CustomizableEdges = customizableEdges9;
            searchNameTextBox.DefaultText = "";
            searchNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchNameTextBox.Font = new Font("Segoe UI", 9F);
            searchNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchNameTextBox.Location = new Point(15, 60);
            searchNameTextBox.Margin = new Padding(3, 4, 3, 4);
            searchNameTextBox.Name = "searchNameTextBox";
            searchNameTextBox.PlaceholderText = "";
            searchNameTextBox.SelectedText = "";
            searchNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            searchNameTextBox.Size = new Size(251, 35);
            searchNameTextBox.TabIndex = 2;
            // 
            // searchNameLabel
            // 
            searchNameLabel.Anchor = AnchorStyles.None;
            searchNameLabel.AutoSize = true;
            searchNameLabel.Location = new Point(3, 36);
            searchNameLabel.Name = "searchNameLabel";
            searchNameLabel.Size = new Size(32, 20);
            searchNameLabel.TabIndex = 1;
            searchNameLabel.Text = "Tên";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.None;
            searchButton.CustomizableEdges = customizableEdges11;
            searchButton.DisabledState.BorderColor = Color.DarkGray;
            searchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            searchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchButton.Font = new Font("Segoe UI", 9F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(15, 165);
            searchButton.Name = "searchButton";
            searchButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            searchButton.Size = new Size(251, 54);
            searchButton.TabIndex = 0;
            searchButton.Text = "Tìm kiếm";
            searchButton.Click += searchButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(userDataGridView);
            panel1.Location = new Point(-6, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 653);
            panel1.TabIndex = 3;
            // 
            // userDataGridView
            // 
            userDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userDataGridView.Anchor = AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userDataGridView.ColumnHeadersHeight = 50;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            userDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, anme, phone, email, salary });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            userDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            userDataGridView.Location = new Point(10, 3);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.ReadOnly = true;
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(843, 643);
            userDataGridView.TabIndex = 0;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            userDataGridView.ThemeStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            userDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            userDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            userDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            userDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            userDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            userDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            userDataGridView.ThemeStyle.ReadOnly = true;
            userDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            userDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            userDataGridView.ThemeStyle.RowsStyle.Height = 29;
            userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // anme
            // 
            anme.HeaderText = "Tên";
            anme.MinimumWidth = 6;
            anme.Name = "anme";
            anme.ReadOnly = true;
            // 
            // phone
            // 
            phone.HeaderText = "SĐT";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // salary
            // 
            salary.HeaderText = "Lương";
            salary.MinimumWidth = 6;
            salary.Name = "salary";
            salary.ReadOnly = true;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 719);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox searchEmailTextBox;
        private Label searchEmailLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchNameTextBox;
        private Label searchNameLabel;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView userDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn anme;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn salary;
    }
}

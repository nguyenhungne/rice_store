namespace rice_store.forms
{
    partial class ReportForm
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
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Legend legend1 = new FastReport.DataVisualization.Charting.Legend();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series2 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series3 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series4 = new FastReport.DataVisualization.Charting.Series();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            mainChart = new FastReport.DataVisualization.Charting.Chart();
            startMonthlabel = new Label();
            panel1 = new Panel();
            startMonthComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            endMonthComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            endMonthLabel = new Label();
            yearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            yearLabel = new Label();
            generateReportButton = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            filterButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainChart
            // 
            mainChart.BackColor = Color.PeachPuff;
            chartArea1.Name = "ChartArea1";
            mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            mainChart.Legends.Add(legend1);
            mainChart.Location = new Point(3, 3);
            mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Lợi nhuận";
            series1.Name = "profit";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Thu nhập";
            series2.Name = "income";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Chi phí";
            series3.Name = "expense";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Đường lợi nhuận";
            series4.Name = "profitLine";
            mainChart.Series.Add(series1);
            mainChart.Series.Add(series2);
            mainChart.Series.Add(series3);
            mainChart.Series.Add(series4);
            mainChart.Size = new Size(1126, 435);
            mainChart.TabIndex = 0;
            mainChart.Text = "Thu nhập";
            // 
            // startMonthlabel
            // 
            startMonthlabel.AutoSize = true;
            startMonthlabel.Font = new Font("Segoe UI", 12F);
            startMonthlabel.Location = new Point(10, 40);
            startMonthlabel.Name = "startMonthlabel";
            startMonthlabel.Size = new Size(138, 28);
            startMonthlabel.TabIndex = 1;
            startMonthlabel.Text = "Tháng bắt đầu";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(mainChart);
            panel1.Location = new Point(0, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 441);
            panel1.TabIndex = 2;
            // 
            // startMonthComboBox
            // 
            startMonthComboBox.BackColor = Color.Transparent;
            startMonthComboBox.BorderRadius = 17;
            startMonthComboBox.CustomizableEdges = customizableEdges1;
            startMonthComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            startMonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            startMonthComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            startMonthComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            startMonthComboBox.Font = new Font("Segoe UI", 10F);
            startMonthComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            startMonthComboBox.ItemHeight = 30;
            startMonthComboBox.Location = new Point(154, 40);
            startMonthComboBox.Name = "startMonthComboBox";
            startMonthComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            startMonthComboBox.Size = new Size(196, 36);
            startMonthComboBox.TabIndex = 3;
            // 
            // endMonthComboBox
            // 
            endMonthComboBox.BackColor = Color.Transparent;
            endMonthComboBox.BorderRadius = 17;
            endMonthComboBox.CustomizableEdges = customizableEdges3;
            endMonthComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            endMonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            endMonthComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            endMonthComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            endMonthComboBox.Font = new Font("Segoe UI", 10F);
            endMonthComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            endMonthComboBox.ItemHeight = 30;
            endMonthComboBox.Location = new Point(531, 40);
            endMonthComboBox.Name = "endMonthComboBox";
            endMonthComboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            endMonthComboBox.Size = new Size(196, 36);
            endMonthComboBox.TabIndex = 5;
            // 
            // endMonthLabel
            // 
            endMonthLabel.AutoSize = true;
            endMonthLabel.Font = new Font("Segoe UI", 12F);
            endMonthLabel.Location = new Point(387, 40);
            endMonthLabel.Name = "endMonthLabel";
            endMonthLabel.Size = new Size(141, 28);
            endMonthLabel.TabIndex = 4;
            endMonthLabel.Text = "Tháng kết thúc";
            // 
            // yearComboBox
            // 
            yearComboBox.BackColor = Color.Transparent;
            yearComboBox.BorderRadius = 17;
            yearComboBox.CustomizableEdges = customizableEdges5;
            yearComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            yearComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            yearComboBox.Font = new Font("Segoe UI", 10F);
            yearComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            yearComboBox.ItemHeight = 30;
            yearComboBox.Location = new Point(884, 40);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            yearComboBox.Size = new Size(196, 36);
            yearComboBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 12F);
            yearLabel.Location = new Point(795, 40);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(54, 28);
            yearLabel.TabIndex = 6;
            yearLabel.Text = "Năm";
            // 
            // generateReportButton
            // 
            generateReportButton.BorderRadius = 40;
            generateReportButton.Cursor = Cursors.Hand;
            generateReportButton.CustomizableEdges = customizableEdges7;
            generateReportButton.DisabledState.BorderColor = Color.DarkGray;
            generateReportButton.DisabledState.CustomBorderColor = Color.DarkGray;
            generateReportButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            generateReportButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            generateReportButton.FillColor = Color.SandyBrown;
            generateReportButton.Font = new Font("Segoe UI", 9F);
            generateReportButton.ForeColor = Color.White;
            generateReportButton.Location = new Point(780, 9);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            generateReportButton.Size = new Size(303, 100);
            generateReportButton.TabIndex = 9;
            generateReportButton.Text = "Xuất báo cáo";
            generateReportButton.Click += generateReportButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(filterButton);
            panel2.Controls.Add(yearComboBox);
            panel2.Controls.Add(yearLabel);
            panel2.Controls.Add(endMonthComboBox);
            panel2.Controls.Add(endMonthLabel);
            panel2.Controls.Add(startMonthComboBox);
            panel2.Controls.Add(startMonthlabel);
            panel2.Location = new Point(3, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 155);
            panel2.TabIndex = 10;
            // 
            // filterButton
            // 
            filterButton.BorderRadius = 20;
            filterButton.Cursor = Cursors.Hand;
            filterButton.CustomizableEdges = customizableEdges9;
            filterButton.DisabledState.BorderColor = Color.DarkGray;
            filterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            filterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            filterButton.FillColor = Color.SandyBrown;
            filterButton.Font = new Font("Segoe UI", 9F);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(762, 97);
            filterButton.Name = "filterButton";
            filterButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            filterButton.Size = new Size(318, 42);
            filterButton.TabIndex = 10;
            filterButton.Text = "Lọc";
            filterButton.Click += filterButton_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(6, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(131, 111);
            guna2Panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 50);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÍ TÀI CHÍNH";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1129, 719);
            Controls.Add(label1);
            Controls.Add(generateReportButton);
            Controls.Add(guna2Panel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private FastReport.DataVisualization.Charting.Chart mainChart;
        private Label startMonthlabel;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox startMonthComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox endMonthComboBox;
        private Label endMonthLabel;
        private Guna.UI2.WinForms.Guna2ComboBox yearComboBox;
        private Label yearLabel;
        private Guna.UI2.WinForms.Guna2Button generateReportButton;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
    }
}

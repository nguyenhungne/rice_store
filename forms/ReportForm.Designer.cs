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
            filterButton = new Guna.UI2.WinForms.Guna2Button();
            generateReportButton = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            mainChart.Legends.Add(legend1);
            mainChart.Location = new Point(3, 12);
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
            mainChart.Size = new Size(1098, 523);
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
            panel1.Location = new Point(12, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 538);
            panel1.TabIndex = 2;
            // 
            // startMonthComboBox
            // 
            startMonthComboBox.BackColor = Color.Transparent;
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
            yearComboBox.CustomizableEdges = customizableEdges5;
            yearComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            yearComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            yearComboBox.Font = new Font("Segoe UI", 10F);
            yearComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            yearComboBox.ItemHeight = 30;
            yearComboBox.Location = new Point(154, 97);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            yearComboBox.Size = new Size(196, 36);
            yearComboBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 12F);
            yearLabel.Location = new Point(10, 97);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(54, 28);
            yearLabel.TabIndex = 6;
            yearLabel.Text = "Năm";
            // 
            // filterButton
            // 
            filterButton.CustomizableEdges = customizableEdges7;
            filterButton.DisabledState.BorderColor = Color.DarkGray;
            filterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            filterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            filterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            filterButton.Font = new Font("Segoe UI", 9F);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(404, 97);
            filterButton.Name = "filterButton";
            filterButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            filterButton.Size = new Size(333, 36);
            filterButton.TabIndex = 8;
            filterButton.Text = "Lọc";
            filterButton.Click += filterButton_Click_1;
            // 
            // generateReportButton
            // 
            generateReportButton.CustomizableEdges = customizableEdges9;
            generateReportButton.DisabledState.BorderColor = Color.DarkGray;
            generateReportButton.DisabledState.CustomBorderColor = Color.DarkGray;
            generateReportButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            generateReportButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            generateReportButton.Font = new Font("Segoe UI", 9F);
            generateReportButton.ForeColor = Color.White;
            generateReportButton.Location = new Point(792, 39);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            generateReportButton.Size = new Size(303, 100);
            generateReportButton.TabIndex = 9;
            generateReportButton.Text = "Tạo Report";
            generateReportButton.Click += generateReportButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(generateReportButton);
            panel2.Controls.Add(filterButton);
            panel2.Controls.Add(yearComboBox);
            panel2.Controls.Add(yearLabel);
            panel2.Controls.Add(endMonthComboBox);
            panel2.Controls.Add(endMonthLabel);
            panel2.Controls.Add(startMonthComboBox);
            panel2.Controls.Add(startMonthlabel);
            panel2.Location = new Point(12, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 155);
            panel2.TabIndex = 10;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 719);
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
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Guna.UI2.WinForms.Guna2Button generateReportButton;
        private Panel panel2;
    }
}

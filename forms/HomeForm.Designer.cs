namespace rice_store.forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Legend legend1 = new FastReport.DataVisualization.Charting.Legend();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series2 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series3 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Series series4 = new FastReport.DataVisualization.Charting.Series();
            label1 = new Label();
            generateReportButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            mainChart = new FastReport.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-21, -127);
            label1.Name = "label1";
            label1.Size = new Size(371, 50);
            label1.TabIndex = 17;
            label1.Text = "QUẢN LÍ TÀI CHÍNH";
            // 
            // generateReportButton
            // 
            generateReportButton.BorderRadius = 40;
            generateReportButton.Cursor = Cursors.Hand;
            generateReportButton.CustomizableEdges = customizableEdges1;
            generateReportButton.DisabledState.BorderColor = Color.DarkGray;
            generateReportButton.DisabledState.CustomBorderColor = Color.DarkGray;
            generateReportButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            generateReportButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            generateReportButton.FillColor = Color.SandyBrown;
            generateReportButton.Font = new Font("Segoe UI", 9F);
            generateReportButton.ForeColor = Color.White;
            generateReportButton.Location = new Point(616, -127);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            generateReportButton.Size = new Size(303, 100);
            generateReportButton.TabIndex = 14;
            generateReportButton.Text = "Xuất báo cáo";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(-158, -133);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(131, 111);
            guna2Panel1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(mainChart);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 713);
            panel1.TabIndex = 13;
            // 
            // mainChart
            // 
            mainChart.BackColor = Color.PeachPuff;
            chartArea1.Name = "ChartArea1";
            mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            mainChart.Legends.Add(legend1);
            mainChart.Location = new Point(3, 0);
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
            mainChart.Size = new Size(1126, 713);
            mainChart.TabIndex = 0;
            mainChart.Text = "Thu nhập";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 719);
            Controls.Add(label1);
            Controls.Add(generateReportButton);
            Controls.Add(guna2Panel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button generateReportButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private FastReport.DataVisualization.Charting.Chart mainChart;
    }
}
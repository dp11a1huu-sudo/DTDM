namespace GUI.Controls
{
    partial class FoodReportsControl
    {
        private System.ComponentModel.IContainer components = null;
        private GUI.Controls.HeaderControl headerControl;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTopSeller;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.Panel panelRevenueChart;
        private System.Windows.Forms.Label lblRevenueChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel panelTopSellers;
        private System.Windows.Forms.Label lblTopSellersTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSellers;
        private System.Windows.Forms.DataGridView dgvTopSellers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerControl = new GUI.Controls.HeaderControl();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.panelTopSellers = new System.Windows.Forms.Panel();
            this.dgvTopSellers = new System.Windows.Forms.DataGridView();
            this.chartTopSellers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTopSellersTitle = new System.Windows.Forms.Label();
            this.panelRevenueChart = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueChartTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTopSeller = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelCharts.SuspendLayout();
            this.panelTopSellers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSellers)).BeginInit();
            this.panelRevenueChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerControl
            // 
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 70);
            this.headerControl.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainContainer.Controls.Add(this.panelCharts);
            this.mainContainer.Controls.Add(this.panelStats);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(30);
            this.mainContainer.Size = new System.Drawing.Size(1200, 730);
            this.mainContainer.TabIndex = 1;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.lblTopSeller);
            this.panelStats.Controls.Add(this.lblTotalOrders);
            this.panelStats.Controls.Add(this.lblTotalProfit);
            this.panelStats.Controls.Add(this.lblTotalRevenue);
            this.panelStats.Location = new System.Drawing.Point(30, 30);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1140, 100);
            this.panelStats.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(0, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Padding = new System.Windows.Forms.Padding(15);
            this.lblTotalRevenue.Size = new System.Drawing.Size(270, 100);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "💰\r\nTổng doanh thu:\r\n15.000.000 đ\r\n";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.BackColor = System.Drawing.Color.White;
            this.lblTotalProfit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalProfit.Location = new System.Drawing.Point(290, 0);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Padding = new System.Windows.Forms.Padding(15);
            this.lblTotalProfit.Size = new System.Drawing.Size(270, 100);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "📈\r\nLợi nhuận:\r\n7.500.000 đ\r\n";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.BackColor = System.Drawing.Color.White;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(580, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Padding = new System.Windows.Forms.Padding(15);
            this.lblTotalOrders.Size = new System.Drawing.Size(270, 100);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "📋\r\nTổng đơn hàng:\r\n150 đơn\r\n";
            // 
            // lblTopSeller
            // 
            this.lblTopSeller.AutoSize = true;
            this.lblTopSeller.BackColor = System.Drawing.Color.White;
            this.lblTopSeller.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTopSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTopSeller.Location = new System.Drawing.Point(870, 0);
            this.lblTopSeller.Name = "lblTopSeller";
            this.lblTopSeller.Padding = new System.Windows.Forms.Padding(15);
            this.lblTopSeller.Size = new System.Drawing.Size(270, 100);
            this.lblTopSeller.TabIndex = 3;
            this.lblTopSeller.Text = "🏆\r\nMón bán chạy:\r\nCoca Cola\r\n";
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.panelTopSellers);
            this.panelCharts.Controls.Add(this.panelRevenueChart);
            this.panelCharts.Location = new System.Drawing.Point(30, 150);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(1140, 550);
            this.panelCharts.TabIndex = 1;
            // 
            // panelRevenueChart
            // 
            this.panelRevenueChart.BackColor = System.Drawing.Color.White;
            this.panelRevenueChart.Controls.Add(this.chartRevenue);
            this.panelRevenueChart.Controls.Add(this.lblRevenueChartTitle);
            this.panelRevenueChart.Location = new System.Drawing.Point(0, 0);
            this.panelRevenueChart.Name = "panelRevenueChart";
            this.panelRevenueChart.Padding = new System.Windows.Forms.Padding(20);
            this.panelRevenueChart.Size = new System.Drawing.Size(560, 550);
            this.panelRevenueChart.TabIndex = 0;
            // 
            // lblRevenueChartTitle
            // 
            this.lblRevenueChartTitle.AutoSize = true;
            this.lblRevenueChartTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenueChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblRevenueChartTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRevenueChartTitle.Name = "lblRevenueChartTitle";
            this.lblRevenueChartTitle.Size = new System.Drawing.Size(250, 25);
            this.lblRevenueChartTitle.TabIndex = 0;
            this.lblRevenueChartTitle.Text = "📊 Doanh thu theo thời gian";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.Location = new System.Drawing.Point(20, 60);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(520, 470);
            this.chartRevenue.TabIndex = 1;
            // 
            // panelTopSellers
            // 
            this.panelTopSellers.BackColor = System.Drawing.Color.White;
            this.panelTopSellers.Controls.Add(this.dgvTopSellers);
            this.panelTopSellers.Controls.Add(this.chartTopSellers);
            this.panelTopSellers.Controls.Add(this.lblTopSellersTitle);
            this.panelTopSellers.Location = new System.Drawing.Point(580, 0);
            this.panelTopSellers.Name = "panelTopSellers";
            this.panelTopSellers.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopSellers.Size = new System.Drawing.Size(560, 550);
            this.panelTopSellers.TabIndex = 1;
            // 
            // lblTopSellersTitle
            // 
            this.lblTopSellersTitle.AutoSize = true;
            this.lblTopSellersTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTopSellersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTopSellersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTopSellersTitle.Name = "lblTopSellersTitle";
            this.lblTopSellersTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTopSellersTitle.TabIndex = 0;
            this.lblTopSellersTitle.Text = "🏆 Top món bán chạy";
            // 
            // chartTopSellers
            // 
            this.chartTopSellers.BackColor = System.Drawing.Color.Transparent;
            this.chartTopSellers.Location = new System.Drawing.Point(20, 60);
            this.chartTopSellers.Name = "chartTopSellers";
            this.chartTopSellers.Size = new System.Drawing.Size(520, 250);
            this.chartTopSellers.TabIndex = 1;
            // 
            // dgvTopSellers
            // 
            this.dgvTopSellers.AllowUserToAddRows = false;
            this.dgvTopSellers.AllowUserToDeleteRows = false;
            this.dgvTopSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSellers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSellers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSellers.Location = new System.Drawing.Point(20, 330);
            this.dgvTopSellers.MultiSelect = false;
            this.dgvTopSellers.Name = "dgvTopSellers";
            this.dgvTopSellers.ReadOnly = true;
            this.dgvTopSellers.RowHeadersVisible = false;
            this.dgvTopSellers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSellers.Size = new System.Drawing.Size(520, 200);
            this.dgvTopSellers.TabIndex = 2;
            // 
            // FoodReportsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "FoodReportsControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            this.panelTopSellers.ResumeLayout(false);
            this.panelTopSellers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSellers)).EndInit();
            this.panelRevenueChart.ResumeLayout(false);
            this.panelRevenueChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}


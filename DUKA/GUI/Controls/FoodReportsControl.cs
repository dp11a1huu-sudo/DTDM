using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Controls
{
    public partial class FoodReportsControl : UserControl
    {
        private bool isInitialized = false;

        public FoodReportsControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += FoodReportsControl_Load;
            }
        }

        private void FoodReportsControl_Load(object sender, EventArgs e)
        {
            if (isInitialized) return;
            
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (!isInitialized && chartRevenue != null && chartTopSellers != null)
                            {
                                InitializeCharts();
                                LoadTopSellersData();
                                UpdateStatistics();
                                isInitialized = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke: {ex.Message}");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FoodReportsControl_Load: {ex.Message}");
            }
        }

        private void InitializeCharts()
        {
            try
            {
                // Revenue Chart
                if (chartRevenue != null)
                {
                    chartRevenue.Series.Clear();
                    chartRevenue.ChartAreas.Clear();
                    
                    ChartArea revenueArea = new ChartArea("RevenueArea");
                    revenueArea.BackColor = Color.Transparent;
                    revenueArea.AxisX.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    revenueArea.AxisY.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    revenueArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    revenueArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    chartRevenue.ChartAreas.Add(revenueArea);

                    Series revenueSeries = new Series("Doanh thu");
                    revenueSeries.ChartType = SeriesChartType.Column;
                    revenueSeries.Color = Color.FromArgb(124, 58, 237);
                    revenueSeries.IsValueShownAsLabel = true;
                    revenueSeries.LabelFormat = "N0";
                    
                    // Sample data - 7 days
                    revenueSeries.Points.AddXY("T2", 2500000);
                    revenueSeries.Points.AddXY("T3", 3000000);
                    revenueSeries.Points.AddXY("T4", 2800000);
                    revenueSeries.Points.AddXY("T5", 3200000);
                    revenueSeries.Points.AddXY("T6", 3500000);
                    revenueSeries.Points.AddXY("T7", 4000000);
                    revenueSeries.Points.AddXY("CN", 4500000);
                    
                    chartRevenue.Series.Add(revenueSeries);
                    chartRevenue.Legends.Clear();
                }

                // Top Sellers Chart
                if (chartTopSellers != null)
                {
                    chartTopSellers.Series.Clear();
                    chartTopSellers.ChartAreas.Clear();
                    
                    ChartArea topSellersArea = new ChartArea("TopSellersArea");
                    topSellersArea.BackColor = Color.Transparent;
                    topSellersArea.AxisX.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    topSellersArea.AxisY.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    topSellersArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    topSellersArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    chartTopSellers.ChartAreas.Add(topSellersArea);

                    Series topSellersSeries = new Series("Số lượng");
                    topSellersSeries.ChartType = SeriesChartType.Bar;
                    topSellersSeries.Color = Color.FromArgb(16, 185, 129);
                    topSellersSeries.IsValueShownAsLabel = true;
                    
                    // Sample data - Top 5
                    topSellersSeries.Points.AddXY("Coca Cola", 150);
                    topSellersSeries.Points.AddXY("Nước suối", 120);
                    topSellersSeries.Points.AddXY("Bánh mì", 100);
                    topSellersSeries.Points.AddXY("Xúc xích", 80);
                    topSellersSeries.Points.AddXY("Combo 1", 60);
                    
                    chartTopSellers.Series.Add(topSellersSeries);
                    chartTopSellers.Legends.Clear();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in InitializeCharts: {ex.Message}");
            }
        }

        private void LoadTopSellersData()
        {
            try
            {
                if (dgvTopSellers == null) return;

                DataTable topSellersData = new DataTable();
                topSellersData.Columns.Add("Rank", typeof(int));
                topSellersData.Columns.Add("ItemName", typeof(string));
                topSellersData.Columns.Add("Quantity", typeof(int));
                topSellersData.Columns.Add("Revenue", typeof(decimal));
                topSellersData.Columns.Add("Profit", typeof(decimal));

                topSellersData.Rows.Add(1, "Coca Cola", 150, 2250000, 1050000);
                topSellersData.Rows.Add(2, "Nước suối", 120, 1200000, 600000);
                topSellersData.Rows.Add(3, "Bánh mì", 100, 2000000, 1000000);
                topSellersData.Rows.Add(4, "Xúc xích", 80, 2000000, 1040000);
                topSellersData.Rows.Add(5, "Combo 1", 60, 3000000, 1500000);

                dgvTopSellers.AutoGenerateColumns = true;
                dgvTopSellers.DataSource = topSellersData;

                if (dgvTopSellers.Columns["Rank"] != null)
                {
                    dgvTopSellers.Columns["Rank"].HeaderText = "Hạng";
                    dgvTopSellers.Columns["Rank"].Width = 60;
                }
                if (dgvTopSellers.Columns["ItemName"] != null)
                {
                    dgvTopSellers.Columns["ItemName"].HeaderText = "Tên món";
                    dgvTopSellers.Columns["ItemName"].Width = 150;
                }
                if (dgvTopSellers.Columns["Quantity"] != null)
                {
                    dgvTopSellers.Columns["Quantity"].HeaderText = "Số lượng";
                    dgvTopSellers.Columns["Quantity"].Width = 100;
                }
                if (dgvTopSellers.Columns["Revenue"] != null)
                {
                    dgvTopSellers.Columns["Revenue"].HeaderText = "Doanh thu";
                    dgvTopSellers.Columns["Revenue"].Width = 120;
                    dgvTopSellers.Columns["Revenue"].DefaultCellStyle.Format = "N0";
                }
                if (dgvTopSellers.Columns["Profit"] != null)
                {
                    dgvTopSellers.Columns["Profit"].HeaderText = "Lợi nhuận";
                    dgvTopSellers.Columns["Profit"].Width = 120;
                    dgvTopSellers.Columns["Profit"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadTopSellersData: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (lblTotalRevenue != null)
                {
                    lblTotalRevenue.Text = "💰\r\nTổng doanh thu:\r\n15.000.000 đ\r\n";
                }
                if (lblTotalProfit != null)
                {
                    lblTotalProfit.Text = "📈\r\nLợi nhuận:\r\n7.500.000 đ\r\n";
                }
                if (lblTotalOrders != null)
                {
                    lblTotalOrders.Text = "📋\r\nTổng đơn hàng:\r\n150 đơn\r\n";
                }
                if (lblTopSeller != null)
                {
                    lblTopSeller.Text = "🏆\r\nMón bán chạy:\r\nCoca Cola\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }
    }
}


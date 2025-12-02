using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Controls
{
    public partial class RentalReportsControl : UserControl
    {
        private bool isInitialized = false;

        public RentalReportsControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += RentalReportsControl_Load;
            }
        }

        private void RentalReportsControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && chartRevenue != null && chartTopRented != null)
                            {
                                InitializeCharts();
                                LoadTopRentedData();
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
                System.Diagnostics.Debug.WriteLine($"Error in RentalReportsControl_Load: {ex.Message}");
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
                    revenueSeries.Points.AddXY("T2", 1200000);
                    revenueSeries.Points.AddXY("T3", 1500000);
                    revenueSeries.Points.AddXY("T4", 1300000);
                    revenueSeries.Points.AddXY("T5", 1600000);
                    revenueSeries.Points.AddXY("T6", 1800000);
                    revenueSeries.Points.AddXY("T7", 2000000);
                    revenueSeries.Points.AddXY("CN", 2200000);
                    
                    chartRevenue.Series.Add(revenueSeries);
                    chartRevenue.Legends.Clear();
                }

                // Top Rented Chart
                if (chartTopRented != null)
                {
                    chartTopRented.Series.Clear();
                    chartTopRented.ChartAreas.Clear();
                    
                    ChartArea topRentedArea = new ChartArea("TopRentedArea");
                    topRentedArea.BackColor = Color.Transparent;
                    topRentedArea.AxisX.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    topRentedArea.AxisY.MajorGrid.LineColor = Color.FromArgb(229, 231, 235);
                    topRentedArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    topRentedArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    chartTopRented.ChartAreas.Add(topRentedArea);

                    Series topRentedSeries = new Series("Số lần thuê");
                    topRentedSeries.ChartType = SeriesChartType.Bar;
                    topRentedSeries.Color = Color.FromArgb(16, 185, 129);
                    topRentedSeries.IsValueShownAsLabel = true;
                    
                    // Sample data - Top 5
                    topRentedSeries.Points.AddXY("Bóng đá size 5", 45);
                    topRentedSeries.Points.AddXY("Giày đá bóng Adidas", 35);
                    topRentedSeries.Points.AddXY("Áo đấu Real Madrid", 30);
                    topRentedSeries.Points.AddXY("Bảo vệ ống chân", 25);
                    topRentedSeries.Points.AddXY("Giày đá bóng Nike", 20);
                    
                    chartTopRented.Series.Add(topRentedSeries);
                    chartTopRented.Legends.Clear();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in InitializeCharts: {ex.Message}");
            }
        }

        private void LoadTopRentedData()
        {
            try
            {
                if (dgvTopRented == null) return;

                DataTable topRentedData = new DataTable();
                topRentedData.Columns.Add("Rank", typeof(int));
                topRentedData.Columns.Add("EquipmentName", typeof(string));
                topRentedData.Columns.Add("RentalCount", typeof(int));
                topRentedData.Columns.Add("Revenue", typeof(decimal));
                topRentedData.Columns.Add("UsageRate", typeof(string));

                topRentedData.Rows.Add(1, "Bóng đá size 5", 45, 1800000, "90%");
                topRentedData.Rows.Add(2, "Giày đá bóng Adidas", 35, 1750000, "70%");
                topRentedData.Rows.Add(3, "Áo đấu Real Madrid", 30, 900000, "60%");
                topRentedData.Rows.Add(4, "Bảo vệ ống chân", 25, 500000, "50%");
                topRentedData.Rows.Add(5, "Giày đá bóng Nike", 20, 1000000, "40%");

                dgvTopRented.AutoGenerateColumns = true;
                dgvTopRented.DataSource = topRentedData;

                if (dgvTopRented.Columns["Rank"] != null)
                {
                    dgvTopRented.Columns["Rank"].HeaderText = "Hạng";
                    dgvTopRented.Columns["Rank"].Width = 60;
                }
                if (dgvTopRented.Columns["EquipmentName"] != null)
                {
                    dgvTopRented.Columns["EquipmentName"].HeaderText = "Tên thiết bị";
                    dgvTopRented.Columns["EquipmentName"].Width = 150;
                }
                if (dgvTopRented.Columns["RentalCount"] != null)
                {
                    dgvTopRented.Columns["RentalCount"].HeaderText = "Số lần thuê";
                    dgvTopRented.Columns["RentalCount"].Width = 100;
                }
                if (dgvTopRented.Columns["Revenue"] != null)
                {
                    dgvTopRented.Columns["Revenue"].HeaderText = "Doanh thu";
                    dgvTopRented.Columns["Revenue"].Width = 120;
                    dgvTopRented.Columns["Revenue"].DefaultCellStyle.Format = "N0";
                }
                if (dgvTopRented.Columns["UsageRate"] != null)
                {
                    dgvTopRented.Columns["UsageRate"].HeaderText = "Tỷ lệ sử dụng";
                    dgvTopRented.Columns["UsageRate"].Width = 120;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadTopRentedData: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (lblTotalRevenue != null)
                {
                    lblTotalRevenue.Text = "💰\r\nTổng doanh thu:\r\n8.000.000 đ\r\n";
                }
                if (lblTotalRentals != null)
                {
                    lblTotalRentals.Text = "📋\r\nTổng đơn thuê:\r\n120 đơn\r\n";
                }
                if (lblTotalEquipment != null)
                {
                    lblTotalEquipment.Text = "📦\r\nTổng thiết bị:\r\n50 thiết bị\r\n";
                }
                if (lblTopRented != null)
                {
                    lblTopRented.Text = "🏆\r\nThiết bị thuê nhiều:\r\nBóng đá size 5\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }
    }
}


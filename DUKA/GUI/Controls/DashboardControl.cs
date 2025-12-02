using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using DTO;

namespace GUI.Controls
{
    public partial class DashboardControl : UserControl
    {
        // Data Models
        public class MonthlyRevenueData
        {
            public string Month { get; set; }
            public decimal Revenue { get; set; }
        }

        public class FieldStatusData
        {
            public string Status { get; set; }
            public double Percentage { get; set; }
            public Color Color { get; set; }
        }

        private List<MonthlyRevenueData> monthlyRevenueData;
        private List<FieldStatusData> fieldStatusData;

        public DashboardControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeData();
                InitializeDashboardComponents();
                ApplyDashboardStyling();
            }
            
            // Subscribe to resize event for responsive layout
            mainContainer.Resize += MainContainer_Resize;
        }

        private void MainContainer_Resize(object sender, EventArgs e)
        {
            if (mainContainer == null) return;
            
            int padding = 20;
            int availableWidth = mainContainer.Width - (padding * 3); // padding left, right, and gap between columns
            int columnWidth = (availableWidth / 2);
            int gap = 10;
            
            // Update left column
            if (leftColumn != null)
            {
                leftColumn.Width = columnWidth;
                leftColumn.Height = mainContainer.Height - 200; // Reserve space for header and footer
            }
            
            // Update right column
            if (rightColumn != null)
            {
                rightColumn.Location = new Point(padding + columnWidth + gap, rightColumn.Location.Y);
                rightColumn.Width = columnWidth;
                rightColumn.Height = mainContainer.Height - 200;
            }
            
            // Update bottom panels
            if (panelRecentActivity != null)
            {
                panelRecentActivity.Location = new Point(padding, mainContainer.Height - 310);
                panelRecentActivity.Width = columnWidth;
            }
            
            if (panelCurrentStatus != null)
            {
                panelCurrentStatus.Location = new Point(padding + columnWidth + gap, mainContainer.Height - 310);
                panelCurrentStatus.Width = columnWidth;
            }
            
            // Update footer
            if (panelFooter != null)
            {
                panelFooter.Location = new Point(padding, mainContainer.Height - 70);
                panelFooter.Width = mainContainer.Width - (padding * 2);
            }
        }

        private void InitializeData()
        {
            try
            {
                BUS_Dashboard busDashboard = new BUS_Dashboard();

                // Get dashboard statistics
                DTO_DashboardStats stats = busDashboard.GetDashboardStats();

                // Get revenue chart data for last 30 days
                DataTable revenueData = busDashboard.GetRevenueChartData(30);

                // Convert to MonthlyRevenueData format
                monthlyRevenueData = new List<MonthlyRevenueData>();
                if (revenueData.Rows.Count > 0)
                {
                    foreach (DataRow row in revenueData.Rows)
                    {
                        monthlyRevenueData.Add(new MonthlyRevenueData
                        {
                            Month = Convert.ToDateTime(row["Date"]).ToString("dd/MM"),
                            Revenue = Convert.ToDecimal(row["Revenue"])
                        });
                    }
                }
                else
                {
                    // Fallback data if no real data
                    monthlyRevenueData = new List<MonthlyRevenueData>
                    {
                        new MonthlyRevenueData { Month = "Hôm nay", Revenue = stats.TotalRevenueToday },
                        new MonthlyRevenueData { Month = "Hôm qua", Revenue = 0 },
                        new MonthlyRevenueData { Month = "3 ngày", Revenue = 0 },
                        new MonthlyRevenueData { Month = "1 tuần", Revenue = stats.MonthlyRevenue },
                    };
                }

                // Calculate field status percentages based on real data
                decimal totalFields = stats.TotalFields;
                if (totalFields > 0)
                {
                    fieldStatusData = new List<FieldStatusData>
                    {
                        new FieldStatusData {
                            Status = "Sân hoạt động",
                            Percentage = (double)(stats.ActiveFields * 100 / totalFields),
                            Color = Color.FromArgb(59, 130, 246)
                        },
                        new FieldStatusData {
                            Status = "Sân bảo trì",
                            Percentage = (double)((totalFields - stats.ActiveFields) * 100 / totalFields),
                            Color = Color.FromArgb(239, 68, 68)
                        }
                    };
                }
                else
                {
                    // Fallback data
                    fieldStatusData = new List<FieldStatusData>
                    {
                        new FieldStatusData { Status = "Sân hoạt động", Percentage = 70, Color = Color.FromArgb(59, 130, 246) },
                        new FieldStatusData { Status = "Sân bảo trì", Percentage = 30, Color = Color.FromArgb(239, 68, 68) }
                    };
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading dashboard data: {ex.Message}");

                // Fallback to sample data
                monthlyRevenueData = new List<MonthlyRevenueData>
                {
                    new MonthlyRevenueData { Month = "T1", Revenue = 45000000 },
                    new MonthlyRevenueData { Month = "T2", Revenue = 52000000 },
                    new MonthlyRevenueData { Month = "T3", Revenue = 48000000 },
                    new MonthlyRevenueData { Month = "T4", Revenue = 61000000 },
                    new MonthlyRevenueData { Month = "T5", Revenue = 55000000 },
                    new MonthlyRevenueData { Month = "T6", Revenue = 67000000 }
                };

                fieldStatusData = new List<FieldStatusData>
                {
                    new FieldStatusData { Status = "Sân hoạt động", Percentage = 70, Color = Color.FromArgb(59, 130, 246) },
                    new FieldStatusData { Status = "Sân bảo trì", Percentage = 30, Color = Color.FromArgb(239, 68, 68) }
                };
            }
        }

        private void InitializeDashboardComponents()
        {
            // Populate data
            UpdateRevenueData();
            UpdateRevenueChart();
            UpdateFieldStatusChart();
            UpdateRecentActivity();
            UpdateCurrentStatus();
        }

        private void UpdateRevenueData()
        {
            // Tính tổng doanh thu tháng hiện tại (tháng cuối cùng)
            decimal currentMonthRevenue = monthlyRevenueData[monthlyRevenueData.Count - 1].Revenue;
            decimal previousMonthRevenue = monthlyRevenueData[monthlyRevenueData.Count - 2].Revenue;
            decimal percentChange = ((currentMonthRevenue - previousMonthRevenue) / previousMonthRevenue) * 100;

            lblRevenueValue.Text = $"{currentMonthRevenue:N0} VND";
            lblRevenueTrend.Text = $"↑ {percentChange:F1}% so với tháng trước";
        }

        private void UpdateRevenueChart()
        {
            // Clear existing data
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.BackColor = Color.White;
            chartRevenue.ChartAreas.Add(chartArea);

            // Create series
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(124, 58, 237); // Purple color
            series.BorderWidth = 0;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#,##0.#M";
            series.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            series.LabelForeColor = Color.FromArgb(31, 41, 55);

            // Add data points for 6 months
            foreach (var data in monthlyRevenueData)
            {
                series.Points.AddXY(data.Month, data.Revenue / 1000000); // Convert to millions
            }

            chartRevenue.Series.Add(series);
            chartRevenue.BackColor = Color.White;
        }

        private void UpdateFieldStatusChart()
        {
            // Clear existing data
            chartFieldStatus.Series.Clear();
            chartFieldStatus.ChartAreas.Clear();
            chartFieldStatus.Legends.Clear();

            // Create chart area with proper positioning
            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.White;
            chartArea.Position.X = 5; // Left margin
            chartArea.Position.Y = 5; // Top margin
            chartArea.Position.Width = 45; // Chart width percentage (leave space for legend)
            chartArea.Position.Height = 70; // Chart height percentage (leave space for legend)
            chartFieldStatus.ChartAreas.Add(chartArea);

            // Create series - Donut chart
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = false; // Hide labels on chart
            series.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Add data points
            foreach (var data in fieldStatusData)
            {
                DataPoint point = series.Points.Add(data.Percentage);
                point.Color = data.Color;
                point.LegendText = data.Status;
            }

            chartFieldStatus.Series.Add(series);

            // Add legend with custom format - positioned at bottom
            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            legend.Font = new Font("Segoe UI", 9F);
            legend.Alignment = StringAlignment.Center;
            legend.Position.Auto = false;
            legend.Position.X = 5;
            legend.Position.Y = 75; // Below the chart
            legend.Position.Width = 90;
            legend.Position.Height = 20;
            legend.CustomItems.Clear();
            
            // Add custom legend items with percentage
            foreach (var data in fieldStatusData)
            {
                LegendItem item = new LegendItem();
                item.Color = data.Color;
                item.Name = $"{data.Status} - {data.Percentage}%";
                legend.CustomItems.Add(item);
            }
            
            chartFieldStatus.Legends.Add(legend);
            chartFieldStatus.BackColor = Color.White;
        }

        private void UpdateRecentActivity()
        {
            // Clear existing items
            flowRecentActivity.Controls.Clear();
            
            // Add recent activities with icons
            AddActivityItem("Nguyễn Văn A đã đặt sân SB02", "10:30 AM - Hôm nay", Color.FromArgb(124, 58, 237));
            AddActivityItem("Trần Thị B thanh toán 450k", "10:30 AM - Hôm nay", Color.FromArgb(16, 185, 129));
            AddActivityItem("Bảo trì sân SB05 hoàn thành", "10:30 AM - Hôm nay", Color.FromArgb(245, 158, 11));
            AddActivityItem("Lê Văn C đã hủy đặt sân", "10:30 AM - Hôm nay", Color.FromArgb(239, 68, 68));
        }

        private void AddActivityItem(string activity, string time, Color iconColor)
        {
            var panel = new Panel();
            panel.Size = new Size(flowRecentActivity.Width > 0 ? flowRecentActivity.Width - 20 : 580, 60);
            panel.Margin = new Padding(0, 5, 0, 5);
            panel.BackColor = Color.White;
            panel.Padding = new Padding(10);
            panel.BorderStyle = BorderStyle.FixedSingle;

            // Icon panel (square with rounded corners effect using Paint event)
            var iconPanel = new Panel();
            iconPanel.Size = new Size(40, 40);
            iconPanel.Location = new Point(10, 10);
            iconPanel.BackColor = iconColor;
            iconPanel.Paint += (s, e) =>
            {
                using (var brush = new SolidBrush(iconColor))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(brush, 0, 0, iconPanel.Width, iconPanel.Height);
                }
            };

            // Activity label
            var lblActivity = new Label();
            lblActivity.Text = activity;
            lblActivity.Font = new Font("Segoe UI", 10);
            lblActivity.ForeColor = Color.FromArgb(31, 41, 55);
            lblActivity.AutoSize = true;
            lblActivity.Location = new Point(60, 10);
            
            // Time label
            var lblTime = new Label();
            lblTime.Text = time;
            lblTime.Font = new Font("Segoe UI", 9);
            lblTime.ForeColor = Color.FromArgb(107, 114, 128);
            lblTime.AutoSize = true;
            lblTime.Location = new Point(60, 30);
            
            panel.Controls.AddRange(new Control[] { iconPanel, lblActivity, lblTime });
            flowRecentActivity.Controls.Add(panel);
        }

        private void UpdateCurrentStatus()
        {
            // Clear existing items
            flowFieldStatus.Controls.Clear();
            
            // Add field status items (SB01-SB04)
            AddFieldStatusItem("SB01", "Bảo trì", Color.FromArgb(239, 68, 68));
            AddFieldStatusItem("SB02", "Có sẵn", Color.FromArgb(16, 185, 129));
            AddFieldStatusItem("SB03", "Có sẵn", Color.FromArgb(16, 185, 129));
            AddFieldStatusItem("SB04", "Đang thuê", Color.FromArgb(245, 158, 11));
        }

        private void AddFieldStatusItem(string fieldId, string status, Color statusColor)
        {
            var panel = new Panel();
            panel.Size = new Size(120, 100);
            panel.Margin = new Padding(5);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Padding = new Padding(10);

            var lblFieldId = new Label();
            lblFieldId.Text = fieldId;
            lblFieldId.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblFieldId.ForeColor = Color.FromArgb(31, 41, 55);
            lblFieldId.AutoSize = true;
            lblFieldId.Location = new Point(10, 10);
            
            // Status label with pill shape background using Paint event
            var lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.AutoSize = false;
            lblStatus.Size = new Size(100, 25);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Location = new Point(10, 60);
            lblStatus.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var brush = new SolidBrush(statusColor))
                {
                    var rect = new Rectangle(0, 0, lblStatus.Width, lblStatus.Height);
                    int radius = 12;
                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                    path.CloseAllFigures();
                    e.Graphics.FillPath(brush, path);
                }
                TextRenderer.DrawText(e.Graphics, lblStatus.Text, lblStatus.Font, 
                    new Rectangle(0, 0, lblStatus.Width, lblStatus.Height), 
                    lblStatus.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
            
            panel.Controls.AddRange(new Control[] { lblFieldId, lblStatus });
            flowFieldStatus.Controls.Add(panel);
        }

        private void ApplyDashboardStyling()
        {
            // Add button click events
            btnViewDetails.Click += (s, e) => ShowDetails();
            btnFieldManagement.Click += (s, e) => ManageFields();
            btnInvoice.Click += (s, e) => ManageInvoices();
            btnMaintenance.Click += (s, e) => ManageMaintenance();
        }

        private void ShowDetails()
        {
            MessageBox.Show("Hiển thị chi tiết doanh thu", "Chi tiết Doanh thu");
        }

        private void ManageFields()
        {
            MessageBox.Show("Mở quản lý sân", "Quản lý Sân");
        }

        private void ManageInvoices()
        {
            MessageBox.Show("Mở quản lý hóa đơn", "Quản lý Hóa đơn");
        }

        private void ManageMaintenance()
        {
            MessageBox.Show("Mở bảo trì sân", "Bảo trì Sân");
        }

        private void panelFieldStatusChart_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

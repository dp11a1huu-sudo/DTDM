using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Controls
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Setup date range combo box
            if (cmbDateRange != null)
            {
                cmbDateRange.SelectedIndex = 0; // Select first item "Hôm nay"
            }

            // Sample data cho các DataGridView có sẵn
            LoadOverviewData();
            LoadRevenueData();
            LoadFieldData();
            LoadCustomerData();
            LoadEmployeeData();
        }

        private void LoadOverviewData()
        {
            // Sample data for overview grids
            DataTable dtTopFields = new DataTable();
            dtTopFields.Columns.Add("FieldName", typeof(string));
            dtTopFields.Columns.Add("Bookings", typeof(int));
            dtTopFields.Columns.Add("Revenue", typeof(string));

            dtTopFields.Rows.Add("Sân 1", 25, "2,500,000đ");
            dtTopFields.Rows.Add("Sân 2", 20, "2,000,000đ");
            dtTopFields.Rows.Add("Sân 3", 18, "1,800,000đ");

            if (dgvTopFields != null)
            {
                dgvTopFields.DataSource = dtTopFields;
            }

            DataTable dtTopCustomers = new DataTable();
            dtTopCustomers.Columns.Add("CustomerName", typeof(string));
            dtTopCustomers.Columns.Add("TotalBookings", typeof(int));
            dtTopCustomers.Columns.Add("TotalSpent", typeof(string));

            dtTopCustomers.Rows.Add("Nguyễn Văn A", 15, "1,500,000đ");
            dtTopCustomers.Rows.Add("Trần Thị B", 12, "1,200,000đ");
            dtTopCustomers.Rows.Add("Lê Văn C", 10, "1,000,000đ");

            if (dgvTopCustomers != null)
            {
                dgvTopCustomers.DataSource = dtTopCustomers;
            }
        }

        private void LoadRevenueData()
        {
            // Sample data for revenue sources
            DataTable dtRevenueSources = new DataTable();
            dtRevenueSources.Columns.Add("Source", typeof(string));
            dtRevenueSources.Columns.Add("Amount", typeof(string));
            dtRevenueSources.Columns.Add("Percentage", typeof(string));

            dtRevenueSources.Rows.Add("Đặt sân", "15,000,000đ", "75%");
            dtRevenueSources.Rows.Add("Dịch vụ", "3,000,000đ", "15%");
            dtRevenueSources.Rows.Add("Khác", "2,000,000đ", "10%");

            if (dgvRevenueSources != null)
            {
                dgvRevenueSources.DataSource = dtRevenueSources;
            }

            // Sample data for cost reports
            DataTable dtCostReports = new DataTable();
            dtCostReports.Columns.Add("Category", typeof(string));
            dtCostReports.Columns.Add("Amount", typeof(string));
            dtCostReports.Columns.Add("Month", typeof(string));

            dtCostReports.Rows.Add("Lương nhân viên", "8,000,000đ", "12/2024");
            dtCostReports.Rows.Add("Bảo trì", "1,500,000đ", "12/2024");
            dtCostReports.Rows.Add("Tiện ích", "2,000,000đ", "12/2024");

            if (dgvCostReports != null)
            {
                dgvCostReports.DataSource = dtCostReports;
            }
        }

        private void LoadFieldData()
        {
            // Sample data for field reports
            DataTable dtFieldReport = new DataTable();
            dtFieldReport.Columns.Add("FieldName", typeof(string));
            dtFieldReport.Columns.Add("Utilization", typeof(string));
            dtFieldReport.Columns.Add("Revenue", typeof(string));
            dtFieldReport.Columns.Add("Status", typeof(string));

            dtFieldReport.Rows.Add("Sân 1", "85%", "3,500,000đ", "Hoạt động");
            dtFieldReport.Rows.Add("Sân 2", "78%", "3,200,000đ", "Hoạt động");
            dtFieldReport.Rows.Add("Sân 3", "92%", "4,000,000đ", "Hoạt động");

            if (dgvFieldReport != null)
            {
                dgvFieldReport.DataSource = dtFieldReport;
            }

            // Sample data for time heatmap
            DataTable dtTimeHeatmap = new DataTable();
            dtTimeHeatmap.Columns.Add("TimeSlot", typeof(string));
            dtTimeHeatmap.Columns.Add("Monday", typeof(string));
            dtTimeHeatmap.Columns.Add("Tuesday", typeof(string));
            dtTimeHeatmap.Columns.Add("Wednesday", typeof(string));
            dtTimeHeatmap.Columns.Add("Thursday", typeof(string));
            dtTimeHeatmap.Columns.Add("Friday", typeof(string));
            dtTimeHeatmap.Columns.Add("Saturday", typeof(string));
            dtTimeHeatmap.Columns.Add("Sunday", typeof(string));

            dtTimeHeatmap.Rows.Add("06:00-08:00", "Low", "Low", "Medium", "Medium", "High", "High", "High");
            dtTimeHeatmap.Rows.Add("08:00-10:00", "Medium", "High", "High", "High", "High", "High", "High");
            dtTimeHeatmap.Rows.Add("10:00-12:00", "High", "High", "High", "High", "High", "High", "High");

            if (dgvTimeHeatmap != null)
            {
                dgvTimeHeatmap.DataSource = dtTimeHeatmap;
            }
        }

        private void LoadCustomerData()
        {
            // Sample data for customer reports
            DataTable dtTopCustomers = new DataTable();
            dtTopCustomers.Columns.Add("CustomerName", typeof(string));
            dtTopCustomers.Columns.Add("TotalBookings", typeof(int));
            dtTopCustomers.Columns.Add("TotalSpent", typeof(string));
            dtTopCustomers.Columns.Add("LastVisit", typeof(string));

            dtTopCustomers.Rows.Add("Nguyễn Văn A", 25, "2,500,000đ", "15/01/2025");
            dtTopCustomers.Rows.Add("Trần Thị B", 20, "2,000,000đ", "14/01/2025");
            dtTopCustomers.Rows.Add("Lê Văn C", 18, "1,800,000đ", "13/01/2025");

            if (dgvTopCustomersReport != null)
            {
                dgvTopCustomersReport.DataSource = dtTopCustomers;
            }

            DataTable dtCustomerBehavior = new DataTable();
            dtCustomerBehavior.Columns.Add("Segment", typeof(string));
            dtCustomerBehavior.Columns.Add("Count", typeof(int));
            dtCustomerBehavior.Columns.Add("AvgSpent", typeof(string));
            dtCustomerBehavior.Columns.Add("Frequency", typeof(string));

            dtCustomerBehavior.Rows.Add("VIP", 50, "150,000đ", "2 lần/tháng");
            dtCustomerBehavior.Rows.Add("Thường xuyên", 120, "80,000đ", "1 lần/tháng");
            dtCustomerBehavior.Rows.Add("Thỉnh thoảng", 200, "50,000đ", "1 lần/2 tháng");

            if (dgvCustomerBehavior != null)
            {
                dgvCustomerBehavior.DataSource = dtCustomerBehavior;
            }

            DataTable dtCustomerRfm = new DataTable();
            dtCustomerRfm.Columns.Add("R_Score", typeof(int));
            dtCustomerRfm.Columns.Add("F_Score", typeof(int));
            dtCustomerRfm.Columns.Add("M_Score", typeof(int));
            dtCustomerRfm.Columns.Add("Segment", typeof(string));
            dtCustomerRfm.Columns.Add("Count", typeof(int));

            dtCustomerRfm.Rows.Add(5, 5, 5, "Champions", 25);
            dtCustomerRfm.Rows.Add(4, 4, 4, "Loyal", 45);
            dtCustomerRfm.Rows.Add(3, 3, 3, "Potential", 60);
            dtCustomerRfm.Rows.Add(2, 2, 2, "At Risk", 35);
            dtCustomerRfm.Rows.Add(1, 1, 1, "Lost", 15);

            if (dgvCustomerRfm != null)
            {
                dgvCustomerRfm.DataSource = dtCustomerRfm;
            }
        }

        private void LoadEmployeeData()
        {
            // Sample data for employee reports
            DataTable dtEmployeePerformance = new DataTable();
            dtEmployeePerformance.Columns.Add("EmployeeName", typeof(string));
            dtEmployeePerformance.Columns.Add("Position", typeof(string));
            dtEmployeePerformance.Columns.Add("Performance", typeof(string));
            dtEmployeePerformance.Columns.Add("Rating", typeof(double));

            dtEmployeePerformance.Rows.Add("Nguyễn Văn D", "Nhân viên", "Xuất sắc", 9.2);
            dtEmployeePerformance.Rows.Add("Trần Thị E", "Quản lý", "Tốt", 8.5);
            dtEmployeePerformance.Rows.Add("Lê Văn F", "Nhân viên", "Khá", 7.8);

            if (dgvEmployeePerformance != null)
            {
                dgvEmployeePerformance.DataSource = dtEmployeePerformance;
            }

            DataTable dtEmployeeAttendance = new DataTable();
            dtEmployeeAttendance.Columns.Add("EmployeeName", typeof(string));
            dtEmployeeAttendance.Columns.Add("PresentDays", typeof(int));
            dtEmployeeAttendance.Columns.Add("TotalDays", typeof(int));
            dtEmployeeAttendance.Columns.Add("AttendanceRate", typeof(string));

            dtEmployeeAttendance.Rows.Add("Nguyễn Văn D", 22, 25, "88%");
            dtEmployeeAttendance.Rows.Add("Trần Thị E", 24, 25, "96%");
            dtEmployeeAttendance.Rows.Add("Lê Văn F", 20, 25, "80%");

            if (dgvEmployeeAttendance != null)
            {
                dgvEmployeeAttendance.DataSource = dtEmployeeAttendance;
            }

            DataTable dtEmployeePayroll = new DataTable();
            dtEmployeePayroll.Columns.Add("EmployeeName", typeof(string));
            dtEmployeePayroll.Columns.Add("BaseSalary", typeof(string));
            dtEmployeePayroll.Columns.Add("Bonus", typeof(string));
            dtEmployeePayroll.Columns.Add("Total", typeof(string));

            dtEmployeePayroll.Rows.Add("Nguyễn Văn D", "8,000,000đ", "500,000đ", "8,500,000đ");
            dtEmployeePayroll.Rows.Add("Trần Thị E", "12,000,000đ", "1,000,000đ", "13,000,000đ");
            dtEmployeePayroll.Rows.Add("Lê Văn F", "7,500,000đ", "300,000đ", "7,800,000đ");

            if (dgvEmployeePayroll != null)
            {
                dgvEmployeePayroll.DataSource = dtEmployeePayroll;
            }
        }
    }
}
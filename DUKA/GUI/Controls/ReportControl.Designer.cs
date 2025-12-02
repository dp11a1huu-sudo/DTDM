namespace GUI.Controls
{
    partial class ReportControl
    {
        private System.ComponentModel.IContainer components = null;
        private HeaderControl headerControl;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Button btnTabOverview;
        private System.Windows.Forms.Button btnTabRevenue;
        private System.Windows.Forms.Button btnTabFields;
        private System.Windows.Forms.Button btnTabCustomers;
        private System.Windows.Forms.Button btnTabEmployees;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.ComboBox cmbDateRange;
        private System.Windows.Forms.DateTimePicker dtpCustomFrom;
        private System.Windows.Forms.DateTimePicker dtpCustomTo;
        private System.Windows.Forms.Label lblCustomFrom;
        private System.Windows.Forms.Label lblCustomTo;
        private System.Windows.Forms.CheckBox chkComparePeriod;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.FlowLayoutPanel flpQuickRange;
        private System.Windows.Forms.Button btnRangeToday;
        private System.Windows.Forms.Button btnRangeWeek;
        private System.Windows.Forms.Button btnRangeMonth;
        private System.Windows.Forms.Button btnRangeLastMonth;
        private System.Windows.Forms.Button btnRangeCustom;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabRevenue;
        private System.Windows.Forms.TabPage tabFields;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.FlowLayoutPanel flpOverviewCards;
        private System.Windows.Forms.Panel cardOverviewRevenue;
        private System.Windows.Forms.Panel cardOverviewBookings;
        private System.Windows.Forms.Panel cardOverviewCustomers;
        private System.Windows.Forms.Panel cardOverviewRating;
        private System.Windows.Forms.TableLayoutPanel tlpOverviewCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverviewRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookingTrend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueShare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueCost;
        private System.Windows.Forms.TableLayoutPanel tlpOverviewTop;
        private System.Windows.Forms.DataGridView dgvTopFields;
        private System.Windows.Forms.DataGridView dgvTopCustomers;
        private System.Windows.Forms.DataGridView dgvTopTimeSlots;
        private System.Windows.Forms.DataGridView dgvTopServices;
        private System.Windows.Forms.FlowLayoutPanel flpRevenueStats;
        private System.Windows.Forms.Panel cardRevenueTotal;
        private System.Windows.Forms.Panel cardRevenueCost;
        private System.Windows.Forms.Panel cardRevenueProfit;
        private System.Windows.Forms.Panel cardRevenueMargin;
        private System.Windows.Forms.DataGridView dgvRevenueSources;
        private System.Windows.Forms.Panel panelPaymentBreakdown;
        private System.Windows.Forms.Label lblCashValue;
        private System.Windows.Forms.Label lblTransferValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaymentMethods;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueTimeline;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueComparison;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrowthTrend;
        private System.Windows.Forms.DataGridView dgvCostReports;
        private System.Windows.Forms.FlowLayoutPanel flpRevenueExport;
        private System.Windows.Forms.Button btnRevenueExportPdf;
        private System.Windows.Forms.Button btnRevenueExportExcel;
        private System.Windows.Forms.FlowLayoutPanel flpFieldStats;
        private System.Windows.Forms.Panel cardFieldBookings;
        private System.Windows.Forms.Panel cardFieldFillRate;
        private System.Windows.Forms.Panel cardFieldAvgRevenue;
        private System.Windows.Forms.Panel cardFieldTop;
        private System.Windows.Forms.DataGridView dgvFieldReport;
        private System.Windows.Forms.DataGridView dgvTimeHeatmap;
        private System.Windows.Forms.FlowLayoutPanel flpEquipmentStatus;
        private System.Windows.Forms.Panel cardEquipmentGood;
        private System.Windows.Forms.Panel cardEquipmentMaintenance;
        private System.Windows.Forms.Panel cardEquipmentDamaged;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFieldByHour;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFieldWeeklyTrend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFieldRevenueShare;
        private System.Windows.Forms.FlowLayoutPanel flpCustomerStats;
        private System.Windows.Forms.Panel cardCustomerTotal;
        private System.Windows.Forms.Panel cardCustomerNew;
        private System.Windows.Forms.Panel cardCustomerReturning;
        private System.Windows.Forms.Panel cardCustomerChurn;
        private System.Windows.Forms.DataGridView dgvCustomerRfm;
        private System.Windows.Forms.DataGridView dgvCustomerBehavior;
        private System.Windows.Forms.DataGridView dgvTopCustomersReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomerNew;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomerGrowth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomerSources;
        private System.Windows.Forms.FlowLayoutPanel flpEmployeeStats;
        private System.Windows.Forms.Panel cardEmployeeTotal;
        private System.Windows.Forms.Panel cardEmployeeOnDuty;
        private System.Windows.Forms.Panel cardEmployeeHours;
        private System.Windows.Forms.Panel cardEmployeePayroll;
        private System.Windows.Forms.DataGridView dgvEmployeePerformance;
        private System.Windows.Forms.DataGridView dgvEmployeeAttendance;
        private System.Windows.Forms.DataGridView dgvEmployeePayroll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayrollCost;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeHours;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeRoles;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.headerControl = new GUI.Controls.HeaderControl();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.tlpOverviewTop = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTopServices = new System.Windows.Forms.DataGridView();
            this.dgvTopTimeSlots = new System.Windows.Forms.DataGridView();
            this.dgvTopCustomers = new System.Windows.Forms.DataGridView();
            this.dgvTopFields = new System.Windows.Forms.DataGridView();
            this.tlpOverviewCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chartRevenueCost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenueShare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBookingTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOverviewRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flpOverviewCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardOverviewRevenue = new System.Windows.Forms.Panel();
            this.cardOverviewBookings = new System.Windows.Forms.Panel();
            this.cardOverviewCustomers = new System.Windows.Forms.Panel();
            this.cardOverviewRating = new System.Windows.Forms.Panel();
            this.tabRevenue = new System.Windows.Forms.TabPage();
            this.flpRevenueExport = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRevenueExportPdf = new System.Windows.Forms.Button();
            this.btnRevenueExportExcel = new System.Windows.Forms.Button();
            this.dgvCostReports = new System.Windows.Forms.DataGridView();
            this.chartGrowthTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenueComparison = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenueTimeline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelPaymentBreakdown = new System.Windows.Forms.Panel();
            this.lblTransferValue = new System.Windows.Forms.Label();
            this.lblCashValue = new System.Windows.Forms.Label();
            this.chartPaymentMethods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRevenueSources = new System.Windows.Forms.DataGridView();
            this.flpRevenueStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardRevenueTotal = new System.Windows.Forms.Panel();
            this.cardRevenueCost = new System.Windows.Forms.Panel();
            this.cardRevenueProfit = new System.Windows.Forms.Panel();
            this.cardRevenueMargin = new System.Windows.Forms.Panel();
            this.tabFields = new System.Windows.Forms.TabPage();
            this.chartFieldRevenueShare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFieldWeeklyTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFieldByHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flpEquipmentStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEquipmentGood = new System.Windows.Forms.Panel();
            this.cardEquipmentMaintenance = new System.Windows.Forms.Panel();
            this.cardEquipmentDamaged = new System.Windows.Forms.Panel();
            this.dgvTimeHeatmap = new System.Windows.Forms.DataGridView();
            this.dgvFieldReport = new System.Windows.Forms.DataGridView();
            this.flpFieldStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardFieldBookings = new System.Windows.Forms.Panel();
            this.cardFieldFillRate = new System.Windows.Forms.Panel();
            this.cardFieldAvgRevenue = new System.Windows.Forms.Panel();
            this.cardFieldTop = new System.Windows.Forms.Panel();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.chartCustomerSources = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCustomerGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCustomerNew = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopCustomersReport = new System.Windows.Forms.DataGridView();
            this.dgvCustomerBehavior = new System.Windows.Forms.DataGridView();
            this.dgvCustomerRfm = new System.Windows.Forms.DataGridView();
            this.flpCustomerStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardCustomerTotal = new System.Windows.Forms.Panel();
            this.cardCustomerNew = new System.Windows.Forms.Panel();
            this.cardCustomerReturning = new System.Windows.Forms.Panel();
            this.cardCustomerChurn = new System.Windows.Forms.Panel();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.chartEmployeeRoles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEmployeeHours = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPayrollCost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEmployeePayroll = new System.Windows.Forms.DataGridView();
            this.dgvEmployeeAttendance = new System.Windows.Forms.DataGridView();
            this.dgvEmployeePerformance = new System.Windows.Forms.DataGridView();
            this.flpEmployeeStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEmployeeTotal = new System.Windows.Forms.Panel();
            this.cardEmployeeOnDuty = new System.Windows.Forms.Panel();
            this.cardEmployeeHours = new System.Windows.Forms.Panel();
            this.cardEmployeePayroll = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.chkComparePeriod = new System.Windows.Forms.CheckBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblCustomTo = new System.Windows.Forms.Label();
            this.lblCustomFrom = new System.Windows.Forms.Label();
            this.dtpCustomTo = new System.Windows.Forms.DateTimePicker();
            this.dtpCustomFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbDateRange = new System.Windows.Forms.ComboBox();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnTabEmployees = new System.Windows.Forms.Button();
            this.btnTabCustomers = new System.Windows.Forms.Button();
            this.btnTabFields = new System.Windows.Forms.Button();
            this.btnTabRevenue = new System.Windows.Forms.Button();
            this.btnTabOverview = new System.Windows.Forms.Button();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.flpQuickRange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRangeToday = new System.Windows.Forms.Button();
            this.btnRangeWeek = new System.Windows.Forms.Button();
            this.btnRangeMonth = new System.Windows.Forms.Button();
            this.btnRangeLastMonth = new System.Windows.Forms.Button();
            this.btnRangeCustom = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tlpOverviewTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopFields)).BeginInit();
            this.tlpOverviewCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverviewRevenue)).BeginInit();
            this.flpOverviewCards.SuspendLayout();
            this.tabRevenue.SuspendLayout();
            this.flpRevenueExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowthTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueComparison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueTimeline)).BeginInit();
            this.panelPaymentBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueSources)).BeginInit();
            this.flpRevenueStats.SuspendLayout();
            this.tabFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldRevenueShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldWeeklyTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldByHour)).BeginInit();
            this.flpEquipmentStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeHeatmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldReport)).BeginInit();
            this.flpFieldStats.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomersReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBehavior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRfm)).BeginInit();
            this.flpCustomerStats.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePerformance)).BeginInit();
            this.flpEmployeeStats.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.flpQuickRange.SuspendLayout();
            this.SuspendLayout();

            // 
            // headerControl
            // 
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 68);
            this.headerControl.TabIndex = 0;
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.mainContainer.Controls.Add(this.contentPanel);
            this.mainContainer.Controls.Add(this.sidebarPanel);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 68);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.mainContainer.Size = new System.Drawing.Size(1200, 732);
            this.mainContainer.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.White;
            this.sidebarPanel.Controls.Add(this.btnTabEmployees);
            this.sidebarPanel.Controls.Add(this.btnTabCustomers);
            this.sidebarPanel.Controls.Add(this.btnTabFields);
            this.sidebarPanel.Controls.Add(this.btnTabRevenue);
            this.sidebarPanel.Controls.Add(this.btnTabOverview);
            this.sidebarPanel.Controls.Add(this.lblSidebarTitle);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Padding = new System.Windows.Forms.Padding(24, 32, 24, 24);
            this.sidebarPanel.Size = new System.Drawing.Size(240, 716);
            this.sidebarPanel.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblSidebarTitle.Location = new System.Drawing.Point(24, 32);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.lblSidebarTitle.Size = new System.Drawing.Size(192, 56);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "📊 Báo cáo";
            // 
            // btnTabOverview
            // 
            this.btnTabOverview.BackColor = System.Drawing.Color.FromArgb(228, 248, 243);
            this.btnTabOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabOverview.FlatAppearance.BorderSize = 0;
            this.btnTabOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabOverview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTabOverview.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnTabOverview.Location = new System.Drawing.Point(24, 88);
            this.btnTabOverview.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTabOverview.Name = "btnTabOverview";
            this.btnTabOverview.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabOverview.Size = new System.Drawing.Size(192, 48);
            this.btnTabOverview.TabIndex = 1;
            this.btnTabOverview.Text = "Tổng quan";
            this.btnTabOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabOverview.UseVisualStyleBackColor = false;
            // 
            // btnTabRevenue
            // 
            this.btnTabRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnTabRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabRevenue.FlatAppearance.BorderSize = 0;
            this.btnTabRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabRevenue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnTabRevenue.Location = new System.Drawing.Point(24, 136);
            this.btnTabRevenue.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTabRevenue.Name = "btnTabRevenue";
            this.btnTabRevenue.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabRevenue.Size = new System.Drawing.Size(192, 44);
            this.btnTabRevenue.TabIndex = 2;
            this.btnTabRevenue.Text = "Doanh thu";
            this.btnTabRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabRevenue.UseVisualStyleBackColor = false;
            // 
            // btnTabFields
            // 
            this.btnTabFields.BackColor = System.Drawing.Color.Transparent;
            this.btnTabFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabFields.FlatAppearance.BorderSize = 0;
            this.btnTabFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabFields.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabFields.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnTabFields.Location = new System.Drawing.Point(24, 180);
            this.btnTabFields.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTabFields.Name = "btnTabFields";
            this.btnTabFields.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabFields.Size = new System.Drawing.Size(192, 44);
            this.btnTabFields.TabIndex = 3;
            this.btnTabFields.Text = "Sân bóng";
            this.btnTabFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabFields.UseVisualStyleBackColor = false;
            // 
            // btnTabCustomers
            // 
            this.btnTabCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnTabCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabCustomers.FlatAppearance.BorderSize = 0;
            this.btnTabCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabCustomers.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnTabCustomers.Location = new System.Drawing.Point(24, 224);
            this.btnTabCustomers.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTabCustomers.Name = "btnTabCustomers";
            this.btnTabCustomers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabCustomers.Size = new System.Drawing.Size(192, 44);
            this.btnTabCustomers.TabIndex = 4;
            this.btnTabCustomers.Text = "Khách hàng";
            this.btnTabCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabCustomers.UseVisualStyleBackColor = false;
            // 
            // btnTabEmployees
            // 
            this.btnTabEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnTabEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabEmployees.FlatAppearance.BorderSize = 0;
            this.btnTabEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTabEmployees.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnTabEmployees.Location = new System.Drawing.Point(24, 268);
            this.btnTabEmployees.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnTabEmployees.Name = "btnTabEmployees";
            this.btnTabEmployees.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabEmployees.Size = new System.Drawing.Size(192, 44);
            this.btnTabEmployees.TabIndex = 5;
            this.btnTabEmployees.Text = "Nhân viên";
            this.btnTabEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabEmployees.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.tabReports);
            this.contentPanel.Controls.Add(this.filterPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(240, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(24);
            this.contentPanel.Size = new System.Drawing.Size(960, 716);
            this.contentPanel.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.White;
            this.filterPanel.Controls.Add(this.btnExportExcel);
            this.filterPanel.Controls.Add(this.btnExportPdf);
            this.filterPanel.Controls.Add(this.btnApplyFilter);
            this.filterPanel.Controls.Add(this.chkComparePeriod);
            this.filterPanel.Controls.Add(this.flpQuickRange);
            this.filterPanel.Controls.Add(this.lblCustomTo);
            this.filterPanel.Controls.Add(this.lblCustomFrom);
            this.filterPanel.Controls.Add(this.dtpCustomTo);
            this.filterPanel.Controls.Add(this.dtpCustomFrom);
            this.filterPanel.Controls.Add(this.cmbDateRange);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(24, 24);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(24);
            this.filterPanel.Size = new System.Drawing.Size(912, 170);
            this.filterPanel.TabIndex = 0;
            // 
            // cmbDateRange
            // 
            this.cmbDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateRange.FormattingEnabled = true;
            this.cmbDateRange.Items.AddRange(new object[] {
            "Hôm nay",
            "7 ngày",
            "Tháng này",
            "Tháng trước",
            "Tuỳ chỉnh"});
            this.cmbDateRange.Location = new System.Drawing.Point(27, 28);
            this.cmbDateRange.Name = "cmbDateRange";
            this.cmbDateRange.Size = new System.Drawing.Size(180, 23);
            this.cmbDateRange.TabIndex = 0;
            // 
            // dtpCustomFrom
            // 
            this.dtpCustomFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustomFrom.Location = new System.Drawing.Point(270, 28);
            this.dtpCustomFrom.Name = "dtpCustomFrom";
            this.dtpCustomFrom.Size = new System.Drawing.Size(140, 23);
            this.dtpCustomFrom.TabIndex = 1;
            // 
            // dtpCustomTo
            // 
            this.dtpCustomTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustomTo.Location = new System.Drawing.Point(450, 28);
            this.dtpCustomTo.Name = "dtpCustomTo";
            this.dtpCustomTo.Size = new System.Drawing.Size(140, 23);
            this.dtpCustomTo.TabIndex = 2;
            // 
            // lblCustomFrom
            // 
            this.lblCustomFrom.AutoSize = true;
            this.lblCustomFrom.Location = new System.Drawing.Point(226, 32);
            this.lblCustomFrom.Name = "lblCustomFrom";
            this.lblCustomFrom.Size = new System.Drawing.Size(38, 15);
            this.lblCustomFrom.TabIndex = 5;
            this.lblCustomFrom.Text = "Từ ngày";
            // 
            // lblCustomTo
            // 
            this.lblCustomTo.AutoSize = true;
            this.lblCustomTo.Location = new System.Drawing.Point(416, 32);
            this.lblCustomTo.Name = "lblCustomTo";
            this.lblCustomTo.Size = new System.Drawing.Size(28, 15);
            this.lblCustomTo.TabIndex = 6;
            this.lblCustomTo.Text = "Đến";
            // 
            // flpQuickRange
            // 
            this.flpQuickRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpQuickRange.Controls.Add(this.btnRangeToday);
            this.flpQuickRange.Controls.Add(this.btnRangeWeek);
            this.flpQuickRange.Controls.Add(this.btnRangeMonth);
            this.flpQuickRange.Controls.Add(this.btnRangeLastMonth);
            this.flpQuickRange.Controls.Add(this.btnRangeCustom);
            this.flpQuickRange.Location = new System.Drawing.Point(27, 70);
            this.flpQuickRange.Name = "flpQuickRange";
            this.flpQuickRange.Size = new System.Drawing.Size(540, 36);
            this.flpQuickRange.TabIndex = 7;
            this.flpQuickRange.WrapContents = false;
            // 
            // btnRangeToday
            // 
            this.btnRangeToday.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRangeToday.FlatAppearance.BorderSize = 0;
            this.btnRangeToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeToday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRangeToday.Location = new System.Drawing.Point(3, 3);
            this.btnRangeToday.Name = "btnRangeToday";
            this.btnRangeToday.Size = new System.Drawing.Size(96, 30);
            this.btnRangeToday.TabIndex = 0;
            this.btnRangeToday.Text = "Hôm nay";
            this.btnRangeToday.UseVisualStyleBackColor = false;
            // 
            // btnRangeWeek
            // 
            this.btnRangeWeek.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRangeWeek.FlatAppearance.BorderSize = 0;
            this.btnRangeWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeWeek.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRangeWeek.Location = new System.Drawing.Point(105, 3);
            this.btnRangeWeek.Name = "btnRangeWeek";
            this.btnRangeWeek.Size = new System.Drawing.Size(96, 30);
            this.btnRangeWeek.TabIndex = 1;
            this.btnRangeWeek.Text = "7 ngày";
            this.btnRangeWeek.UseVisualStyleBackColor = false;
            // 
            // btnRangeMonth
            // 
            this.btnRangeMonth.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRangeMonth.FlatAppearance.BorderSize = 0;
            this.btnRangeMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRangeMonth.Location = new System.Drawing.Point(207, 3);
            this.btnRangeMonth.Name = "btnRangeMonth";
            this.btnRangeMonth.Size = new System.Drawing.Size(96, 30);
            this.btnRangeMonth.TabIndex = 2;
            this.btnRangeMonth.Text = "Tháng này";
            this.btnRangeMonth.UseVisualStyleBackColor = false;
            // 
            // btnRangeLastMonth
            // 
            this.btnRangeLastMonth.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRangeLastMonth.FlatAppearance.BorderSize = 0;
            this.btnRangeLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeLastMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRangeLastMonth.Location = new System.Drawing.Point(309, 3);
            this.btnRangeLastMonth.Name = "btnRangeLastMonth";
            this.btnRangeLastMonth.Size = new System.Drawing.Size(96, 30);
            this.btnRangeLastMonth.TabIndex = 3;
            this.btnRangeLastMonth.Text = "Tháng trước";
            this.btnRangeLastMonth.UseVisualStyleBackColor = false;
            // 
            // btnRangeCustom
            // 
            this.btnRangeCustom.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRangeCustom.FlatAppearance.BorderSize = 0;
            this.btnRangeCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRangeCustom.Location = new System.Drawing.Point(411, 3);
            this.btnRangeCustom.Name = "btnRangeCustom";
            this.btnRangeCustom.Size = new System.Drawing.Size(96, 30);
            this.btnRangeCustom.TabIndex = 4;
            this.btnRangeCustom.Text = "Tùy chỉnh";
            this.btnRangeCustom.UseVisualStyleBackColor = false;
            // 
            // chkComparePeriod
            // 
            this.chkComparePeriod.AutoSize = true;
            this.chkComparePeriod.Location = new System.Drawing.Point(27, 118);
            this.chkComparePeriod.Name = "chkComparePeriod";
            this.chkComparePeriod.Size = new System.Drawing.Size(171, 19);
            this.chkComparePeriod.TabIndex = 8;
            this.chkComparePeriod.Text = "So sánh với kỳ trước";
            this.chkComparePeriod.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(637, 26);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(110, 32);
            this.btnApplyFilter.TabIndex = 9;
            this.btnApplyFilter.Text = "Áp dụng";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.BackColor = System.Drawing.Color.FromArgb(190, 24, 93);
            this.btnExportPdf.FlatAppearance.BorderSize = 0;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(637, 75);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 32);
            this.btnExportPdf.TabIndex = 10;
            this.btnExportPdf.Text = "Xuất PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(763, 75);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 32);
            this.btnExportExcel.TabIndex = 11;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabOverview);
            this.tabReports.Controls.Add(this.tabRevenue);
            this.tabReports.Controls.Add(this.tabFields);
            this.tabReports.Controls.Add(this.tabCustomers);
            this.tabReports.Controls.Add(this.tabEmployees);
            this.tabReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReports.Location = new System.Drawing.Point(24, 194);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Drawing.Point(16, 8);
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(912, 498);
            this.tabReports.TabIndex = 1;
            // 
            // tabOverview
            // 
            this.tabOverview.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.tabOverview.Controls.Add(this.tlpOverviewTop);
            this.tabOverview.Controls.Add(this.tlpOverviewCharts);
            this.tabOverview.Controls.Add(this.flpOverviewCards);
            this.tabOverview.Location = new System.Drawing.Point(4, 30);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(16);
            this.tabOverview.Size = new System.Drawing.Size(904, 464);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Tổng quan";
            // 
            // flpOverviewCards
            // 
            this.flpOverviewCards.AutoScroll = true;
            this.flpOverviewCards.BackColor = System.Drawing.Color.Transparent;
            this.flpOverviewCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpOverviewCards.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpOverviewCards.Location = new System.Drawing.Point(16, 16);
            this.flpOverviewCards.Margin = new System.Windows.Forms.Padding(0);
            this.flpOverviewCards.Name = "flpOverviewCards";
            this.flpOverviewCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpOverviewCards.Size = new System.Drawing.Size(872, 110);
            this.flpOverviewCards.TabIndex = 0;
            this.flpOverviewCards.WrapContents = false;
            this.flpOverviewCards.Controls.Add(this.cardOverviewRevenue);
            this.flpOverviewCards.Controls.Add(this.cardOverviewBookings);
            this.flpOverviewCards.Controls.Add(this.cardOverviewCustomers);
            this.flpOverviewCards.Controls.Add(this.cardOverviewRating);
            // 
            // cardOverviewRevenue
            // 
            this.cardOverviewRevenue.BackColor = System.Drawing.Color.White;
            this.cardOverviewRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardOverviewRevenue.Name = "cardOverviewRevenue";
            this.cardOverviewRevenue.Size = new System.Drawing.Size(200, 100);
            this.cardOverviewRevenue.TabIndex = 0;
            // 
            // cardOverviewBookings
            // 
            this.cardOverviewBookings.BackColor = System.Drawing.Color.White;
            this.cardOverviewBookings.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardOverviewBookings.Name = "cardOverviewBookings";
            this.cardOverviewBookings.Size = new System.Drawing.Size(200, 100);
            this.cardOverviewBookings.TabIndex = 1;
            // 
            // cardOverviewCustomers
            // 
            this.cardOverviewCustomers.BackColor = System.Drawing.Color.White;
            this.cardOverviewCustomers.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardOverviewCustomers.Name = "cardOverviewCustomers";
            this.cardOverviewCustomers.Size = new System.Drawing.Size(200, 100);
            this.cardOverviewCustomers.TabIndex = 2;
            // 
            // cardOverviewRating
            // 
            this.cardOverviewRating.BackColor = System.Drawing.Color.White;
            this.cardOverviewRating.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardOverviewRating.Name = "cardOverviewRating";
            this.cardOverviewRating.Size = new System.Drawing.Size(200, 100);
            this.cardOverviewRating.TabIndex = 3;
            // 
            // tlpOverviewCharts
            // 
            this.tlpOverviewCharts.ColumnCount = 2;
            this.tlpOverviewCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewCharts.Controls.Add(this.chartOverviewRevenue, 0, 0);
            this.tlpOverviewCharts.Controls.Add(this.chartBookingTrend, 1, 0);
            this.tlpOverviewCharts.Controls.Add(this.chartRevenueShare, 0, 1);
            this.tlpOverviewCharts.Controls.Add(this.chartRevenueCost, 1, 1);
            this.tlpOverviewCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOverviewCharts.Location = new System.Drawing.Point(16, 126);
            this.tlpOverviewCharts.Name = "tlpOverviewCharts";
            this.tlpOverviewCharts.RowCount = 2;
            this.tlpOverviewCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewCharts.Size = new System.Drawing.Size(872, 220);
            this.tlpOverviewCharts.TabIndex = 1;
            // 
            // chartOverviewRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOverviewRevenue.ChartAreas.Add(chartArea1);
            this.chartOverviewRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartOverviewRevenue.Location = new System.Drawing.Point(3, 3);
            this.chartOverviewRevenue.Name = "chartOverviewRevenue";
            this.chartOverviewRevenue.Size = new System.Drawing.Size(430, 104);
            this.chartOverviewRevenue.TabIndex = 0;
            this.chartOverviewRevenue.Text = "chart1";
            // 
            // chartBookingTrend
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBookingTrend.ChartAreas.Add(chartArea2);
            this.chartBookingTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBookingTrend.Location = new System.Drawing.Point(439, 3);
            this.chartBookingTrend.Name = "chartBookingTrend";
            this.chartBookingTrend.Size = new System.Drawing.Size(430, 104);
            this.chartBookingTrend.TabIndex = 1;
            this.chartBookingTrend.Text = "chart2";
            // 
            // chartRevenueShare
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenueShare.ChartAreas.Add(chartArea3);
            this.chartRevenueShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenueShare.Location = new System.Drawing.Point(3, 113);
            this.chartRevenueShare.Name = "chartRevenueShare";
            this.chartRevenueShare.Size = new System.Drawing.Size(430, 104);
            this.chartRevenueShare.TabIndex = 2;
            this.chartRevenueShare.Text = "chart3";
            // 
            // chartRevenueCost
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRevenueCost.ChartAreas.Add(chartArea4);
            this.chartRevenueCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenueCost.Location = new System.Drawing.Point(439, 113);
            this.chartRevenueCost.Name = "chartRevenueCost";
            this.chartRevenueCost.Size = new System.Drawing.Size(430, 104);
            this.chartRevenueCost.TabIndex = 3;
            this.chartRevenueCost.Text = "chart4";
            // 
            // tlpOverviewTop
            // 
            this.tlpOverviewTop.ColumnCount = 2;
            this.tlpOverviewTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewTop.Controls.Add(this.dgvTopFields, 0, 0);
            this.tlpOverviewTop.Controls.Add(this.dgvTopCustomers, 1, 0);
            this.tlpOverviewTop.Controls.Add(this.dgvTopTimeSlots, 0, 1);
            this.tlpOverviewTop.Controls.Add(this.dgvTopServices, 1, 1);
            this.tlpOverviewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOverviewTop.Location = new System.Drawing.Point(16, 346);
            this.tlpOverviewTop.Name = "tlpOverviewTop";
            this.tlpOverviewTop.RowCount = 2;
            this.tlpOverviewTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOverviewTop.Size = new System.Drawing.Size(872, 102);
            this.tlpOverviewTop.TabIndex = 2;
            // 
            // dgvTopFields
            // 
            this.dgvTopFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopFields.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopFields.Location = new System.Drawing.Point(3, 3);
            this.dgvTopFields.Name = "dgvTopFields";
            this.dgvTopFields.RowHeadersVisible = false;
            this.dgvTopFields.Size = new System.Drawing.Size(430, 45);
            this.dgvTopFields.TabIndex = 0;
            // 
            // dgvTopCustomers
            // 
            this.dgvTopCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopCustomers.Location = new System.Drawing.Point(439, 3);
            this.dgvTopCustomers.Name = "dgvTopCustomers";
            this.dgvTopCustomers.RowHeadersVisible = false;
            this.dgvTopCustomers.Size = new System.Drawing.Size(430, 45);
            this.dgvTopCustomers.TabIndex = 1;
            // 
            // dgvTopTimeSlots
            // 
            this.dgvTopTimeSlots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopTimeSlots.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopTimeSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopTimeSlots.Location = new System.Drawing.Point(3, 54);
            this.dgvTopTimeSlots.Name = "dgvTopTimeSlots";
            this.dgvTopTimeSlots.RowHeadersVisible = false;
            this.dgvTopTimeSlots.Size = new System.Drawing.Size(430, 45);
            this.dgvTopTimeSlots.TabIndex = 2;
            // 
            // dgvTopServices
            // 
            this.dgvTopServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopServices.Location = new System.Drawing.Point(439, 54);
            this.dgvTopServices.Name = "dgvTopServices";
            this.dgvTopServices.RowHeadersVisible = false;
            this.dgvTopServices.Size = new System.Drawing.Size(430, 45);
            this.dgvTopServices.TabIndex = 3;
            // 
            // tabRevenue
            // 
            this.tabRevenue.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.tabRevenue.Controls.Add(this.dgvCostReports);
            this.tabRevenue.Controls.Add(this.dgvRevenueSources);
            this.tabRevenue.Controls.Add(this.chartGrowthTrend);
            this.tabRevenue.Controls.Add(this.chartRevenueComparison);
            this.tabRevenue.Controls.Add(this.chartRevenueTimeline);
            this.tabRevenue.Controls.Add(this.panelPaymentBreakdown);
            this.tabRevenue.Controls.Add(this.flpRevenueStats);
            this.tabRevenue.Controls.Add(this.flpRevenueExport);
            this.tabRevenue.Location = new System.Drawing.Point(4, 30);
            this.tabRevenue.Name = "tabRevenue";
            this.tabRevenue.Padding = new System.Windows.Forms.Padding(16);
            this.tabRevenue.Size = new System.Drawing.Size(904, 464);
            this.tabRevenue.TabIndex = 1;
            this.tabRevenue.Text = "Doanh thu";
            // 
            // flpRevenueStats
            // 
            this.flpRevenueStats.BackColor = System.Drawing.Color.Transparent;
            this.flpRevenueStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRevenueStats.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpRevenueStats.Location = new System.Drawing.Point(16, 16);
            this.flpRevenueStats.Name = "flpRevenueStats";
            this.flpRevenueStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpRevenueStats.Size = new System.Drawing.Size(872, 100);
            this.flpRevenueStats.TabIndex = 0;
            this.flpRevenueStats.WrapContents = false;
            this.flpRevenueStats.Controls.Add(this.cardRevenueTotal);
            this.flpRevenueStats.Controls.Add(this.cardRevenueCost);
            this.flpRevenueStats.Controls.Add(this.cardRevenueProfit);
            this.flpRevenueStats.Controls.Add(this.cardRevenueMargin);
            // 
            // cardRevenueTotal
            // 
            this.cardRevenueTotal.BackColor = System.Drawing.Color.White;
            this.cardRevenueTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardRevenueTotal.Name = "cardRevenueTotal";
            this.cardRevenueTotal.Size = new System.Drawing.Size(200, 90);
            this.cardRevenueTotal.TabIndex = 0;
            // 
            // cardRevenueCost
            // 
            this.cardRevenueCost.BackColor = System.Drawing.Color.White;
            this.cardRevenueCost.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardRevenueCost.Name = "cardRevenueCost";
            this.cardRevenueCost.Size = new System.Drawing.Size(200, 90);
            this.cardRevenueCost.TabIndex = 1;
            // 
            // cardRevenueProfit
            // 
            this.cardRevenueProfit.BackColor = System.Drawing.Color.White;
            this.cardRevenueProfit.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardRevenueProfit.Name = "cardRevenueProfit";
            this.cardRevenueProfit.Size = new System.Drawing.Size(200, 90);
            this.cardRevenueProfit.TabIndex = 2;
            // 
            // cardRevenueMargin
            // 
            this.cardRevenueMargin.BackColor = System.Drawing.Color.White;
            this.cardRevenueMargin.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardRevenueMargin.Name = "cardRevenueMargin";
            this.cardRevenueMargin.Size = new System.Drawing.Size(200, 90);
            this.cardRevenueMargin.TabIndex = 3;
            // 
            // panelPaymentBreakdown
            // 
            this.panelPaymentBreakdown.BackColor = System.Drawing.Color.White;
            this.panelPaymentBreakdown.Controls.Add(this.chartPaymentMethods);
            this.panelPaymentBreakdown.Controls.Add(this.lblTransferValue);
            this.panelPaymentBreakdown.Controls.Add(this.lblCashValue);
            this.panelPaymentBreakdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymentBreakdown.Location = new System.Drawing.Point(16, 116);
            this.panelPaymentBreakdown.Name = "panelPaymentBreakdown";
            this.panelPaymentBreakdown.Padding = new System.Windows.Forms.Padding(16);
            this.panelPaymentBreakdown.Size = new System.Drawing.Size(872, 140);
            this.panelPaymentBreakdown.TabIndex = 1;
            // 
            // chartPaymentMethods
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPaymentMethods.ChartAreas.Add(chartArea5);
            this.chartPaymentMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPaymentMethods.Location = new System.Drawing.Point(16, 16);
            this.chartPaymentMethods.Name = "chartPaymentMethods";
            this.chartPaymentMethods.Size = new System.Drawing.Size(546, 108);
            this.chartPaymentMethods.TabIndex = 0;
            this.chartPaymentMethods.Text = "chart5";
            // 
            // lblCashValue
            // 
            this.lblCashValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCashValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCashValue.ForeColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.lblCashValue.Location = new System.Drawing.Point(562, 16);
            this.lblCashValue.Name = "lblCashValue";
            this.lblCashValue.Size = new System.Drawing.Size(147, 108);
            this.lblCashValue.TabIndex = 1;
            this.lblCashValue.Text = "Tiền mặt: 0đ";
            this.lblCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransferValue
            // 
            this.lblTransferValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTransferValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransferValue.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblTransferValue.Location = new System.Drawing.Point(709, 16);
            this.lblTransferValue.Name = "lblTransferValue";
            this.lblTransferValue.Size = new System.Drawing.Size(147, 108);
            this.lblTransferValue.TabIndex = 2;
            this.lblTransferValue.Text = "Chuyển khoản: 0đ";
            this.lblTransferValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartRevenueTimeline
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRevenueTimeline.ChartAreas.Add(chartArea6);
            this.chartRevenueTimeline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartRevenueTimeline.Location = new System.Drawing.Point(16, 304);
            this.chartRevenueTimeline.Name = "chartRevenueTimeline";
            this.chartRevenueTimeline.Size = new System.Drawing.Size(872, 80);
            this.chartRevenueTimeline.TabIndex = 3;
            this.chartRevenueTimeline.Text = "chart6";
            // 
            // chartRevenueComparison
            // 
            chartArea7.Name = "ChartArea1";
            this.chartRevenueComparison.ChartAreas.Add(chartArea7);
            this.chartRevenueComparison.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartRevenueComparison.Location = new System.Drawing.Point(16, 384);
            this.chartRevenueComparison.Name = "chartRevenueComparison";
            this.chartRevenueComparison.Size = new System.Drawing.Size(872, 80);
            this.chartRevenueComparison.TabIndex = 4;
            this.chartRevenueComparison.Text = "chart7";
            // 
            // chartGrowthTrend
            // 
            chartArea8.Name = "ChartArea1";
            this.chartGrowthTrend.ChartAreas.Add(chartArea8);
            this.chartGrowthTrend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartGrowthTrend.Location = new System.Drawing.Point(16, 464);
            this.chartGrowthTrend.Name = "chartGrowthTrend";
            this.chartGrowthTrend.Size = new System.Drawing.Size(872, 0);
            this.chartGrowthTrend.TabIndex = 5;
            this.chartGrowthTrend.Text = "chart8";
            // 
            // dgvRevenueSources
            // 
            this.dgvRevenueSources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenueSources.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevenueSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueSources.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvRevenueSources.Location = new System.Drawing.Point(16, 256);
            this.dgvRevenueSources.Name = "dgvRevenueSources";
            this.dgvRevenueSources.RowHeadersVisible = false;
            this.dgvRevenueSources.Size = new System.Drawing.Size(280, 128);
            this.dgvRevenueSources.TabIndex = 2;
            // 
            // dgvCostReports
            // 
            this.dgvCostReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCostReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCostReports.Location = new System.Drawing.Point(296, 256);
            this.dgvCostReports.Name = "dgvCostReports";
            this.dgvCostReports.RowHeadersVisible = false;
            this.dgvCostReports.Size = new System.Drawing.Size(592, 128);
            this.dgvCostReports.TabIndex = 6;
            // 
            // flpRevenueExport
            // 
            this.flpRevenueExport.Controls.Add(this.btnRevenueExportExcel);
            this.flpRevenueExport.Controls.Add(this.btnRevenueExportPdf);
            this.flpRevenueExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpRevenueExport.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpRevenueExport.Location = new System.Drawing.Point(16, 432);
            this.flpRevenueExport.Name = "flpRevenueExport";
            this.flpRevenueExport.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpRevenueExport.Size = new System.Drawing.Size(872, 16);
            this.flpRevenueExport.TabIndex = 7;
            this.flpRevenueExport.Visible = false;
            // 
            // btnRevenueExportPdf
            // 
            this.btnRevenueExportPdf.BackColor = System.Drawing.Color.FromArgb(190, 24, 93);
            this.btnRevenueExportPdf.FlatAppearance.BorderSize = 0;
            this.btnRevenueExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnRevenueExportPdf.Location = new System.Drawing.Point(682, 11);
            this.btnRevenueExportPdf.Name = "btnRevenueExportPdf";
            this.btnRevenueExportPdf.Size = new System.Drawing.Size(90, 30);
            this.btnRevenueExportPdf.TabIndex = 1;
            this.btnRevenueExportPdf.Text = "PDF";
            this.btnRevenueExportPdf.UseVisualStyleBackColor = false;
            // 
            // btnRevenueExportExcel
            // 
            this.btnRevenueExportExcel.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnRevenueExportExcel.FlatAppearance.BorderSize = 0;
            this.btnRevenueExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnRevenueExportExcel.Location = new System.Drawing.Point(778, 11);
            this.btnRevenueExportExcel.Name = "btnRevenueExportExcel";
            this.btnRevenueExportExcel.Size = new System.Drawing.Size(90, 30);
            this.btnRevenueExportExcel.TabIndex = 0;
            this.btnRevenueExportExcel.Text = "Excel";
            this.btnRevenueExportExcel.UseVisualStyleBackColor = false;
            // 
            // tabFields
            // 
            this.tabFields.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.tabFields.Controls.Add(this.dgvFieldReport);
            this.tabFields.Controls.Add(this.dgvTimeHeatmap);
            this.tabFields.Controls.Add(this.chartFieldRevenueShare);
            this.tabFields.Controls.Add(this.chartFieldWeeklyTrend);
            this.tabFields.Controls.Add(this.chartFieldByHour);
            this.tabFields.Controls.Add(this.flpEquipmentStatus);
            this.tabFields.Controls.Add(this.flpFieldStats);
            this.tabFields.Location = new System.Drawing.Point(4, 30);
            this.tabFields.Name = "tabFields";
            this.tabFields.Padding = new System.Windows.Forms.Padding(16);
            this.tabFields.Size = new System.Drawing.Size(904, 464);
            this.tabFields.TabIndex = 2;
            this.tabFields.Text = "Sân bóng";
            // 
            // flpFieldStats
            // 
            this.flpFieldStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFieldStats.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpFieldStats.Location = new System.Drawing.Point(16, 16);
            this.flpFieldStats.Name = "flpFieldStats";
            this.flpFieldStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpFieldStats.Size = new System.Drawing.Size(872, 90);
            this.flpFieldStats.TabIndex = 0;
            this.flpFieldStats.WrapContents = false;
            this.flpFieldStats.Controls.Add(this.cardFieldBookings);
            this.flpFieldStats.Controls.Add(this.cardFieldFillRate);
            this.flpFieldStats.Controls.Add(this.cardFieldAvgRevenue);
            this.flpFieldStats.Controls.Add(this.cardFieldTop);
            // 
            // cardFieldBookings
            // 
            this.cardFieldBookings.BackColor = System.Drawing.Color.White;
            this.cardFieldBookings.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardFieldBookings.Name = "cardFieldBookings";
            this.cardFieldBookings.Size = new System.Drawing.Size(200, 80);
            this.cardFieldBookings.TabIndex = 0;
            // 
            // cardFieldFillRate
            // 
            this.cardFieldFillRate.BackColor = System.Drawing.Color.White;
            this.cardFieldFillRate.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardFieldFillRate.Name = "cardFieldFillRate";
            this.cardFieldFillRate.Size = new System.Drawing.Size(200, 80);
            this.cardFieldFillRate.TabIndex = 1;
            // 
            // cardFieldAvgRevenue
            // 
            this.cardFieldAvgRevenue.BackColor = System.Drawing.Color.White;
            this.cardFieldAvgRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardFieldAvgRevenue.Name = "cardFieldAvgRevenue";
            this.cardFieldAvgRevenue.Size = new System.Drawing.Size(200, 80);
            this.cardFieldAvgRevenue.TabIndex = 2;
            // 
            // cardFieldTop
            // 
            this.cardFieldTop.BackColor = System.Drawing.Color.White;
            this.cardFieldTop.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardFieldTop.Name = "cardFieldTop";
            this.cardFieldTop.Size = new System.Drawing.Size(200, 80);
            this.cardFieldTop.TabIndex = 3;
            // 
            // flpEquipmentStatus
            // 
            this.flpEquipmentStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpEquipmentStatus.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpEquipmentStatus.Location = new System.Drawing.Point(16, 106);
            this.flpEquipmentStatus.Name = "flpEquipmentStatus";
            this.flpEquipmentStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpEquipmentStatus.Size = new System.Drawing.Size(872, 80);
            this.flpEquipmentStatus.TabIndex = 1;
            this.flpEquipmentStatus.WrapContents = false;
            this.flpEquipmentStatus.Controls.Add(this.cardEquipmentGood);
            this.flpEquipmentStatus.Controls.Add(this.cardEquipmentMaintenance);
            this.flpEquipmentStatus.Controls.Add(this.cardEquipmentDamaged);
            // 
            // cardEquipmentGood
            // 
            this.cardEquipmentGood.BackColor = System.Drawing.Color.White;
            this.cardEquipmentGood.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEquipmentGood.Name = "cardEquipmentGood";
            this.cardEquipmentGood.Size = new System.Drawing.Size(200, 70);
            this.cardEquipmentGood.TabIndex = 0;
            // 
            // cardEquipmentMaintenance
            // 
            this.cardEquipmentMaintenance.BackColor = System.Drawing.Color.White;
            this.cardEquipmentMaintenance.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEquipmentMaintenance.Name = "cardEquipmentMaintenance";
            this.cardEquipmentMaintenance.Size = new System.Drawing.Size(200, 70);
            this.cardEquipmentMaintenance.TabIndex = 1;
            // 
            // cardEquipmentDamaged
            // 
            this.cardEquipmentDamaged.BackColor = System.Drawing.Color.White;
            this.cardEquipmentDamaged.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEquipmentDamaged.Name = "cardEquipmentDamaged";
            this.cardEquipmentDamaged.Size = new System.Drawing.Size(200, 70);
            this.cardEquipmentDamaged.TabIndex = 2;
            // 
            // chartFieldByHour
            // 
            chartArea9.Name = "ChartArea1";
            this.chartFieldByHour.ChartAreas.Add(chartArea9);
            this.chartFieldByHour.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartFieldByHour.Location = new System.Drawing.Point(16, 186);
            this.chartFieldByHour.Name = "chartFieldByHour";
            this.chartFieldByHour.Size = new System.Drawing.Size(872, 80);
            this.chartFieldByHour.TabIndex = 2;
            this.chartFieldByHour.Text = "chart9";
            // 
            // chartFieldWeeklyTrend
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFieldWeeklyTrend.ChartAreas.Add(chartArea10);
            this.chartFieldWeeklyTrend.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartFieldWeeklyTrend.Location = new System.Drawing.Point(16, 266);
            this.chartFieldWeeklyTrend.Name = "chartFieldWeeklyTrend";
            this.chartFieldWeeklyTrend.Size = new System.Drawing.Size(872, 80);
            this.chartFieldWeeklyTrend.TabIndex = 3;
            this.chartFieldWeeklyTrend.Text = "chart10";
            // 
            // chartFieldRevenueShare
            // 
            chartArea11.Name = "ChartArea1";
            this.chartFieldRevenueShare.ChartAreas.Add(chartArea11);
            this.chartFieldRevenueShare.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartFieldRevenueShare.Location = new System.Drawing.Point(16, 346);
            this.chartFieldRevenueShare.Name = "chartFieldRevenueShare";
            this.chartFieldRevenueShare.Size = new System.Drawing.Size(872, 80);
            this.chartFieldRevenueShare.TabIndex = 4;
            this.chartFieldRevenueShare.Text = "chart11";
            // 
            // dgvTimeHeatmap
            // 
            this.dgvTimeHeatmap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeHeatmap.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimeHeatmap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeHeatmap.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTimeHeatmap.Location = new System.Drawing.Point(628, 426);
            this.dgvTimeHeatmap.Name = "dgvTimeHeatmap";
            this.dgvTimeHeatmap.RowHeadersVisible = false;
            this.dgvTimeHeatmap.Size = new System.Drawing.Size(260, 22);
            this.dgvTimeHeatmap.TabIndex = 5;
            // 
            // dgvFieldReport
            // 
            this.dgvFieldReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFieldReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvFieldReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFieldReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFieldReport.Location = new System.Drawing.Point(16, 426);
            this.dgvFieldReport.Name = "dgvFieldReport";
            this.dgvFieldReport.RowHeadersVisible = false;
            this.dgvFieldReport.Size = new System.Drawing.Size(612, 22);
            this.dgvFieldReport.TabIndex = 6;
            // 
            // tabCustomers
            // 
            this.tabCustomers.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.tabCustomers.Controls.Add(this.dgvCustomerRfm);
            this.tabCustomers.Controls.Add(this.dgvCustomerBehavior);
            this.tabCustomers.Controls.Add(this.dgvTopCustomersReport);
            this.tabCustomers.Controls.Add(this.chartCustomerSources);
            this.tabCustomers.Controls.Add(this.chartCustomerGrowth);
            this.tabCustomers.Controls.Add(this.chartCustomerNew);
            this.tabCustomers.Controls.Add(this.flpCustomerStats);
            this.tabCustomers.Location = new System.Drawing.Point(4, 30);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(16);
            this.tabCustomers.Size = new System.Drawing.Size(904, 464);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Khách hàng";
            // 
            // flpCustomerStats
            // 
            this.flpCustomerStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCustomerStats.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpCustomerStats.Location = new System.Drawing.Point(16, 16);
            this.flpCustomerStats.Name = "flpCustomerStats";
            this.flpCustomerStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpCustomerStats.Size = new System.Drawing.Size(872, 90);
            this.flpCustomerStats.TabIndex = 0;
            this.flpCustomerStats.WrapContents = false;
            this.flpCustomerStats.Controls.Add(this.cardCustomerTotal);
            this.flpCustomerStats.Controls.Add(this.cardCustomerNew);
            this.flpCustomerStats.Controls.Add(this.cardCustomerReturning);
            this.flpCustomerStats.Controls.Add(this.cardCustomerChurn);
            // 
            // cardCustomerTotal
            // 
            this.cardCustomerTotal.BackColor = System.Drawing.Color.White;
            this.cardCustomerTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardCustomerTotal.Name = "cardCustomerTotal";
            this.cardCustomerTotal.Size = new System.Drawing.Size(200, 80);
            this.cardCustomerTotal.TabIndex = 0;
            // 
            // cardCustomerNew
            // 
            this.cardCustomerNew.BackColor = System.Drawing.Color.White;
            this.cardCustomerNew.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardCustomerNew.Name = "cardCustomerNew";
            this.cardCustomerNew.Size = new System.Drawing.Size(200, 80);
            this.cardCustomerNew.TabIndex = 1;
            // 
            // cardCustomerReturning
            // 
            this.cardCustomerReturning.BackColor = System.Drawing.Color.White;
            this.cardCustomerReturning.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardCustomerReturning.Name = "cardCustomerReturning";
            this.cardCustomerReturning.Size = new System.Drawing.Size(200, 80);
            this.cardCustomerReturning.TabIndex = 2;
            // 
            // cardCustomerChurn
            // 
            this.cardCustomerChurn.BackColor = System.Drawing.Color.White;
            this.cardCustomerChurn.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardCustomerChurn.Name = "cardCustomerChurn";
            this.cardCustomerChurn.Size = new System.Drawing.Size(200, 80);
            this.cardCustomerChurn.TabIndex = 3;
            // 
            // chartCustomerNew
            // 
            chartArea12.Name = "ChartArea1";
            this.chartCustomerNew.ChartAreas.Add(chartArea12);
            this.chartCustomerNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartCustomerNew.Location = new System.Drawing.Point(16, 106);
            this.chartCustomerNew.Name = "chartCustomerNew";
            this.chartCustomerNew.Size = new System.Drawing.Size(872, 80);
            this.chartCustomerNew.TabIndex = 1;
            this.chartCustomerNew.Text = "chart12";
            // 
            // chartCustomerGrowth
            // 
            chartArea13.Name = "ChartArea1";
            this.chartCustomerGrowth.ChartAreas.Add(chartArea13);
            this.chartCustomerGrowth.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartCustomerGrowth.Location = new System.Drawing.Point(16, 186);
            this.chartCustomerGrowth.Name = "chartCustomerGrowth";
            this.chartCustomerGrowth.Size = new System.Drawing.Size(872, 80);
            this.chartCustomerGrowth.TabIndex = 2;
            this.chartCustomerGrowth.Text = "chart13";
            // 
            // chartCustomerSources
            // 
            chartArea14.Name = "ChartArea1";
            this.chartCustomerSources.ChartAreas.Add(chartArea14);
            this.chartCustomerSources.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartCustomerSources.Location = new System.Drawing.Point(16, 266);
            this.chartCustomerSources.Name = "chartCustomerSources";
            this.chartCustomerSources.Size = new System.Drawing.Size(872, 80);
            this.chartCustomerSources.TabIndex = 3;
            this.chartCustomerSources.Text = "chart14";
            // 
            // dgvTopCustomersReport
            // 
            this.dgvTopCustomersReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopCustomersReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopCustomersReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomersReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTopCustomersReport.Location = new System.Drawing.Point(16, 384);
            this.dgvTopCustomersReport.Name = "dgvTopCustomersReport";
            this.dgvTopCustomersReport.RowHeadersVisible = false;
            this.dgvTopCustomersReport.Size = new System.Drawing.Size(872, 64);
            this.dgvTopCustomersReport.TabIndex = 4;
            // 
            // dgvCustomerBehavior
            // 
            this.dgvCustomerBehavior.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerBehavior.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerBehavior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerBehavior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomerBehavior.Location = new System.Drawing.Point(16, 320);
            this.dgvCustomerBehavior.Name = "dgvCustomerBehavior";
            this.dgvCustomerBehavior.RowHeadersVisible = false;
            this.dgvCustomerBehavior.Size = new System.Drawing.Size(872, 64);
            this.dgvCustomerBehavior.TabIndex = 5;
            // 
            // dgvCustomerRfm
            // 
            this.dgvCustomerRfm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRfm.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerRfm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRfm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerRfm.Location = new System.Drawing.Point(16, 346);
            this.dgvCustomerRfm.Name = "dgvCustomerRfm";
            this.dgvCustomerRfm.RowHeadersVisible = false;
            this.dgvCustomerRfm.Size = new System.Drawing.Size(872, 38);
            this.dgvCustomerRfm.TabIndex = 6;
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.tabEmployees.Controls.Add(this.dgvEmployeePerformance);
            this.tabEmployees.Controls.Add(this.dgvEmployeeAttendance);
            this.tabEmployees.Controls.Add(this.dgvEmployeePayroll);
            this.tabEmployees.Controls.Add(this.chartPayrollCost);
            this.tabEmployees.Controls.Add(this.chartEmployeeHours);
            this.tabEmployees.Controls.Add(this.chartEmployeeRoles);
            this.tabEmployees.Controls.Add(this.flpEmployeeStats);
            this.tabEmployees.Location = new System.Drawing.Point(4, 30);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(16);
            this.tabEmployees.Size = new System.Drawing.Size(904, 464);
            this.tabEmployees.TabIndex = 4;
            this.tabEmployees.Text = "Nhân viên";
            // 
            // flpEmployeeStats
            // 
            this.flpEmployeeStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpEmployeeStats.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpEmployeeStats.Location = new System.Drawing.Point(16, 16);
            this.flpEmployeeStats.Name = "flpEmployeeStats";
            this.flpEmployeeStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.flpEmployeeStats.Size = new System.Drawing.Size(872, 90);
            this.flpEmployeeStats.TabIndex = 0;
            this.flpEmployeeStats.WrapContents = false;
            this.flpEmployeeStats.Controls.Add(this.cardEmployeeTotal);
            this.flpEmployeeStats.Controls.Add(this.cardEmployeeOnDuty);
            this.flpEmployeeStats.Controls.Add(this.cardEmployeeHours);
            this.flpEmployeeStats.Controls.Add(this.cardEmployeePayroll);
            // 
            // cardEmployeeTotal
            // 
            this.cardEmployeeTotal.BackColor = System.Drawing.Color.White;
            this.cardEmployeeTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEmployeeTotal.Name = "cardEmployeeTotal";
            this.cardEmployeeTotal.Size = new System.Drawing.Size(200, 80);
            this.cardEmployeeTotal.TabIndex = 0;
            // 
            // cardEmployeeOnDuty
            // 
            this.cardEmployeeOnDuty.BackColor = System.Drawing.Color.White;
            this.cardEmployeeOnDuty.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEmployeeOnDuty.Name = "cardEmployeeOnDuty";
            this.cardEmployeeOnDuty.Size = new System.Drawing.Size(200, 80);
            this.cardEmployeeOnDuty.TabIndex = 1;
            // 
            // cardEmployeeHours
            // 
            this.cardEmployeeHours.BackColor = System.Drawing.Color.White;
            this.cardEmployeeHours.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEmployeeHours.Name = "cardEmployeeHours";
            this.cardEmployeeHours.Size = new System.Drawing.Size(200, 80);
            this.cardEmployeeHours.TabIndex = 2;
            // 
            // cardEmployeePayroll
            // 
            this.cardEmployeePayroll.BackColor = System.Drawing.Color.White;
            this.cardEmployeePayroll.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.cardEmployeePayroll.Name = "cardEmployeePayroll";
            this.cardEmployeePayroll.Size = new System.Drawing.Size(200, 80);
            this.cardEmployeePayroll.TabIndex = 3;
            // 
            // chartEmployeeRoles
            // 
            chartArea15.Name = "ChartArea1";
            this.chartEmployeeRoles.ChartAreas.Add(chartArea15);
            this.chartEmployeeRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartEmployeeRoles.Location = new System.Drawing.Point(16, 106);
            this.chartEmployeeRoles.Name = "chartEmployeeRoles";
            this.chartEmployeeRoles.Size = new System.Drawing.Size(872, 80);
            this.chartEmployeeRoles.TabIndex = 1;
            this.chartEmployeeRoles.Text = "chart15";
            // 
            // chartEmployeeHours
            // 
            chartArea16.Name = "ChartArea1";
            this.chartEmployeeHours.ChartAreas.Add(chartArea16);
            this.chartEmployeeHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartEmployeeHours.Location = new System.Drawing.Point(16, 186);
            this.chartEmployeeHours.Name = "chartEmployeeHours";
            this.chartEmployeeHours.Size = new System.Drawing.Size(872, 80);
            this.chartEmployeeHours.TabIndex = 2;
            this.chartEmployeeHours.Text = "chart16";
            // 
            // chartPayrollCost
            // 
            chartArea17.Name = "ChartArea1";
            this.chartPayrollCost.ChartAreas.Add(chartArea17);
            this.chartPayrollCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartPayrollCost.Location = new System.Drawing.Point(16, 266);
            this.chartPayrollCost.Name = "chartPayrollCost";
            this.chartPayrollCost.Size = new System.Drawing.Size(872, 80);
            this.chartPayrollCost.TabIndex = 3;
            this.chartPayrollCost.Text = "chart17";
            // 
            // dgvEmployeePayroll
            // 
            this.dgvEmployeePayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeePayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeePayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePayroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeePayroll.Location = new System.Drawing.Point(16, 408);
            this.dgvEmployeePayroll.Name = "dgvEmployeePayroll";
            this.dgvEmployeePayroll.RowHeadersVisible = false;
            this.dgvEmployeePayroll.Size = new System.Drawing.Size(872, 40);
            this.dgvEmployeePayroll.TabIndex = 4;
            // 
            // dgvEmployeeAttendance
            // 
            this.dgvEmployeeAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeeAttendance.Location = new System.Drawing.Point(16, 368);
            this.dgvEmployeeAttendance.Name = "dgvEmployeeAttendance";
            this.dgvEmployeeAttendance.RowHeadersVisible = false;
            this.dgvEmployeeAttendance.Size = new System.Drawing.Size(872, 40);
            this.dgvEmployeeAttendance.TabIndex = 5;
            // 
            // dgvEmployeePerformance
            // 
            this.dgvEmployeePerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeePerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeePerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeePerformance.Location = new System.Drawing.Point(16, 346);
            this.dgvEmployeePerformance.Name = "dgvEmployeePerformance";
            this.dgvEmployeePerformance.RowHeadersVisible = false;
            this.dgvEmployeePerformance.Size = new System.Drawing.Size(872, 22);
            this.dgvEmployeePerformance.TabIndex = 6;

            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.mainContainer);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tlpOverviewTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopFields)).EndInit();
            this.tlpOverviewCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverviewRevenue)).EndInit();
            this.flpOverviewCards.ResumeLayout(false);
            this.tabRevenue.ResumeLayout(false);
            this.flpRevenueExport.ResumeLayout(false);
            this.flpRevenueExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowthTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueComparison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueTimeline)).EndInit();
            this.panelPaymentBreakdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueSources)).EndInit();
            this.flpRevenueStats.ResumeLayout(false);
            this.tabFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldRevenueShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldWeeklyTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldByHour)).EndInit();
            this.flpEquipmentStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeHeatmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFieldReport)).EndInit();
            this.flpFieldStats.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerGrowth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomerNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomersReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerBehavior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRfm)).EndInit();
            this.flpCustomerStats.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePerformance)).EndInit();
            this.flpEmployeeStats.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.flpQuickRange.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.SuspendLayout();
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.mainContainer);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);
        }
    }
}
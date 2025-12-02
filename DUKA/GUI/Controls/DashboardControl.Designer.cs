using System.Drawing;

namespace GUI.Controls
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        // Main Container
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel leftColumn;
        private System.Windows.Forms.Panel rightColumn;

        // Header
        private HeaderControl headerControl;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblMainTitle;

        // Left Column Components
        private System.Windows.Forms.Panel panelRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTrend;
        private System.Windows.Forms.Button btnViewDetails;

        private System.Windows.Forms.Panel panelRevenueChart;
        private System.Windows.Forms.Label lblRevenueChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;

        private System.Windows.Forms.Panel panelQuickActions;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Button btnFieldManagement;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnMaintenance;

        private System.Windows.Forms.Panel panelFieldStatus;
        private System.Windows.Forms.Label lblFieldStatus;
        private System.Windows.Forms.ProgressBar progressBookings;
        private System.Windows.Forms.Label lblBookingsText;
        private System.Windows.Forms.Label lblBookingsPercent;
        private System.Windows.Forms.ProgressBar progressActiveFields;
        private System.Windows.Forms.Label lblActiveFieldsText;
        private System.Windows.Forms.Label lblActiveFieldsPercent;
        private System.Windows.Forms.ProgressBar progressMaintenance;
        private System.Windows.Forms.Label lblMaintenanceText;
        private System.Windows.Forms.Label lblMaintenancePercent;

        private System.Windows.Forms.Panel panelFieldStatusChart;
        private System.Windows.Forms.Label lblFieldStatusChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFieldStatus;

        // Right Column Components
        private System.Windows.Forms.Panel panelRecentActivity;
        private System.Windows.Forms.Label lblRecentActivity;
        private System.Windows.Forms.FlowLayoutPanel flowRecentActivity;

        private System.Windows.Forms.Panel panelCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.FlowLayoutPanel flowFieldStatus;

        // Footer
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;

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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.panelCurrentStatus = new System.Windows.Forms.Panel();
            this.flowFieldStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.panelRecentActivity = new System.Windows.Forms.Panel();
            this.flowRecentActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecentActivity = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.rightColumn = new System.Windows.Forms.Panel();
            this.panelFieldStatusChart = new System.Windows.Forms.Panel();
            this.chartFieldStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFieldStatusChartTitle = new System.Windows.Forms.Label();
            this.panelQuickActions = new System.Windows.Forms.Panel();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnFieldManagement = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.leftColumn = new System.Windows.Forms.Panel();
            this.panelRevenueChart = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueChartTitle = new System.Windows.Forms.Label();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lblRevenueTrend = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.headerControl = new HeaderControl();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelFieldStatus = new System.Windows.Forms.Panel();
            this.lblMaintenancePercent = new System.Windows.Forms.Label();
            this.lblMaintenanceText = new System.Windows.Forms.Label();
            this.progressMaintenance = new System.Windows.Forms.ProgressBar();
            this.lblActiveFieldsPercent = new System.Windows.Forms.Label();
            this.lblActiveFieldsText = new System.Windows.Forms.Label();
            this.progressActiveFields = new System.Windows.Forms.ProgressBar();
            this.lblBookingsPercent = new System.Windows.Forms.Label();
            this.lblBookingsText = new System.Windows.Forms.Label();
            this.progressBookings = new System.Windows.Forms.ProgressBar();
            this.lblFieldStatus = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelCurrentStatus.SuspendLayout();
            this.panelRecentActivity.SuspendLayout();
            this.rightColumn.SuspendLayout();
            this.panelFieldStatusChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldStatus)).BeginInit();
            this.panelQuickActions.SuspendLayout();
            this.leftColumn.SuspendLayout();
            this.panelRevenueChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelRevenue.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFieldStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.mainContainer.Controls.Add(this.panelCurrentStatus);
            this.mainContainer.Controls.Add(this.panelRecentActivity);
            this.mainContainer.Controls.Add(this.panelFooter);
            this.mainContainer.Controls.Add(this.rightColumn);
            this.mainContainer.Controls.Add(this.leftColumn);
            this.mainContainer.Controls.Add(this.panelHeader);
            // 
            // headerControl
            // 
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 70);
            this.headerControl.TabIndex = 0;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(20);
            this.mainContainer.Size = new System.Drawing.Size(1200, 730);
            this.mainContainer.TabIndex = 0;
            // 
            // panelCurrentStatus
            // 
            this.panelCurrentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrentStatus.BackColor = System.Drawing.Color.White;
            this.panelCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentStatus.Controls.Add(this.flowFieldStatus);
            this.panelCurrentStatus.Controls.Add(this.lblCurrentStatus);
            this.panelCurrentStatus.Location = new System.Drawing.Point(600, 500);
            this.panelCurrentStatus.Name = "panelCurrentStatus";
            this.panelCurrentStatus.Padding = new System.Windows.Forms.Padding(20);
            this.panelCurrentStatus.Size = new System.Drawing.Size(580, 280);
            this.panelCurrentStatus.TabIndex = 1;
            // 
            // flowFieldStatus
            // 
            this.flowFieldStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowFieldStatus.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowFieldStatus.Location = new System.Drawing.Point(0, 40);
            this.flowFieldStatus.Name = "flowFieldStatus";
            this.flowFieldStatus.Size = new System.Drawing.Size(540, 220);
            this.flowFieldStatus.TabIndex = 1;
            this.flowFieldStatus.WrapContents = true;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(175, 32);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "Trạng thái sân";
            // 
            // panelRecentActivity
            // 
            this.panelRecentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentActivity.BackColor = System.Drawing.Color.White;
            this.panelRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecentActivity.Controls.Add(this.flowRecentActivity);
            this.panelRecentActivity.Controls.Add(this.lblRecentActivity);
            this.panelRecentActivity.Location = new System.Drawing.Point(20, 500);
            this.panelRecentActivity.Name = "panelRecentActivity";
            this.panelRecentActivity.Padding = new System.Windows.Forms.Padding(20);
            this.panelRecentActivity.Size = new System.Drawing.Size(560, 280);
            this.panelRecentActivity.TabIndex = 0;
            // 
            // flowRecentActivity
            // 
            this.flowRecentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowRecentActivity.AutoScroll = true;
            this.flowRecentActivity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowRecentActivity.Location = new System.Drawing.Point(0, 40);
            this.flowRecentActivity.Name = "flowRecentActivity";
            this.flowRecentActivity.Size = new System.Drawing.Size(520, 220);
            this.flowRecentActivity.TabIndex = 1;
            this.flowRecentActivity.WrapContents = false;
            // 
            // lblRecentActivity
            // 
            this.lblRecentActivity.AutoSize = true;
            this.lblRecentActivity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblRecentActivity.Location = new System.Drawing.Point(0, 0);
            this.lblRecentActivity.Name = "lblRecentActivity";
            this.lblRecentActivity.Size = new System.Drawing.Size(234, 32);
            this.lblRecentActivity.TabIndex = 0;
            this.lblRecentActivity.Text = "Hoạt động gần đây";
            // 
            // panelFooter
            // 
            this.panelFooter.Location = new System.Drawing.Point(0, 0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(228, 100);
            this.panelFooter.TabIndex = 2;
            // 
            // rightColumn
            // 
            this.rightColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightColumn.BackColor = System.Drawing.Color.Transparent;
            this.rightColumn.Controls.Add(this.panelFieldStatusChart);
            this.rightColumn.Controls.Add(this.panelQuickActions);
            this.rightColumn.Location = new System.Drawing.Point(600, 120);
            this.rightColumn.Name = "rightColumn";
            this.rightColumn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.rightColumn.Size = new System.Drawing.Size(580, 360);
            this.rightColumn.TabIndex = 2;
            // 
            // panelFieldStatusChart
            // 
            this.panelFieldStatusChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFieldStatusChart.BackColor = System.Drawing.Color.White;
            this.panelFieldStatusChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFieldStatusChart.Controls.Add(this.chartFieldStatus);
            this.panelFieldStatusChart.Controls.Add(this.lblFieldStatusChartTitle);
            this.panelFieldStatusChart.Location = new System.Drawing.Point(0, 150);
            this.panelFieldStatusChart.Name = "panelFieldStatusChart";
            this.panelFieldStatusChart.Padding = new System.Windows.Forms.Padding(20);
            this.panelFieldStatusChart.Size = new System.Drawing.Size(570, 200);
            this.panelFieldStatusChart.TabIndex = 5;
            this.panelFieldStatusChart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFieldStatusChart_Paint);
            // 
            // chartFieldStatus
            // 
            this.chartFieldStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartFieldStatus.Location = new System.Drawing.Point(0, 40);
            this.chartFieldStatus.Name = "chartFieldStatus";
            this.chartFieldStatus.Size = new System.Drawing.Size(530, 150);
            this.chartFieldStatus.TabIndex = 1;
            // 
            // lblFieldStatusChartTitle
            // 
            this.lblFieldStatusChartTitle.AutoSize = true;
            this.lblFieldStatusChartTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFieldStatusChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblFieldStatusChartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFieldStatusChartTitle.Name = "lblFieldStatusChartTitle";
            this.lblFieldStatusChartTitle.Size = new System.Drawing.Size(179, 32);
            this.lblFieldStatusChartTitle.TabIndex = 0;
            this.lblFieldStatusChartTitle.Text = "Tình trạng sân";
            // 
            // panelQuickActions
            // 
            this.panelQuickActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuickActions.BackColor = System.Drawing.Color.White;
            this.panelQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuickActions.Controls.Add(this.btnMaintenance);
            this.panelQuickActions.Controls.Add(this.btnInvoice);
            this.panelQuickActions.Controls.Add(this.btnFieldManagement);
            this.panelQuickActions.Controls.Add(this.lblQuickActions);
            this.panelQuickActions.Location = new System.Drawing.Point(0, 0);
            this.panelQuickActions.Name = "panelQuickActions";
            this.panelQuickActions.Padding = new System.Windows.Forms.Padding(20);
            this.panelQuickActions.Size = new System.Drawing.Size(570, 140);
            this.panelQuickActions.TabIndex = 1;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnMaintenance.Location = new System.Drawing.Point(0, 95);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(110, 40);
            this.btnMaintenance.TabIndex = 3;
            this.btnMaintenance.Text = "Bảo trì";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnInvoice.Location = new System.Drawing.Point(125, 40);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(110, 40);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Tập hóa đơn";
            this.btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnFieldManagement
            // 
            this.btnFieldManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnFieldManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnFieldManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFieldManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFieldManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnFieldManagement.Location = new System.Drawing.Point(0, 40);
            this.btnFieldManagement.Name = "btnFieldManagement";
            this.btnFieldManagement.Size = new System.Drawing.Size(110, 40);
            this.btnFieldManagement.TabIndex = 1;
            this.btnFieldManagement.Text = "Dịch cấm";
            this.btnFieldManagement.UseVisualStyleBackColor = false;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuickActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblQuickActions.Location = new System.Drawing.Point(0, 0);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(189, 32);
            this.lblQuickActions.TabIndex = 0;
            this.lblQuickActions.Text = "Thao tác nhanh";
            // 
            // leftColumn
            // 
            this.leftColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftColumn.BackColor = System.Drawing.Color.Transparent;
            this.leftColumn.Controls.Add(this.panelRevenueChart);
            this.leftColumn.Controls.Add(this.panelRevenue);
            this.leftColumn.Location = new System.Drawing.Point(20, 120);
            this.leftColumn.Name = "leftColumn";
            this.leftColumn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.leftColumn.Size = new System.Drawing.Size(570, 360);
            this.leftColumn.TabIndex = 1;
            // 
            // panelRevenueChart
            // 
            this.panelRevenueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRevenueChart.BackColor = System.Drawing.Color.White;
            this.panelRevenueChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRevenueChart.Controls.Add(this.chartRevenue);
            this.panelRevenueChart.Controls.Add(this.lblRevenueChartTitle);
            this.panelRevenueChart.Location = new System.Drawing.Point(0, 150);
            this.panelRevenueChart.Name = "panelRevenueChart";
            this.panelRevenueChart.Padding = new System.Windows.Forms.Padding(20);
            this.panelRevenueChart.Size = new System.Drawing.Size(560, 200);
            this.panelRevenueChart.TabIndex = 4;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRevenue.Location = new System.Drawing.Point(0, 40);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(520, 150);
            this.chartRevenue.TabIndex = 1;
            // 
            // lblRevenueChartTitle
            // 
            this.lblRevenueChartTitle.AutoSize = true;
            this.lblRevenueChartTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenueChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblRevenueChartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRevenueChartTitle.Name = "lblRevenueChartTitle";
            this.lblRevenueChartTitle.Size = new System.Drawing.Size(0, 32);
            this.lblRevenueChartTitle.TabIndex = 0;
            // 
            // panelRevenue
            // 
            this.panelRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRevenue.BackColor = System.Drawing.Color.White;
            this.panelRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRevenue.Controls.Add(this.btnViewDetails);
            this.panelRevenue.Controls.Add(this.lblRevenueTrend);
            this.panelRevenue.Controls.Add(this.lblRevenueValue);
            this.panelRevenue.Controls.Add(this.lblRevenueTitle);
            this.panelRevenue.Location = new System.Drawing.Point(0, 0);
            this.panelRevenue.Name = "panelRevenue";
            this.panelRevenue.Padding = new System.Windows.Forms.Padding(20);
            this.panelRevenue.Size = new System.Drawing.Size(560, 140);
            this.panelRevenue.TabIndex = 0;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(0, 115);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(120, 35);
            this.btnViewDetails.TabIndex = 3;
            this.btnViewDetails.Text = "Xem chi tiết";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // lblRevenueTrend
            // 
            this.lblRevenueTrend.AutoSize = true;
            this.lblRevenueTrend.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRevenueTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblRevenueTrend.Location = new System.Drawing.Point(0, 85);
            this.lblRevenueTrend.Name = "lblRevenueTrend";
            this.lblRevenueTrend.Size = new System.Drawing.Size(223, 25);
            this.lblRevenueTrend.TabIndex = 2;
            this.lblRevenueTrend.Text = "↑ 3.0% so với tháng trước";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(0, 40);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(329, 54);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "12 500 000 VND";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(207, 32);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Doanh thu tháng";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblMainTitle);
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelHeader.Size = new System.Drawing.Size(1160, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblMainTitle.Location = new System.Drawing.Point(30, 20);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(408, 54);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Tổng quan hiệu suất";
            // 
            // lblFooter
            // 
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(100, 23);
            this.lblFooter.TabIndex = 0;
            // 
            // panelFieldStatus
            // 
            this.panelFieldStatus.BackColor = System.Drawing.Color.White;
            this.panelFieldStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFieldStatus.Controls.Add(this.lblMaintenancePercent);
            this.panelFieldStatus.Controls.Add(this.lblMaintenanceText);
            this.panelFieldStatus.Controls.Add(this.progressMaintenance);
            this.panelFieldStatus.Controls.Add(this.lblActiveFieldsPercent);
            this.panelFieldStatus.Controls.Add(this.lblActiveFieldsText);
            this.panelFieldStatus.Controls.Add(this.progressActiveFields);
            this.panelFieldStatus.Controls.Add(this.lblBookingsPercent);
            this.panelFieldStatus.Controls.Add(this.lblBookingsText);
            this.panelFieldStatus.Controls.Add(this.progressBookings);
            this.panelFieldStatus.Controls.Add(this.lblFieldStatus);
            this.panelFieldStatus.Location = new System.Drawing.Point(0, 630);
            this.panelFieldStatus.Name = "panelFieldStatus";
            this.panelFieldStatus.Padding = new System.Windows.Forms.Padding(20);
            this.panelFieldStatus.Size = new System.Drawing.Size(480, 200);
            this.panelFieldStatus.TabIndex = 2;
            // 
            // lblMaintenancePercent
            // 
            this.lblMaintenancePercent.AutoSize = true;
            this.lblMaintenancePercent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaintenancePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblMaintenancePercent.Location = new System.Drawing.Point(360, 140);
            this.lblMaintenancePercent.Name = "lblMaintenancePercent";
            this.lblMaintenancePercent.Size = new System.Drawing.Size(45, 23);
            this.lblMaintenancePercent.TabIndex = 9;
            this.lblMaintenancePercent.Text = "20%";
            // 
            // lblMaintenanceText
            // 
            this.lblMaintenanceText.AutoSize = true;
            this.lblMaintenanceText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaintenanceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblMaintenanceText.Location = new System.Drawing.Point(0, 140);
            this.lblMaintenanceText.Name = "lblMaintenanceText";
            this.lblMaintenanceText.Size = new System.Drawing.Size(125, 23);
            this.lblMaintenanceText.TabIndex = 8;
            this.lblMaintenanceText.Text = "Sân cần bảo trì";
            // 
            // progressMaintenance
            // 
            this.progressMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.progressMaintenance.Location = new System.Drawing.Point(150, 140);
            this.progressMaintenance.Name = "progressMaintenance";
            this.progressMaintenance.Size = new System.Drawing.Size(200, 20);
            this.progressMaintenance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressMaintenance.TabIndex = 7;
            // 
            // lblActiveFieldsPercent
            // 
            this.lblActiveFieldsPercent.AutoSize = true;
            this.lblActiveFieldsPercent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblActiveFieldsPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblActiveFieldsPercent.Location = new System.Drawing.Point(360, 90);
            this.lblActiveFieldsPercent.Name = "lblActiveFieldsPercent";
            this.lblActiveFieldsPercent.Size = new System.Drawing.Size(45, 23);
            this.lblActiveFieldsPercent.TabIndex = 6;
            this.lblActiveFieldsPercent.Text = "30%";
            // 
            // lblActiveFieldsText
            // 
            this.lblActiveFieldsText.AutoSize = true;
            this.lblActiveFieldsText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActiveFieldsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblActiveFieldsText.Location = new System.Drawing.Point(0, 90);
            this.lblActiveFieldsText.Name = "lblActiveFieldsText";
            this.lblActiveFieldsText.Size = new System.Drawing.Size(167, 23);
            this.lblActiveFieldsText.TabIndex = 5;
            this.lblActiveFieldsText.Text = "Sân đang hoạt động";
            // 
            // progressActiveFields
            // 
            this.progressActiveFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.progressActiveFields.Location = new System.Drawing.Point(150, 90);
            this.progressActiveFields.Name = "progressActiveFields";
            this.progressActiveFields.Size = new System.Drawing.Size(200, 20);
            this.progressActiveFields.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressActiveFields.TabIndex = 4;
            // 
            // lblBookingsPercent
            // 
            this.lblBookingsPercent.AutoSize = true;
            this.lblBookingsPercent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingsPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblBookingsPercent.Location = new System.Drawing.Point(360, 40);
            this.lblBookingsPercent.Name = "lblBookingsPercent";
            this.lblBookingsPercent.Size = new System.Drawing.Size(45, 23);
            this.lblBookingsPercent.TabIndex = 3;
            this.lblBookingsPercent.Text = "40%";
            // 
            // lblBookingsText
            // 
            this.lblBookingsText.AutoSize = true;
            this.lblBookingsText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblBookingsText.Location = new System.Drawing.Point(0, 40);
            this.lblBookingsText.Name = "lblBookingsText";
            this.lblBookingsText.Size = new System.Drawing.Size(103, 23);
            this.lblBookingsText.TabIndex = 2;
            this.lblBookingsText.Text = "Đơn đặt sân";
            // 
            // progressBookings
            // 
            this.progressBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.progressBookings.Location = new System.Drawing.Point(150, 40);
            this.progressBookings.Name = "progressBookings";
            this.progressBookings.Size = new System.Drawing.Size(200, 20);
            this.progressBookings.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBookings.TabIndex = 1;
            // 
            // lblFieldStatus
            // 
            this.lblFieldStatus.AutoSize = true;
            this.lblFieldStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFieldStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblFieldStatus.Location = new System.Drawing.Point(0, 0);
            this.lblFieldStatus.Name = "lblFieldStatus";
            this.lblFieldStatus.Size = new System.Drawing.Size(179, 32);
            this.lblFieldStatus.TabIndex = 0;
            this.lblFieldStatus.Text = "Tình trạng sân";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelCurrentStatus.ResumeLayout(false);
            this.panelCurrentStatus.PerformLayout();
            this.panelRecentActivity.ResumeLayout(false);
            this.panelRecentActivity.PerformLayout();
            this.rightColumn.ResumeLayout(false);
            this.panelFieldStatusChart.ResumeLayout(false);
            this.panelFieldStatusChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFieldStatus)).EndInit();
            this.panelQuickActions.ResumeLayout(false);
            this.panelQuickActions.PerformLayout();
            this.leftColumn.ResumeLayout(false);
            this.panelRevenueChart.ResumeLayout(false);
            this.panelRevenueChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelRevenue.ResumeLayout(false);
            this.panelRevenue.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFieldStatus.ResumeLayout(false);
            this.panelFieldStatus.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

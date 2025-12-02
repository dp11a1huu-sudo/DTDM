namespace GUI.Controls
{
    partial class RentalReportsControl
    {
        private System.ComponentModel.IContainer components = null;
        private GUI.Controls.HeaderControl headerControl;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalRentals;
        private System.Windows.Forms.Label lblTotalEquipment;
        private System.Windows.Forms.Label lblTopRented;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.Panel panelRevenueChart;
        private System.Windows.Forms.Label lblRevenueChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel panelTopRented;
        private System.Windows.Forms.Label lblTopRentedTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopRented;
        private System.Windows.Forms.DataGridView dgvTopRented;

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
            this.panelTopRented = new System.Windows.Forms.Panel();
            this.dgvTopRented = new System.Windows.Forms.DataGridView();
            this.chartTopRented = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTopRentedTitle = new System.Windows.Forms.Label();
            this.panelRevenueChart = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueChartTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTopRented = new System.Windows.Forms.Label();
            this.lblTotalEquipment = new System.Windows.Forms.Label();
            this.lblTotalRentals = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelCharts.SuspendLayout();
            this.panelTopRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopRented)).BeginInit();
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
            this.panelStats.Controls.Add(this.lblTopRented);
            this.panelStats.Controls.Add(this.lblTotalEquipment);
            this.panelStats.Controls.Add(this.lblTotalRentals);
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
            this.lblTotalRevenue.Text = "💰\r\nTổng doanh thu:\r\n8.000.000 đ\r\n";
            // 
            // lblTotalRentals
            // 
            this.lblTotalRentals.AutoSize = true;
            this.lblTotalRentals.BackColor = System.Drawing.Color.White;
            this.lblTotalRentals.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalRentals.Location = new System.Drawing.Point(290, 0);
            this.lblTotalRentals.Name = "lblTotalRentals";
            this.lblTotalRentals.Padding = new System.Windows.Forms.Padding(15);
            this.lblTotalRentals.Size = new System.Drawing.Size(270, 100);
            this.lblTotalRentals.TabIndex = 1;
            this.lblTotalRentals.Text = "📋\r\nTổng đơn thuê:\r\n120 đơn\r\n";
            // 
            // lblTotalEquipment
            // 
            this.lblTotalEquipment.AutoSize = true;
            this.lblTotalEquipment.BackColor = System.Drawing.Color.White;
            this.lblTotalEquipment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalEquipment.Location = new System.Drawing.Point(580, 0);
            this.lblTotalEquipment.Name = "lblTotalEquipment";
            this.lblTotalEquipment.Padding = new System.Windows.Forms.Padding(15);
            this.lblTotalEquipment.Size = new System.Drawing.Size(270, 100);
            this.lblTotalEquipment.TabIndex = 2;
            this.lblTotalEquipment.Text = "📦\r\nTổng thiết bị:\r\n50 thiết bị\r\n";
            // 
            // lblTopRented
            // 
            this.lblTopRented.AutoSize = true;
            this.lblTopRented.BackColor = System.Drawing.Color.White;
            this.lblTopRented.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTopRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTopRented.Location = new System.Drawing.Point(870, 0);
            this.lblTopRented.Name = "lblTopRented";
            this.lblTopRented.Padding = new System.Windows.Forms.Padding(15);
            this.lblTopRented.Size = new System.Drawing.Size(270, 100);
            this.lblTopRented.TabIndex = 3;
            this.lblTopRented.Text = "🏆\r\nThiết bị thuê nhiều:\r\nBóng đá size 5\r\n";
            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.panelTopRented);
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
            this.lblRevenueChartTitle.Size = new System.Drawing.Size(280, 25);
            this.lblRevenueChartTitle.TabIndex = 0;
            this.lblRevenueChartTitle.Text = "📊 Doanh thu cho thuê theo thời gian";
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.Location = new System.Drawing.Point(20, 60);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(520, 470);
            this.chartRevenue.TabIndex = 1;
            // 
            // panelTopRented
            // 
            this.panelTopRented.BackColor = System.Drawing.Color.White;
            this.panelTopRented.Controls.Add(this.dgvTopRented);
            this.panelTopRented.Controls.Add(this.chartTopRented);
            this.panelTopRented.Controls.Add(this.lblTopRentedTitle);
            this.panelTopRented.Location = new System.Drawing.Point(580, 0);
            this.panelTopRented.Name = "panelTopRented";
            this.panelTopRented.Padding = new System.Windows.Forms.Padding(20);
            this.panelTopRented.Size = new System.Drawing.Size(560, 550);
            this.panelTopRented.TabIndex = 1;
            // 
            // lblTopRentedTitle
            // 
            this.lblTopRentedTitle.AutoSize = true;
            this.lblTopRentedTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTopRentedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTopRentedTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTopRentedTitle.Name = "lblTopRentedTitle";
            this.lblTopRentedTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTopRentedTitle.TabIndex = 0;
            this.lblTopRentedTitle.Text = "🏆 Thiết bị được thuê nhiều nhất";
            // 
            // chartTopRented
            // 
            this.chartTopRented.BackColor = System.Drawing.Color.Transparent;
            this.chartTopRented.Location = new System.Drawing.Point(20, 60);
            this.chartTopRented.Name = "chartTopRented";
            this.chartTopRented.Size = new System.Drawing.Size(520, 250);
            this.chartTopRented.TabIndex = 1;
            // 
            // dgvTopRented
            // 
            this.dgvTopRented.AllowUserToAddRows = false;
            this.dgvTopRented.AllowUserToDeleteRows = false;
            this.dgvTopRented.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopRented.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopRented.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopRented.Location = new System.Drawing.Point(20, 330);
            this.dgvTopRented.MultiSelect = false;
            this.dgvTopRented.Name = "dgvTopRented";
            this.dgvTopRented.ReadOnly = true;
            this.dgvTopRented.RowHeadersVisible = false;
            this.dgvTopRented.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopRented.Size = new System.Drawing.Size(520, 200);
            this.dgvTopRented.TabIndex = 2;
            // 
            // RentalReportsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "RentalReportsControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelCharts.ResumeLayout(false);
            this.panelTopRented.ResumeLayout(false);
            this.panelTopRented.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopRented)).EndInit();
            this.panelRevenueChart.ResumeLayout(false);
            this.panelRevenueChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}


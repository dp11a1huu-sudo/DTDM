namespace GUI.Controls
{
    partial class ServiceManagementControl
    {
        private System.ComponentModel.IContainer components = null;
        private HeaderControl headerControl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Panel mainContainerFood;
        private System.Windows.Forms.Panel panelMenuManagement;
        private System.Windows.Forms.Label lblMenuManagementTitle;
        private System.Windows.Forms.Label lblMenuManagementDesc;
        private System.Windows.Forms.Button btnMenuManagementAccess;
        private System.Windows.Forms.Button btnMenuManagementDetails;
        private System.Windows.Forms.Panel panelOrderManagement;
        private System.Windows.Forms.Label lblOrderManagementTitle;
        private System.Windows.Forms.Label lblOrderManagementDesc;
        private System.Windows.Forms.Button btnOrderManagementAccess;
        private System.Windows.Forms.Button btnOrderManagementDetails;
        private System.Windows.Forms.Panel panelFoodReports;
        private System.Windows.Forms.Label lblFoodReportsTitle;
        private System.Windows.Forms.Label lblFoodReportsDesc;
        private System.Windows.Forms.Button btnFoodReportsAccess;
        private System.Windows.Forms.Button btnFoodReportsDetails;
        private System.Windows.Forms.TabPage tabRental;
        private System.Windows.Forms.Panel mainContainerRental;
        private System.Windows.Forms.Panel panelEquipmentManagement;
        private System.Windows.Forms.Label lblEquipmentManagementTitle;
        private System.Windows.Forms.Label lblEquipmentManagementDesc;
        private System.Windows.Forms.Button btnEquipmentManagementAccess;
        private System.Windows.Forms.Button btnEquipmentManagementDetails;
        private System.Windows.Forms.Panel panelRentalManagement;
        private System.Windows.Forms.Label lblRentalManagementTitle;
        private System.Windows.Forms.Label lblRentalManagementDesc;
        private System.Windows.Forms.Button btnRentalManagementAccess;
        private System.Windows.Forms.Button btnRentalManagementDetails;
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.Label lblMaintenanceTitle;
        private System.Windows.Forms.Label lblMaintenanceDesc;
        private System.Windows.Forms.Button btnMaintenanceAccess;
        private System.Windows.Forms.Button btnMaintenanceDetails;
        private System.Windows.Forms.Panel panelRentalReports;
        private System.Windows.Forms.Label lblRentalReportsTitle;
        private System.Windows.Forms.Label lblRentalReportsDesc;
        private System.Windows.Forms.Button btnRentalReportsAccess;
        private System.Windows.Forms.Button btnRentalReportsDetails;

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
            this.headerControl = new HeaderControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.mainContainerFood = new System.Windows.Forms.Panel();
            this.panelFoodReports = new System.Windows.Forms.Panel();
            this.btnFoodReportsDetails = new System.Windows.Forms.Button();
            this.btnFoodReportsAccess = new System.Windows.Forms.Button();
            this.lblFoodReportsDesc = new System.Windows.Forms.Label();
            this.lblFoodReportsTitle = new System.Windows.Forms.Label();
            this.panelOrderManagement = new System.Windows.Forms.Panel();
            this.btnOrderManagementDetails = new System.Windows.Forms.Button();
            this.btnOrderManagementAccess = new System.Windows.Forms.Button();
            this.lblOrderManagementDesc = new System.Windows.Forms.Label();
            this.lblOrderManagementTitle = new System.Windows.Forms.Label();
            this.panelMenuManagement = new System.Windows.Forms.Panel();
            this.btnMenuManagementDetails = new System.Windows.Forms.Button();
            this.btnMenuManagementAccess = new System.Windows.Forms.Button();
            this.lblMenuManagementDesc = new System.Windows.Forms.Label();
            this.lblMenuManagementTitle = new System.Windows.Forms.Label();
            this.tabRental = new System.Windows.Forms.TabPage();
            this.mainContainerRental = new System.Windows.Forms.Panel();
            this.panelRentalReports = new System.Windows.Forms.Panel();
            this.btnRentalReportsDetails = new System.Windows.Forms.Button();
            this.btnRentalReportsAccess = new System.Windows.Forms.Button();
            this.lblRentalReportsDesc = new System.Windows.Forms.Label();
            this.lblRentalReportsTitle = new System.Windows.Forms.Label();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.btnMaintenanceDetails = new System.Windows.Forms.Button();
            this.btnMaintenanceAccess = new System.Windows.Forms.Button();
            this.lblMaintenanceDesc = new System.Windows.Forms.Label();
            this.lblMaintenanceTitle = new System.Windows.Forms.Label();
            this.panelRentalManagement = new System.Windows.Forms.Panel();
            this.btnRentalManagementDetails = new System.Windows.Forms.Button();
            this.btnRentalManagementAccess = new System.Windows.Forms.Button();
            this.lblRentalManagementDesc = new System.Windows.Forms.Label();
            this.lblRentalManagementTitle = new System.Windows.Forms.Label();
            this.panelEquipmentManagement = new System.Windows.Forms.Panel();
            this.btnEquipmentManagementDetails = new System.Windows.Forms.Button();
            this.btnEquipmentManagementAccess = new System.Windows.Forms.Button();
            this.lblEquipmentManagementDesc = new System.Windows.Forms.Label();
            this.lblEquipmentManagementTitle = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabFood.SuspendLayout();
            this.mainContainerFood.SuspendLayout();
            this.panelFoodReports.SuspendLayout();
            this.panelOrderManagement.SuspendLayout();
            this.panelMenuManagement.SuspendLayout();
            this.tabRental.SuspendLayout();
            this.mainContainerRental.SuspendLayout();
            this.panelRentalReports.SuspendLayout();
            this.panelMaintenance.SuspendLayout();
            this.panelRentalManagement.SuspendLayout();
            this.panelEquipmentManagement.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFood);
            this.tabControl.Controls.Add(this.tabRental);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 730);
            this.tabControl.TabIndex = 1;
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.mainContainerFood);
            this.tabFood.Location = new System.Drawing.Point(4, 26);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(1192, 700);
            this.tabFood.TabIndex = 0;
            this.tabFood.Text = "🍔 Dịch vụ ăn uống";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // mainContainerFood
            // 
            this.mainContainerFood.BackColor = System.Drawing.Color.White;
            this.mainContainerFood.Controls.Add(this.panelFoodReports);
            this.mainContainerFood.Controls.Add(this.panelOrderManagement);
            this.mainContainerFood.Controls.Add(this.panelMenuManagement);
            this.mainContainerFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainerFood.Location = new System.Drawing.Point(3, 3);
            this.mainContainerFood.Name = "mainContainerFood";
            this.mainContainerFood.Padding = new System.Windows.Forms.Padding(40);
            this.mainContainerFood.Size = new System.Drawing.Size(1186, 694);
            this.mainContainerFood.TabIndex = 0;
            // 
            // panelMenuManagement
            // 
            this.panelMenuManagement.BackColor = System.Drawing.Color.White;
            this.panelMenuManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuManagement.Controls.Add(this.btnMenuManagementDetails);
            this.panelMenuManagement.Controls.Add(this.btnMenuManagementAccess);
            this.panelMenuManagement.Controls.Add(this.lblMenuManagementDesc);
            this.panelMenuManagement.Controls.Add(this.lblMenuManagementTitle);
            this.panelMenuManagement.Location = new System.Drawing.Point(40, 40);
            this.panelMenuManagement.Name = "panelMenuManagement";
            this.panelMenuManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelMenuManagement.Size = new System.Drawing.Size(550, 280);
            this.panelMenuManagement.TabIndex = 0;
            // 
            // lblMenuManagementTitle
            // 
            this.lblMenuManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenuManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMenuManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblMenuManagementTitle.Name = "lblMenuManagementTitle";
            this.lblMenuManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblMenuManagementTitle.TabIndex = 0;
            this.lblMenuManagementTitle.Text = "📋 Quản lý Menu/Món ăn";
            // 
            // lblMenuManagementDesc
            // 
            this.lblMenuManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMenuManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblMenuManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblMenuManagementDesc.Name = "lblMenuManagementDesc";
            this.lblMenuManagementDesc.Size = new System.Drawing.Size(490, 100);
            this.lblMenuManagementDesc.TabIndex = 1;
            this.lblMenuManagementDesc.Text = "Quản lý menu và món ăn, bao gồm thêm/sửa/xóa món, quản lý giá bán, tồn kho và trạng thái";
            // 
            // btnMenuManagementAccess
            // 
            this.btnMenuManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnMenuManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnMenuManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnMenuManagementAccess.Location = new System.Drawing.Point(30, 200);
            this.btnMenuManagementAccess.Name = "btnMenuManagementAccess";
            this.btnMenuManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnMenuManagementAccess.TabIndex = 2;
            this.btnMenuManagementAccess.Text = "▶ Truy cập";
            this.btnMenuManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnMenuManagementDetails
            // 
            this.btnMenuManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnMenuManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnMenuManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenuManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnMenuManagementDetails.Location = new System.Drawing.Point(250, 200);
            this.btnMenuManagementDetails.Name = "btnMenuManagementDetails";
            this.btnMenuManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnMenuManagementDetails.TabIndex = 3;
            this.btnMenuManagementDetails.Text = "ⓘ Chi tiết";
            this.btnMenuManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelOrderManagement
            // 
            this.panelOrderManagement.BackColor = System.Drawing.Color.White;
            this.panelOrderManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrderManagement.Controls.Add(this.btnOrderManagementDetails);
            this.panelOrderManagement.Controls.Add(this.btnOrderManagementAccess);
            this.panelOrderManagement.Controls.Add(this.lblOrderManagementDesc);
            this.panelOrderManagement.Controls.Add(this.lblOrderManagementTitle);
            this.panelOrderManagement.Location = new System.Drawing.Point(610, 40);
            this.panelOrderManagement.Name = "panelOrderManagement";
            this.panelOrderManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelOrderManagement.Size = new System.Drawing.Size(550, 280);
            this.panelOrderManagement.TabIndex = 1;
            // 
            // lblOrderManagementTitle
            // 
            this.lblOrderManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblOrderManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblOrderManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblOrderManagementTitle.Name = "lblOrderManagementTitle";
            this.lblOrderManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblOrderManagementTitle.TabIndex = 0;
            this.lblOrderManagementTitle.Text = "🛒 Quản lý đơn hàng";
            // 
            // lblOrderManagementDesc
            // 
            this.lblOrderManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOrderManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOrderManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblOrderManagementDesc.Name = "lblOrderManagementDesc";
            this.lblOrderManagementDesc.Size = new System.Drawing.Size(490, 100);
            this.lblOrderManagementDesc.TabIndex = 1;
            this.lblOrderManagementDesc.Text = "Tạo và quản lý đơn hàng ăn uống, cập nhật trạng thái đơn hàng, xử lý thanh toán và in hóa đơn";
            // 
            // btnOrderManagementAccess
            // 
            this.btnOrderManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnOrderManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnOrderManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrderManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnOrderManagementAccess.Location = new System.Drawing.Point(30, 200);
            this.btnOrderManagementAccess.Name = "btnOrderManagementAccess";
            this.btnOrderManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnOrderManagementAccess.TabIndex = 2;
            this.btnOrderManagementAccess.Text = "▶ Truy cập";
            this.btnOrderManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnOrderManagementDetails
            // 
            this.btnOrderManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnOrderManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnOrderManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrderManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnOrderManagementDetails.Location = new System.Drawing.Point(250, 200);
            this.btnOrderManagementDetails.Name = "btnOrderManagementDetails";
            this.btnOrderManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnOrderManagementDetails.TabIndex = 3;
            this.btnOrderManagementDetails.Text = "ⓘ Chi tiết";
            this.btnOrderManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelFoodReports
            // 
            this.panelFoodReports.BackColor = System.Drawing.Color.White;
            this.panelFoodReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFoodReports.Controls.Add(this.btnFoodReportsDetails);
            this.panelFoodReports.Controls.Add(this.btnFoodReportsAccess);
            this.panelFoodReports.Controls.Add(this.lblFoodReportsDesc);
            this.panelFoodReports.Controls.Add(this.lblFoodReportsTitle);
            this.panelFoodReports.Location = new System.Drawing.Point(40, 340);
            this.panelFoodReports.Name = "panelFoodReports";
            this.panelFoodReports.Padding = new System.Windows.Forms.Padding(30);
            this.panelFoodReports.Size = new System.Drawing.Size(550, 280);
            this.panelFoodReports.TabIndex = 2;
            // 
            // lblFoodReportsTitle
            // 
            this.lblFoodReportsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFoodReportsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblFoodReportsTitle.Location = new System.Drawing.Point(80, 30);
            this.lblFoodReportsTitle.Name = "lblFoodReportsTitle";
            this.lblFoodReportsTitle.Size = new System.Drawing.Size(440, 40);
            this.lblFoodReportsTitle.TabIndex = 0;
            this.lblFoodReportsTitle.Text = "📊 Báo cáo & Thống kê";
            // 
            // lblFoodReportsDesc
            // 
            this.lblFoodReportsDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFoodReportsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFoodReportsDesc.Location = new System.Drawing.Point(30, 90);
            this.lblFoodReportsDesc.Name = "lblFoodReportsDesc";
            this.lblFoodReportsDesc.Size = new System.Drawing.Size(490, 100);
            this.lblFoodReportsDesc.TabIndex = 1;
            this.lblFoodReportsDesc.Text = "Biểu đồ doanh thu theo thời gian, top món bán chạy, phân tích lợi nhuận (doanh thu - giá vốn)";
            // 
            // btnFoodReportsAccess
            // 
            this.btnFoodReportsAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFoodReportsAccess.FlatAppearance.BorderSize = 0;
            this.btnFoodReportsAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodReportsAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFoodReportsAccess.ForeColor = System.Drawing.Color.White;
            this.btnFoodReportsAccess.Location = new System.Drawing.Point(30, 200);
            this.btnFoodReportsAccess.Name = "btnFoodReportsAccess";
            this.btnFoodReportsAccess.Size = new System.Drawing.Size(200, 45);
            this.btnFoodReportsAccess.TabIndex = 2;
            this.btnFoodReportsAccess.Text = "▶ Truy cập";
            this.btnFoodReportsAccess.UseVisualStyleBackColor = false;
            // 
            // btnFoodReportsDetails
            // 
            this.btnFoodReportsDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnFoodReportsDetails.FlatAppearance.BorderSize = 0;
            this.btnFoodReportsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodReportsDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFoodReportsDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFoodReportsDetails.Location = new System.Drawing.Point(250, 200);
            this.btnFoodReportsDetails.Name = "btnFoodReportsDetails";
            this.btnFoodReportsDetails.Size = new System.Drawing.Size(200, 45);
            this.btnFoodReportsDetails.TabIndex = 3;
            this.btnFoodReportsDetails.Text = "ⓘ Chi tiết";
            this.btnFoodReportsDetails.UseVisualStyleBackColor = false;
            // 
            // tabRental
            // 
            this.tabRental.Controls.Add(this.mainContainerRental);
            this.tabRental.Location = new System.Drawing.Point(4, 26);
            this.tabRental.Name = "tabRental";
            this.tabRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabRental.Size = new System.Drawing.Size(1192, 700);
            this.tabRental.TabIndex = 1;
            this.tabRental.Text = "⚽ Cho thuê thiết bị";
            this.tabRental.UseVisualStyleBackColor = true;
            // 
            // mainContainerRental
            // 
            this.mainContainerRental.BackColor = System.Drawing.Color.White;
            this.mainContainerRental.Controls.Add(this.panelRentalReports);
            this.mainContainerRental.Controls.Add(this.panelMaintenance);
            this.mainContainerRental.Controls.Add(this.panelRentalManagement);
            this.mainContainerRental.Controls.Add(this.panelEquipmentManagement);
            this.mainContainerRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainerRental.Location = new System.Drawing.Point(3, 3);
            this.mainContainerRental.Name = "mainContainerRental";
            this.mainContainerRental.Padding = new System.Windows.Forms.Padding(40);
            this.mainContainerRental.Size = new System.Drawing.Size(1186, 694);
            this.mainContainerRental.TabIndex = 0;
            // 
            // panelEquipmentManagement
            // 
            this.panelEquipmentManagement.BackColor = System.Drawing.Color.White;
            this.panelEquipmentManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEquipmentManagement.Controls.Add(this.btnEquipmentManagementDetails);
            this.panelEquipmentManagement.Controls.Add(this.btnEquipmentManagementAccess);
            this.panelEquipmentManagement.Controls.Add(this.lblEquipmentManagementDesc);
            this.panelEquipmentManagement.Controls.Add(this.lblEquipmentManagementTitle);
            this.panelEquipmentManagement.Location = new System.Drawing.Point(40, 40);
            this.panelEquipmentManagement.Name = "panelEquipmentManagement";
            this.panelEquipmentManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelEquipmentManagement.Size = new System.Drawing.Size(550, 280);
            this.panelEquipmentManagement.TabIndex = 0;
            // 
            // lblEquipmentManagementTitle
            // 
            this.lblEquipmentManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblEquipmentManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblEquipmentManagementTitle.Name = "lblEquipmentManagementTitle";
            this.lblEquipmentManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblEquipmentManagementTitle.TabIndex = 0;
            this.lblEquipmentManagementTitle.Text = "⚽ Quản lý danh mục thiết bị";
            // 
            // lblEquipmentManagementDesc
            // 
            this.lblEquipmentManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEquipmentManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEquipmentManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblEquipmentManagementDesc.Name = "lblEquipmentManagementDesc";
            this.lblEquipmentManagementDesc.Size = new System.Drawing.Size(490, 100);
            this.lblEquipmentManagementDesc.TabIndex = 1;
            this.lblEquipmentManagementDesc.Text = "Quản lý danh mục thiết bị cho thuê, bao gồm thêm/sửa/xóa thiết bị, quản lý giá thuê, số lượng và tình trạng";
            // 
            // btnEquipmentManagementAccess
            // 
            this.btnEquipmentManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnEquipmentManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnEquipmentManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipmentManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEquipmentManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnEquipmentManagementAccess.Location = new System.Drawing.Point(30, 200);
            this.btnEquipmentManagementAccess.Name = "btnEquipmentManagementAccess";
            this.btnEquipmentManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnEquipmentManagementAccess.TabIndex = 2;
            this.btnEquipmentManagementAccess.Text = "▶ Truy cập";
            this.btnEquipmentManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnEquipmentManagementDetails
            // 
            this.btnEquipmentManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnEquipmentManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnEquipmentManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipmentManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEquipmentManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnEquipmentManagementDetails.Location = new System.Drawing.Point(250, 200);
            this.btnEquipmentManagementDetails.Name = "btnEquipmentManagementDetails";
            this.btnEquipmentManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnEquipmentManagementDetails.TabIndex = 3;
            this.btnEquipmentManagementDetails.Text = "ⓘ Chi tiết";
            this.btnEquipmentManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelRentalManagement
            // 
            this.panelRentalManagement.BackColor = System.Drawing.Color.White;
            this.panelRentalManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRentalManagement.Controls.Add(this.btnRentalManagementDetails);
            this.panelRentalManagement.Controls.Add(this.btnRentalManagementAccess);
            this.panelRentalManagement.Controls.Add(this.lblRentalManagementDesc);
            this.panelRentalManagement.Controls.Add(this.lblRentalManagementTitle);
            this.panelRentalManagement.Location = new System.Drawing.Point(610, 40);
            this.panelRentalManagement.Name = "panelRentalManagement";
            this.panelRentalManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelRentalManagement.Size = new System.Drawing.Size(550, 280);
            this.panelRentalManagement.TabIndex = 1;
            // 
            // lblRentalManagementTitle
            // 
            this.lblRentalManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRentalManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblRentalManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblRentalManagementTitle.Name = "lblRentalManagementTitle";
            this.lblRentalManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblRentalManagementTitle.TabIndex = 0;
            this.lblRentalManagementTitle.Text = "📋 Quản lý cho thuê";
            // 
            // lblRentalManagementDesc
            // 
            this.lblRentalManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRentalManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRentalManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblRentalManagementDesc.Name = "lblRentalManagementDesc";
            this.lblRentalManagementDesc.Size = new System.Drawing.Size(490, 100);
            this.lblRentalManagementDesc.TabIndex = 1;
            this.lblRentalManagementDesc.Text = "Tạo và quản lý đơn thuê thiết bị, xác nhận trả thiết bị, xử lý thanh toán và báo cáo hư hỏng/mất mát";
            // 
            // btnRentalManagementAccess
            // 
            this.btnRentalManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRentalManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnRentalManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRentalManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnRentalManagementAccess.Location = new System.Drawing.Point(30, 200);
            this.btnRentalManagementAccess.Name = "btnRentalManagementAccess";
            this.btnRentalManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnRentalManagementAccess.TabIndex = 2;
            this.btnRentalManagementAccess.Text = "▶ Truy cập";
            this.btnRentalManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnRentalManagementDetails
            // 
            this.btnRentalManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnRentalManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnRentalManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRentalManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRentalManagementDetails.Location = new System.Drawing.Point(250, 200);
            this.btnRentalManagementDetails.Name = "btnRentalManagementDetails";
            this.btnRentalManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnRentalManagementDetails.TabIndex = 3;
            this.btnRentalManagementDetails.Text = "ⓘ Chi tiết";
            this.btnRentalManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.BackColor = System.Drawing.Color.White;
            this.panelMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaintenance.Controls.Add(this.btnMaintenanceDetails);
            this.panelMaintenance.Controls.Add(this.btnMaintenanceAccess);
            this.panelMaintenance.Controls.Add(this.lblMaintenanceDesc);
            this.panelMaintenance.Controls.Add(this.lblMaintenanceTitle);
            this.panelMaintenance.Location = new System.Drawing.Point(40, 340);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Padding = new System.Windows.Forms.Padding(30);
            this.panelMaintenance.Size = new System.Drawing.Size(550, 280);
            this.panelMaintenance.TabIndex = 2;
            // 
            // lblMaintenanceTitle
            // 
            this.lblMaintenanceTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMaintenanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMaintenanceTitle.Location = new System.Drawing.Point(80, 30);
            this.lblMaintenanceTitle.Name = "lblMaintenanceTitle";
            this.lblMaintenanceTitle.Size = new System.Drawing.Size(440, 40);
            this.lblMaintenanceTitle.TabIndex = 0;
            this.lblMaintenanceTitle.Text = "🔧 Theo dõi & Bảo trì";
            // 
            // lblMaintenanceDesc
            // 
            this.lblMaintenanceDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMaintenanceDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblMaintenanceDesc.Location = new System.Drawing.Point(30, 90);
            this.lblMaintenanceDesc.Name = "lblMaintenanceDesc";
            this.lblMaintenanceDesc.Size = new System.Drawing.Size(490, 100);
            this.lblMaintenanceDesc.TabIndex = 1;
            this.lblMaintenanceDesc.Text = "Ghi nhận bảo trì, cảnh báo thiết bị cần bảo trì, lịch sử bảo trì và theo dõi tình trạng thiết bị";
            // 
            // btnMaintenanceAccess
            // 
            this.btnMaintenanceAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnMaintenanceAccess.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintenanceAccess.ForeColor = System.Drawing.Color.White;
            this.btnMaintenanceAccess.Location = new System.Drawing.Point(30, 200);
            this.btnMaintenanceAccess.Name = "btnMaintenanceAccess";
            this.btnMaintenanceAccess.Size = new System.Drawing.Size(200, 45);
            this.btnMaintenanceAccess.TabIndex = 2;
            this.btnMaintenanceAccess.Text = "▶ Truy cập";
            this.btnMaintenanceAccess.UseVisualStyleBackColor = false;
            // 
            // btnMaintenanceDetails
            // 
            this.btnMaintenanceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnMaintenanceDetails.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMaintenanceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnMaintenanceDetails.Location = new System.Drawing.Point(250, 200);
            this.btnMaintenanceDetails.Name = "btnMaintenanceDetails";
            this.btnMaintenanceDetails.Size = new System.Drawing.Size(200, 45);
            this.btnMaintenanceDetails.TabIndex = 3;
            this.btnMaintenanceDetails.Text = "ⓘ Chi tiết";
            this.btnMaintenanceDetails.UseVisualStyleBackColor = false;
            // 
            // panelRentalReports
            // 
            this.panelRentalReports.BackColor = System.Drawing.Color.White;
            this.panelRentalReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRentalReports.Controls.Add(this.btnRentalReportsDetails);
            this.panelRentalReports.Controls.Add(this.btnRentalReportsAccess);
            this.panelRentalReports.Controls.Add(this.lblRentalReportsDesc);
            this.panelRentalReports.Controls.Add(this.lblRentalReportsTitle);
            this.panelRentalReports.Location = new System.Drawing.Point(610, 340);
            this.panelRentalReports.Name = "panelRentalReports";
            this.panelRentalReports.Padding = new System.Windows.Forms.Padding(30);
            this.panelRentalReports.Size = new System.Drawing.Size(550, 280);
            this.panelRentalReports.TabIndex = 3;
            // 
            // lblRentalReportsTitle
            // 
            this.lblRentalReportsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRentalReportsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblRentalReportsTitle.Location = new System.Drawing.Point(80, 30);
            this.lblRentalReportsTitle.Name = "lblRentalReportsTitle";
            this.lblRentalReportsTitle.Size = new System.Drawing.Size(440, 40);
            this.lblRentalReportsTitle.TabIndex = 0;
            this.lblRentalReportsTitle.Text = "📊 Báo cáo & Thống kê";
            // 
            // lblRentalReportsDesc
            // 
            this.lblRentalReportsDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRentalReportsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRentalReportsDesc.Location = new System.Drawing.Point(30, 90);
            this.lblRentalReportsDesc.Name = "lblRentalReportsDesc";
            this.lblRentalReportsDesc.Size = new System.Drawing.Size(490, 100);
            this.lblRentalReportsDesc.TabIndex = 1;
            this.lblRentalReportsDesc.Text = "Doanh thu cho thuê theo thời gian, thiết bị được thuê nhiều nhất, tỷ lệ sử dụng thiết bị và chi phí bảo trì";
            // 
            // btnRentalReportsAccess
            // 
            this.btnRentalReportsAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRentalReportsAccess.FlatAppearance.BorderSize = 0;
            this.btnRentalReportsAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalReportsAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRentalReportsAccess.ForeColor = System.Drawing.Color.White;
            this.btnRentalReportsAccess.Location = new System.Drawing.Point(30, 200);
            this.btnRentalReportsAccess.Name = "btnRentalReportsAccess";
            this.btnRentalReportsAccess.Size = new System.Drawing.Size(200, 45);
            this.btnRentalReportsAccess.TabIndex = 2;
            this.btnRentalReportsAccess.Text = "▶ Truy cập";
            this.btnRentalReportsAccess.UseVisualStyleBackColor = false;
            // 
            // btnRentalReportsDetails
            // 
            this.btnRentalReportsDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnRentalReportsDetails.FlatAppearance.BorderSize = 0;
            this.btnRentalReportsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalReportsDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRentalReportsDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRentalReportsDetails.Location = new System.Drawing.Point(250, 200);
            this.btnRentalReportsDetails.Name = "btnRentalReportsDetails";
            this.btnRentalReportsDetails.Size = new System.Drawing.Size(200, 45);
            this.btnRentalReportsDetails.TabIndex = 3;
            this.btnRentalReportsDetails.Text = "ⓘ Chi tiết";
            this.btnRentalReportsDetails.UseVisualStyleBackColor = false;
            // 
            // ServiceManagementControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.headerControl);
            this.Name = "ServiceManagementControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.tabControl.ResumeLayout(false);
            this.tabFood.ResumeLayout(false);
            this.mainContainerFood.ResumeLayout(false);
            this.panelFoodReports.ResumeLayout(false);
            this.panelOrderManagement.ResumeLayout(false);
            this.panelMenuManagement.ResumeLayout(false);
            this.tabRental.ResumeLayout(false);
            this.mainContainerRental.ResumeLayout(false);
            this.panelRentalReports.ResumeLayout(false);
            this.panelMaintenance.ResumeLayout(false);
            this.panelRentalManagement.ResumeLayout(false);
            this.panelEquipmentManagement.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

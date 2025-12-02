namespace GUI.Controls
{
    partial class FieldControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panelFieldInfo;
        private System.Windows.Forms.Label lblFieldInfoTitle;
        private System.Windows.Forms.Label lblFieldInfoDesc;
        private System.Windows.Forms.Button btnFieldInfoAccess;
        private System.Windows.Forms.Button btnFieldInfoDetails;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblBookingDesc;
        private System.Windows.Forms.Button btnBookingAccess;
        private System.Windows.Forms.Button btnBookingDetails;
        private System.Windows.Forms.Panel panelFacilities;
        private System.Windows.Forms.Label lblFacilitiesTitle;
        private System.Windows.Forms.Label lblFacilitiesDesc;
        private System.Windows.Forms.Button btnFacilitiesAccess;
        private System.Windows.Forms.Button btnFacilitiesDetails;
        private System.Windows.Forms.Panel panelRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueDesc;
        private System.Windows.Forms.Button btnRevenueAccess;
        private System.Windows.Forms.Button btnRevenueDetails;
        private HeaderControl headerControl;

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
            this.headerControl = new HeaderControl();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.btnRevenueDetails = new System.Windows.Forms.Button();
            this.btnRevenueAccess = new System.Windows.Forms.Button();
            this.lblRevenueDesc = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.panelFacilities = new System.Windows.Forms.Panel();
            this.btnFacilitiesDetails = new System.Windows.Forms.Button();
            this.btnFacilitiesAccess = new System.Windows.Forms.Button();
            this.lblFacilitiesDesc = new System.Windows.Forms.Label();
            this.lblFacilitiesTitle = new System.Windows.Forms.Label();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.btnBookingDetails = new System.Windows.Forms.Button();
            this.btnBookingAccess = new System.Windows.Forms.Button();
            this.lblBookingDesc = new System.Windows.Forms.Label();
            this.lblBookingTitle = new System.Windows.Forms.Label();
            this.panelFieldInfo = new System.Windows.Forms.Panel();
            this.btnFieldInfoDetails = new System.Windows.Forms.Button();
            this.btnFieldInfoAccess = new System.Windows.Forms.Button();
            this.lblFieldInfoDesc = new System.Windows.Forms.Label();
            this.lblFieldInfoTitle = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelRevenue.SuspendLayout();
            this.panelFacilities.SuspendLayout();
            this.panelBooking.SuspendLayout();
            this.panelFieldInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.Controls.Add(this.panelRevenue);
            this.mainContainer.Controls.Add(this.panelFacilities);
            this.mainContainer.Controls.Add(this.panelBooking);
            this.mainContainer.Controls.Add(this.panelFieldInfo);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(40);
            this.mainContainer.Size = new System.Drawing.Size(1200, 730);
            this.mainContainer.TabIndex = 0;
            // 
            // headerControl
            // 
            this.headerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 70);
            this.headerControl.TabIndex = 0;
            // 
            // panelFieldInfo
            // 
            this.panelFieldInfo.BackColor = System.Drawing.Color.White;
            this.panelFieldInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFieldInfo.Controls.Add(this.btnFieldInfoDetails);
            this.panelFieldInfo.Controls.Add(this.btnFieldInfoAccess);
            this.panelFieldInfo.Controls.Add(this.lblFieldInfoDesc);
            this.panelFieldInfo.Controls.Add(this.lblFieldInfoTitle);
            this.panelFieldInfo.Location = new System.Drawing.Point(40, 40);
            this.panelFieldInfo.Name = "panelFieldInfo";
            this.panelFieldInfo.Padding = new System.Windows.Forms.Padding(30);
            this.panelFieldInfo.Size = new System.Drawing.Size(550, 350);
            this.panelFieldInfo.TabIndex = 0;
            // 
            // lblFieldInfoTitle
            // 
            this.lblFieldInfoTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFieldInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblFieldInfoTitle.Location = new System.Drawing.Point(80, 30);
            this.lblFieldInfoTitle.Name = "lblFieldInfoTitle";
            this.lblFieldInfoTitle.Size = new System.Drawing.Size(440, 40);
            this.lblFieldInfoTitle.TabIndex = 0;
            this.lblFieldInfoTitle.Text = "📋 Thông tin sân bóng";
            // 
            // lblFieldInfoDesc
            // 
            this.lblFieldInfoDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFieldInfoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFieldInfoDesc.Location = new System.Drawing.Point(30, 90);
            this.lblFieldInfoDesc.Name = "lblFieldInfoDesc";
            this.lblFieldInfoDesc.Size = new System.Drawing.Size(490, 120);
            this.lblFieldInfoDesc.TabIndex = 1;
            this.lblFieldInfoDesc.Text = "Quản lý thông tin chi tiết sân bóng, bao gồm loại sân, diện tích, mặt cỏ, giá thuê theo khung giờ";
            // 
            // btnFieldInfoAccess
            // 
            this.btnFieldInfoAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFieldInfoAccess.FlatAppearance.BorderSize = 0;
            this.btnFieldInfoAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFieldInfoAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFieldInfoAccess.ForeColor = System.Drawing.Color.White;
            this.btnFieldInfoAccess.Location = new System.Drawing.Point(30, 230);
            this.btnFieldInfoAccess.Name = "btnFieldInfoAccess";
            this.btnFieldInfoAccess.Size = new System.Drawing.Size(200, 45);
            this.btnFieldInfoAccess.TabIndex = 2;
            this.btnFieldInfoAccess.Text = "▶ Truy cập";
            this.btnFieldInfoAccess.UseVisualStyleBackColor = false;
            // 
            // btnFieldInfoDetails
            // 
            this.btnFieldInfoDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnFieldInfoDetails.FlatAppearance.BorderSize = 0;
            this.btnFieldInfoDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFieldInfoDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFieldInfoDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFieldInfoDetails.Location = new System.Drawing.Point(250, 230);
            this.btnFieldInfoDetails.Name = "btnFieldInfoDetails";
            this.btnFieldInfoDetails.Size = new System.Drawing.Size(200, 45);
            this.btnFieldInfoDetails.TabIndex = 3;
            this.btnFieldInfoDetails.Text = "ⓘ Chi tiết";
            this.btnFieldInfoDetails.UseVisualStyleBackColor = false;
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.White;
            this.panelBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBooking.Controls.Add(this.btnBookingDetails);
            this.panelBooking.Controls.Add(this.btnBookingAccess);
            this.panelBooking.Controls.Add(this.lblBookingDesc);
            this.panelBooking.Controls.Add(this.lblBookingTitle);
            this.panelBooking.Location = new System.Drawing.Point(610, 40);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Padding = new System.Windows.Forms.Padding(30);
            this.panelBooking.Size = new System.Drawing.Size(550, 350);
            this.panelBooking.TabIndex = 1;
            // 
            // lblBookingTitle
            // 
            this.lblBookingTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBookingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBookingTitle.Location = new System.Drawing.Point(80, 30);
            this.lblBookingTitle.Name = "lblBookingTitle";
            this.lblBookingTitle.Size = new System.Drawing.Size(440, 40);
            this.lblBookingTitle.TabIndex = 0;
            this.lblBookingTitle.Text = "📅 Đặt sân & Thanh toán";
            // 
            // lblBookingDesc
            // 
            this.lblBookingDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBookingDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblBookingDesc.Location = new System.Drawing.Point(30, 90);
            this.lblBookingDesc.Name = "lblBookingDesc";
            this.lblBookingDesc.Size = new System.Drawing.Size(490, 120);
            this.lblBookingDesc.TabIndex = 1;
            this.lblBookingDesc.Text = "Quản lý đặt sân theo ngày và khung giờ, xử lý thanh toán và xác nhận đơn đặt sân";
            // 
            // btnBookingAccess
            // 
            this.btnBookingAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnBookingAccess.FlatAppearance.BorderSize = 0;
            this.btnBookingAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBookingAccess.ForeColor = System.Drawing.Color.White;
            this.btnBookingAccess.Location = new System.Drawing.Point(30, 230);
            this.btnBookingAccess.Name = "btnBookingAccess";
            this.btnBookingAccess.Size = new System.Drawing.Size(200, 45);
            this.btnBookingAccess.TabIndex = 2;
            this.btnBookingAccess.Text = "▶ Truy cập";
            this.btnBookingAccess.UseVisualStyleBackColor = false;
            // 
            // btnBookingDetails
            // 
            this.btnBookingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnBookingDetails.FlatAppearance.BorderSize = 0;
            this.btnBookingDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBookingDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnBookingDetails.Location = new System.Drawing.Point(250, 230);
            this.btnBookingDetails.Name = "btnBookingDetails";
            this.btnBookingDetails.Size = new System.Drawing.Size(200, 45);
            this.btnBookingDetails.TabIndex = 3;
            this.btnBookingDetails.Text = "ⓘ Chi tiết";
            this.btnBookingDetails.UseVisualStyleBackColor = false;
            // 
            // panelFacilities
            // 
            this.panelFacilities.BackColor = System.Drawing.Color.White;
            this.panelFacilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFacilities.Controls.Add(this.btnFacilitiesDetails);
            this.panelFacilities.Controls.Add(this.btnFacilitiesAccess);
            this.panelFacilities.Controls.Add(this.lblFacilitiesDesc);
            this.panelFacilities.Controls.Add(this.lblFacilitiesTitle);
            this.panelFacilities.Location = new System.Drawing.Point(40, 410);
            this.panelFacilities.Name = "panelFacilities";
            this.panelFacilities.Padding = new System.Windows.Forms.Padding(30);
            this.panelFacilities.Size = new System.Drawing.Size(550, 350);
            this.panelFacilities.TabIndex = 2;
            // 
            // lblFacilitiesTitle
            // 
            this.lblFacilitiesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFacilitiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblFacilitiesTitle.Location = new System.Drawing.Point(80, 30);
            this.lblFacilitiesTitle.Name = "lblFacilitiesTitle";
            this.lblFacilitiesTitle.Size = new System.Drawing.Size(440, 40);
            this.lblFacilitiesTitle.TabIndex = 0;
            this.lblFacilitiesTitle.Text = "🔧 Cơ sở vật chất";
            // 
            // lblFacilitiesDesc
            // 
            this.lblFacilitiesDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFacilitiesDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFacilitiesDesc.Location = new System.Drawing.Point(30, 90);
            this.lblFacilitiesDesc.Name = "lblFacilitiesDesc";
            this.lblFacilitiesDesc.Size = new System.Drawing.Size(490, 120);
            this.lblFacilitiesDesc.TabIndex = 1;
            this.lblFacilitiesDesc.Text = "Theo dõi và quản lý trang thiết bị, lập phiếu bảo trì và sửa chữa kịp thời";
            // 
            // btnFacilitiesAccess
            // 
            this.btnFacilitiesAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFacilitiesAccess.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFacilitiesAccess.ForeColor = System.Drawing.Color.White;
            this.btnFacilitiesAccess.Location = new System.Drawing.Point(30, 230);
            this.btnFacilitiesAccess.Name = "btnFacilitiesAccess";
            this.btnFacilitiesAccess.Size = new System.Drawing.Size(200, 45);
            this.btnFacilitiesAccess.TabIndex = 2;
            this.btnFacilitiesAccess.Text = "▶ Truy cập";
            this.btnFacilitiesAccess.UseVisualStyleBackColor = false;
            // 
            // btnFacilitiesDetails
            // 
            this.btnFacilitiesDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnFacilitiesDetails.FlatAppearance.BorderSize = 0;
            this.btnFacilitiesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitiesDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFacilitiesDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnFacilitiesDetails.Location = new System.Drawing.Point(250, 230);
            this.btnFacilitiesDetails.Name = "btnFacilitiesDetails";
            this.btnFacilitiesDetails.Size = new System.Drawing.Size(200, 45);
            this.btnFacilitiesDetails.TabIndex = 3;
            this.btnFacilitiesDetails.Text = "ⓘ Chi tiết";
            this.btnFacilitiesDetails.UseVisualStyleBackColor = false;
            // 
            // panelRevenue
            // 
            this.panelRevenue.BackColor = System.Drawing.Color.White;
            this.panelRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRevenue.Controls.Add(this.btnRevenueDetails);
            this.panelRevenue.Controls.Add(this.btnRevenueAccess);
            this.panelRevenue.Controls.Add(this.lblRevenueDesc);
            this.panelRevenue.Controls.Add(this.lblRevenueTitle);
            this.panelRevenue.Location = new System.Drawing.Point(610, 410);
            this.panelRevenue.Name = "panelRevenue";
            this.panelRevenue.Padding = new System.Windows.Forms.Padding(30);
            this.panelRevenue.Size = new System.Drawing.Size(550, 350);
            this.panelRevenue.TabIndex = 3;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(80, 30);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(440, 40);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "📈 Doanh thu";
            // 
            // lblRevenueDesc
            // 
            this.lblRevenueDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRevenueDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRevenueDesc.Location = new System.Drawing.Point(30, 90);
            this.lblRevenueDesc.Name = "lblRevenueDesc";
            this.lblRevenueDesc.Size = new System.Drawing.Size(490, 120);
            this.lblRevenueDesc.TabIndex = 1;
            this.lblRevenueDesc.Text = "Tổng hợp doanh thu từ các đơn đặt sân và dịch vụ phụ trợ";
            // 
            // btnRevenueAccess
            // 
            this.btnRevenueAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRevenueAccess.FlatAppearance.BorderSize = 0;
            this.btnRevenueAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRevenueAccess.ForeColor = System.Drawing.Color.White;
            this.btnRevenueAccess.Location = new System.Drawing.Point(30, 230);
            this.btnRevenueAccess.Name = "btnRevenueAccess";
            this.btnRevenueAccess.Size = new System.Drawing.Size(200, 45);
            this.btnRevenueAccess.TabIndex = 2;
            this.btnRevenueAccess.Text = "▶ Truy cập";
            this.btnRevenueAccess.UseVisualStyleBackColor = false;
            // 
            // btnRevenueDetails
            // 
            this.btnRevenueDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnRevenueDetails.FlatAppearance.BorderSize = 0;
            this.btnRevenueDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRevenueDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnRevenueDetails.Location = new System.Drawing.Point(250, 230);
            this.btnRevenueDetails.Name = "btnRevenueDetails";
            this.btnRevenueDetails.Size = new System.Drawing.Size(200, 45);
            this.btnRevenueDetails.TabIndex = 3;
            this.btnRevenueDetails.Text = "ⓘ Chi tiết";
            this.btnRevenueDetails.UseVisualStyleBackColor = false;
            // 
            // FieldControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "FieldControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelFieldInfo.ResumeLayout(false);
            this.panelBooking.ResumeLayout(false);
            this.panelFacilities.ResumeLayout(false);
            this.panelRevenue.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}


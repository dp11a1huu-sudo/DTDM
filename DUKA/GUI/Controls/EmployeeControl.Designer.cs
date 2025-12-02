namespace GUI.Controls
{
    partial class EmployeeControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panelEmployeeManagement;
        private System.Windows.Forms.Label lblEmployeeManagementTitle;
        private System.Windows.Forms.Label lblEmployeeManagementDesc;
        private System.Windows.Forms.Button btnEmployeeManagementAccess;
        private System.Windows.Forms.Button btnEmployeeManagementDetails;
        private System.Windows.Forms.Panel panelShiftManagement;
        private System.Windows.Forms.Label lblShiftManagementTitle;
        private System.Windows.Forms.Label lblShiftManagementDesc;
        private System.Windows.Forms.Button btnShiftManagementAccess;
        private System.Windows.Forms.Button btnShiftManagementDetails;
        private System.Windows.Forms.Panel panelSalaryManagement;
        private System.Windows.Forms.Label lblSalaryManagementTitle;
        private System.Windows.Forms.Label lblSalaryManagementDesc;
        private System.Windows.Forms.Button btnSalaryManagementAccess;
        private System.Windows.Forms.Button btnSalaryManagementDetails;
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
            this.panelSalaryManagement = new System.Windows.Forms.Panel();
            this.btnSalaryManagementDetails = new System.Windows.Forms.Button();
            this.btnSalaryManagementAccess = new System.Windows.Forms.Button();
            this.lblSalaryManagementDesc = new System.Windows.Forms.Label();
            this.lblSalaryManagementTitle = new System.Windows.Forms.Label();
            this.panelShiftManagement = new System.Windows.Forms.Panel();
            this.btnShiftManagementDetails = new System.Windows.Forms.Button();
            this.btnShiftManagementAccess = new System.Windows.Forms.Button();
            this.lblShiftManagementDesc = new System.Windows.Forms.Label();
            this.lblShiftManagementTitle = new System.Windows.Forms.Label();
            this.panelEmployeeManagement = new System.Windows.Forms.Panel();
            this.btnEmployeeManagementDetails = new System.Windows.Forms.Button();
            this.btnEmployeeManagementAccess = new System.Windows.Forms.Button();
            this.lblEmployeeManagementDesc = new System.Windows.Forms.Label();
            this.lblEmployeeManagementTitle = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelSalaryManagement.SuspendLayout();
            this.panelShiftManagement.SuspendLayout();
            this.panelEmployeeManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.Controls.Add(this.panelSalaryManagement);
            this.mainContainer.Controls.Add(this.panelShiftManagement);
            this.mainContainer.Controls.Add(this.panelEmployeeManagement);
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
            // panelEmployeeManagement
            // 
            this.panelEmployeeManagement.BackColor = System.Drawing.Color.White;
            this.panelEmployeeManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeManagement.Controls.Add(this.btnEmployeeManagementDetails);
            this.panelEmployeeManagement.Controls.Add(this.btnEmployeeManagementAccess);
            this.panelEmployeeManagement.Controls.Add(this.lblEmployeeManagementDesc);
            this.panelEmployeeManagement.Controls.Add(this.lblEmployeeManagementTitle);
            this.panelEmployeeManagement.Location = new System.Drawing.Point(40, 40);
            this.panelEmployeeManagement.Name = "panelEmployeeManagement";
            this.panelEmployeeManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelEmployeeManagement.Size = new System.Drawing.Size(550, 350);
            this.panelEmployeeManagement.TabIndex = 0;
            // 
            // lblEmployeeManagementTitle
            // 
            this.lblEmployeeManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblEmployeeManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblEmployeeManagementTitle.Name = "lblEmployeeManagementTitle";
            this.lblEmployeeManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblEmployeeManagementTitle.TabIndex = 0;
            this.lblEmployeeManagementTitle.Text = "👥 Quản lý nhân viên";
            // 
            // lblEmployeeManagementDesc
            // 
            this.lblEmployeeManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmployeeManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmployeeManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblEmployeeManagementDesc.Name = "lblEmployeeManagementDesc";
            this.lblEmployeeManagementDesc.Size = new System.Drawing.Size(490, 120);
            this.lblEmployeeManagementDesc.TabIndex = 1;
            this.lblEmployeeManagementDesc.Text = "Quản lý thông tin nhân viên, bao gồm chức vụ, phòng ban, lương cơ bản và trạng thái hoạt động";
            // 
            // btnEmployeeManagementAccess
            // 
            this.btnEmployeeManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnEmployeeManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagementAccess.Location = new System.Drawing.Point(30, 230);
            this.btnEmployeeManagementAccess.Name = "btnEmployeeManagementAccess";
            this.btnEmployeeManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnEmployeeManagementAccess.TabIndex = 2;
            this.btnEmployeeManagementAccess.Text = "▶ Truy cập";
            this.btnEmployeeManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeManagementDetails
            // 
            this.btnEmployeeManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnEmployeeManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEmployeeManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnEmployeeManagementDetails.Location = new System.Drawing.Point(250, 230);
            this.btnEmployeeManagementDetails.Name = "btnEmployeeManagementDetails";
            this.btnEmployeeManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnEmployeeManagementDetails.TabIndex = 3;
            this.btnEmployeeManagementDetails.Text = "ⓘ Chi tiết";
            this.btnEmployeeManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelShiftManagement
            // 
            this.panelShiftManagement.BackColor = System.Drawing.Color.White;
            this.panelShiftManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShiftManagement.Controls.Add(this.btnShiftManagementDetails);
            this.panelShiftManagement.Controls.Add(this.btnShiftManagementAccess);
            this.panelShiftManagement.Controls.Add(this.lblShiftManagementDesc);
            this.panelShiftManagement.Controls.Add(this.lblShiftManagementTitle);
            this.panelShiftManagement.Location = new System.Drawing.Point(610, 40);
            this.panelShiftManagement.Name = "panelShiftManagement";
            this.panelShiftManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelShiftManagement.Size = new System.Drawing.Size(550, 350);
            this.panelShiftManagement.TabIndex = 1;
            // 
            // lblShiftManagementTitle
            // 
            this.lblShiftManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblShiftManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblShiftManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblShiftManagementTitle.Name = "lblShiftManagementTitle";
            this.lblShiftManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblShiftManagementTitle.TabIndex = 0;
            this.lblShiftManagementTitle.Text = "⏰ Quản lý ca làm";
            // 
            // lblShiftManagementDesc
            // 
            this.lblShiftManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblShiftManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblShiftManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblShiftManagementDesc.Name = "lblShiftManagementDesc";
            this.lblShiftManagementDesc.Size = new System.Drawing.Size(490, 120);
            this.lblShiftManagementDesc.TabIndex = 1;
            this.lblShiftManagementDesc.Text = "Phân ca làm việc cho nhân viên, theo dõi ca làm theo ngày và quản lý giờ vào/ra";
            // 
            // btnShiftManagementAccess
            // 
            this.btnShiftManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnShiftManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnShiftManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShiftManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnShiftManagementAccess.Location = new System.Drawing.Point(30, 230);
            this.btnShiftManagementAccess.Name = "btnShiftManagementAccess";
            this.btnShiftManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnShiftManagementAccess.TabIndex = 2;
            this.btnShiftManagementAccess.Text = "▶ Truy cập";
            this.btnShiftManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnShiftManagementDetails
            // 
            this.btnShiftManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnShiftManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnShiftManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShiftManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnShiftManagementDetails.Location = new System.Drawing.Point(250, 230);
            this.btnShiftManagementDetails.Name = "btnShiftManagementDetails";
            this.btnShiftManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnShiftManagementDetails.TabIndex = 3;
            this.btnShiftManagementDetails.Text = "ⓘ Chi tiết";
            this.btnShiftManagementDetails.UseVisualStyleBackColor = false;
            // 
            // panelSalaryManagement
            // 
            this.panelSalaryManagement.BackColor = System.Drawing.Color.White;
            this.panelSalaryManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSalaryManagement.Controls.Add(this.btnSalaryManagementDetails);
            this.panelSalaryManagement.Controls.Add(this.btnSalaryManagementAccess);
            this.panelSalaryManagement.Controls.Add(this.lblSalaryManagementDesc);
            this.panelSalaryManagement.Controls.Add(this.lblSalaryManagementTitle);
            this.panelSalaryManagement.Location = new System.Drawing.Point(325, 410);
            this.panelSalaryManagement.Name = "panelSalaryManagement";
            this.panelSalaryManagement.Padding = new System.Windows.Forms.Padding(30);
            this.panelSalaryManagement.Size = new System.Drawing.Size(550, 350);
            this.panelSalaryManagement.TabIndex = 2;
            // 
            // lblSalaryManagementTitle
            // 
            this.lblSalaryManagementTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSalaryManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblSalaryManagementTitle.Location = new System.Drawing.Point(80, 30);
            this.lblSalaryManagementTitle.Name = "lblSalaryManagementTitle";
            this.lblSalaryManagementTitle.Size = new System.Drawing.Size(440, 40);
            this.lblSalaryManagementTitle.TabIndex = 0;
            this.lblSalaryManagementTitle.Text = "💰 Tính lương";
            // 
            // lblSalaryManagementDesc
            // 
            this.lblSalaryManagementDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSalaryManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSalaryManagementDesc.Location = new System.Drawing.Point(30, 90);
            this.lblSalaryManagementDesc.Name = "lblSalaryManagementDesc";
            this.lblSalaryManagementDesc.Size = new System.Drawing.Size(490, 120);
            this.lblSalaryManagementDesc.TabIndex = 1;
            this.lblSalaryManagementDesc.Text = "Tính lương theo ca làm việc, báo cáo lương theo tháng/năm và xuất bảng lương";
            // 
            // btnSalaryManagementAccess
            // 
            this.btnSalaryManagementAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSalaryManagementAccess.FlatAppearance.BorderSize = 0;
            this.btnSalaryManagementAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryManagementAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalaryManagementAccess.ForeColor = System.Drawing.Color.White;
            this.btnSalaryManagementAccess.Location = new System.Drawing.Point(30, 230);
            this.btnSalaryManagementAccess.Name = "btnSalaryManagementAccess";
            this.btnSalaryManagementAccess.Size = new System.Drawing.Size(200, 45);
            this.btnSalaryManagementAccess.TabIndex = 2;
            this.btnSalaryManagementAccess.Text = "▶ Truy cập";
            this.btnSalaryManagementAccess.UseVisualStyleBackColor = false;
            // 
            // btnSalaryManagementDetails
            // 
            this.btnSalaryManagementDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnSalaryManagementDetails.FlatAppearance.BorderSize = 0;
            this.btnSalaryManagementDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryManagementDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalaryManagementDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSalaryManagementDetails.Location = new System.Drawing.Point(250, 230);
            this.btnSalaryManagementDetails.Name = "btnSalaryManagementDetails";
            this.btnSalaryManagementDetails.Size = new System.Drawing.Size(200, 45);
            this.btnSalaryManagementDetails.TabIndex = 3;
            this.btnSalaryManagementDetails.Text = "ⓘ Chi tiết";
            this.btnSalaryManagementDetails.UseVisualStyleBackColor = false;
            // 
            // EmployeeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelEmployeeManagement.ResumeLayout(false);
            this.panelShiftManagement.ResumeLayout(false);
            this.panelSalaryManagement.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}


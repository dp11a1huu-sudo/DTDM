namespace GUI.Controls
{
    partial class ShiftManagementControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblBranches;
        private System.Windows.Forms.Button btnSearchBranch;
        private System.Windows.Forms.Button btnEditBranch;
        private System.Windows.Forms.Button btnDeleteBranch;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.Button btnBranch1;
        private System.Windows.Forms.Button btnBranch2;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Panel panelInfoCards;
        private System.Windows.Forms.Label lblTotalShifts;
        private System.Windows.Forms.Label lblScheduledShifts;
        private System.Windows.Forms.Label lblCompletedShifts;
        private System.Windows.Forms.Label lblAbsentShifts;
        private System.Windows.Forms.Panel panelSearchFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.Panel panelTableActions;
        private System.Windows.Forms.Button btnEditShift;
        private System.Windows.Forms.Button btnDeleteShift;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Label lblPaginationInfo;
        private System.Windows.Forms.Button btnPageFirst;
        private System.Windows.Forms.Button btnPagePrev;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnPage4;
        private System.Windows.Forms.Button btnPageNext;
        private System.Windows.Forms.Button btnPageLast;
        private GUI.Controls.HeaderControl headerControl;

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
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.btnPageLast = new System.Windows.Forms.Button();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPage4 = new System.Windows.Forms.Button();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPagePrev = new System.Windows.Forms.Button();
            this.btnPageFirst = new System.Windows.Forms.Button();
            this.lblPaginationInfo = new System.Windows.Forms.Label();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.panelTableActions = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.btnEditShift = new System.Windows.Forms.Button();
            this.panelSearchFilter = new System.Windows.Forms.Panel();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelInfoCards = new System.Windows.Forms.Panel();
            this.lblAbsentShifts = new System.Windows.Forms.Label();
            this.lblCompletedShifts = new System.Windows.Forms.Label();
            this.lblScheduledShifts = new System.Windows.Forms.Label();
            this.lblTotalShifts = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBranch2 = new System.Windows.Forms.Button();
            this.btnBranch1 = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.btnEditBranch = new System.Windows.Forms.Button();
            this.btnSearchBranch = new System.Windows.Forms.Button();
            this.lblBranches = new System.Windows.Forms.Label();
            this.headerControl = new GUI.Controls.HeaderControl();
            this.mainContainer.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.panelTableActions.SuspendLayout();
            this.panelSearchFilter.SuspendLayout();
            this.panelInfoCards.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainContainer.Controls.Add(this.panelRight);
            this.mainContainer.Controls.Add(this.panelLeft);
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1200, 730);
            this.mainContainer.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panelPagination);
            this.panelRight.Controls.Add(this.dgvShifts);
            this.panelRight.Controls.Add(this.panelTableActions);
            this.panelRight.Controls.Add(this.panelSearchFilter);
            this.panelRight.Controls.Add(this.panelInfoCards);
            this.panelRight.Controls.Add(this.lblShifts);
            this.panelRight.Location = new System.Drawing.Point(250, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(30);
            this.panelRight.Size = new System.Drawing.Size(950, 730);
            this.panelRight.TabIndex = 1;
            // 
            // panelPagination
            // 
            this.panelPagination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPagination.Controls.Add(this.btnPageLast);
            this.panelPagination.Controls.Add(this.btnPageNext);
            this.panelPagination.Controls.Add(this.btnPage4);
            this.panelPagination.Controls.Add(this.btnPage3);
            this.panelPagination.Controls.Add(this.btnPage2);
            this.panelPagination.Controls.Add(this.btnPage1);
            this.panelPagination.Controls.Add(this.btnPagePrev);
            this.panelPagination.Controls.Add(this.btnPageFirst);
            this.panelPagination.Controls.Add(this.lblPaginationInfo);
            this.panelPagination.Location = new System.Drawing.Point(30, 630);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(890, 50);
            this.panelPagination.TabIndex = 5;
            // 
            // btnPageLast
            // 
            this.btnPageLast.BackColor = System.Drawing.Color.White;
            this.btnPageLast.FlatAppearance.BorderSize = 0;
            this.btnPageLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageLast.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageLast.Location = new System.Drawing.Point(790, 10);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(30, 30);
            this.btnPageLast.TabIndex = 8;
            this.btnPageLast.Text = "▶";
            this.btnPageLast.UseVisualStyleBackColor = false;
            // 
            // btnPageNext
            // 
            this.btnPageNext.BackColor = System.Drawing.Color.White;
            this.btnPageNext.FlatAppearance.BorderSize = 0;
            this.btnPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageNext.Location = new System.Drawing.Point(750, 10);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(30, 30);
            this.btnPageNext.TabIndex = 7;
            this.btnPageNext.Text = "▶";
            this.btnPageNext.UseVisualStyleBackColor = false;
            // 
            // btnPage4
            // 
            this.btnPage4.BackColor = System.Drawing.Color.White;
            this.btnPage4.FlatAppearance.BorderSize = 0;
            this.btnPage4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage4.Location = new System.Drawing.Point(700, 10);
            this.btnPage4.Name = "btnPage4";
            this.btnPage4.Size = new System.Drawing.Size(30, 30);
            this.btnPage4.TabIndex = 6;
            this.btnPage4.Text = "4";
            this.btnPage4.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            this.btnPage3.BackColor = System.Drawing.Color.White;
            this.btnPage3.FlatAppearance.BorderSize = 0;
            this.btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage3.Location = new System.Drawing.Point(660, 10);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(30, 30);
            this.btnPage3.TabIndex = 5;
            this.btnPage3.Text = "3";
            this.btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            this.btnPage2.BackColor = System.Drawing.Color.White;
            this.btnPage2.FlatAppearance.BorderSize = 0;
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage2.Location = new System.Drawing.Point(620, 10);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(30, 30);
            this.btnPage2.TabIndex = 4;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            this.btnPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnPage1.FlatAppearance.BorderSize = 0;
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPage1.ForeColor = System.Drawing.Color.White;
            this.btnPage1.Location = new System.Drawing.Point(580, 10);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(30, 30);
            this.btnPage1.TabIndex = 3;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPagePrev
            // 
            this.btnPagePrev.BackColor = System.Drawing.Color.White;
            this.btnPagePrev.FlatAppearance.BorderSize = 0;
            this.btnPagePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagePrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagePrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPagePrev.Location = new System.Drawing.Point(540, 10);
            this.btnPagePrev.Name = "btnPagePrev";
            this.btnPagePrev.Size = new System.Drawing.Size(30, 30);
            this.btnPagePrev.TabIndex = 2;
            this.btnPagePrev.Text = "◀";
            this.btnPagePrev.UseVisualStyleBackColor = false;
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.BackColor = System.Drawing.Color.White;
            this.btnPageFirst.FlatAppearance.BorderSize = 0;
            this.btnPageFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageFirst.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageFirst.Location = new System.Drawing.Point(500, 10);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(30, 30);
            this.btnPageFirst.TabIndex = 1;
            this.btnPageFirst.Text = "◀";
            this.btnPageFirst.UseVisualStyleBackColor = false;
            // 
            // lblPaginationInfo
            // 
            this.lblPaginationInfo.AutoSize = true;
            this.lblPaginationInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaginationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPaginationInfo.Location = new System.Drawing.Point(0, 15);
            this.lblPaginationInfo.Name = "lblPaginationInfo";
            this.lblPaginationInfo.Size = new System.Drawing.Size(360, 23);
            this.lblPaginationInfo.TabIndex = 0;
            this.lblPaginationInfo.Text = "Hiển thị 1 đến 5 dữ liệu trong tổng số 5 mục";
            // 
            // dgvShifts
            // 
            this.dgvShifts.AllowUserToAddRows = false;
            this.dgvShifts.AllowUserToDeleteRows = false;
            this.dgvShifts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvShifts.BackgroundColor = System.Drawing.Color.White;
            this.dgvShifts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvShifts.Location = new System.Drawing.Point(30, 320);
            this.dgvShifts.MultiSelect = false;
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShifts.RowHeadersVisible = false;
            this.dgvShifts.RowHeadersWidth = 51;
            this.dgvShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShifts.Size = new System.Drawing.Size(890, 300);
            this.dgvShifts.TabIndex = 4;
            // 
            // panelTableActions
            // 
            this.panelTableActions.Controls.Add(this.btnCheckOut);
            this.panelTableActions.Controls.Add(this.btnCheckIn);
            this.panelTableActions.Controls.Add(this.btnAddShift);
            this.panelTableActions.Controls.Add(this.btnDeleteShift);
            this.panelTableActions.Controls.Add(this.btnEditShift);
            this.panelTableActions.Location = new System.Drawing.Point(30, 270);
            this.panelTableActions.Name = "panelTableActions";
            this.panelTableActions.Size = new System.Drawing.Size(890, 40);
            this.panelTableActions.TabIndex = 3;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.Transparent;
            this.btnAddShift.FlatAppearance.BorderSize = 0;
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnAddShift.Location = new System.Drawing.Point(834, -3);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(40, 40);
            this.btnAddShift.TabIndex = 2;
            this.btnAddShift.Text = "➕";
            this.btnAddShift.UseVisualStyleBackColor = false;
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteShift.FlatAppearance.BorderSize = 0;
            this.btnDeleteShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShift.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDeleteShift.Location = new System.Drawing.Point(780, -4);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteShift.TabIndex = 1;
            this.btnDeleteShift.Text = "🗑️";
            this.btnDeleteShift.UseVisualStyleBackColor = false;
            // 
            // btnEditShift
            // 
            this.btnEditShift.BackColor = System.Drawing.Color.Transparent;
            this.btnEditShift.FlatAppearance.BorderSize = 0;
            this.btnEditShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShift.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEditShift.Location = new System.Drawing.Point(600, 0);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(40, 40);
            this.btnEditShift.TabIndex = 0;
            this.btnEditShift.Text = "✏️";
            this.btnEditShift.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(650, 0);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(80, 40);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "✅ Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(740, 0);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(80, 40);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "⏹️ Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // panelSearchFilter
            // 
            this.panelSearchFilter.Controls.Add(this.cmbStatusFilter);
            this.panelSearchFilter.Controls.Add(this.lblStatusFilter);
            this.panelSearchFilter.Controls.Add(this.btnFilter);
            this.panelSearchFilter.Controls.Add(this.cmbEmployee);
            this.panelSearchFilter.Controls.Add(this.lblEmployee);
            this.panelSearchFilter.Controls.Add(this.dtpFilterDate);
            this.panelSearchFilter.Controls.Add(this.lblFilterDate);
            this.panelSearchFilter.Controls.Add(this.cmbFilter);
            this.panelSearchFilter.Controls.Add(this.txtSearch);
            this.panelSearchFilter.Location = new System.Drawing.Point(30, 160);
            this.panelSearchFilter.Name = "panelSearchFilter";
            this.panelSearchFilter.Size = new System.Drawing.Size(890, 100);
            this.panelSearchFilter.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(740, 60);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "🔍 Lọc";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(540, 63);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(90, 23);
            this.lblStatusFilter.TabIndex = 7;
            this.lblStatusFilter.Text = "Trạng thái:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Đã lên lịch",
            "Hoàn thành",
            "Vắng mặt"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(640, 60);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(80, 31);
            this.cmbStatusFilter.TabIndex = 8;
            this.cmbStatusFilter.Text = "Tất cả";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(470, 60);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(250, 31);
            this.cmbEmployee.TabIndex = 5;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmployee.Location = new System.Drawing.Point(380, 63);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(90, 23);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Nhân viên:";
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFilterDate.Location = new System.Drawing.Point(110, 60);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(250, 30);
            this.dtpFilterDate.TabIndex = 3;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblFilterDate.Location = new System.Drawing.Point(0, 63);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(80, 23);
            this.lblFilterDate.TabIndex = 2;
            this.lblFilterDate.Text = "Ngày làm:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã ca",
            "Nhân viên",
            "Ngày",
            "Trạng thái"});
            this.cmbFilter.Location = new System.Drawing.Point(320, 10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "Lọc theo: Trạng thái";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(0, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "🔍 Tìm kiếm";
            // 
            // panelInfoCards
            // 
            this.panelInfoCards.Controls.Add(this.lblAbsentShifts);
            this.panelInfoCards.Controls.Add(this.lblCompletedShifts);
            this.panelInfoCards.Controls.Add(this.lblScheduledShifts);
            this.panelInfoCards.Controls.Add(this.lblTotalShifts);
            this.panelInfoCards.Location = new System.Drawing.Point(30, 53);
            this.panelInfoCards.Name = "panelInfoCards";
            this.panelInfoCards.Size = new System.Drawing.Size(890, 97);
            this.panelInfoCards.TabIndex = 1;
            // 
            // lblTotalShifts
            // 
            this.lblTotalShifts.AutoSize = true;
            this.lblTotalShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalShifts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalShifts.Location = new System.Drawing.Point(0, -3);
            this.lblTotalShifts.Name = "lblTotalShifts";
            this.lblTotalShifts.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalShifts.Size = new System.Drawing.Size(200, 102);
            this.lblTotalShifts.TabIndex = 0;
            this.lblTotalShifts.Text = "⏰\r\nTổng ca:\r\n5 ca làm\r\n";
            // 
            // lblScheduledShifts
            // 
            this.lblScheduledShifts.AutoSize = true;
            this.lblScheduledShifts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblScheduledShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblScheduledShifts.Location = new System.Drawing.Point(220, -3);
            this.lblScheduledShifts.Name = "lblScheduledShifts";
            this.lblScheduledShifts.Padding = new System.Windows.Forms.Padding(5);
            this.lblScheduledShifts.Size = new System.Drawing.Size(200, 102);
            this.lblScheduledShifts.TabIndex = 1;
            this.lblScheduledShifts.Text = "📅\r\nĐã lên lịch:\r\n3 ca\r\n";
            // 
            // lblCompletedShifts
            // 
            this.lblCompletedShifts.AutoSize = true;
            this.lblCompletedShifts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompletedShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCompletedShifts.Location = new System.Drawing.Point(440, -3);
            this.lblCompletedShifts.Name = "lblCompletedShifts";
            this.lblCompletedShifts.Padding = new System.Windows.Forms.Padding(5);
            this.lblCompletedShifts.Size = new System.Drawing.Size(200, 102);
            this.lblCompletedShifts.TabIndex = 2;
            this.lblCompletedShifts.Text = "✅\r\nHoàn thành:\r\n2 ca\r\n";
            // 
            // lblAbsentShifts
            // 
            this.lblAbsentShifts.AutoSize = true;
            this.lblAbsentShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAbsentShifts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbsentShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblAbsentShifts.Location = new System.Drawing.Point(660, -3);
            this.lblAbsentShifts.Name = "lblAbsentShifts";
            this.lblAbsentShifts.Padding = new System.Windows.Forms.Padding(5);
            this.lblAbsentShifts.Size = new System.Drawing.Size(230, 102);
            this.lblAbsentShifts.TabIndex = 3;
            this.lblAbsentShifts.Text = "❌\r\nVắng mặt:\r\n0 ca\r\n";
            // 
            // lblShifts
            // 
            this.lblShifts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblShifts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblShifts.Location = new System.Drawing.Point(24, 20);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(200, 30);
            this.lblShifts.TabIndex = 0;
            this.lblShifts.Text = "Ca làm việc";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnBranch2);
            this.panelLeft.Controls.Add(this.btnBranch1);
            this.panelLeft.Controls.Add(this.btnAddBranch);
            this.panelLeft.Controls.Add(this.btnDeleteBranch);
            this.panelLeft.Controls.Add(this.btnEditBranch);
            this.panelLeft.Controls.Add(this.btnSearchBranch);
            this.panelLeft.Controls.Add(this.lblBranches);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelLeft.Size = new System.Drawing.Size(250, 730);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBranch2
            // 
            this.btnBranch2.BackColor = System.Drawing.Color.White;
            this.btnBranch2.FlatAppearance.BorderSize = 0;
            this.btnBranch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBranch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnBranch2.Location = new System.Drawing.Point(20, 180);
            this.btnBranch2.Name = "btnBranch2";
            this.btnBranch2.Size = new System.Drawing.Size(210, 50);
            this.btnBranch2.TabIndex = 6;
            this.btnBranch2.Text = "CHINHANH2";
            this.btnBranch2.UseVisualStyleBackColor = false;
            // 
            // btnBranch1
            // 
            this.btnBranch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnBranch1.FlatAppearance.BorderSize = 0;
            this.btnBranch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBranch1.ForeColor = System.Drawing.Color.White;
            this.btnBranch1.Location = new System.Drawing.Point(20, 120);
            this.btnBranch1.Name = "btnBranch1";
            this.btnBranch1.Size = new System.Drawing.Size(210, 50);
            this.btnBranch1.TabIndex = 5;
            this.btnBranch1.Text = "CHINHANH1";
            this.btnBranch1.UseVisualStyleBackColor = false;
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBranch.FlatAppearance.BorderSize = 0;
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnAddBranch.Location = new System.Drawing.Point(170, 60);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(40, 40);
            this.btnAddBranch.TabIndex = 4;
            this.btnAddBranch.Text = "➕";
            this.btnAddBranch.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBranch.FlatAppearance.BorderSize = 0;
            this.btnDeleteBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBranch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDeleteBranch.Location = new System.Drawing.Point(120, 60);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteBranch.TabIndex = 3;
            this.btnDeleteBranch.Text = "🗑️";
            this.btnDeleteBranch.UseVisualStyleBackColor = false;
            // 
            // btnEditBranch
            // 
            this.btnEditBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnEditBranch.FlatAppearance.BorderSize = 0;
            this.btnEditBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBranch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEditBranch.Location = new System.Drawing.Point(70, 60);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(40, 40);
            this.btnEditBranch.TabIndex = 2;
            this.btnEditBranch.Text = "✏️";
            this.btnEditBranch.UseVisualStyleBackColor = false;
            // 
            // btnSearchBranch
            // 
            this.btnSearchBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBranch.FlatAppearance.BorderSize = 0;
            this.btnSearchBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBranch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSearchBranch.Location = new System.Drawing.Point(20, 60);
            this.btnSearchBranch.Name = "btnSearchBranch";
            this.btnSearchBranch.Size = new System.Drawing.Size(40, 40);
            this.btnSearchBranch.TabIndex = 1;
            this.btnSearchBranch.Text = "🔍";
            this.btnSearchBranch.UseVisualStyleBackColor = false;
            // 
            // lblBranches
            // 
            this.lblBranches.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBranches.Location = new System.Drawing.Point(20, 20);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(210, 30);
            this.lblBranches.TabIndex = 0;
            this.lblBranches.Text = "Chi nhánh";
            // 
            // headerControl
            // 
            this.headerControl.BackColor = System.Drawing.Color.White;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 70);
            this.headerControl.TabIndex = 0;
            // 
            // ShiftManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "ShiftManagementControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.panelTableActions.ResumeLayout(false);
            this.panelSearchFilter.ResumeLayout(false);
            this.panelSearchFilter.PerformLayout();
            this.panelInfoCards.ResumeLayout(false);
            this.panelInfoCards.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

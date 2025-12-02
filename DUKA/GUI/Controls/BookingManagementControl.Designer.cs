namespace GUI.Controls
{
    partial class BookingManagementControl
    {
        private System.ComponentModel.IContainer components = null;
        private HeaderControl headerControl;
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
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Panel panelInfoCards;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Label lblTodayBookings;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panelSearchFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Panel panelTableActions;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DataGridView dgvBookings;
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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.panelTableActions = new System.Windows.Forms.Panel();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.panelSearchFilter = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelInfoCards = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblTodayBookings = new System.Windows.Forms.Label();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.lblBookings = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBranch2 = new System.Windows.Forms.Button();
            this.btnBranch1 = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.btnEditBranch = new System.Windows.Forms.Button();
            this.btnSearchBranch = new System.Windows.Forms.Button();
            this.lblBranches = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.panelTableActions.SuspendLayout();
            this.panelSearchFilter.SuspendLayout();
            this.panelInfoCards.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerControl
            // 
            this.headerControl.BackColor = System.Drawing.Color.White;
            this.headerControl.Location = new System.Drawing.Point(0, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1200, 70);
            this.headerControl.TabIndex = 0;
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
            this.panelRight.Controls.Add(this.dgvBookings);
            this.panelRight.Controls.Add(this.panelTableActions);
            this.panelRight.Controls.Add(this.panelSearchFilter);
            this.panelRight.Controls.Add(this.panelInfoCards);
            this.panelRight.Controls.Add(this.lblBookings);
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
            this.btnPage4.Location = new System.Drawing.Point(660, 10);
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
            this.btnPage3.Location = new System.Drawing.Point(620, 10);
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
            this.btnPage2.Location = new System.Drawing.Point(580, 10);
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
            this.btnPage1.Location = new System.Drawing.Point(540, 10);
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
            this.btnPagePrev.Location = new System.Drawing.Point(500, 10);
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
            this.btnPageFirst.Location = new System.Drawing.Point(460, 10);
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
            this.lblPaginationInfo.Text = "Hiển thị 1 đến 6 dữ liệu trong tổng số 10 mục";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvBookings.Location = new System.Drawing.Point(30, 270);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(890, 350);
            this.dgvBookings.TabIndex = 4;
            // 
            // panelTableActions
            // 
            this.panelTableActions.Controls.Add(this.btnAddBooking);
            this.panelTableActions.Controls.Add(this.btnDeleteBooking);
            this.panelTableActions.Controls.Add(this.btnEditBooking);
            this.panelTableActions.Location = new System.Drawing.Point(30, 220);
            this.panelTableActions.Name = "panelTableActions";
            this.panelTableActions.Size = new System.Drawing.Size(890, 40);
            this.panelTableActions.TabIndex = 3;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBooking.FlatAppearance.BorderSize = 0;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnAddBooking.Location = new System.Drawing.Point(834, -3);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(40, 40);
            this.btnAddBooking.TabIndex = 2;
            this.btnAddBooking.Text = "➕";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBooking.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDeleteBooking.Location = new System.Drawing.Point(780, -4);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteBooking.TabIndex = 1;
            this.btnDeleteBooking.Text = "🗑️";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnEditBooking.FlatAppearance.BorderSize = 0;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEditBooking.Location = new System.Drawing.Point(724, 0);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(40, 40);
            this.btnEditBooking.TabIndex = 0;
            this.btnEditBooking.Text = "✏️";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            // 
            // panelSearchFilter
            // 
            this.panelSearchFilter.Controls.Add(this.cmbFilter);
            this.panelSearchFilter.Controls.Add(this.txtSearch);
            this.panelSearchFilter.Location = new System.Drawing.Point(30, 160);
            this.panelSearchFilter.Name = "panelSearchFilter";
            this.panelSearchFilter.Size = new System.Drawing.Size(890, 50);
            this.panelSearchFilter.TabIndex = 2;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã đặt",
            "Tên sân",
            "Khách hàng",
            "Trạng thái"});
            this.cmbFilter.Location = new System.Drawing.Point(320, 10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "Lọc theo: Mã đặt";
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
            this.panelInfoCards.Controls.Add(this.lblRevenue);
            this.panelInfoCards.Controls.Add(this.lblTodayBookings);
            this.panelInfoCards.Controls.Add(this.lblTotalBookings);
            this.panelInfoCards.Location = new System.Drawing.Point(30, 53);
            this.panelInfoCards.Name = "panelInfoCards";
            this.panelInfoCards.Size = new System.Drawing.Size(890, 97);
            this.panelInfoCards.TabIndex = 1;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblRevenue.Location = new System.Drawing.Point(574, -3);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Padding = new System.Windows.Forms.Padding(5);
            this.lblRevenue.Size = new System.Drawing.Size(316, 102);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "💰\r\nDoanh thu hôm nay:\r\n2.100.000 đ\r\n";
            // 
            // lblTodayBookings
            // 
            this.lblTodayBookings.AutoSize = true;
            this.lblTodayBookings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTodayBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTodayBookings.Location = new System.Drawing.Point(287, 18);
            this.lblTodayBookings.Name = "lblTodayBookings";
            this.lblTodayBookings.Padding = new System.Windows.Forms.Padding(10);
            this.lblTodayBookings.Size = new System.Drawing.Size(101, 43);
            this.lblTodayBookings.TabIndex = 1;
            this.lblTodayBookings.Text = "📅 7 hôm nay";
            // 
            // lblTotalBookings
            // 
            this.lblTotalBookings.AutoSize = true;
            this.lblTotalBookings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBookings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalBookings.Location = new System.Drawing.Point(0, -3);
            this.lblTotalBookings.Name = "lblTotalBookings";
            this.lblTotalBookings.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalBookings.Size = new System.Drawing.Size(239, 102);
            this.lblTotalBookings.TabIndex = 0;
            this.lblTotalBookings.Text = "📋\r\nTổng đặt sân:\r\n156 lượt\r\n";
            // 
            // lblBookings
            // 
            this.lblBookings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBookings.Location = new System.Drawing.Point(24, 20);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(200, 30);
            this.lblBookings.TabIndex = 0;
            this.lblBookings.Text = "Đặt sân & Thanh toán";
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
            this.btnAddBranch.Location = new System.Drawing.Point(180, 70);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(30, 30);
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
            this.btnDeleteBranch.Location = new System.Drawing.Point(140, 70);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(30, 30);
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
            this.btnEditBranch.Location = new System.Drawing.Point(100, 70);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(30, 30);
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
            this.btnSearchBranch.Location = new System.Drawing.Point(60, 70);
            this.btnSearchBranch.Name = "btnSearchBranch";
            this.btnSearchBranch.Size = new System.Drawing.Size(30, 30);
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
            this.lblBranches.Size = new System.Drawing.Size(200, 30);
            this.lblBranches.TabIndex = 0;
            this.lblBranches.Text = "Chi nhánh";
            // 
            // BookingManagementControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "BookingManagementControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
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

namespace GUI.Controls
{
    partial class FoodMenuManagementControl
    {
        private System.ComponentModel.IContainer components = null;
        private GUI.Controls.HeaderControl headerControl;
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
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panelInfoCards;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblBestSeller;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel panelSearchFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.Panel panelTableActions;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvMenuItems;
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
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.panelTableActions = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.panelSearchFilter = new System.Windows.Forms.Panel();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelInfoCards = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblBestSeller = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
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
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 70);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1200, 730);
            this.mainContainer.TabIndex = 1;
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
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(200, 730);
            this.panelLeft.TabIndex = 0;
            // 
            // lblBranches
            // 
            this.lblBranches.AutoSize = true;
            this.lblBranches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBranches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBranches.Location = new System.Drawing.Point(10, 10);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(80, 21);
            this.lblBranches.TabIndex = 0;
            this.lblBranches.Text = "Chi nhánh";
            // 
            // btnSearchBranch
            // 
            this.btnSearchBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBranch.FlatAppearance.BorderSize = 0;
            this.btnSearchBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSearchBranch.Location = new System.Drawing.Point(10, 50);
            this.btnSearchBranch.Name = "btnSearchBranch";
            this.btnSearchBranch.Size = new System.Drawing.Size(180, 35);
            this.btnSearchBranch.TabIndex = 1;
            this.btnSearchBranch.Text = "🔍 Tìm kiếm";
            this.btnSearchBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBranch.UseVisualStyleBackColor = false;
            // 
            // btnEditBranch
            // 
            this.btnEditBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnEditBranch.FlatAppearance.BorderSize = 0;
            this.btnEditBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEditBranch.Location = new System.Drawing.Point(10, 90);
            this.btnEditBranch.Name = "btnEditBranch";
            this.btnEditBranch.Size = new System.Drawing.Size(180, 35);
            this.btnEditBranch.TabIndex = 2;
            this.btnEditBranch.Text = "✏️ Chỉnh sửa";
            this.btnEditBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBranch.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteBranch.FlatAppearance.BorderSize = 0;
            this.btnDeleteBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDeleteBranch.Location = new System.Drawing.Point(10, 130);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(180, 35);
            this.btnDeleteBranch.TabIndex = 3;
            this.btnDeleteBranch.Text = "🗑️ Xóa";
            this.btnDeleteBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBranch.UseVisualStyleBackColor = false;
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddBranch.FlatAppearance.BorderSize = 0;
            this.btnAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBranch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBranch.ForeColor = System.Drawing.Color.White;
            this.btnAddBranch.Location = new System.Drawing.Point(10, 170);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(180, 40);
            this.btnAddBranch.TabIndex = 4;
            this.btnAddBranch.Text = "+ Thêm chi nhánh";
            this.btnAddBranch.UseVisualStyleBackColor = false;
            // 
            // btnBranch1
            // 
            this.btnBranch1.BackColor = System.Drawing.Color.Transparent;
            this.btnBranch1.FlatAppearance.BorderSize = 0;
            this.btnBranch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBranch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnBranch1.Location = new System.Drawing.Point(10, 230);
            this.btnBranch1.Name = "btnBranch1";
            this.btnBranch1.Size = new System.Drawing.Size(180, 40);
            this.btnBranch1.TabIndex = 5;
            this.btnBranch1.Text = "📍 Chi nhánh 1";
            this.btnBranch1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBranch1.UseVisualStyleBackColor = false;
            // 
            // btnBranch2
            // 
            this.btnBranch2.BackColor = System.Drawing.Color.Transparent;
            this.btnBranch2.FlatAppearance.BorderSize = 0;
            this.btnBranch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranch2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBranch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnBranch2.Location = new System.Drawing.Point(10, 280);
            this.btnBranch2.Name = "btnBranch2";
            this.btnBranch2.Size = new System.Drawing.Size(180, 40);
            this.btnBranch2.TabIndex = 6;
            this.btnBranch2.Text = "📍 Chi nhánh 2";
            this.btnBranch2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBranch2.UseVisualStyleBackColor = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.panelPagination);
            this.panelRight.Controls.Add(this.dgvMenuItems);
            this.panelRight.Controls.Add(this.panelTableActions);
            this.panelRight.Controls.Add(this.panelSearchFilter);
            this.panelRight.Controls.Add(this.panelInfoCards);
            this.panelRight.Controls.Add(this.lblMenu);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(200, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(30);
            this.panelRight.Size = new System.Drawing.Size(1000, 730);
            this.panelRight.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMenu.Location = new System.Drawing.Point(30, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(250, 32);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "📋 Quản lý Menu/Món ăn";
            // 
            // panelInfoCards
            // 
            this.panelInfoCards.Controls.Add(this.lblLowStock);
            this.panelInfoCards.Controls.Add(this.lblBestSeller);
            this.panelInfoCards.Controls.Add(this.lblTotalRevenue);
            this.panelInfoCards.Controls.Add(this.lblTotalItems);
            this.panelInfoCards.Location = new System.Drawing.Point(30, 53);
            this.panelInfoCards.Name = "panelInfoCards";
            this.panelInfoCards.Size = new System.Drawing.Size(940, 97);
            this.panelInfoCards.TabIndex = 1;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalItems.Location = new System.Drawing.Point(0, -3);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalItems.Size = new System.Drawing.Size(200, 102);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "📋\r\nTổng món:\r\n15 món\r\n";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(220, -3);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalRevenue.Size = new System.Drawing.Size(200, 102);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "💰\r\nDoanh thu hôm nay:\r\n2.500.000 đ\r\n";
            // 
            // lblBestSeller
            // 
            this.lblBestSeller.AutoSize = true;
            this.lblBestSeller.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBestSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblBestSeller.Location = new System.Drawing.Point(440, -3);
            this.lblBestSeller.Name = "lblBestSeller";
            this.lblBestSeller.Padding = new System.Windows.Forms.Padding(5);
            this.lblBestSeller.Size = new System.Drawing.Size(200, 102);
            this.lblBestSeller.TabIndex = 2;
            this.lblBestSeller.Text = "🏆\r\nMón bán chạy:\r\nCoca Cola\r\n";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblLowStock.Location = new System.Drawing.Point(660, -3);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Padding = new System.Windows.Forms.Padding(5);
            this.lblLowStock.Size = new System.Drawing.Size(280, 102);
            this.lblLowStock.TabIndex = 3;
            this.lblLowStock.Text = "⚠️\r\nTồn kho cảnh báo:\r\n3 món\r\n";
            // 
            // panelSearchFilter
            // 
            this.panelSearchFilter.Controls.Add(this.cmbStatusFilter);
            this.panelSearchFilter.Controls.Add(this.lblStatusFilter);
            this.panelSearchFilter.Controls.Add(this.cmbCategoryFilter);
            this.panelSearchFilter.Controls.Add(this.lblCategoryFilter);
            this.panelSearchFilter.Controls.Add(this.cmbFilter);
            this.panelSearchFilter.Controls.Add(this.txtSearch);
            this.panelSearchFilter.Location = new System.Drawing.Point(30, 160);
            this.panelSearchFilter.Name = "panelSearchFilter";
            this.panelSearchFilter.Size = new System.Drawing.Size(940, 100);
            this.panelSearchFilter.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(0, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "🔍 Tìm kiếm (mã món, tên món)";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã món",
            "Tên món",
            "Danh mục",
            "Giá"});
            this.cmbFilter.Location = new System.Drawing.Point(320, 10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "Tên món";
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCategoryFilter.Location = new System.Drawing.Point(0, 50);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(90, 23);
            this.lblCategoryFilter.TabIndex = 2;
            this.lblCategoryFilter.Text = "Danh mục:";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Đồ ăn",
            "Nước uống",
            "Combo"});
            this.cmbCategoryFilter.Location = new System.Drawing.Point(100, 47);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbCategoryFilter.TabIndex = 3;
            this.cmbCategoryFilter.Text = "Tất cả";
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(320, 50);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(90, 23);
            this.lblStatusFilter.TabIndex = 4;
            this.lblStatusFilter.Text = "Trạng thái:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Còn hàng",
            "Hết hàng"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(420, 47);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbStatusFilter.TabIndex = 5;
            this.cmbStatusFilter.Text = "Tất cả";
            // 
            // panelTableActions
            // 
            this.panelTableActions.Controls.Add(this.btnAddItem);
            this.panelTableActions.Controls.Add(this.btnDeleteItem);
            this.panelTableActions.Controls.Add(this.btnEditItem);
            this.panelTableActions.Location = new System.Drawing.Point(30, 270);
            this.panelTableActions.Name = "panelTableActions";
            this.panelTableActions.Size = new System.Drawing.Size(940, 40);
            this.panelTableActions.TabIndex = 3;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.Transparent;
            this.btnEditItem.FlatAppearance.BorderSize = 0;
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEditItem.Location = new System.Drawing.Point(600, 0);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(40, 40);
            this.btnEditItem.TabIndex = 0;
            this.btnEditItem.Text = "✏️";
            this.btnEditItem.UseVisualStyleBackColor = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDeleteItem.Location = new System.Drawing.Point(650, 0);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "🗑️";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(700, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 40);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "+ Thêm món";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowUserToAddRows = false;
            this.dgvMenuItems.AllowUserToDeleteRows = false;
            this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvMenuItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvMenuItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvMenuItems.Location = new System.Drawing.Point(30, 320);
            this.dgvMenuItems.MultiSelect = false;
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.ReadOnly = true;
            this.dgvMenuItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMenuItems.RowHeadersVisible = false;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(940, 300);
            this.dgvMenuItems.TabIndex = 4;
            // 
            // panelPagination
            // 
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
            this.panelPagination.Size = new System.Drawing.Size(940, 50);
            this.panelPagination.TabIndex = 5;
            // 
            // lblPaginationInfo
            // 
            this.lblPaginationInfo.AutoSize = true;
            this.lblPaginationInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPaginationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPaginationInfo.Location = new System.Drawing.Point(0, 15);
            this.lblPaginationInfo.Name = "lblPaginationInfo";
            this.lblPaginationInfo.Size = new System.Drawing.Size(200, 19);
            this.lblPaginationInfo.TabIndex = 0;
            this.lblPaginationInfo.Text = "Hiển thị 1-10 của 15 món ăn";
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnPageFirst.FlatAppearance.BorderSize = 0;
            this.btnPageFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageFirst.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageFirst.Location = new System.Drawing.Point(200, 10);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(40, 30);
            this.btnPageFirst.TabIndex = 1;
            this.btnPageFirst.Text = "⏮️";
            this.btnPageFirst.UseVisualStyleBackColor = false;
            // 
            // btnPagePrev
            // 
            this.btnPagePrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPagePrev.FlatAppearance.BorderSize = 0;
            this.btnPagePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagePrev.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagePrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPagePrev.Location = new System.Drawing.Point(250, 10);
            this.btnPagePrev.Name = "btnPagePrev";
            this.btnPagePrev.Size = new System.Drawing.Size(40, 30);
            this.btnPagePrev.TabIndex = 2;
            this.btnPagePrev.Text = "◀️";
            this.btnPagePrev.UseVisualStyleBackColor = false;
            // 
            // btnPage1
            // 
            this.btnPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnPage1.FlatAppearance.BorderSize = 0;
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage1.Location = new System.Drawing.Point(300, 10);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(40, 30);
            this.btnPage1.TabIndex = 3;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            this.btnPage2.BackColor = System.Drawing.Color.Transparent;
            this.btnPage2.FlatAppearance.BorderSize = 0;
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage2.Location = new System.Drawing.Point(350, 10);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(40, 30);
            this.btnPage2.TabIndex = 4;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = false;
            // 
            // btnPage3
            // 
            this.btnPage3.BackColor = System.Drawing.Color.Transparent;
            this.btnPage3.FlatAppearance.BorderSize = 0;
            this.btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage3.Location = new System.Drawing.Point(400, 10);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(40, 30);
            this.btnPage3.TabIndex = 5;
            this.btnPage3.Text = "3";
            this.btnPage3.UseVisualStyleBackColor = false;
            // 
            // btnPage4
            // 
            this.btnPage4.BackColor = System.Drawing.Color.Transparent;
            this.btnPage4.FlatAppearance.BorderSize = 0;
            this.btnPage4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPage4.Location = new System.Drawing.Point(450, 10);
            this.btnPage4.Name = "btnPage4";
            this.btnPage4.Size = new System.Drawing.Size(40, 30);
            this.btnPage4.TabIndex = 6;
            this.btnPage4.Text = "4";
            this.btnPage4.UseVisualStyleBackColor = false;
            // 
            // btnPageNext
            // 
            this.btnPageNext.BackColor = System.Drawing.Color.Transparent;
            this.btnPageNext.FlatAppearance.BorderSize = 0;
            this.btnPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageNext.Location = new System.Drawing.Point(500, 10);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(40, 30);
            this.btnPageNext.TabIndex = 7;
            this.btnPageNext.Text = "▶️";
            this.btnPageNext.UseVisualStyleBackColor = false;
            // 
            // btnPageLast
            // 
            this.btnPageLast.BackColor = System.Drawing.Color.Transparent;
            this.btnPageLast.FlatAppearance.BorderSize = 0;
            this.btnPageLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageLast.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPageLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnPageLast.Location = new System.Drawing.Point(550, 10);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(40, 30);
            this.btnPageLast.TabIndex = 8;
            this.btnPageLast.Text = "⏭️";
            this.btnPageLast.UseVisualStyleBackColor = false;
            // 
            // FoodMenuManagementControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.headerControl);
            this.Name = "FoodMenuManagementControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.mainContainer.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.panelTableActions.ResumeLayout(false);
            this.panelSearchFilter.ResumeLayout(false);
            this.panelSearchFilter.PerformLayout();
            this.panelInfoCards.ResumeLayout(false);
            this.panelInfoCards.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}


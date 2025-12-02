using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class FoodMenuManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable menuData;

        public FoodMenuManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += FoodMenuManagementControl_Load;
            }
        }

        private void FoodMenuManagementControl_Load(object sender, EventArgs e)
        {
            if (isInitialized) return;
            
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (!isInitialized && dgvMenuItems != null)
                            {
                                LoadSampleData();
                                FormatDataGridView();
                                UpdateStatistics();
                                SetupEventHandlers();
                                isInitialized = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke: {ex.Message}");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FoodMenuManagementControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddItem != null)
                {
                    btnAddItem.Click -= BtnAddItem_Click;
                    btnAddItem.Click += BtnAddItem_Click;
                }
                if (btnEditItem != null)
                {
                    btnEditItem.Click -= BtnEditItem_Click;
                    btnEditItem.Click += BtnEditItem_Click;
                }
                if (btnDeleteItem != null)
                {
                    btnDeleteItem.Click -= BtnDeleteItem_Click;
                    btnDeleteItem.Click += BtnDeleteItem_Click;
                }
                if (txtSearch != null)
                {
                    txtSearch.TextChanged += TxtSearch_TextChanged;
                }
                if (cmbCategoryFilter != null)
                {
                    cmbCategoryFilter.SelectedIndexChanged += CmbCategoryFilter_SelectedIndexChanged;
                }
                if (cmbStatusFilter != null)
                {
                    cmbStatusFilter.SelectedIndexChanged += CmbStatusFilter_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SetupEventHandlers: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvMenuItems == null) return;

                dgvMenuItems.AutoGenerateColumns = true;

                menuData = new DataTable();
                menuData.Columns.Add("ItemCode", typeof(string));
                menuData.Columns.Add("ItemName", typeof(string));
                menuData.Columns.Add("Category", typeof(string));
                menuData.Columns.Add("SellingPrice", typeof(decimal));
                menuData.Columns.Add("CostPrice", typeof(decimal));
                menuData.Columns.Add("StockQuantity", typeof(int));
                menuData.Columns.Add("Unit", typeof(string));
                menuData.Columns.Add("Status", typeof(string));

                // Sample data
                menuData.Rows.Add("MON001", "Nước suối", "Nước uống", 10000, 5000, 100, "Chai", "Còn hàng");
                menuData.Rows.Add("MON002", "Coca Cola", "Nước uống", 15000, 8000, 50, "Chai", "Còn hàng");
                menuData.Rows.Add("MON003", "Bánh mì", "Đồ ăn", 20000, 10000, 30, "Cái", "Còn hàng");
                menuData.Rows.Add("MON004", "Xúc xích", "Đồ ăn", 25000, 12000, 40, "Cái", "Còn hàng");
                menuData.Rows.Add("MON005", "Combo 1", "Combo", 50000, 25000, 20, "Combo", "Còn hàng");
                menuData.Rows.Add("MON006", "Pepsi", "Nước uống", 15000, 8000, 5, "Chai", "Hết hàng");
                menuData.Rows.Add("MON007", "Bánh bao", "Đồ ăn", 15000, 7000, 8, "Cái", "Hết hàng");
                menuData.Rows.Add("MON008", "Nước cam", "Nước uống", 20000, 10000, 25, "Ly", "Còn hàng");
                menuData.Rows.Add("MON009", "Bánh quy", "Đồ ăn", 10000, 5000, 15, "Gói", "Còn hàng");
                menuData.Rows.Add("MON010", "Combo 2", "Combo", 60000, 30000, 10, "Combo", "Còn hàng");

                dgvMenuItems.DataBindingComplete -= DgvMenuItems_DataBindingComplete;
                dgvMenuItems.DataBindingComplete += DgvMenuItems_DataBindingComplete;

                dgvMenuItems.DataSource = null;
                dgvMenuItems.DataSource = menuData;
                dgvMenuItems.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvMenuItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvMenuItems != null && dgvMenuItems.Columns != null && dgvMenuItems.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvMenuItems_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvMenuItems == null || dgvMenuItems.Columns == null || dgvMenuItems.Columns.Count == 0) return;

            try
            {
                if (dgvMenuItems.Columns["ItemCode"] != null)
                {
                    dgvMenuItems.Columns["ItemCode"].HeaderText = "Mã món";
                    dgvMenuItems.Columns["ItemCode"].Width = 100;
                }
                if (dgvMenuItems.Columns["ItemName"] != null)
                {
                    dgvMenuItems.Columns["ItemName"].HeaderText = "Tên món";
                    dgvMenuItems.Columns["ItemName"].Width = 150;
                }
                if (dgvMenuItems.Columns["Category"] != null)
                {
                    dgvMenuItems.Columns["Category"].HeaderText = "Danh mục";
                    dgvMenuItems.Columns["Category"].Width = 120;
                }
                if (dgvMenuItems.Columns["SellingPrice"] != null)
                {
                    dgvMenuItems.Columns["SellingPrice"].HeaderText = "Giá bán";
                    dgvMenuItems.Columns["SellingPrice"].Width = 120;
                    dgvMenuItems.Columns["SellingPrice"].DefaultCellStyle.Format = "N0";
                }
                if (dgvMenuItems.Columns["CostPrice"] != null)
                {
                    dgvMenuItems.Columns["CostPrice"].HeaderText = "Giá vốn";
                    dgvMenuItems.Columns["CostPrice"].Width = 120;
                    dgvMenuItems.Columns["CostPrice"].DefaultCellStyle.Format = "N0";
                }
                if (dgvMenuItems.Columns["StockQuantity"] != null)
                {
                    dgvMenuItems.Columns["StockQuantity"].HeaderText = "Tồn kho";
                    dgvMenuItems.Columns["StockQuantity"].Width = 100;
                }
                if (dgvMenuItems.Columns["Unit"] != null)
                {
                    dgvMenuItems.Columns["Unit"].HeaderText = "Đơn vị";
                    dgvMenuItems.Columns["Unit"].Width = 80;
                }
                if (dgvMenuItems.Columns["Status"] != null)
                {
                    dgvMenuItems.Columns["Status"].HeaderText = "Trạng thái";
                    dgvMenuItems.Columns["Status"].Width = 120;
                }

                dgvMenuItems.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvMenuItems.GridColor = Color.FromArgb(229, 231, 235);
                dgvMenuItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvMenuItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvMenuItems.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvMenuItems.CellFormatting -= DgvMenuItems_CellFormatting;
                dgvMenuItems.CellFormatting += DgvMenuItems_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvMenuItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvMenuItems == null || dgvMenuItems.Columns == null) return;

                var statusCol = dgvMenuItems.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Còn hàng")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                    }
                }

                var stockCol = dgvMenuItems.Columns["StockQuantity"];
                if (stockCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == stockCol.Index && 
                    e.Value != null)
                {
                    if (int.TryParse(e.Value.ToString(), out int stock) && stock < 10)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                        e.CellStyle.Font = new Font(dgvMenuItems.Font, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvMenuItems_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (menuData == null || lblTotalItems == null) return;

                int totalItems = menuData.Rows.Count;
                decimal totalRevenue = 0;
                string bestSeller = "Chưa có";
                int lowStockCount = 0;

                int maxSold = 0;
                foreach (DataRow row in menuData.Rows)
                {
                    if (row["SellingPrice"] != DBNull.Value)
                    {
                        totalRevenue += Convert.ToDecimal(row["SellingPrice"]) * 10; // Giả sử mỗi món bán 10 lần
                    }

                    if (row["StockQuantity"] != DBNull.Value)
                    {
                        int stock = Convert.ToInt32(row["StockQuantity"]);
                        if (stock < 10)
                        {
                            lowStockCount++;
                        }
                    }

                    // Giả sử món bán chạy nhất là món có giá cao nhất
                    if (row["SellingPrice"] != DBNull.Value)
                    {
                        decimal price = Convert.ToDecimal(row["SellingPrice"]);
                        if (price > maxSold)
                        {
                            maxSold = (int)price;
                            bestSeller = row["ItemName"].ToString();
                        }
                    }
                }

                if (lblTotalItems != null)
                {
                    lblTotalItems.Text = $"📋\r\nTổng món:\r\n{totalItems} món\r\n";
                }
                if (lblTotalRevenue != null)
                {
                    lblTotalRevenue.Text = $"💰\r\nDoanh thu hôm nay:\r\n{totalRevenue:N0} đ\r\n";
                }
                if (lblBestSeller != null)
                {
                    lblBestSeller.Text = $"🏆\r\nMón bán chạy:\r\n{bestSeller}\r\n";
                }
                if (lblLowStock != null)
                {
                    lblLowStock.Text = $"⚠️\r\nTồn kho cảnh báo:\r\n{lowStockCount} món\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open food item form for adding
                MessageBox.Show("Chức năng thêm món ăn sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddItem_Click: {ex.Message}");
            }
        }

        private void BtnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenuItems.SelectedRows.Count > 0)
                {
                    // TODO: Open food item form for editing
                    MessageBox.Show("Chức năng sửa món ăn sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditItem_Click: {ex.Message}");
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenuItems.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: Delete food item
                        MessageBox.Show("Chức năng xóa món ăn sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteItem_Click: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterMenuItems();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TxtSearch_TextChanged: {ex.Message}");
            }
        }

        private void CmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterMenuItems();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbCategoryFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterMenuItems();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterMenuItems()
        {
            try
            {
                if (menuData == null || dgvMenuItems == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string categoryFilter = cmbCategoryFilter?.SelectedItem?.ToString() ?? "Tất cả";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = menuData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(ItemCode LIKE '%{searchText}%' OR ItemName LIKE '%{searchText}%')";
                }

                if (categoryFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Category = '{categoryFilter}'";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvMenuItems.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterMenuItems: {ex.Message}");
            }
        }
    }
}


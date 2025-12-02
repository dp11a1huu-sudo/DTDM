using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.Controls
{
    public partial class FieldInfoManagementControl : UserControl
    {
        private string selectedBranch = "CHINHANH1";
        private bool isInitialized = false;

        public FieldInfoManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                // Use Load event to initialize data
                this.Load += FieldInfoManagementControl_Load;
            }
        }

        private void FieldInfoManagementControl_Load(object sender, EventArgs e)
        {
            if (isInitialized) return;
            
            try
            {
                // Use BeginInvoke to ensure all controls are fully initialized
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (!isInitialized)
                            {
                                // Double check all controls exist
                                if (btnBranch1 != null && btnBranch2 != null && dgvFields != null &&
                                    lblLocation != null && lblFieldCount != null && lblServices != null)
                                {
                                    InitializeData();
                                    SetupEvents();
                                    isInitialized = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke: {ex.Message}");
                            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FieldInfoManagementControl_Load: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            
            // Also try to initialize when control becomes visible
            if (this.Visible && !isInitialized)
            {
                try
                {
                    if (btnBranch1 != null && btnBranch2 != null && dgvFields != null &&
                        lblLocation != null && lblFieldCount != null && lblServices != null)
                    {
                        InitializeData();
                        SetupEvents();
                        isInitialized = true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error in OnVisibleChanged: {ex.Message}");
                }
            }
        }

        private void InitializeData()
        {
            try
            {
                LoadBranches();
                LoadFieldData();
                UpdateBranchInfo();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in InitializeData: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void LoadBranches()
        {
            try
            {
                if (btnBranch1 == null || btnBranch2 == null) return;
                
                // Sample branches
                btnBranch1.Text = "CHINHANH1";
                btnBranch2.Text = "CHINHANH2";
                
                // Select first branch by default - but don't reload data yet
                selectedBranch = "CHINHANH1";
                btnBranch1.BackColor = Color.FromArgb(124, 58, 237); // Purple
                btnBranch1.ForeColor = Color.White;
                btnBranch2.BackColor = Color.White;
                btnBranch2.ForeColor = Color.FromArgb(17, 24, 39);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadBranches: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void LoadFieldData()
        {
            try
            {
                if (dgvFields == null) return;

                // Ensure AutoGenerateColumns is enabled
                dgvFields.AutoGenerateColumns = true;

                // Get data from BUS layer
                BUS_Field busField = new BUS_Field();
                DataTable dt = busField.GetAllFields();

                // Transform data for display
                if (dt.Rows.Count > 0)
                {
                    // Add calculated columns for display
                    dt.Columns.Add("PriceDisplay", typeof(string));
                    dt.Columns.Add("AreaDisplay", typeof(string));
                    dt.Columns.Add("StatusDisplay", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        // Format price display
                        decimal priceNormal = Convert.ToDecimal(row["PriceNormal"]);
                        row["PriceDisplay"] = $"{priceNormal:N0} VNĐ/giờ";

                        // Format area display
                        decimal area = Convert.ToDecimal(row["Area"]);
                        row["AreaDisplay"] = $"{area} m²";

                        // Format status display
                        string status = row["Status"].ToString();
                        switch (status)
                        {
                            case "Active":
                                row["StatusDisplay"] = "Hoạt động";
                                break;
                            case "Maintenance":
                                row["StatusDisplay"] = "Bảo trì";
                                break;
                            case "Closed":
                                row["StatusDisplay"] = "Đóng cửa";
                                break;
                            default:
                                row["StatusDisplay"] = status;
                                break;
                        }
                    }
                }

                // Unsubscribe first to avoid duplicate subscriptions
                dgvFields.DataBindingComplete -= DgvFields_DataBindingComplete;
                dgvFields.DataBindingComplete += DgvFields_DataBindingComplete;

                // Clear existing data source first
                dgvFields.DataSource = null;
                dgvFields.Refresh();

                // Set data source
                dgvFields.DataSource = dt;

                // Hide unnecessary columns and rename display columns
                if (dgvFields.Columns.Contains("FieldID")) dgvFields.Columns["FieldID"].Visible = false;
                if (dgvFields.Columns.Contains("PriceHigh")) dgvFields.Columns["PriceHigh"].Visible = false;
                if (dgvFields.Columns.Contains("PriceLow")) dgvFields.Columns["PriceLow"].Visible = false;
                if (dgvFields.Columns.Contains("CreatedDate")) dgvFields.Columns["CreatedDate"].Visible = false;
                if (dgvFields.Columns.Contains("Notes")) dgvFields.Columns["Notes"].Visible = false;

                // Rename columns for better display
                if (dgvFields.Columns.Contains("FieldCode")) dgvFields.Columns["FieldCode"].HeaderText = "Mã sân";
                if (dgvFields.Columns.Contains("FieldName")) dgvFields.Columns["FieldName"].HeaderText = "Tên sân";
                if (dgvFields.Columns.Contains("FieldType")) dgvFields.Columns["FieldType"].HeaderText = "Loại sân";
                if (dgvFields.Columns.Contains("SurfaceType")) dgvFields.Columns["SurfaceType"].HeaderText = "Mặt sân";
                if (dgvFields.Columns.Contains("PriceDisplay")) dgvFields.Columns["PriceDisplay"].HeaderText = "Giá thường";
                if (dgvFields.Columns.Contains("AreaDisplay")) dgvFields.Columns["AreaDisplay"].HeaderText = "Diện tích";
                if (dgvFields.Columns.Contains("StatusDisplay")) dgvFields.Columns["StatusDisplay"].HeaderText = "Trạng thái";

                // Force refresh
                dgvFields.Refresh();
                dgvFields.Update();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadFieldData: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                MessageBox.Show($"Lỗi tải dữ liệu sân bóng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvFields_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvFields != null)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvFields_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvFields == null) return;
            if (dgvFields.Columns == null || dgvFields.Columns.Count == 0) return;

            try
            {
                // Add checkbox column if not exists
                if (dgvFields.Columns["Select"] == null)
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "Select";
                    checkBoxColumn.HeaderText = "";
                    checkBoxColumn.Width = 50;
                    checkBoxColumn.Frozen = false;
                    dgvFields.Columns.Insert(0, checkBoxColumn);
                }
                else
                {
                    var selectCol = dgvFields.Columns["Select"];
                    if (selectCol != null)
                    {
                        selectCol.Width = 50;
                        selectCol.HeaderText = "";
                    }
                }

                // Format other columns - check if column exists before accessing
                var fieldCodeCol = dgvFields.Columns["FieldCode"];
                if (fieldCodeCol != null)
                {
                    fieldCodeCol.HeaderText = "Mã sân";
                    fieldCodeCol.Width = 100;
                }

                var fieldNameCol = dgvFields.Columns["FieldName"];
                if (fieldNameCol != null)
                {
                    fieldNameCol.HeaderText = "Tên sân";
                    fieldNameCol.Width = 200;
                }

                var fieldTypeCol = dgvFields.Columns["FieldType"];
                if (fieldTypeCol != null)
                {
                    fieldTypeCol.HeaderText = "Loại sân";
                    fieldTypeCol.Width = 100;
                }

                var areaCol = dgvFields.Columns["Area"];
                if (areaCol != null)
                {
                    areaCol.HeaderText = "Diện tích";
                    areaCol.Width = 120;
                }

                var priceCol = dgvFields.Columns["Price"];
                if (priceCol != null)
                {
                    priceCol.HeaderText = "Giá thuê";
                    priceCol.Width = 180;
                }

                var statusCol = dgvFields.Columns["Status"];
                if (statusCol != null)
                {
                    statusCol.HeaderText = "Trạng thái";
                    statusCol.Width = 120;
                }

                // Set border style for all cells
                dgvFields.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvFields.GridColor = Color.FromArgb(229, 231, 235); // Light gray border
                dgvFields.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvFields.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                // Set selection color and border for all cells
                if (dgvFields.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvFields.Rows)
                    {
                        if (row == null) continue;
                        
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null && cell.Style != null)
                            {
                                cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255); // Light purple
                            }
                        }

                        // Set all checkboxes to checked
                        if (row.Cells["Select"] != null)
                        {
                            row.Cells["Select"].Value = true;
                        }
                    }
                }

                // Format status column - only subscribe once
                dgvFields.CellFormatting -= DgvFields_CellFormatting;
                dgvFields.CellFormatting += DgvFields_CellFormatting;
            }
            catch (Exception ex)
            {
                // Log error if needed
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void DgvFields_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFields.Columns["Status"] != null && 
                e.ColumnIndex == dgvFields.Columns["Status"].Index && 
                e.Value != null)
            {
                var status = e.Value.ToString();
                if (status == "Hoạt động")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                }
                else if (status == "Trống")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                }
                else if (status == "Bảo trì")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                }
            }
        }

        private void UpdateBranchInfo()
        {
            try
            {
                if (lblLocation != null)
                    lblLocation.Text = "📍 123 đường Nguyễn Trãi, phường Thanh Xuân, Hà Nội";

                // Get actual field count from database
                BUS_Field busField = new BUS_Field();
                DataTable fieldStats = busField.GetFieldStatistics();

                int totalFields = 0;
                if (fieldStats.Rows.Count > 0)
                {
                    foreach (DataRow row in fieldStats.Rows)
                    {
                        totalFields += Convert.ToInt32(row["TotalFields"]);
                    }
                }

                if (lblFieldCount != null)
                    lblFieldCount.Text = $"☰ {totalFields} Sân";

                if (lblServices != null)
                    lblServices.Text = "✏️ Có dịch vụ ăn uống, thuê đồ thi đấu";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateBranchInfo: {ex.Message}");

                // Fallback to default values
                if (lblLocation != null)
                    lblLocation.Text = "📍 123 đường Nguyễn Trãi, phường Thanh Xuân, Hà Nội";
                if (lblFieldCount != null)
                    lblFieldCount.Text = "☰ Đang tải...";
                if (lblServices != null)
                    lblServices.Text = "✏️ Có dịch vụ ăn uống, thuê đồ thi đấu";
            }
        }

        private void SetupEvents()
        {
            if (btnBranch1 != null)
                btnBranch1.Click += (s, e) => SelectBranch("CHINHANH1");
            if (btnBranch2 != null)
                btnBranch2.Click += (s, e) => SelectBranch("CHINHANH2");
            if (btnAddBranch != null)
                btnAddBranch.Click += (s, e) => AddBranch();
            if (btnEditBranch != null)
                btnEditBranch.Click += (s, e) => EditBranch();
            if (btnDeleteBranch != null)
                btnDeleteBranch.Click += (s, e) => DeleteBranch();
            if (btnSearchBranch != null)
                btnSearchBranch.Click += (s, e) => SearchBranch();

            if (btnAddField != null)
                btnAddField.Click += (s, e) => AddField();
            if (btnEditField != null)
                btnEditField.Click += (s, e) => EditField();
            if (btnDeleteField != null)
                btnDeleteField.Click += (s, e) => DeleteField();
        }

        private void SelectBranch(string branchCode)
        {
            selectedBranch = branchCode;
            
            if (btnBranch1 == null || btnBranch2 == null) return;
            
            try
            {
                // Update button styles
                if (branchCode == "CHINHANH1")
                {
                    btnBranch1.BackColor = Color.FromArgb(124, 58, 237); // Purple
                    btnBranch1.ForeColor = Color.White;
                    btnBranch2.BackColor = Color.White;
                    btnBranch2.ForeColor = Color.FromArgb(17, 24, 39);
                }
                else
                {
                    btnBranch2.BackColor = Color.FromArgb(124, 58, 237); // Purple
                    btnBranch2.ForeColor = Color.White;
                    btnBranch1.BackColor = Color.White;
                    btnBranch1.ForeColor = Color.FromArgb(17, 24, 39);
                }

                // Reload field data for selected branch
                LoadFieldData();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SelectBranch: {ex.Message}");
            }
        }

        private void AddBranch()
        {
            MessageBox.Show("Thêm chi nhánh mới", "Thông báo");
        }

        private void EditBranch()
        {
            MessageBox.Show($"Chỉnh sửa chi nhánh: {selectedBranch}", "Thông báo");
        }

        private void DeleteBranch()
        {
            if (MessageBox.Show($"Bạn có chắc muốn xóa chi nhánh {selectedBranch}?", "Xác nhận", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show($"Đã xóa chi nhánh {selectedBranch}", "Thông báo");
            }
        }

        private void SearchBranch()
        {
            MessageBox.Show("Tìm kiếm chi nhánh", "Thông báo");
        }

        private void AddField()
        {
            MessageBox.Show("Thêm sân mới", "Thông báo");
        }

        private void EditField()
        {
            if (dgvFields == null || dgvFields.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sân cần chỉnh sửa", "Thông báo");
                return;
            }

            var selectedRow = dgvFields.SelectedRows[0];
            if (selectedRow.Cells["FieldCode"] != null && selectedRow.Cells["FieldCode"].Value != null)
            {
                var fieldCode = selectedRow.Cells["FieldCode"].Value.ToString();
                MessageBox.Show($"Chỉnh sửa sân: {fieldCode}", "Thông báo");
            }
        }

        private void DeleteField()
        {
            if (dgvFields == null || dgvFields.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sân cần xóa", "Thông báo");
                return;
            }

            var selectedRow = dgvFields.SelectedRows[0];
            if (selectedRow.Cells["FieldCode"] != null && selectedRow.Cells["FieldCode"].Value != null)
            {
                var fieldCode = selectedRow.Cells["FieldCode"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc muốn xóa sân {fieldCode}?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show($"Đã xóa sân {fieldCode}", "Thông báo");
                }
            }
        }
    }
}


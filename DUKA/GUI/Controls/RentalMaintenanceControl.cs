using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RentalMaintenanceControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable maintenanceData;

        public RentalMaintenanceControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += RentalMaintenanceControl_Load;
            }
        }

        private void RentalMaintenanceControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvMaintenance != null)
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
                System.Diagnostics.Debug.WriteLine($"Error in RentalMaintenanceControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddMaintenance != null)
                {
                    btnAddMaintenance.Click -= BtnAddMaintenance_Click;
                    btnAddMaintenance.Click += BtnAddMaintenance_Click;
                }
                if (btnCompleteMaintenance != null)
                {
                    btnCompleteMaintenance.Click -= BtnCompleteMaintenance_Click;
                    btnCompleteMaintenance.Click += BtnCompleteMaintenance_Click;
                }
                if (btnViewDetails != null)
                {
                    btnViewDetails.Click -= BtnViewDetails_Click;
                    btnViewDetails.Click += BtnViewDetails_Click;
                }
                if (txtSearch != null)
                {
                    txtSearch.TextChanged += TxtSearch_TextChanged;
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
                if (dgvMaintenance == null) return;

                dgvMaintenance.AutoGenerateColumns = true;

                maintenanceData = new DataTable();
                maintenanceData.Columns.Add("MaintenanceCode", typeof(string));
                maintenanceData.Columns.Add("EquipmentName", typeof(string));
                maintenanceData.Columns.Add("EquipmentCode", typeof(string));
                maintenanceData.Columns.Add("Description", typeof(string));
                maintenanceData.Columns.Add("AssignedTo", typeof(string));
                maintenanceData.Columns.Add("MaintenanceDate", typeof(string));
                maintenanceData.Columns.Add("Cost", typeof(decimal));
                maintenanceData.Columns.Add("Status", typeof(string));
                maintenanceData.Columns.Add("NextMaintenanceDate", typeof(string));

                // Sample data
                maintenanceData.Rows.Add("BT001", "Bóng đá size 5", "TB001", "Thay bóng mới", "Lê Văn Cường", "10/01/2025", 500000, "Hoàn thành", "10/04/2025");
                maintenanceData.Rows.Add("BT002", "Giày đá bóng Adidas", "TB002", "Vệ sinh và bảo dưỡng", "Lê Văn Cường", "12/01/2025", 200000, "Hoàn thành", "12/04/2025");
                maintenanceData.Rows.Add("BT003", "Bóng đá size 4", "TB004", "Kiểm tra và sửa chữa", "Lê Văn Cường", "15/01/2025", 300000, "Đang thực hiện", "");
                maintenanceData.Rows.Add("BT004", "Giày đá bóng Puma", "TB009", "Thay đế giày", "Nguyễn Văn A", "16/01/2025", 400000, "Chờ xử lý", "");
                maintenanceData.Rows.Add("BT005", "Bóng đá size 3", "TB008", "Thay bóng mới", "Lê Văn Cường", "08/01/2025", 500000, "Hoàn thành", "08/04/2025");
                maintenanceData.Rows.Add("BT006", "Áo đấu Real Madrid", "TB003", "Giặt và kiểm tra", "Trần Thị B", "11/01/2025", 100000, "Hoàn thành", "11/02/2025");
                maintenanceData.Rows.Add("BT007", "Bảo vệ ống chân", "TB007", "Kiểm tra độ an toàn", "Lê Văn Cường", "13/01/2025", 150000, "Hoàn thành", "13/04/2025");
                maintenanceData.Rows.Add("BT008", "Giày đá bóng Nike", "TB005", "Vệ sinh và bảo dưỡng", "Nguyễn Văn A", "17/01/2025", 200000, "Chờ xử lý", "");
                maintenanceData.Rows.Add("BT009", "Áo đấu Barcelona", "TB006", "Giặt và kiểm tra", "Trần Thị B", "09/01/2025", 100000, "Hoàn thành", "09/02/2025");
                maintenanceData.Rows.Add("BT010", "Bóng đá size 5", "TB001", "Kiểm tra định kỳ", "Lê Văn Cường", "18/01/2025", 100000, "Chờ xử lý", "");
                maintenanceData.Rows.Add("BT011", "Giày đá bóng Adidas", "TB002", "Thay dây giày", "Lê Văn Cường", "14/01/2025", 50000, "Hoàn thành", "14/04/2025");
                maintenanceData.Rows.Add("BT012", "Áo đấu Manchester United", "TB010", "Giặt và kiểm tra", "Trần Thị B", "07/01/2025", 100000, "Hoàn thành", "07/02/2025");

                dgvMaintenance.DataBindingComplete -= DgvMaintenance_DataBindingComplete;
                dgvMaintenance.DataBindingComplete += DgvMaintenance_DataBindingComplete;

                dgvMaintenance.DataSource = null;
                dgvMaintenance.DataSource = maintenanceData;
                dgvMaintenance.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvMaintenance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvMaintenance != null && dgvMaintenance.Columns != null && dgvMaintenance.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvMaintenance_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvMaintenance == null || dgvMaintenance.Columns == null || dgvMaintenance.Columns.Count == 0) return;

            try
            {
                if (dgvMaintenance.Columns["MaintenanceCode"] != null)
                {
                    dgvMaintenance.Columns["MaintenanceCode"].HeaderText = "Mã bảo trì";
                    dgvMaintenance.Columns["MaintenanceCode"].Width = 100;
                }
                if (dgvMaintenance.Columns["EquipmentName"] != null)
                {
                    dgvMaintenance.Columns["EquipmentName"].HeaderText = "Thiết bị";
                    dgvMaintenance.Columns["EquipmentName"].Width = 150;
                }
                if (dgvMaintenance.Columns["EquipmentCode"] != null)
                {
                    dgvMaintenance.Columns["EquipmentCode"].HeaderText = "Mã TB";
                    dgvMaintenance.Columns["EquipmentCode"].Width = 80;
                }
                if (dgvMaintenance.Columns["Description"] != null)
                {
                    dgvMaintenance.Columns["Description"].HeaderText = "Mô tả";
                    dgvMaintenance.Columns["Description"].Width = 200;
                }
                if (dgvMaintenance.Columns["AssignedTo"] != null)
                {
                    dgvMaintenance.Columns["AssignedTo"].HeaderText = "Người thực hiện";
                    dgvMaintenance.Columns["AssignedTo"].Width = 150;
                }
                if (dgvMaintenance.Columns["MaintenanceDate"] != null)
                {
                    dgvMaintenance.Columns["MaintenanceDate"].HeaderText = "Ngày bảo trì";
                    dgvMaintenance.Columns["MaintenanceDate"].Width = 120;
                }
                if (dgvMaintenance.Columns["Cost"] != null)
                {
                    dgvMaintenance.Columns["Cost"].HeaderText = "Chi phí";
                    dgvMaintenance.Columns["Cost"].Width = 120;
                    dgvMaintenance.Columns["Cost"].DefaultCellStyle.Format = "N0";
                }
                if (dgvMaintenance.Columns["Status"] != null)
                {
                    dgvMaintenance.Columns["Status"].HeaderText = "Trạng thái";
                    dgvMaintenance.Columns["Status"].Width = 120;
                }
                if (dgvMaintenance.Columns["NextMaintenanceDate"] != null)
                {
                    dgvMaintenance.Columns["NextMaintenanceDate"].HeaderText = "Lần bảo trì tiếp";
                    dgvMaintenance.Columns["NextMaintenanceDate"].Width = 120;
                }

                dgvMaintenance.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvMaintenance.GridColor = Color.FromArgb(229, 231, 235);
                dgvMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvMaintenance.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvMaintenance.CellFormatting -= DgvMaintenance_CellFormatting;
                dgvMaintenance.CellFormatting += DgvMaintenance_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvMaintenance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvMaintenance == null || dgvMaintenance.Columns == null) return;

                var statusCol = dgvMaintenance.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Hoàn thành")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Đang thực hiện")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvMaintenance_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (maintenanceData == null || lblTotalMaintenance == null) return;

                int totalMaintenance = maintenanceData.Rows.Count;
                int pendingMaintenance = 0;
                int completedMaintenance = 0;
                decimal totalCost = 0;

                foreach (DataRow row in maintenanceData.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Chờ xử lý" || status == "Đang thực hiện")
                    {
                        pendingMaintenance++;
                    }
                    else if (status == "Hoàn thành")
                    {
                        completedMaintenance++;
                    }

                    if (row["Cost"] != DBNull.Value && status == "Hoàn thành")
                    {
                        totalCost += Convert.ToDecimal(row["Cost"]);
                    }
                }

                if (lblTotalMaintenance != null)
                {
                    lblTotalMaintenance.Text = $"📋\r\nTổng bảo trì:\r\n{totalMaintenance} lần\r\n";
                }
                if (lblPendingMaintenance != null)
                {
                    lblPendingMaintenance.Text = $"⏳\r\nChờ xử lý:\r\n{pendingMaintenance} lần\r\n";
                }
                if (lblCompletedMaintenance != null)
                {
                    lblCompletedMaintenance.Text = $"✅\r\nHoàn thành:\r\n{completedMaintenance} lần\r\n";
                }
                if (lblMaintenanceCost != null)
                {
                    lblMaintenanceCost.Text = $"💰\r\nChi phí bảo trì:\r\n{totalCost:N0} đ\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chức năng ghi nhận bảo trì sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddMaintenance_Click: {ex.Message}");
            }
        }

        private void BtnCompleteMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaintenance.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvMaintenance.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Chờ xử lý" || status == "Đang thực hiện")
                    {
                        selectedRow.Cells["Status"].Value = "Hoàn thành";
                        UpdateStatistics();
                        MessageBox.Show("Cập nhật trạng thái bảo trì thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể hoàn thành bảo trì đang chờ xử lý hoặc đang thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảo trì cần hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnCompleteMaintenance_Click: {ex.Message}");
            }
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaintenance.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Chức năng xem chi tiết bảo trì sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảo trì cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnViewDetails_Click: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterMaintenance();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TxtSearch_TextChanged: {ex.Message}");
            }
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterMaintenance();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterMaintenance()
        {
            try
            {
                if (maintenanceData == null || dgvMaintenance == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = maintenanceData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(MaintenanceCode LIKE '%{searchText}%' OR EquipmentName LIKE '%{searchText}%' OR EquipmentCode LIKE '%{searchText}%')";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvMaintenance.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterMaintenance: {ex.Message}");
            }
        }
    }
}


using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RentalEquipmentManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable equipmentData;

        public RentalEquipmentManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += RentalEquipmentManagementControl_Load;
            }
        }

        private void RentalEquipmentManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvEquipment != null)
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
                System.Diagnostics.Debug.WriteLine($"Error in RentalEquipmentManagementControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddEquipment != null)
                {
                    btnAddEquipment.Click -= BtnAddEquipment_Click;
                    btnAddEquipment.Click += BtnAddEquipment_Click;
                }
                if (btnEditEquipment != null)
                {
                    btnEditEquipment.Click -= BtnEditEquipment_Click;
                    btnEditEquipment.Click += BtnEditEquipment_Click;
                }
                if (btnDeleteEquipment != null)
                {
                    btnDeleteEquipment.Click -= BtnDeleteEquipment_Click;
                    btnDeleteEquipment.Click += BtnDeleteEquipment_Click;
                }
                if (txtSearch != null)
                {
                    txtSearch.TextChanged += TxtSearch_TextChanged;
                }
                if (cmbTypeFilter != null)
                {
                    cmbTypeFilter.SelectedIndexChanged += CmbTypeFilter_SelectedIndexChanged;
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
                if (dgvEquipment == null) return;

                dgvEquipment.AutoGenerateColumns = true;

                equipmentData = new DataTable();
                equipmentData.Columns.Add("EquipmentCode", typeof(string));
                equipmentData.Columns.Add("EquipmentName", typeof(string));
                equipmentData.Columns.Add("EquipmentType", typeof(string));
                equipmentData.Columns.Add("RentalPricePerHour", typeof(decimal));
                equipmentData.Columns.Add("RentalPricePerDay", typeof(decimal));
                equipmentData.Columns.Add("TotalQuantity", typeof(int));
                equipmentData.Columns.Add("AvailableQuantity", typeof(int));
                equipmentData.Columns.Add("RentedQuantity", typeof(int));
                equipmentData.Columns.Add("Status", typeof(string));
                equipmentData.Columns.Add("PurchaseDate", typeof(string));
                equipmentData.Columns.Add("WarrantyExpiry", typeof(string));

                // Sample data
                equipmentData.Rows.Add("TB001", "Bóng đá size 5", "Bóng", 20000, 150000, 20, 15, 5, "Tốt", "01/01/2024", "01/01/2026");
                equipmentData.Rows.Add("TB002", "Giày đá bóng Adidas", "Giày", 50000, 350000, 15, 10, 5, "Tốt", "15/02/2024", "15/02/2025");
                equipmentData.Rows.Add("TB003", "Áo đấu Real Madrid", "Áo", 30000, 200000, 25, 20, 5, "Tốt", "10/03/2024", "10/03/2025");
                equipmentData.Rows.Add("TB004", "Bóng đá size 4", "Bóng", 15000, 100000, 10, 5, 3, "Cần bảo trì", "20/01/2024", "20/01/2026");
                equipmentData.Rows.Add("TB005", "Giày đá bóng Nike", "Giày", 50000, 350000, 12, 8, 2, "Tốt", "05/04/2024", "05/04/2025");
                equipmentData.Rows.Add("TB006", "Áo đấu Barcelona", "Áo", 30000, 200000, 20, 15, 3, "Tốt", "12/05/2024", "12/05/2025");
                equipmentData.Rows.Add("TB007", "Bảo vệ ống chân", "Bảo hộ", 10000, 50000, 30, 25, 2, "Tốt", "01/06/2024", "01/06/2026");
                equipmentData.Rows.Add("TB008", "Bóng đá size 3", "Bóng", 10000, 80000, 8, 3, 2, "Hỏng", "15/01/2024", "15/01/2026");
                equipmentData.Rows.Add("TB009", "Giày đá bóng Puma", "Giày", 45000, 300000, 10, 7, 1, "Cần bảo trì", "20/07/2024", "20/07/2025");
                equipmentData.Rows.Add("TB010", "Áo đấu Manchester United", "Áo", 30000, 200000, 18, 12, 4, "Tốt", "25/08/2024", "25/08/2025");

                dgvEquipment.DataBindingComplete -= DgvEquipment_DataBindingComplete;
                dgvEquipment.DataBindingComplete += DgvEquipment_DataBindingComplete;

                dgvEquipment.DataSource = null;
                dgvEquipment.DataSource = equipmentData;
                dgvEquipment.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvEquipment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvEquipment != null && dgvEquipment.Columns != null && dgvEquipment.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvEquipment_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvEquipment == null || dgvEquipment.Columns == null || dgvEquipment.Columns.Count == 0) return;

            try
            {
                if (dgvEquipment.Columns["EquipmentCode"] != null)
                {
                    dgvEquipment.Columns["EquipmentCode"].HeaderText = "Mã thiết bị";
                    dgvEquipment.Columns["EquipmentCode"].Width = 100;
                }
                if (dgvEquipment.Columns["EquipmentName"] != null)
                {
                    dgvEquipment.Columns["EquipmentName"].HeaderText = "Tên thiết bị";
                    dgvEquipment.Columns["EquipmentName"].Width = 150;
                }
                if (dgvEquipment.Columns["EquipmentType"] != null)
                {
                    dgvEquipment.Columns["EquipmentType"].HeaderText = "Loại";
                    dgvEquipment.Columns["EquipmentType"].Width = 100;
                }
                if (dgvEquipment.Columns["RentalPricePerHour"] != null)
                {
                    dgvEquipment.Columns["RentalPricePerHour"].HeaderText = "Giá/giờ";
                    dgvEquipment.Columns["RentalPricePerHour"].Width = 100;
                    dgvEquipment.Columns["RentalPricePerHour"].DefaultCellStyle.Format = "N0";
                }
                if (dgvEquipment.Columns["RentalPricePerDay"] != null)
                {
                    dgvEquipment.Columns["RentalPricePerDay"].HeaderText = "Giá/ngày";
                    dgvEquipment.Columns["RentalPricePerDay"].Width = 100;
                    dgvEquipment.Columns["RentalPricePerDay"].DefaultCellStyle.Format = "N0";
                }
                if (dgvEquipment.Columns["TotalQuantity"] != null)
                {
                    dgvEquipment.Columns["TotalQuantity"].HeaderText = "Tổng số";
                    dgvEquipment.Columns["TotalQuantity"].Width = 80;
                }
                if (dgvEquipment.Columns["AvailableQuantity"] != null)
                {
                    dgvEquipment.Columns["AvailableQuantity"].HeaderText = "Khả dụng";
                    dgvEquipment.Columns["AvailableQuantity"].Width = 80;
                }
                if (dgvEquipment.Columns["RentedQuantity"] != null)
                {
                    dgvEquipment.Columns["RentedQuantity"].HeaderText = "Đang thuê";
                    dgvEquipment.Columns["RentedQuantity"].Width = 80;
                }
                if (dgvEquipment.Columns["Status"] != null)
                {
                    dgvEquipment.Columns["Status"].HeaderText = "Tình trạng";
                    dgvEquipment.Columns["Status"].Width = 100;
                }
                if (dgvEquipment.Columns["PurchaseDate"] != null)
                {
                    dgvEquipment.Columns["PurchaseDate"].HeaderText = "Ngày mua";
                    dgvEquipment.Columns["PurchaseDate"].Width = 100;
                }
                if (dgvEquipment.Columns["WarrantyExpiry"] != null)
                {
                    dgvEquipment.Columns["WarrantyExpiry"].HeaderText = "Hết BH";
                    dgvEquipment.Columns["WarrantyExpiry"].Width = 100;
                }

                dgvEquipment.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvEquipment.GridColor = Color.FromArgb(229, 231, 235);
                dgvEquipment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvEquipment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvEquipment.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvEquipment.CellFormatting -= DgvEquipment_CellFormatting;
                dgvEquipment.CellFormatting += DgvEquipment_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvEquipment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvEquipment == null || dgvEquipment.Columns == null) return;

                var statusCol = dgvEquipment.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Tốt")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Cần bảo trì")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvEquipment_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (equipmentData == null || lblTotalEquipment == null) return;

                int totalEquipment = equipmentData.Rows.Count;
                int availableEquipment = 0;
                int rentedEquipment = 0;
                int maintenanceNeeded = 0;

                foreach (DataRow row in equipmentData.Rows)
                {
                    if (row["AvailableQuantity"] != DBNull.Value)
                    {
                        availableEquipment += Convert.ToInt32(row["AvailableQuantity"]);
                    }
                    if (row["RentedQuantity"] != DBNull.Value)
                    {
                        rentedEquipment += Convert.ToInt32(row["RentedQuantity"]);
                    }
                    if (row["Status"] != DBNull.Value && row["Status"].ToString() == "Cần bảo trì")
                    {
                        maintenanceNeeded++;
                    }
                }

                if (lblTotalEquipment != null)
                {
                    lblTotalEquipment.Text = $"📦\r\nTổng thiết bị:\r\n{totalEquipment} thiết bị\r\n";
                }
                if (lblAvailableEquipment != null)
                {
                    lblAvailableEquipment.Text = $"✅\r\nKhả dụng:\r\n{availableEquipment} thiết bị\r\n";
                }
                if (lblRentedEquipment != null)
                {
                    lblRentedEquipment.Text = $"📋\r\nĐang cho thuê:\r\n{rentedEquipment} thiết bị\r\n";
                }
                if (lblMaintenanceNeeded != null)
                {
                    lblMaintenanceNeeded.Text = $"⚠️\r\nCần bảo trì:\r\n{maintenanceNeeded} thiết bị\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chức năng thêm thiết bị sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddEquipment_Click: {ex.Message}");
            }
        }

        private void BtnEditEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipment.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Chức năng sửa thiết bị sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thiết bị cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditEquipment_Click: {ex.Message}");
            }
        }

        private void BtnDeleteEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEquipment.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Chức năng xóa thiết bị sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thiết bị cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteEquipment_Click: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterEquipment();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TxtSearch_TextChanged: {ex.Message}");
            }
        }

        private void CmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterEquipment();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbTypeFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterEquipment();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterEquipment()
        {
            try
            {
                if (equipmentData == null || dgvEquipment == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string typeFilter = cmbTypeFilter?.SelectedItem?.ToString() ?? "Tất cả";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = equipmentData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(EquipmentCode LIKE '%{searchText}%' OR EquipmentName LIKE '%{searchText}%')";
                }

                if (typeFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"EquipmentType = '{typeFilter}'";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvEquipment.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterEquipment: {ex.Message}");
            }
        }
    }
}


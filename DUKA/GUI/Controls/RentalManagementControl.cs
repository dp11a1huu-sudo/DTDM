using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RentalManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable rentalData;

        public RentalManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += RentalManagementControl_Load;
            }
        }

        private void RentalManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvRentals != null)
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
                System.Diagnostics.Debug.WriteLine($"Error in RentalManagementControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddRental != null)
                {
                    btnAddRental.Click -= BtnAddRental_Click;
                    btnAddRental.Click += BtnAddRental_Click;
                }
                if (btnViewDetails != null)
                {
                    btnViewDetails.Click -= BtnViewDetails_Click;
                    btnViewDetails.Click += BtnViewDetails_Click;
                }
                if (btnReturnEquipment != null)
                {
                    btnReturnEquipment.Click -= BtnReturnEquipment_Click;
                    btnReturnEquipment.Click += BtnReturnEquipment_Click;
                }
                if (btnPayment != null)
                {
                    btnPayment.Click -= BtnPayment_Click;
                    btnPayment.Click += BtnPayment_Click;
                }
                if (btnPrintInvoice != null)
                {
                    btnPrintInvoice.Click -= BtnPrintInvoice_Click;
                    btnPrintInvoice.Click += BtnPrintInvoice_Click;
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
                if (dgvRentals == null) return;

                dgvRentals.AutoGenerateColumns = true;

                rentalData = new DataTable();
                rentalData.Columns.Add("RentalCode", typeof(string));
                rentalData.Columns.Add("CustomerName", typeof(string));
                rentalData.Columns.Add("EquipmentName", typeof(string));
                rentalData.Columns.Add("Quantity", typeof(int));
                rentalData.Columns.Add("RentalType", typeof(string));
                rentalData.Columns.Add("RentalDuration", typeof(string));
                rentalData.Columns.Add("TotalAmount", typeof(decimal));
                rentalData.Columns.Add("Deposit", typeof(decimal));
                rentalData.Columns.Add("Status", typeof(string));
                rentalData.Columns.Add("RentalDate", typeof(string));
                rentalData.Columns.Add("ReturnDate", typeof(string));

                // Sample data
                rentalData.Rows.Add("TH001", "Nguyễn Văn A", "Bóng đá size 5", 2, "Theo giờ", "2 giờ", 80000, 50000, "Đang cho thuê", "15/01/2025 10:00", "15/01/2025 12:00");
                rentalData.Rows.Add("TH002", "Trần Thị B", "Giày đá bóng Adidas", 1, "Theo ngày", "1 ngày", 350000, 200000, "Đang cho thuê", "15/01/2025 08:00", "16/01/2025 08:00");
                rentalData.Rows.Add("TH003", "Lê Văn C", "Áo đấu Real Madrid", 3, "Theo giờ", "3 giờ", 270000, 100000, "Đã trả", "15/01/2025 09:00", "15/01/2025 12:00");
                rentalData.Rows.Add("TH004", "Phạm Thị D", "Bóng đá size 4", 1, "Theo giờ", "1 giờ", 15000, 10000, "Đã thanh toán", "15/01/2025 07:00", "15/01/2025 08:00");
                rentalData.Rows.Add("TH005", "Hoàng Văn E", "Giày đá bóng Nike", 2, "Theo ngày", "1 ngày", 700000, 300000, "Đang cho thuê", "15/01/2025 11:00", "16/01/2025 11:00");
                rentalData.Rows.Add("TH006", "Nguyễn Văn F", "Bảo vệ ống chân", 4, "Theo giờ", "2 giờ", 80000, 50000, "Đã trả", "15/01/2025 10:30", "15/01/2025 12:30");
                rentalData.Rows.Add("TH007", "Trần Thị G", "Áo đấu Barcelona", 2, "Theo giờ", "2 giờ", 120000, 50000, "Đã thanh toán", "15/01/2025 08:30", "15/01/2025 10:30");
                rentalData.Rows.Add("TH008", "Lê Văn H", "Bóng đá size 5", 1, "Theo ngày", "1 ngày", 150000, 100000, "Đang cho thuê", "15/01/2025 12:00", "16/01/2025 12:00");
                rentalData.Rows.Add("TH009", "Phạm Thị I", "Giày đá bóng Puma", 1, "Theo giờ", "2 giờ", 90000, 50000, "Quá hạn", "14/01/2025 10:00", "14/01/2025 12:00");
                rentalData.Rows.Add("TH010", "Hoàng Văn K", "Áo đấu Manchester United", 2, "Theo giờ", "1 giờ", 60000, 30000, "Đã trả", "15/01/2025 11:30", "15/01/2025 12:30");

                dgvRentals.DataBindingComplete -= DgvRentals_DataBindingComplete;
                dgvRentals.DataBindingComplete += DgvRentals_DataBindingComplete;

                dgvRentals.DataSource = null;
                dgvRentals.DataSource = rentalData;
                dgvRentals.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvRentals_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvRentals != null && dgvRentals.Columns != null && dgvRentals.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvRentals_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvRentals == null || dgvRentals.Columns == null || dgvRentals.Columns.Count == 0) return;

            try
            {
                if (dgvRentals.Columns["RentalCode"] != null)
                {
                    dgvRentals.Columns["RentalCode"].HeaderText = "Mã đơn";
                    dgvRentals.Columns["RentalCode"].Width = 100;
                }
                if (dgvRentals.Columns["CustomerName"] != null)
                {
                    dgvRentals.Columns["CustomerName"].HeaderText = "Khách hàng";
                    dgvRentals.Columns["CustomerName"].Width = 150;
                }
                if (dgvRentals.Columns["EquipmentName"] != null)
                {
                    dgvRentals.Columns["EquipmentName"].HeaderText = "Thiết bị";
                    dgvRentals.Columns["EquipmentName"].Width = 150;
                }
                if (dgvRentals.Columns["Quantity"] != null)
                {
                    dgvRentals.Columns["Quantity"].HeaderText = "Số lượng";
                    dgvRentals.Columns["Quantity"].Width = 80;
                }
                if (dgvRentals.Columns["RentalType"] != null)
                {
                    dgvRentals.Columns["RentalType"].HeaderText = "Loại thuê";
                    dgvRentals.Columns["RentalType"].Width = 100;
                }
                if (dgvRentals.Columns["RentalDuration"] != null)
                {
                    dgvRentals.Columns["RentalDuration"].HeaderText = "Thời gian";
                    dgvRentals.Columns["RentalDuration"].Width = 100;
                }
                if (dgvRentals.Columns["TotalAmount"] != null)
                {
                    dgvRentals.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                    dgvRentals.Columns["TotalAmount"].Width = 120;
                    dgvRentals.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (dgvRentals.Columns["Deposit"] != null)
                {
                    dgvRentals.Columns["Deposit"].HeaderText = "Đặt cọc";
                    dgvRentals.Columns["Deposit"].Width = 120;
                    dgvRentals.Columns["Deposit"].DefaultCellStyle.Format = "N0";
                }
                if (dgvRentals.Columns["Status"] != null)
                {
                    dgvRentals.Columns["Status"].HeaderText = "Trạng thái";
                    dgvRentals.Columns["Status"].Width = 120;
                }
                if (dgvRentals.Columns["RentalDate"] != null)
                {
                    dgvRentals.Columns["RentalDate"].HeaderText = "Ngày thuê";
                    dgvRentals.Columns["RentalDate"].Width = 150;
                }
                if (dgvRentals.Columns["ReturnDate"] != null)
                {
                    dgvRentals.Columns["ReturnDate"].HeaderText = "Ngày trả";
                    dgvRentals.Columns["ReturnDate"].Width = 150;
                }

                dgvRentals.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvRentals.GridColor = Color.FromArgb(229, 231, 235);
                dgvRentals.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvRentals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvRentals.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvRentals.CellFormatting -= DgvRentals_CellFormatting;
                dgvRentals.CellFormatting += DgvRentals_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvRentals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvRentals == null || dgvRentals.Columns == null) return;

                var statusCol = dgvRentals.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Đã trả" || status == "Đã thanh toán")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Đang cho thuê")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                    }
                    else if (status == "Quá hạn")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvRentals_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (rentalData == null || lblTodayRevenue == null) return;

                int totalRentals = rentalData.Rows.Count;
                int activeRentals = 0;
                int completedRentals = 0;
                decimal todayRevenue = 0;

                foreach (DataRow row in rentalData.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Đang cho thuê")
                    {
                        activeRentals++;
                    }
                    else if (status == "Đã trả" || status == "Đã thanh toán")
                    {
                        completedRentals++;
                    }

                    if (row["TotalAmount"] != DBNull.Value && (status == "Đã trả" || status == "Đã thanh toán"))
                    {
                        todayRevenue += Convert.ToDecimal(row["TotalAmount"]);
                    }
                }

                if (lblTodayRevenue != null)
                {
                    lblTodayRevenue.Text = $"💰\r\nDoanh thu hôm nay:\r\n{todayRevenue:N0} đ\r\n";
                }
                if (lblActiveRentals != null)
                {
                    lblActiveRentals.Text = $"⏳\r\nĐang cho thuê:\r\n{activeRentals} đơn\r\n";
                }
                if (lblCompletedRentals != null)
                {
                    lblCompletedRentals.Text = $"✅\r\nĐã trả:\r\n{completedRentals} đơn\r\n";
                }
                if (lblTotalRentals != null)
                {
                    lblTotalRentals.Text = $"📋\r\nTổng đơn thuê:\r\n{totalRentals} đơn\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddRental_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chức năng tạo đơn thuê mới sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddRental_Click: {ex.Message}");
            }
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRentals.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Chức năng xem chi tiết đơn thuê sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn thuê cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnViewDetails_Click: {ex.Message}");
            }
        }

        private void BtnReturnEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRentals.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvRentals.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Đang cho thuê")
                    {
                        selectedRow.Cells["Status"].Value = "Đã trả";
                        UpdateStatistics();
                        MessageBox.Show("Xác nhận trả thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể trả thiết bị cho đơn đang cho thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn thuê cần trả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnReturnEquipment_Click: {ex.Message}");
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRentals.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvRentals.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Đã trả")
                    {
                        selectedRow.Cells["Status"].Value = "Đã thanh toán";
                        UpdateStatistics();
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể thanh toán cho đơn đã trả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn thuê cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnPayment_Click: {ex.Message}");
            }
        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRentals.SelectedRows.Count > 0)
                {
                    MessageBox.Show("Chức năng in hóa đơn sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn thuê cần in hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnPrintInvoice_Click: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterRentals();
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
                FilterRentals();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterRentals()
        {
            try
            {
                if (rentalData == null || dgvRentals == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = rentalData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(RentalCode LIKE '%{searchText}%' OR CustomerName LIKE '%{searchText}%' OR EquipmentName LIKE '%{searchText}%')";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvRentals.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterRentals: {ex.Message}");
            }
        }
    }
}


using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class FoodOrderManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable orderData;

        public FoodOrderManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += FoodOrderManagementControl_Load;
            }
        }

        private void FoodOrderManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvOrders != null)
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
                System.Diagnostics.Debug.WriteLine($"Error in FoodOrderManagementControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddOrder != null)
                {
                    btnAddOrder.Click -= BtnAddOrder_Click;
                    btnAddOrder.Click += BtnAddOrder_Click;
                }
                if (btnViewDetails != null)
                {
                    btnViewDetails.Click -= BtnViewDetails_Click;
                    btnViewDetails.Click += BtnViewDetails_Click;
                }
                if (btnUpdateStatus != null)
                {
                    btnUpdateStatus.Click -= BtnUpdateStatus_Click;
                    btnUpdateStatus.Click += BtnUpdateStatus_Click;
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
                if (dgvOrders == null) return;

                dgvOrders.AutoGenerateColumns = true;

                orderData = new DataTable();
                orderData.Columns.Add("OrderCode", typeof(string));
                orderData.Columns.Add("CustomerName", typeof(string));
                orderData.Columns.Add("FieldName", typeof(string));
                orderData.Columns.Add("Items", typeof(string));
                orderData.Columns.Add("TotalAmount", typeof(decimal));
                orderData.Columns.Add("Status", typeof(string));
                orderData.Columns.Add("OrderTime", typeof(string));
                orderData.Columns.Add("PaymentMethod", typeof(string));

                // Sample data
                orderData.Rows.Add("DH001", "Nguyễn Văn A", "Sân 1", "Coca Cola x2, Bánh mì x1", 50000, "Chờ xử lý", "15/01/2025 10:30", "Tiền mặt");
                orderData.Rows.Add("DH002", "Trần Thị B", "Sân 2", "Nước suối x3, Xúc xích x2", 80000, "Đang chuẩn bị", "15/01/2025 11:00", "Tiền mặt");
                orderData.Rows.Add("DH003", "Lê Văn C", "Sân 1", "Combo 1 x1", 50000, "Hoàn thành", "15/01/2025 09:15", "Chuyển khoản");
                orderData.Rows.Add("DH004", "Phạm Thị D", "Sân 3", "Pepsi x2, Bánh bao x2", 60000, "Đã thanh toán", "15/01/2025 08:45", "Tiền mặt");
                orderData.Rows.Add("DH005", "Hoàng Văn E", "Sân 2", "Nước cam x1, Bánh quy x1", 30000, "Chờ xử lý", "15/01/2025 12:00", "Tiền mặt");
                orderData.Rows.Add("DH006", "Nguyễn Văn F", "Sân 1", "Combo 2 x1, Coca Cola x1", 75000, "Đang chuẩn bị", "15/01/2025 11:30", "Chuyển khoản");
                orderData.Rows.Add("DH007", "Trần Thị G", "Sân 3", "Bánh mì x2, Nước suối x2", 60000, "Hoàn thành", "15/01/2025 10:00", "Tiền mặt");
                orderData.Rows.Add("DH008", "Lê Văn H", "Sân 2", "Xúc xích x3", 75000, "Chờ xử lý", "15/01/2025 12:30", "Tiền mặt");
                orderData.Rows.Add("DH009", "Phạm Thị I", "Sân 1", "Combo 1 x2", 100000, "Đã thanh toán", "15/01/2025 09:00", "Chuyển khoản");
                orderData.Rows.Add("DH010", "Hoàng Văn K", "Sân 3", "Nước cam x2, Bánh quy x2", 60000, "Hoàn thành", "15/01/2025 10:45", "Tiền mặt");

                dgvOrders.DataBindingComplete -= DgvOrders_DataBindingComplete;
                dgvOrders.DataBindingComplete += DgvOrders_DataBindingComplete;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = orderData;
                dgvOrders.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvOrders != null && dgvOrders.Columns != null && dgvOrders.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvOrders_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvOrders == null || dgvOrders.Columns == null || dgvOrders.Columns.Count == 0) return;

            try
            {
                if (dgvOrders.Columns["OrderCode"] != null)
                {
                    dgvOrders.Columns["OrderCode"].HeaderText = "Mã đơn";
                    dgvOrders.Columns["OrderCode"].Width = 100;
                }
                if (dgvOrders.Columns["CustomerName"] != null)
                {
                    dgvOrders.Columns["CustomerName"].HeaderText = "Khách hàng";
                    dgvOrders.Columns["CustomerName"].Width = 150;
                }
                if (dgvOrders.Columns["FieldName"] != null)
                {
                    dgvOrders.Columns["FieldName"].HeaderText = "Sân";
                    dgvOrders.Columns["FieldName"].Width = 80;
                }
                if (dgvOrders.Columns["Items"] != null)
                {
                    dgvOrders.Columns["Items"].HeaderText = "Món đã gọi";
                    dgvOrders.Columns["Items"].Width = 250;
                }
                if (dgvOrders.Columns["TotalAmount"] != null)
                {
                    dgvOrders.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                    dgvOrders.Columns["TotalAmount"].Width = 120;
                    dgvOrders.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (dgvOrders.Columns["Status"] != null)
                {
                    dgvOrders.Columns["Status"].HeaderText = "Trạng thái";
                    dgvOrders.Columns["Status"].Width = 120;
                }
                if (dgvOrders.Columns["OrderTime"] != null)
                {
                    dgvOrders.Columns["OrderTime"].HeaderText = "Thời gian";
                    dgvOrders.Columns["OrderTime"].Width = 150;
                }
                if (dgvOrders.Columns["PaymentMethod"] != null)
                {
                    dgvOrders.Columns["PaymentMethod"].HeaderText = "Thanh toán";
                    dgvOrders.Columns["PaymentMethod"].Width = 120;
                }

                dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvOrders.GridColor = Color.FromArgb(229, 231, 235);
                dgvOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvOrders.CellFormatting -= DgvOrders_CellFormatting;
                dgvOrders.CellFormatting += DgvOrders_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvOrders == null || dgvOrders.Columns == null) return;

                var statusCol = dgvOrders.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Hoàn thành" || status == "Đã thanh toán")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Đang chuẩn bị")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                    }
                    else if (status == "Chờ xử lý")
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
                System.Diagnostics.Debug.WriteLine($"Error in DgvOrders_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (orderData == null || lblTodayRevenue == null) return;

                int totalOrders = orderData.Rows.Count;
                int processingOrders = 0;
                int completedOrders = 0;
                decimal todayRevenue = 0;

                foreach (DataRow row in orderData.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Chờ xử lý" || status == "Đang chuẩn bị")
                    {
                        processingOrders++;
                    }
                    else if (status == "Hoàn thành" || status == "Đã thanh toán")
                    {
                        completedOrders++;
                    }

                    if (row["TotalAmount"] != DBNull.Value && (status == "Hoàn thành" || status == "Đã thanh toán"))
                    {
                        todayRevenue += Convert.ToDecimal(row["TotalAmount"]);
                    }
                }

                if (lblTodayRevenue != null)
                {
                    lblTodayRevenue.Text = $"💰\r\nDoanh thu hôm nay:\r\n{todayRevenue:N0} đ\r\n";
                }
                if (lblProcessingOrders != null)
                {
                    lblProcessingOrders.Text = $"⏳\r\nĐang xử lý:\r\n{processingOrders} đơn\r\n";
                }
                if (lblCompletedOrders != null)
                {
                    lblCompletedOrders.Text = $"✅\r\nHoàn thành:\r\n{completedOrders} đơn\r\n";
                }
                if (lblTotalOrders != null)
                {
                    lblTotalOrders.Text = $"📋\r\nTổng đơn hàng:\r\n{totalOrders} đơn\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open order form for creating new order
                MessageBox.Show("Chức năng tạo đơn hàng mới sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddOrder_Click: {ex.Message}");
            }
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    // TODO: Open order detail form
                    MessageBox.Show("Chức năng xem chi tiết đơn hàng sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnViewDetails_Click: {ex.Message}");
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                    string currentStatus = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    // Status flow: Chờ xử lý → Đang chuẩn bị → Hoàn thành
                    string newStatus = "";
                    if (currentStatus == "Chờ xử lý")
                    {
                        newStatus = "Đang chuẩn bị";
                    }
                    else if (currentStatus == "Đang chuẩn bị")
                    {
                        newStatus = "Hoàn thành";
                    }
                    else
                    {
                        MessageBox.Show("Đơn hàng này không thể cập nhật trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    selectedRow.Cells["Status"].Value = newStatus;
                    UpdateStatistics();
                    MessageBox.Show($"Cập nhật trạng thái thành công: {newStatus}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnUpdateStatus_Click: {ex.Message}");
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvOrders.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Hoàn thành")
                    {
                        selectedRow.Cells["Status"].Value = "Đã thanh toán";
                        UpdateStatistics();
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể thanh toán cho đơn hàng đã hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    // TODO: Print invoice
                    MessageBox.Show("Chức năng in hóa đơn sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần in hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                FilterOrders();
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
                FilterOrders();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterOrders()
        {
            try
            {
                if (orderData == null || dgvOrders == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = orderData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(OrderCode LIKE '%{searchText}%' OR CustomerName LIKE '%{searchText}%' OR FieldName LIKE '%{searchText}%')";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvOrders.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterOrders: {ex.Message}");
            }
        }
    }
}


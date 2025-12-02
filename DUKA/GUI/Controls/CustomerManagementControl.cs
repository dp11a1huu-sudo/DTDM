using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class CustomerManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable customerData;

        public CustomerManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += CustomerManagementControl_Load;
            }
        }

        private void CustomerManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvCustomers != null)
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
                System.Diagnostics.Debug.WriteLine($"Error in CustomerManagementControl_Load: {ex.Message}");
            }
        }

        private void SetupEventHandlers()
        {
            try
            {
                if (btnAddCustomer != null)
                {
                    btnAddCustomer.Click -= BtnAddCustomer_Click;
                    btnAddCustomer.Click += BtnAddCustomer_Click;
                }
                if (btnEditCustomer != null)
                {
                    btnEditCustomer.Click -= BtnEditCustomer_Click;
                    btnEditCustomer.Click += BtnEditCustomer_Click;
                }
                if (btnDeleteCustomer != null)
                {
                    btnDeleteCustomer.Click -= BtnDeleteCustomer_Click;
                    btnDeleteCustomer.Click += BtnDeleteCustomer_Click;
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
                if (cmbMemberTypeFilter != null)
                {
                    cmbMemberTypeFilter.SelectedIndexChanged += CmbMemberTypeFilter_SelectedIndexChanged;
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

        private string GetMemberType(int bookingCount)
        {
            if (bookingCount < 10)
                return "🆕 Mới";
            else if (bookingCount <= 30)
                return "⭐ Thường xuyên";
            else
                return "👑 VIP";
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvCustomers == null) return;

                dgvCustomers.AutoGenerateColumns = true;

                customerData = new DataTable();
                customerData.Columns.Add("CustomerCode", typeof(string));
                customerData.Columns.Add("FullName", typeof(string));
                customerData.Columns.Add("Phone", typeof(string));
                customerData.Columns.Add("Email", typeof(string));
                customerData.Columns.Add("Address", typeof(string));
                customerData.Columns.Add("TotalBookings", typeof(int));
                customerData.Columns.Add("TotalSpent", typeof(decimal));
                customerData.Columns.Add("MemberType", typeof(string));
                customerData.Columns.Add("Status", typeof(string));
                customerData.Columns.Add("LastBookingDate", typeof(string));
                customerData.Columns.Add("FavoriteField", typeof(string));

                // Sample data với phân loại
                customerData.Rows.Add("KH001", "Nguyễn Văn A", "0912345678", "nguyenvana@email.com", "123 Đường ABC", 15, 4500000, "⭐ Thường xuyên", "Hoạt động", "15/01/2025", "Sân 1");
                customerData.Rows.Add("KH002", "Trần Thị B", "0923456789", "tranthib@email.com", "456 Đường XYZ", 12, 3600000, "⭐ Thường xuyên", "Hoạt động", "14/01/2025", "Sân 2");
                customerData.Rows.Add("KH003", "Lê Văn C", "0934567890", "levanc@email.com", "789 Đường DEF", 8, 2400000, "🆕 Mới", "Hoạt động", "13/01/2025", "Sân 1");
                customerData.Rows.Add("KH004", "Phạm Thị D", "0945678901", "phamthid@email.com", "321 Đường GHI", 35, 10500000, "👑 VIP", "Hoạt động", "15/01/2025", "Sân 3");
                customerData.Rows.Add("KH005", "Hoàng Văn E", "0956789012", "hoangvane@email.com", "654 Đường JKL", 5, 1500000, "🆕 Mới", "Không hoạt động", "12/01/2025", "Sân 2");

                dgvCustomers.DataBindingComplete -= DgvCustomers_DataBindingComplete;
                dgvCustomers.DataBindingComplete += DgvCustomers_DataBindingComplete;

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = customerData;
                dgvCustomers.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvCustomers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvCustomers != null && dgvCustomers.Columns != null && dgvCustomers.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvCustomers_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvCustomers == null || dgvCustomers.Columns == null || dgvCustomers.Columns.Count == 0) return;

            try
            {
                if (dgvCustomers.Columns["CustomerCode"] != null)
                {
                    dgvCustomers.Columns["CustomerCode"].HeaderText = "Mã KH";
                    dgvCustomers.Columns["CustomerCode"].Width = 100;
                }
                if (dgvCustomers.Columns["FullName"] != null)
                {
                    dgvCustomers.Columns["FullName"].HeaderText = "Họ tên";
                    dgvCustomers.Columns["FullName"].Width = 150;
                }
                if (dgvCustomers.Columns["Phone"] != null)
                {
                    dgvCustomers.Columns["Phone"].HeaderText = "Số điện thoại";
                    dgvCustomers.Columns["Phone"].Width = 120;
                }
                if (dgvCustomers.Columns["Email"] != null)
                {
                    dgvCustomers.Columns["Email"].HeaderText = "Email";
                    dgvCustomers.Columns["Email"].Width = 180;
                }
                if (dgvCustomers.Columns["TotalBookings"] != null)
                {
                    dgvCustomers.Columns["TotalBookings"].HeaderText = "Số lượt đặt";
                    dgvCustomers.Columns["TotalBookings"].Width = 100;
                }
                if (dgvCustomers.Columns["TotalSpent"] != null)
                {
                    dgvCustomers.Columns["TotalSpent"].HeaderText = "Tổng chi tiêu";
                    dgvCustomers.Columns["TotalSpent"].Width = 150;
                    dgvCustomers.Columns["TotalSpent"].DefaultCellStyle.Format = "N0";
                }
                if (dgvCustomers.Columns["MemberType"] != null)
                {
                    dgvCustomers.Columns["MemberType"].HeaderText = "Hạng thành viên";
                    dgvCustomers.Columns["MemberType"].Width = 150;
                }
                if (dgvCustomers.Columns["Status"] != null)
                {
                    dgvCustomers.Columns["Status"].HeaderText = "Trạng thái";
                    dgvCustomers.Columns["Status"].Width = 120;
                }
                if (dgvCustomers.Columns["LastBookingDate"] != null)
                {
                    dgvCustomers.Columns["LastBookingDate"].HeaderText = "Đặt cuối";
                    dgvCustomers.Columns["LastBookingDate"].Width = 100;
                }

                dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvCustomers.GridColor = Color.FromArgb(229, 231, 235);
                dgvCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvCustomers.CellFormatting -= DgvCustomers_CellFormatting;
                dgvCustomers.CellFormatting += DgvCustomers_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvCustomers == null || dgvCustomers.Columns == null) return;

                var statusCol = dgvCustomers.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Hoạt động")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                    }
                }

                var memberTypeCol = dgvCustomers.Columns["MemberType"];
                if (memberTypeCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == memberTypeCol.Index && 
                    e.Value != null)
                {
                    var memberType = e.Value.ToString();
                    if (memberType.Contains("VIP"))
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange/Gold
                        e.CellStyle.Font = new Font(dgvCustomers.Font, FontStyle.Bold);
                    }
                    else if (memberType.Contains("Thường xuyên"))
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(107, 114, 128); // Gray
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvCustomers_CellFormatting: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (customerData == null || lblTotalCustomers == null) return;

                int totalCustomers = customerData.Rows.Count;
                int newCustomers = 0;
                int regularCustomers = 0;
                int vipCustomers = 0;
                decimal totalRevenue = 0;
                decimal averageRevenue = 0;

                foreach (DataRow row in customerData.Rows)
                {
                    string memberType = row["MemberType"].ToString();
                    if (memberType.Contains("Mới"))
                        newCustomers++;
                    else if (memberType.Contains("Thường xuyên"))
                        regularCustomers++;
                    else if (memberType.Contains("VIP"))
                        vipCustomers++;

                    if (row["TotalSpent"] != DBNull.Value)
                    {
                        totalRevenue += Convert.ToDecimal(row["TotalSpent"]);
                    }
                }

                if (totalCustomers > 0)
                {
                    averageRevenue = totalRevenue / totalCustomers;
                }

                // Update labels
                if (lblTotalCustomers != null)
                {
                    lblTotalCustomers.Text = $"👥\r\nTổng khách hàng:\r\n{totalCustomers} khách hàng\r\n(🆕 {newCustomers} | ⭐ {regularCustomers} | 👑 {vipCustomers})";
                }
                if (lblTotalRevenue != null)
                {
                    lblTotalRevenue.Text = $"💰\r\nTổng doanh thu:\r\n{totalRevenue:N0} đ\r\n";
                }
                if (lblAverageRevenue != null)
                {
                    lblAverageRevenue.Text = $"📊\r\nDoanh thu TB/KH:\r\n{averageRevenue:N0} đ\r\n";
                }
                if (lblVIPCustomers != null)
                {
                    lblVIPCustomers.Text = $"👑\r\nSố khách VIP:\r\n{vipCustomers} khách hàng\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open customer edit form for adding
                MessageBox.Show("Chức năng thêm khách hàng sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddCustomer_Click: {ex.Message}");
            }
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    // TODO: Open customer edit form for editing
                    MessageBox.Show("Chức năng sửa khách hàng sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditCustomer_Click: {ex.Message}");
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: Delete customer
                        MessageBox.Show("Chức năng xóa khách hàng sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteCustomer_Click: {ex.Message}");
            }
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    // TODO: Open customer detail form
                    MessageBox.Show("Chức năng xem chi tiết khách hàng sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                FilterCustomers();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TxtSearch_TextChanged: {ex.Message}");
            }
        }

        private void CmbMemberTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterCustomers();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbMemberTypeFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterCustomers();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CmbStatusFilter_SelectedIndexChanged: {ex.Message}");
            }
        }

        private void FilterCustomers()
        {
            try
            {
                if (customerData == null || dgvCustomers == null) return;

                string searchText = txtSearch?.Text?.ToLower() ?? "";
                string memberTypeFilter = cmbMemberTypeFilter?.SelectedItem?.ToString() ?? "Tất cả";
                string statusFilter = cmbStatusFilter?.SelectedItem?.ToString() ?? "Tất cả";

                DataView dv = customerData.DefaultView;
                string filter = "";

                if (!string.IsNullOrEmpty(searchText))
                {
                    filter += $"(FullName LIKE '%{searchText}%' OR Phone LIKE '%{searchText}%' OR Email LIKE '%{searchText}%')";
                }

                if (memberTypeFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"MemberType = '{memberTypeFilter}'";
                }

                if (statusFilter != "Tất cả")
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"Status = '{statusFilter}'";
                }

                dv.RowFilter = filter;
                dgvCustomers.DataSource = dv;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterCustomers: {ex.Message}");
            }
        }
    }
}

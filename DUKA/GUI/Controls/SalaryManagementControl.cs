using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class SalaryManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable salaryData;

        public SalaryManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += SalaryManagementControl_Load;
            }
        }

        private void SalaryManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvSalaries != null)
                            {
                                cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
                                cmbYear.Text = DateTime.Now.Year.ToString();
                                LoadSampleData();
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
                System.Diagnostics.Debug.WriteLine($"Error in SalaryManagementControl_Load: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvSalaries == null) return;

                dgvSalaries.AutoGenerateColumns = true;

                salaryData = new DataTable();
                salaryData.Columns.Add("SalaryCode", typeof(string));
                salaryData.Columns.Add("EmployeeName", typeof(string));
                salaryData.Columns.Add("Month", typeof(string));
                salaryData.Columns.Add("Year", typeof(string));
                salaryData.Columns.Add("BaseSalary", typeof(string));
                salaryData.Columns.Add("CompletedShifts", typeof(string));
                salaryData.Columns.Add("AbsentShifts", typeof(string));
                salaryData.Columns.Add("OvertimeHours", typeof(string));
                salaryData.Columns.Add("Bonus", typeof(string));
                salaryData.Columns.Add("Deduction", typeof(string));
                salaryData.Columns.Add("TotalSalary", typeof(string));
                salaryData.Columns.Add("Status", typeof(string));

                salaryData.Rows.Add("LUONG001", "Nguyễn Văn An", "12", "2024", "8.000.000 đ", "26", "0", "8", "500.000 đ", "0 đ", "10.400.000 đ", "Đã thanh toán");
                salaryData.Rows.Add("LUONG002", "Trần Thị Bình", "12", "2024", "15.000.000 đ", "26", "0", "4", "1.000.000 đ", "0 đ", "19.500.000 đ", "Đã thanh toán");
                salaryData.Rows.Add("LUONG003", "Lê Văn Cường", "12", "2024", "10.000.000 đ", "24", "2", "0", "0 đ", "200.000 đ", "12.000.000 đ", "Đã duyệt");
                salaryData.Rows.Add("LUONG004", "Phạm Thị Dung", "01", "2025", "9.000.000 đ", "22", "0", "0", "0 đ", "0 đ", "9.000.000 đ", "Chờ duyệt");

                dgvSalaries.DataBindingComplete -= DgvSalaries_DataBindingComplete;
                dgvSalaries.DataBindingComplete += DgvSalaries_DataBindingComplete;

                dgvSalaries.DataSource = null;
                dgvSalaries.DataSource = salaryData;
                dgvSalaries.Refresh();

                UpdateStatistics();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                if (salaryData == null || lblTotalSalarySheets == null) return;

                int totalSheets = salaryData.Rows.Count;
                int pendingApproval = 0;
                int approved = 0;
                int paid = 0;

                foreach (DataRow row in salaryData.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Chờ duyệt")
                    {
                        pendingApproval++;
                    }
                    else if (status == "Đã duyệt")
                    {
                        approved++;
                    }
                    else if (status == "Đã thanh toán")
                    {
                        paid++;
                    }
                }

                if (lblTotalSalarySheets != null)
                {
                    lblTotalSalarySheets.Text = $"📋\r\nTổng bảng lương:\r\n{totalSheets} bảng\r\n";
                }
                if (lblPendingApproval != null)
                {
                    lblPendingApproval.Text = $"⏳\r\nChờ duyệt:\r\n{pendingApproval} bảng\r\n";
                }
                if (lblApproved != null)
                {
                    lblApproved.Text = $"✅\r\nĐã duyệt:\r\n{approved} bảng\r\n";
                }
                if (lblPaid != null)
                {
                    lblPaid.Text = $"💰\r\nĐã thanh toán:\r\n{paid} bảng\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void DgvSalaries_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvSalaries != null && dgvSalaries.Columns != null && dgvSalaries.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvSalaries_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvSalaries == null || dgvSalaries.Columns == null || dgvSalaries.Columns.Count == 0) return;

            try
            {
                if (dgvSalaries.Columns["SalaryCode"] != null)
                {
                    dgvSalaries.Columns["SalaryCode"].HeaderText = "Mã lương";
                    dgvSalaries.Columns["SalaryCode"].Width = 120;
                }
                if (dgvSalaries.Columns["EmployeeName"] != null)
                {
                    dgvSalaries.Columns["EmployeeName"].HeaderText = "Nhân viên";
                    dgvSalaries.Columns["EmployeeName"].Width = 150;
                }
                if (dgvSalaries.Columns["Month"] != null)
                {
                    dgvSalaries.Columns["Month"].HeaderText = "Tháng";
                    dgvSalaries.Columns["Month"].Width = 80;
                }
                if (dgvSalaries.Columns["Year"] != null)
                {
                    dgvSalaries.Columns["Year"].HeaderText = "Năm";
                    dgvSalaries.Columns["Year"].Width = 80;
                }
                if (dgvSalaries.Columns["BaseSalary"] != null)
                {
                    dgvSalaries.Columns["BaseSalary"].HeaderText = "Lương cơ bản";
                    dgvSalaries.Columns["BaseSalary"].Width = 140;
                }
                if (dgvSalaries.Columns["CompletedShifts"] != null)
                {
                    dgvSalaries.Columns["CompletedShifts"].HeaderText = "Ca hoàn thành";
                    dgvSalaries.Columns["CompletedShifts"].Width = 120;
                }
                if (dgvSalaries.Columns["AbsentShifts"] != null)
                {
                    dgvSalaries.Columns["AbsentShifts"].HeaderText = "Ca vắng mặt";
                    dgvSalaries.Columns["AbsentShifts"].Width = 120;
                }
                if (dgvSalaries.Columns["OvertimeHours"] != null)
                {
                    dgvSalaries.Columns["OvertimeHours"].HeaderText = "Tăng ca";
                    dgvSalaries.Columns["OvertimeHours"].Width = 90;
                }
                if (dgvSalaries.Columns["Bonus"] != null)
                {
                    dgvSalaries.Columns["Bonus"].HeaderText = "Thưởng";
                    dgvSalaries.Columns["Bonus"].Width = 120;
                }
                if (dgvSalaries.Columns["Deduction"] != null)
                {
                    dgvSalaries.Columns["Deduction"].HeaderText = "Khấu trừ";
                    dgvSalaries.Columns["Deduction"].Width = 120;
                }
                if (dgvSalaries.Columns["TotalSalary"] != null)
                {
                    dgvSalaries.Columns["TotalSalary"].HeaderText = "Tổng lương";
                    dgvSalaries.Columns["TotalSalary"].Width = 140;
                }
                if (dgvSalaries.Columns["Status"] != null)
                {
                    dgvSalaries.Columns["Status"].HeaderText = "Trạng thái";
                    dgvSalaries.Columns["Status"].Width = 130;
                }

                dgvSalaries.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvSalaries.GridColor = Color.FromArgb(229, 231, 235);
                dgvSalaries.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvSalaries.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvSalaries.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvSalaries.CellFormatting -= DgvSalaries_CellFormatting;
                dgvSalaries.CellFormatting += DgvSalaries_CellFormatting;

                // Setup event handlers
                if (btnCalculate != null)
                {
                    btnCalculate.Click -= BtnCalculate_Click;
                    btnCalculate.Click += BtnCalculate_Click;
                }
                if (btnApprove != null)
                {
                    btnApprove.Click -= BtnApprove_Click;
                    btnApprove.Click += BtnApprove_Click;
                }
                if (btnExport != null)
                {
                    btnExport.Click -= BtnExport_Click;
                    btnExport.Click += BtnExport_Click;
                }
                if (btnEditSalary != null)
                {
                    btnEditSalary.Click -= BtnEditSalary_Click;
                    btnEditSalary.Click += BtnEditSalary_Click;
                }
                if (btnDeleteSalary != null)
                {
                    btnDeleteSalary.Click -= BtnDeleteSalary_Click;
                    btnDeleteSalary.Click += BtnDeleteSalary_Click;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvSalaries.SelectedRows[0];
                    
                    // Get employee data
                    string employeeName = selectedRow.Cells["EmployeeName"].Value?.ToString() ?? "";
                    string baseSalaryStr = selectedRow.Cells["BaseSalary"].Value?.ToString().Replace(" đ", "").Replace(".", "").Replace(",", "") ?? "0";
                    string completedShiftsStr = selectedRow.Cells["CompletedShifts"].Value?.ToString() ?? "0";
                    string absentShiftsStr = selectedRow.Cells["AbsentShifts"].Value?.ToString() ?? "0";
                    string overtimeStr = selectedRow.Cells["OvertimeHours"].Value?.ToString() ?? "0";
                    string bonusStr = selectedRow.Cells["Bonus"].Value?.ToString().Replace(" đ", "").Replace(".", "").Replace(",", "") ?? "0";
                    string deductionStr = selectedRow.Cells["Deduction"].Value?.ToString().Replace(" đ", "").Replace(".", "").Replace(",", "") ?? "0";

                    if (decimal.TryParse(baseSalaryStr, out decimal baseSalary) &&
                        int.TryParse(completedShiftsStr, out int completedShifts) &&
                        int.TryParse(absentShiftsStr, out int absentShifts) &&
                        int.TryParse(overtimeStr, out int overtimeHours) &&
                        decimal.TryParse(bonusStr, out decimal bonus) &&
                        decimal.TryParse(deductionStr, out decimal deduction))
                    {
                        // Calculate salary: Base + (Completed shifts * daily rate) - (Absent shifts * daily rate) + Overtime + Bonus - Deduction
                        decimal dailyRate = baseSalary / 26; // Assuming 26 working days per month
                        decimal shiftBonus = completedShifts * dailyRate;
                        decimal shiftDeduction = absentShifts * dailyRate;
                        decimal overtimePay = overtimeHours * (dailyRate / 8) * 1.5m; // 1.5x for overtime
                        decimal totalSalary = baseSalary + shiftBonus - shiftDeduction + overtimePay + bonus - deduction;

                        selectedRow.Cells["TotalSalary"].Value = $"{totalSalary:N0} đ";
                        selectedRow.Cells["Status"].Value = "Chờ duyệt";
                        UpdateStatistics();
                        
                        MessageBox.Show($"Tính lương thành công!\nTổng lương: {totalSalary:N0} đ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảng lương cần tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnCalculate_Click: {ex.Message}");
                MessageBox.Show($"Lỗi khi tính lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvSalaries.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Chờ duyệt")
                    {
                        selectedRow.Cells["Status"].Value = "Đã duyệt";
                        UpdateStatistics();
                        MessageBox.Show("Duyệt bảng lương thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (status == "Đã duyệt")
                    {
                        selectedRow.Cells["Status"].Value = "Đã thanh toán";
                        UpdateStatistics();
                        MessageBox.Show("Xác nhận thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bảng lương này không thể duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảng lương cần duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnApprove_Click: {ex.Message}");
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Export to Excel
                MessageBox.Show("Chức năng xuất Excel sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnExport_Click: {ex.Message}");
            }
        }

        private void BtnEditSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    // TODO: Open salary detail form for editing
                    MessageBox.Show("Chức năng sửa bảng lương sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảng lương cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditSalary_Click: {ex.Message}");
            }
        }

        private void BtnDeleteSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa bảng lương này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: Delete salary
                        MessageBox.Show("Chức năng xóa bảng lương sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bảng lương cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteSalary_Click: {ex.Message}");
            }
        }

        private void DgvSalaries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvSalaries == null || dgvSalaries.Columns == null) return;

                var statusCol = dgvSalaries.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Đã thanh toán")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Đã duyệt")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                    }
                    else if (status == "Chờ duyệt")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(107, 114, 128); // Gray
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvSalaries_CellFormatting: {ex.Message}");
            }
        }
    }
}


using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class ShiftManagementControl : UserControl
    {
        private bool isInitialized = false;
        private DataTable shiftData;

        public ShiftManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += ShiftManagementControl_Load;
            }
        }

        private void ShiftManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvShifts != null)
                            {
                                dtpFilterDate.Value = DateTime.Today;
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
                System.Diagnostics.Debug.WriteLine($"Error in ShiftManagementControl_Load: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvShifts == null) return;

                dgvShifts.AutoGenerateColumns = true;

                shiftData = new DataTable();
                shiftData.Columns.Add("ShiftCode", typeof(string));
                shiftData.Columns.Add("EmployeeName", typeof(string));
                shiftData.Columns.Add("WorkDate", typeof(string));
                shiftData.Columns.Add("StartTime", typeof(string));
                shiftData.Columns.Add("EndTime", typeof(string));
                shiftData.Columns.Add("CheckInTime", typeof(string));
                shiftData.Columns.Add("CheckOutTime", typeof(string));
                shiftData.Columns.Add("Hours", typeof(string));
                shiftData.Columns.Add("Status", typeof(string));
                shiftData.Columns.Add("Notes", typeof(string));

                shiftData.Rows.Add("CA001", "Nguyễn Văn An", "15/01/2025", "08:00", "16:00", "08:05", "16:00", "8 giờ", "Hoàn thành", "Ca làm việc bình thường");
                shiftData.Rows.Add("CA002", "Trần Thị Bình", "15/01/2025", "16:00", "24:00", "16:02", "24:00", "8 giờ", "Hoàn thành", "");
                shiftData.Rows.Add("CA003", "Lê Văn Cường", "16/01/2025", "08:00", "16:00", "", "", "8 giờ", "Đã lên lịch", "");
                shiftData.Rows.Add("CA004", "Nguyễn Văn An", "16/01/2025", "16:00", "24:00", "", "", "8 giờ", "Đã lên lịch", "");
                shiftData.Rows.Add("CA005", "Phạm Thị Dung", "17/01/2025", "08:00", "16:00", "", "", "8 giờ", "Đã lên lịch", "");

                dgvShifts.DataBindingComplete -= DgvShifts_DataBindingComplete;
                dgvShifts.DataBindingComplete += DgvShifts_DataBindingComplete;

                dgvShifts.DataSource = null;
                dgvShifts.DataSource = shiftData;
                dgvShifts.Refresh();

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
                if (shiftData == null || lblTotalShifts == null) return;

                int totalShifts = shiftData.Rows.Count;
                int scheduled = 0;
                int completed = 0;
                int absent = 0;

                foreach (DataRow row in shiftData.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Đã lên lịch")
                    {
                        scheduled++;
                    }
                    else if (status == "Hoàn thành")
                    {
                        completed++;
                    }
                    else if (status == "Vắng mặt")
                    {
                        absent++;
                    }
                }

                if (lblTotalShifts != null)
                {
                    lblTotalShifts.Text = $"⏰\r\nTổng ca:\r\n{totalShifts} ca làm\r\n";
                }
                if (lblScheduledShifts != null)
                {
                    lblScheduledShifts.Text = $"📅\r\nĐã lên lịch:\r\n{scheduled} ca\r\n";
                }
                if (lblCompletedShifts != null)
                {
                    lblCompletedShifts.Text = $"✅\r\nHoàn thành:\r\n{completed} ca\r\n";
                }
                if (lblAbsentShifts != null)
                {
                    lblAbsentShifts.Text = $"❌\r\nVắng mặt:\r\n{absent} ca\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void DgvShifts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvShifts != null && dgvShifts.Columns != null && dgvShifts.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvShifts_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvShifts == null || dgvShifts.Columns == null || dgvShifts.Columns.Count == 0) return;

            try
            {
                if (dgvShifts.Columns["ShiftCode"] != null)
                {
                    dgvShifts.Columns["ShiftCode"].HeaderText = "Mã ca";
                    dgvShifts.Columns["ShiftCode"].Width = 100;
                }
                if (dgvShifts.Columns["EmployeeName"] != null)
                {
                    dgvShifts.Columns["EmployeeName"].HeaderText = "Nhân viên";
                    dgvShifts.Columns["EmployeeName"].Width = 150;
                }
                if (dgvShifts.Columns["WorkDate"] != null)
                {
                    dgvShifts.Columns["WorkDate"].HeaderText = "Ngày làm";
                    dgvShifts.Columns["WorkDate"].Width = 120;
                }
                if (dgvShifts.Columns["StartTime"] != null)
                {
                    dgvShifts.Columns["StartTime"].HeaderText = "Giờ bắt đầu";
                    dgvShifts.Columns["StartTime"].Width = 120;
                }
                if (dgvShifts.Columns["EndTime"] != null)
                {
                    dgvShifts.Columns["EndTime"].HeaderText = "Giờ kết thúc";
                    dgvShifts.Columns["EndTime"].Width = 120;
                }
                if (dgvShifts.Columns["Hours"] != null)
                {
                    dgvShifts.Columns["Hours"].HeaderText = "Số giờ";
                    dgvShifts.Columns["Hours"].Width = 100;
                }
                if (dgvShifts.Columns["Status"] != null)
                {
                    dgvShifts.Columns["Status"].HeaderText = "Trạng thái";
                    dgvShifts.Columns["Status"].Width = 120;
                }
                if (dgvShifts.Columns["CheckInTime"] != null)
                {
                    dgvShifts.Columns["CheckInTime"].HeaderText = "Check-in";
                    dgvShifts.Columns["CheckInTime"].Width = 100;
                }
                if (dgvShifts.Columns["CheckOutTime"] != null)
                {
                    dgvShifts.Columns["CheckOutTime"].HeaderText = "Check-out";
                    dgvShifts.Columns["CheckOutTime"].Width = 100;
                }
                if (dgvShifts.Columns["Notes"] != null)
                {
                    dgvShifts.Columns["Notes"].HeaderText = "Ghi chú";
                    dgvShifts.Columns["Notes"].Width = 200;
                }

                dgvShifts.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvShifts.GridColor = Color.FromArgb(229, 231, 235);
                dgvShifts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvShifts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvShifts.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvShifts.CellFormatting -= DgvShifts_CellFormatting;
                dgvShifts.CellFormatting += DgvShifts_CellFormatting;

                // Setup event handlers
                if (btnAddShift != null)
                {
                    btnAddShift.Click -= BtnAddShift_Click;
                    btnAddShift.Click += BtnAddShift_Click;
                }
                if (btnEditShift != null)
                {
                    btnEditShift.Click -= BtnEditShift_Click;
                    btnEditShift.Click += BtnEditShift_Click;
                }
                if (btnDeleteShift != null)
                {
                    btnDeleteShift.Click -= BtnDeleteShift_Click;
                    btnDeleteShift.Click += BtnDeleteShift_Click;
                }
                if (btnCheckIn != null)
                {
                    btnCheckIn.Click -= BtnCheckIn_Click;
                    btnCheckIn.Click += BtnCheckIn_Click;
                }
                if (btnCheckOut != null)
                {
                    btnCheckOut.Click -= BtnCheckOut_Click;
                    btnCheckOut.Click += BtnCheckOut_Click;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void BtnAddShift_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open shift detail form for adding
                MessageBox.Show("Chức năng thêm ca làm việc sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddShift_Click: {ex.Message}");
            }
        }

        private void BtnEditShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShifts.SelectedRows.Count > 0)
                {
                    // TODO: Open shift detail form for editing (with notes field)
                    MessageBox.Show("Chức năng sửa ca làm việc sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditShift_Click: {ex.Message}");
            }
        }

        private void BtnDeleteShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShifts.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ca làm việc này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: Delete shift
                        MessageBox.Show("Chức năng xóa ca làm việc sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteShift_Click: {ex.Message}");
            }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShifts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvShifts.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Đã lên lịch")
                    {
                        string checkInTime = DateTime.Now.ToString("HH:mm");
                        selectedRow.Cells["CheckInTime"].Value = checkInTime;
                        selectedRow.Cells["Status"].Value = "Đang làm việc";
                        UpdateStatistics();
                        MessageBox.Show($"Check-in thành công lúc {checkInTime}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể check-in cho ca đã lên lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần check-in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnCheckIn_Click: {ex.Message}");
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShifts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvShifts.SelectedRows[0];
                    string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";
                    
                    if (status == "Đang làm việc" || status == "Đã lên lịch")
                    {
                        string checkOutTime = DateTime.Now.ToString("HH:mm");
                        selectedRow.Cells["CheckOutTime"].Value = checkOutTime;
                        selectedRow.Cells["Status"].Value = "Hoàn thành";
                        UpdateStatistics();
                        MessageBox.Show($"Check-out thành công lúc {checkOutTime}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể check-out cho ca đang làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần check-out", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnCheckOut_Click: {ex.Message}");
            }
        }

        private void DgvShifts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvShifts == null || dgvShifts.Columns == null) return;

                var statusCol = dgvShifts.Columns["Status"];
                if (statusCol != null && 
                    e.ColumnIndex >= 0 && e.ColumnIndex == statusCol.Index && 
                    e.Value != null)
                {
                    var status = e.Value.ToString();
                    if (status == "Hoàn thành")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                    }
                    else if (status == "Đã lên lịch")
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
                System.Diagnostics.Debug.WriteLine($"Error in DgvShifts_CellFormatting: {ex.Message}");
            }
        }
    }
}


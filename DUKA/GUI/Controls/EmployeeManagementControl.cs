using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class EmployeeManagementControl : UserControl
    {
        public EmployeeManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += EmployeeManagementControl_Load;
            }
        }

        private void EmployeeManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvEmployees != null)
                            {
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
                System.Diagnostics.Debug.WriteLine($"Error in EmployeeManagementControl_Load: {ex.Message}");
            }
        }

        private bool isInitialized = false;

        private DataTable employeeData;

        private void LoadSampleData()
        {
            try
            {
                if (dgvEmployees == null) return;

                dgvEmployees.AutoGenerateColumns = true;

                // Dữ liệu nhân viên
                employeeData = new DataTable();
                employeeData.Columns.Add("EmployeeCode", typeof(string));
                employeeData.Columns.Add("FullName", typeof(string));
                employeeData.Columns.Add("Phone", typeof(string));
                employeeData.Columns.Add("Email", typeof(string));
                employeeData.Columns.Add("Position", typeof(string));
                employeeData.Columns.Add("BaseSalary", typeof(string));
                employeeData.Columns.Add("IsActive", typeof(string));

                employeeData.Rows.Add("NV001", "Nguyễn Văn An", "0911111111", "nguyenvanan@duka.com", "Lễ tân", "8.000.000 đ", "Hoạt động");
                employeeData.Rows.Add("NV002", "Trần Thị Bình", "0922222222", "tranthibinh@duka.com", "Quản lý", "15.000.000 đ", "Hoạt động");
                employeeData.Rows.Add("NV003", "Lê Văn Cường", "0933333333", "levancuong@duka.com", "Bảo trì", "10.000.000 đ", "Hoạt động");
                employeeData.Rows.Add("NV004", "Phạm Thị Dung", "0944444444", "phamthidung@duka.com", "Lễ tân", "8.000.000 đ", "Hoạt động");
                employeeData.Rows.Add("NV005", "Hoàng Văn Em", "0955555555", "hoangvanem@duka.com", "Nhân viên", "7.000.000 đ", "Hoạt động");

                dgvEmployees.DataBindingComplete -= DgvEmployees_DataBindingComplete;
                dgvEmployees.DataBindingComplete += DgvEmployees_DataBindingComplete;

                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = employeeData;
                dgvEmployees.Refresh();

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
                if (employeeData == null || lblTotalEmployees == null) return;

                int totalEmployees = employeeData.Rows.Count;
                int managers = 0;
                decimal totalSalary = 0;
                decimal averageSalary = 0;

                foreach (DataRow row in employeeData.Rows)
                {
                    if (row["Position"].ToString() == "Quản lý")
                    {
                        managers++;
                    }

                    string salaryStr = row["BaseSalary"].ToString().Replace(" đ", "").Replace(".", "").Replace(",", "");
                    if (decimal.TryParse(salaryStr, out decimal salary))
                    {
                        totalSalary += salary;
                    }
                }

                if (totalEmployees > 0)
                {
                    averageSalary = totalSalary / totalEmployees;
                }

                // Update labels
                if (lblTotalEmployees != null)
                {
                    lblTotalEmployees.Text = $"👥\r\nTổng nhân viên:\r\n{totalEmployees} nhân viên\r\n";
                }
                if (lblManagers != null)
                {
                    lblManagers.Text = $"👔\r\nQuản lý:\r\n{managers} người\r\n";
                }
                if (lblTotalSalary != null)
                {
                    lblTotalSalary.Text = $"💰\r\nTổng lương:\r\n{totalSalary:N0} đ\r\n";
                }
                if (lblAverageSalary != null)
                {
                    lblAverageSalary.Text = $"📊\r\nLương trung bình:\r\n{averageSalary:N0} đ\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateStatistics: {ex.Message}");
            }
        }

        private void DgvEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvEmployees != null && dgvEmployees.Columns != null && dgvEmployees.Columns.Count > 0)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvEmployees_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvEmployees == null || dgvEmployees.Columns == null || dgvEmployees.Columns.Count == 0) return;

            try
            {
                if (dgvEmployees.Columns["EmployeeCode"] != null)
                {
                    dgvEmployees.Columns["EmployeeCode"].HeaderText = "Mã nhân viên";
                    dgvEmployees.Columns["EmployeeCode"].Width = 120;
                }
                if (dgvEmployees.Columns["FullName"] != null)
                {
                    dgvEmployees.Columns["FullName"].HeaderText = "Họ tên";
                    dgvEmployees.Columns["FullName"].Width = 180;
                }
                if (dgvEmployees.Columns["Phone"] != null)
                {
                    dgvEmployees.Columns["Phone"].HeaderText = "Số điện thoại";
                    dgvEmployees.Columns["Phone"].Width = 130;
                }
                if (dgvEmployees.Columns["Email"] != null)
                {
                    dgvEmployees.Columns["Email"].HeaderText = "Email";
                    dgvEmployees.Columns["Email"].Width = 200;
                }
                if (dgvEmployees.Columns["Position"] != null)
                {
                    dgvEmployees.Columns["Position"].HeaderText = "Chức vụ";
                    dgvEmployees.Columns["Position"].Width = 120;
                }
                if (dgvEmployees.Columns["BaseSalary"] != null)
                {
                    dgvEmployees.Columns["BaseSalary"].HeaderText = "Lương cơ bản";
                    dgvEmployees.Columns["BaseSalary"].Width = 150;
                }
                if (dgvEmployees.Columns["IsActive"] != null)
                {
                    dgvEmployees.Columns["IsActive"].HeaderText = "Trạng thái";
                    dgvEmployees.Columns["IsActive"].Width = 120;
                }

                dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvEmployees.GridColor = Color.FromArgb(229, 231, 235);
                dgvEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                dgvEmployees.CellFormatting -= DgvEmployees_CellFormatting;
                dgvEmployees.CellFormatting += DgvEmployees_CellFormatting;

                // Setup CRUD event handlers
                if (btnAddEmployee != null)
                {
                    btnAddEmployee.Click -= BtnAddEmployee_Click;
                    btnAddEmployee.Click += BtnAddEmployee_Click;
                }
                if (btnEditEmployee != null)
                {
                    btnEditEmployee.Click -= BtnEditEmployee_Click;
                    btnEditEmployee.Click += BtnEditEmployee_Click;
                }
                if (btnDeleteEmployee != null)
                {
                    btnDeleteEmployee.Click -= BtnDeleteEmployee_Click;
                    btnDeleteEmployee.Click += BtnDeleteEmployee_Click;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Open employee detail form for adding
                MessageBox.Show("Chức năng thêm nhân viên sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnAddEmployee_Click: {ex.Message}");
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    // TODO: Open employee detail form for editing
                    MessageBox.Show("Chức năng sửa nhân viên sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnEditEmployee_Click: {ex.Message}");
            }
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // TODO: Delete employee
                        MessageBox.Show("Chức năng xóa nhân viên sẽ được triển khai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in BtnDeleteEmployee_Click: {ex.Message}");
            }
        }

        private void DgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvEmployees == null || dgvEmployees.Columns == null) return;

                var statusCol = dgvEmployees.Columns["IsActive"];
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
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvEmployees_CellFormatting: {ex.Message}");
            }
        }
    }
}

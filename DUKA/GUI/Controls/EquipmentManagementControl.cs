using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class EquipmentManagementControl : UserControl
    {
        private bool isInitialized = false;

        public EquipmentManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
        {
                this.Load += EquipmentManagementControl_Load;
            }
        }

        private void EquipmentManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvEquipment != null && dgvMaintenance != null)
                            {
                                LoadSampleData();
                                // FormatDataGridViews() is no longer needed - formatting happens in DataBindingComplete events
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
                System.Diagnostics.Debug.WriteLine($"Error in EquipmentManagementControl_Load: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
        {
            // Dữ liệu thiết bị
                if (dgvEquipment != null && dgvEquipment.IsHandleCreated)
                {
                    dgvEquipment.AutoGenerateColumns = true;
                    
                    // Unsubscribe first to avoid duplicate subscriptions
                    dgvEquipment.DataBindingComplete -= DgvEquipment_DataBindingComplete;
                    dgvEquipment.DataBindingComplete += DgvEquipment_DataBindingComplete;
                    
            DataTable dtEquipment = new DataTable();
            dtEquipment.Columns.Add("EquipmentCode", typeof(string));
            dtEquipment.Columns.Add("EquipmentName", typeof(string));
            dtEquipment.Columns.Add("EquipmentType", typeof(string));
            dtEquipment.Columns.Add("FieldName", typeof(string));
            dtEquipment.Columns.Add("Quantity", typeof(string));
            dtEquipment.Columns.Add("Status", typeof(string));

                    dtEquipment.Rows.Add("TB001", "Đèn chiếu sáng", "Đèn", "Sân A- Sân chính", "8", "Tốt");
                    dtEquipment.Rows.Add("TB002", "Khung thành", "Khung thành", "Sân B- Sân phụ", "2", "Tốt");
                    dtEquipment.Rows.Add("TB003", "Lưới", "Lưới", "Tất cả sân", "10", "Tốt");
                    dtEquipment.Rows.Add("TB004", "Máy bơm nước", "Máy bơm", "Sân C - Sân Vip", "1", "Cần sửa chữa");
                    dtEquipment.Rows.Add("TB005", "Quạt gió", "Quạt", "Sân D- Sân phụ", "4", "Tốt");

                    dgvEquipment.DataSource = null;
                    dgvEquipment.Refresh();
                    
                    // Set data source
            dgvEquipment.DataSource = dtEquipment;
                }
            // Dữ liệu bảo trì
                if (dgvMaintenance != null && dgvMaintenance.IsHandleCreated)
                {
                    dgvMaintenance.AutoGenerateColumns = true;
                    
                    // Unsubscribe first to avoid duplicate subscriptions
                    dgvMaintenance.DataBindingComplete -= DgvMaintenance_DataBindingComplete;
                    dgvMaintenance.DataBindingComplete += DgvMaintenance_DataBindingComplete;
                    
            DataTable dtMaintenance = new DataTable();
            dtMaintenance.Columns.Add("MaintenanceCode", typeof(string));
            dtMaintenance.Columns.Add("Description", typeof(string));
            dtMaintenance.Columns.Add("FieldName", typeof(string));
            dtMaintenance.Columns.Add("AssignedTo", typeof(string));
            dtMaintenance.Columns.Add("Cost", typeof(string));
            dtMaintenance.Columns.Add("Status", typeof(string));

                    dtMaintenance.Rows.Add("BT001", "Thay lưới sân A", "Sân A- Sân chính", "Lê Văn Cường", "500.000 đ", "Hoàn thành");
                    dtMaintenance.Rows.Add("BT002", "Sửa đèn sân B", "Sân B- Sân phụ", "Lê Văn Cường", "1.200.000 đ", "Đang thực hiện");
                    dtMaintenance.Rows.Add("BT003", "Bảo dưỡng máy bơm", "Sân C - Sân Vip", "Lê Văn Cường", "800.000 đ", "Chờ xử lý");
                    dtMaintenance.Rows.Add("BT004", "Kiểm tra quạt gió", "Sân D- Sân phụ", "Nguyễn Văn A", "200.000 đ", "Hoàn thành");

                    dgvMaintenance.DataSource = null;
                    dgvMaintenance.Refresh();
                    
                    // Set data source
            dgvMaintenance.DataSource = dtMaintenance;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void DgvEquipment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                var dgv = sender as DataGridView;
                if (dgv == null || dgv.Columns == null || dgv.Columns.Count == 0) return;
                
                if (this.IsHandleCreated)
                {
                    // Use BeginInvoke to ensure columns are fully created
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (dgvEquipment != null && dgvEquipment.IsHandleCreated && 
                                dgvEquipment.Columns != null && dgvEquipment.Columns.Count > 0)
                            {
                                FormatEquipmentGrid();
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke FormatEquipmentGrid: {ex.Message}");
                            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                        }
                    }));
                }
                else
                {
                    // If handle not created, try direct formatting
                    if (dgvEquipment != null && dgvEquipment.Columns != null && dgvEquipment.Columns.Count > 0)
                    {
                        FormatEquipmentGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvEquipment_DataBindingComplete: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void DgvMaintenance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                var dgv = sender as DataGridView;
                if (dgv == null || dgv.Columns == null || dgv.Columns.Count == 0) return;
                
                if (this.IsHandleCreated)
                {
                    // Use BeginInvoke to ensure columns are fully created
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (dgvMaintenance != null && dgvMaintenance.IsHandleCreated && 
                                dgvMaintenance.Columns != null && dgvMaintenance.Columns.Count > 0)
                            {
                                FormatMaintenanceGrid();
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke FormatMaintenanceGrid: {ex.Message}");
                            System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                        }
                    }));
                }
                else
                {
                    // If handle not created, try direct formatting
                    if (dgvMaintenance != null && dgvMaintenance.Columns != null && dgvMaintenance.Columns.Count > 0)
                    {
                        FormatMaintenanceGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvMaintenance_DataBindingComplete: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
            }
        }

        private void FormatDataGridViews()
        {
            // This method is no longer needed as formatting is done in DataBindingComplete events
            // But keeping it for backward compatibility
        }

        private void FormatEquipmentGrid()
        {
            if (dgvEquipment == null) return;
            if (dgvEquipment.Columns == null || dgvEquipment.Columns.Count == 0) return;

            try
            {
                var equipmentCodeCol = dgvEquipment.Columns["EquipmentCode"];
                if (equipmentCodeCol != null)
                {
                    equipmentCodeCol.HeaderText = "Mã thiết bị";
                    equipmentCodeCol.Width = 120;
                }

                var equipmentNameCol = dgvEquipment.Columns["EquipmentName"];
                if (equipmentNameCol != null)
                {
                    equipmentNameCol.HeaderText = "Tên thiết bị";
                    equipmentNameCol.Width = 200;
                }

                var equipmentTypeCol = dgvEquipment.Columns["EquipmentType"];
                if (equipmentTypeCol != null)
                {
                    equipmentTypeCol.HeaderText = "Loại thiết bị";
                    equipmentTypeCol.Width = 150;
                }

                var fieldNameCol = dgvEquipment.Columns["FieldName"];
                if (fieldNameCol != null)
                {
                    fieldNameCol.HeaderText = "Sân";
                    fieldNameCol.Width = 180;
                }

                var quantityCol = dgvEquipment.Columns["Quantity"];
                if (quantityCol != null)
                {
                    quantityCol.HeaderText = "Số lượng";
                    quantityCol.Width = 100;
                }

                var statusCol = dgvEquipment.Columns["Status"];
                if (statusCol != null)
                {
                    statusCol.HeaderText = "Trạng thái";
                    statusCol.Width = 130;
                }

                dgvEquipment.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvEquipment.GridColor = Color.FromArgb(229, 231, 235);
                dgvEquipment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvEquipment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                if (dgvEquipment.Rows != null && dgvEquipment.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvEquipment.Rows)
                    {
                        if (row == null || row.Cells == null) continue;
                        
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null && cell.Style != null)
                            {
                                cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                            }
                        }
                    }
                }

                dgvEquipment.CellFormatting -= DgvEquipment_CellFormatting;
                dgvEquipment.CellFormatting += DgvEquipment_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting Equipment grid: {ex.Message}");
            }
        }

        private void FormatMaintenanceGrid()
        {
            if (dgvMaintenance == null) return;
            if (dgvMaintenance.Columns == null || dgvMaintenance.Columns.Count == 0) return;

            try
            {
                var maintenanceCodeCol = dgvMaintenance.Columns["MaintenanceCode"];
                if (maintenanceCodeCol != null)
                {
                    maintenanceCodeCol.HeaderText = "Mã bảo trì";
                    maintenanceCodeCol.Width = 120;
                }

                var descriptionCol = dgvMaintenance.Columns["Description"];
                if (descriptionCol != null)
                {
                    descriptionCol.HeaderText = "Mô tả";
                    descriptionCol.Width = 250;
                }

                var fieldNameCol = dgvMaintenance.Columns["FieldName"];
                if (fieldNameCol != null)
                {
                    fieldNameCol.HeaderText = "Sân";
                    fieldNameCol.Width = 180;
                }

                var assignedToCol = dgvMaintenance.Columns["AssignedTo"];
                if (assignedToCol != null)
                {
                    assignedToCol.HeaderText = "Người phụ trách";
                    assignedToCol.Width = 180;
                }

                var costCol = dgvMaintenance.Columns["Cost"];
                if (costCol != null)
                {
                    costCol.HeaderText = "Chi phí";
                    costCol.Width = 150;
                }

                var statusCol = dgvMaintenance.Columns["Status"];
                if (statusCol != null)
                {
                    statusCol.HeaderText = "Trạng thái";
                    statusCol.Width = 130;
                }

                dgvMaintenance.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvMaintenance.GridColor = Color.FromArgb(229, 231, 235);
                dgvMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                if (dgvMaintenance.Rows != null && dgvMaintenance.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvMaintenance.Rows)
                    {
                        if (row == null || row.Cells == null) continue;
                        
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null && cell.Style != null)
                            {
                                cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                            }
                        }
                    }
                }

                dgvMaintenance.CellFormatting -= DgvMaintenance_CellFormatting;
                dgvMaintenance.CellFormatting += DgvMaintenance_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting Maintenance grid: {ex.Message}");
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
                    else if (status == "Cần sửa chữa")
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
                    else if (status == "Chờ xử lý")
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
    }
}

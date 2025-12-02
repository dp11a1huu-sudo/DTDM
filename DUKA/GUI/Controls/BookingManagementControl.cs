using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class BookingManagementControl : UserControl
    {
        private bool isInitialized = false;

        public BookingManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += BookingManagementControl_Load;
            }
        }

        private void BookingManagementControl_Load(object sender, EventArgs e)
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
                            if (!isInitialized && dgvBookings != null)
                            {
                                LoadSampleData();
                                FormatDataGridView();
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
                System.Diagnostics.Debug.WriteLine($"Error in BookingManagementControl_Load: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvBookings == null) return;
                
                dgvBookings.AutoGenerateColumns = true;
                
            DataTable dt = new DataTable();
            dt.Columns.Add("BookingCode", typeof(string));
            dt.Columns.Add("FieldName", typeof(string));
            dt.Columns.Add("CustomerName", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("BookingDate", typeof(string));
                dt.Columns.Add("TimeSlot", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("PaymentMethod", typeof(string));
            dt.Columns.Add("Status", typeof(string));

                dt.Rows.Add("BK000001", "Sân A- Sân chính", "Nguyễn Văn A", "0912345678", "15/01/2025", "18:00 - 19:30", "300.000 đ", "Tiền mặt", "Đã thanh toán");
                dt.Rows.Add("BK000002", "Sân B- Sân phụ", "Trần Thị B", "0923456789", "15/01/2025", "19:30 - 21:00", "300.000 đ", "Chuyển khoản", "Đã thanh toán");
                dt.Rows.Add("BK000003", "Sân C - Sân Vip", "Lê Văn C", "0934567890", "15/01/2025", "20:00 - 21:30", "400.000 đ", "QR Code", "Đã xác nhận");
                dt.Rows.Add("BK000004", "Sân A- Sân chính", "Phạm Thị D", "0945678901", "16/01/2025", "18:00 - 19:30", "300.000 đ", "Tiền mặt", "Chờ thanh toán");
                dt.Rows.Add("BK000005", "Sân B- Sân phụ", "Hoàng Văn E", "0956789012", "16/01/2025", "19:00 - 20:30", "300.000 đ", "Chuyển khoản", "Chờ thanh toán");
                dt.Rows.Add("BK000006", "Sân D- Sân phụ", "Võ Thị F", "0967890123", "16/01/2025", "20:00 - 21:30", "300.000 đ", "QR Code", "Đã hủy");

                dgvBookings.DataBindingComplete -= DgvBookings_DataBindingComplete;
                dgvBookings.DataBindingComplete += DgvBookings_DataBindingComplete;
                
                dgvBookings.DataSource = null;
            dgvBookings.DataSource = dt;
                dgvBookings.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvBookings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvBookings != null)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvBookings_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvBookings == null || dgvBookings.Columns == null || dgvBookings.Columns.Count == 0) return;

            try
            {
                // Format columns
                if (dgvBookings.Columns["BookingCode"] != null)
                {
                    dgvBookings.Columns["BookingCode"].HeaderText = "Mã đặt";
                    dgvBookings.Columns["BookingCode"].Width = 120;
                }
                if (dgvBookings.Columns["FieldName"] != null)
                {
                    dgvBookings.Columns["FieldName"].HeaderText = "Tên sân";
                    dgvBookings.Columns["FieldName"].Width = 150;
                }
                if (dgvBookings.Columns["CustomerName"] != null)
                {
                    dgvBookings.Columns["CustomerName"].HeaderText = "Khách hàng";
                    dgvBookings.Columns["CustomerName"].Width = 150;
                }
                if (dgvBookings.Columns["Phone"] != null)
                {
                    dgvBookings.Columns["Phone"].HeaderText = "Số điện thoại";
                    dgvBookings.Columns["Phone"].Width = 130;
                }
                if (dgvBookings.Columns["BookingDate"] != null)
                {
                    dgvBookings.Columns["BookingDate"].HeaderText = "Ngày đặt";
                    dgvBookings.Columns["BookingDate"].Width = 120;
                }
                if (dgvBookings.Columns["TimeSlot"] != null)
                {
                    dgvBookings.Columns["TimeSlot"].HeaderText = "Khung giờ";
                    dgvBookings.Columns["TimeSlot"].Width = 150;
                }
                if (dgvBookings.Columns["Price"] != null)
                {
                    dgvBookings.Columns["Price"].HeaderText = "Giá tiền";
                    dgvBookings.Columns["Price"].Width = 120;
                }
                if (dgvBookings.Columns["PaymentMethod"] != null)
                {
                    dgvBookings.Columns["PaymentMethod"].HeaderText = "Phương thức";
                    dgvBookings.Columns["PaymentMethod"].Width = 130;
                }
                if (dgvBookings.Columns["Status"] != null)
                {
                    dgvBookings.Columns["Status"].HeaderText = "Trạng thái";
                    dgvBookings.Columns["Status"].Width = 130;
                }

                // Set border style
                dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvBookings.GridColor = Color.FromArgb(229, 231, 235);
                dgvBookings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                // Set selection color
                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }

                // Format status column
                dgvBookings.CellFormatting -= DgvBookings_CellFormatting;
                dgvBookings.CellFormatting += DgvBookings_CellFormatting;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }

        private void DgvBookings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBookings.Columns["Status"] != null && 
                e.ColumnIndex == dgvBookings.Columns["Status"].Index && 
                e.Value != null)
            {
                var status = e.Value.ToString();
                if (status == "Đã thanh toán")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129); // Green
                }
                else if (status == "Chờ thanh toán")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Orange
                }
                else if (status == "Đã xác nhận")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(59, 130, 246); // Blue
                }
                else if (status == "Đã hủy")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68); // Red
                }
            }
        }
    }
}

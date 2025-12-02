using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class BookingManagementForm : Form
    {
        private DataGridView dgvBookings;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnPayment;
        private Button btnRefresh;
        private DateTimePicker dtpFilterDate;
        private Label lblTitle;

        public BookingManagementForm()
        {
            InitializeComponent();
            dtpFilterDate.Value = DateTime.Today;
            LoadBookings();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.dgvBookings = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnCancel = new Button();
            this.btnPayment = new Button();
            this.btnRefresh = new Button();
            this.dtpFilterDate = new DateTimePicker();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(400, 36);
            this.lblTitle.Text = "📅 Đặt sân & Thanh toán";

            // Date Filter
            Label lblFilter = new Label();
            lblFilter.Text = "Lọc theo ngày:";
            lblFilter.Location = new Point(20, 70);
            lblFilter.Size = new Size(100, 20);
            dtpFilterDate.Location = new Point(130, 70);
            dtpFilterDate.Size = new Size(200, 22);
            dtpFilterDate.ValueChanged += (s, e) => LoadBookings();

            // dgvBookings
            this.dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.Location = new Point(20, 110);
            this.dgvBookings.Size = new Size(1100, 500);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.ReadOnly = true;

            // Buttons
            this.btnAdd.Location = new Point(20, 630);
            this.btnAdd.Size = new Size(120, 40);
            this.btnAdd.Text = "➕ Đặt sân mới";
            this.btnAdd.BackColor = Color.FromArgb(100, 50, 150);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Click += BtnAdd_Click;

            this.btnEdit.Location = new Point(150, 630);
            this.btnEdit.Size = new Size(120, 40);
            this.btnEdit.Text = "✏️ Sửa";
            this.btnEdit.BackColor = Color.FromArgb(50, 150, 100);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Click += BtnEdit_Click;

            this.btnPayment.Location = new Point(280, 630);
            this.btnPayment.Size = new Size(120, 40);
            this.btnPayment.Text = "💳 Thanh toán";
            this.btnPayment.BackColor = Color.FromArgb(50, 100, 200);
            this.btnPayment.ForeColor = Color.White;
            this.btnPayment.FlatStyle = FlatStyle.Flat;
            this.btnPayment.Click += BtnPayment_Click;

            this.btnCancel.Location = new Point(410, 630);
            this.btnCancel.Size = new Size(120, 40);
            this.btnCancel.Text = "❌ Hủy đặt";
            this.btnCancel.BackColor = Color.FromArgb(200, 50, 50);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Click += BtnCancel_Click;

            this.btnRefresh.Location = new Point(1000, 630);
            this.btnRefresh.Size = new Size(120, 40);
            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.BackColor = Color.FromArgb(100, 100, 100);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Click += BtnRefresh_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, lblFilter, dtpFilterDate, dgvBookings,
                btnAdd, btnEdit, btnPayment, btnCancel, btnRefresh
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "BookingManagementForm";
            this.Text = "Đặt sân & Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadBookings()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT b.BookingID, b.BookingCode, f.FieldName, c.FullName as CustomerName, 
                                  c.Phone, b.BookingDate, b.StartTime, b.EndTime, b.Price, 
                                  b.PaymentMethod, b.Status
                                  FROM Bookings b
                                  INNER JOIN Fields f ON b.FieldID = f.FieldID
                                  INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                                  WHERE CAST(b.BookingDate AS DATE) = @FilterDate
                                  ORDER BY b.BookingDate DESC, b.StartTime";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FilterDate", dtpFilterDate.Value.Date);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBookings.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BookingDetailForm form = new BookingDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt sân cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
            BookingDetailForm form = new BookingDetailForm(bookingID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt sân cần thanh toán!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
            string status = dgvBookings.SelectedRows[0].Cells["Status"].Value.ToString();
            
            if (status == "Paid")
            {
                MessageBox.Show("Đơn đặt sân này đã được thanh toán!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentForm form = new PaymentForm(bookingID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn đặt sân cần hủy!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn hủy đơn đặt sân này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
                    string connStr = DatabaseConnection.GetConnectionString();
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "UPDATE Bookings SET Status = 'Cancelled' WHERE BookingID = @BookingID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Hủy đơn đặt sân thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hủy: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }
    }
}


using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class BookingDetailForm : Form
    {
        private int bookingID = 0;
        private ComboBox cmbField;
        private DateTimePicker dtpBookingDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private ComboBox cmbPaymentMethod;
        private Label lblPrice;
        private Button btnSave;
        private Button btnCancel;

        public BookingDetailForm(int bookingID = 0)
        {
            this.bookingID = bookingID;
            InitializeComponent();
            LoadFields();
            if (bookingID > 0) LoadBookingData();
        }

        private void InitializeComponent()
        {
            this.cmbField = new ComboBox();
            this.dtpBookingDate = new DateTimePicker();
            this.dtpStartTime = new DateTimePicker();
            this.dtpEndTime = new DateTimePicker();
            this.txtCustomerName = new TextBox();
            this.txtCustomerPhone = new TextBox();
            this.cmbPaymentMethod = new ComboBox();
            this.lblPrice = new Label();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Field
            Label lblField = new Label();
            lblField.Text = "Chọn sân:";
            lblField.Location = new Point(20, 20);
            lblField.Size = new Size(120, 20);
            cmbField.Location = new Point(150, 20);
            cmbField.Size = new Size(300, 22);
            cmbField.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbField.SelectedIndexChanged += (s, e) => CalculatePrice();

            // Booking Date
            Label lblDate = new Label();
            lblDate.Text = "Ngày đặt:";
            lblDate.Location = new Point(20, 60);
            lblDate.Size = new Size(120, 20);
            dtpBookingDate.Location = new Point(150, 60);
            dtpBookingDate.Size = new Size(300, 22);
            dtpBookingDate.Value = DateTime.Today;
            dtpBookingDate.ValueChanged += (s, e) => CalculatePrice();

            // Start Time
            Label lblStart = new Label();
            lblStart.Text = "Giờ bắt đầu:";
            lblStart.Location = new Point(20, 100);
            lblStart.Size = new Size(120, 20);
            dtpStartTime.Location = new Point(150, 100);
            dtpStartTime.Size = new Size(300, 22);
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.ValueChanged += (s, e) => CalculatePrice();

            // End Time
            Label lblEnd = new Label();
            lblEnd.Text = "Giờ kết thúc:";
            lblEnd.Location = new Point(20, 140);
            lblEnd.Size = new Size(120, 20);
            dtpEndTime.Location = new Point(150, 140);
            dtpEndTime.Size = new Size(300, 22);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.ValueChanged += (s, e) => CalculatePrice();

            // Customer Name
            Label lblCustName = new Label();
            lblCustName.Text = "Tên khách hàng:";
            lblCustName.Location = new Point(20, 180);
            lblCustName.Size = new Size(120, 20);
            txtCustomerName.Location = new Point(150, 180);
            txtCustomerName.Size = new Size(300, 22);

            // Customer Phone
            Label lblCustPhone = new Label();
            lblCustPhone.Text = "Số điện thoại:";
            lblCustPhone.Location = new Point(20, 220);
            lblCustPhone.Size = new Size(120, 20);
            txtCustomerPhone.Location = new Point(150, 220);
            txtCustomerPhone.Size = new Size(300, 22);
            txtCustomerPhone.Leave += TxtCustomerPhone_Leave;

            // Payment Method
            Label lblPayment = new Label();
            lblPayment.Text = "Phương thức thanh toán:";
            lblPayment.Location = new Point(20, 260);
            lblPayment.Size = new Size(120, 20);
            cmbPaymentMethod.Location = new Point(150, 260);
            cmbPaymentMethod.Size = new Size(300, 22);
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new[] { "Cash", "Transfer", "QR" });

            // Price
            Label lblPriceTitle = new Label();
            lblPriceTitle.Text = "Tổng tiền:";
            lblPriceTitle.Location = new Point(20, 300);
            lblPriceTitle.Size = new Size(120, 20);
            lblPrice.Text = "0 đ";
            lblPrice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(100, 50, 150);
            lblPrice.Location = new Point(150, 300);
            lblPrice.Size = new Size(200, 25);

            // Buttons
            btnSave.Location = new Point(200, 350);
            btnSave.Size = new Size(100, 40);
            btnSave.Text = "💾 Lưu";
            btnSave.BackColor = Color.FromArgb(100, 50, 150);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += BtnSave_Click;

            btnCancel.Location = new Point(330, 350);
            btnCancel.Size = new Size(100, 40);
            btnCancel.Text = "❌ Hủy";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.AddRange(new Control[] {
                lblField, cmbField, lblDate, dtpBookingDate,
                lblStart, dtpStartTime, lblEnd, dtpEndTime,
                lblCustName, txtCustomerName, lblCustPhone, txtCustomerPhone,
                lblPayment, cmbPaymentMethod, lblPriceTitle, lblPrice,
                btnSave, btnCancel
            });

            this.ClientSize = new Size(500, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = bookingID == 0 ? "Đặt sân mới" : "Sửa đơn đặt sân";
            this.ResumeLayout(false);
        }

        private void LoadFields()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT FieldID, FieldName FROM Fields WHERE Status = 'Active' ORDER BY FieldCode";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbField.Items.Clear();
                            while (reader.Read())
                            {
                                cmbField.Items.Add(new { ID = reader["FieldID"], Name = reader["FieldName"].ToString() });
                            }
                        }
                    }
                }
                cmbField.DisplayMember = "Name";
                cmbField.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sân: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCustomerPhone_Leave(object sender, EventArgs e)
        {
            // Tự động load thông tin khách hàng nếu đã tồn tại
            if (!string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
            {
                try
                {
                    string connStr = DatabaseConnection.GetConnectionString();
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "SELECT FullName FROM Customers WHERE Phone = @Phone";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtCustomerName.Text = result.ToString();
                            }
                        }
                    }
                }
                catch { }
            }
        }

        private void CalculatePrice()
        {
            if (cmbField.SelectedItem == null) return;

            try
            {
                int hour = dtpStartTime.Value.Hour;
                decimal price = 0;

                // Xác định khung giờ (BR-002)
                if (hour >= 17 && hour < 22) // Cao điểm: 17h-22h
                {
                    price = GetFieldPrice("PriceHigh");
                }
                else if (hour >= 6 && hour < 17) // Thường: 6h-17h
                {
                    price = GetFieldPrice("PriceNormal");
                }
                else // Thấp điểm: 22h-6h
                {
                    price = GetFieldPrice("PriceLow");
                }

                // Tính số giờ
                TimeSpan duration = dtpEndTime.Value - dtpStartTime.Value;
                int hours = (int)Math.Ceiling(duration.TotalHours);
                if (hours < 1) hours = 1;

                decimal total = price * hours;
                lblPrice.Text = total.ToString("N0") + " đ";
            }
            catch { }
        }

        private decimal GetFieldPrice(string priceType)
        {
            try
            {
                dynamic field = cmbField.SelectedItem;
                int fieldID = (int)field.ID;
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = $"SELECT {priceType} FROM Fields WHERE FieldID = @FieldID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FieldID", fieldID);
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }

        private void LoadBookingData()
        {
            // Load existing booking data
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (cmbField.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sân!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Get or create customer
                            int customerID = GetOrCreateCustomer(conn, trans);

                            // Check for overlapping bookings (BR-004)
                            if (CheckOverlappingBooking(conn, trans))
                            {
                                MessageBox.Show("Khung giờ này đã được đặt! Vui lòng chọn khung giờ khác.", 
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                trans.Rollback();
                                return;
                            }

                            dynamic field = cmbField.SelectedItem;
                            int fieldID = (int)field.ID;
                            decimal price = Convert.ToDecimal(lblPrice.Text.Replace(" đ", "").Replace(",", ""));

                            // Generate BookingCode
                            string bookingCode = GenerateBookingCode(conn, trans);

                            // Insert booking
                            string sql = @"INSERT INTO Bookings (BookingCode, FieldID, CustomerID, BookingDate, 
                                         StartTime, EndTime, Price, PaymentMethod, Status, CreatedBy)
                                         VALUES (@BookingCode, @FieldID, @CustomerID, @BookingDate, 
                                         @StartTime, @EndTime, @Price, @PaymentMethod, 'Pending', 1)";
                            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@BookingCode", bookingCode);
                                cmd.Parameters.AddWithValue("@FieldID", fieldID);
                                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                                cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value.Date);
                                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay);
                                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay);
                                cmd.Parameters.AddWithValue("@Price", price);
                                cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Đặt sân thành công!", "Thông báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetOrCreateCustomer(SqlConnection conn, SqlTransaction trans)
        {
            string sql = "SELECT CustomerID FROM Customers WHERE Phone = @Phone";
            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }

            // Create new customer
            sql = @"INSERT INTO Customers (FullName, Phone) 
                   OUTPUT INSERTED.CustomerID
                   VALUES (@FullName, @Phone)";
            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@FullName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private bool CheckOverlappingBooking(SqlConnection conn, SqlTransaction trans)
        {
            dynamic field = cmbField.SelectedItem;
            int fieldID = (int)field.ID;
            string sql = @"SELECT COUNT(*) FROM Bookings 
                          WHERE FieldID = @FieldID 
                          AND BookingDate = @BookingDate
                          AND Status NOT IN ('Cancelled')
                          AND ((StartTime < @EndTime AND EndTime > @StartTime))";
            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@FieldID", fieldID);
                cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value.Date);
                cmd.Parameters.AddWithValue("@StartTime", dtpStartTime.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@EndTime", dtpEndTime.Value.TimeOfDay);
                if (bookingID > 0)
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    sql += " AND BookingID != @BookingID";
                }
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private string GenerateBookingCode(SqlConnection conn, SqlTransaction trans)
        {
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(BookingCode, 3, LEN(BookingCode)-2) AS INT)), 0) FROM Bookings WHERE BookingCode LIKE 'BK%'";
            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
            {
                int maxNum = Convert.ToInt32(cmd.ExecuteScalar());
                return "BK" + (maxNum + 1).ToString("D6");
            }
        }
    }
}


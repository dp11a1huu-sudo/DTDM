using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private Label lblBookingInfo;
        private Label lblTotalAmount;
        private ComboBox cmbPaymentMethod;
        private Button btnConfirm;
        private Button btnCancel;

        public PaymentForm(int bookingID)
        {
            this.bookingID = bookingID;
            InitializeComponent();
            LoadBookingInfo();
        }

        private void InitializeComponent()
        {
            this.lblBookingInfo = new Label();
            this.lblTotalAmount = new Label();
            this.cmbPaymentMethod = new ComboBox();
            this.btnConfirm = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Booking Info
            Label lblInfoTitle = new Label();
            lblInfoTitle.Text = "Thông tin đơn đặt sân:";
            lblInfoTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblInfoTitle.Location = new Point(20, 20);
            lblInfoTitle.Size = new Size(300, 25);
            lblBookingInfo.Text = "";
            lblBookingInfo.Location = new Point(20, 50);
            lblBookingInfo.Size = new Size(400, 100);
            lblBookingInfo.AutoSize = true;

            // Total Amount
            Label lblAmountTitle = new Label();
            lblAmountTitle.Text = "Tổng tiền:";
            lblAmountTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblAmountTitle.Location = new Point(20, 160);
            lblAmountTitle.Size = new Size(150, 25);
            lblTotalAmount.Text = "0 đ";
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(100, 50, 150);
            lblTotalAmount.Location = new Point(180, 160);
            lblTotalAmount.Size = new Size(200, 30);

            // Payment Method
            Label lblPayment = new Label();
            lblPayment.Text = "Phương thức thanh toán:";
            lblPayment.Location = new Point(20, 210);
            lblPayment.Size = new Size(150, 20);
            cmbPaymentMethod.Location = new Point(180, 210);
            cmbPaymentMethod.Size = new Size(200, 22);
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new[] { "Cash", "Transfer", "QR" });

            // Buttons
            btnConfirm.Location = new Point(150, 270);
            btnConfirm.Size = new Size(100, 40);
            btnConfirm.Text = "💳 Xác nhận thanh toán";
            btnConfirm.BackColor = Color.FromArgb(100, 50, 150);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Click += BtnConfirm_Click;

            btnCancel.Location = new Point(280, 270);
            btnCancel.Size = new Size(100, 40);
            btnCancel.Text = "❌ Hủy";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.AddRange(new Control[] {
                lblInfoTitle, lblBookingInfo, lblAmountTitle, lblTotalAmount,
                lblPayment, cmbPaymentMethod, btnConfirm, btnCancel
            });

            this.ClientSize = new Size(450, 350);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadBookingInfo()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT b.BookingCode, f.FieldName, c.FullName, b.BookingDate, 
                                  b.StartTime, b.EndTime, b.Price, b.PaymentMethod
                                  FROM Bookings b
                                  INNER JOIN Fields f ON b.FieldID = f.FieldID
                                  INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                                  WHERE b.BookingID = @BookingID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblBookingInfo.Text = $"Mã đơn: {reader["BookingCode"]}\n" +
                                                     $"Sân: {reader["FieldName"]}\n" +
                                                     $"Khách hàng: {reader["FullName"]}\n" +
                                                     $"Ngày: {Convert.ToDateTime(reader["BookingDate"]):dd/MM/yyyy}\n" +
                                                     $"Giờ: {reader["StartTime"]} - {reader["EndTime"]}";
                                lblTotalAmount.Text = Convert.ToDecimal(reader["Price"]).ToString("N0") + " đ";
                                if (reader["PaymentMethod"] != DBNull.Value)
                                {
                                    cmbPaymentMethod.Text = reader["PaymentMethod"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!", "Thông báo", 
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
                            // Update booking status
                            string sql = @"UPDATE Bookings SET Status = 'Paid', PaymentMethod = @PaymentMethod, 
                                         PaidDate = GETDATE() WHERE BookingID = @BookingID";
                            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                                cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                                cmd.ExecuteNonQuery();
                            }

                            // Get booking price
                            decimal totalAmount = Convert.ToDecimal(lblTotalAmount.Text.Replace(" đ", "").Replace(",", ""));

                            // Create invoice (BR-011)
                            string invoiceCode = GenerateInvoiceCode(conn, trans);
                            sql = @"INSERT INTO Invoices (InvoiceCode, BookingID, TotalAmount, ServiceAmount, 
                                  Discount, FinalAmount, CreatedBy)
                                  VALUES (@InvoiceCode, @BookingID, @TotalAmount, 0, 0, @FinalAmount, 1)";
                            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@InvoiceCode", invoiceCode);
                                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                                cmd.Parameters.AddWithValue("@FinalAmount", totalAmount);
                                cmd.ExecuteNonQuery();
                            }

                            // Update customer stats
                            sql = @"UPDATE Customers SET TotalBookings = TotalBookings + 1, 
                                   TotalSpent = TotalSpent + @Amount,
                                   LastBookingDate = GETDATE()
                                   WHERE CustomerID = (SELECT CustomerID FROM Bookings WHERE BookingID = @BookingID)";
                            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                                cmd.Parameters.AddWithValue("@Amount", totalAmount);
                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Thanh toán thành công!\nMã hóa đơn: " + invoiceCode, "Thông báo", 
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
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateInvoiceCode(SqlConnection conn, SqlTransaction trans)
        {
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(InvoiceCode, 3, LEN(InvoiceCode)-2) AS INT)), 0) FROM Invoices WHERE InvoiceCode LIKE 'INV%'";
            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
            {
                int maxNum = Convert.ToInt32(cmd.ExecuteScalar());
                return "INV" + (maxNum + 1).ToString("D6");
            }
        }
    }
}


using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class DashboardForm : Form
    {
        private Label lblTotalRevenue;
        private Label lblTotalBookings;
        private Label lblActiveFields;
        private Label lblTotalCustomers;
        private Panel panelStats;
        private DataGridView dgvRecentBookings;
        private Label lblTitle;

        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.panelStats = new Panel();
            this.lblTotalRevenue = new Label();
            this.lblTotalBookings = new Label();
            this.lblActiveFields = new Label();
            this.lblTotalCustomers = new Label();
            this.dgvRecentBookings = new DataGridView();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 36);
            this.lblTitle.Text = "📊 Dashboard";

            // panelStats
            this.panelStats.Location = new Point(20, 70);
            this.panelStats.Size = new Size(1100, 150);
            this.panelStats.BackColor = Color.White;
            this.panelStats.BorderStyle = BorderStyle.FixedSingle;

            // Stats Labels
            CreateStatCard(0, "💰 Doanh thu hôm nay", lblTotalRevenue, "0 đ");
            CreateStatCard(1, "📅 Đặt sân hôm nay", lblTotalBookings, "0");
            CreateStatCard(2, "⚽ Sân đang hoạt động", lblActiveFields, "0");
            CreateStatCard(3, "👥 Tổng khách hàng", lblTotalCustomers, "0");

            // dgvRecentBookings
            this.dgvRecentBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.Location = new Point(20, 240);
            this.dgvRecentBookings.Size = new Size(1100, 500);
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DashboardForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Controls.Add(this.dgvRecentBookings);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateStatCard(int index, string title, Label valueLabel, string defaultValue)
        {
            Panel card = new Panel();
            card.Size = new Size(250, 120);
            card.Location = new Point(20 + index * 270, 15);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;

            valueLabel = new Label();
            valueLabel.Text = defaultValue;
            valueLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            valueLabel.ForeColor = Color.FromArgb(100, 50, 150);
            valueLabel.Location = new Point(10, 50);
            valueLabel.AutoSize = true;

            card.Controls.Add(lblTitle);
            card.Controls.Add(valueLabel);
            panelStats.Controls.Add(card);

            // Lưu reference
            if (index == 0) this.lblTotalRevenue = valueLabel;
            else if (index == 1) this.lblTotalBookings = valueLabel;
            else if (index == 2) this.lblActiveFields = valueLabel;
            else if (index == 3) this.lblTotalCustomers = valueLabel;
        }

        private void LoadDashboardData()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Doanh thu hôm nay
                    string sqlRevenue = @"SELECT ISNULL(SUM(FinalAmount), 0) 
                                         FROM Invoices 
                                         WHERE CAST(CreatedDate AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(sqlRevenue, conn))
                    {
                        decimal revenue = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalRevenue.Text = revenue.ToString("N0") + " đ";
                    }

                    // Đặt sân hôm nay
                    string sqlBookings = @"SELECT COUNT(*) 
                                          FROM Bookings 
                                          WHERE CAST(BookingDate AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(sqlBookings, conn))
                    {
                        int bookings = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalBookings.Text = bookings.ToString();
                    }

                    // Sân đang hoạt động
                    string sqlFields = @"SELECT COUNT(*) 
                                        FROM Fields 
                                        WHERE Status = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(sqlFields, conn))
                    {
                        int fields = Convert.ToInt32(cmd.ExecuteScalar());
                        lblActiveFields.Text = fields.ToString();
                    }

                    // Tổng khách hàng
                    string sqlCustomers = "SELECT COUNT(*) FROM Customers";
                    using (SqlCommand cmd = new SqlCommand(sqlCustomers, conn))
                    {
                        int customers = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalCustomers.Text = customers.ToString();
                    }

                    // Đặt sân gần đây
                    string sqlRecent = @"SELECT TOP 10 
                                        b.BookingCode, 
                                        f.FieldName,
                                        c.FullName as CustomerName,
                                        b.BookingDate,
                                        b.StartTime,
                                        b.EndTime,
                                        b.Status
                                        FROM Bookings b
                                        INNER JOIN Fields f ON b.FieldID = f.FieldID
                                        INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                                        ORDER BY b.CreatedDate DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlRecent, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecentBookings.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu dashboard: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


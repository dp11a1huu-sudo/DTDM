using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class RevenueManagementForm : Form
    {
        private DataGridView dgvRevenue;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnFilter;
        private Button btnExport;
        private Label lblTotalRevenue;
        private Label lblTotalExpenses;
        private Label lblProfit;
        private Label lblTitle;

        public RevenueManagementForm()
        {
            InitializeComponent();
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
            LoadRevenue();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.dgvRevenue = new DataGridView();
            this.dtpFrom = new DateTimePicker();
            this.dtpTo = new DateTimePicker();
            this.btnFilter = new Button();
            this.btnExport = new Button();
            this.lblTotalRevenue = new Label();
            this.lblTotalExpenses = new Label();
            this.lblProfit = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "💰 Quản lý doanh thu";

            // Date filters
            Label lblFrom = new Label();
            lblFrom.Text = "Từ ngày:";
            lblFrom.Location = new Point(20, 70);
            lblFrom.Size = new Size(80, 20);
            dtpFrom.Location = new Point(110, 70);
            dtpFrom.Size = new Size(200, 22);

            Label lblTo = new Label();
            lblTo.Text = "Đến ngày:";
            lblTo.Location = new Point(330, 70);
            lblTo.Size = new Size(80, 20);
            dtpTo.Location = new Point(420, 70);
            dtpTo.Size = new Size(200, 22);

            btnFilter.Location = new Point(640, 70);
            btnFilter.Size = new Size(100, 30);
            btnFilter.Text = "🔍 Lọc";
            btnFilter.BackColor = Color.FromArgb(100, 50, 150);
            btnFilter.ForeColor = Color.White;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Click += BtnFilter_Click;

            // Summary labels
            Panel panelSummary = new Panel();
            panelSummary.Location = new Point(20, 110);
            panelSummary.Size = new Size(1100, 80);
            panelSummary.BackColor = Color.White;
            panelSummary.BorderStyle = BorderStyle.FixedSingle;

            Label lblRevenueTitle = new Label();
            lblRevenueTitle.Text = "Tổng doanh thu:";
            lblRevenueTitle.Location = new Point(20, 10);
            lblRevenueTitle.Size = new Size(150, 20);
            lblTotalRevenue.Text = "0 đ";
            lblTotalRevenue.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.Green;
            lblTotalRevenue.Location = new Point(20, 35);
            lblTotalRevenue.Size = new Size(200, 25);

            Label lblExpensesTitle = new Label();
            lblExpensesTitle.Text = "Tổng chi phí:";
            lblExpensesTitle.Location = new Point(300, 10);
            lblExpensesTitle.Size = new Size(150, 20);
            lblTotalExpenses.Text = "0 đ";
            lblTotalExpenses.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTotalExpenses.ForeColor = Color.Red;
            lblTotalExpenses.Location = new Point(300, 35);
            lblTotalExpenses.Size = new Size(200, 25);

            Label lblProfitTitle = new Label();
            lblProfitTitle.Text = "Lợi nhuận:";
            lblProfitTitle.Location = new Point(580, 10);
            lblProfitTitle.Size = new Size(150, 20);
            lblProfit.Text = "0 đ";
            lblProfit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblProfit.ForeColor = Color.Blue;
            lblProfit.Location = new Point(580, 35);
            lblProfit.Size = new Size(200, 25);

            panelSummary.Controls.AddRange(new Control[] {
                lblRevenueTitle, lblTotalRevenue, lblExpensesTitle, lblTotalExpenses,
                lblProfitTitle, lblProfit
            });

            // dgvRevenue
            this.dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.Location = new Point(20, 210);
            this.dgvRevenue.Size = new Size(1100, 450);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Buttons
            this.btnExport.Location = new Point(1000, 680);
            this.btnExport.Size = new Size(120, 40);
            this.btnExport.Text = "📄 Xuất Excel";
            this.btnExport.BackColor = Color.FromArgb(50, 150, 100);
            this.btnExport.ForeColor = Color.White;
            this.btnExport.FlatStyle = FlatStyle.Flat;
            this.btnExport.Click += BtnExport_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, lblFrom, dtpFrom, lblTo, dtpTo, btnFilter,
                panelSummary, dgvRevenue, btnExport
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "RevenueManagementForm";
            this.Text = "Quản lý doanh thu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadRevenue()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT CAST(i.CreatedDate AS DATE) as Date,
                                  COUNT(DISTINCT i.InvoiceID) as InvoiceCount,
                                  SUM(i.FinalAmount) as Revenue
                                  FROM Invoices i
                                  WHERE CAST(i.CreatedDate AS DATE) BETWEEN @FromDate AND @ToDate
                                  GROUP BY CAST(i.CreatedDate AS DATE)
                                  ORDER BY Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvRevenue.DataSource = dt;
                        }
                    }

                    // Calculate totals
                    string sqlRevenue = @"SELECT ISNULL(SUM(FinalAmount), 0) 
                                         FROM Invoices 
                                         WHERE CAST(CreatedDate AS DATE) BETWEEN @FromDate AND @ToDate";
                    using (SqlCommand cmd = new SqlCommand(sqlRevenue, conn))
                    {
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                        decimal revenue = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalRevenue.Text = revenue.ToString("N0") + " đ";
                    }

                    string sqlExpenses = @"SELECT ISNULL(SUM(Amount), 0) 
                                          FROM Expenses 
                                          WHERE CAST(ExpenseDate AS DATE) BETWEEN @FromDate AND @ToDate";
                    using (SqlCommand cmd = new SqlCommand(sqlExpenses, conn))
                    {
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                        decimal expenses = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalExpenses.Text = expenses.ToString("N0") + " đ";
                    }

                    decimal profit = Convert.ToDecimal(lblTotalRevenue.Text.Replace(" đ", "").Replace(",", "")) - 
                                   Convert.ToDecimal(lblTotalExpenses.Text.Replace(" đ", "").Replace(",", ""));
                    lblProfit.Text = profit.ToString("N0") + " đ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel sẽ được triển khai sau!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


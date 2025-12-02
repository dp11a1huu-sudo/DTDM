using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class CustomerManagementForm : Form
    {
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnViewHistory;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Label lblTitle;

        public CustomerManagementForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.dgvCustomers = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnViewHistory = new Button();
            this.btnRefresh = new Button();
            this.txtSearch = new TextBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "👥 Quản lý khách hàng";

            // Search
            Label lblSearch = new Label();
            lblSearch.Text = "Tìm kiếm:";
            lblSearch.Location = new Point(20, 70);
            lblSearch.Size = new Size(80, 20);
            txtSearch.Location = new Point(110, 70);
            txtSearch.Size = new Size(300, 22);
            txtSearch.TextChanged += (s, e) => LoadCustomers();

            // dgvCustomers
            this.dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.Location = new Point(20, 110);
            this.dgvCustomers.Size = new Size(1100, 500);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.ReadOnly = true;

            // Buttons
            this.btnAdd.Location = new Point(20, 630);
            this.btnAdd.Size = new Size(120, 40);
            this.btnAdd.Text = "➕ Thêm mới";
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

            this.btnViewHistory.Location = new Point(280, 630);
            this.btnViewHistory.Size = new Size(150, 40);
            this.btnViewHistory.Text = "📋 Lịch sử đặt sân";
            this.btnViewHistory.BackColor = Color.FromArgb(50, 100, 200);
            this.btnViewHistory.ForeColor = Color.White;
            this.btnViewHistory.FlatStyle = FlatStyle.Flat;
            this.btnViewHistory.Click += BtnViewHistory_Click;

            this.btnRefresh.Location = new Point(1000, 630);
            this.btnRefresh.Size = new Size(120, 40);
            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.BackColor = Color.FromArgb(100, 100, 100);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Click += BtnRefresh_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, lblSearch, txtSearch, dgvCustomers,
                btnAdd, btnEdit, btnViewHistory, btnRefresh
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "CustomerManagementForm";
            this.Text = "Quản lý khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadCustomers()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT CustomerID, FullName, Phone, Email, TotalBookings, 
                                  TotalSpent, LastBookingDate
                                  FROM Customers
                                  WHERE (@Search = '' OR FullName LIKE @Search OR Phone LIKE @Search)
                                  ORDER BY TotalSpent DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        string search = "%" + txtSearch.Text + "%";
                        cmd.Parameters.AddWithValue("@Search", string.IsNullOrWhiteSpace(txtSearch.Text) ? "" : search);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvCustomers.DataSource = dt;
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
            CustomerDetailForm form = new CustomerDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
            CustomerDetailForm form = new CustomerDetailForm(customerID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
            CustomerHistoryForm form = new CustomerHistoryForm(customerID);
            form.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}


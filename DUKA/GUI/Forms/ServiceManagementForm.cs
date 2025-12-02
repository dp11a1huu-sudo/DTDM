using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class ServiceManagementForm : Form
    {
        private TabControl tabControl;
        private DataGridView dgvFoodServices;
        private DataGridView dgvRentalServices;
        private Button btnAddFood;
        private Button btnAddRental;
        private Label lblTitle;

        public ServiceManagementForm()
        {
            InitializeComponent();
            LoadFoodServices();
            LoadRentalServices();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.tabControl = new TabControl();
            this.dgvFoodServices = new DataGridView();
            this.dgvRentalServices = new DataGridView();
            this.btnAddFood = new Button();
            this.btnAddRental = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "🍔 Quản lý dịch vụ phụ trợ";

            // TabControl
            this.tabControl.Location = new Point(20, 70);
            this.tabControl.Size = new Size(1100, 600);
            
            // Tab 1: Ăn uống
            TabPage tabFood = new TabPage("Dịch vụ ăn uống");
            dgvFoodServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodServices.Dock = DockStyle.Fill;
            dgvFoodServices.ReadOnly = true;
            dgvFoodServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabFood.Controls.Add(dgvFoodServices);
            tabControl.TabPages.Add(tabFood);

            // Tab 2: Thuê
            TabPage tabRental = new TabPage("Dịch vụ thuê");
            dgvRentalServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentalServices.Dock = DockStyle.Fill;
            dgvRentalServices.ReadOnly = true;
            dgvRentalServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabRental.Controls.Add(dgvRentalServices);
            tabControl.TabPages.Add(tabRental);

            // Buttons
            this.btnAddFood.Location = new Point(20, 690);
            this.btnAddFood.Size = new Size(150, 40);
            this.btnAddFood.Text = "➕ Thêm món ăn";
            this.btnAddFood.BackColor = Color.FromArgb(100, 50, 150);
            this.btnAddFood.ForeColor = Color.White;
            this.btnAddFood.FlatStyle = FlatStyle.Flat;
            this.btnAddFood.Click += BtnAddFood_Click;

            this.btnAddRental.Location = new Point(180, 690);
            this.btnAddRental.Size = new Size(150, 40);
            this.btnAddRental.Text = "➕ Thêm dịch vụ thuê";
            this.btnAddRental.BackColor = Color.FromArgb(50, 150, 100);
            this.btnAddRental.ForeColor = Color.White;
            this.btnAddRental.FlatStyle = FlatStyle.Flat;
            this.btnAddRental.Click += BtnAddRental_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, tabControl, btnAddFood, btnAddRental
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "ServiceManagementForm";
            this.Text = "Quản lý dịch vụ phụ trợ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadFoodServices()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT FoodServiceID, ServiceName, ServiceType, UnitPrice, StockQuantity, Unit
                                  FROM FoodServices
                                  WHERE IsActive = 1
                                  ORDER BY ServiceName";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFoodServices.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRentalServices()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT RentalServiceID, ServiceName, ServiceType, UnitPrice, AvailableQuantity, Status
                                  FROM RentalServices
                                  ORDER BY ServiceName";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRentalServices.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            FoodServiceDetailForm form = new FoodServiceDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFoodServices();
            }
        }

        private void BtnAddRental_Click(object sender, EventArgs e)
        {
            RentalServiceDetailForm form = new RentalServiceDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRentalServices();
            }
        }
    }
}


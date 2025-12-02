using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class EmployeeManagementForm : Form
    {
        private TabControl tabControl;
        private DataGridView dgvEmployees;
        private DataGridView dgvShifts;
        private DataGridView dgvSalaries;
        private Button btnAddEmployee;
        private Button btnAddShift;
        private Button btnCalculateSalary;
        private Label lblTitle;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            LoadEmployees();
            LoadShifts();
            LoadSalaries();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.tabControl = new TabControl();
            this.dgvEmployees = new DataGridView();
            this.dgvShifts = new DataGridView();
            this.dgvSalaries = new DataGridView();
            this.btnAddEmployee = new Button();
            this.btnAddShift = new Button();
            this.btnCalculateSalary = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "👔 Quản lý nhân viên";

            // TabControl
            this.tabControl.Location = new Point(20, 70);
            this.tabControl.Size = new Size(1100, 600);
            
            // Tab 1: Nhân viên
            TabPage tabEmployees = new TabPage("Danh sách nhân viên");
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabEmployees.Controls.Add(dgvEmployees);
            tabControl.TabPages.Add(tabEmployees);

            // Tab 2: Ca làm việc
            TabPage tabShifts = new TabPage("Ca làm việc");
            dgvShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShifts.Dock = DockStyle.Fill;
            dgvShifts.ReadOnly = true;
            dgvShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabShifts.Controls.Add(dgvShifts);
            tabControl.TabPages.Add(tabShifts);

            // Tab 3: Lương
            TabPage tabSalaries = new TabPage("Bảng lương");
            dgvSalaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalaries.Dock = DockStyle.Fill;
            dgvSalaries.ReadOnly = true;
            dgvSalaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabSalaries.Controls.Add(dgvSalaries);
            tabControl.TabPages.Add(tabSalaries);

            // Buttons
            this.btnAddEmployee.Location = new Point(20, 690);
            this.btnAddEmployee.Size = new Size(150, 40);
            this.btnAddEmployee.Text = "➕ Thêm nhân viên";
            this.btnAddEmployee.BackColor = Color.FromArgb(100, 50, 150);
            this.btnAddEmployee.ForeColor = Color.White;
            this.btnAddEmployee.FlatStyle = FlatStyle.Flat;
            this.btnAddEmployee.Click += BtnAddEmployee_Click;

            this.btnAddShift.Location = new Point(180, 690);
            this.btnAddShift.Size = new Size(150, 40);
            this.btnAddShift.Text = "📅 Thêm ca làm việc";
            this.btnAddShift.BackColor = Color.FromArgb(50, 150, 100);
            this.btnAddShift.ForeColor = Color.White;
            this.btnAddShift.FlatStyle = FlatStyle.Flat;
            this.btnAddShift.Click += BtnAddShift_Click;

            this.btnCalculateSalary.Location = new Point(340, 690);
            this.btnCalculateSalary.Size = new Size(150, 40);
            this.btnCalculateSalary.Text = "💰 Tính lương";
            this.btnCalculateSalary.BackColor = Color.FromArgb(50, 100, 200);
            this.btnCalculateSalary.ForeColor = Color.White;
            this.btnCalculateSalary.FlatStyle = FlatStyle.Flat;
            this.btnCalculateSalary.Click += BtnCalculateSalary_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, tabControl, btnAddEmployee, btnAddShift, btnCalculateSalary
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "EmployeeManagementForm";
            this.Text = "Quản lý nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadEmployees()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT EmployeeID, EmployeeCode, FullName, Phone, Email, Position, BaseSalary, IsActive
                                  FROM Employees
                                  ORDER BY EmployeeCode";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEmployees.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadShifts()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT ws.ShiftID, e.FullName as EmployeeName, ws.WorkDate, 
                                  ws.StartTime, ws.EndTime, ws.Status
                                  FROM WorkShifts ws
                                  INNER JOIN Employees e ON ws.EmployeeID = e.EmployeeID
                                  ORDER BY ws.WorkDate DESC, ws.StartTime";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvShifts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSalaries()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT s.SalaryID, e.FullName as EmployeeName, s.SalaryMonth, s.SalaryYear,
                                  s.ShiftCount, s.TotalSalary
                                  FROM Salaries s
                                  INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
                                  ORDER BY s.SalaryYear DESC, s.SalaryMonth DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSalaries.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDetailForm form = new EmployeeDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void BtnAddShift_Click(object sender, EventArgs e)
        {
            ShiftDetailForm form = new ShiftDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadShifts();
            }
        }

        private void BtnCalculateSalary_Click(object sender, EventArgs e)
        {
            CalculateSalaryForm form = new CalculateSalaryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSalaries();
            }
        }
    }
}


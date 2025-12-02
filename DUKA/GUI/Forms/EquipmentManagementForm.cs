using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class EquipmentManagementForm : Form
    {
        private TabControl tabControl;
        private DataGridView dgvEquipment;
        private DataGridView dgvMaintenance;
        private Button btnAddEquipment;
        private Button btnAddMaintenance;
        private Label lblTitle;

        public EquipmentManagementForm()
        {
            InitializeComponent();
            LoadEquipment();
            LoadMaintenance();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.tabControl = new TabControl();
            this.dgvEquipment = new DataGridView();
            this.dgvMaintenance = new DataGridView();
            this.btnAddEquipment = new Button();
            this.btnAddMaintenance = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "🔧 Quản lý cơ sở vật chất";

            // TabControl
            this.tabControl.Location = new Point(20, 70);
            this.tabControl.Size = new Size(1100, 600);
            
            // Tab 1: Thiết bị
            TabPage tabEquipment = new TabPage("Danh sách thiết bị");
            dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipment.Dock = DockStyle.Fill;
            dgvEquipment.ReadOnly = true;
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabEquipment.Controls.Add(dgvEquipment);
            tabControl.TabPages.Add(tabEquipment);

            // Tab 2: Bảo trì
            TabPage tabMaintenance = new TabPage("Lịch sử bảo trì");
            dgvMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenance.Dock = DockStyle.Fill;
            dgvMaintenance.ReadOnly = true;
            dgvMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabMaintenance.Controls.Add(dgvMaintenance);
            tabControl.TabPages.Add(tabMaintenance);

            // Buttons
            this.btnAddEquipment.Location = new Point(20, 690);
            this.btnAddEquipment.Size = new Size(150, 40);
            this.btnAddEquipment.Text = "➕ Thêm thiết bị";
            this.btnAddEquipment.BackColor = Color.FromArgb(100, 50, 150);
            this.btnAddEquipment.ForeColor = Color.White;
            this.btnAddEquipment.FlatStyle = FlatStyle.Flat;
            this.btnAddEquipment.Click += BtnAddEquipment_Click;

            this.btnAddMaintenance.Location = new Point(180, 690);
            this.btnAddMaintenance.Size = new Size(150, 40);
            this.btnAddMaintenance.Text = "🔧 Tạo phiếu bảo trì";
            this.btnAddMaintenance.BackColor = Color.FromArgb(50, 150, 100);
            this.btnAddMaintenance.ForeColor = Color.White;
            this.btnAddMaintenance.FlatStyle = FlatStyle.Flat;
            this.btnAddMaintenance.Click += BtnAddMaintenance_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, tabControl, btnAddEquipment, btnAddMaintenance
            });

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Name = "EquipmentManagementForm";
            this.Text = "Quản lý cơ sở vật chất";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadEquipment()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT e.EquipmentID, e.EquipmentCode, e.EquipmentName, e.EquipmentType,
                                  f.FieldName, e.Quantity, e.Status
                                  FROM Equipment e
                                  LEFT JOIN Fields f ON e.FieldID = f.FieldID
                                  ORDER BY e.EquipmentCode";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEquipment.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaintenance()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT m.MaintenanceID, m.MaintenanceCode, m.Description, 
                                  f.FieldName, e.FullName as AssignedTo, m.Cost, m.Status
                                  FROM Maintenance m
                                  LEFT JOIN Fields f ON m.FieldID = f.FieldID
                                  LEFT JOIN Employees e ON m.AssignedTo = e.EmployeeID
                                  ORDER BY m.CreatedDate DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMaintenance.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddEquipment_Click(object sender, EventArgs e)
        {
            EquipmentDetailForm form = new EquipmentDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEquipment();
            }
        }

        private void BtnAddMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceDetailForm form = new MaintenanceDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMaintenance();
            }
        }
    }
}


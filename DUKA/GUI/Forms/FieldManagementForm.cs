using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class FieldManagementForm : Form
    {
        private DataGridView dgvFields;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private TextBox txtFieldCode;
        private TextBox txtFieldName;
        private ComboBox cmbFieldType;
        private TextBox txtArea;
        private TextBox txtPriceHigh;
        private TextBox txtPriceNormal;
        private TextBox txtPriceLow;
        private ComboBox cmbStatus;
        private Label lblTitle;
        private Panel panelForm;

        public FieldManagementForm()
        {
            InitializeComponent();
            LoadFields();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.dgvFields = new DataGridView();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnRefresh = new Button();
            this.panelForm = new Panel();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(300, 36);
            this.lblTitle.Text = "⚽ Quản lý sân bóng";

            // dgvFields
            this.dgvFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFields.Location = new Point(20, 70);
            this.dgvFields.Size = new Size(1100, 400);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFields.ReadOnly = true;
            this.dgvFields.CellClick += DgvFields_CellClick;

            // Buttons
            this.btnAdd.Location = new Point(20, 490);
            this.btnAdd.Size = new Size(120, 40);
            this.btnAdd.Text = "➕ Thêm mới";
            this.btnAdd.BackColor = Color.FromArgb(100, 50, 150);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Click += BtnAdd_Click;

            this.btnEdit.Location = new Point(150, 490);
            this.btnEdit.Size = new Size(120, 40);
            this.btnEdit.Text = "✏️ Sửa";
            this.btnEdit.BackColor = Color.FromArgb(50, 150, 100);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Click += BtnEdit_Click;

            this.btnDelete.Location = new Point(280, 490);
            this.btnDelete.Size = new Size(120, 40);
            this.btnDelete.Text = "🗑️ Xóa";
            this.btnDelete.BackColor = Color.FromArgb(200, 50, 50);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Click += BtnDelete_Click;

            this.btnRefresh.Location = new Point(1000, 490);
            this.btnRefresh.Size = new Size(120, 40);
            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.BackColor = Color.FromArgb(100, 100, 100);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Click += BtnRefresh_Click;

            // DashboardForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.ClientSize = new Size(1150, 800);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.lblTitle);
            this.Name = "FieldManagementForm";
            this.Text = "Quản lý sân bóng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadFields()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"SELECT FieldID, FieldCode, FieldName, FieldType, Area, 
                                  PriceHigh, PriceNormal, PriceLow, Status
                                  FROM Fields
                                  ORDER BY FieldCode";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFields.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Load data to form when row selected
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FieldDetailForm form = new FieldDetailForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFields();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFields.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sân cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int fieldID = Convert.ToInt32(dgvFields.SelectedRows[0].Cells["FieldID"].Value);
            FieldDetailForm form = new FieldDetailForm(fieldID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFields();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFields.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sân cần xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sân này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int fieldID = Convert.ToInt32(dgvFields.SelectedRows[0].Cells["FieldID"].Value);
                    string connStr = DatabaseConnection.GetConnectionString();
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Fields WHERE FieldID = @FieldID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FieldID", fieldID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa sân thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadFields();
        }
    }
}


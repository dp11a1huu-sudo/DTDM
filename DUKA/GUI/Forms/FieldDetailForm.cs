using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DAL;

namespace GUI.Forms
{
    public partial class FieldDetailForm : Form
    {
        private int fieldID = 0;
        private TextBox txtFieldCode;
        private TextBox txtFieldName;
        private ComboBox cmbFieldType;
        private TextBox txtArea;
        private TextBox txtPriceHigh;
        private TextBox txtPriceNormal;
        private TextBox txtPriceLow;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;

        public FieldDetailForm(int fieldID = 0)
        {
            this.fieldID = fieldID;
            InitializeComponent();
            if (fieldID > 0) LoadFieldData();
        }

        private void InitializeComponent()
        {
            this.txtFieldCode = new TextBox();
            this.txtFieldName = new TextBox();
            this.cmbFieldType = new ComboBox();
            this.txtArea = new TextBox();
            this.txtPriceHigh = new TextBox();
            this.txtPriceNormal = new TextBox();
            this.txtPriceLow = new TextBox();
            this.cmbStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Field Code
            Label lblCode = new Label();
            lblCode.Text = "Mã sân:";
            lblCode.Location = new Point(20, 20);
            lblCode.Size = new Size(100, 20);
            txtFieldCode.Location = new Point(130, 20);
            txtFieldCode.Size = new Size(300, 22);
            txtFieldCode.Enabled = (fieldID == 0); // Chỉ cho phép nhập khi thêm mới

            // Field Name
            Label lblName = new Label();
            lblName.Text = "Tên sân:";
            lblName.Location = new Point(20, 60);
            lblName.Size = new Size(100, 20);
            txtFieldName.Location = new Point(130, 60);
            txtFieldName.Size = new Size(300, 22);

            // Field Type
            Label lblType = new Label();
            lblType.Text = "Loại sân:";
            lblType.Location = new Point(20, 100);
            lblType.Size = new Size(100, 20);
            cmbFieldType.Location = new Point(130, 100);
            cmbFieldType.Size = new Size(300, 22);
            cmbFieldType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFieldType.Items.AddRange(new[] { "5 người", "7 người", "11 người" });

            // Area
            Label lblArea = new Label();
            lblArea.Text = "Diện tích (m²):";
            lblArea.Location = new Point(20, 140);
            lblArea.Size = new Size(100, 20);
            txtArea.Location = new Point(130, 140);
            txtArea.Size = new Size(300, 22);

            // Price High
            Label lblPriceHigh = new Label();
            lblPriceHigh.Text = "Giá cao điểm:";
            lblPriceHigh.Location = new Point(20, 180);
            lblPriceHigh.Size = new Size(100, 20);
            txtPriceHigh.Location = new Point(130, 180);
            txtPriceHigh.Size = new Size(300, 22);

            // Price Normal
            Label lblPriceNormal = new Label();
            lblPriceNormal.Text = "Giá thường:";
            lblPriceNormal.Location = new Point(20, 220);
            lblPriceNormal.Size = new Size(100, 20);
            txtPriceNormal.Location = new Point(130, 220);
            txtPriceNormal.Size = new Size(300, 22);

            // Price Low
            Label lblPriceLow = new Label();
            lblPriceLow.Text = "Giá thấp điểm:";
            lblPriceLow.Location = new Point(20, 260);
            lblPriceLow.Size = new Size(100, 20);
            txtPriceLow.Location = new Point(130, 260);
            txtPriceLow.Size = new Size(300, 22);

            // Status
            Label lblStatus = new Label();
            lblStatus.Text = "Trạng thái:";
            lblStatus.Location = new Point(20, 300);
            lblStatus.Size = new Size(100, 20);
            cmbStatus.Location = new Point(130, 300);
            cmbStatus.Size = new Size(300, 22);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new[] { "Active", "Maintenance", "Closed" });

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
                lblCode, txtFieldCode, lblName, txtFieldName,
                lblType, cmbFieldType, lblArea, txtArea,
                lblPriceHigh, txtPriceHigh, lblPriceNormal, txtPriceNormal,
                lblPriceLow, txtPriceLow, lblStatus, cmbStatus,
                btnSave, btnCancel
            });

            this.ClientSize = new Size(480, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = fieldID == 0 ? "Thêm sân mới" : "Sửa thông tin sân";
            this.ResumeLayout(false);
        }

        private void LoadFieldData()
        {
            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Fields WHERE FieldID = @FieldID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FieldID", fieldID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFieldCode.Text = reader["FieldCode"].ToString();
                                txtFieldName.Text = reader["FieldName"].ToString();
                                cmbFieldType.Text = reader["FieldType"].ToString();
                                txtArea.Text = reader["Area"].ToString();
                                txtPriceHigh.Text = reader["PriceHigh"].ToString();
                                txtPriceNormal.Text = reader["PriceNormal"].ToString();
                                txtPriceLow.Text = reader["PriceLow"].ToString();
                                cmbStatus.Text = reader["Status"].ToString();
                            }
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFieldName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sân!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = DatabaseConnection.GetConnectionString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    if (fieldID == 0)
                    {
                        // Generate FieldCode if empty
                        if (string.IsNullOrWhiteSpace(txtFieldCode.Text))
                        {
                            string sqlMax = "SELECT ISNULL(MAX(CAST(SUBSTRING(FieldCode, 3, LEN(FieldCode)-2) AS INT)), 0) FROM Fields WHERE FieldCode LIKE 'SB%'";
                            using (SqlCommand cmdMax = new SqlCommand(sqlMax, conn))
                            {
                                int maxNum = Convert.ToInt32(cmdMax.ExecuteScalar());
                                txtFieldCode.Text = "SB" + (maxNum + 1).ToString("D3");
                            }
                        }

                        // Insert
                        string sql = @"INSERT INTO Fields (FieldCode, FieldName, FieldType, Area, PriceHigh, PriceNormal, PriceLow, Status)
                                     VALUES (@FieldCode, @FieldName, @FieldType, @Area, @PriceHigh, @PriceNormal, @PriceLow, @Status)";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FieldCode", txtFieldCode.Text);
                            cmd.Parameters.AddWithValue("@FieldName", txtFieldName.Text);
                            cmd.Parameters.AddWithValue("@FieldType", cmbFieldType.Text);
                            cmd.Parameters.AddWithValue("@Area", string.IsNullOrWhiteSpace(txtArea.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtArea.Text));
                            cmd.Parameters.AddWithValue("@PriceHigh", string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? 0 : Convert.ToDecimal(txtPriceHigh.Text));
                            cmd.Parameters.AddWithValue("@PriceNormal", string.IsNullOrWhiteSpace(txtPriceNormal.Text) ? 0 : Convert.ToDecimal(txtPriceNormal.Text));
                            cmd.Parameters.AddWithValue("@PriceLow", string.IsNullOrWhiteSpace(txtPriceLow.Text) ? 0 : Convert.ToDecimal(txtPriceLow.Text));
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm sân thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Update
                        string sql = @"UPDATE Fields SET FieldName = @FieldName, FieldType = @FieldType, 
                                     Area = @Area, PriceHigh = @PriceHigh, PriceNormal = @PriceNormal, 
                                     PriceLow = @PriceLow, Status = @Status
                                     WHERE FieldID = @FieldID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FieldID", fieldID);
                            cmd.Parameters.AddWithValue("@FieldName", txtFieldName.Text);
                            cmd.Parameters.AddWithValue("@FieldType", cmbFieldType.Text);
                            cmd.Parameters.AddWithValue("@Area", string.IsNullOrWhiteSpace(txtArea.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtArea.Text));
                            cmd.Parameters.AddWithValue("@PriceHigh", string.IsNullOrWhiteSpace(txtPriceHigh.Text) ? 0 : Convert.ToDecimal(txtPriceHigh.Text));
                            cmd.Parameters.AddWithValue("@PriceNormal", string.IsNullOrWhiteSpace(txtPriceNormal.Text) ? 0 : Convert.ToDecimal(txtPriceNormal.Text));
                            cmd.Parameters.AddWithValue("@PriceLow", string.IsNullOrWhiteSpace(txtPriceLow.Text) ? 0 : Convert.ToDecimal(txtPriceLow.Text));
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật sân thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


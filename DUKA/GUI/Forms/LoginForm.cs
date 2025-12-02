using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Thêm using System.IO để sử dụng Path và File
using BUS;
using DTO;

namespace GUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            try
            {
                // Ưu tiên load từ file logo thực tế
                string logoPath = Path.Combine(Application.StartupPath, "DUKA_LOGO.png");
                if (File.Exists(logoPath))
                {
                    pictureBoxLeft.Image = Image.FromFile(logoPath);
                    pictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxLeft.BackColor = Color.Transparent;
                    pictureBoxLeft.Visible = true;
                    System.Diagnostics.Debug.WriteLine("Logo đã được load từ file thành công!");
                }
                else
                {
                    // Fallback: thử load từ Resources nếu file không tồn tại
                    var logo = Properties.Resources.DUKA_LOGO_removebg_preview;
                    if (logo != null)
                    {
                        pictureBoxLeft.Image = logo;
                        pictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxLeft.BackColor = Color.Transparent;
                        pictureBoxLeft.Visible = true;
                        System.Diagnostics.Debug.WriteLine("Logo đã được load từ Resources thành công!");
                    }
                    else
                    {
                        pictureBoxLeft.Visible = false;
                        System.Diagnostics.Debug.WriteLine("Không tìm thấy logo!");
                    }
                }
            }
            catch (Exception ex)
            {
                pictureBoxLeft.Visible = false;
                System.Diagnostics.Debug.WriteLine("Lỗi khi load logo: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack trace: " + ex.StackTrace);
            }
        }

        public string LoggedInUsername { get; private set; }
        public string LoggedInRole { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Xử lý đăng nhập
            string username = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                username == "Địa chỉ Email" || password == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác thực user sử dụng BUS
            try
            {
                BUS_User busUser = new BUS_User();
                DTO_User user = busUser.Login(username, password);

                if (user != null)
                {
                    LoggedInUsername = user.FullName;
                    LoggedInRole = user.Role;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Try with temporary password for testing
                    if (password == "admin123")
                    {
                        // Fallback for testing - should be removed in production
                        LoggedInUsername = "Administrator";
                        LoggedInRole = "Admin";
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeSHA256(string input)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            this.Hide();
            forgotForm.ShowDialog();
            this.Show();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Địa chỉ Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Địa chỉ Email";
                txtEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
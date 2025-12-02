using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class ResetPasswordForm : Form
    {
        private string email;

        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            this.email = email;
            LoadLogo();
        }

        private void LoadLogo()
        {
            try
            {
                if (Properties.Resources.DUKA_Logo != null)
                {
                    pictureBoxLeft.Image = Properties.Resources.DUKA_Logo;
                }
                else
                {
                    pictureBoxLeft.Visible = false;
                }
            }
            catch (Exception ex)
            {
                pictureBoxLeft.Visible = false;
                System.Diagnostics.Debug.WriteLine("Không thể load logo từ Resources: " + ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword) ||
                newPassword == "Nhập mật khẩu mới" || confirmPassword == "Xác nhận mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Thêm logic đặt lại mật khẩu
            MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnToggleNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
        }

        private void btnToggleConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Nhập mật khẩu mới")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = System.Drawing.Color.Black;
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                txtNewPassword.Text = "Nhập mật khẩu mới";
                txtNewPassword.ForeColor = System.Drawing.Color.Gray;
                txtNewPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Xác nhận mật khẩu")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "Xác nhận mật khẩu";
                txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }
    }
}


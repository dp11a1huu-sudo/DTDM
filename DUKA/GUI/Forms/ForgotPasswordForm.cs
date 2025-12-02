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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(email) || email == "Địa chỉ email")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Thêm logic gửi mã xác minh
            MessageBox.Show("Mã xác minh đã được gửi đến email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Chuyển sang form nhập mã xác minh
            VerificationCodeForm verifyForm = new VerificationCodeForm(email);
            this.Hide();
            verifyForm.ShowDialog();
            this.Close();
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Địa chỉ email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Địa chỉ email";
                txtEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }
}


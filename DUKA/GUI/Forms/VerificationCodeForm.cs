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
    public partial class VerificationCodeForm : Form
    {
        private string email;
        private int resendCountdown = 60;
        private Timer countdownTimer;

        public VerificationCodeForm(string email)
        {
            InitializeComponent();
            this.email = email;
            InitializeTimer();
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

        private void InitializeTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
            UpdateResendLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            resendCountdown--;
            if (resendCountdown <= 0)
            {
                countdownTimer.Stop();
                linkResend.Enabled = true;
                lblWaitMessage.Text = "Không nhận được mã xác minh? Bạn có thể yêu cầu gửi lại.";
            }
            else
            {
                UpdateResendLabel();
            }
        }

        private void UpdateResendLabel()
        {
            lblWaitMessage.Text = $"Không nhận được mã xác minh? Vui lòng đợi {resendCountdown} giây trước khi yêu cầu gửi lại.";
        }

        private void txtCode1_TextChanged(object sender, EventArgs e)
        {
            if (txtCode1.Text.Length == 1)
            {
                txtCode2.Focus();
            }
        }

        private void txtCode2_TextChanged(object sender, EventArgs e)
        {
            if (txtCode2.Text.Length == 1)
            {
                txtCode3.Focus();
            }
        }

        private void txtCode3_TextChanged(object sender, EventArgs e)
        {
            if (txtCode3.Text.Length == 1)
            {
                txtCode4.Focus();
            }
        }

        private void txtCode4_TextChanged(object sender, EventArgs e)
        {
            if (txtCode4.Text.Length == 1)
            {
                btnConfirm.Focus();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (e.KeyCode == Keys.Back && txt.Text.Length == 0)
            {
                if (txt == txtCode2) txtCode1.Focus();
                else if (txt == txtCode3) txtCode2.Focus();
                else if (txt == txtCode4) txtCode3.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string code = txtCode1.Text + txtCode2.Text + txtCode3.Text + txtCode4.Text;

            if (code.Length != 4)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ 4 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Thêm logic xác minh mã
            MessageBox.Show("Mã xác minh hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Chuyển sang form đặt lại mật khẩu
            ResetPasswordForm resetForm = new ResetPasswordForm(email);
            this.Hide();
            resetForm.ShowDialog();
            this.Close();
        }

        private void linkResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (resendCountdown > 0)
            {
                MessageBox.Show($"Vui lòng đợi {resendCountdown} giây nữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Thêm logic gửi lại mã
            MessageBox.Show("Mã xác minh mới đã được gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resendCountdown = 60;
            countdownTimer.Start();
            linkResend.Enabled = false;
            UpdateResendLabel();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (countdownTimer != null)
            {
                countdownTimer.Stop();
                countdownTimer.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}


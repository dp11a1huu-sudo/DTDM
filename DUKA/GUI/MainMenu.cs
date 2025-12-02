using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Controls;

namespace GUI
{
    public partial class MainMenu : Form
    {
        // Biến để lưu control hiện tại
        private UserControl currentControl;
        private Button currentButton;
        private string currentUserRole = "Admin";
        private string currentUserName = "Admin";

        // Các controls được khai báo trong Designer.cs

        public MainMenu(string username = "Admin", string role = "Admin")
        {
            InitializeComponent();
            currentUserName = username;
            currentUserRole = role;
            InitializeCustomComponents();
            
            // Đảm bảo contentPanel có z-order cao hơn sidebarPanel để hiển thị đúng
            this.Controls.SetChildIndex(this.contentPanel, this.Controls.Count - 1);
            
            // Mở Dashboard và highlight button sau khi tất cả controls đã được tạo
            OpenChildControl(new DashboardControl());
            if (btnDashboard != null)
            {
                HighlightButton(btnDashboard);
            }
        }

        private void InitializeCustomComponents()
        {
            // Cấu hình form
            this.Text = "DUKA - Hệ Thống Quản Lý Sân Bóng Đá";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Setup button tags và events
            btnDashboard.Tag = "Dashboard";
            btnFields.Tag = "Fields";
            btnCustomers.Tag = "Customers";
            btnEmployees.Tag = "Employees";
            btnServices.Tag = "Services";
            btnReports.Tag = "Reports";
            btnSettings.Tag = "Settings";
            btnHelp.Tag = "Help";
            btnLogout.Tag = "Logout";

            // Attach events
            btnDashboard.Click += MenuButton_Click;
            btnFields.Click += MenuButton_Click;
            btnCustomers.Click += MenuButton_Click;
            btnEmployees.Click += MenuButton_Click;
            btnServices.Click += MenuButton_Click;
            btnReports.Click += MenuButton_Click;
            btnSettings.Click += MenuButton_Click;
            btnHelp.Click += MenuButton_Click;
            btnLogout.Click += MenuButton_Click;

            btnDashboard.MouseEnter += Button_MouseEnter;
            btnFields.MouseEnter += Button_MouseEnter;
            btnCustomers.MouseEnter += Button_MouseEnter;
            btnEmployees.MouseEnter += Button_MouseEnter;
            btnServices.MouseEnter += Button_MouseEnter;
            btnReports.MouseEnter += Button_MouseEnter;
            btnSettings.MouseEnter += Button_MouseEnter;
            btnHelp.MouseEnter += Button_MouseEnter;
            btnLogout.MouseEnter += Button_MouseEnter;

            btnDashboard.MouseLeave += Button_MouseLeave;
            btnFields.MouseLeave += Button_MouseLeave;
            btnCustomers.MouseLeave += Button_MouseLeave;
            btnEmployees.MouseLeave += Button_MouseLeave;
            btnServices.MouseLeave += Button_MouseLeave;
            btnReports.MouseLeave += Button_MouseLeave;
            btnSettings.MouseLeave += Button_MouseLeave;
            btnHelp.MouseLeave += Button_MouseLeave;
            btnLogout.MouseLeave += Button_MouseLeave;

            // Setup button styles
            foreach (Control control in menuPanel.Controls)
            {
                if (control is Button btn && btn != btnLogout)
                {
                    btn.BackColor = Color.Transparent;
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string menuTag = button.Tag.ToString();

            if (menuTag == "Logout")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return;
            }

            HighlightButton(button);

            // Mở control tương ứng
            switch (menuTag)
            {
                case "Dashboard":
                    OpenChildControl(new DashboardControl());
                    break;
                case "Fields":
                    OpenChildControl(new FieldControl());
                    break;
                case "Customers":
                    OpenChildControl(new CustomerManagementControl());
                    break;
                case "Employees":
                    OpenChildControl(new EmployeeControl());
                    break;
                case "Services":
                    OpenChildControl(new ServiceManagementControl());
                    break;
                case "Reports":
                    OpenChildControl(new ReportControl());
                    break;
                case "Settings":
                    OpenChildControl(new SettingsControl());
                    break;
                case "Help":
                    OpenChildControl(new HelpControl());
                    break;
            }
        }

        private void HighlightButton(Button selectedButton)
            {
            // Reset tất cả buttons
            foreach (Control control in menuPanel.Controls)
            {
                if (control is Button btn && btn.Tag.ToString() != "Logout")
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(156, 163, 175); // Light purple-grey (inactive)
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }

            // Highlight button được chọn - dark purple/grey (active)
            selectedButton.BackColor = Color.Transparent;
            selectedButton.ForeColor = Color.FromArgb(107, 114, 128); // Dark grey (active)
            selectedButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            currentButton = selectedButton;
        }

        public void OpenChildControl(UserControl control)
        {
            // Đóng control hiện tại nếu có
            if (currentControl != null)
            {
                this.contentPanel.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Cấu hình control
            currentControl = control;
            control.Dock = DockStyle.Fill;

            // Thêm vào panel content
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(control);
            this.contentPanel.Tag = control;

            // Đảm bảo control hiển thị
            control.Visible = true;
            control.BringToFront();
            this.contentPanel.BringToFront();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != currentButton && button.Tag.ToString() != "Logout")
        {
                button.ForeColor = Color.FromArgb(139, 92, 246); // Slightly darker on hover
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != currentButton && button.Tag.ToString() != "Logout")
        {
                button.ForeColor = Color.FromArgb(156, 163, 175); // Back to inactive color
            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

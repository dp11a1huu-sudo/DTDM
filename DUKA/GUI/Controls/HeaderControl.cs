using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class HeaderControl : UserControl
    {
        private string userName = "KaTun";
        private int notificationCount = 3;

        public HeaderControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                // Delay initialization until control is fully loaded
                this.HandleCreated += HeaderControl_HandleCreated;
            }
        }

        private void HeaderControl_HandleCreated(object sender, EventArgs e)
        {
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            InitializeHeader();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in HeaderControl BeginInvoke: {ex.Message}");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in HeaderControl_HandleCreated: {ex.Message}");
            }
        }

        private void InitializeHeader()
        {
            try
            {
                UpdateUserName(userName);
                UpdateNotificationCount(notificationCount);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in InitializeHeader: {ex.Message}");
            }
        }

        public void UpdateUserName(string name)
        {
            userName = name;
            if (lblUserName != null)
            {
                lblUserName.Text = name;
            }
        }

        public void UpdateNotificationCount(int count)
        {
            notificationCount = count;
            if (lblNotificationBadge != null)
            {
                lblNotificationBadge.Text = count > 0 ? count.ToString() : "";
                lblNotificationBadge.Visible = count > 0;
            }
            this.Invalidate();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Toggle sidebar or show menu
            OnMenuClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            // Show user profile dropdown
            OnUserProfileClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            // Show notifications
            OnNotificationClick?.Invoke(this, EventArgs.Empty);
        }

        // Events
        public event EventHandler OnMenuClick;
        public event EventHandler OnUserProfileClick;
        public event EventHandler OnNotificationClick;

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {
            // Draw circular avatar
            var button = sender as Button;
            if (button == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new SolidBrush(Color.FromArgb(255, 154, 102))) // Light orange
            {
                e.Graphics.FillEllipse(brush, 0, 0, button.Width, button.Height);
            }

            // Draw "K" text
            using (var font = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.White))
            {
                var textSize = e.Graphics.MeasureString("K", font);
                var x = (button.Width - textSize.Width) / 2;
                var y = (button.Height - textSize.Height) / 2;
                e.Graphics.DrawString("K", font, brush, x, y);
            }
        }

        private void panelNotification_Paint(object sender, PaintEventArgs e)
        {
            // Draw notification bell icon
            var button = sender as Button;
            if (button == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // Draw bell shape (simplified)
            using (var pen = new Pen(Color.FromArgb(59, 130, 246), 2)) // Dark blue
            {
                // Bell body
                var bellRect = new Rectangle(8, 8, 16, 16);
                e.Graphics.DrawEllipse(pen, bellRect);
                
                // Bell handle
                e.Graphics.DrawLine(pen, 12, 6, 12, 8);
                e.Graphics.DrawLine(pen, 20, 6, 20, 8);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Draw bottom border line
            var panel = sender as Panel;
            if (panel == null) return;

            using (var pen = new Pen(Color.FromArgb(229, 231, 235), 1)) // Light gray
            {
                e.Graphics.DrawLine(pen, 0, panel.Height - 1, panel.Width, panel.Height - 1);
            }
        }
    }
}


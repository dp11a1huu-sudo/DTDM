namespace GUI.Controls
{
    partial class HeaderControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnUserDropdown;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Label lblNotificationBadge;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.lblNotificationBadge = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnUserDropdown = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelNotification.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.panelNotification);
            this.panelHeader.Controls.Add(this.panelUser);
            this.panelHeader.Controls.Add(this.btnMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelNotification
            // 
            this.panelNotification.Controls.Add(this.lblNotificationBadge);
            this.panelNotification.Controls.Add(this.btnNotifications);
            this.panelNotification.Location = new System.Drawing.Point(1160, 15);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(40, 40);
            this.panelNotification.TabIndex = 2;
            // 
            // lblNotificationBadge
            // 
            this.lblNotificationBadge.AutoSize = true;
            this.lblNotificationBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblNotificationBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNotificationBadge.ForeColor = System.Drawing.Color.White;
            this.lblNotificationBadge.Location = new System.Drawing.Point(22, 5);
            this.lblNotificationBadge.Name = "lblNotificationBadge";
            this.lblNotificationBadge.Size = new System.Drawing.Size(17, 19);
            this.lblNotificationBadge.TabIndex = 1;
            this.lblNotificationBadge.Text = "3";
            this.lblNotificationBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.Transparent;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnNotifications.ForeColor = System.Drawing.Color.Black;
            this.btnNotifications.Location = new System.Drawing.Point(0, 0);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(40, 40);
            this.btnNotifications.TabIndex = 0;
            this.btnNotifications.Text = "🔔︎";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            this.btnNotifications.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNotification_Paint);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.btnUserDropdown);
            this.panelUser.Controls.Add(this.lblUserName);
            this.panelUser.Controls.Add(this.btnUserProfile);
            this.panelUser.Location = new System.Drawing.Point(1000, 15);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(150, 40);
            this.panelUser.TabIndex = 1;
            // 
            // btnUserDropdown
            // 
            this.btnUserDropdown.BackColor = System.Drawing.Color.Transparent;
            this.btnUserDropdown.FlatAppearance.BorderSize = 0;
            this.btnUserDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUserDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnUserDropdown.Location = new System.Drawing.Point(110, 10);
            this.btnUserDropdown.Name = "btnUserDropdown";
            this.btnUserDropdown.Size = new System.Drawing.Size(20, 20);
            this.btnUserDropdown.TabIndex = 2;
            this.btnUserDropdown.Text = "▼";
            this.btnUserDropdown.UseVisualStyleBackColor = false;
            this.btnUserDropdown.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblUserName.Location = new System.Drawing.Point(50, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "KaTun";
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnUserProfile.FlatAppearance.BorderSize = 0;
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Location = new System.Drawing.Point(0, 0);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(40, 40);
            this.btnUserProfile.TabIndex = 0;
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            this.btnUserProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnMenu.Location = new System.Drawing.Point(20, 15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "☰";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelHeader);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.ResumeLayout(false);
            this.panelNotification.ResumeLayout(false);
            this.panelNotification.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnUserProfile;
    }
}


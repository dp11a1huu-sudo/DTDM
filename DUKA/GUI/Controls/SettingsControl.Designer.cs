namespace GUI.Controls
{
    partial class SettingsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.TabPage tabNotifications;
        private System.Windows.Forms.CheckBox chkEmailNotifications;
        private System.Windows.Forms.CheckBox chkSMSNotifications;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Label lblBackupInterval;
        private System.Windows.Forms.NumericUpDown numBackupInterval;
        private System.Windows.Forms.Label lblBackupIntervalUnit;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.tabNotifications = new System.Windows.Forms.TabPage();
            this.chkSMSNotifications = new System.Windows.Forms.CheckBox();
            this.chkEmailNotifications = new System.Windows.Forms.CheckBox();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.lblBackupIntervalUnit = new System.Windows.Forms.Label();
            this.numBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.lblBackupInterval = new System.Windows.Forms.Label();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabNotifications.SuspendLayout();
            this.tabBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnSave);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20);
            this.panelHeader.Size = new System.Drawing.Size(1150, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙️ Cài đặt";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1050, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelContent.Controls.Add(this.tabControl);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(1150, 720);
            this.panelContent.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabBackup);
            this.tabControl.Controls.Add(this.tabNotifications);
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(20, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1110, 680);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cmbTheme);
            this.tabGeneral.Controls.Add(this.lblTheme);
            this.tabGeneral.Controls.Add(this.cmbLanguage);
            this.tabGeneral.Controls.Add(this.lblLanguage);
            this.tabGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1102, 650);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Cài đặt chung";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblLanguage.Location = new System.Drawing.Point(20, 30);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(100, 21);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Ngôn ngữ:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Tiếng Việt",
            "English"});
            this.cmbLanguage.Location = new System.Drawing.Point(130, 28);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(250, 25);
            this.cmbLanguage.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTheme.Location = new System.Drawing.Point(20, 80);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(100, 21);
            this.lblTheme.TabIndex = 2;
            this.lblTheme.Text = "Giao diện:";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Sáng",
            "Tối"});
            this.cmbTheme.Location = new System.Drawing.Point(130, 78);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(250, 25);
            this.cmbTheme.TabIndex = 3;
            // 
            // tabNotifications
            // 
            this.tabNotifications.Controls.Add(this.chkSMSNotifications);
            this.tabNotifications.Controls.Add(this.chkEmailNotifications);
            this.tabNotifications.Location = new System.Drawing.Point(4, 26);
            this.tabNotifications.Name = "tabNotifications";
            this.tabNotifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotifications.Size = new System.Drawing.Size(1102, 650);
            this.tabNotifications.TabIndex = 1;
            this.tabNotifications.Text = "Thông báo";
            this.tabNotifications.UseVisualStyleBackColor = true;
            // 
            // chkEmailNotifications
            // 
            this.chkEmailNotifications.AutoSize = true;
            this.chkEmailNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmailNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.chkEmailNotifications.Location = new System.Drawing.Point(20, 30);
            this.chkEmailNotifications.Name = "chkEmailNotifications";
            this.chkEmailNotifications.Size = new System.Drawing.Size(200, 25);
            this.chkEmailNotifications.TabIndex = 0;
            this.chkEmailNotifications.Text = "Thông báo qua Email";
            this.chkEmailNotifications.UseVisualStyleBackColor = true;
            // 
            // chkSMSNotifications
            // 
            this.chkSMSNotifications.AutoSize = true;
            this.chkSMSNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMSNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.chkSMSNotifications.Location = new System.Drawing.Point(20, 80);
            this.chkSMSNotifications.Name = "chkSMSNotifications";
            this.chkSMSNotifications.Size = new System.Drawing.Size(200, 25);
            this.chkSMSNotifications.TabIndex = 1;
            this.chkSMSNotifications.Text = "Thông báo qua SMS";
            this.chkSMSNotifications.UseVisualStyleBackColor = true;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.lblBackupIntervalUnit);
            this.tabBackup.Controls.Add(this.numBackupInterval);
            this.tabBackup.Controls.Add(this.lblBackupInterval);
            this.tabBackup.Controls.Add(this.chkAutoBackup);
            this.tabBackup.Location = new System.Drawing.Point(4, 26);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(1102, 650);
            this.tabBackup.TabIndex = 2;
            this.tabBackup.Text = "Sao lưu";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.chkAutoBackup.Location = new System.Drawing.Point(20, 30);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(200, 25);
            this.chkAutoBackup.TabIndex = 0;
            this.chkAutoBackup.Text = "Tự động sao lưu";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            // 
            // lblBackupInterval
            // 
            this.lblBackupInterval.AutoSize = true;
            this.lblBackupInterval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblBackupInterval.Location = new System.Drawing.Point(20, 80);
            this.lblBackupInterval.Name = "lblBackupInterval";
            this.lblBackupInterval.Size = new System.Drawing.Size(150, 21);
            this.lblBackupInterval.TabIndex = 1;
            this.lblBackupInterval.Text = "Chu kỳ sao lưu:";
            // 
            // numBackupInterval
            // 
            this.numBackupInterval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBackupInterval.Location = new System.Drawing.Point(180, 78);
            this.numBackupInterval.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.numBackupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBackupInterval.Name = "numBackupInterval";
            this.numBackupInterval.Size = new System.Drawing.Size(100, 29);
            this.numBackupInterval.TabIndex = 2;
            this.numBackupInterval.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // lblBackupIntervalUnit
            // 
            this.lblBackupIntervalUnit.AutoSize = true;
            this.lblBackupIntervalUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupIntervalUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblBackupIntervalUnit.Location = new System.Drawing.Point(290, 80);
            this.lblBackupIntervalUnit.Name = "lblBackupIntervalUnit";
            this.lblBackupIntervalUnit.Size = new System.Drawing.Size(50, 21);
            this.lblBackupIntervalUnit.TabIndex = 3;
            this.lblBackupIntervalUnit.Text = "giờ";
            // 
            // SettingsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1150, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabNotifications.ResumeLayout(false);
            this.tabNotifications.PerformLayout();
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).EndInit();
            this.ResumeLayout(false);
        }
    }
}


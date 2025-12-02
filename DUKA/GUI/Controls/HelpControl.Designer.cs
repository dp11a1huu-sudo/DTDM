namespace GUI.Controls
{
    partial class HelpControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.RichTextBox rtbHelpContent;
        private System.Windows.Forms.Panel panelHelpTopics;
        private System.Windows.Forms.Button btnGettingStarted;
        private System.Windows.Forms.Button btnBookingGuide;
        private System.Windows.Forms.Button btnEmployeeGuide;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnContact;

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
            this.panelContent = new System.Windows.Forms.Panel();
            this.rtbHelpContent = new System.Windows.Forms.RichTextBox();
            this.panelHelpTopics = new System.Windows.Forms.Panel();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnEmployeeGuide = new System.Windows.Forms.Button();
            this.btnBookingGuide = new System.Windows.Forms.Button();
            this.btnGettingStarted = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelHelpTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
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
            this.lblTitle.Text = "❓ Trợ giúp";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelContent.Controls.Add(this.rtbHelpContent);
            this.panelContent.Controls.Add(this.panelHelpTopics);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(1150, 720);
            this.panelContent.TabIndex = 1;
            // 
            // panelHelpTopics
            // 
            this.panelHelpTopics.BackColor = System.Drawing.Color.White;
            this.panelHelpTopics.Controls.Add(this.btnContact);
            this.panelHelpTopics.Controls.Add(this.btnFAQ);
            this.panelHelpTopics.Controls.Add(this.btnEmployeeGuide);
            this.panelHelpTopics.Controls.Add(this.btnBookingGuide);
            this.panelHelpTopics.Controls.Add(this.btnGettingStarted);
            this.panelHelpTopics.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHelpTopics.Location = new System.Drawing.Point(20, 20);
            this.panelHelpTopics.Name = "panelHelpTopics";
            this.panelHelpTopics.Padding = new System.Windows.Forms.Padding(10);
            this.panelHelpTopics.Size = new System.Drawing.Size(250, 680);
            this.panelHelpTopics.TabIndex = 0;
            // 
            // btnGettingStarted
            // 
            this.btnGettingStarted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGettingStarted.FlatAppearance.BorderSize = 0;
            this.btnGettingStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGettingStarted.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGettingStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnGettingStarted.Location = new System.Drawing.Point(10, 10);
            this.btnGettingStarted.Name = "btnGettingStarted";
            this.btnGettingStarted.Size = new System.Drawing.Size(230, 50);
            this.btnGettingStarted.TabIndex = 0;
            this.btnGettingStarted.Text = "🚀 Bắt đầu";
            this.btnGettingStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGettingStarted.UseVisualStyleBackColor = true;
            // 
            // btnBookingGuide
            // 
            this.btnBookingGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookingGuide.FlatAppearance.BorderSize = 0;
            this.btnBookingGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingGuide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnBookingGuide.Location = new System.Drawing.Point(10, 60);
            this.btnBookingGuide.Name = "btnBookingGuide";
            this.btnBookingGuide.Size = new System.Drawing.Size(230, 50);
            this.btnBookingGuide.TabIndex = 1;
            this.btnBookingGuide.Text = "📅 Hướng dẫn đặt sân";
            this.btnBookingGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingGuide.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeGuide
            // 
            this.btnEmployeeGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeGuide.FlatAppearance.BorderSize = 0;
            this.btnEmployeeGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeGuide.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnEmployeeGuide.Location = new System.Drawing.Point(10, 110);
            this.btnEmployeeGuide.Name = "btnEmployeeGuide";
            this.btnEmployeeGuide.Size = new System.Drawing.Size(230, 50);
            this.btnEmployeeGuide.TabIndex = 2;
            this.btnEmployeeGuide.Text = "👔 Hướng dẫn quản lý";
            this.btnEmployeeGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeGuide.UseVisualStyleBackColor = true;
            // 
            // btnFAQ
            // 
            this.btnFAQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnFAQ.Location = new System.Drawing.Point(10, 160);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(230, 50);
            this.btnFAQ.TabIndex = 3;
            this.btnFAQ.Text = "❓ Câu hỏi thường gặp";
            this.btnFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFAQ.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnContact.Location = new System.Drawing.Point(10, 210);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(230, 50);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "📞 Liên hệ hỗ trợ";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // rtbHelpContent
            // 
            this.rtbHelpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelpContent.BackColor = System.Drawing.Color.White;
            this.rtbHelpContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHelpContent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHelpContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.rtbHelpContent.Location = new System.Drawing.Point(280, 20);
            this.rtbHelpContent.Name = "rtbHelpContent";
            this.rtbHelpContent.ReadOnly = true;
            this.rtbHelpContent.Size = new System.Drawing.Size(850, 680);
            this.rtbHelpContent.TabIndex = 1;
            this.rtbHelpContent.Text = "Chào mừng đến với hệ thống quản lý sân bóng DUKA!\n\nVui lòng chọn một chủ đề ở bên trái để xem hướng dẫn chi tiết.";
            // 
            // HelpControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "HelpControl";
            this.Size = new System.Drawing.Size(1150, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelHelpTopics.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace GUI.Forms
{
    partial class VerificationCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblWaitMessage = new System.Windows.Forms.Label();
            this.linkResend = new System.Windows.Forms.LinkLabel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCode4 = new System.Windows.Forms.TextBox();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLeft.Enabled = false;
            this.pictureBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(400, 700);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.lblWaitMessage);
            this.panelRight.Controls.Add(this.linkResend);
            this.panelRight.Controls.Add(this.btnConfirm);
            this.panelRight.Controls.Add(this.txtCode4);
            this.panelRight.Controls.Add(this.txtCode3);
            this.panelRight.Controls.Add(this.txtCode2);
            this.panelRight.Controls.Add(this.txtCode1);
            this.panelRight.Controls.Add(this.lblInstruction);
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(600, 700);
            this.panelRight.TabIndex = 1;
            // 
            // lblWaitMessage
            // 
            this.lblWaitMessage.AutoSize = true;
            this.lblWaitMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitMessage.ForeColor = System.Drawing.Color.Black;
            this.lblWaitMessage.Location = new System.Drawing.Point(100, 500);
            this.lblWaitMessage.Name = "lblWaitMessage";
            this.lblWaitMessage.Size = new System.Drawing.Size(409, 20);
            this.lblWaitMessage.TabIndex = 8;
            this.lblWaitMessage.Text = "Không nhận được mã xác minh? Vui lòng đợi 60 giây...";
            // 
            // linkResend
            // 
            this.linkResend.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkResend.AutoSize = true;
            this.linkResend.Enabled = false;
            this.linkResend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkResend.LinkColor = System.Drawing.Color.Blue;
            this.linkResend.Location = new System.Drawing.Point(200, 450);
            this.linkResend.Name = "linkResend";
            this.linkResend.Size = new System.Drawing.Size(157, 20);
            this.linkResend.TabIndex = 7;
            this.linkResend.TabStop = true;
            this.linkResend.Text = "Gửi lại mã xác minh";
            this.linkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkResend_LinkClicked);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(100, 400);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(400, 50);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCode4
            // 
            this.txtCode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode4.Location = new System.Drawing.Point(450, 300);
            this.txtCode4.MaxLength = 1;
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.Size = new System.Drawing.Size(50, 53);
            this.txtCode4.TabIndex = 5;
            this.txtCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode4.TextChanged += new System.EventHandler(this.txtCode4_TextChanged);
            this.txtCode4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtCode3
            // 
            this.txtCode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode3.Location = new System.Drawing.Point(350, 300);
            this.txtCode3.MaxLength = 1;
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(50, 53);
            this.txtCode3.TabIndex = 4;
            this.txtCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode3.TextChanged += new System.EventHandler(this.txtCode3_TextChanged);
            this.txtCode3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtCode2
            // 
            this.txtCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode2.Location = new System.Drawing.Point(250, 300);
            this.txtCode2.MaxLength = 1;
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(50, 53);
            this.txtCode2.TabIndex = 3;
            this.txtCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode2.TextChanged += new System.EventHandler(this.txtCode2_TextChanged);
            this.txtCode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtCode1
            // 
            this.txtCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode1.Location = new System.Drawing.Point(150, 300);
            this.txtCode1.MaxLength = 1;
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(50, 53);
            this.txtCode1.TabIndex = 2;
            this.txtCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode1.TextChanged += new System.EventHandler(this.txtCode1_TextChanged);
            this.txtCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.Gray;
            this.lblInstruction.Location = new System.Drawing.Point(100, 150);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(581, 25);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Chúng tôi vừa gửi mã xác nhận đến địa chỉ email bạn đã cung cấp";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(100, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mã xác minh";
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.pictureBoxLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerificationCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã xác minh - DUKA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtCode1;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.TextBox txtCode3;
        private System.Windows.Forms.TextBox txtCode4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.LinkLabel linkResend;
        private System.Windows.Forms.Label lblWaitMessage;

    }
}


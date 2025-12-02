using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Controls;
using System.Linq;

namespace GUI.Controls
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeButtons();
            }
        }

        private void InitializeButtons()
        {
            // Employee Management buttons
            btnEmployeeManagementAccess.Click += (s, e) => OpenEmployeeManagement();
            btnEmployeeManagementDetails.Click += (s, e) => ShowEmployeeManagementDetails();

            // Shift Management buttons
            btnShiftManagementAccess.Click += (s, e) => OpenShiftManagement();
            btnShiftManagementDetails.Click += (s, e) => ShowShiftManagementDetails();

            // Salary Management buttons
            btnSalaryManagementAccess.Click += (s, e) => OpenSalaryManagement();
            btnSalaryManagementDetails.Click += (s, e) => ShowSalaryManagementDetails();
        }

        private void OpenEmployeeManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new EmployeeManagementControl());
            }
        }

        private void ShowEmployeeManagementDetails()
        {
            MessageBox.Show(
                "Quản lý nhân viên:\n\n" +
                "• Quản lý thông tin nhân viên\n" +
                "• Chức vụ và phòng ban\n" +
                "• Lương cơ bản\n" +
                "• Trạng thái hoạt động",
                "Chi tiết - Quản lý nhân viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void OpenShiftManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new ShiftManagementControl());
            }
        }

        private void ShowShiftManagementDetails()
        {
            MessageBox.Show(
                "Quản lý ca làm:\n\n" +
                "• Phân ca làm việc cho nhân viên\n" +
                "• Theo dõi ca làm theo ngày\n" +
                "• Quản lý giờ vào/ra\n" +
                "• Trạng thái ca làm",
                "Chi tiết - Quản lý ca làm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void OpenSalaryManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new SalaryManagementControl());
            }
        }

        private void ShowSalaryManagementDetails()
        {
            MessageBox.Show(
                "Tính lương:\n\n" +
                "• Tính lương theo ca làm việc\n" +
                "• Báo cáo lương theo tháng/năm\n" +
                "• Xuất bảng lương\n" +
                "• Lịch sử thanh toán lương",
                "Chi tiết - Tính lương",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private GUI.MainMenu FindMainMenu()
        {
            Control parent = this.Parent;
            while (parent != null)
            {
                if (parent is GUI.MainMenu mainMenu)
                {
                    return mainMenu;
                }
                parent = parent.Parent;
            }
            return null;
        }
    }
}


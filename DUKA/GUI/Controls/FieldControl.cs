using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Controls;
using System.Linq;

namespace GUI.Controls
{
    public partial class FieldControl : UserControl
    {
        public FieldControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeButtons();
            }
        }

        private void InitializeButtons()
        {
            // Field Information buttons
            btnFieldInfoAccess.Click += (s, e) => OpenFieldManagement();
            btnFieldInfoDetails.Click += (s, e) => ShowFieldInfoDetails();

            // Booking & Payment buttons
            btnBookingAccess.Click += (s, e) => OpenBookingManagement();
            btnBookingDetails.Click += (s, e) => ShowBookingDetails();

            // Facilities buttons
            btnFacilitiesAccess.Click += (s, e) => OpenFacilitiesManagement();
            btnFacilitiesDetails.Click += (s, e) => ShowFacilitiesDetails();

            // Revenue buttons
            btnRevenueAccess.Click += (s, e) => OpenRevenueManagement();
            btnRevenueDetails.Click += (s, e) => ShowRevenueDetails();
        }

        private void OpenFieldManagement()
        {
            // Navigate to field information management
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new FieldInfoManagementControl());
            }
        }

        private void ShowFieldInfoDetails()
        {
            MessageBox.Show(
                "Thông tin sân bóng:\n\n" +
                "• Quản lý thông tin chi tiết sân bóng\n" +
                "• Loại sân (5 người, 7 người, 11 người)\n" +
                "• Diện tích và mặt cỏ\n" +
                "• Giá thuê theo khung giờ\n" +
                "• Trạng thái sân (Hoạt động, Bảo trì)",
                "Chi tiết - Thông tin sân bóng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void OpenBookingManagement()
        {
            // Navigate to booking management
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new BookingManagementControl());
            }
        }

        private void ShowBookingDetails()
        {
            MessageBox.Show(
                "Đặt sân & Thanh toán:\n\n" +
                "• Quản lý đặt sân theo ngày và khung giờ\n" +
                "• Xử lý thanh toán\n" +
                "• Xác nhận đơn đặt sân\n" +
                "• Hủy đặt sân và hoàn tiền",
                "Chi tiết - Đặt sân & Thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void OpenFacilitiesManagement()
        {
            // Navigate to equipment management
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new EquipmentManagementControl());
            }
        }

        private void ShowFacilitiesDetails()
        {
            MessageBox.Show(
                "Cơ sở vật chất:\n\n" +
                "• Theo dõi và quản lý trang thiết bị\n" +
                "• Lập phiếu bảo trì\n" +
                "• Sửa chữa kịp thời\n" +
                "• Lịch sử bảo trì",
                "Chi tiết - Cơ sở vật chất",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void OpenRevenueManagement()
        {
            // Navigate to revenue management
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new RevenueManagementControl());
            }
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

        private void ShowRevenueDetails()
        {
            MessageBox.Show(
                "Doanh thu:\n\n" +
                "• Tổng hợp doanh thu từ các đơn đặt sân\n" +
                "• Doanh thu từ dịch vụ phụ trợ\n" +
                "• Báo cáo doanh thu theo ngày/tháng/năm\n" +
                "• Phân tích xu hướng doanh thu",
                "Chi tiết - Doanh thu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}


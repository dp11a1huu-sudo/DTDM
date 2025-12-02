using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Controls;
using System.Linq;

namespace GUI.Controls
{
    public partial class ServiceManagementControl : UserControl
    {
        public ServiceManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeButtons();
            }
        }

        private void InitializeButtons()
        {
            // Tab 1: Dịch vụ ăn uống
            btnMenuManagementAccess.Click += (s, e) => ShowMenuManagement();
            btnMenuManagementDetails.Click += (s, e) => ShowMenuManagementDetails();
            
            btnOrderManagementAccess.Click += (s, e) => ShowOrderManagement();
            btnOrderManagementDetails.Click += (s, e) => ShowOrderManagementDetails();
            
            btnFoodReportsAccess.Click += (s, e) => ShowFoodReports();
            btnFoodReportsDetails.Click += (s, e) => ShowFoodReportsDetails();

            // Tab 2: Cho thuê thiết bị
            btnEquipmentManagementAccess.Click += (s, e) => ShowEquipmentManagement();
            btnEquipmentManagementDetails.Click += (s, e) => ShowEquipmentManagementDetails();
            
            btnRentalManagementAccess.Click += (s, e) => ShowRentalManagement();
            btnRentalManagementDetails.Click += (s, e) => ShowRentalManagementDetails();
            
            btnMaintenanceAccess.Click += (s, e) => ShowMaintenance();
            btnMaintenanceDetails.Click += (s, e) => ShowMaintenanceDetails();
            
            btnRentalReportsAccess.Click += (s, e) => ShowRentalReports();
            btnRentalReportsDetails.Click += (s, e) => ShowRentalReportsDetails();
        }

        // Tab 1: Dịch vụ ăn uống
        private void ShowMenuManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new FoodMenuManagementControl());
            }
        }

        private void ShowMenuManagementDetails()
        {
            MessageBox.Show(
                "Quản lý Menu/Món ăn:\n\n" +
                "• Thêm/sửa/xóa món ăn\n" +
                "• Quản lý danh mục (đồ ăn/nước uống/combo)\n" +
                "• Quản lý giá bán và giá vốn\n" +
                "• Quản lý tồn kho và đơn vị tính\n" +
                "• Trạng thái món (còn hàng/hết hàng)\n" +
                "• Tìm kiếm và lọc theo danh mục, giá, trạng thái",
                "Chi tiết - Quản lý Menu/Món ăn",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowOrderManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new FoodOrderManagementControl());
            }
        }

        private void ShowOrderManagementDetails()
        {
            MessageBox.Show(
                "Quản lý đơn hàng:\n\n" +
                "• Tạo đơn hàng mới\n" +
                "• Xem chi tiết đơn hàng\n" +
                "• Cập nhật trạng thái (chờ xử lý → đang chuẩn bị → hoàn thành)\n" +
                "• Thanh toán đơn hàng\n" +
                "• In hóa đơn\n" +
                "• Chọn khách hàng/sân đang đặt\n" +
                "• Chọn món với số lượng\n" +
                "• Tính tổng tự động",
                "Chi tiết - Quản lý đơn hàng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowFoodReports()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new FoodReportsControl());
            }
        }

        private void ShowFoodReportsDetails()
        {
            MessageBox.Show(
                "Báo cáo & Thống kê:\n\n" +
                "• Biểu đồ doanh thu theo thời gian\n" +
                "• Top món bán chạy\n" +
                "• Phân tích lợi nhuận (doanh thu - giá vốn)\n" +
                "• Thống kê tổng doanh thu hôm nay/tháng\n" +
                "• Số đơn hàng đang xử lý\n" +
                "• Tồn kho cảnh báo",
                "Chi tiết - Báo cáo & Thống kê",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Tab 2: Cho thuê thiết bị
        private void ShowEquipmentManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new RentalEquipmentManagementControl());
            }
        }

        private void ShowEquipmentManagementDetails()
        {
            MessageBox.Show(
                "Quản lý danh mục thiết bị:\n\n" +
                "• Thêm/sửa/xóa thiết bị\n" +
                "• Quản lý loại thiết bị (bóng, giày, áo, bảo hộ, etc.)\n" +
                "• Quản lý giá thuê (theo giờ/ngày)\n" +
                "• Quản lý số lượng tổng và khả dụng\n" +
                "• Cập nhật tình trạng (tốt/cần bảo trì/hỏng)\n" +
                "• Ngày mua và hạn bảo hành\n" +
                "• Tìm kiếm và lọc",
                "Chi tiết - Quản lý danh mục thiết bị",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowRentalManagement()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new RentalManagementControl());
            }
        }

        private void ShowRentalManagementDetails()
        {
            MessageBox.Show(
                "Quản lý cho thuê:\n\n" +
                "• Tạo đơn thuê mới\n" +
                "• Xem chi tiết đơn thuê\n" +
                "• Xác nhận trả thiết bị\n" +
                "• Thanh toán\n" +
                "• Báo cáo hư hỏng/mất mát\n" +
                "• Chọn khách hàng và thiết bị\n" +
                "• Kiểm tra availability\n" +
                "• Quản lý tiền đặt cọc",
                "Chi tiết - Quản lý cho thuê",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowMaintenance()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new RentalMaintenanceControl());
            }
        }

        private void ShowMaintenanceDetails()
        {
            MessageBox.Show(
                "Theo dõi & Bảo trì:\n\n" +
                "• Ghi nhận bảo trì\n" +
                "• Cảnh báo thiết bị cần bảo trì\n" +
                "• Lịch sử bảo trì\n" +
                "• Theo dõi tình trạng thiết bị\n" +
                "• Lần bảo trì cuối\n" +
                "• Lịch bảo trì tiếp theo",
                "Chi tiết - Theo dõi & Bảo trì",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ShowRentalReports()
        {
            var mainMenu = FindMainMenu();
            if (mainMenu != null)
            {
                mainMenu.OpenChildControl(new RentalReportsControl());
            }
        }

        private void ShowRentalReportsDetails()
        {
            MessageBox.Show(
                "Báo cáo & Thống kê:\n\n" +
                "• Doanh thu cho thuê theo thời gian\n" +
                "• Thiết bị được thuê nhiều nhất\n" +
                "• Tỷ lệ sử dụng thiết bị\n" +
                "• Chi phí bảo trì\n" +
                "• Thống kê tổng thiết bị\n" +
                "• Đang cho thuê\n" +
                "• Thiết bị cần bảo trì",
                "Chi tiết - Báo cáo & Thống kê",
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

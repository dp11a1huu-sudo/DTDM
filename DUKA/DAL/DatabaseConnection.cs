using System;
using System.Data.SqlClient;

namespace DAL
{
    public static class DatabaseConnection
    {
        // Cấu hình kết nối database trên localhost
        private static string server = "localhost";
        private static string database = "DUKA_FootballManagement";
        private static bool useWindowsAuth = true;
        private static string username = "sa";
        private static string password = "";

        /// <summary>
        /// Tạo chuỗi kết nối đến database
        /// </summary>
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = server;
            builder.InitialCatalog = database;
            builder.IntegratedSecurity = useWindowsAuth;

            if (!useWindowsAuth)
            {
                builder.UserID = username;
                builder.Password = password;
            }

            // Tăng thời gian chờ kết nối
            builder.ConnectTimeout = 30;

            return builder.ConnectionString;
        }

        /// <summary>
        /// Kiểm tra kết nối database
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi kết nối database: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Tạo đối tượng SqlConnection mới
        /// </summary>
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        /// <summary>
        /// Cập nhật cấu hình kết nối (nếu cần thay đổi)
        /// </summary>
        public static void UpdateConnection(string newServer, string newDatabase, bool useWinAuth = true, string newUsername = "", string newPassword = "")
        {
            server = newServer;
            database = newDatabase;
            useWindowsAuth = useWinAuth;
            if (!useWinAuth)
            {
                username = newUsername;
                password = newPassword;
            }
        }
    }
}


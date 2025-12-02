using DAL;
using GUI.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Debug: Kiểm tra file exe mới được load
            Debug.WriteLine($"=== DUKA Application Started ===");
            Debug.WriteLine($"Build Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            Debug.WriteLine($"Working Directory: {Environment.CurrentDirectory}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Bỏ qua đăng nhập và cấu hình, vào thẳng MainMenu
            Debug.WriteLine("Starting MainMenu...");
            Application.Run(new MainMenu("Admin", "Admin"));
        }

    }
}

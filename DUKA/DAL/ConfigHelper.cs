using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // Thêm reference: System.Configuration
using System.Data.SqlClient; // Thêm reference: System.Data

namespace DAL
{
    public static class ConfigHelper
    {
        // Đọc một setting từ App.config
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                return appSettings[key] ?? null; // Trả về null nếu key không tồn tại
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return null;
            }
        }

        // Ghi (hoặc thêm mới) một setting vào App.config
        public static void WriteSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        // Xây dựng Connection String từ các setting đã lưu
        public static string BuildConnectionString()
        {
            var server = ReadSetting("DbServer");
            var db = ReadSetting("DbName");
            var useWindowsAuth = ReadSetting("DbUseWindowsAuth") == "true";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = server;
            builder.InitialCatalog = db;
            builder.IntegratedSecurity = useWindowsAuth;

            if (!useWindowsAuth)
            {
                builder.UserID = ReadSetting("DbUser");
                // Cần giải mã password nếu bạn đã mã hóa nó
                builder.Password = ReadSetting("DbPassword");
            }

            return builder.ConnectionString;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load current settings
            chkEmailNotifications.Checked = true;
            chkSMSNotifications.Checked = false;
            chkAutoBackup.Checked = true;
            numBackupInterval.Value = 24;
            cmbLanguage.SelectedIndex = 0;
            cmbTheme.SelectedIndex = 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class SidebarControl : UserControl
    {
        public event EventHandler<string> MenuItemClicked;
        
        private List<MenuItemInfo> menuItems;
        private string activeMenuItemId;
        private Dictionary<string, bool> expandedMenus;

        public SidebarControl()
        {
            InitializeComponent();
            menuItems = new List<MenuItemInfo>();
            expandedMenus = new Dictionary<string, bool>();
            activeMenuItemId = "dashboard";
        }

        public void SetWelcomeText(string text)
        {
            if (lblWelcome != null)
            {
                lblWelcome.Text = text;
            }
        }

        public void SetLogo(Image logo)
        {
            if (logo != null && pictureBoxLogo != null)
            {
                pictureBoxLogo.Image = logo;
                pictureBoxLogo.Visible = true;
                lblWelcome.Visible = false;
            }
            else if (pictureBoxLogo != null)
            {
                pictureBoxLogo.Visible = false;
                if (lblWelcome != null)
                {
                    lblWelcome.Visible = true;
                    lblWelcome.Text = "DUKA\nFOOTBALL MANAGEMENT";
                }
            }
        }

        public void AddMenuItem(string id, string text, string icon = "", List<SubMenuItemInfo> subItems = null)
        {
            menuItems.Add(new MenuItemInfo
            {
                Id = id,
                Text = text,
                Icon = icon,
                SubItems = subItems ?? new List<SubMenuItemInfo>()
            });
            
            // Only refresh if control is ready
            if (this.IsHandleCreated && panelMenuContainer != null)
            {
                RefreshMenu();
            }
        }

        public void SetActiveMenuItem(string id)
        {
            activeMenuItemId = id;
            RefreshMenu();
        }

        private void RefreshMenu()
        {
            // Check if panelMenuContainer is ready
            if (panelMenuContainer == null || !this.IsHandleCreated)
                return;

            // Clear existing menu buttons
            var buttonsToRemove = panelMenuContainer.Controls.OfType<Button>()
                .Where(ctrl => ctrl.Tag != null && ctrl.Tag.ToString().StartsWith("MENU_"))
                .ToList();
            
            foreach (var ctrl in buttonsToRemove)
            {
                panelMenuContainer.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            // Clear sub-menu panels
            var panelsToRemove = panelMenuContainer.Controls.OfType<Panel>()
                .Where(ctrl => ctrl.Tag != null && ctrl.Tag.ToString().StartsWith("SUBMENU_"))
                .ToList();
            
            foreach (var ctrl in panelsToRemove)
            {
                panelMenuContainer.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            int yPosition = 0; // Start from top of container (padding handled by container)
            foreach (var item in menuItems)
            {
                // Create main menu button
                Button btnMenu = CreateMenuButton(item, yPosition);
                panelMenuContainer.Controls.Add(btnMenu);
                yPosition += 53; // 45px height + 8px margin (mb-2)

                // Create sub-menu panel if expanded
                if (item.SubItems.Count > 0 && expandedMenus.ContainsKey(item.Id) && expandedMenus[item.Id])
                {
                    Panel subMenuPanel = CreateSubMenuPanel(item, yPosition);
                    panelMenuContainer.Controls.Add(subMenuPanel);
                    yPosition += (item.SubItems.Count * 53); // 45px height + 8px margin per item
                }
            }

            // AutoScroll will handle scrolling automatically
            panelMenuContainer.Invalidate();
        }

        private Button CreateMenuButton(MenuItemInfo item, int yPosition)
        {
            // Check if this menu item or any of its sub-items is active
            bool isActive = (activeMenuItemId == item.Id && item.SubItems.Count == 0);
            bool hasActiveSubItem = item.SubItems.Any(sub => sub.Id == activeMenuItemId);
            bool shouldHighlight = isActive || hasActiveSubItem;
            
            // Build text with icon on left and expand/collapse on right
            // Use ☐ for unselected and ☒ for selected
            string iconSymbol = shouldHighlight ? "☒" : "☐";
            string buttonText = $"{iconSymbol} {item.Text}";
            if (item.SubItems.Count > 0)
            {
                bool isExpanded = expandedMenus.ContainsKey(item.Id) && expandedMenus[item.Id];
                buttonText = $"{iconSymbol} {item.Text}        {(isExpanded ? "▼" : "▶")}";
            }
            
            Button btn = new Button
            {
                Name = $"btn{item.Id}",
                Text = buttonText,
                Location = new Point(0, yPosition),
                Size = new Size(220, 45),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = shouldHighlight 
                    ? Color.FromArgb(0, 150, 255) // Active text color
                    : Color.White, // Inactive text color
                BackColor = shouldHighlight 
                    ? Color.FromArgb(65, 65, 85) // Active background
                    : Color.Transparent, // Inactive background
                Padding = new Padding(20, 0, 0, 0),
                Tag = $"MENU_{item.Id}",
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 0, 8) // mb-2
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = shouldHighlight 
                ? Color.FromArgb(65, 65, 85) 
                : Color.FromArgb(45, 45, 55); // hover background
            
            btn.Click += (s, e) => OnMenuItemClick(item);
            btn.MouseEnter += (s, e) => 
            {
                if (!shouldHighlight)
                {
                    btn.BackColor = Color.FromArgb(45, 45, 55);
                }
            };
            btn.MouseLeave += (s, e) => 
            {
                if (!shouldHighlight)
                {
                    btn.BackColor = Color.Transparent;
                }
            };

            return btn;
        }

        private Panel CreateSubMenuPanel(MenuItemInfo item, int yPosition)
        {
            Panel panel = new Panel
            {
                Location = new Point(0, yPosition),
                Size = new Size(220, item.SubItems.Count * 53),
                BackColor = Color.Transparent,
                Tag = $"SUBMENU_{item.Id}",
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            int subY = 0;
            foreach (var subItem in item.SubItems)
            {
                bool isSubActive = (activeMenuItemId == subItem.Id);
                
                // Use ☐ for unselected and ☒ for selected
                string iconSymbol = isSubActive ? "☒" : "☐";
                
                Button btnSub = new Button
                {
                    Name = $"btn{subItem.Id}",
                    Text = $"{iconSymbol} {subItem.Text}",
                    Location = new Point(20, subY), // Indent for sub-items
                    Size = new Size(200, 45),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = isSubActive 
                        ? Color.FromArgb(0, 150, 255) // Active text color
                        : Color.White, // Inactive text color
                    BackColor = isSubActive 
                        ? Color.FromArgb(65, 65, 85) // Active background
                        : Color.Transparent, // Inactive background
                    Padding = new Padding(20, 0, 0, 0),
                    Tag = $"SUBMENU_{subItem.Id}",
                    Cursor = Cursors.Hand,
                    Margin = new Padding(0, 0, 0, 8) // mb-2
                };

                btnSub.FlatAppearance.BorderSize = 0;
                btnSub.FlatAppearance.MouseOverBackColor = isSubActive 
                    ? Color.FromArgb(65, 65, 85) 
                    : Color.FromArgb(45, 45, 55); // hover background
                
                btnSub.Click += (s, e) => OnSubMenuItemClick(subItem);
                btnSub.MouseEnter += (s, e) => 
                {
                    if (!isSubActive)
                    {
                        btnSub.BackColor = Color.FromArgb(45, 45, 55);
                    }
                };
                btnSub.MouseLeave += (s, e) => 
                {
                    if (!isSubActive)
                    {
                        btnSub.BackColor = Color.Transparent;
                    }
                };
                
                panel.Controls.Add(btnSub);
                subY += 45;
            }

            return panel;
        }

        private void OnMenuItemClick(MenuItemInfo item)
        {
            if (item.SubItems.Count > 0)
            {
                // Toggle expand/collapse
                if (expandedMenus.ContainsKey(item.Id))
                {
                    expandedMenus[item.Id] = !expandedMenus[item.Id];
                }
                else
                {
                    expandedMenus[item.Id] = true;
                }
                RefreshMenu();
            }
            else
            {
                // Fire event for main menu item
                activeMenuItemId = item.Id;
                MenuItemClicked?.Invoke(this, item.Id);
                RefreshMenu();
            }
        }

        private void OnSubMenuItemClick(SubMenuItemInfo subItem)
        {
            activeMenuItemId = subItem.Id;
            MenuItemClicked?.Invoke(this, subItem.Id);
            RefreshMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SidebarControl_Load(object sender, EventArgs e)
        {
            // Refresh menu when control is loaded
            if (menuItems.Count > 0)
            {
                RefreshMenu();
            }
        }

        private void SidebarControl_Paint(object sender, PaintEventArgs e)
        {
            // Draw right border (border-r border-gray-200)
            using (Pen borderPen = new Pen(Color.FromArgb(229, 231, 235), 1)) // border-gray-200
            {
                e.Graphics.DrawLine(borderPen, this.Width - 1, 0, this.Width - 1, this.Height);
            }
        }


        private class MenuItemInfo
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public string Icon { get; set; }
            public List<SubMenuItemInfo> SubItems { get; set; }
        }

        public class SubMenuItemInfo
        {
            public string Id { get; set; }
            public string Text { get; set; }
        }
    }
}


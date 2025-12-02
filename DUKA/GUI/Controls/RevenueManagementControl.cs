using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RevenueManagementControl : UserControl
    {
        private bool isInitialized = false;

        public RevenueManagementControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Load += RevenueManagementControl_Load;
            }
        }

        private void RevenueManagementControl_Load(object sender, EventArgs e)
        {
            if (isInitialized) return;
            
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (!isInitialized && dgvRevenue != null)
                            {
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
            LoadSampleData();
                                FormatDataGridView();
                                isInitialized = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error in BeginInvoke: {ex.Message}");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RevenueManagementControl_Load: {ex.Message}");
            }
        }

        private void LoadSampleData()
        {
            try
            {
                if (dgvRevenue == null) return;
                
                dgvRevenue.AutoGenerateColumns = true;
                
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("InvoiceCount", typeof(string));
            dt.Columns.Add("Revenue", typeof(string));

            dt.Rows.Add("01/01/2025", "12", "3.600.000 đ");
            dt.Rows.Add("02/01/2025", "15", "4.500.000 đ");
            dt.Rows.Add("03/01/2025", "10", "3.000.000 đ");
            dt.Rows.Add("04/01/2025", "18", "5.400.000 đ");
            dt.Rows.Add("05/01/2025", "14", "4.200.000 đ");
                dt.Rows.Add("06/01/2025", "20", "6.000.000 đ");
                dt.Rows.Add("07/01/2025", "16", "4.800.000 đ");

                dgvRevenue.DataBindingComplete -= DgvRevenue_DataBindingComplete;
                dgvRevenue.DataBindingComplete += DgvRevenue_DataBindingComplete;

                dgvRevenue.DataSource = null;
            dgvRevenue.DataSource = dt;
                dgvRevenue.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in LoadSampleData: {ex.Message}");
            }
        }

        private void DgvRevenue_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvRevenue != null)
                {
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DgvRevenue_DataBindingComplete: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            if (dgvRevenue == null || dgvRevenue.Columns == null || dgvRevenue.Columns.Count == 0) return;

            try
            {
                if (dgvRevenue.Columns["Date"] != null)
                {
                    dgvRevenue.Columns["Date"].HeaderText = "Ngày";
                    dgvRevenue.Columns["Date"].Width = 150;
                }
                if (dgvRevenue.Columns["InvoiceCount"] != null)
                {
                    dgvRevenue.Columns["InvoiceCount"].HeaderText = "Số hóa đơn";
                    dgvRevenue.Columns["InvoiceCount"].Width = 150;
                }
                if (dgvRevenue.Columns["Revenue"] != null)
                {
                    dgvRevenue.Columns["Revenue"].HeaderText = "Doanh thu";
                    dgvRevenue.Columns["Revenue"].Width = 200;
                }

                dgvRevenue.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgvRevenue.GridColor = Color.FromArgb(229, 231, 235);
                dgvRevenue.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                foreach (DataGridViewRow row in dgvRevenue.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null && cell.Style != null)
                        {
                            cell.Style.SelectionBackColor = Color.FromArgb(230, 224, 255);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error formatting DataGridView: {ex.Message}");
            }
        }
    }
}

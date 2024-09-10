using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Center the buttons
            btnReportIssues.Left = centerX - (btnReportIssues.Width / 2);
            btnLocalEvents.Left = centerX - (btnLocalEvents.Width / 2);
            btnServiceRequestStatus.Left = centerX - (btnServiceRequestStatus.Width / 2);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the form to open in maximized mode
            this.WindowState = FormWindowState.Maximized;

            // Disable other buttons
            btnLocalEvents.Enabled = false;
            btnServiceRequestStatus.Enabled = false;

            // Set background color and layout
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "Municipal Services Portal";
            lblHeader.Text = "Welcome to Municipal Services";
            lblHeader.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Event handler to resize form and re-center controls when window size changes
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
        }

        // This method is triggered when the form is resized to re-center the buttons dynamically
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        // This method is to center the buttons on the form relative to the form's width
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            
            btnReportIssues.Left = centerX - (btnReportIssues.Width / 2);
            btnLocalEvents.Left = centerX - (btnLocalEvents.Width / 2);
            btnServiceRequestStatus.Left = centerX - (btnServiceRequestStatus.Width / 2);
        }

        // This event handler is for the "Report Issues" button, opens the Report Issues form
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();
        }

     

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sets the form to open in maximized mode
            this.WindowState = FormWindowState.Maximized;


            // Sets background color and layout
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "Municipal Services Portal";
            lblHeader.Text = "Welcome to Municipal Services";
            lblHeader.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
        }

        // This event handler is for the "Local Events/Announcements" button
        // Displays a message indicating that the feature is not yet available
        private void btnLocalEvents_Click_1(object sender, EventArgs e)
        {
           
                MessageBox.Show("This feature will be implemented later!", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        // This event handler is for the "Service Request Status" button
        // Displays a message indicating that the feature is not yet available
        private void btnServiceRequestStatus_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implemented later!", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

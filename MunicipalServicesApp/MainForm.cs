using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        // Constructor for the main form, initializing the form and setting up event handlers
        public MainForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
        }

        // Event handler for when the form is resized
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls(); // Adjust controls when the form is resized
        }

        // Centers the controls on the form horizontally
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2; // Calculates the horizontal center of the form

            // Adjust the position of buttons to be centered
            btnReportIssues.Left = centerX - (btnReportIssues.Width / 6);
            btnLocalEvents.Left = centerX - (btnLocalEvents.Width / 6);
            btnServiceRequestStatus.Left = centerX - (btnServiceRequestStatus.Width / 6);
            btnSettings.Left = centerX - (btnSettings.Width / 6);
        }

        // Event handler for the "Report Issues" button click, opens the ReportIssuesForm
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReportIssuesForm()); // Open the report issues form
        }

        // Loads the form, sets its appearance and label settings
        private void MainForm_Load(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "Municipal Services Portal";
            lblHeader.Text = "Municipal Services";
            lblHeader.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
        }

        // Event handler for the "Local Events" button click, opens the LocalEventsForm
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            OpenNewForm(new LocalEventsForm());
        }

        // Opens a new form and hides the current form
        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Show(); // Show the main form when the new form is closed
            newForm.Show(); // Show the new form
            this.Hide(); // Hide the current form
        }

        // Event handler for the "Service Request Status" button click, displays a message
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ServiceRequestStatusForm());
        }

        // Event handler for the "Settings" button click, opens the SettingsForm
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SettingsForm());
        }

        // Event handler for form closing, exits the application
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
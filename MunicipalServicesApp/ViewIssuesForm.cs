using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ViewIssuesForm : Form
    {
        private List<Issue> reportedIssues;

        public ViewIssuesForm(List<Issue> issues)
        {
            // Attach event handler to trigger when form is resized, enabling dynamic re-centering of controls.
            InitializeComponent();
            //uses the list to display issues
            reportedIssues = issues;
            this.Resize += new EventHandler(Form_Resize);
        }

        // This Triggers when the form is resized; adjusts control positions dynamically.
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls(); // Ensures controls remain centered as the form size changes.
        }

        // Centers the buttons and other controls relative to the form's width for consistent layout.
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Centers the textboxes, buttons, and listbox
            txtFilterLocation.Left = centerX - (txtFilterLocation.Width / 2);
            btnFilter.Left = centerX - (btnFilter.Width / 2);
            lstIssues.Left = centerX - (lstIssues.Width / 2);
            btnBackToMainMenu.Left = centerX - (btnBackToMainMenu.Width / 2);
            btnReportIssue.Left = centerX - (btnReportIssue.Width / 2);
        }

        // Event handler for filtering the issues based of the location entered; validates and updates the lisbox.\
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedLocation = txtFilterLocation.Text; //uses the selected location and changes it to text

            var filteredIssues = reportedIssues
                .Where(issue => issue.Location.Equals(selectedLocation, StringComparison.OrdinalIgnoreCase))
                .ToList(); //uses the list and allows the data to be used for filterig, if the location enetered = to the location in the list then it displays

            lstIssues.Items.Clear();
            int issueNumber = 1;

            //sorts through the lists and displays it by issue number, location, category, description and attachment for each issue
            foreach (var issue in filteredIssues)
            {
                lstIssues.Items.Add($"Issue {issueNumber++}:");
                lstIssues.Items.Add($"Location: {issue.Location}");
                lstIssues.Items.Add($"Category: {issue.Category}");
                lstIssues.Items.Add($"Description: {issue.Description}");
                lstIssues.Items.Add($"Attachment: {issue.Attachment}");
                lstIssues.Items.Add(""); // Empty line between issues
            }

            if (!filteredIssues.Any())
            {
                MessageBox.Show("No issues found for the specified location."); //message box displaying if no location was found
            }
        }

        // This event handler allows for the direction back to the main menu
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        // This event handler allows for the direction back to the Report Issue page
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
        }

        private void ViewIssuesForm_Load(object sender, EventArgs e)
        {
            // Sets the form to open in maximized mode
            this.WindowState = FormWindowState.Maximized;
        }

        private void lstIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handles issue selection if needed
        }
    }
}

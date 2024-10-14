using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ViewIssuesForm : Form
    {
        private List<Issue> reportedIssues; // List to hold reported issues

        // Constructor to initialize the ViewIssuesForm with a list of issues
        public ViewIssuesForm(List<Issue> issues)
        {
            InitializeComponent();
            reportedIssues = issues; // Assigns the provided list of issues to the local variable
            this.Resize += new EventHandler(Form_Resize);
            this.FormClosing += ViewIssuesForm_FormClosing;
        }

        // Event handler for form resizing
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        // Method to center controls on the form
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            // Centering labels, text boxes, buttons, and list box
            lblFilterLocation.Left = centerX - (lblFilterLocation.Width / 4);
            txtFilterLocation.Left = centerX - (txtFilterLocation.Width / 2);
            btnFilter.Left = centerX - (btnFilter.Width / 2);
            lstIssues.Left = centerX - (lstIssues.Width / 2);
            btnBackToMainMenu.Left = centerX - (btnBackToMainMenu.Width / 2);
            btnReportIssue.Left = centerX - (btnReportIssue.Width / 2);
        }

        // Event handler for the Filter button click
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedLocation = txtFilterLocation.Text;

            // Filter issues based on the selected location
            var filteredIssues = reportedIssues
                .Where(issue => issue.Location.Equals(selectedLocation, StringComparison.OrdinalIgnoreCase))
                .ToList();

            lstIssues.Items.Clear(); // Clear the existing items in the list
            int issueNumber = 1; // Initialize issue counter

            // Loop through the filtered issues and add them to the list
            foreach (var issue in filteredIssues)
            {
                lstIssues.Items.Add($"Issue {issueNumber++}:"); 
                lstIssues.Items.Add($"Location: {issue.Location}");
                lstIssues.Items.Add($"Category: {issue.Category}");
                lstIssues.Items.Add($"Description: {issue.Description}");
                lstIssues.Items.Add($"Attachment: {issue.Attachment}");
                lstIssues.Items.Add(""); // Empty line between issues
            }

            // If no issues were found, show a message
            if (!filteredIssues.Any())
            {
                MessageBox.Show("No issues found for the specified location.");
            }
        }

        // Event handler for the Back to Main Menu button click
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MainForm());
        }

        // Event handler for the Report Issue button click
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReportIssuesForm());
        }

        // Method to open a new form and close the current one
        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        // Event handler for form load event
        private void ViewIssuesForm_Load(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Maximized;
        }

        // Event handler for form closing
        private void ViewIssuesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void lstIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFilterLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
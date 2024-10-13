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
            InitializeComponent();
            reportedIssues = issues;
            this.Resize += new EventHandler(Form_Resize);
            this.FormClosing += ViewIssuesForm_FormClosing;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;

            lblFilterLocation.Left = centerX - (lblFilterLocation.Width / 4);
            txtFilterLocation.Left = centerX - (txtFilterLocation.Width / 2);
            btnFilter.Left = centerX - (btnFilter.Width / 2);
            lstIssues.Left = centerX - (lstIssues.Width / 2);
            btnBackToMainMenu.Left = centerX - (btnBackToMainMenu.Width / 2);
            btnReportIssue.Left = centerX - (btnReportIssue.Width / 2);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedLocation = txtFilterLocation.Text;

            var filteredIssues = reportedIssues
                .Where(issue => issue.Location.Equals(selectedLocation, StringComparison.OrdinalIgnoreCase))
                .ToList();

            lstIssues.Items.Clear();
            int issueNumber = 1;

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
                MessageBox.Show("No issues found for the specified location.");
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MainForm());
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReportIssuesForm());
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void ViewIssuesForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ViewIssuesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void lstIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handles issue selection if needed
        }

        private void lblFilterLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
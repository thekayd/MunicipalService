using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        // Static list to store reported issues, which persists across all instances of this form.
        private static List<Issue> reportedIssues = new List<Issue>();

        public ReportIssuesForm()
        {
            // Attach event handler to trigger when form is resized, enabling dynamic re-centering of controls.
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
        }

        // This method is triggered when the form is resized to re-center the buttons dynamically
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls(); // Ensures controls remain centered as the form size changes.
        }

        // This method is to center the buttons on the form relative to the form's width
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int offsetY = panelHeader.Height + 20; 

            lblLocation.Top = offsetY + 20; 
            txtLocation.Top = lblLocation.Bottom + 10;
            btnSaveLocation.Top = txtLocation.Top;

            lblCategory.Top = txtLocation.Bottom + 20;
            cmbCategory.Top = lblCategory.Bottom + 10;

            lblDescription.Top = cmbCategory.Bottom + 20;
            txtDescription.Top = lblDescription.Bottom + 10;
            btnSaveDescription.Top = txtDescription.Top;

            lblAttachment.Top = txtDescription.Bottom + 20;
            txtAttachment.Top = lblAttachment.Bottom + 10;
            btnAttachMedia.Top = txtAttachment.Top;

            btnSubmit.Top = txtAttachment.Bottom + 20;
            lblEngagement.Top = btnSubmit.Bottom + 20;
            progressBar.Top = lblEngagement.Bottom + 10;
            btnViewIssues.Top = progressBar.Bottom + 20;
            btnBackToMenu.Top = btnViewIssues.Bottom + 20;

            // Centers controls horizontally
            lblLocation.Left = centerX - (lblLocation.Width / 2);
            txtLocation.Left = centerX - (txtLocation.Width / 2);
            btnSaveLocation.Left = txtLocation.Right + 10;

            lblCategory.Left = centerX - (lblCategory.Width / 2);
            cmbCategory.Left = centerX - (cmbCategory.Width / 2);

            lblDescription.Left = centerX - (lblDescription.Width / 2);
            txtDescription.Left = centerX - (txtDescription.Width / 2);
            btnSaveDescription.Left = txtDescription.Right + 10;

            lblAttachment.Left = centerX - (lblAttachment.Width / 2);
            txtAttachment.Left = centerX - (txtAttachment.Width / 2);
            btnAttachMedia.Left = txtAttachment.Right + 10;

            btnSubmit.Left = centerX - (btnSubmit.Width / 2);
            lblEngagement.Left = centerX - (lblEngagement.Width / 2);
            progressBar.Left = centerX - (progressBar.Width / 2);
            btnViewIssues.Left = centerX - (btnViewIssues.Width / 2);
            btnBackToMenu.Left = centerX - (btnBackToMenu.Width / 2);
        }

        // This event handler is for saving location; validates and updates the progress bar.
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            // Validates location input
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location."); // Alerts if location input is missing.
                return;
            }

            // Updates progress bar to 20%
            progressBar.Value = 20;
            progressBar.ForeColor = System.Drawing.Color.Orange;
        }

        // This event handler is for saving description; validates and updates the progress bar.
        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            // Validates description input
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Updates progress bar to 60%
            progressBar.Value = 60;
            progressBar.ForeColor = System.Drawing.Color.Yellow;
        }

        // This event handler is for category selection; updates progress bar based on user input.
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates progress bar to 40%
            progressBar.Value = 40;
            progressBar.ForeColor = System.Drawing.Color.Green;
        }

        // This event handler is for media attachment; opens file dialog to select and attach media files.
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter to allow only specific image file types.
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = openFileDialog.FileName;

                    // Updates progress bar to 80%
                    progressBar.Value = 80;
                    progressBar.ForeColor = System.Drawing.Color.Blue;
                }
            }
        }

        // This event handler is for submitting the report; validates all fields and submits the issue.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all inputs are completed
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) &&
                !string.IsNullOrWhiteSpace(txtDescription.Text) &&
                cmbCategory.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtAttachment.Text))
            {
                // Creates a new issue with the entered details and adds it to the static list.
                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = txtDescription.Text,
                    Attachment = txtAttachment.Text
                };

                // Stores the reported issue.
                reportedIssues.Add(newIssue);

                // Updates progress bar to 100%
                progressBar.Value = 100;

                // Displays success dialog box
                DialogResult result = MessageBox.Show("Issue has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If the user clicks OK, reset the form and progress bar
                if (result == DialogResult.OK)
                {
                    // Resets the form for new inputs
                    txtLocation.Clear();
                    txtDescription.Clear();
                    cmbCategory.SelectedIndex = -1; // Reset the ComboBox
                    txtAttachment.Clear();

                    // Resets the progress bar to 0%
                    progressBar.Value = 0;
                }
            }
            else
            {
                // Shows a message if some inputs are missing
                MessageBox.Show("Please complete all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This event handler is for viewing all reported issues; opens the view form with the reported issues list.
        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            // Passes the static list to the view form
            ViewIssuesForm viewForm = new ViewIssuesForm(reportedIssues);
            viewForm.Show();
        }

        // This event handler is for navigating back to the main menu; closes the current form.
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            MainForm menuForm = new MainForm();
            menuForm.Show();
            this.Close(); // Closes the current form
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Sets the form to open in maximized (full screen) mode
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

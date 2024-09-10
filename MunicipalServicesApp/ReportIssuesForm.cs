using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        // Static list to store reported issues
        private static List<Issue> reportedIssues = new List<Issue>();

        public ReportIssuesForm()
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
            int offsetY = panelHeader.Height + 20; // Adding some space after the banner

            lblLocation.Top = offsetY + 20; // Adjust top to be below the banner
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

            // Centering controls horizontally
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


        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            // Validate location input
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.");
                return;
            }

            // Update progress bar to 20%
            progressBar.Value = 20;
            progressBar.ForeColor = System.Drawing.Color.Orange;
        }

        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            // Validate description input
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Update progress bar to 60%
            progressBar.Value = 60;
            progressBar.ForeColor = System.Drawing.Color.Yellow;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update progress bar to 40%
            progressBar.Value = 40;
            progressBar.ForeColor = System.Drawing.Color.Green;
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = openFileDialog.FileName;

                    // Update progress bar to 80%
                    progressBar.Value = 80;
                    progressBar.ForeColor = System.Drawing.Color.Blue;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all inputs are completed
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) &&
                !string.IsNullOrWhiteSpace(txtDescription.Text) &&
                cmbCategory.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtAttachment.Text))
            {
                // Create a new Issue object with the entered details
                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = txtDescription.Text,
                    Attachment = txtAttachment.Text
                };

                // Add the new issue to the static list
                reportedIssues.Add(newIssue);

                // Update progress bar to 100%
                progressBar.Value = 100;

                // Display success dialog box
                DialogResult result = MessageBox.Show("Issue has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If the user clicks OK, reset the form and progress bar
                if (result == DialogResult.OK)
                {
                    // Reset the form for new inputs
                    txtLocation.Clear();
                    txtDescription.Clear();
                    cmbCategory.SelectedIndex = -1; // Reset the ComboBox
                    txtAttachment.Clear();

                    // Reset the progress bar to 0%
                    progressBar.Value = 0;
                }
            }
            else
            {
                // Show a message if some inputs are missing
                MessageBox.Show("Please complete all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            // Pass the static list to the view form
            ViewIssuesForm viewForm = new ViewIssuesForm(reportedIssues);
            viewForm.Show();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            MainForm menuForm = new MainForm();
            menuForm.Show();
            this.Close(); // Close the current form
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Set the form to open in maximized (full screen) mode
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

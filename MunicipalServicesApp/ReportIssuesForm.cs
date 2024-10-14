using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        // Static list to store all reported issues
        private static List<Issue> reportedIssues = new List<Issue>();

        // Static field to store the path of the uploaded files
        private static string uploadFolderPath = Path.Combine(Application.StartupPath, "Uploads");

        public ReportIssuesForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
            StyleControls();
        }

        // Method to style controls on the form
        private void StyleControls()
        {
            // Sets form background color
            this.BackColor = Color.White;

            // Styles labels
            foreach (Control c in this.Controls)
            {
                if (c is Label && c != lblHeader)
                {
                    c.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                    c.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Styles text inputs
            txtLocation.Font = new Font("Segoe UI", 11F);
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtAttachment.Font = new Font("Segoe UI", 11F);
            cmbCategory.Font = new Font("Segoe UI", 11F);

            // Styles buttons
            StyleButton(btnSaveLocation);
            StyleButton(btnSaveDescription);
            StyleButton(btnAttachMedia);
            StyleButton(btnSubmit);
            StyleButton(btnViewIssues);
            StyleButton(btnBackToMenu);

            // Styles progress bar
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Height = 25;
        }

        // Helper method to style buttons uniformly
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(33, 150, 243);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(5);
        }

        // Event handler for form resizing
        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        // Method to center controls dynamically on the form
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int currentY = panelHeader.Bottom + 20;
            int padding = 10;

            // Center individual controls vertically with spacing
            CenterControl(lblLocation, centerX, ref currentY, padding);
            CenterControl(txtLocation, centerX, ref currentY, padding);
            CenterControl(btnSaveLocation, centerX, ref currentY, padding);

            CenterControl(lblCategory, centerX, ref currentY, padding);
            CenterControl(cmbCategory, centerX, ref currentY, padding);

            CenterControl(lblDescription, centerX, ref currentY, padding);
            CenterControl(txtDescription, centerX, ref currentY, padding);
            CenterControl(btnSaveDescription, centerX, ref currentY, padding);

            CenterControl(lblAttachment, centerX, ref currentY, padding);
            CenterControl(txtAttachment, centerX, ref currentY, padding);
            CenterControl(btnAttachMedia, centerX, ref currentY, padding);

            CenterControl(btnSubmit, centerX, ref currentY, padding * 2);

            CenterControl(lblEngagement, centerX, ref currentY, padding);
            CenterControl(progressBar, centerX, ref currentY, padding);

            // Position View Issues and Back to Menu buttons side by side
            int buttonWidth = Math.Min(200, (this.ClientSize.Width - 60) / 2);
            btnViewIssues.Width = buttonWidth;
            btnBackToMenu.Width = buttonWidth;

            int totalButtonsWidth = buttonWidth * 2 + 20;
            int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;

            btnViewIssues.Location = new Point(startX, currentY);
            btnBackToMenu.Location = new Point(btnViewIssues.Right + 20, currentY);
        }

        // Helper method to center a single control on the form
        private void CenterControl(Control ctrl, int centerX, ref int currentY, int padding)
        {
            ctrl.Left = centerX - ctrl.Width / 2;
            ctrl.Top = currentY;
            currentY += ctrl.Height + padding;
        }

        // Saves location button click event
        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.");
                return;
            }
            progressBar.Value = 20;
            progressBar.ForeColor = Color.Orange;
        }

        // Save description button click event
        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }
            progressBar.Value = 60;
            progressBar.ForeColor = Color.Yellow;
        }

        // Category selection change event
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar.Value = 40;
            progressBar.ForeColor = Color.Green;
        }

        // Attach media button click event
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationFilePath = Path.Combine(uploadFolderPath, fileName);

                    try
                    {
                        // Create the Uploads folder if it doesn't exist
                        Directory.CreateDirectory(uploadFolderPath);

                        // Copy the file to the Uploads folder
                        File.Copy(sourceFilePath, destinationFilePath, true);

                        txtAttachment.Text = destinationFilePath;
                        progressBar.Value = 80;
                        progressBar.ForeColor = Color.Blue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error copying file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) &&
                !string.IsNullOrWhiteSpace(txtDescription.Text) &&
                cmbCategory.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtAttachment.Text))
            {
                // Create a new issue and add it to the list
                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = txtDescription.Text,
                    Attachment = txtAttachment.Text // This now contains the path in the Uploads folder
                };

                reportedIssues.Add(newIssue);
                progressBar.Value = 100;

                DialogResult result = MessageBox.Show("Issue has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reset the form inputs and progress bar
        private void ResetForm()
        {
            txtLocation.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            txtAttachment.Clear();
            progressBar.Value = 0;
        }

        // View issues button click event
        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ViewIssuesForm(reportedIssues));
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MainForm());
        }

        // Open a new form and close the current one
        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        // Handle form closing event to ensure application closes properly
        private void ReportIssuesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void lblEngagement_Click(object sender, EventArgs e)
        {
            // This method is empty in the original code
        }
    }
}
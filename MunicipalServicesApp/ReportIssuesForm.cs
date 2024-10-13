using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        private static List<Issue> reportedIssues = new List<Issue>();

        public ReportIssuesForm()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form_Resize);
            StyleControls();
        }

        private void StyleControls()
        {
            // Set form background color
            this.BackColor = Color.White;

            // Style labels
            foreach (Control c in this.Controls)
            {
                if (c is Label && c != lblHeader)
                {
                    c.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                    c.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Style text inputs
            txtLocation.Font = new Font("Segoe UI", 11F);
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtAttachment.Font = new Font("Segoe UI", 11F);
            cmbCategory.Font = new Font("Segoe UI", 11F);

            // Style buttons
            StyleButton(btnSaveLocation);
            StyleButton(btnSaveDescription);
            StyleButton(btnAttachMedia);
            StyleButton(btnSubmit);
            StyleButton(btnViewIssues);
            StyleButton(btnBackToMenu);

            // Style progress bar
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Height = 25;
        }

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

        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int currentY = panelHeader.Bottom + 20;
            int padding = 10;

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
            int buttonWidth = Math.Min(200, (this.ClientSize.Width - 60) / 2); // Set max width to 200
            btnViewIssues.Width = buttonWidth;
            btnBackToMenu.Width = buttonWidth;

            int totalButtonsWidth = buttonWidth * 2 + 20; // 20 is the space between buttons
            int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;

            btnViewIssues.Location = new Point(startX, currentY);
            btnBackToMenu.Location = new Point(btnViewIssues.Right + 20, currentY);
        }

        private void CenterControl(Control ctrl, int centerX, ref int currentY, int padding)
        {
            ctrl.Left = centerX - ctrl.Width / 2;
            ctrl.Top = currentY;
            currentY += ctrl.Height + padding;
        }

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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar.Value = 40;
            progressBar.ForeColor = Color.Green;
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = openFileDialog.FileName;
                    progressBar.Value = 80;
                    progressBar.ForeColor = Color.Blue;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) &&
                !string.IsNullOrWhiteSpace(txtDescription.Text) &&
                cmbCategory.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(txtAttachment.Text))
            {
                Issue newIssue = new Issue
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = txtDescription.Text,
                    Attachment = txtAttachment.Text
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

        private void ResetForm()
        {
            txtLocation.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            txtAttachment.Clear();
            progressBar.Value = 0;
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ViewIssuesForm(reportedIssues));
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MainForm());
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReportIssuesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void lblEngagement_Click(object sender, EventArgs e)
        {
            // This method can remain empty if no functionality is needed
        }
    }
}
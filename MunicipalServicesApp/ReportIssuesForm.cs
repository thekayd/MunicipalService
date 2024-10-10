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
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // Your existing CenterControls code here
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

        }
    }
}
using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
        }

        // Event handler for when the submit button is clicked
        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            string selectedOption = ""; // Variable to store the selected rating

            // Check which radio button is selected and assign the corresponding value
            if (rbtnExcellent.Checked)
                selectedOption = "Excellent";
            else if (rbtnGood.Checked)
                selectedOption = "Good";
            else if (rbtnAverage.Checked)
                selectedOption = "Fair";
            else if (rbtnPoor.Checked)
                selectedOption = "Poor";

            // Check if feedback text is provided and an option is selected
            if (!string.IsNullOrWhiteSpace(txtFeedback.Text) && !string.IsNullOrWhiteSpace(selectedOption))
            {
                MessageBox.Show("Thank you for reviewing our application!", "Review Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearReviewForm();
            }
            else
            {
                MessageBox.Show("Please fill out the review form.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to clear the form inputs after a review is submitted
        private void ClearReviewForm()
        {
            rbtnExcellent.Checked = false;
            rbtnGood.Checked = false;
            rbtnAverage.Checked = false;
            rbtnPoor.Checked = false;
            txtFeedback.Clear();
        }

        // Event handler for the 'Back' button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler when the feedback text box gains focus (user clicks inside)
        private void txtFeedback_Enter(object sender, EventArgs e)
        {
            // If the default text is present, clear it and set the text color to black
            if (txtFeedback.Text == "Leave a comment...")
            {
                txtFeedback.Text = "";
                txtFeedback.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Event handler when the feedback text box loses focus (user clicks outside)
        private void txtFeedback_Leave(object sender, EventArgs e)
        {
            // If no text is entered, restore the default prompt and set text color to gray
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                txtFeedback.Text = "Leave a comment...";
                txtFeedback.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
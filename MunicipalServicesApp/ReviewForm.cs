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

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            string selectedOption = "";
            if (rbtnExcellent.Checked)
                selectedOption = "Excellent";
            else if (rbtnGood.Checked)
                selectedOption = "Good";
            else if (rbtnAverage.Checked)
                selectedOption = "Fair";
            else if (rbtnPoor.Checked)
                selectedOption = "Poor";

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

        private void ClearReviewForm()
        {
            rbtnExcellent.Checked = false;
            rbtnGood.Checked = false;
            rbtnAverage.Checked = false;
            rbtnPoor.Checked = false;
            txtFeedback.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFeedback_Enter(object sender, EventArgs e)
        {
            if (txtFeedback.Text == "Leave a comment...")
            {
                txtFeedback.Text = "";
                txtFeedback.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtFeedback_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                txtFeedback.Text = "Leave a comment...";
                txtFeedback.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
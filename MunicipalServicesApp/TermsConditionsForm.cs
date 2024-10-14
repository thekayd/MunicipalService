using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class TermsConditionsForm : Form
    {
        public TermsConditionsForm()
        {
            InitializeComponent();
        }

        // Event handler for the Agree button click
        private void btnAgree_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog asking the user if they agree to the Terms and Conditions
            DialogResult result = MessageBox.Show("Do you agree to the Terms and Conditions?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Show a message thanking the user for agreeing to the Terms and Conditions
                MessageBox.Show("Thank you for agreeing to the Terms and Conditions.", "Agreement Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Event handler for the Back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
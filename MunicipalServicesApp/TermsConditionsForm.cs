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

        private void btnAgree_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you agree to the Terms and Conditions?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for agreeing to the Terms and Conditions.", "Agreement Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
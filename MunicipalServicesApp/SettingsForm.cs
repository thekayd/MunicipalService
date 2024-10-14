using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Event handler for the Review button click
        private void btnReview_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReviewForm());
        }

        // Event handler for the Terms and Conditions button click
        private void btnTermsConditions_Click(object sender, EventArgs e)
        {
            OpenNewForm(new TermsConditionsForm());
        }

        // Event handler for the Back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to open a new form and hide the current one
        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Show();
            newForm.Show();
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
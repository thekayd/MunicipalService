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

        private void btnReview_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReviewForm());
        }

        private void btnTermsConditions_Click(object sender, EventArgs e)
        {
            OpenNewForm(new TermsConditionsForm());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
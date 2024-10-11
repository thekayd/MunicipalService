using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
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

            btnReportIssues.Left = centerX - (btnReportIssues.Width / 2);
            btnLocalEvents.Left = centerX - (btnLocalEvents.Width / 2);
            btnServiceRequestStatus.Left = centerX - (btnServiceRequestStatus.Width / 2);
            btnSettings.Left = centerX - (btnSettings.Width / 2);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ReportIssuesForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Text = "Municipal Services Portal";
            lblHeader.Text = "Welcome to Municipal Services";
            lblHeader.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            OpenNewForm(new LocalEventsForm());
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Show();
            newForm.Show();
            this.Hide();
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be implemented later!", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SettingsForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
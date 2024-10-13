using System.Windows.Forms;
using System.Drawing;

namespace MunicipalServicesApp
{
    partial class ViewIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFilterLocation;
        private Button btnFilter;
        private Button btnBackToMainMenu;
        private Button btnReportIssue;
        private ListBox lstIssues;
        private Label lblHeader;
        private Panel panelHeader;
        private Label lblFilterByLocation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFilterLocation = new TextBox();
            btnFilter = new Button();
            btnBackToMainMenu = new Button();
            btnReportIssue = new Button();
            lstIssues = new ListBox();
            lblHeader = new Label();
            panelHeader = new Panel();
            lblFilterByLocation = new Label();
            lblFilterLocation = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilterLocation
            // 
            txtFilterLocation.Font = new Font("Segoe UI", 12F);
            txtFilterLocation.Location = new Point(321, 162);
            txtFilterLocation.Margin = new Padding(4, 3, 4, 3);
            txtFilterLocation.Name = "txtFilterLocation";
            txtFilterLocation.PlaceholderText = "Enter location to filter...";
            txtFilterLocation.Size = new Size(291, 29);
            txtFilterLocation.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilter.Location = new Point(321, 208);
            btnFilter.Margin = new Padding(4, 3, 4, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(292, 46);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Filter Issues By Location";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBackToMainMenu.Location = new Point(321, 519);
            btnBackToMainMenu.Margin = new Padding(4, 3, 4, 3);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(292, 46);
            btnBackToMainMenu.TabIndex = 3;
            btnBackToMainMenu.Text = "Back to Main Menu";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // btnReportIssue
            // 
            btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportIssue.Location = new Point(321, 577);
            btnReportIssue.Margin = new Padding(4, 3, 4, 3);
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.Size = new Size(292, 46);
            btnReportIssue.TabIndex = 4;
            btnReportIssue.Text = "Report Issue";
            btnReportIssue.UseVisualStyleBackColor = true;
            btnReportIssue.Click += btnReportIssue_Click;
            // 
            // lstIssues
            // 
            lstIssues.Font = new Font("Segoe UI", 12F);
            lstIssues.FormattingEnabled = true;
            lstIssues.ItemHeight = 21;
            lstIssues.Location = new Point(117, 265);
            lstIssues.Margin = new Padding(4, 3, 4, 3);
            lstIssues.Name = "lstIssues";
            lstIssues.Size = new Size(699, 214);
            lstIssues.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(175, 23);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(257, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Issues Reported";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(933, 115);
            panelHeader.TabIndex = 1;
            // 
            // lblFilterByLocation
            // 
            lblFilterByLocation.Location = new Point(0, 0);
            lblFilterByLocation.Margin = new Padding(4, 0, 4, 0);
            lblFilterByLocation.Name = "lblFilterByLocation";
            lblFilterByLocation.Size = new Size(117, 27);
            lblFilterByLocation.TabIndex = 2;
            // 
            // lblFilterLocation
            // 
            lblFilterLocation.Font = new Font("Segoe UI", 12F);
            lblFilterLocation.Location = new Point(394, 130);
            lblFilterLocation.Margin = new Padding(4, 0, 4, 0);
            lblFilterLocation.Name = "lblFilterLocation";
            lblFilterLocation.Size = new Size(292, 29);
            lblFilterLocation.TabIndex = 0;
            lblFilterLocation.Text = "Enter Location:";
            lblFilterLocation.Click += lblFilterLocation_Click;
            // 
            // ViewIssuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 692);
            Controls.Add(lblFilterLocation);
            Controls.Add(panelHeader);
            Controls.Add(lblFilterByLocation);
            Controls.Add(txtFilterLocation);
            Controls.Add(btnFilter);
            Controls.Add(lstIssues);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(btnReportIssue);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ViewIssuesForm";
            Text = "View Reported Issues";
            Load += ViewIssuesForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblFilterLocation;
    }
}
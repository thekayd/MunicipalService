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
            this.txtFilterLocation = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.lstIssues = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFilterByLocation = new System.Windows.Forms.Label();

            this.SuspendLayout();


            // panelHeader, designing and styling of the panel header, including positioning
            this.panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);


            // lblHeader, designing and styling of the label header, including positioning
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Location = new Point(150, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(450, 45);
            this.lblHeader.Text = "Issues Reported";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;


            // txtFilterLocation, designing and styling of the textbox, including positioning
            this.txtFilterLocation.Location = new System.Drawing.Point(275, 140);
            this.txtFilterLocation.Name = "txtFilterLocation";
            this.txtFilterLocation.Size = new System.Drawing.Size(250, 30);
            this.txtFilterLocation.TabIndex = 0;
            this.txtFilterLocation.Font = new Font("Segoe UI", 12F);
            this.txtFilterLocation.Text = "Enter location to filter...";

            // btnFilter, designing and styling of the filter button, including positioning
            this.btnFilter.Location = new System.Drawing.Point(275, 180);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(250, 40);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnFilter.Text = "Filter Issues By Location";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            // lstIssues, designing and styling of the listbox, including positioning
            this.lstIssues.FormattingEnabled = true;
            this.lstIssues.Location = new System.Drawing.Point(100, 230);
            this.lstIssues.Name = "lstIssues";
            this.lstIssues.Size = new System.Drawing.Size(600, 200);
            this.lstIssues.Font = new Font("Segoe UI", 12F);
            this.lstIssues.TabIndex = 2;


            // btnBackToMainMenu, designing and styling of the back to menu button, including positioning
            this.btnBackToMainMenu.Location = new System.Drawing.Point(275, 450);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(250, 40);
            this.btnBackToMainMenu.TabIndex = 3;
            this.btnBackToMainMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);

            // btnReportIssue, designing and styling of the report issue button, including positioning
            this.btnReportIssue.Location = new System.Drawing.Point(275, 500);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(250, 40);
            this.btnReportIssue.TabIndex = 4;
            this.btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnReportIssue.Text = "Report Issue";
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);

            // ViewIssuesForm, designing and styling of the issue forms, including positioning
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblFilterByLocation);
            this.Controls.Add(this.txtFilterLocation);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lstIssues);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnReportIssue);
            this.Name = "ViewIssuesForm";
            this.Text = "View Reported Issues";
            this.Load += new System.EventHandler(this.ViewIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
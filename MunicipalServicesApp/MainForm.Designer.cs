using System.Windows.Forms;
using System.Drawing;

namespace MunicipalServicesApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceRequestStatus;
        private Label lblHeader;
        private Panel panelHeader;

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
            // Initialize components
            this.btnReportIssues = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceRequestStatus = new Button();
            this.lblHeader = new Label();
            this.panelHeader = new Panel();
            this.SuspendLayout();

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Location = new Point(50, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(450, 45);
            this.lblHeader.Text = "Welcome to Municipal Services";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Location = new Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(800, 100);

            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new Point(250, 150);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new Size(300, 50);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.BackColor = Color.FromArgb(33, 150, 243);
            this.btnReportIssues.ForeColor = Color.White;
            this.btnReportIssues.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnReportIssues.FlatStyle = FlatStyle.Flat;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Location = new Point(250, 250);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new Size(300, 50);
            this.btnLocalEvents.TabIndex = 1;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.BackColor = Color.FromArgb(33, 150, 243);
            this.btnLocalEvents.ForeColor = Color.White;
            this.btnLocalEvents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnLocalEvents.FlatStyle = FlatStyle.Flat;
            this.btnLocalEvents.FlatAppearance.BorderSize = 0;

            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Location = new Point(250, 350);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new Size(300, 50);
            this.btnServiceRequestStatus.TabIndex = 2;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = false;
            this.btnServiceRequestStatus.BackColor = Color.FromArgb(33, 150, 243);
            this.btnServiceRequestStatus.ForeColor = Color.White;
            this.btnServiceRequestStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            this.btnServiceRequestStatus.FlatAppearance.BorderSize = 0;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Name = "MainForm";
            this.Text = "Municipal Services App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}

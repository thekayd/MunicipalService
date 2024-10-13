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
        private Button btnSettings;
        private Label lblHeader;
        private Panel panelHeader;
        private PictureBox picBanner;

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
            btnReportIssues = new Button();
            btnLocalEvents = new Button();
            btnServiceRequestStatus = new Button();
            btnSettings = new Button();
            lblHeader = new Label();
            panelHeader = new Panel();
            picBanner = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            SuspendLayout();
            // 
            // btnReportIssues
            // 
            btnReportIssues.BackColor = Color.FromArgb(33, 150, 243);
            btnReportIssues.FlatAppearance.BorderSize = 0;
            btnReportIssues.FlatStyle = FlatStyle.Flat;
            btnReportIssues.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReportIssues.ForeColor = Color.White;
            btnReportIssues.Location = new Point(665, 193);
            btnReportIssues.Margin = new Padding(4, 3, 4, 3);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(350, 58);
            btnReportIssues.TabIndex = 0;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = false;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.BackColor = Color.FromArgb(33, 150, 243);
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLocalEvents.ForeColor = Color.White;
            btnLocalEvents.Location = new Point(665, 280);
            btnLocalEvents.Margin = new Padding(4, 3, 4, 3);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(350, 58);
            btnLocalEvents.TabIndex = 1;
            btnLocalEvents.Text = "Local Events/Announcements";
            btnLocalEvents.UseVisualStyleBackColor = false;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // btnServiceRequestStatus
            // 
            btnServiceRequestStatus.BackColor = Color.FromArgb(33, 150, 243);
            btnServiceRequestStatus.FlatAppearance.BorderSize = 0;
            btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            btnServiceRequestStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnServiceRequestStatus.ForeColor = Color.White;
            btnServiceRequestStatus.Location = new Point(665, 366);
            btnServiceRequestStatus.Margin = new Padding(4, 3, 4, 3);
            btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            btnServiceRequestStatus.Size = new Size(350, 58);
            btnServiceRequestStatus.TabIndex = 2;
            btnServiceRequestStatus.Text = "Service Request Status";
            btnServiceRequestStatus.UseVisualStyleBackColor = false;
            btnServiceRequestStatus.Click += btnServiceRequestStatus_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(33, 150, 243);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(665, 453);
            btnSettings.Margin = new Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(350, 58);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(13, 27);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(307, 90);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Municipal Services \nPortal";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Controls.Add(picBanner);
            panelHeader.Dock = DockStyle.Left;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(360, 692);
            panelHeader.TabIndex = 0;
            // 
            // picBanner
            // 
            picBanner.Location = new Point(31, 139);
            picBanner.Margin = new Padding(4, 3, 4, 3);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(239, 154);
            picBanner.SizeMode = PictureBoxSizeMode.Zoom;
            picBanner.TabIndex = 1;
            picBanner.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1135, 692);
            Controls.Add(panelHeader);
            Controls.Add(btnReportIssues);
            Controls.Add(btnLocalEvents);
            Controls.Add(btnServiceRequestStatus);
            Controls.Add(btnSettings);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Municipal Services App";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            ResumeLayout(false);
        }
    }
}
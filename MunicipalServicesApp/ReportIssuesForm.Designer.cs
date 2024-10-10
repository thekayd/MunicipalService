using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLocation;
        private ComboBox cmbCategory;
        private RichTextBox txtDescription;
        private TextBox txtAttachment;
        private Button btnAttachMedia;
        private Button btnSubmit;
        private Label lblEngagement;
        private ProgressBar progressBar;
        private Button btnViewIssues;
        private Label lblLocation;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblAttachment;
        private Button btnSaveLocation;
        private Button btnSaveDescription;
        private Button btnBackToMenu;
        
        private Label lblHeader;
        private Panel panelHeader;

        // Disposes method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // This method is to initialize the form components and layout
        private void InitializeComponent()
        {
            txtLocation = new TextBox();
            cmbCategory = new ComboBox();
            txtDescription = new RichTextBox();
            txtAttachment = new TextBox();
            btnAttachMedia = new Button();
            btnSubmit = new Button();
            lblEngagement = new Label();
            progressBar = new ProgressBar();
            btnViewIssues = new Button();
            lblLocation = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblAttachment = new Label();
            btnSaveLocation = new Button();
            btnSaveDescription = new Button();
            btnBackToMenu = new Button();
            lblHeader = new Label();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(50, 137);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(350, 23);
            txtLocation.TabIndex = 0;
            txtLocation.Text = "Enter location...";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Electricity", "Water" });
            cmbCategory.Location = new Point(50, 206);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(350, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "Select category...";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(50, 281);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 80);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "Enter description...";
            // 
            // txtAttachment
            // 
            txtAttachment.Location = new Point(50, 381);
            txtAttachment.Name = "txtAttachment";
            txtAttachment.Size = new Size(350, 23);
            txtAttachment.TabIndex = 6;
            txtAttachment.Text = "No file selected...";
            // 
            // btnAttachMedia
            // 
            btnAttachMedia.Location = new Point(431, 380);
            btnAttachMedia.Name = "btnAttachMedia";
            btnAttachMedia.Size = new Size(75, 23);
            btnAttachMedia.TabIndex = 8;
            btnAttachMedia.Text = "Attach";
            btnAttachMedia.UseVisualStyleBackColor = true;
            btnAttachMedia.Click += btnAttachMedia_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(113, 413);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 40);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblEngagement
            // 
            lblEngagement.AutoSize = true;
            lblEngagement.Font = new Font("Segoe UI", 12F);
            lblEngagement.Location = new Point(167, 466);
            lblEngagement.Name = "lblEngagement";
            lblEngagement.Size = new Size(100, 21);
            lblEngagement.TabIndex = 13;
            lblEngagement.Text = "Engagement:";
            lblEngagement.Click += lblEngagement_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(100, 490);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(250, 23);
            progressBar.TabIndex = 12;
            // 
            // btnViewIssues
            // 
            btnViewIssues.Location = new Point(36, 535);
            btnViewIssues.Name = "btnViewIssues";
            btnViewIssues.Size = new Size(200, 40);
            btnViewIssues.TabIndex = 14;
            btnViewIssues.Text = "View Reported Issues";
            btnViewIssues.UseVisualStyleBackColor = true;
            btnViewIssues.Click += btnViewIssues_Click;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 12F);
            lblLocation.Location = new Point(54, 103);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(72, 21);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(50, 181);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 21);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(50, 256);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 21);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description:";
            // 
            // lblAttachment
            // 
            lblAttachment.AutoSize = true;
            lblAttachment.Font = new Font("Segoe UI", 12F);
            lblAttachment.Location = new Point(50, 356);
            lblAttachment.Name = "lblAttachment";
            lblAttachment.Size = new Size(93, 21);
            lblAttachment.TabIndex = 7;
            lblAttachment.Text = "Attachment:";
            // 
            // btnSaveLocation
            // 
            btnSaveLocation.Location = new Point(431, 137);
            btnSaveLocation.Name = "btnSaveLocation";
            btnSaveLocation.Size = new Size(75, 23);
            btnSaveLocation.TabIndex = 9;
            btnSaveLocation.Text = "Save";
            btnSaveLocation.UseVisualStyleBackColor = true;
            btnSaveLocation.Click += btnSaveLocation_Click;
            // 
            // btnSaveDescription
            // 
            btnSaveDescription.Location = new Point(431, 280);
            btnSaveDescription.Name = "btnSaveDescription";
            btnSaveDescription.Size = new Size(75, 23);
            btnSaveDescription.TabIndex = 10;
            btnSaveDescription.Text = "Save";
            btnSaveDescription.UseVisualStyleBackColor = true;
            btnSaveDescription.Click += btnSaveDescription_Click;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(289, 535);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(200, 40);
            btnBackToMenu.TabIndex = 15;
            btnBackToMenu.Text = "Back to Main Menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(150, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(220, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Report Issues";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(766, 100);
            panelHeader.TabIndex = 16;
            // 
            // ReportIssuesForm
            // 
            ClientSize = new Size(766, 637);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnViewIssues);
            Controls.Add(lblEngagement);
            Controls.Add(progressBar);
            Controls.Add(btnSubmit);
            Controls.Add(btnSaveDescription);
            Controls.Add(btnSaveLocation);
            Controls.Add(btnAttachMedia);
            Controls.Add(lblAttachment);
            Controls.Add(txtAttachment);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Controls.Add(panelHeader);
            Name = "ReportIssuesForm";
            Text = "Report Issues";
            Load += ReportIssuesForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

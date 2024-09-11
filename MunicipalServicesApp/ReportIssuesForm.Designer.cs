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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnSaveDescription = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
           
            // txtLocation, designing and styling of the textbox, including positioning
            this.txtLocation.Location = new System.Drawing.Point(50, 100);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(350, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "Enter location...";

            // cmbCategory, , designing and styling of the combobox, including positioning
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Electricity",
            "Water"});
            this.cmbCategory.Location = new System.Drawing.Point(50, 175);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(350, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.Text = "Select category...";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

            // txtDescription, designing and styling of the textbox, including positioning
            this.txtDescription.Location = new System.Drawing.Point(50, 250);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 80);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "Enter description...";

            // txtAttachment, designing and styling of the textbox, including positioning
            this.txtAttachment.Location = new System.Drawing.Point(50, 350);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(350, 20);
            this.txtAttachment.TabIndex = 6;
            this.txtAttachment.Text = "No file selected...";

            // btnAttachMedia, designing and styling of the button, including positioning
            this.btnAttachMedia.Location = new System.Drawing.Point(310, 350);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(75, 23);
            this.btnAttachMedia.TabIndex = 8;
            this.btnAttachMedia.Text = "Attach";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);

            // btnSubmit, designing and styling of the button, including positioning
            this.btnSubmit.Location = new System.Drawing.Point(150, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // lblEngagement, designing and styling of the button, including positioning
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEngagement.Location = new System.Drawing.Point(50, 425);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(100, 21);
            this.lblEngagement.TabIndex = 13;
            this.lblEngagement.Text = "Engagement:";

            // progressBar, designing and styling of the progressbar, including positioning
            this.progressBar.Location = new System.Drawing.Point(50, 450);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 23);
            this.progressBar.TabIndex = 12;

            // btnViewIssues, designing and styling of the button, including positioning
            this.btnViewIssues.Location = new System.Drawing.Point(150, 500);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(200, 40);
            this.btnViewIssues.TabIndex = 14;
            this.btnViewIssues.Text = "View Reported Issues";
            this.btnViewIssues.UseVisualStyleBackColor = true;
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);

            // lblLocation, designing and styling of the label, including positioning
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLocation.Location = new System.Drawing.Point(50, 75);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 21);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location:";

            // lblCategory, designing and styling of the label, including positioning
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCategory.Location = new System.Drawing.Point(50, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 21);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";

            // lblDescription, designing and styling of the label, including positioning
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.Location = new System.Drawing.Point(50, 225);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 21);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";

            // lblAttachment, designing and styling of the label, including positioning
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAttachment.Location = new System.Drawing.Point(50, 325);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(93, 21);
            this.lblAttachment.TabIndex = 7;
            this.lblAttachment.Text = "Attachment:";

            // btnSaveLocation, designing and styling of the button, including positioning
            this.btnSaveLocation.Location = new System.Drawing.Point(310, 100);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLocation.TabIndex = 9;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);

            // btnSaveDescription, designing and styling of the button, including positioning
            this.btnSaveDescription.Location = new System.Drawing.Point(310, 250);
            this.btnSaveDescription.Name = "btnSaveDescription";
            this.btnSaveDescription.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDescription.TabIndex = 10;
            this.btnSaveDescription.Text = "Save";
            this.btnSaveDescription.UseVisualStyleBackColor = true;
            this.btnSaveDescription.Click += new System.EventHandler(this.btnSaveDescription_Click);

            // btnBackToMenu, designing and styling of the button, including positioning
            this.btnBackToMenu.Location = new System.Drawing.Point(150, 550);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(200, 40);
            this.btnBackToMenu.TabIndex = 15;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);

            // lblHeader, designing and styling of the label, including positioning
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(150, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(257, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Report Issues";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelHeader, designing and styling of the panelheader, including positioning
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 100);
            this.panelHeader.TabIndex = 16;
             
            // ReportIssuesForm 
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnViewIssues);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSaveDescription);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.panelHeader);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace MunicipalServicesApp
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnTermsConditions;
        private System.Windows.Forms.Button btnBack;

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
            panelHeader = new System.Windows.Forms.Panel();
            lblHeader = new System.Windows.Forms.Label();
            picBanner = new System.Windows.Forms.PictureBox();
            btnReview = new System.Windows.Forms.Button();
            btnTermsConditions = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Controls.Add(picBanner);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(350, 692);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Location = new System.Drawing.Point(23, 23);
            lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(141, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Settings";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBanner
            // 
            picBanner.Location = new System.Drawing.Point(23, 150);
            picBanner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picBanner.Name = "picBanner";
            picBanner.Size = new System.Drawing.Size(303, 231);
            picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picBanner.TabIndex = 1;
            picBanner.TabStop = false;
            string imagePath = Path.Combine(Application.StartupPath, "images", "SettingsImage.jpg");
            picBanner.Image = Image.FromFile(imagePath);

            // 
            // btnReview
            // 
            btnReview.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnReview.FlatAppearance.BorderSize = 0;
            btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReview.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnReview.ForeColor = System.Drawing.Color.White;
            btnReview.Location = new System.Drawing.Point(467, 173);
            btnReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReview.Name = "btnReview";
            btnReview.Size = new System.Drawing.Size(350, 58);
            btnReview.TabIndex = 1;
            btnReview.Text = "Leave a Review";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // btnTermsConditions
            // 
            btnTermsConditions.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnTermsConditions.FlatAppearance.BorderSize = 0;
            btnTermsConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTermsConditions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnTermsConditions.ForeColor = System.Drawing.Color.White;
            btnTermsConditions.Location = new System.Drawing.Point(467, 260);
            btnTermsConditions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnTermsConditions.Name = "btnTermsConditions";
            btnTermsConditions.Size = new System.Drawing.Size(350, 58);
            btnTermsConditions.TabIndex = 2;
            btnTermsConditions.Text = "Terms/Conditions";
            btnTermsConditions.UseVisualStyleBackColor = false;
            btnTermsConditions.Click += btnTermsConditions_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(467, 346);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(350, 58);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(933, 692);
            Controls.Add(panelHeader);
            Controls.Add(btnReview);
            Controls.Add(btnTermsConditions);
            Controls.Add(btnBack);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            ResumeLayout(false);
        }
    }
}
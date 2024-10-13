using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace MunicipalServicesApp
{
    partial class TermsConditionsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private PictureBox picBanner;
        private RichTextBox rtbTermsConditions;
        private Button btnAgree;
        private Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsConditionsForm));
            panelHeader = new Panel();
            lblHeader = new Label();
            picBanner = new PictureBox();
            rtbTermsConditions = new RichTextBox();
            btnAgree = new Button();
            btnBack = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            SuspendLayout();
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
            panelHeader.Size = new Size(350, 692);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(23, 23);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(345, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Terms/Conditions";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBanner
            // 
            picBanner.Location = new Point(23, 88);
            picBanner.Margin = new Padding(4, 3, 4, 3);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(303, 400);
            picBanner.SizeMode = PictureBoxSizeMode.Zoom;
            picBanner.TabIndex = 1;
            picBanner.TabStop = false;
            string imagePath = Path.Combine(Application.StartupPath, "images", "Nelson.jpg");
            picBanner.Image = Image.FromFile(imagePath);

            // 
            // rtbTermsConditions
            // 
            rtbTermsConditions.Font = new Font("Segoe UI", 10F);
            rtbTermsConditions.Location = new Point(373, 23);
            rtbTermsConditions.Margin = new Padding(4, 3, 4, 3);
            rtbTermsConditions.Name = "rtbTermsConditions";
            rtbTermsConditions.ReadOnly = true;
            rtbTermsConditions.Size = new Size(524, 553);
            rtbTermsConditions.TabIndex = 1;
            rtbTermsConditions.Text = resources.GetString("rtbTermsConditions.Text");
            // 
            // btnAgree
            // 
            btnAgree.BackColor = Color.FromArgb(33, 150, 243);
            btnAgree.FlatAppearance.BorderSize = 0;
            btnAgree.FlatStyle = FlatStyle.Flat;
            btnAgree.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgree.ForeColor = Color.White;
            btnAgree.Location = new Point(373, 600);
            btnAgree.Margin = new Padding(4, 3, 4, 3);
            btnAgree.Name = "btnAgree";
            btnAgree.Size = new Size(257, 46);
            btnAgree.TabIndex = 2;
            btnAgree.Text = "Agree to Terms & Conditions";
            btnAgree.UseVisualStyleBackColor = false;
            btnAgree.Click += btnAgree_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(33, 150, 243);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(642, 600);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(257, 46);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back to Settings";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // TermsConditionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 692);
            Controls.Add(panelHeader);
            Controls.Add(rtbTermsConditions);
            Controls.Add(btnAgree);
            Controls.Add(btnBack);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TermsConditionsForm";
            Text = "Terms and Conditions";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            ResumeLayout(false);
        }
    }
}
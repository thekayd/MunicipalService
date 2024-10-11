using System;
using System.Windows.Forms;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.rtbTermsConditions = new System.Windows.Forms.RichTextBox();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.picBanner);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(300, 600);
            this.panelHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(260, 90);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Terms and Conditions";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // picBanner
            this.picBanner.Location = new System.Drawing.Point(20, 130);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(260, 200);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabIndex = 1;
            this.picBanner.TabStop = false;
          //  this.picBanner.Image = System.Drawing.Image.FromFile("terms_banner.jpg"); // Make sure to add this image to your project

            // rtbTermsConditions
            this.rtbTermsConditions.Location = new System.Drawing.Point(320, 20);
            this.rtbTermsConditions.Name = "rtbTermsConditions";
            this.rtbTermsConditions.Size = new System.Drawing.Size(450, 480);
            this.rtbTermsConditions.TabIndex = 1;
            this.rtbTermsConditions.Text = "1. Acceptance of Terms\n\nBy using this Municipal Services Application, you agree to comply with and be bound by the following terms and conditions. If you do not agree to these terms, please do not use the application.\n\n2. Use of the Application\n\nYou agree to use the application only for lawful purposes and in a way that does not infringe the rights of, restrict or inhibit anyone else's use and enjoyment of the application.\n\n3. Privacy Policy\n\nYour use of the application is also governed by our Privacy Policy, which is incorporated into these terms and conditions by reference.\n\n4. Modifications to the Application\n\nWe reserve the right to modify or discontinue, temporarily or permanently, the application or any features or portions thereof without prior notice.\n\n5. Limitation of Liability\n\nThe application and all information, content, materials, products and services included on or otherwise made available to you through the application are provided on an \"as is\" and \"as available\" basis.\n\n6. Governing Law\n\nThese terms and conditions are governed by and construed in accordance with the laws of [Your Jurisdiction].\n\n7. Changes to Terms\n\nWe reserve the right to update these terms and conditions at any time. We will provide notice of any material changes to these terms.\n\nBy using this application, you acknowledge that you have read, understood, and agree to be bound by these terms and conditions.";
            this.rtbTermsConditions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbTermsConditions.ReadOnly = true;

            // btnAgree
            this.btnAgree.Location = new System.Drawing.Point(320, 520);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(220, 40);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Agree to Terms & Conditions";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAgree.ForeColor = System.Drawing.Color.White;
            this.btnAgree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgree.FlatAppearance.BorderSize = 0;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(550, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(220, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Settings";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // TermsConditionsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.rtbTermsConditions);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.btnBack);
            this.Name = "TermsConditionsForm";
            this.Text = "Terms and Conditions";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
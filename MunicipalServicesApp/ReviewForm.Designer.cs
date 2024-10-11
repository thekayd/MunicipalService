using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private RadioButton rbtnExcellent;
        private RadioButton rbtnGood;
        private RadioButton rbtnAverage;
        private RadioButton rbtnPoor;
        private TextBox txtFeedback;
        private Button btnSubmitReview;
        private Button btnBack;
        private Panel panelHeader;
        private Label lblHeader;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbtnExcellent = new System.Windows.Forms.RadioButton();
            this.rbtnGood = new System.Windows.Forms.RadioButton();
            this.rbtnAverage = new System.Windows.Forms.RadioButton();
            this.rbtnPoor = new System.Windows.Forms.RadioButton();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
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
            this.lblHeader.Size = new System.Drawing.Size(260, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Leave a Review";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // picBanner
            this.picBanner.Location = new System.Drawing.Point(20, 130);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(260, 200);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabIndex = 1;
            this.picBanner.TabStop = false;
           // this.picBanner.Image = System.Drawing.Image.FromFile("review_banner.jpg"); // Make sure to add this image to your project

            // lblTitle
            this.lblTitle.Location = new System.Drawing.Point(350, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rate Our Application";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);

            // rbtnExcellent
            this.rbtnExcellent.Location = new System.Drawing.Point(350, 80);
            this.rbtnExcellent.Name = "rbtnExcellent";
            this.rbtnExcellent.Size = new System.Drawing.Size(150, 30);
            this.rbtnExcellent.TabIndex = 1;
            this.rbtnExcellent.Text = "Excellent";
            this.rbtnExcellent.Font = new System.Drawing.Font("Segoe UI", 12F);

            // rbtnGood
            this.rbtnGood.Location = new System.Drawing.Point(350, 120);
            this.rbtnGood.Name = "rbtnGood";
            this.rbtnGood.Size = new System.Drawing.Size(150, 30);
            this.rbtnGood.TabIndex = 2;
            this.rbtnGood.Text = "Good";
            this.rbtnGood.Font = new System.Drawing.Font("Segoe UI", 12F);

            // rbtnAverage
            this.rbtnAverage.Location = new System.Drawing.Point(350, 160);
            this.rbtnAverage.Name = "rbtnAverage";
            this.rbtnAverage.Size = new System.Drawing.Size(150, 30);
            this.rbtnAverage.TabIndex = 3;
            this.rbtnAverage.Text = "Average";
            this.rbtnAverage.Font = new System.Drawing.Font("Segoe UI", 12F);

            // rbtnPoor
            this.rbtnPoor.Location = new System.Drawing.Point(350, 200);
            this.rbtnPoor.Name = "rbtnPoor";
            this.rbtnPoor.Size = new System.Drawing.Size(150, 30);
            this.rbtnPoor.TabIndex = 4;
            this.rbtnPoor.Text = "Poor";
            this.rbtnPoor.Font = new System.Drawing.Font("Segoe UI", 12F);

            // txtFeedback
            this.txtFeedback.Location = new System.Drawing.Point(350, 250);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(400, 100);
            this.txtFeedback.TabIndex = 5;
            this.txtFeedback.Text = "Leave a comment...";
            this.txtFeedback.ForeColor = System.Drawing.Color.Gray;
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFeedback.Enter += new System.EventHandler(this.txtFeedback_Enter);
            this.txtFeedback.Leave += new System.EventHandler(this.txtFeedback_Leave);

            // btnSubmitReview
            this.btnSubmitReview.Location = new System.Drawing.Point(350, 370);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(200, 40);
            this.btnSubmitReview.TabIndex = 6;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReview.FlatAppearance.BorderSize = 0;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(570, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Settings";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ReviewForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rbtnExcellent);
            this.Controls.Add(this.rbtnGood);
            this.Controls.Add(this.rbtnAverage);
            this.Controls.Add(this.rbtnPoor);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.btnBack);
            this.Name = "ReviewForm";
            this.Text = "Leave a Review";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
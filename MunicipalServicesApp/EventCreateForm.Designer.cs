﻿namespace MunicipalServicesApp
{
    partial class EventCreateForm
    {
        private System.ComponentModel.IContainer components = null;

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
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelDate = new System.Windows.Forms.Label();
            dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            labelCategory = new System.Windows.Forms.Label();
            textBoxCategory = new System.Windows.Forms.TextBox();
            labelDescription = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            buttonCreate = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            panelHeader = new System.Windows.Forms.Panel();
            lblHeader = new System.Windows.Forms.Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(188, 118);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(88, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name of Event:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(188, 143);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(300, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(188, 183);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(34, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date:";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new System.Drawing.Point(188, 208);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new System.Drawing.Size(300, 23);
            dateTimePickerDate.TabIndex = 3;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new System.Drawing.Point(188, 248);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new System.Drawing.Size(58, 15);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Category:";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new System.Drawing.Point(188, 273);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new System.Drawing.Size(300, 23);
            textBoxCategory.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(188, 313);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(70, 15);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(188, 338);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(300, 100);
            textBoxDescription.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new System.Drawing.Point(188, 468);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(140, 50);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(348, 468);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(140, 50);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(738, 100);
            panelHeader.TabIndex = 10;
            // 
            // lblHeader
            // 
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(738, 100);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Local Events and Announcements";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventCreateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(738, 690);
            Controls.Add(panelHeader);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelDate);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "EventCreateForm";
            Text = "Create New Event";
            Load += EventCreateForm_Load_1;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
    }
}
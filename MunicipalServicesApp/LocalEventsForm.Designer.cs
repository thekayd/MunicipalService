
using System.Windows.Forms;
using System.Drawing;
using System;

namespace MunicipalServicesApp
{

    partial class LocalEventsForm
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
            listViewEvents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            textBoxSearch = new TextBox();
            dateTimePickerSearch = new DateTimePicker();
            comboBoxCategory = new ComboBox();
            buttonSearch = new Button();
            textBoxEventDetails = new TextBox();
            listBoxRecommendations = new ListBox();
            buttonCreateEvent = new Button();
            btnBackToMainMenu = new Button();
            SuspendLayout();
            // 
            // listViewEvents
            // 
            listViewEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewEvents.FullRowSelect = true;
            listViewEvents.Location = new Point(12, 41);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(460, 200);
            listViewEvents.TabIndex = 0;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.View = View.Details;
            listViewEvents.SelectedIndexChanged += listViewEvents_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 100;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(150, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Location = new Point(168, 12);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(150, 23);
            dateTimePickerSearch.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(324, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(451, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxEventDetails
            // 
            textBoxEventDetails.Location = new Point(12, 247);
            textBoxEventDetails.Multiline = true;
            textBoxEventDetails.Name = "textBoxEventDetails";
            textBoxEventDetails.ReadOnly = true;
            textBoxEventDetails.Size = new Size(460, 100);
            textBoxEventDetails.TabIndex = 5;
            // 
            // listBoxRecommendations
            // 
            listBoxRecommendations.FormattingEnabled = true;
            listBoxRecommendations.ItemHeight = 15;
            listBoxRecommendations.Location = new Point(12, 353);
            listBoxRecommendations.Name = "listBoxRecommendations";
            listBoxRecommendations.Size = new Size(460, 79);
            listBoxRecommendations.TabIndex = 6;
            // 
            // buttonCreateEvent
            // 
            buttonCreateEvent.Location = new Point(12, 438);
            buttonCreateEvent.Name = "buttonCreateEvent";
            buttonCreateEvent.Size = new Size(100, 23);
            buttonCreateEvent.TabIndex = 7;
            buttonCreateEvent.Text = "Create Event";
            buttonCreateEvent.UseVisualStyleBackColor = true;
            buttonCreateEvent.Click += buttonCreateEvent_Click;
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new Point(118, 438);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(120, 23);
            btnBackToMainMenu.TabIndex = 8;
            btnBackToMainMenu.Text = "Back to Main Menu";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 471);
            Controls.Add(buttonCreateEvent);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(listBoxRecommendations);
            Controls.Add(textBoxEventDetails);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxCategory);
            Controls.Add(dateTimePickerSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(listViewEvents);
            Name = "LocalEventsForm";
            Text = "Local Events and Announcements";
            Load += LocalEventsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxEventDetails;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.Button btnBackToMainMenu;
    }

}


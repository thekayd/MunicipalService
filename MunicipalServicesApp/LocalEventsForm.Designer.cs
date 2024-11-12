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
            btnBackToMainMenu = new Button();
            panelHeader = new Panel();
            labelHeader = new Label();
            labelEventName = new Label();
            labelEventDetails = new Label();
            labelRecommendations = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // listViewEvents
            // 
            listViewEvents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewEvents.FullRowSelect = true;
            listViewEvents.Location = new Point(47, 247);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(600, 250);
            listViewEvents.TabIndex = 0;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.View = View.Details;
            listViewEvents.SelectedIndexChanged += listViewEvents_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Category";
            columnHeader3.Width = 150;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(150, 110);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 25);
            textBoxSearch.TabIndex = 1;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Location = new Point(360, 110);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(200, 25);
            dateTimePickerSearch.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(570, 110);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(150, 25);
            comboBoxCategory.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(268, 167);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 40);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxEventDetails
            // 
            textBoxEventDetails.Location = new Point(47, 527);
            textBoxEventDetails.Multiline = true;
            textBoxEventDetails.Name = "textBoxEventDetails";
            textBoxEventDetails.ReadOnly = true;
            textBoxEventDetails.Size = new Size(600, 132);
            textBoxEventDetails.TabIndex = 5;
            // 
            // listBoxRecommendations
            // 
            listBoxRecommendations.FormattingEnabled = true;
            listBoxRecommendations.ItemHeight = 17;
            listBoxRecommendations.Location = new Point(47, 701);
            listBoxRecommendations.Name = "listBoxRecommendations";
            listBoxRecommendations.Size = new Size(600, 123);
            listBoxRecommendations.TabIndex = 6;
            // 
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new Point(333, 844);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(150, 40);
            btnBackToMainMenu.TabIndex = 8;
            btnBackToMainMenu.Text = "Back to Main Menu";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(835, 100);
            panelHeader.TabIndex = 9;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(12, 25);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(518, 45);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Local Events and Announcements";
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Location = new Point(12, 113);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(102, 19);
            labelEventName.TabIndex = 10;
            labelEventName.Text = "Name of Event:";
            // 
            // labelEventDetails
            // 
            labelEventDetails.AutoSize = true;
            labelEventDetails.Location = new Point(47, 505);
            labelEventDetails.Name = "labelEventDetails";
            labelEventDetails.Size = new Size(91, 19);
            labelEventDetails.TabIndex = 11;
            labelEventDetails.Text = "Event Details:";
            // 
            // labelRecommendations
            // 
            labelRecommendations.AutoSize = true;
            labelRecommendations.Location = new Point(47, 679);
            labelRecommendations.Name = "labelRecommendations";
            labelRecommendations.Size = new Size(125, 19);
            labelRecommendations.TabIndex = 12;
            labelRecommendations.Text = "Recommendations:";
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 927);
            Controls.Add(labelRecommendations);
            Controls.Add(labelEventDetails);
            Controls.Add(labelEventName);
            Controls.Add(panelHeader);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(listBoxRecommendations);
            Controls.Add(textBoxEventDetails);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxCategory);
            Controls.Add(dateTimePickerSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(listViewEvents);
            Font = new Font("Segoe UI", 10F);
            Name = "LocalEventsForm";
            Text = "Local Events and Announcements";
            Load += LocalEventsForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView listViewEvents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePickerSearch;
        private ComboBox comboBoxCategory;
        private Button buttonSearch;
        private TextBox textBoxEventDetails;
        private ListBox listBoxRecommendations;
       // private Button buttonCreateEvent;
        private Button btnBackToMainMenu;
        private Panel panelHeader;
        private Label labelHeader;
        private Label labelEventName;
        private Label labelEventDetails;
        private Label labelRecommendations;
    }
}
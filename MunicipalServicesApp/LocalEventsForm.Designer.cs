namespace MunicipalServicesApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnDisplayEvents;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRecommendations;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblSearchCategory;

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

            this.lblEventName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblSearchCategory = new System.Windows.Forms.Label();

            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnDisplayEvents = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRecommendations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(30, 10);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(80, 17);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(30, 30);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 22);
            this.txtEventName.TabIndex = 1;

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(30, 70);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 3;

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(30, 120);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 80);
            this.txtDescription.TabIndex = 5;

            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(30, 210);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(77, 17);
            this.lblEventDate.TabIndex = 6;
            this.lblEventDate.Text = "Event Date";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(30, 230);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 7;

            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(30, 270);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(112, 17);
            this.lblSearchCategory.TabIndex = 8;
            this.lblSearchCategory.Text = "Search Category";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(30, 290);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(200, 22);
            this.txtSearchCategory.TabIndex = 9;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(30, 180);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 3;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(30, 220);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(200, 30);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnDisplayEvents
            // 
            this.btnDisplayEvents.Location = new System.Drawing.Point(30, 260);
            this.btnDisplayEvents.Name = "btnDisplayEvents";
            this.btnDisplayEvents.Size = new System.Drawing.Size(200, 30);
            this.btnDisplayEvents.TabIndex = 5;
            this.btnDisplayEvents.Text = "Display Events";
            this.btnDisplayEvents.UseVisualStyleBackColor = true;
            this.btnDisplayEvents.Click += new System.EventHandler(this.btnDisplayEvents_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(250, 30);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(400, 260);
            this.lstEvents.TabIndex = 6;
         
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRecommendations
            // 
            this.btnRecommendations.Location = new System.Drawing.Point(30, 380);
            this.btnRecommendations.Name = "btnRecommendations";
            this.btnRecommendations.Size = new System.Drawing.Size(200, 30);
            this.btnRecommendations.TabIndex = 9;
            this.btnRecommendations.Text = "Recommendations";
            this.btnRecommendations.UseVisualStyleBackColor = true;
            this.btnRecommendations.Click += new System.EventHandler(this.btnRecommendations_Click);
            // 
            // LocalEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnRecommendations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnDisplayEvents);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtEventName);
            this.Name = "LocalEventsForm";
            this.Text = "Local Events Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

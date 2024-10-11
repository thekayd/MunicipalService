namespace MunicipalServicesApp
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
            btnBackToMainMenu = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(92, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(200, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(12, 44);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(31, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new System.Drawing.Point(92, 41);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            dateTimePickerDate.TabIndex = 3;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new System.Drawing.Point(12, 73);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new System.Drawing.Size(55, 15);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Category";
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new System.Drawing.Point(92, 70);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new System.Drawing.Size(200, 23);
            textBoxCategory.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(12, 102);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(67, 15);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(92, 99);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(200, 100);
            textBoxDescription.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new System.Drawing.Point(92, 205);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(75, 23);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(173, 205);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new System.Drawing.Point(92, 234);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new System.Drawing.Size(156, 23);
            btnBackToMainMenu.TabIndex = 10;
            btnBackToMainMenu.Text = "Back to Main Menu";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // EventCreateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 340);
            Controls.Add(btnBackToMainMenu);
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
            Load += EventCreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnBackToMainMenu;
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
    }
}
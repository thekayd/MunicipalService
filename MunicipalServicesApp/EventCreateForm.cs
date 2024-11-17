using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class EventCreateForm : Form
    {
        private Manager _manager;

        // Constructor to initialize the form and subscribe to load and resize events
        public EventCreateForm(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
            this.Load += EventCreateForm_Load;
            this.Resize += EventCreateForm_Resize;
        }

        // Load event handler - styles and centers controls when the form loads
        private void EventCreateForm_Load(object sender, EventArgs e)
        {
            StyleControls();
            CenterControls();
        }

        // Resize event handler - centers controls when the form is resized
        private void EventCreateForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        // Method to apply consistent styling to form controls
        private void StyleControls()
        {
            // Set form background color and disable resizing features
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // Style the header panel and label
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            lblHeader.ForeColor = Color.White;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            // Style all labels except for the header
            foreach (Control c in this.Controls)
            {
                if (c is Label && c != lblHeader)
                {
                    c.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                    c.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Apply font styling to text inputs
            textBoxName.Font = new Font("Segoe UI", 11F);
            textBoxCategory.Font = new Font("Segoe UI", 11F);
            textBoxDescription.Font = new Font("Segoe UI", 11F);
            dateTimePickerDate.Font = new Font("Segoe UI", 11F);

            // Style buttons with a helper method
            StyleButton(buttonCreate);
            StyleButton(buttonCancel);
        }

        // Helper method to apply styling to buttons
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(33, 150, 243);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10);
        }

        // Method to center controls within the form dynamically
        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;  // Get the horizontal center of the form
            int currentY = panelHeader.Bottom + 20; // Start placing controls below the header
            int padding = 10; // Padding between controls

            // Center each control vertically
            CenterControl(labelName, centerX, ref currentY, padding);
            CenterControl(textBoxName, centerX, ref currentY, padding);

            CenterControl(labelDate, centerX, ref currentY, padding);
            CenterControl(dateTimePickerDate, centerX, ref currentY, padding);

            CenterControl(labelCategory, centerX, ref currentY, padding);
            CenterControl(textBoxCategory, centerX, ref currentY, padding);

            CenterControl(labelDescription, centerX, ref currentY, padding);
            CenterControl(textBoxDescription, centerX, ref currentY, padding);

            // Position Create and Cancel buttons side by side
            int buttonWidth = 120;
            int totalButtonsWidth = buttonWidth * 2 + 20; // 20 is the space between buttons
            int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;

            // Set button positions
            buttonCreate.Location = new Point(startX, currentY);
            buttonCreate.Width = buttonWidth;

            buttonCancel.Location = new Point(buttonCreate.Right + 20, currentY);
            buttonCancel.Width = buttonWidth;
        }

        // Helper method to center an individual control horizontally and update Y-position
        private void CenterControl(Control ctrl, int centerX, ref int currentY, int padding)
        {
            ctrl.Left = centerX - ctrl.Width / 2; // Centers control horizontally
            ctrl.Top = currentY; // Set control's top position
            currentY += ctrl.Height + padding; // Update currentY for the next control
        }

        // Create button click event handler - validates input and creates an event
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Create a new event with the form data
                Event newEvent = new Event(
                    textBoxName.Text,
                    dateTimePickerDate.Value,
                    textBoxCategory.Text,
                    textBoxDescription.Text
                );

                // Add the event through the manager and close the form
                _manager.AddEvent(newEvent);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        // Input validation to ensure required fields are filled in
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter an event name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxCategory.Text))
            {
                MessageBox.Show("Please enter a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Cancel button click event handler - closes the form without saving
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Sets dialog result to cancel
            Close();
        }

        private void EventCreateForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
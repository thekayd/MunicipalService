using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class EventCreateForm : Form
    {
        private Manager _manager;

        public EventCreateForm(Manager manager)
        {
            InitializeComponent();
            _manager = manager;
            this.Load += EventCreateForm_Load;
            this.Resize += EventCreateForm_Resize;
        }

        private void EventCreateForm_Load(object sender, EventArgs e)
        {
            StyleControls();
            CenterControls();
        }

        private void EventCreateForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void StyleControls()
        {
            // Set form properties
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // Style header
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            lblHeader.ForeColor = Color.White;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            // Style labels
            foreach (Control c in this.Controls)
            {
                if (c is Label && c != lblHeader)
                {
                    c.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                    c.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }

            // Style text inputs
            textBoxName.Font = new Font("Segoe UI", 11F);
            textBoxCategory.Font = new Font("Segoe UI", 11F);
            textBoxDescription.Font = new Font("Segoe UI", 11F);
            dateTimePickerDate.Font = new Font("Segoe UI", 11F);

            // Style buttons
            StyleButton(buttonCreate);
            StyleButton(buttonCancel);
        }

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

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int currentY = panelHeader.Bottom + 20;
            int padding = 10;

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

            buttonCreate.Location = new Point(startX, currentY);
            buttonCreate.Width = buttonWidth;

            buttonCancel.Location = new Point(buttonCreate.Right + 20, currentY);
            buttonCancel.Width = buttonWidth;
        }

        private void CenterControl(Control ctrl, int centerX, ref int currentY, int padding)
        {
            ctrl.Left = centerX - ctrl.Width / 2;
            ctrl.Top = currentY;
            currentY += ctrl.Height + padding;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Event newEvent = new Event(
                    textBoxName.Text,
                    dateTimePickerDate.Value,
                    textBoxCategory.Text,
                    textBoxDescription.Text
                );

                _manager.AddEvent(newEvent);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EventCreateForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
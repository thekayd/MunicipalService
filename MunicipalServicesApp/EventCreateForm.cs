using System;
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
    }
}
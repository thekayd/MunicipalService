using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class AddRequestForm : Form
    {
        private ServiceManager serviceManager; // Manages service requests using data structures

        public AddRequestForm(ServiceManager manager)
        {
            serviceManager = manager; // This is the dependency injection of the ServiceManager
            InitializeComponent(); // Sets up the form's components
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // Ensures all required fields are properly filled
            {
                var request = CreateServiceRequest(); // Creates a service request object based on user input
                serviceManager.InsertBST(request); // Inserts into a Binary Search Tree
                serviceManager.InsertAVL(request); // Inserts into an AVL tree for balanced searching
                serviceManager.InsertRB(request); // Inserts into a Red-Black tree for additional balance
                serviceManager.InsertHeap(request); // Inserts into a Heap for priority handling
                this.DialogResult = DialogResult.OK; // Signals successful submission
                this.Close(); // Closes the form
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text)) // Checks for an empty description
            {
                MessageBox.Show("Please enter a description."); // Prompts the user
                return false;
            }

            if (cmbCategory.SelectedIndex == -1) // Ensures a category is selected
            {
                MessageBox.Show("Please select a category."); // Prompts the user
                return false;
            }

            if (cmbPriority.SelectedIndex == -1) // Ensures a priority level is selected
            {
                MessageBox.Show("Please select a priority level."); 
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location."); 
                return false;
            }

            return true; // All validations passed
        }

        private ServiceRequest CreateServiceRequest()
        {
            return new ServiceRequest
            {
                Id = ServiceManager.GenerateNextRequestId(), // Generates a unique ID for the request
                Description = txtDescription.Text, // Sets the user-provided description
                Category = cmbCategory.SelectedItem.ToString(), // Gets the selected category
                Priority = cmbPriority.SelectedIndex + 1, // Maps the selected priority to a numeric level
                Location = txtLocation.Text, // Sets the location provided by the user
                Status = "New", // Defaults status for a new request
                CreatedDate = DateTime.Now // Records the current date and time
            };
        }
    }
}

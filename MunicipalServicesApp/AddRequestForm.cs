using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class AddRequestForm : Form
    {
        private ServiceManager serviceManager;

        public AddRequestForm(ServiceManager manager)
        {
            serviceManager = manager;
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var request = CreateServiceRequest();
                serviceManager.InsertBST(request);
                serviceManager.InsertAVL(request);
                serviceManager.InsertRB(request);
                serviceManager.InsertHeap(request);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return false;
            }

            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a priority level.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.");
                return false;
            }

            return true;
        }

        private ServiceRequest CreateServiceRequest()
        {
            return new ServiceRequest
            {
                Id = GenerateRequestId(),
                Description = txtDescription.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Priority = cmbPriority.SelectedIndex + 1,
                Location = txtLocation.Text,
                Status = "New",
                CreatedDate = DateTime.Now
            };
        }

        private string GenerateRequestId()
        {
            return $"SR{DateTime.Now:yyyyMMddHHmmss}";
        }
    }
}

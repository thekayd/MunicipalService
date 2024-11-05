using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private ServiceManager serviceManager;

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            serviceManager = new ServiceManager();
            InitializeTestData();
        }

        private void InitializeTestData()
        {
            // Add some test data
            var requests = new List<ServiceRequest>
            {
                new ServiceRequest { Id = "SR001", Description = "Road repair", Status = "In Progress", Priority = 1, Category = "Infrastructure", CreatedDate = DateTime.Now.AddDays(-5) },
                new ServiceRequest { Id = "SR002", Description = "Street light repair", Status = "Pending", Priority = 2, Category = "Maintenance", CreatedDate = DateTime.Now.AddDays(-3) },
                new ServiceRequest { Id = "SR003", Description = "Garbage collection", Status = "Completed", Priority = 3, Category = "Sanitation", CreatedDate = DateTime.Now.AddDays(-1) }
            };

            foreach (var request in requests)
            {
                serviceManager.InsertBST(request);
                serviceManager.InsertAVL(request);
                serviceManager.InsertRB(request);
                serviceManager.InsertHeap(request);
                UpdateListView(request);
            }

            // Add some test relationships
            serviceManager.AddGraphConnection("SR001", "SR002");
            serviceManager.AddGraphConnection("SR002", "SR003");
        }

        private void UpdateListView(ServiceRequest request)
        {
            var item = new ListViewItem(request.Id);
            item.SubItems.Add(request.Description);
            item.SubItems.Add(request.Status);
            item.SubItems.Add(request.Priority.ToString());
            item.SubItems.Add(request.Category);
            item.SubItems.Add(request.CreatedDate.ToString("yyyy-MM-dd HH:mm"));
            listViewRequests.Items.Add(item);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtSearchId.Text.Trim();
            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter a request ID");
                return;
            }

            var request = serviceManager.FindRequestBST(searchId);
            if (request != null)
            {
                listViewRequests.Items.Clear();
                UpdateListView(request);

                // Show related requests
                var relatedRequests = serviceManager.GetRelatedRequests(searchId);
                foreach (var relatedId in relatedRequests)
                {
                    var relatedRequest = serviceManager.FindRequestBST(relatedId);
                    if (relatedRequest != null)
                        UpdateListView(relatedRequest);
                }
            }
            else
            {
                MessageBox.Show("Request not found");
            }
        }

        private void BtnAddRequest_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddRequestForm(serviceManager))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the list view
                    listViewRequests.Items.Clear();
                    var requests = serviceManager.GetPrioritizedRequests();
                    foreach (var request in requests)
                    {
                        UpdateListView(request);
                    }
                }
            }
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var requests = serviceManager.GetPrioritizedRequests();

            switch (cmbSort.SelectedItem.ToString())
            {
                case "Priority":
                    requests = requests.OrderBy(r => r.Priority).ToList();
                    break;
                case "Date":
                    requests = requests.OrderByDescending(r => r.CreatedDate).ToList();
                    break;
                case "Status":
                    requests = requests.OrderBy(r => r.Status).ToList();
                    break;
            }

            listViewRequests.Items.Clear();
            foreach (var request in requests)
            {
                UpdateListView(request);
            }
        }
    }
}
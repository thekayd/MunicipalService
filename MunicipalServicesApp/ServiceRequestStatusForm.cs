using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private ServiceManager serviceManager;
        // Implements various data structures (BST, AVL, RB Tree, Heap) for efficient request management.

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            serviceManager = new ServiceManager();  // Manager class that handles all service request operations and data structures
            InitializeTestData();
        }

        // Initializes sample service requests and their relationships for testing, creates test data with various priorities, statuses, and categories
        // Also establishes connections between related service requests in the graph
        private void InitializeTestData()
        {
            // Creates sample service requests with different attributes
            var requests = new List<ServiceRequest>
            {
               new ServiceRequest { Id = "SR001", Description = "Road repair", Status = "In Progress", Priority = 1, Category = "Infrastructure", Location = "Main St", CreatedDate = DateTime.Now.AddDays(-5) },
               new ServiceRequest { Id = "SR002", Description = "Street light repair", Status = "Pending", Priority = 2, Category = "Maintenance", Location = "2nd Ave", CreatedDate = DateTime.Now.AddDays(-3) },
               new ServiceRequest { Id = "SR003", Description = "Garbage collection", Status = "Completed", Priority = 3, Category = "Sanitation", Location = "Parkside", CreatedDate = DateTime.Now.AddDays(-1) },
               new ServiceRequest { Id = "SR004", Description = "Water leak repair", Status = "In Progress", Priority = 2, Category = "Utilities", Location = "5th St", CreatedDate = DateTime.Now.AddDays(-7) },
               new ServiceRequest { Id = "SR005", Description = "Public park cleanup", Status = "Pending", Priority = 1, Category = "Sanitation", Location = "Central Park", CreatedDate = DateTime.Now.AddDays(-2) }

            };

            // Inserts each request into all data structures for comparison
            foreach (var request in requests)
            {
                serviceManager.InsertBST(request);
                serviceManager.InsertAVL(request);
                serviceManager.InsertRB(request);
                serviceManager.InsertHeap(request);
                UpdateListView(request);
            }

            // Graph relationships
            // Defines relationships between service requests using a graph structure
            // Each connection represents related or dependent service requests
            serviceManager.AddGraphConnection("SR001", "SR002");
            serviceManager.AddGraphConnection("SR001", "SR004");
            serviceManager.AddGraphConnection("SR002", "SR001");
            serviceManager.AddGraphConnection("SR002", "SR004");
            serviceManager.AddGraphConnection("SR003", "SR005");
            serviceManager.AddGraphConnection("SR004", "SR001");
            serviceManager.AddGraphConnection("SR004", "SR002");
            serviceManager.AddGraphConnection("SR005", "SR003");
        }

        // Updates the main ListView with a single service request
        // Displays ID, description, status, priority, category, and creation date
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

        // Updates the related requests ListView with a list of related service requests
        // Clears existing items and adds all related requests with their details
        private void UpdateRelatedListView(List<ServiceRequest> relatedRequests)
        {
            listViewRelatedRequests.Items.Clear();
            foreach (var request in relatedRequests)
            {
                var item = new ListViewItem(request.Id);
                item.SubItems.Add(request.Description);
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Priority.ToString());
                item.SubItems.Add(request.Category);
                item.SubItems.Add(request.CreatedDate.ToString("yyyy-MM-dd HH:mm"));
                listViewRelatedRequests.Items.Add(item);
            }
        }

        // Handles the search button click event
        // Searches for a service request by ID and displays it along with related requests
        // Uses BST for efficient searching
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtSearchId.Text.Trim();
            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter a request ID");
                return;
            }

            // Search for the request in BST and display if found
            var request = serviceManager.FindRequestBST(searchId);
            if (request != null)
            {
                listViewRequests.Items.Clear();
                UpdateListView(request);
 
                // Find and display related requests using graph connections
                var relatedIds = serviceManager.GetRelatedRequests(searchId);
                var relatedRequests = new List<ServiceRequest>();

                foreach (var relatedId in relatedIds)
                {
                    var relatedRequest = serviceManager.FindRequestBST(relatedId);
                    if (relatedRequest != null)
                    {
                        relatedRequests.Add(relatedRequest);
                    }
                }
                UpdateRelatedListView(relatedRequests);
            }
            else
            {
                MessageBox.Show("Request not found");
            }
        }

        // Handles adding new service requests through a separate form
        // Updates the main ListView with the new request if added successfully
        private void BtnAddRequest_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddRequestForm(serviceManager))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the ListView with updated data
                    listViewRequests.Items.Clear();
                    var requests = serviceManager.GetPrioritizedRequests();
                    foreach (var request in requests)
                    {
                        UpdateListView(request);
                    }
                }
            }
        }

        // Handles the sorting combo box selection change
        // Sorts requests by priority, date, or status based on user selection
        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var requests = serviceManager.GetPrioritizedRequests();

            // Apply different sorting based on user selection
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

            // Update ListView with sorted requests
            listViewRequests.Items.Clear();
            foreach (var request in requests)
            {
                UpdateListView(request);
            }
        }
        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the current form and returns to the main menu
        }
        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            if (listViewRequests.SelectedItems.Count > 0)
            {
                // Gets the ID of the selected request from the ListView
                string selectedRequestId = listViewRequests.SelectedItems[0].Text;
                
                // Finds the request using the BST in serviceManager
                var selectedRequest = serviceManager.FindRequestBST(selectedRequestId);

                if (selectedRequest != null)
                {
                    // Opens the RequestDetailsForm with the selected request
                    var detailsForm = new RequestDetailsForm(selectedRequest, serviceManager);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Service request ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a service request ID from list to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
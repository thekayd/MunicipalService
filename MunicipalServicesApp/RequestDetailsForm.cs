using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class RequestDetailsForm : Form
    {
        private ServiceRequest request; // Represents the service request being viewed
        private ServiceManager serviceManager; // Manages service requests and related operations

        public RequestDetailsForm(ServiceRequest request, ServiceManager manager)
        {
            this.request = request; // Initializes the current request
            this.serviceManager = manager; // References to ServiceManager for managing requests
            InitializeComponent(); // Initializes UI components
            LoadRequestDetails(); // Populates details about the selected request
            LoadRelatedRequests(); // Displays related requests, if any
        }

        private void LoadRequestDetails()
        {
            var details = new Dictionary<string, string> // Key-value pairs for displaying request details
            {
                { "ID", request.Id }, // Displays request ID
                { "Description", request.Description }, // Displays request description
                { "Status", request.Status }, // Displays current status of the request
                { "Priority", request.Priority.ToString() }, // Converts priority level to string for display
                { "Category", request.Category }, // Displays the category of the request
                { "Location", request.Location }, // Displays location associated with the request
                { "Created Date", request.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss") } // Formats and displays creation date
            };
            
            foreach (var detail in details) // Loops through the details dictionary
            {
                var item = new ListViewItem(detail.Key); // Creates a new ListView item for each detail
                item.SubItems.Add(detail.Value); // Adds the corresponding value as a sub-item
                listViewDetails.Items.Add(item); // Adds the item to the ListView
            }
        }

        private void LoadRelatedRequests()
        {
            var relatedIds = serviceManager.GetRelatedRequests(request.Id); // Fetches related request IDs from the ServiceManager
            foreach (var id in relatedIds) // Loops through related request IDs
            {
                var relatedRequest = serviceManager.FindRequestBST(id); // Finds the related request using Binary Search Tree
                if (relatedRequest != null) // Checks if the related request exists
                {
                    var item = new ListViewItem(relatedRequest.Id); // Creates a new ListView item for the related request
                    item.SubItems.Add(relatedRequest.Description); // Adds description as a sub-item
                    item.SubItems.Add(relatedRequest.Status); // Adds status as a sub-item
                    item.SubItems.Add(relatedRequest.Priority.ToString()); // Adds priority as a sub-item
                    listViewRelated.Items.Add(item); // Adds the related request to the ListView
                }
            }
        }
    }
}

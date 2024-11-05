using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class RequestDetailsForm : Form
    {
        private ServiceRequest request;
        private ServiceManager serviceManager;

        public RequestDetailsForm(ServiceRequest request, ServiceManager manager)
        {
            this.request = request;
            this.serviceManager = manager;
            InitializeComponent();
            LoadRequestDetails();
            LoadRelatedRequests();
        }

        private void LoadRequestDetails()
        {
            var details = new Dictionary<string, string>
            {
                { "ID", request.Id },
                { "Description", request.Description },
                { "Status", request.Status },
                { "Priority", request.Priority.ToString() },
                { "Category", request.Category },
                { "Location", request.Location },
                { "Created Date", request.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss") }
            };

            foreach (var detail in details)
            {
                var item = new ListViewItem(detail.Key);
                item.SubItems.Add(detail.Value);
                listViewDetails.Items.Add(item);
            }
        }

        private void LoadRelatedRequests()
        {
            var relatedIds = serviceManager.GetRelatedRequests(request.Id);
            foreach (var id in relatedIds)
            {
                var relatedRequest = serviceManager.FindRequestBST(id);
                if (relatedRequest != null)
                {
                    var item = new ListViewItem(relatedRequest.Id);
                    item.SubItems.Add(relatedRequest.Description);
                    item.SubItems.Add(relatedRequest.Status);
                    item.SubItems.Add(relatedRequest.Priority.ToString());
                    listViewRelated.Items.Add(item);
                }
            }
        }
    }
}

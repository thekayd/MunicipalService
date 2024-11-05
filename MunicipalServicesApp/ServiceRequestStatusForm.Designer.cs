using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        private ListView listViewRequests;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Button btnAddRequest;
        private ComboBox cmbSort;
        private Button btnBackToMenu;
        private Button btnViewDetails;

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
            this.components = new System.ComponentModel.Container();

            this.Text = "Service Request Status";
            this.Size = new Size(800, 600);

            // Initialize ListView
            this.listViewRequests = new ListView();
            this.listViewRequests.Dock = DockStyle.Bottom;
            this.listViewRequests.Height = 400;
            this.listViewRequests.View = View.Details;
            this.listViewRequests.Columns.Add("ID", 100);
            this.listViewRequests.Columns.Add("Description", 200);
            this.listViewRequests.Columns.Add("Status", 100);
            this.listViewRequests.Columns.Add("Priority", 80);
            this.listViewRequests.Columns.Add("Category", 100);
            this.listViewRequests.Columns.Add("Created Date", 150);

            // Initialize Search Controls
            this.txtSearchId = new TextBox();
            this.txtSearchId.Location = new Point(20, 20);
            this.txtSearchId.Size = new Size(150, 23);
            this.txtSearchId.PlaceholderText = "Enter Request ID";

            this.btnSearch = new Button();
            this.btnSearch.Location = new Point(180, 20);
            this.btnSearch.Size = new Size(75, 23);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += BtnSearch_Click;

            this.btnAddRequest = new Button();
            this.btnAddRequest.Location = new Point(270, 20);
            this.btnAddRequest.Size = new Size(100, 23);
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.Click += BtnAddRequest_Click;

            this.cmbSort = new ComboBox();
            this.cmbSort.Location = new Point(380, 20);
            this.cmbSort.Size = new Size(150, 23);
            this.cmbSort.Items.AddRange(new string[] { "Priority", "Date", "Status" });
            this.cmbSort.SelectedIndexChanged += CmbSort_SelectedIndexChanged;

            // Initialize Back to Menu Button
            this.btnBackToMenu = new Button();
            this.btnBackToMenu.Location = new Point(540, 20);
            this.btnBackToMenu.Size = new Size(150, 23);
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.Click += BtnBackToMenu_Click;

            // Initialize View Details Button
            this.btnViewDetails = new Button();
            this.btnViewDetails.Location = new Point(540, 50);  // Position under Back to Menu button
            this.btnViewDetails.Size = new Size(150, 23);
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.Click += BtnViewDetails_Click;

            // Add controls to form
            this.Controls.AddRange(new Control[] {
                this.listViewRequests,
                this.txtSearchId,
                this.btnSearch,
                this.btnAddRequest,
                this.cmbSort,
                this.btnBackToMenu,
                this.btnViewDetails
            });
        }
    }
}
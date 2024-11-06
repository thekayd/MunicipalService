using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        private ListView listViewRequests;
        private ListView listViewRelatedRequests;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Button btnAddRequest;
        private ComboBox cmbSort;
        private Button btnBackToMenu;
        private Button btnViewDetails;
        private Panel panelHeader;
        private Label labelHeader;
        private Label labelSearchId;
        private Label labelSort;
        private Label labelRequestDetails;
        private Label labelRelatedRequests;

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
            this.Size = new Size(850, 900);
            this.BackColor = Color.White;

            // Initialize Header Panel
            this.panelHeader = new Panel();
            this.panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 100;

            this.labelHeader = new Label();
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.labelHeader.ForeColor = Color.White;
            this.labelHeader.Location = new Point(12, 25);
            this.labelHeader.Text = "Service Request Status";
            this.panelHeader.Controls.Add(this.labelHeader);

            // Initialize ListView
            this.listViewRequests = new ListView();
            this.listViewRequests.Dock = DockStyle.Bottom;
            this.listViewRequests.Height = 300;
            this.listViewRequests.View = View.Details;
            this.listViewRequests.Columns.Add("ID", 100);
            this.listViewRequests.Columns.Add("Description", 200);
            this.listViewRequests.Columns.Add("Status", 100);
            this.listViewRequests.Columns.Add("Priority", 80);
            this.listViewRequests.Columns.Add("Category", 100);
            this.listViewRequests.Columns.Add("Created Date", 150);
            this.listViewRequests.BackColor = Color.WhiteSmoke;
            this.listViewRequests.Font = new Font("Segoe UI", 9F);
            this.listViewRequests.FullRowSelect = true;

            // Initialize Label for related requests heading
            this.labelRelatedRequests = new Label();
            this.labelRelatedRequests.Text = "Related Service Requests";
            this.labelRelatedRequests.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelRelatedRequests.Location = new Point(20, 320);
            this.labelRelatedRequests.Size = new Size(200, 20);

            // Initialize ListView for related requests
            this.listViewRelatedRequests = new ListView();
            this.listViewRelatedRequests.Location = new Point(20, 350);
            this.listViewRelatedRequests.Size = new Size(740, 150);
            this.listViewRelatedRequests.View = View.Details;
            this.listViewRelatedRequests.Columns.Add("ID", 100);
            this.listViewRelatedRequests.Columns.Add("Description", 200);
            this.listViewRelatedRequests.Columns.Add("Status", 100);
            this.listViewRelatedRequests.Columns.Add("Priority", 80);
            this.listViewRelatedRequests.Columns.Add("Category", 100);
            this.listViewRelatedRequests.Columns.Add("Created Date", 150);
            this.listViewRelatedRequests.FullRowSelect = true;

            // Initialize Search Controls
            this.labelSearchId = new Label();
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Location = new Point(20, 120);
            this.labelSearchId.Text = "Search by ID:";

            this.txtSearchId = new TextBox();
            this.txtSearchId.Location = new Point(120, 117);
            this.txtSearchId.Size = new Size(150, 25);
            this.txtSearchId.PlaceholderText = "Enter Request ID";

            this.btnSearch = new Button();
            this.btnSearch.Location = new Point(280, 117);
            this.btnSearch.Size = new Size(90, 25);
            this.btnSearch.Text = "Search";
            this.btnSearch.BackColor = Color.FromArgb(33, 150, 243); // Set button background color to blue
            this.btnSearch.ForeColor = Color.White; // Set button text color to white
            this.btnSearch.Click += BtnSearch_Click;

            this.btnAddRequest = new Button();
            this.btnAddRequest.Location = new Point(380, 117);
            this.btnAddRequest.Size = new Size(120, 25);
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.BackColor = Color.FromArgb(33, 150, 243); // Set button background color to blue
            this.btnAddRequest.ForeColor = Color.White; // Set button text color to white
            this.btnAddRequest.Click += BtnAddRequest_Click;

            this.labelSort = new Label();
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new Point(520, 120);
            this.labelSort.Text = "Sort by:";

            this.cmbSort = new ComboBox();
            this.cmbSort.Location = new Point(580, 117);
            this.cmbSort.Size = new Size(150, 25);
            this.cmbSort.Items.AddRange(new string[] { "Priority", "Date", "Status" });
            this.cmbSort.SelectedIndexChanged += CmbSort_SelectedIndexChanged;

            // Initialize View Details Button
            this.btnViewDetails = new Button();
            this.btnViewDetails.Location = new Point(20, 160);
            this.btnViewDetails.Size = new Size(120, 25);
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.BackColor = Color.FromArgb(33, 150, 243); // Set button background color to blue
            this.btnViewDetails.ForeColor = Color.White; // Set button text color to white
            this.btnViewDetails.Click += BtnViewDetails_Click;

            // Initialize Back to Menu Button
            this.btnBackToMenu = new Button();
            this.btnBackToMenu.Location = new Point(20, 200);
            this.btnBackToMenu.Size = new Size(120, 25);
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.BackColor = Color.FromArgb(33, 150, 243); // Set button background color to blue
            this.btnBackToMenu.ForeColor = Color.White; // Set button text color to white
            this.btnBackToMenu.Click += BtnBackToMenu_Click;




            // Add controls to form
            this.Controls.AddRange(new Control[] {
        this.listViewRequests,
        this.labelSearchId,
        this.txtSearchId,
        this.btnSearch,
        this.btnAddRequest,
        this.labelSort,
        this.cmbSort,
        this.btnViewDetails,
        this.btnBackToMenu,
        this.labelRequestDetails,
        this.panelHeader,
        this.labelRelatedRequests,
        this.listViewRelatedRequests
    });
        }
    }
}
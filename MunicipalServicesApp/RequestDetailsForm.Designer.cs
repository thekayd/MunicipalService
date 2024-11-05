using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class RequestDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private ListView listViewDetails;
        private ListView listViewRelated;

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

            this.Text = $"Request Details - {request.Id}";
            this.Size = new Size(600, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            // Details ListView
            this.listViewDetails = new ListView
            {
                Location = new Point(20, 20),
                Size = new Size(540, 200),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            this.listViewDetails.Columns.Add("Field", 150);
            this.listViewDetails.Columns.Add("Value", 370);

            // Related Requests ListView
            var lblRelated = new Label
            {
                Text = "Related Requests:",
                Location = new Point(20, 230),
                Size = new Size(200, 23)
            };

            this.listViewRelated = new ListView
            {
                Location = new Point(20, 260),
                Size = new Size(540, 150),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            this.listViewRelated.Columns.Add("ID", 100);
            this.listViewRelated.Columns.Add("Description", 200);
            this.listViewRelated.Columns.Add("Status", 120);
            this.listViewRelated.Columns.Add("Priority", 100);

            this.Controls.AddRange(new Control[] {
                this.listViewDetails,
                lblRelated,
                this.listViewRelated
            });
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class AddRequestForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private ComboBox cmbPriority;
        private TextBox txtLocation;
        private Button btnSubmit;
        private Button btnCancel;

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

            this.Text = "Add New Service Request";
            this.Size = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Description
            var lblDescription = new Label
            {
                Text = "Description:",
                Location = new Point(20, 20),
                Size = new Size(80, 23)
            };

            this.txtDescription = new TextBox
            {
                Location = new Point(110, 20),
                Size = new Size(250, 23),
                Multiline = true,
                Height = 60
            };

            // Category
            var lblCategory = new Label
            {
                Text = "Category:",
                Location = new Point(20, 90),
                Size = new Size(80, 23)
            };

            this.cmbCategory = new ComboBox
            {
                Location = new Point(110, 90),
                Size = new Size(250, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.cmbCategory.Items.AddRange(new string[] {
                "Infrastructure",
                "Maintenance",
                "Sanitation",
                "Public Safety",
                "Utilities",
                "Other"
            });

            // Priority
            var lblPriority = new Label
            {
                Text = "Priority:",
                Location = new Point(20, 120),
                Size = new Size(80, 23)
            };

            this.cmbPriority = new ComboBox
            {
                Location = new Point(110, 120),
                Size = new Size(250, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.cmbPriority.Items.AddRange(new string[] {
                "1 - High",
                "2 - Medium",
                "3 - Low"
            });

            // Location
            var lblLocation = new Label
            {
                Text = "Location:",
                Location = new Point(20, 150),
                Size = new Size(80, 23)
            };

            this.txtLocation = new TextBox
            {
                Location = new Point(110, 150),
                Size = new Size(250, 23)
            };

            // Buttons
            this.btnSubmit = new Button
            {
                Text = "Submit",
                DialogResult = DialogResult.OK,
                Location = new Point(110, 200),
                Size = new Size(100, 30)
            };
            this.btnSubmit.Click += BtnSubmit_Click;

            this.btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(260, 200),
                Size = new Size(100, 30)
            };

            // Add controls to form
            this.Controls.AddRange(new Control[] {
                lblDescription,
                this.txtDescription,
                lblCategory,
                this.cmbCategory,
                lblPriority,
                this.cmbPriority,
                lblLocation,
                this.txtLocation,
                this.btnSubmit,
                this.btnCancel
            });
        }
    }
}
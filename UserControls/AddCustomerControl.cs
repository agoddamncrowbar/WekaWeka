using System;
using System.Windows.Forms;
using System.Xml.Linq;
using WekaWeka.Models;
using WekaWeka.Repositories;
using WekaWeka.Utils;

namespace WekaWeka.UserControls
{
    public partial class AddCustomerControl : UserControl
    {
        public AddCustomerControl()
        {
            InitializeComponent();
            SetupIdTypes();
        }

        private void SetupIdTypes()
        {
            cmbIdType.Items.Add("National ID");
            cmbIdType.Items.Add("Passport");
            cmbIdType.Items.Add("Driver License");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                lblStatus.Text = "Name is required";
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                lblStatus.Text = "Phone number is required";
                return;
            }

            var customer = new Customer
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Phone = phone,
                Email = txtEmail.Text.Trim(),
                IdNumber = txtIdNumber.Text.Trim(),
                IdType = cmbIdType.SelectedItem?.ToString(),

                NodeId = SessionManager.CurrentNodeId,
                CreatedAt = DateTime.UtcNow.ToString("o"),
                UpdatedAt = DateTime.UtcNow.ToString("o"),
                IsDeleted = 0
            };

            var repo = new CustomerRepository();
            repo.Insert(customer);

            lblStatus.ForeColor = System.Drawing.Color.Green;
            lblStatus.Text = "Customer saved successfully";

            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtIdNumber.Clear();
            cmbIdType.SelectedIndex = -1;
        }
    }
}
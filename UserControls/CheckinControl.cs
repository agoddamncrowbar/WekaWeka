using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WekaWeka.Models;
using WekaWeka.Repositories;
using WekaWeka.Utils;

namespace WekaWeka.UserControls
{
    public partial class CheckinControl : UserControl
    {
        public CheckinControl()
        {
            InitializeComponent();
            this.Load += CheckinControl_Load;
        }
        private void CheckinControl_Load(object sender, EventArgs e)
        {
            OpenCustomerSearch();
        }
        private string GenerateTag(string customerId, string nodeId, string luggageId)
        {
            var raw = $"{customerId}-{nodeId}-{luggageId}";

            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));

                // take first 6 bytes → short but unique enough
                return Convert.ToBase64String(bytes)
                    .Replace("/", "")
                    .Replace("+", "")
                    .Substring(0, 10)
                    .ToUpper();
            }
        }
        private Customer selectedCustomer;
        public event Action<UserControl> OnNavigate;
        private void OpenCustomerSearch()
        {
            var searchControl = new CustomerSearchControl();

            searchControl.OnCustomerSelected += (customer) =>
            {
                selectedCustomer = customer;

                lblCustomerName.Text = customer.Name;
                lblCustomerPhone.Text = customer.Phone;

                // navigate back to THIS control
                OnNavigate?.Invoke(this);
            };

            // navigate to search screen
            OnNavigate?.Invoke(searchControl);
            searchControl.OnNavigate += (control) =>
            {
                OnNavigate?.Invoke(control);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                lblStatus.Text = "Select a customer first";
                return;
            }

            var description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                lblStatus.Text = "Description is required";
                return;
            }

            double? weight = null;
            if (!string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                if (double.TryParse(txtWeight.Text, out var w))
                    weight = w;
                else
                {
                    lblStatus.Text = "Invalid weight";
                    return;
                }
            }
            var luggageId = Guid.NewGuid().ToString();

            var tag = GenerateTag(
                selectedCustomer.Id,
                SessionManager.CurrentNodeId,
                luggageId
            );

            var luggage = new Luggage
            {
                id = luggageId,
                customer_id = selectedCustomer.Id,
                description = txtDescription.Text.Trim(),
                weight = weight,
                tag_number = tag,
                status = "checked_in",

                origin = SessionManager.CurrentNodeId,
                current_location = SessionManager.CurrentNodeId,

                is_fragile = chkFragile.Checked ? 1 : 0,

                node_id = SessionManager.CurrentNodeId,
                created_at = DateTime.UtcNow.ToString("o"),
                updated_at = DateTime.UtcNow.ToString("o"),
            };

            try
            {
                var repo = new LuggageRepository();
                repo.Insert(luggage);

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"Saved. Tag: {luggage.tag_number}";

                ClearForm();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }
        private void ClearForm()
        {
            txtDescription.Clear();
            txtWeight.Clear();
            txtOrigin.Clear();
            txtDestination.Clear();
        }
    }
}

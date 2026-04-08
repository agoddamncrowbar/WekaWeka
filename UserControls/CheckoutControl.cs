using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WekaWeka.Models;
using WekaWeka.Repositories;
using WekaWeka.Utils;

namespace WekaWeka.UserControls
{
    public partial class CheckoutControl : UserControl
    {
        private readonly List<Luggage> _luggages;
        private readonly Customer _customer;

        public CheckoutControl(List<Luggage> luggages, Customer customer)
        {
            InitializeComponent();
            _luggages = luggages;
            _customer = customer;
        }

        private void CheckoutControl_Load(object sender, EventArgs e)
        {
            dgvSelectedLuggage.DataSource = _luggages.Select(l => new
            {
                Tag = l.tag_number,
                Description = l.description,
                Status = l.status
            }).ToList();

            chkSelf.Checked = true;
            chkSelf_CheckedChanged(null, null);
        }
        private void chkSelf_CheckedChanged(object sender, EventArgs e)
        {
            bool isSelf = chkSelf.Checked;

            txtCollectorName.Visible = !isSelf;
            txtCollectorPhone.Visible = !isSelf;
            txtCollectorId.Visible = !isSelf;
            txtRelationship.Visible = !isSelf;

            // If you have labels, hide them too
            label2.Visible = !isSelf;
            label3.Visible = !isSelf;
            label4.Visible = !isSelf;
            label5.Visible = !isSelf;
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!chkSelf.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCollectorName.Text))
                {
                    MessageBox.Show("Collector name required.");
                    return;
                }
            }

            var now = DateTime.UtcNow.ToString("o");

            var checkouts = _luggages.Select(l => new LuggageCheckout
            {
                id = Guid.NewGuid().ToString(),
                luggage_id = l.id,
                customer_id = _customer.Id,

                collector_name = chkSelf.Checked ? null : txtCollectorName.Text,
                collector_phone = chkSelf.Checked ? null : txtCollectorPhone.Text,
                collector_id_number = chkSelf.Checked ? null : txtCollectorId.Text,
                relationship_to_customer = chkSelf.Checked ? "self" : txtRelationship.Text,

                remarks = txtRemarks.Text,

                checked_out_by_user_id = SessionManager.CurrentUser.Id,
                node_id = SessionManager.CurrentNodeId,
                checked_out_at = now
            }).ToList();

            var repo = new LuggageCheckoutRepository();
            var success = repo.CheckoutMultiple(checkouts);

            if (success)
            {
                MessageBox.Show("Checkout successful.");
                // optionally navigate back
            }
            else
            {
                MessageBox.Show("Checkout failed. Some items may already be checked out.");
            }
        }
    }
}

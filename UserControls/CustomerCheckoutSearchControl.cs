using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WekaWeka.Models;
using WekaWeka.Repositories;

namespace WekaWeka.UserControls
{
    public partial class CustomerCheckoutSearchControl : UserControl
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly LuggageRepository _luggageRepo = new LuggageRepository();

        private List<Customer> _customers = new();
        private List<Luggage> _luggages = new();

        private Customer _selectedCustomer;

        public event Action<List<Luggage>, Customer> OnProceedToCheckout;

        public CustomerCheckoutSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text.Trim();

            _customers = _customerRepo.Search(query);

            dgvCustomers.DataSource = _customers;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
                return;

            var customer = dgvCustomers.CurrentRow.DataBoundItem as Customer;
            if (customer == null)
                return;

            _selectedCustomer = customer;

            LoadLuggage(customer.Id);
        }

        private void LoadLuggage(string customerId)
        {
            _luggages = _luggageRepo.GetByCustomer(customerId);

            // add selection wrapper
            var selectable = _luggages.Select(l => new SelectableLuggage
            {
                Luggage = l,
                IsSelected = false
            }).ToList();

            dgvLuggage.DataSource = selectable;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            var selected = ((List<SelectableLuggage>)dgvLuggage.DataSource)
                .Where(x => x.IsSelected)
                .Select(x => x.Luggage)
                .ToList();

            if (!selected.Any())
            {
                MessageBox.Show("Select at least one luggage.");
                return;
            }

            OnProceedToCheckout?.Invoke(selected, _selectedCustomer);
        }
        private void dgvLuggage_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvLuggage.IsCurrentCellDirty)
            {
                dgvLuggage.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvLuggage_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateProceedButtonState();
        }
        private void UpdateProceedButtonState()
        {
            if (_selectedCustomer == null || dgvLuggage.DataSource == null)
            {
                btnProceed.Enabled = false;
                return;
            }

            var list = (List<SelectableLuggage>)dgvLuggage.DataSource;

            btnProceed.Enabled = list.Any(x => x.IsSelected);
        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvLuggage.DataSource == null)
                return;

            var list = dgvLuggage.DataSource as List<SelectableLuggage>;
            if (list == null)
                return;

            bool isChecked = chkSelectAll.Checked;

            foreach (var item in list)
            {
                item.IsSelected = isChecked;
            }

            dgvLuggage.Refresh();
            UpdateProceedButtonState();
        }
    }


    public class SelectableLuggage
    {
        public bool IsSelected { get; set; }
        public Luggage Luggage { get; set; }

        // flatten for DataGridView
        public string Tag => Luggage.tag_number;
        public string Description => Luggage.description;
        public string Status => Luggage.status;
    }
}
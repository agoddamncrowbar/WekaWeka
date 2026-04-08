using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WekaWeka.Models;
using WekaWeka.Repositories;

namespace WekaWeka.UserControls
{
    public partial class CustomerSearchControl : UserControl
    {
        public CustomerSearchControl()
        {
            InitializeComponent();
        }
        public event Action<Customer> OnCustomerSelected;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var repo = new CustomerRepository();
            var results = repo.Search(txtSearch.Text.Trim());

            dataGridCustomers.DataSource = results;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow == null)
                return;

            var customer = (Customer)dataGridCustomers.CurrentRow.DataBoundItem;

            OnCustomerSelected?.Invoke(customer);


        }
        public event Action<UserControl> OnNavigate;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomerControl();
            OnNavigate?.Invoke(addCustomer);
        }

    }
}

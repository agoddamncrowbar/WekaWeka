using System;
using System.Windows.Forms;

namespace WekaWeka.UserControls
{
    public partial class Dashboard : UserControl
    {
        public event Action OnCheckinClicked;
        public event Action OnCheckoutClicked;
        public event Action OnLuggageListClicked;
        public event Action OnAddCustomerClicked;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            OnCheckinClicked?.Invoke();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            OnCheckoutClicked?.Invoke();
        }

        private void btnLuggageList_Click(object sender, EventArgs e)
        {
            OnLuggageListClicked?.Invoke();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OnAddCustomerClicked?.Invoke();
        }
    }
}
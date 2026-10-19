using System;
using System.Windows.Forms;

namespace WekaWeka.UserControls
{
    public partial class AppLayoutControl : UserControl
    {
        public event Action OnDashboardClicked;
        public event Action OnCheckinClicked;
        public event Action OnCheckoutClicked;
        public event Action OnLuggageListClicked;
        public event Action OnAddCustomerClicked;

        public AppLayoutControl()
        {
            InitializeComponent();
        }

        public void LoadContent(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OnDashboardClicked?.Invoke();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            OnCheckinClicked?.Invoke();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            OnCheckoutClicked?.Invoke();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OnLuggageListClicked?.Invoke();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OnAddCustomerClicked?.Invoke();
        }
    }
}
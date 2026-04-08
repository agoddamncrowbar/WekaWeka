using WekaWeka.UserControls;

namespace WekaWeka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }
        private void ShowDashboard()
        {
            var dashboard = new UserControls.Dashboard();

            dashboard.OnCheckinClicked += () =>
            {
                ShowCheckin();
            };

            dashboard.OnCheckoutClicked += () =>
            {
                ShowCheckoutSearch();
            };

            dashboard.OnLuggageListClicked += () =>
            {
                LoadControl(new UserControls.LuggageListControl());
            };
            dashboard.OnAddCustomerClicked += () =>
            {
                LoadControl(new UserControls.AddCustomerControl());
            };

            LoadControl(dashboard);
        }
        private void ShowCheckin()
        {
            var checkin = new CheckinControl();

            checkin.OnNavigate += (control) =>
            {
                LoadControl(control);
            };

            LoadControl(checkin);
        }
        private void ShowCheckoutSearch()
        {
            var control = new CustomerCheckoutSearchControl();

            control.OnProceedToCheckout += (selectedLuggage, customer) =>
            {
                LoadControl(new CheckoutControl(selectedLuggage, customer));
            };

            LoadControl(control);
        }
    }
}

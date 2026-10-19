using WekaWeka.Data;
using WekaWeka.UserControls;

namespace WekaWeka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private AppLayoutControl _layout;
        
        private void LoadWithSidebar(UserControl control)
        {
            if (_layout == null)
            {
                _layout = new AppLayoutControl();

                _layout.OnDashboardClicked += ShowDashboard;
                _layout.OnCheckinClicked += ShowCheckin;
                _layout.OnCheckoutClicked += ShowCheckoutSearch;
                _layout.OnLuggageListClicked += () =>
                    _layout.LoadContent(new LuggageListControl());
                _layout.OnAddCustomerClicked += () =>
                    _layout.LoadContent(new AddCustomerControl());

                mainPanel.Controls.Clear();
                _layout.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(_layout);
            }

            _layout.LoadContent(control);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }
        private void ShowDashboard()
        {
            _layout = null; // reset layout

            var dashboard = new Dashboard();

            dashboard.OnCheckinClicked += ShowCheckin;
            dashboard.OnCheckoutClicked += ShowCheckoutSearch;
            dashboard.OnLuggageListClicked += () =>
                LoadWithSidebar(new LuggageListControl());
            dashboard.OnAddCustomerClicked += () =>
                LoadWithSidebar(new AddCustomerControl());

            mainPanel.Controls.Clear();
            dashboard.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashboard);
        }
        private void ShowCheckin()
        {
            var checkin = new CheckinControl();

            checkin.OnNavigate += (control) =>
            {
                LoadWithSidebar(control);
            };

            LoadWithSidebar(checkin);
        }
        private void ShowCheckoutSearch()
        {
            var control = new CustomerCheckoutSearchControl();

            control.OnProceedToCheckout += (selectedLuggage, customer) =>
            {
                LoadWithSidebar(new CheckoutControl(selectedLuggage, customer));
            };

            LoadWithSidebar(control);
        }
    }
}

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
                LoadControl(new UserControls.CheckinControl());
            };

            dashboard.OnCheckoutClicked += () =>
            {
                LoadControl(new UserControls.CheckoutControl());
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
    }
}

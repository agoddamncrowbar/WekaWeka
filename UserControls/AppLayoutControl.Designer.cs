namespace WekaWeka.UserControls
{
    partial class AppLayoutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            button5 = new Button();
            btnDashboard = new Button();
            btnAddCustomer = new Button();
            btnCheckout = new Button();
            btnCheckin = new Button();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ActiveCaptionText;
            pnlSidebar.Controls.Add(button5);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnAddCustomer);
            pnlSidebar.Controls.Add(btnCheckout);
            pnlSidebar.Controls.Add(btnCheckin);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 650);
            pnlSidebar.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.Silver;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Desktop;
            button5.Location = new Point(0, 274);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(200, 48);
            button5.TabIndex = 0;
            button5.Text = "Transfers";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnTransfer_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.Black;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.Desktop;
            btnDashboard.Location = new Point(0, 82);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5, 0, 0, 0);
            btnDashboard.Size = new Size(200, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatAppearance.BorderColor = Color.Black;
            btnAddCustomer.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAddCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAddCustomer.FlatStyle = FlatStyle.Popup;
            btnAddCustomer.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.Desktop;
            btnAddCustomer.Location = new Point(0, 226);
            btnAddCustomer.Margin = new Padding(0);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Padding = new Padding(5, 0, 0, 0);
            btnAddCustomer.Size = new Size(200, 48);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.White;
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderColor = Color.Black;
            btnCheckout.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCheckout.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = SystemColors.Desktop;
            btnCheckout.Location = new Point(0, 178);
            btnCheckout.Margin = new Padding(0);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Padding = new Padding(5, 0, 0, 0);
            btnCheckout.Size = new Size(200, 48);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCheckin
            // 
            btnCheckin.BackColor = Color.White;
            btnCheckin.Cursor = Cursors.Hand;
            btnCheckin.FlatAppearance.BorderColor = Color.Black;
            btnCheckin.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCheckin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCheckin.FlatStyle = FlatStyle.Popup;
            btnCheckin.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckin.ForeColor = SystemColors.Desktop;
            btnCheckin.Location = new Point(0, 130);
            btnCheckin.Margin = new Padding(0);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Padding = new Padding(5, 0, 0, 0);
            btnCheckin.Size = new Size(200, 48);
            btnCheckin.TabIndex = 0;
            btnCheckin.Text = "Checkin";
            btnCheckin.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckin.UseVisualStyleBackColor = false;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.Info;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(750, 650);
            pnlContent.TabIndex = 1;
            // 
            // AppLayoutControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Name = "AppLayoutControl";
            Size = new Size(950, 650);
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnCheckin;
        private Panel pnlContent;
        private Button btnDashboard;
        private Button btnAddCustomer;
        private Button btnCheckout;
        private Button button5;
    }
}

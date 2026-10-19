namespace WekaWeka.UserControls
{
    partial class Dashboard
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
            btnLogout = new Button();
            btnCheckout = new Button();
            btnLuggageList = new Button();
            btnAddCustomer = new Button();
            panel1 = new Panel();
            lblWelcome = new Label();
            btnCheckin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.Black;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Wheat;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(726, 29);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(194, 56);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.ButtonHighlight;
            btnCheckout.FlatAppearance.BorderColor = Color.Black;
            btnCheckout.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btnCheckout.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            btnCheckout.Location = new Point(133, 274);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(194, 56);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnLuggageList
            // 
            btnLuggageList.BackColor = SystemColors.ButtonHighlight;
            btnLuggageList.FlatAppearance.BorderColor = Color.Black;
            btnLuggageList.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btnLuggageList.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnLuggageList.FlatStyle = FlatStyle.Flat;
            btnLuggageList.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            btnLuggageList.Location = new Point(595, 171);
            btnLuggageList.Name = "btnLuggageList";
            btnLuggageList.Size = new Size(194, 56);
            btnLuggageList.TabIndex = 0;
            btnLuggageList.Text = "Transfers";
            btnLuggageList.UseVisualStyleBackColor = false;
            btnLuggageList.Click += btnCheckin_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ButtonHighlight;
            btnAddCustomer.FlatAppearance.BorderColor = Color.Black;
            btnAddCustomer.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btnAddCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(595, 274);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(194, 56);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 100);
            panel1.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Wheat;
            lblWelcome.Location = new Point(133, 39);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(237, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back, ";
            // 
            // btnCheckin
            // 
            btnCheckin.BackColor = SystemColors.ButtonHighlight;
            btnCheckin.FlatAppearance.BorderColor = Color.Black;
            btnCheckin.FlatAppearance.MouseDownBackColor = Color.SaddleBrown;
            btnCheckin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCheckin.FlatStyle = FlatStyle.Flat;
            btnCheckin.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            btnCheckin.Location = new Point(133, 171);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Size = new Size(194, 56);
            btnCheckin.TabIndex = 0;
            btnCheckin.Text = "Checkin";
            btnCheckin.UseVisualStyleBackColor = false;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(panel1);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnLuggageList);
            Controls.Add(btnCheckin);
            Controls.Add(btnCheckout);
            Name = "Dashboard";
            Size = new Size(934, 478);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnCheckout;
        private Button btnLuggageList;
        private Button btnAddCustomer;
        private Panel panel1;
        private Label lblWelcome;
        private Button btnCheckin;
    }
}

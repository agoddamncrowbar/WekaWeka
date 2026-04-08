namespace WekaWeka.UserControls
{
    partial class CustomerCheckoutSearchControl
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvCustomers = new DataGridView();
            dgvLuggage = new DataGridView();
            lblStatus = new Label();
            btnProceed = new Button();
            chkSelectAll = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLuggage).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(669, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(453, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 28);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 2;
            label1.Text = "Search Name, Phone or ID";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(60, 118);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(703, 188);
            dgvCustomers.TabIndex = 3;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // dgvLuggage
            // 
            dgvLuggage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLuggage.Location = new Point(60, 360);
            dgvLuggage.Name = "dgvLuggage";
            dgvLuggage.RowHeadersWidth = 51;
            dgvLuggage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuggage.Size = new Size(703, 188);
            dgvLuggage.TabIndex = 3;
            dgvLuggage.CellValueChanged += dgvLuggage_CellValueChanged;
            dgvLuggage.CurrentCellDirtyStateChanged += dgvLuggage_CurrentCellDirtyStateChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(60, 323);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(189, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Select luggage to checkout";
            // 
            // btnProceed
            // 
            btnProceed.Enabled = false;
            btnProceed.Location = new Point(669, 572);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(94, 29);
            btnProceed.TabIndex = 0;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.Location = new Point(662, 323);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(93, 24);
            chkSelectAll.TabIndex = 4;
            chkSelectAll.Text = "Select All";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            // 
            // CustomerCheckoutSearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkSelectAll);
            Controls.Add(dgvLuggage);
            Controls.Add(dgvCustomers);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnProceed);
            Controls.Add(btnSearch);
            Name = "CustomerCheckoutSearchControl";
            Size = new Size(810, 630);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLuggage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvCustomers;
        private DataGridView dgvLuggage;
        private Label lblStatus;
        private Button btnProceed;
        private CheckBox chkSelectAll;
    }
}

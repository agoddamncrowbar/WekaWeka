namespace WekaWeka.UserControls
{
    partial class CustomerSearchControl
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
            txtSearch = new TextBox();
            dataGridCustomers = new DataGridView();
            btnSearch = new Button();
            btnAdd = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(48, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(527, 27);
            txtSearch.TabIndex = 0;
            // 
            // dataGridCustomers
            // 
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Location = new Point(48, 98);
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.RowHeadersWidth = 51;
            dataGridCustomers.Size = new Size(629, 256);
            dataGridCustomers.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(600, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 374);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(600, 374);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(77, 29);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // CustomerSearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSelect);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(dataGridCustomers);
            Controls.Add(txtSearch);
            Name = "CustomerSearchControl";
            Size = new Size(729, 460);
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dataGridCustomers;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnSelect;
    }
}

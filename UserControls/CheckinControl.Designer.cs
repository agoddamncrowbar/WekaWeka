namespace WekaWeka.UserControls
{
    partial class CheckinControl
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
            txtDescription = new TextBox();
            txtWeight = new TextBox();
            txtOrigin = new TextBox();
            txtDestination = new TextBox();
            lblCustomerName = new Label();
            lblCustomerPhone = new Label();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            lblStatus = new Label();
            chkFragile = new CheckBox();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(22, 85);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 0;
            txtDescription.Text = "Description";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(174, 85);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 0;
            txtWeight.Text = "Weight";
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(22, 139);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(125, 27);
            txtOrigin.TabIndex = 0;
            txtOrigin.Text = "Origin";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(327, 85);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(125, 27);
            txtDestination.TabIndex = 0;
            txtDestination.Text = "Current Location";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(153, 23);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(49, 20);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Name";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Location = new Point(153, 43);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(50, 20);
            lblCustomerPhone.TabIndex = 1;
            lblCustomerPhone.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(327, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Checkin Luggage";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(339, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // chkFragile
            // 
            chkFragile.AutoSize = true;
            chkFragile.Location = new Point(174, 144);
            chkFragile.Name = "chkFragile";
            chkFragile.Size = new Size(76, 24);
            chkFragile.TabIndex = 5;
            chkFragile.Text = "Fragile";
            chkFragile.UseVisualStyleBackColor = true;
            // 
            // CheckinControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkFragile);
            Controls.Add(btnSave);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(lblCustomerPhone);
            Controls.Add(label1);
            Controls.Add(lblCustomerName);
            Controls.Add(txtDestination);
            Controls.Add(txtOrigin);
            Controls.Add(txtWeight);
            Controls.Add(txtDescription);
            Name = "CheckinControl";
            Size = new Size(832, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtWeight;
        private TextBox txtOrigin;
        private TextBox txtDestination;
        private Label lblCustomerName;
        private Label lblCustomerPhone;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Label lblStatus;
        private CheckBox chkFragile;
    }
}

namespace WekaWeka.UserControls
{
    partial class AddCustomerControl
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
            btnSave = new Button();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtIdNumber = new TextBox();
            lblStatus = new Label();
            label1 = new Label();
            cmbIdType = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(332, 257);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add Customer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 27);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(232, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(267, 27);
            txtPhone.TabIndex = 1;
            txtPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Email";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(232, 208);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(267, 27);
            txtIdNumber.TabIndex = 1;
            txtIdNumber.Text = "ID Number";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(450, 295);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 50);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Add Customer";
            // 
            // cmbIdType
            // 
            cmbIdType.FormattingEnabled = true;
            cmbIdType.Location = new Point(232, 175);
            cmbIdType.Name = "cmbIdType";
            cmbIdType.Size = new Size(267, 28);
            cmbIdType.TabIndex = 4;
            // 
            // AddCustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbIdType);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(txtIdNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Name = "AddCustomerControl";
            Size = new Size(843, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtIdNumber;
        private Label lblStatus;
        private Label label1;
        private ComboBox cmbIdType;
    }
}

namespace WekaWeka.UserControls
{
    partial class CheckoutControl
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
            label1 = new Label();
            txtCollectorName = new TextBox();
            dgvSelectedLuggage = new DataGridView();
            chkSelf = new CheckBox();
            txtCollectorPhone = new TextBox();
            txtCollectorId = new TextBox();
            txtRelationship = new TextBox();
            txtRemarks = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedLuggage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 41);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // txtCollectorName
            // 
            txtCollectorName.Location = new Point(302, 289);
            txtCollectorName.Name = "txtCollectorName";
            txtCollectorName.Size = new Size(235, 27);
            txtCollectorName.TabIndex = 1;
            // 
            // dgvSelectedLuggage
            // 
            dgvSelectedLuggage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedLuggage.Location = new Point(46, 76);
            dgvSelectedLuggage.Name = "dgvSelectedLuggage";
            dgvSelectedLuggage.RowHeadersWidth = 51;
            dgvSelectedLuggage.Size = new Size(673, 188);
            dgvSelectedLuggage.TabIndex = 2;
            // 
            // chkSelf
            // 
            chkSelf.AutoSize = true;
            chkSelf.Location = new Point(598, 41);
            chkSelf.Name = "chkSelf";
            chkSelf.Size = new Size(121, 24);
            chkSelf.TabIndex = 0;
            chkSelf.Text = "Self Checkout";
            chkSelf.UseVisualStyleBackColor = true;
            chkSelf.Click += chkSelf_CheckedChanged;
            // 
            // txtCollectorPhone
            // 
            txtCollectorPhone.Location = new Point(302, 322);
            txtCollectorPhone.Name = "txtCollectorPhone";
            txtCollectorPhone.Size = new Size(235, 27);
            txtCollectorPhone.TabIndex = 2;
            // 
            // txtCollectorId
            // 
            txtCollectorId.Location = new Point(302, 355);
            txtCollectorId.Name = "txtCollectorId";
            txtCollectorId.Size = new Size(235, 27);
            txtCollectorId.TabIndex = 3;
            // 
            // txtRelationship
            // 
            txtRelationship.Location = new Point(302, 388);
            txtRelationship.Name = "txtRelationship";
            txtRelationship.Size = new Size(235, 27);
            txtRelationship.TabIndex = 4;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(46, 452);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(491, 104);
            txtRemarks.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 292);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Collector Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 325);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 5;
            label3.Text = "Collector Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 358);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 5;
            label4.Text = "Collector ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 391);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 5;
            label5.Text = "Relationship";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 429);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Remarks";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(569, 292);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(150, 41);
            btnCheckout.TabIndex = 6;
            btnCheckout.Text = "Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // CheckoutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheckout);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRemarks);
            Controls.Add(chkSelf);
            Controls.Add(dgvSelectedLuggage);
            Controls.Add(txtRelationship);
            Controls.Add(txtCollectorId);
            Controls.Add(txtCollectorPhone);
            Controls.Add(txtCollectorName);
            Controls.Add(label1);
            Name = "CheckoutControl";
            Size = new Size(762, 585);
            Load += CheckoutControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelectedLuggage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCollectorName;
        private DataGridView dgvSelectedLuggage;
        private CheckBox chkSelf;
        private TextBox txtCollectorPhone;
        private TextBox txtCollectorId;
        private TextBox txtRelationship;
        private TextBox txtRemarks;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCheckout;
    }
}

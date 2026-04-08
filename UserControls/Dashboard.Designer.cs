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
            btnCheckin = new Button();
            btnCheckout = new Button();
            btnLuggageList = new Button();
            btnAddCustomer = new Button();
            SuspendLayout();
            // 
            // btnCheckin
            // 
            btnCheckin.Location = new Point(181, 124);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Size = new Size(121, 29);
            btnCheckin.TabIndex = 0;
            btnCheckin.Text = "Checkin";
            btnCheckin.UseVisualStyleBackColor = true;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(181, 159);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(121, 29);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnLuggageList
            // 
            btnLuggageList.Location = new Point(181, 194);
            btnLuggageList.Name = "btnLuggageList";
            btnLuggageList.Size = new Size(121, 29);
            btnLuggageList.TabIndex = 0;
            btnLuggageList.Text = "Luggage List";
            btnLuggageList.UseVisualStyleBackColor = true;
            btnLuggageList.Click += btnCheckin_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(181, 229);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(121, 29);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddCustomer);
            Controls.Add(btnLuggageList);
            Controls.Add(btnCheckout);
            Controls.Add(btnCheckin);
            Name = "Dashboard";
            Size = new Size(934, 478);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckin;
        private Button btnCheckout;
        private Button btnLuggageList;
        private Button btnAddCustomer;
    }
}

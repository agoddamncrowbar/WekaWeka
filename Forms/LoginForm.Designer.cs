namespace WekaWeka
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUname = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            lblStatusTxt = new Label();
            SuspendLayout();
            // 
            // txtUname
            // 
            txtUname.Location = new Point(9, 187);
            txtUname.Margin = new Padding(0);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(288, 27);
            txtUname.TabIndex = 0;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(9, 229);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(288, 27);
            txtPwd.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(9, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(288, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 103);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // lblStatusTxt
            // 
            lblStatusTxt.Location = new Point(12, 153);
            lblStatusTxt.Name = "lblStatusTxt";
            lblStatusTxt.Size = new Size(284, 25);
            lblStatusTxt.TabIndex = 3;
            lblStatusTxt.Text = "Enter username and password";
            lblStatusTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 357);
            Controls.Add(lblStatusTxt);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtUname);
            Name = "LoginForm";
            Text = "WekaWeka-Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUname;
        private TextBox txtPwd;
        private Button btnLogin;
        private Label label1;
        private Label lblStatusTxt;
    }
}
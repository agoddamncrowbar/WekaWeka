using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WekaWeka.Repositories;
using WekaWeka.Utils;

namespace WekaWeka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUname.Text.Trim();
            var password = txtPwd.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatusTxt.Text = "Enter username and password";
                return;
            }

            var repo = new UserRepository();
            var user = repo.GetByUsername(username);

            if (user == null)
            {
                lblStatusTxt.Text = "User not found";
                return;
            }
            MessageBox.Show($"IsActive value: {user.Is_active}");

            if (user.Is_active != 1)
            {
                lblStatusTxt.Text = "User is inactive";
                return;
            }

            var hashed = PasswordHelper.Hash(password);

            if (user.password_hash != hashed)
            {
                lblStatusTxt.Text = "Invalid password";
                return;
            }

            // SUCCESS
            SessionManager.StartSession(user);


            // open main form
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            lblStatusTxt.ForeColor = Color.Green;
            lblStatusTxt.Text = "Login successful";

            // TODO: store session + open main form
        }
    }
}

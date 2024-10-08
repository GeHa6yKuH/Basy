using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class Login : BaseBasyForm
    {

        public Login()
        {
            InitializeComponent();

            Utils.EnsureTableExists(Queries.CreateUsersTable);
            FormClosing += Login_FormClosing;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblNewAccount_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }

        private void lblPasswordReset_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredPassword = tbPassword.Text;
                string username = tbUsername.Text.Trim();

                if (string.IsNullOrEmpty(enteredPassword) && string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter valid credentials!");
                }
                else
                {
                    if (Utils.ValidateUserCredentials(username, enteredPassword))
                    {
                        Maineditorwindow maineditorwindow = new Maineditorwindow();
                        maineditorwindow.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password are incorrect!");
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

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
    public partial class RegisterUser : Form
    {

        public RegisterUser()
        {
            InitializeComponent();

            Utils.EnsureTableExists(Queries.CreateUsersTable);
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utils.CreateUserIfNotExist(tbUsername.Text, tbPassword.Text, tbEmail.Text))
                {
                    MessageBox.Show("User " + tbUsername.Text + " successfuly created!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

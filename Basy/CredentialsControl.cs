using Basy.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class CredentialsControl : UserControl
    {
        private BindingList<CredentialUnit> credentials = new BindingList<CredentialUnit>();

        public CredentialsControl()
        {
            InitializeComponent();
        }

        public void PopulateGrid()
        {

            try
            {
                credentials.Clear();
                //dGVTemplates.Invalidate();

                Utils.EnsureTablesExist();

                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    string query = @"
                        SELECT c.id, c.name, c.login, u.username
                        FROM credentials c
                        JOIN users u ON c.user_id = u.id";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                credentials.Add(new CredentialUnit
                                {
                                    Id = int.Parse(reader["id"].ToString()),
                                    Name = reader["name"].ToString(),
                                    Login = reader["text"].ToString(),
                                    Username = reader["username"].ToString()
                                });
                            }
                        }
                    }
                }

                dGVCredentials.DataSource = credentials;
                dGVCredentials.Refresh();

                dGVCredentials.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CredentialsControl_Load(object sender, EventArgs e)
        {
            Utils.EnsureTableExists(Queries.CreateUsersTable);
            PopulateGrid();
        }
    }
}

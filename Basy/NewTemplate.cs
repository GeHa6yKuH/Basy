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
    public partial class NewTemplate : Form
    {
        private TemplatesControl _templatesControl;

        public NewTemplate()
        {
            InitializeComponent();
            Utils.EnsureTablesExist();
        }

        public NewTemplate(TemplatesControl templatesControl)
        {
            InitializeComponent();
            Utils.EnsureTablesExist();
            _templatesControl = templatesControl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbText.Text))
                {
                    MessageBox.Show("Please fill template fields!");
                    return;
                }
                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO templates (name, text, user_id, created_at) 
                    VALUES (@name, @text, 1, @created_at)";

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@created_at", DateTime.Now);
                        command.Parameters.AddWithValue("@name", tbName.Text);
                        command.Parameters.AddWithValue("@text", tbText.Text);
                        command.ExecuteNonQuery();
                    }
                }
                if (_templatesControl != null)
                {
                    _templatesControl.PopulateGrid();
                }
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void NewTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}

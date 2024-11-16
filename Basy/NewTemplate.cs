using MaterialSkin.Controls;
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
            _templatesControl = templatesControl;
        }

        private int AddTemplateAndInitialVersion(SqliteConnection connection)
        {
            int newInitialVersionId = -1;

            string insertQuery = @"
                    INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id) 
                    VALUES (@name, @text, @created_at, 0, NULL);
                    SELECT last_insert_rowid();";

            long newTemplateId;
            using (var command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@created_at", DateTime.Now);
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@text", tbText.Text);
                newTemplateId = (long)command.ExecuteScalar();
            }

            string insertInitialVersionQuery = @"
                    INSERT INTO versions (template_id, name, text, has_parameters)
                    VALUES (@template_id, @name, @text, 0);
                    SELECT last_insert_rowid();";

            long NewLongVersionId;
            using (var command = new SqliteCommand(insertInitialVersionQuery, connection))
            {
                command.Parameters.AddWithValue("@template_id", newTemplateId);
                command.Parameters.AddWithValue("@name", "Initial");
                command.Parameters.AddWithValue("@text", tbText.Text);
                NewLongVersionId = (long)command.ExecuteScalar();
                newInitialVersionId = (int)NewLongVersionId;
            }

            string updateNewTemplate = @"
                    UPDATE templates
                        SET initial_version_id = @new_ver_id
                        WHERE id = @new_temp_id;";

            using (var command = new SqliteCommand(updateNewTemplate, connection))
            {
                command.Parameters.AddWithValue("@new_ver_id", newInitialVersionId);
                command.Parameters.AddWithValue("@new_temp_id", newTemplateId);
                command.ExecuteNonQuery();
            }

            return newInitialVersionId >= 0 ? newInitialVersionId : -1;
        }

        private void NewTemplate_Load(object sender, EventArgs e)
        {

        }

        private void mtbAdd_Click(object sender, EventArgs e)
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

                    int newTemplateInitialVersionId = AddTemplateAndInitialVersion(connection);

                    List<string> parametersNames = Utils.GetAllParametersNamesFromTextBox(tbText.Text);

                    if (parametersNames.Count >= 1)
                    {
                        Utils.AddParametersByVersionId(newTemplateInitialVersionId, parametersNames, true);
                    }
                }
                if (_templatesControl != null)
                {
                    _templatesControl.PopulateGrid();
                }
                Utils.LogToHistory("Create", $"template {tbName.Text} created!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

 using Basy.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class NewVersion : Form
    {
        private Template _templateToCreateVersion;
        private VersionsEditor _versionsEditor;
        private List<string> _ParametersNames;

        public NewVersion(Template template,VersionsEditor versionsEditor)
        {
            InitializeComponent();
            _templateToCreateVersion = template;
            _versionsEditor = versionsEditor;
        }

        private int AddVersionAndUpdateTemplate(SqliteConnection connection)
        {
            int newVersionId = -1;
            string insertQuery = @"
                     INSERT INTO versions (template_id, name, text, has_parameters)
                     VALUES (@template_id, @name, @text, 0);
                     SELECT last_insert_rowid();";

            string updateHasVersionsTemplateQuery = @"
                     UPDATE templates
                     SET has_more_versions = 1
                     WHERE id = @id";

            if (_templateToCreateVersion != null)
            {
                long newLongId;
                using (var command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", tbName.Text);
                    command.Parameters.AddWithValue("@text", tbText.Text);
                    command.Parameters.AddWithValue("@template_id", _templateToCreateVersion.Id);
                    newLongId = (long)command.ExecuteScalar();
                    newVersionId = (int)newLongId;
                }

                using (var command = new SqliteCommand(updateHasVersionsTemplateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", _templateToCreateVersion.Id);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Error occured!");
                Close();
            }
            return newVersionId >= 0 ? newVersionId : -1;
        }

        private void mtbAddtag_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbText.Text))
                {
                    MessageBox.Show("Please fill version fields!");
                    return;
                }
                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    int newVersionId = AddVersionAndUpdateTemplate(connection);

                    List<string> parametersNames = Utils.GetAllParametersNamesFromTextBox(tbText.Text);

                    if (parametersNames.Count >= 1)
                    {
                        Utils.AddParametersByVersionId(newVersionId, parametersNames, true);
                    }
                }
                if (_versionsEditor != null)
                {
                    _versionsEditor.PopulateListWithVersions();
                }
                Utils.LogToHistory(Operations.Create, $"Version {tbName.Text} has been created");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }
    }
}

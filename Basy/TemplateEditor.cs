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
    public partial class TemplateEditor : Form
    {
        Template _toModifyTemplate;
        TemplatesControl _templatesControl;

        public TemplateEditor(Template template, TemplatesControl templatesControl)
        {
            InitializeComponent();
            _toModifyTemplate = template;
            _templatesControl = templatesControl;
            this.FormClosing += UpdateTemplatesControl;
        }

        private void UpdateTemplatesControl(object sender, FormClosingEventArgs e)
        {
            _templatesControl.PopulateGrid();
            _templatesControl.SelectIndexInSortGrid(2);
        }

        private void TemplateEditor_Load(object sender, EventArgs e)
        {
            tbName.Text = _toModifyTemplate.Name;
            tbText.Text = _toModifyTemplate.Text;
        }

        private void btnEditVersions_Click(object sender, EventArgs e)
        {
            VersionsEditor versionsEditor = new VersionsEditor(_toModifyTemplate);
            versionsEditor.Show();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            TagsEditor tagsEditor = new TagsEditor(_toModifyTemplate);
            tagsEditor.Show();
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            List<Parameter> parameters = Utils.GetAllParametersByVersionId(_toModifyTemplate.InitialVersionId);

            ParameterList parameterList = new ParameterList(parameters);
            parameterList.Show();
        }

        private void UpdateParameters()
        {
            List<Parameter> currentParameters = Utils.GetAllParametersByVersionId(_toModifyTemplate.InitialVersionId);

            if (currentParameters.Count > 0)
            {
                List<string> currentParametersNames = currentParameters.Select(par => par.Name).ToList();

                List<string> allParametersNamesFromTextBox = Utils.GetAllParametersNamesFromTextBox(tbText.Text);

                List<string> newParametersNames = allParametersNamesFromTextBox
                        .Where(p => !currentParametersNames.Contains(p))
                        .ToList();

                List<string> parametersToDeleteNames = currentParametersNames
                        .Where(p => !allParametersNamesFromTextBox.Contains(p))
                        .ToList();

                int totalParametersAfterModification = (currentParametersNames.Count + newParametersNames.Count) - parametersToDeleteNames.Count;
                bool versionHasParametersAfterUpdate = totalParametersAfterModification > 0;

                Utils.AddParametersByVersionId(_toModifyTemplate.InitialVersionId, newParametersNames, false);
                Utils.RemoveParametersByVersionId(_toModifyTemplate.InitialVersionId, parametersToDeleteNames, !versionHasParametersAfterUpdate);
            }
            else
            {
                List<string> allParametersNamesFromTextBox = Utils.GetAllParametersNamesFromTextBox(tbText.Text);

                Utils.AddParametersByVersionId(_toModifyTemplate.InitialVersionId, allParametersNamesFromTextBox, true);
            }
        }

        private void UpdateTemplateAndVersion(SqliteConnection connection)
        {
            string modifyQuery = @"
                        UPDATE templates
                        SET name = @name, text = @text
                        WHERE id = @id;
                    ";


            using (var command = new SqliteCommand(modifyQuery, connection))
            {
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@text", tbText.Text);
                command.Parameters.AddWithValue("@id", _toModifyTemplate.Id);
                command.ExecuteNonQuery();
            }

            if (_toModifyTemplate.InitialVersionId != -1)
            {
                string updateInitialTemplateQuery = @"
                        UPDATE versions
                        SET text = @text
                        WHERE id = @id;
                    ";

                using (var command = new SqliteCommand(updateInitialTemplateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", _toModifyTemplate.InitialVersionId);
                    command.Parameters.AddWithValue("@text", tbText.Text);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void mtbModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbText.Text))
            {
                MessageBox.Show("Template fields can not be empty!");
                return;
            }
            if (tbName.Text != _toModifyTemplate.Name || tbText.Text != _toModifyTemplate.Text)
            {
                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    bool nameModified = tbName.Text != _toModifyTemplate.Name;
                    string toLog = nameModified ?
                        $"Name of template {_toModifyTemplate.Name} has been changed to {tbName.Text}" :
                        $"Text of template {_toModifyTemplate.Name} has been changed from {_toModifyTemplate.Text} to {tbText.Text}";

                    UpdateTemplateAndVersion(connection);

                    UpdateParameters();

                    Utils.LogToHistory(Operations.Modify, toLog);
                }
            }
            if (_templatesControl != null)
            {
                _templatesControl.PopulateGrid();
                _templatesControl.SelectIndexInSortGrid(2);
            }
            Close();
        }

        private void mtbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_toModifyTemplate != null)
                {
                    DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {_toModifyTemplate.Name} Template?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (userConfirms == DialogResult.Yes)
                    {
                        Utils.deleteTemplateById(_toModifyTemplate.Id);
                        Utils.LogToHistory(Operations.Delete, $"Template {_toModifyTemplate.Name}" +
                            $" with text {_toModifyTemplate.Text} has been deleted!");
                        _templatesControl.PopulateGrid();
                        _templatesControl.SelectIndexInSortGrid(2);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

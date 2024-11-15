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
    public partial class VersionEditor : Form
    {
        TVersion _versionToModify;
        VersionsEditor _versionsEditor;
        int _templateId;

        public VersionEditor(TVersion versionToModify, VersionsEditor versionsEditor, int templateId)
        {
            InitializeComponent();
            _versionToModify = versionToModify;
            _versionsEditor = versionsEditor;
            _templateId = templateId;
        }

        private void VersionEditor_Load(object sender, EventArgs e)
        {
            tbText.Text = _versionToModify.Text;
            tbName.Text = _versionToModify.Name;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbText.Text))
                {
                    MessageBox.Show("Version fields can not be empty!");
                    return;
                }
                if (tbName.Text != _versionToModify.Name || tbText.Text != _versionToModify.Text)
                {
                    using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                    {
                        connection.Open();

                        bool nameModified = tbName.Text != _versionToModify.Name;
                        string toLog = nameModified ?
                            $"Name of version {_versionToModify.Name} has been changed to {tbName.Text}" :
                            $"Text of version {_versionToModify.Name} has been changed from {_versionToModify.Text} to {tbText.Text}";

                        UpdateVersion(connection);

                        UpdateParameters();

                        Utils.LogToHistory(Operations.Modify, toLog);
                    }
                    if (_versionsEditor != null)
                    {
                        _versionsEditor.PopulateListWithVersions();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Please enter valid values!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void UpdateParameters()
        {
            List<Parameter> currentParameters = Utils.GetAllParametersByVersionId(_versionToModify.Id);

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

                Utils.AddParametersByVersionId(_versionToModify.Id, newParametersNames, false);
                Utils.RemoveParametersByVersionId(_versionToModify.Id, parametersToDeleteNames, !versionHasParametersAfterUpdate);
            }
            else
            {
                List<string> allParametersNamesFromTextBox = Utils.GetAllParametersNamesFromTextBox(tbText.Text);

                Utils.AddParametersByVersionId(_versionToModify.Id, allParametersNamesFromTextBox, true);
            }
        }

        private void UpdateVersion(SqliteConnection connection)
        {
            string modifyQuery = @"
                        UPDATE versions
                        SET name = @name, text = @text
                        WHERE id = @id;";

            using (var command = new SqliteCommand(modifyQuery, connection))
            {
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@text", tbText.Text);
                command.Parameters.AddWithValue("@id", _versionToModify.Id);
                command.ExecuteNonQuery();
            }

            if (Utils.IsVersionInitialById(_versionToModify.Id))
            {
                string templateUpdateQuery = @"
                            UPDATE templates
                            SET text = @text
                            WHERE id = @id;";

                using (var command = new SqliteCommand(templateUpdateQuery, connection))
                {
                    command.Parameters.AddWithValue("@text", tbText.Text);
                    command.Parameters.AddWithValue("@id", _templateId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            List<Parameter> parameters = Utils.GetAllParametersByVersionId(_versionToModify.Id);

            ParameterList parameterList = new ParameterList(parameters);
            parameterList.Show();
        }
    }
}

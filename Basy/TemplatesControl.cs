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
    public partial class TemplatesControl : UserControl
    {

        private BindingList<Template> templates = new BindingList<Template>();

        public TemplatesControl()
        {
            InitializeComponent();
        }

        private void DGVTemplates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dGVTemplates.Rows[e.RowIndex];

                if (templates.Count != 0)
                {
                    Template templateToModify = templates.FirstOrDefault(t => t.Name == selectedRow.Cells["Name"].Value.ToString());
                    if (templateToModify != null)
                    {
                        TemplateEditor templateEditor = new TemplateEditor(templateToModify, this);
                        templateEditor.Show();
                    }
                }
            }
        }

        public void PopulateGrid()
        {

            try
            {
                templates.Clear();
                //dGVTemplates.Invalidate();

                Utils.EnsureTablesExist();

                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    string query = @"
                        SELECT t.id, t.name, t.text, u.username
                        FROM templates t
                        JOIN users u ON t.user_id = u.id";

                    using (var command = new SqliteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                templates.Add(new Template
                                {
                                    Id = int.Parse(reader["id"].ToString()),
                                    Name = reader["name"].ToString(),
                                    Text = reader["text"].ToString(),
                                    Username = reader["username"].ToString()
                                });
                            }
                        }
                    }
                }

                dGVTemplates.DataSource = templates;
                dGVTemplates.Refresh();

                dGVTemplates.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            NewTemplate newTemplate = new NewTemplate(this);
            newTemplate.Show();
        }

        private void TemplatesControl_Load(object sender, EventArgs e)
        {
            Utils.EnsureTableExists(Queries.CreateUsersTable);
            PopulateGrid();

            dGVTemplates.CellDoubleClick += DGVTemplates_CellDoubleClick;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVTemplates.SelectedRows[0].Cells["id"].Value;

                Template templateToDelete = Utils.findTemplateById(id);

                if (templateToDelete != null)
                {
                    DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {templateToDelete.Name} Template?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (userConfirms == DialogResult.Yes)
                    {
                        Utils.deleteTemplateById(id);
                        dGVTemplates.Refresh();
                        PopulateGrid();
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

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
        }

        private void TemplateEditor_Load(object sender, EventArgs e)
        {
            tbName.Text = _toModifyTemplate.Name;
            tbText.Text = _toModifyTemplate.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                // Insert sample templates directly
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
            }
            if (_templatesControl != null)
            {
                _templatesControl.PopulateGrid();
            }
            Close();
        }
    }
}

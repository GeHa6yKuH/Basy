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
    public partial class PopupWindow : Form
    {
        private List<Template> _templates = new List<Template>();

        public PopupWindow()
        {
            InitializeComponent();
            Utils.EnsureTablesExist();
            populateListWithTemplates();
            BringToFront();

            TopMost = true;

            lbTemplates.DoubleClick += (s, e) =>
            {
                if (lbTemplates.SelectedItem != null)
                {
                    PasteTemplateAsync(((Template)lbTemplates.SelectedItem).Text);
                    this.Close();
                }
            };
        }

        private async Task PasteTemplateAsync(string template)
        {
            string originalClipboardText = Clipboard.GetText();

            Clipboard.SetText(template);

            await Task.Delay(100);

            SendKeys.Send("^v");

         }

        private void populateListWithTemplates()
        {
            _templates = getAllTemplates();

            foreach (Template template in _templates) 
            { 
                lbTemplates.Items.Add(template);
            }
        }

        private List<Template> getAllTemplates()
        {
            List<Template> templates = new List<Template>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT t.name, t.text, u.username
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
                                Name = reader["name"].ToString(),
                                Text = reader["text"].ToString(),
                                Username = reader["username"].ToString()
                            });
                        }
                    }
                }
            }

            return templates;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }
    }
}

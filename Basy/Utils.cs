using Basy.Models;
using Microsoft.Data.Sqlite;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Basy
{
    public static class Utils
    {
        public static void EnsureTableExists(string queryToRun)
        {

            string folderPath = Path.GetDirectoryName(RuntimeConstants.BasyDatabaseFilePath);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();  // This will create the database file if it doesn't exist.

                using (var command = new SqliteCommand("PRAGMA foreign_keys = ON;", connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SqliteCommand(queryToRun, connection))
                {
                    command.ExecuteNonQuery();  // This will create the table if it doesn't exist.
                }
            }
        }

        public static void DeleteAllTables()
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string deleteQuery = @"
                    DROP TABLE IF EXISTS logs;
                ";

                /* DROP TABLE IF EXISTS tags;
                 DROP TABLE IF EXISTS template_tags;
                 DROP TABLE IF EXISTS logs;
                 DROP TABLE IF EXISTS users;
                 DROP TABLE IF EXISTS credentials;*/

                using (var command = new SqliteCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EnsureTablesExist()
        {
            if (Properties.Settings.Default.FirstStart)
            {
                EnsureTableExists(Queries.CreateTemplatesTable);

                EnsureTableExists(Queries.CreateTagsTable);

                EnsureTableExists(Queries.CreateTemplatesTagsTable);

                EnsureTableExists(Queries.CreateLogsTable);

                EnsureTableExists(Queries.CreateVersionsTable);

                EnsureTableExists(Queries.CreateParametersTable);

                PopulateSampleTemplates();

                Properties.Settings.Default.FirstStart = false;
                Properties.Settings.Default.Save();
            }
        }

        public static void PopulateSampleTemplates()
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                // Insert sample templates directly, including new fields
                string insertQuery1 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id) 
            VALUES ('Welcome to Basy', 'Hello,\n\nWelcome to Basy!', @created_at, 0, NULL)";

                string insertQuery2 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id)
            VALUES ('Usage', 'Please feel free to explore the wide range of functionlity offered to you by basy app such as managing Templates', @created_at, 0, NULL)";

                string insertQuery3 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id)
            VALUES ('Issues', 'Please share any issues you encounter along the way of using app on HitHub', @created_at, 0, NULL)";

                string insertQuery4 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id)
            VALUES ('Python HW', 'print(''Hello, World!'')', @created_at, 0, NULL)";

                string insertQuery5 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id)
            VALUES ('C++ HW', '#include <iostream>\nint main() {\n    std::cout << ''Hello, World!'' << std::endl;\n    return 0;\n}', @created_at, 0, NULL)";

                string insertQuery6 = @"
            INSERT INTO templates (name, text, created_at, has_more_versions, initial_version_id)
            VALUES ('Powershell HW', 'Write-Output ''Hello, World!''', @created_at, 0, NULL)";

                // Prepare and execute each command
                using (var command1 = new SqliteCommand(insertQuery1, connection))
                {
                    command1.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command1.ExecuteNonQuery();
                }

                using (var command2 = new SqliteCommand(insertQuery2, connection))
                {
                    command2.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command2.ExecuteNonQuery();
                }

                using (var command3 = new SqliteCommand(insertQuery3, connection))
                {
                    command3.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command3.ExecuteNonQuery();
                }

                using (var command4 = new SqliteCommand(insertQuery4, connection))
                {
                    command4.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command4.ExecuteNonQuery();
                }

                using (var command5 = new SqliteCommand(insertQuery5, connection))
                {
                    command5.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command5.ExecuteNonQuery();
                }

                using (var command6 = new SqliteCommand(insertQuery6, connection))
                {
                    command6.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command6.ExecuteNonQuery();
                }
            }
        }

        public static Template findTemplateById(int templateId)
        {
            EnsureTablesExist();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT * 
                FROM templates 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", templateId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Template
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Text = reader["text"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static TVersion findVersionById(int versionId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT * 
                FROM versions 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", versionId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TVersion
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Text = reader["text"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static void deleteTemplateById(int templateId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                DELETE FROM templates 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", templateId);

                    int SomeRowFound = command.ExecuteNonQuery();

                    if (SomeRowFound > 0)
                    {
                        MessageBox.Show("Template deleted succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please try again!");
                    }
                }
            }
        }

        public static void DeleteTemplatesByIdList(List<int> idList)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                DELETE FROM templates 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.Add(new SqliteParameter("@id", DbType.Int32));

                    foreach (int id in idList)
                    {
                        Template templateToDelete = findTemplateById(id);
                        Utils.LogToHistory(Operations.Delete, $"Template {templateToDelete.Name}" +
                            $" with text {templateToDelete.Text} has been deleted!");

                        command.Parameters["@id"].Value = id;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void deleteVersionById(int versionId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                DELETE FROM versions 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", versionId);

                    int SomeRowFound = command.ExecuteNonQuery();

                    if (SomeRowFound > 0)
                    {
                        MessageBox.Show("Version deleted succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please try again!");
                    }
                }
            }
        }

        public static void deleteTagById(int tagId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                DELETE FROM tags 
                WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", tagId);

                    int SomeRowFound = command.ExecuteNonQuery();

                    if (SomeRowFound > 0)
                    {
                        MessageBox.Show("Tag deleted succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please try again!");
                    }
                }
            }
        }

        public static List<TVersion> GetAllVersionsByTemplateId(int templateId)
        {
            List<TVersion> versions = new List<TVersion>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT id, name, text, template_id
                        FROM versions
                        WHERE template_id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", templateId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            versions.Add(new TVersion
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Text = reader["text"].ToString()
                            });
                        }
                    }
                }
            }

            return versions;
        }

        public static List<Tag> GetAllTagsByTemplateId(int templateId)
        {
            List<Tag> tags = new List<Tag>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT t.id, t.name, t.color
                        FROM tags t
                        INNER JOIN template_tags g
                        ON t.id = g.tag_id
                        WHERE g.template_id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", templateId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tags.Add(new Tag
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Color = ColorTranslator.FromHtml(reader["color"].ToString())
                            });
                        }
                    }
                }
            }

            return tags;
        }

        public static List<Tag> GetAllTags()
        {
            List<Tag> tags = new List<Tag>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT id, name, color
                        FROM tags";

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tags.Add(new Tag
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Color = ColorTranslator.FromHtml(reader["color"].ToString())
                            });
                        }
                    }
                }
            }

            return tags;
        }

        public static bool FormIsOpenByName(string formName)
        {
            FormCollection openForms = System.Windows.Forms.Application.OpenForms;

            foreach (Form form in openForms)
            {
                if (form.Name == formName && form != null)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }

                    form.Activate();
                    return true;
                }
            }

            return false;
        }

        public static async Task PasteTextAsync(string template)
        {

            Clipboard.SetText(template);

            await Task.Delay(100);

            SendKeys.Send("^v");
        }

        public static bool TemplateHasMoreVersionsById(int templateId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT has_more_versions
                FROM templates
                WHERE id = @id AND has_more_versions = 1";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", templateId);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool VersionHasParametersById(int versionId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT has_parameters
                FROM versions
                WHERE id = @ver_id AND has_parameters = 1";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ver_id", versionId);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void DrawColorCircleForTags(ListBox lbTags, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Tag tag = (Tag)lbTags.Items[e.Index];

            e.DrawBackground();

            using (Brush colorBrush = new SolidBrush(tag.Color))
            {
                Rectangle colorRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, 20, e.Bounds.Height - 4);
                e.Graphics.FillEllipse(colorBrush, colorRect);
            }

            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(tag.Name, e.Font, textBrush, e.Bounds.X + 25, e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2);
            }

            e.DrawFocusRectangle();
        }

        public static void AddNewTag(string name, Color color, Template template)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO tags (name, color) 
                    VALUES (@name, @color);
                    SELECT last_insert_rowid();";

                string colorHex = ColorTranslator.ToHtml(color);

                long newTagId;
                using (var command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@color", colorHex);
                    newTagId = (long)command.ExecuteScalar();
                }

                if (template != null)
                {
                    string insertTemplateTagsQuery = @"
                    INSERT INTO template_tags (template_id, tag_id)
                    VALUES (@template_id, @tag_id)";

                    using (var command = new SqliteCommand(insertTemplateTagsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@template_id", template.Id);
                        command.Parameters.AddWithValue("@tag_id", newTagId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void UpdateTag(Tag tag)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string modifyQuery = @"
                        UPDATE tags
                        SET name = @name, color = @color
                        WHERE id = @id;
                    ";

                string colorHex = ColorTranslator.ToHtml(tag.Color);

                using (var command = new SqliteCommand(modifyQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", tag.Name);
                    command.Parameters.AddWithValue("@color", colorHex);
                    command.Parameters.AddWithValue("@id", tag.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool TagIsAssignedToTemplateByIds(int tagId, int templateId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT template_id
                FROM template_tags
                WHERE tag_id = @tag_id AND template_id = @template_id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tag_id", tagId);
                    command.Parameters.AddWithValue("@template_id", templateId);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void AssignTemplateToTagByIds(int templateId, int tagId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string insertTemplateTagsQuery = @"
                    INSERT INTO template_tags (template_id, tag_id)
                    VALUES (@template_id, @tag_id)";

                using (var command = new SqliteCommand(insertTemplateTagsQuery, connection))
                {
                    command.Parameters.AddWithValue("@template_id", templateId);
                    command.Parameters.AddWithValue("@tag_id", tagId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static BindingList<Template> GetAllTemplates()
        {
            BindingList<Template> templates = new BindingList<Template>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT t.created_at, t.id, t.name, t.text, s.color, t.initial_version_id
                        FROM templates t
                        LEFT JOIN template_tags d
                        ON t.id = d.template_id
                        LEFT JOIN tags s
                        ON s.id = d.tag_id";

                using (var command = new SqliteCommand(query, connection))
                {
                    Dictionary<int, Template> templatesDict = new Dictionary<int, Template>();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int templateId = int.Parse(reader["id"].ToString());

                            if (!templatesDict.ContainsKey(templateId))
                            {
                                templatesDict[templateId] = new Template
                                {
                                    Id = int.Parse(reader["id"].ToString()),
                                    Name = reader["name"].ToString(),
                                    Text = reader["text"].ToString(),
                                    Colors = new List<Color>(),
                                    CreationDate = DateTime.Parse(reader["created_at"].ToString()),
                                    InitialVersionId = reader.IsDBNull(reader.GetOrdinal("initial_version_id")) ? -1 : int.Parse(reader["initial_version_id"].ToString())
                                };
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("color")))
                            {
                                Color colorToAdd = ColorTranslator.FromHtml(reader["color"].ToString());
                                templatesDict[templateId].Colors.Add(colorToAdd);
                            }
                        }

                        templates = new BindingList<Template>(templatesDict.Values.ToList());
                    }
                }
            }

            return templates;
        }

        public static bool IsVersionInitialById(int versionId)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT id
                FROM templates
                WHERE initial_version_id = @init_ver";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@init_ver", versionId);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void AddParametersByVersionId(int versionId, List<string> parametersNames, bool ChangeVersionHasParametersToOne)
        {
            if (parametersNames.Count > 0 && versionId >= 0)
            {
                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    string insertParamatersQuery = @"
                    INSERT INTO parameters (name, version_id)
                    VALUES (@name, @version_id)";

                    using (var command = new SqliteCommand(insertParamatersQuery, connection))
                    {
                        command.Parameters.Add(new SqliteParameter("@name", DbType.String));
                        command.Parameters.Add(new SqliteParameter("@version_id", DbType.Int32));

                        foreach (string parameterName in parametersNames)
                        {
                            command.Parameters["@name"].Value = parameterName;
                            command.Parameters["@version_id"].Value = versionId;

                            command.ExecuteNonQuery();
                        }
                    }

                    if (ChangeVersionHasParametersToOne)
                    {
                        string updateVersionHasParametersQuery = @"
                        UPDATE versions
                        SET has_parameters = 1
                        WHERE id = @id;";

                        using (var command = new SqliteCommand(updateVersionHasParametersQuery, connection))
                        {
                            command.Parameters.AddWithValue("id", versionId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void RemoveParametersByVersionId(int versionId, List<string> parametersToDeleteNames, bool ChangeVersionHasParametersToZero)
        {
            if (parametersToDeleteNames.Count > 0 && versionId >= 0)
            {
                using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
                {
                    connection.Open();

                    string deleteParametersQuery = @"
                    DELETE FROM parameters
                    WHERE version_id = @ver_id AND name = @name";

                    using (var command = new SqliteCommand(deleteParametersQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ver_id", versionId);
                        command.Parameters.Add(new SqliteParameter("@name", DbType.String));

                        foreach (string parameterName in parametersToDeleteNames)
                        {
                            command.Parameters["@name"].Value = parameterName;

                            command.ExecuteNonQuery();
                        }
                    }

                    if (ChangeVersionHasParametersToZero)
                    {
                        string updateVersionHasParametersQuery = @"
                        UPDATE versions
                        SET has_parameters = 0
                        WHERE id = @id;";

                        using (var command = new SqliteCommand(updateVersionHasParametersQuery, connection))
                        {
                            command.Parameters.AddWithValue("id", versionId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static List<string> GetAllParametersNamesFromTextBox(string text)
        {
            List<string> parametersNames = new List<string>();

            string textToSearch = text;
            Regex regexForParameters = new Regex(@"\/(.*?)\/");

            MatchCollection matches = regexForParameters.Matches(textToSearch);

            foreach (Match match in matches)
            {
                parametersNames.Add(match.Groups[1].Value);
            }

            return parametersNames;
        }

        public static List<Parameter> GetAllParametersByVersionId(int versionId)
        {
            List<Parameter> parameters = new List<Parameter>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                SELECT id, name
                FROM parameters
                WHERE version_id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", versionId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            parameters.Add(new Parameter
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString()
                            });
                        }
                    }
                }
            }

            return parameters;
        }

        public static void SetTemplateHasMoreVersions(int templateId, bool hasMoreVersions)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string modifyQuery = @"
                        UPDATE templates
                        SET has_more_versions = @has
                        WHERE id = @id;
                    "
                ;

                int hasVersions = hasMoreVersions ? 1 : 0;
                using (var command = new SqliteCommand(modifyQuery, connection))
                {
                    command.Parameters.AddWithValue("@has", hasVersions);
                    command.Parameters.AddWithValue("@id", templateId);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal static List<HistoryLog> GetAllLogs()
        {
            List<HistoryLog> logs = new List<HistoryLog>();

            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string query = @"
                        SELECT id, action, timestamp, type
                        FROM logs";

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logs.Add(new HistoryLog
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Action = reader["action"].ToString(),
                                TimeStamp = DateTime.Parse(reader["timestamp"].ToString()),
                                Type = reader["type"].ToString()
                            });
                        }
                    }
                }
            }

            return logs;
        }

        public static void LogToHistory(string type, string action)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO logs (action, type, timestamp)
                    VALUES (@action, @type, @timestamp);
                    ";

                using (var command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    command.ExecuteNonQuery();
                }

                string deleteOldLogsQuery = @"
                    DELETE FROM logs
                    WHERE id IN (
                        SELECT id
                        FROM logs
                        WHERE (SELECT COUNT(*) FROM logs) > 20
                        ORDER BY timestamp ASC
                        LIMIT (SELECT COUNT(*) FROM logs) - 20
                    );";

                using (var deleteCommand = new SqliteCommand(deleteOldLogsQuery, connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        public static void ChangeAppShouldStartWithSystem(bool shouldStart)
        {
            Properties.Settings.Default.StartWithSystem = shouldStart;
            Properties.Settings.Default.Save();

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key != null)
            {
                if (shouldStart)
                {
                    key.SetValue("Basy", System.Windows.Forms.Application.ExecutablePath);
                    MessageBox.Show("Application startup settings changed to start with system!");
                }
                else
                {
                    key.DeleteValue("Basy", false);
                    MessageBox.Show("Application removed from startup!");
                }
            }
        }
    }
}

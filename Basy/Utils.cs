using Basy.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static bool CreateUserIfNotExist(string username, string password, string email)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                // Check if the username or email already exists
                string checkUserQuery = @"
                SELECT COUNT(*) 
                FROM users 
                WHERE username = @username OR email = @Email";

                using (var checkCommand = new SqliteCommand(checkUserQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", username);
                    checkCommand.Parameters.AddWithValue("@Email", email);

                    long userExists = (long)checkCommand.ExecuteScalar();

                    if (userExists > 0)
                    {
                        return false;  // User with the same username or email already exists
                    }
                }

                // If no user exists, insert the new user
                string insertUserQuery = @"
                INSERT INTO users (username, email, password) 
                VALUES (@username, @Email, @Password)";

                using (var insertCommand = new SqliteCommand(insertUserQuery, connection))
                {
                    // Hash the password before storing it (use BCrypt or other hashing mechanisms for security)
                    string hashedPassword = HashPassword(password);

                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Password", hashedPassword);

                    insertCommand.ExecuteNonQuery();  // Insert the new user
                }
            }

            return true;  // User successfully created
        }

        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder stringBuilder = new StringBuilder();

            for (global::System.Int32 i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static bool ValidateUserCredentials(string username, string enteredPassword)
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                // Query to get the user's hashed password from the database
                string query = @"
                SELECT password 
                FROM users 
                WHERE username = @username OR email = @username";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHashedPassword = result.ToString();
                        string enteredHashedPassword = HashPassword(enteredPassword);

                        return storedHashedPassword == enteredHashedPassword;
                    }
                }
            }

            return false;
        }

        public static void EnsureTablesExist()
        {
            Utils.EnsureTableExists(Queries.CreateTemplatesTable);

            // Create the tags table
            Utils.EnsureTableExists(Queries.CreateTagsTable);

            // Create the template_tags table (many-to-many relationship between templates and tags)
            Utils.EnsureTableExists(Queries.CreateTemplatesTagsTable);

            // Create the logs table (logs actions performed by users)
            Utils.EnsureTableExists(Queries.CreateLogsTable);

            //PopulateSampleTemplates();

            Utils.EnsureTableExists(Queries.CreateCredentialsTable);
        }

        public static void PopulateSampleTemplates()
        {
            using (var connection = new SqliteConnection($"Data Source={RuntimeConstants.BasyDatabaseFilePath}"))
            {
                connection.Open();

                // Insert sample templates directly
                string insertQuery1 = @"
                    INSERT INTO templates (name, text, user_id, created_at) 
                    VALUES ('Welcome Email', 'Dear User,\n\nWelcome to our service!\n\nBest,\nThe Team', 1, @created_at)";

                string insertQuery2 = @"
                    INSERT INTO templates (name, text, user_id, created_at) 
                    VALUES ('Password Reset', 'Hello,\n\nClick here to reset your password.\n\nBest,\nSupport', 1, @created_at)";

                string insertQuery3 = @"
                    INSERT INTO templates (name, text, user_id, created_at) 
                    VALUES ('Feedback Request', 'Hi,\n\nWe value your feedback. Please let us know how we did!\n\nThanks,\nThe Team', 1, @created_at)";

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

        public static void deleteTemplateById(int templateId) 
        { 
            EnsureTablesExist();

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy
{
    public static class Queries
    {
        public const string CreateUsersTable = @"
        CREATE TABLE IF NOT EXISTS users (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            username TEXT NOT NULL,
            email TEXT NOT NULL,
            password TEXT NOT NULL
        )";

        public const string CreateTemplatesTable = @"
                       CREATE TABLE IF NOT EXISTS templates (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       name TEXT NOT NULL,
                       text TEXT NOT NULL,
                       created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                       user_id INTEGER NOT NULL,
                       FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
           )";

        public const string CreateTagsTable = @"
                       CREATE TABLE IF NOT EXISTS tags (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       name TEXT NOT NULL
           )";

        public const string CreateTemplatesTagsTable = @"
                       CREATE TABLE IF NOT EXISTS template_tags (
                       template_id INTEGER NOT NULL,
                       tag_id INTEGER NOT NULL,
                       PRIMARY KEY (template_id, tag_id),
                       FOREIGN KEY (template_id) REFERENCES templates(id) ON DELETE CASCADE,
                       FOREIGN KEY (tag_id) REFERENCES tags(id) ON DELETE CASCADE
           )";

        public const string CreateLogsTable = @"
                       CREATE TABLE IF NOT EXISTS logs (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       user_id INTEGER NOT NULL,
                       action TEXT NOT NULL,
                       timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                       FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
           )";

    }
}

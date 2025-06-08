 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy
{
    public static class Queries
    {

        public const string CreateTemplatesTable = @"
                       CREATE TABLE IF NOT EXISTS templates (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       packageId INTEGER,
                       name TEXT NOT NULL,
                       text TEXT NOT NULL,
                       created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                       has_more_versions INTEGER NOT NULL,
                       initial_version_id INTEGER,
                       FOREIGN KEY (initial_version_id) REFERENCES versions(id) ON DELETE CASCADE
                       FOREIGN KEY (packageId) REFERENCES Packages(id) ON DELETE CASCADE
           )";

        public const string CreateVersionsTable = @"
                       CREATE TABLE IF NOT EXISTS versions (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       template_id INTEGER NOT NULL,
                       name TEXT NOT NULL,
                       text TEXT NOT NULL,
                       has_parameters INTEGER NOT NULL,
                       FOREIGN KEY (template_id) REFERENCES templates(id) ON DELETE CASCADE
           )";

        public const string CreateParametersTable = @"
                       CREATE TABLE IF NOT EXISTS parameters (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       name TEXT NOT NULL,
                       version_id INTEGER NOT NULL,
                       FOREIGN KEY (version_id) REFERENCES versions(id) ON DELETE CASCADE
           )";

        public const string CreateTagsTable = @"
                       CREATE TABLE IF NOT EXISTS tags (
                       id INTEGER PRIMARY KEY AUTOINCREMENT,
                       name TEXT NOT NULL,
                       color TEXT NOT NULL UNIQUE
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
                       action TEXT NOT NULL,
                       type TEXT NOT NULL,
                       timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP
           )";

        public const string CreatePackagesTable = @"
                       CREATE TABLE IF NOT EXISTS packages (
                       id TEXT PRIMARY KEY,
                       name TEXT NOT NULL,
                       description TEXT NOT NULL,
                       version TEXT DEFAULT '1',
                       CreatedAt TEXT DEFAULT (datetime('now'))
           )";

    }
}

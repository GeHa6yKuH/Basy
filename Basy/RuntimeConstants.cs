using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy
{
    public static class RuntimeConstants
    {
        public static readonly string BasyDatabaseFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Basy",
            "basy.db");
    }
}

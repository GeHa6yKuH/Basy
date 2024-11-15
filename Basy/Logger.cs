using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    internal static class Logger
    {
        public static void Log(Exception ex)
        {
            string logPath = Path.Combine(Application.StartupPath, "logs.txt"); ;

            using(StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] {ex.Message}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}");
                writer.WriteLine("------------------------------------------------");
            }
        }
    }
}

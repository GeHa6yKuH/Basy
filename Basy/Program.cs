using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        private static IKeyboardMouseEvents globalHook;
        private static NotifyIcon notifyIcon;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Visible = true,
                Text = "Basy App"
            };

            notifyIcon.Visible = true;

            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;

            Application.Run(new Login());
        }

        private static void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Y)
            {
                ShowTemplatePopup();
            }
        }

        private static void ShowTemplatePopup()
        {
            PopupWindow popupWindow = new PopupWindow();
            popupWindow.ShowInTaskbar = false;
            popupWindow.Deactivate += (s, e) => popupWindow.Close();
            popupWindow.Show();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            globalHook.KeyDown -= GlobalHook_KeyDown;
            globalHook.Dispose();
        }
    }
}

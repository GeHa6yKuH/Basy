using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

            string solutionPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string iconPath = Path.Combine(solutionPath, "UI", "Logo", "logo_for_icon.ico");
            notifyIcon = new NotifyIcon
            {
                Icon = new Icon(iconPath),
                Visible = true,
                Text = "Basy App",
            };

            notifyIcon.Visible = true;

            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;
            Application.ApplicationExit += Application_ApplicationExit;

            Application.ThreadException += (sender, args) => HandleException(args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => HandleException((Exception)args.ExceptionObject);

            BaseBasyForm baseBasyForm = new BaseBasyForm();

            Maineditorwindow mainEditorWindow = new Maineditorwindow();

            mainEditorWindow.Show();

            Application.Run(baseBasyForm);
        }

        private static void HandleException(Exception exception)
        {
            Logger.Log(exception);
            MessageBox.Show("An internal error occured while executing Basy functionality. The error has been logged to the logs.txt file in the Basy working directory.");
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
            Screen currentScreen = Screen.FromPoint(Cursor.Position);
            PopupWindow popupWindow = new PopupWindow();

            popupWindow.Left = currentScreen.Bounds.Left;
            popupWindow.Top = currentScreen.Bounds.Top;
            popupWindow.StartPosition = FormStartPosition.Manual;

            popupWindow.ShowInTaskbar = false;
            popupWindow.Deactivate += (s, e) =>
            {
                Point mousePosition = Cursor.Position;
                if (!popupWindow.Bounds.Contains(mousePosition))
                {
                    popupWindow.Close();
                }
            };

            popupWindow.Show();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (globalHook != null)
            {
                globalHook.KeyDown -= GlobalHook_KeyDown;
                globalHook.Dispose();
            }

            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }
        }
    }
}

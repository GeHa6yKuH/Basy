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
        private static HashSet<Keys> pressedKeys = new HashSet<Keys>();

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

            notifyIcon.Click += OpenEditor;
            notifyIcon.Visible = true;

            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;
            globalHook.KeyUp += GlobalHook_KeyUp;

            BasyClipboard.StartClipboardMonitoring();

            Application.ApplicationExit += Application_ApplicationExit;

            Application.ThreadException += (sender, args) => HandleException(args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => HandleException((Exception)args.ExceptionObject);

            BaseBasyForm baseBasyForm = new BaseBasyForm();

            Maineditorwindow mainEditorWindow = new Maineditorwindow();

            if (Properties.Settings.Default.ShouldOpenEdittorOnStart)
            {
                mainEditorWindow.Show();
            }

            Application.Run(baseBasyForm);
        }

        private static void OpenEditor(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpenByName("Maineditorwindow"))
            {
                Maineditorwindow maineditorwindow = new Maineditorwindow();
                maineditorwindow.Show();
            }
        }

        private static void HandleException(Exception exception)
        {
            Logger.Log(exception);
            MessageBox.Show("An internal error occured while executing Basy functionality. The error has been logged to the logs.txt file in the Basy working directory.");
        }

        private static void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey) pressedKeys.Add(Keys.ControlKey);
            else if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) pressedKeys.Add(Keys.ShiftKey);
            else if (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu) pressedKeys.Add(Keys.Menu);
            else pressedKeys.Add(e.KeyCode);

            if (string.Join(" + ", pressedKeys) == Properties.Settings.Default.Hotkey)
            {
                ShowTemplatePopup();
            }

            if (string.Join(" + ", pressedKeys) == Properties.Settings.Default.HotkeyClipboard)
            {
                ShowClipboardPopup();
            }

            // Editor

            if (string.Join(" + ", pressedKeys) == Properties.Settings.Default.HotkeyEditor)
            {
                if (!Utils.FormIsOpenByName("Maineditorwindow"))
                {
                    Maineditorwindow maineditorwindow = new Maineditorwindow();
                    maineditorwindow.Show();
                }
            }
        }

        private static void GlobalHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey) pressedKeys.Remove(Keys.ControlKey);
            else if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey) pressedKeys.Remove(Keys.ShiftKey);
            else if (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu) pressedKeys.Remove(Keys.Menu);
            else if (pressedKeys.Contains(e.KeyCode)) pressedKeys.Remove(e.KeyCode);
        }

        private static void ShowClipboardPopup()
        {
            Screen currentScreen = Screen.FromPoint(Cursor.Position);
            ClipBoardPopup clipboardWindow = new ClipBoardPopup();

            string positionString = Properties.Settings.Default.ClipboardPosition;

            bool isLeft = positionString.Contains("Left");
            bool isTop = positionString.Contains("Top");

            int x = isLeft ? currentScreen.Bounds.Left : currentScreen.Bounds.Right - clipboardWindow.Width;
            int y = isTop ? currentScreen.Bounds.Top : currentScreen.Bounds.Bottom - clipboardWindow.Height;

            clipboardWindow.Location = new Point(x, y);

            clipboardWindow.StartPosition = FormStartPosition.Manual;

            clipboardWindow.ShowInTaskbar = false;
            clipboardWindow.Deactivate += (s, e) =>
            {
                Point mousePosition = Cursor.Position;
                if (!clipboardWindow.Bounds.Contains(mousePosition))
                {
                    clipboardWindow.Close();
                }
            };

            clipboardWindow.Show();
        }

        private static void ShowTemplatePopup()
        {
            Screen currentScreen = Screen.FromPoint(Cursor.Position);
            PopupWindow popupWindow = new PopupWindow();

            string positionString = Properties.Settings.Default.TemplatesPosition;

            bool isLeft = positionString.Contains("Left");
            bool isTop = positionString.Contains("Top");

            int x = isLeft ? currentScreen.Bounds.Left : currentScreen.Bounds.Right - popupWindow.Width;
            int y = isTop ? currentScreen.Bounds.Top : currentScreen.Bounds.Bottom - popupWindow.Height;

            x = positionString.Contains("Coursor") ? Cursor.Position.X - popupWindow.Width : x;
            y = positionString.Contains("Coursor") ? Cursor.Position.Y - popupWindow.Height : y;

            popupWindow.Location = new Point(x, y);

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

            BasyClipboard.StopClipboardMonitoring();
        }
    }
}

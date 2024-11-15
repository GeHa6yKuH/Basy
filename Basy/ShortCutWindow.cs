using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class ShortCutWindow : Form
    {
        private SettingsControl settingsControl;
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private string variable;

        public ShortCutWindow(SettingsControl settingsControl, string variable)
        {
            InitializeComponent();
            this.settingsControl = settingsControl;
            this.variable = variable;
        }

        private void ShortCutWindow_Load(object sender, EventArgs e)
        {

        }

        private void tbHotkeyTemplates_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHotkeyTemplates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || pressedKeys.Count >= 3)
            {
                return;
            }
            pressedKeys.Add(e.KeyCode);

            tbHotkeyTemplates.Text = string.Join(" + ", pressedKeys);

            e.SuppressKeyPress = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hotkey = string.Join(" + ", pressedKeys);
            SaveHotKey(hotkey);
        }

        private void SaveHotKey(string hotkey)
        {
            if (!string.IsNullOrEmpty(tbHotkeyTemplates.Text))
            {
                ChangeUserSetting(hotkey);

                MessageBox.Show($"Shortcut changed to {hotkey}, it will start working on next program start!");
                if (settingsControl != null)
                {
                    settingsControl.SetCurrentStates();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please press shortcut!");
            }
        }

        private void ChangeUserSetting(string hotKey)
        {
            switch (variable)
            {
                case "Templates":
                    Properties.Settings.Default.Hotkey = hotKey;
                    Properties.Settings.Default.Save();
                    break;
                case "Editor":
                    Properties.Settings.Default.HotkeyEditor = hotKey;
                    Properties.Settings.Default.Save();
                    break;
                case "Clipboard":
                    Properties.Settings.Default.HotkeyClipboard = hotKey;
                    Properties.Settings.Default.Save();
                    break;
            }
        }

        private void tbHotkeyTemplates_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            tbHotkeyTemplates.Text = string.Join(" + ", pressedKeys);
        }
    }
}

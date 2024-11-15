using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class SettingsControl : UserControl
    {
        private bool _isSettingInitial = true;

        public SettingsControl()
        {
            InitializeComponent();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            SetCurrentStates();
        }

        public void SetCurrentStates()
        {
            _isSettingInitial = true;

            mcbStartWithSystem.CheckState = Properties.Settings.Default.StartWithSystem ?
                CheckState.Checked : CheckState.Unchecked;
            mcbOpenEditorOnStart.CheckState = Properties.Settings.Default.ShouldOpenEdittorOnStart ? 
                CheckState.Checked : CheckState.Unchecked;

            tbHotkeyTemplates.Text = Properties.Settings.Default.Hotkey;
            tbHotkeyMainEditor.Text = Properties.Settings.Default.HotkeyEditor;
            tbHotkeyClipboard.Text = Properties.Settings.Default.HotkeyClipboard;

            lblClipboardPosition.Text = Properties.Settings.Default.ClipboardPosition;
            lblTemplatesPosition.Text = Properties.Settings.Default.TemplatesPosition;
            mcbShowVersionsOnHover.CheckState = Properties.Settings.Default.ShowVersionsOnHover ?
                 CheckState.Checked : CheckState.Unchecked;
            mcbShowTemplateTextOnHover.CheckState = Properties.Settings.Default.ShowTemplateTextOnHover ?
                 CheckState.Checked : CheckState.Unchecked;

            _isSettingInitial = false;
        }

        private void rbStartWithSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblStartWithEditor_Click(object sender, EventArgs e)
        {

        }

        private void lblHotkeys_Click(object sender, EventArgs e)
        {

        }

        private void mcbStartWithSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (_isSettingInitial)
            {
                return;
            }

            bool isChecked = mcbStartWithSystem.Checked;
            Utils.ChangeAppShouldStartWithSystem(isChecked);
        }

        private void mcbOpenEditorOnStart_CheckedChanged(object sender, EventArgs e)
        {
            if (_isSettingInitial)
            {
                return;
            }

            bool isChecked = mcbOpenEditorOnStart.Checked;
            Properties.Settings.Default.ShouldOpenEdittorOnStart = isChecked;
            Properties.Settings.Default.Save();
        }

        private void btnEditOpenTemplatesPopup_Click(object sender, EventArgs e)
        {
            ShortCutWindow shortCutWindow = new ShortCutWindow(this, "Templates");
            shortCutWindow.ShowDialog(this);
        }

        private void btnEditOpenClipboardPopup_Click(object sender, EventArgs e)
        {
            ShortCutWindow shortCutWindow = new ShortCutWindow(this, "Clipboard");
            shortCutWindow.ShowDialog(this);
        }

        private void btnEditOpenMainEditor_Click(object sender, EventArgs e)
        {
            ShortCutWindow shortCutWindow = new ShortCutWindow(this, "Editor");
            shortCutWindow.ShowDialog(this);
        }

        private void btnPositionTemp_Click(object sender, EventArgs e)
        {
            PopupPosition popupPosition = new PopupPosition("Templates", this);
            popupPosition.ShowDialog(this);
        }

        private void btnPositionClip_Click(object sender, EventArgs e)
        {
            PopupPosition popupPosition = new PopupPosition("Clipboard", this);
            popupPosition.ShowDialog(this);
        }

        private void mcbShowVersionsOnHover_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowVersionsOnHover = mcbShowVersionsOnHover.Checked;
            Properties.Settings.Default.Save();
        }

        private void mcbShowTemplateTextOnHover_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowTemplateTextOnHover = mcbShowTemplateTextOnHover.Checked;
            Properties.Settings.Default.Save();
        }
    }
}

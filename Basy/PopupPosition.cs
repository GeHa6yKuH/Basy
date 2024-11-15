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
    public partial class PopupPosition : Form
    {
        private string window;
        private SettingsControl settingsControl;
        public PopupPosition(string window, SettingsControl settingsControl)
        {
            InitializeComponent();
            this.window = window;
            this.settingsControl = settingsControl;
        }

        private void btnCoursorPosition_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null )
            {
                switch (window)
                {
                    case "Templates":
                        Properties.Settings.Default.TemplatesPosition = button.Text;
                        Properties.Settings.Default.Save();
                        break;
                    case "Clipboard":
                        Properties.Settings.Default.ClipboardPosition = button.Text;
                        Properties.Settings.Default.Save();
                        break;
                }
                if (settingsControl != null)
                {
                    settingsControl.SetCurrentStates();
                }
                Close();
            }
        }
    }
}

using Basy.Models;
using Gma.System.MouseKeyHook;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class Maineditorwindow : BaseBasyForm
    {

        public Maineditorwindow()
        {
            InitializeComponent();
        }

        private void rbTemplates_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTemplates.Checked)
            {
                FillUserControl(new TemplatesControl());
            }
        }

        private void rbCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredentials.Checked)
            {
                mainContentPanel.Controls.Clear();
            }
        }

        private void FillUserControl(UserControl control)
        {
            mainContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(control);

            //control.Refresh();
        }
    }
}

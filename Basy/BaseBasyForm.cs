using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public class BaseBasyForm : Form
    {
        public BaseBasyForm()
        {
            this.FormClosing += Close_Hide;
        }

        private void Close_Hide(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

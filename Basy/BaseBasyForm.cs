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
        Maineditorwindow _mainEditorWindow;

        public BaseBasyForm()
        {
            InitializeComponent();
            this.FormClosing += Close_Hide;
        }

        private void Close_Hide(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseBasyForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseBasyForm";
            this.Load += new System.EventHandler(this.BaseBasyForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseBasyForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
    }
}

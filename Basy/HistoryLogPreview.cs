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
    public partial class HistoryLogPreview : Form
    {
        private string _type;
        private string _action;

        public HistoryLogPreview(string type, string action)
        {
            InitializeComponent();
            _type = type;
            _action = action;
        }

        private void HistoryLogPreview_Load(object sender, EventArgs e)
        {
            lblType.Text = _type;
            tbText.Text = _action;
        }
    }
}

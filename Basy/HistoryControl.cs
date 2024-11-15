using Basy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Basy
{
    public partial class HistoryControl : UserControl
    {
        private List<HistoryLog> _logs;

        public HistoryControl()
        {
            InitializeComponent();

            lvLogs.DoubleClick += OpenLog;
        }

        private void OpenLog(object sender, EventArgs e)
        {
            if (lvLogs.SelectedItems.Count > 0)
            {
                string type = lvLogs.SelectedItems[0].SubItems[1].Text;
                string action = lvLogs.SelectedItems[0].SubItems[2].Text;
                
                HistoryLogPreview historyLogPreview = new HistoryLogPreview(type, action);
                historyLogPreview.Show();
            }
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void PopulateListView()
        {
            lvLogs.Items.Clear();

            _logs = Utils.GetAllLogs().OrderByDescending(l => l.TimeStamp).ToList();

            foreach (var log in _logs)
            {
                string type = log.Type;

                ListViewItem item = new ListViewItem("");
                switch (type)
                {
                    case Operations.Create:
                        item.BackColor = Color.Blue;
                        break;
                    case Operations.Modify:
                        item.BackColor = Color.Green;
                        break;
                    case Operations.Delete:
                        item.BackColor = Color.Red;
                        break;
                }
                item.SubItems.Add(type);
                item.SubItems.Add(log.Action);
                item.SubItems.Add(log.TimeStamp.ToString());

                lvLogs.Items.Add(item);
            }
        }
    }
}

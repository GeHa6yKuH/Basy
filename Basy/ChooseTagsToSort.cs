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

namespace Basy
{
    public partial class ChooseTagsToSort : Form
    {
        private List<Tag> _tags = new List<Tag>();
        public List<Tag> _tagsToPass = new List<Tag>();
        private bool _isConfirmed = false;

        public ChooseTagsToSort()
        {
            InitializeComponent();

            lbTags.DrawMode = DrawMode.OwnerDrawFixed;
            lbTags.DrawItem += DrawColorCircle;

            this.FormClosing += DialogCancel;
        }

        private void DialogCancel(object sender, FormClosingEventArgs e)
        {
            if (!_isConfirmed)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void DrawColorCircle(object sender, DrawItemEventArgs e)
        {
            Utils.DrawColorCircleForTags(lbTags, e);
        }

        private void ChooseTagsToSort_Load(object sender, EventArgs e)
        {
            _tagsToPass = new List<Tag>();
            PopulateListWithTags();
        }

        private void PopulateListWithTags()
        {
            lbTags.Items.Clear();

            _tags = Utils.GetAllTags();

            foreach (Tag tag in _tags)
            {
                lbTags.Items.Add(tag);
            }
        }

        private void mtbSort_Click(object sender, EventArgs e)
        {
            if (lbTags.SelectedItems != null && lbTags.SelectedItems.Count > 0)
            {
                foreach (Tag tag in lbTags.SelectedItems)
                {
                    _tagsToPass.Add(tag);
                }
            }

            _isConfirmed = true;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}

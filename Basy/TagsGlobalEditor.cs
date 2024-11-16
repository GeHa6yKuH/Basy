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
    public partial class TagsGlobalEditor : Form
    {
        List<Tag> _tags = new List<Tag>();
        TemplatesControl _templatesControl;

        public TagsGlobalEditor(TemplatesControl templatesControl)
        {
            InitializeComponent();
            _templatesControl = templatesControl;
            PopulateListWithTags();

            lbTags.DrawMode = DrawMode.OwnerDrawFixed;
            lbTags.DrawItem += DrawColorCircle;

            lbTags.DoubleClick += OpenTagEditor;
        }

        private void OpenTagEditor(object sender, EventArgs e)
        {
            Tag tagToEdit = (Tag)lbTags.SelectedItem;
            if (tagToEdit != null)
            {
                TagEditor tagEditor = new TagEditor(tagToEdit, this);
                tagEditor.Show();
            }
        }

        private void DrawColorCircle(object sender, DrawItemEventArgs e)
        {
            Utils.DrawColorCircleForTags(lbTags, e);
        }

        public void PopulateListWithTags()
        {
            lbTags.Items.Clear();

            _tags = Utils.GetAllTags();

            foreach (Tag tag in _tags)
            {
                lbTags.Items.Add(tag);
            }
        }

        private void mtbAddNewTag_Click(object sender, EventArgs e)
        {
            NewTag newTag = new NewTag(this);
            newTag.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (lbTags.SelectedItem != null)
            {
                Tag tagToDelete = (Tag)lbTags.SelectedItem;
                DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {tagToDelete.Name} Tag?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (userConfirms == DialogResult.Yes)
                {
                    Utils.deleteTagById(tagToDelete.Id);
                    Utils.LogToHistory(Operations.Delete, $"Tag with name {tagToDelete.Name} has been deleted!");
                    PopulateListWithTags();
                }
            }
        }
    }
}

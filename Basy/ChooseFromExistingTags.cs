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
    public partial class ChooseFromExistingTags : Form
    {
        Template _templateToAddExistingTag;
        TagsEditor _tagsEditor;
        private List<Tag> _tags = new List<Tag>();

        public ChooseFromExistingTags(Template template, TagsEditor tagsEditor)
        {
            InitializeComponent();
            PopulateListWithTags();
            _templateToAddExistingTag = template;

            lbTags.DrawMode = DrawMode.OwnerDrawFixed;
            lbTags.DrawItem += DrawColorCircle;
            _tagsEditor = tagsEditor;

            lbTags.DoubleClick += DoubleClickAssignTag;
        }

        private void DoubleClickAssignTag(object sender, EventArgs e)
        {
            AssignSelectedTagToTemplate();
        }

        private void DrawColorCircle(object sender, DrawItemEventArgs e)
        {
            Utils.DrawColorCircleForTags(lbTags, e);
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

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            AssignSelectedTagToTemplate();
        }

        private void AssignSelectedTagToTemplate()
        {
            if (lbTags.SelectedItem != null)
            {
                Tag tag = (Tag)lbTags.SelectedItem;
                if (!Utils.TagIsAssignedToTemplateByIds(tag.Id, _templateToAddExistingTag.Id))
                {
                    Utils.AssignTemplateToTagByIds(_templateToAddExistingTag.Id, tag.Id);
                    if (_tagsEditor != null)
                    {
                        _tagsEditor.PopulateListWithTags();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("This Tag is already assigned to specified Template!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an Item!");
            }
        }
    }
}

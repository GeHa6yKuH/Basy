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
    public partial class TagsEditor : Form
    {
        Template _templateToEditTags;
        private List<Tag> _tags = new List<Tag>();

        public TagsEditor(Template template)
        {
            InitializeComponent();
            _templateToEditTags = template;
            PopulateListWithTags();

            lbTags.DrawMode = DrawMode.OwnerDrawFixed;
            lbTags.DrawItem += DrawColorCircle;
        }

        private void DrawColorCircle(object sender, DrawItemEventArgs e)
        {
            Utils.DrawColorCircleForTags(lbTags, e);
        }

        public void PopulateListWithTags()
        {
            lbTags.Items.Clear();

            _tags = Utils.GetAllTagsByTemplateId(_templateToEditTags.Id);

            foreach (Tag tag in _tags)
            {
                lbTags.Items.Add(tag);
            }
        }

        private void mtbAddNewTag_Click(object sender, EventArgs e)
        {
            if (_tags.Count > 3)
            {
                MessageBox.Show("You can not add more then 4 Tags to one Template!");
                return;
            }
            NewTag newTag = new NewTag(this, _templateToEditTags);
            newTag.Show();
        }

        private void mtbAddExistingTag_Click(object sender, EventArgs e)
        {
            if (_tags.Count > 3)
            {
                MessageBox.Show("You can not add more then 4 Tags to one Template!");
                return;
            }
            ChooseFromExistingTags chooseFromExistingTags = new ChooseFromExistingTags(_templateToEditTags, this);
            chooseFromExistingTags.Show();
        }
    }
}

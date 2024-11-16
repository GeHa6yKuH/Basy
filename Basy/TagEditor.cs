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
    public partial class TagEditor : Form
    {
        private TagsGlobalEditor _tagsGlobalEditor;
        private Tag _tag;
        private Color _color;

        public TagEditor(Tag tag, TagsGlobalEditor tagsGlobalEditor)
        {
            InitializeComponent();
            _tag = tag;
            _tagsGlobalEditor = tagsGlobalEditor;
        }

        private void TagEditor_Load(object sender, EventArgs e)
        {
            tbName.Text = _tag.Name;
            _color = _tag.Color;
            pnlColorPreview.BackColor = _tag.Color;
        }

        private void btnPickAColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _color = colorDialog.Color;
                    pnlColorPreview.BackColor = _color;
                }
            }
        }

        private void mtbModify_Click(object sender, EventArgs e)
        {
            if (tbName.Text != _tag.Name || _color != _tag.Color)
            {
                bool nameModified = tbName.Text != _tag.Name;
                string toLog = nameModified ?
                    $"Name of tag {_tag.Name} has been changed to {tbName.Text}" :
                    $"Color of tag {_tag.Name} has been changed to {_color.Name}";
                _tag.Name = tbName.Text;
                _tag.Color = _color;
                Utils.UpdateTag(_tag);
                if (_tagsGlobalEditor != null)
                {
                    _tagsGlobalEditor.PopulateListWithTags();
                }
                Utils.LogToHistory(Operations.Modify, toLog);
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}

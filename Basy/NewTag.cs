using Basy.Models;
using Microsoft.Data.Sqlite;
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
    public partial class NewTag : Form
    {
        private TagsGlobalEditor _tagsGlobalEditor;
        private TagsEditor _tagsEditor;
        private Template _templateToCreateTagFor;
        private Color _color;

        public NewTag(TagsGlobalEditor tagsGlobalEditor)
        {
            InitializeComponent();
            _tagsGlobalEditor = tagsGlobalEditor;
        }

        public NewTag(TagsEditor tagsEditor, Template template)
        {
            InitializeComponent();
            _templateToCreateTagFor = template;
            _tagsEditor = tagsEditor;
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

        private void btnAddNewTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbName.Text) && _color != null)
                {
                    Utils.AddNewTag(tbName.Text, _color, _templateToCreateTagFor);
                    if (_tagsEditor != null)
                    {
                        _tagsEditor.PopulateListWithTags();
                    }
                    if (_tagsGlobalEditor != null)
                    {
                        _tagsGlobalEditor.PopulateListWithTags();
                    }
                    Utils.LogToHistory(Operations.Create, $"Tag {tbName.Text} has been created!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Please fill all the fields!");
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("The selected color is already occupied by another tag, please choose another color!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}

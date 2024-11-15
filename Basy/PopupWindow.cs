using Basy.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Basy
{
    public partial class PopupWindow : Form
    {
        private BindingList<Template> _templates = new BindingList<Template>();
        private ContextMenuStrip _versionMenuPopup;
        private int _lastHoveredIndex = -1;
        private Timer _hoverTimer;
        private Graphics _graphicsForCircles;
        private bool _isExtended = false;

        public PopupWindow()
        {
            InitializeComponent();
            Utils.EnsureTablesExist();
            populateListWithTemplates();
            BringToFront();

            _versionMenuPopup = new ContextMenuStrip();
            _versionMenuPopup.MouseLeave += (s, e) => _versionMenuPopup.Hide();

            _hoverTimer = new Timer();
            _hoverTimer.Interval = 100;
            _hoverTimer.Tick += ShowVersionsOnHover;

            lbTemplates.MouseEnter += (s, e) => _hoverTimer.Start();
            lbTemplates.MouseLeave += HideVersions;
            MouseLeave += HideVersions;

            TopMost = true;

            lbTemplates.Click += pasteSelectedTemplate;

            lbTemplates.DrawMode = DrawMode.OwnerDrawFixed;
            lbTemplates.DrawItem += DrawColorCircles;
        }

        private void DrawColorCircles(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            Template template = (Template)lbTemplates.Items[e.Index];

            if (template != null)
            {
                int margin = 5;
                int x = e.Bounds.Left + margin;

                if (template.Colors != null && template.Colors.Count > 0)
                {
                    int ellipseRadius = 15;

                    foreach (Color color in template.Colors)
                    {
                        using (Brush brush = new SolidBrush(color))
                        {
                            e.Graphics.FillEllipse(
                                brush,
                                x,
                                e.Bounds.Top + (e.Bounds.Height - ellipseRadius) / 2,
                                ellipseRadius,
                                ellipseRadius);

                            x += ellipseRadius + margin;
                        }
                    }
                }

                using (Brush textBrush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(
                        template.Name,
                        e.Font,
                        textBrush,
                        x,
                        e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2);
                }
            }
        }

        private void pasteSelectedTemplate(object sender, EventArgs e)
        {
            if (lbTemplates.SelectedItem != null)
            {
                Template selectedTemplate = (Template)lbTemplates.SelectedItem;
                if (!Utils.TemplateHasMoreVersionsById(selectedTemplate.Id))
                {
                    if (!Utils.VersionHasParametersById(selectedTemplate.InitialVersionId))
                    {
                        Utils.PasteTextAsync(selectedTemplate.Text);
                    }
                    else
                    {
                        ParametersTemplateWindow parametersTemplateWindow = new ParametersTemplateWindow(selectedTemplate.Text);
                        parametersTemplateWindow.Show();
                    }
                }
                else
                {
                    ChooseVersion chooseVersion = new ChooseVersion(selectedTemplate);
                    chooseVersion.Show();
                }
                this.Close();
            }
        }

        private void HideVersions(object sender, EventArgs e)
        {
            _hoverTimer.Stop();
            Point mousePosition = Cursor.Position;
            if (!_versionMenuPopup.Bounds.Contains(mousePosition))
            {
                _versionMenuPopup.Hide();
            }
            _lastHoveredIndex = -1;
        }

        private void ShowVersionsOnHover(object sender, EventArgs e)
        {
            Point cursorPosition = lbTemplates.PointToClient(Cursor.Position);
            int index = lbTemplates.IndexFromPoint(cursorPosition);

            if (index != _lastHoveredIndex && index >= 0 && index < lbTemplates.Items.Count)
            {
                _lastHoveredIndex = index;
                Template hoveredTemplate = (Template)lbTemplates.Items[index];

                if (hoveredTemplate != null)
                {
                    _versionMenuPopup.Items.Clear();

                    foreach (TVersion version in Utils.GetAllVersionsByTemplateId(hoveredTemplate.Id))
                    {
                        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(version.ToString());
                        toolStripMenuItem.Tag = version;
                        toolStripMenuItem.Click += VersionClick;
                        _versionMenuPopup.Items.Add(toolStripMenuItem);
                    }

                    if (_versionMenuPopup.Items.Count > 1)
                    {
                        Point versionsWindowSpawnPoint = cursorPosition + Constants.versionsPopupoffset;
                        _versionMenuPopup.Show(lbTemplates, versionsWindowSpawnPoint);
                    }
                }
            }
        }


        private void VersionClick(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            if (item != null)
            {
                string textToPaste = ((TVersion)item.Tag).Text;
                Utils.PasteTextAsync(textToPaste);
            }
            this.Close();
        }

        private void populateListWithTemplates()
        {
            lbTemplates.Items.Clear();

            _templates = Utils.GetAllTemplates();

            foreach (Template template in _templates)
            {
                lbTemplates.Items.Add(template);
            }
        }

        private void cbSortGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortBox.SelectedIndex >= 0)
            {
                Properties.Settings.Default.LastSortIndex = cbSortBox.SelectedIndex;
                Properties.Settings.Default.Save();

                switch (cbSortBox.SelectedIndex)
                {
                    case 0:
                        _templates = new BindingList<Template>(_templates.OrderBy(x => x.Name).ToList());
                        ChangeSize(false);
                        break;
                    case 1:
                        _templates = new BindingList<Template>(_templates.OrderByDescending(x => x.Name).ToList());
                        ChangeSize(false);
                        break;
                    case 2:
                        _templates = new BindingList<Template>(_templates.OrderBy(x => x.CreationDate).ToList());
                        ChangeSize(false);
                        break;
                    case 3:
                        _templates = new BindingList<Template>(_templates.OrderByDescending(x => x.Colors.Count).ToList());
                        ChangeSize(false);
                        break;
                    case 4:
                        ChooseTagsToSort chooseTagsToSort = new ChooseTagsToSort();
                        chooseTagsToSort.StartPosition = FormStartPosition.CenterScreen;

                        if (chooseTagsToSort.ShowDialog() == DialogResult.OK && chooseTagsToSort._tagsToPass != null
                            && chooseTagsToSort._tagsToPass.Count >= 0)
                        {
                            ChangeSize(true);

                            List<Tag> selectedTags = chooseTagsToSort._tagsToPass;
                            List<Template> templatesSortedByTags = _templates
                                .Where(t => selectedTags.Any(tag => t.Colors.Contains(tag.Color)))
                                .OrderBy(x => x.CreationDate)
                                .ToList();

                            lbTemplates.DataSource = templatesSortedByTags;
                            lbTemplates.Refresh();

                            DrawColorCirclesUnderCbSortBox(selectedTags);

                            return;
                        }
                        else
                        {
                            cbSortBox.SelectedIndex = 2;
                        }
                        break;
                }

                lbTemplates.DataSource = _templates;
                lbTemplates.Refresh();
            }
        }

        private void DrawColorCirclesUnderCbSortBox(List<Tag> selectedTags)
        {
            _graphicsForCircles = CreateGraphics();

            int margin = 5;
            int ellipseRadius = 15;
            int x = cbSortBox.Left;
            int y = cbSortBox.Bottom + 5;

            foreach (Tag tag in selectedTags)
            {
                using (Brush brush = new SolidBrush(tag.Color))
                {
                    _graphicsForCircles.FillEllipse(
                        brush,
                        x,
                        y,
                        ellipseRadius,
                        ellipseRadius);

                    x += ellipseRadius + margin;
                }
            }
        }

        private void ChangeSize(bool getsHigher)
        {
            if (getsHigher && !_isExtended)
            {
                lbTemplates.Location = new Point(lbTemplates.Location.X, lbTemplates.Location.Y + 22);
                this.Size += new Size(0, 22);
                _isExtended = true;
            }
            else if (!getsHigher && _isExtended)
            {
                lbTemplates.Location = new Point(lbTemplates.Location.X, lbTemplates.Location.Y - 22);
                this.Size -= new Size(0, 22);
                _isExtended = false;
            }
        }

        private void btnEditorOpen_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpenByName("Maineditorwindow"))
            {
                Maineditorwindow maineditorwindow = new Maineditorwindow();
                maineditorwindow.Show();
                Close();
            }
        }

        private void PopupWindow_Load(object sender, EventArgs e)
        {
            int lastSortIndex = Properties.Settings.Default.LastSortIndex;

            if (lastSortIndex >= 0 && lastSortIndex < cbSortBox.Items.Count)
            {
                cbSortBox.SelectedIndex = lastSortIndex;

                cbSortGrid_SelectedIndexChanged(cbSortBox, EventArgs.Empty);
            }
        }
    }
}

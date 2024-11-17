using Basy.Models;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class TemplatesControl : UserControl
    {

        private BindingList<Template> templates = new BindingList<Template>();
        private bool tagsColumnAdded = false;
        private Graphics _graphicsForCircles;

        public TemplatesControl()
        {
            InitializeComponent();
        }

        private void PaintTagsColorCirclesForTagsColumn(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dGVTemplates.Columns["Tags"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                Template template = (Template)dGVTemplates.Rows[e.RowIndex].DataBoundItem;

                if (template != null && template.Colors != null && template.Colors.Count > 0)
                {
                    int ellipseRadius = 18;
                    int margin = 10;
                    int x = e.CellBounds.Left + margin;

                    foreach (Color color in template.Colors)
                    {
                        using (Brush brush = new SolidBrush(color))
                        {
                            e.Graphics.FillEllipse(brush, x, e.CellBounds.Top + (e.CellBounds.Height - ellipseRadius) / 2, ellipseRadius, ellipseRadius);
                            x += ellipseRadius + margin;
                        }
                    }
                }

                e.Handled = true;
            }
        }

        private void dGVTemplates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dGVTemplates.Rows[e.RowIndex];

                if (templates.Count != 0)
                {
                    Template templateToModify = templates.FirstOrDefault(t => t.Id == int.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    if (templateToModify != null && !string.IsNullOrEmpty(templateToModify.Name))
                    {
                        TemplateEditor templateEditor = new TemplateEditor(templateToModify, this);
                        templateEditor.Show();
                    }
                }
            }
        }

        public void PopulateGrid()
        {
                templates.Clear();

                Utils.EnsureTablesExist();

                templates = Utils.GetAllTemplates();

                dGVTemplates.DataSource = templates;

                ResetGridColumnSettings();
        }

        private void TemplatesControl_Load(object sender, EventArgs e)
        {
            PopulateGrid();

            dGVTemplates.CellDoubleClick += dGVTemplates_CellDoubleClick;
            dGVTemplates.CellPainting += PaintTagsColorCirclesForTagsColumn;
            //dGVTemplates.Layout += AdjustWidth;
            SelectIndexInSortGrid(2);
        }

        private void AdjustWidth(object sender, LayoutEventArgs e)
        {
            if (dGVTemplates.Controls.OfType<VScrollBar>().FirstOrDefault()?.Visible == true)
            {
                dGVTemplates.Size = new Size(947, 415);
            }
            else
            {
                dGVTemplates.Width = 947 - SystemInformation.VerticalScrollBarWidth;
            }
        }

        private void cbSortGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortGrid.SelectedIndex >= 0)
            {
                switch (cbSortGrid.SelectedIndex)
                {
                    case 0:
                        templates = new BindingList<Template>(templates.OrderBy(x => x.Name).ToList());
                        ClearGraphics();
                        dGVTemplates.PerformLayout();
                        break;
                    case 1:
                        templates = new BindingList<Template>(templates.OrderByDescending(x => x.Name).ToList());
                        ClearGraphics();
                        dGVTemplates.PerformLayout();
                        break;
                    case 2:
                        templates = new BindingList<Template>(templates.OrderBy(x => x.CreationDate).ToList());
                        ClearGraphics();
                        dGVTemplates.PerformLayout();
                        break;
                    case 3:
                        templates = new BindingList<Template>(templates.OrderByDescending(x => x.Colors.Count).ToList());
                        ClearGraphics();
                        dGVTemplates.PerformLayout();
                        break;
                    case 4:
                        ChooseTagsToSort chooseTagsToSort = new ChooseTagsToSort();

                        if (chooseTagsToSort.ShowDialog() == DialogResult.OK && chooseTagsToSort._tagsToPass != null
                            && chooseTagsToSort._tagsToPass.Count >= 0)
                        {
                            List<Tag> selectedTags = chooseTagsToSort._tagsToPass;
                            List<Template> templatesSortedByTags =  templates
                                .Where(t => selectedTags.Any(tag => t.Colors.Contains(tag.Color)))
                                .OrderBy(x => x.CreationDate)
                                .ToList();

                            dGVTemplates.DataSource = templatesSortedByTags;
                            dGVTemplates.Refresh();
                            ClearGraphics();
                            DrawColorCirclesUnderCbSortBox(selectedTags);

                            ResetGridColumnSettings();
                            return;
                        }
                        else
                        {
                            cbSortGrid.SelectedIndex = 2;
                        }
                        break;
                }

                dGVTemplates.DataSource = templates;
                dGVTemplates.Refresh();
            }
        }

        public void SelectIndexInSortGrid(int index)
        {
            cbSortGrid.SelectedIndex = index;
        }

        private void ClearGraphics()
        {
            this.Invalidate();
            this.Update();
        }

        private void DrawColorCirclesUnderCbSortBox(List<Tag> selectedTags)
        {
            _graphicsForCircles = CreateGraphics();

            int margin = 5;
            int ellipseRadius = 15;
            int x = lblSortBy.Right;
            int y = lblSortBy.Top;

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

        private void ResetGridColumnSettings()
        {
            dGVTemplates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dGVTemplates.Columns["Id"].Visible = false;
            dGVTemplates.Columns["CreationDate"].Visible = false;
            dGVTemplates.Columns["InitialVersionId"].Visible = false;

            int rowHeaderWidth = dGVTemplates.RowHeadersWidth;
            int availabledgvWidth = dGVTemplates.Width - rowHeaderWidth;

            dGVTemplates.Columns["Name"].Width = (int)(availabledgvWidth * 0.2);
            dGVTemplates.Columns["Text"].Width = (int)(availabledgvWidth * 0.613);

            if (tagsColumnAdded == true)
            {
                dGVTemplates.Columns["Tags"].Width = (int)(availabledgvWidth * 0.18);
            }
            else
            {
                DataGridViewColumn tagsColumn = new DataGridViewColumn();
                tagsColumn.Name = "Tags";
                tagsColumn.HeaderText = "Tags";
                tagsColumn.ReadOnly = true;
                tagsColumn.CellTemplate = new DataGridViewTextBoxCell();
                tagsColumn.Width = (int)(availabledgvWidth * 0.17);

                dGVTemplates.Columns.Add(tagsColumn);

                tagsColumnAdded = true;
            }

            dGVTemplates.ScrollBars = ScrollBars.Vertical;
            dGVTemplates.PerformLayout();

            dGVTemplates.Refresh();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRaws = dGVTemplates.SelectedRows;
                if (selectedRaws.Count > 0)
                {
                    if (dGVTemplates.SelectedRows.Count == 1)
                    {
                        int id = (int)dGVTemplates.SelectedRows[0].Cells["id"].Value;

                        Template templateToDelete = Utils.findTemplateById(id);

                        if (templateToDelete != null)
                        {
                            DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {templateToDelete.Name} Template?", "Delete", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (userConfirms == DialogResult.Yes)
                            {
                                Utils.deleteTemplateById(id);
                                Utils.LogToHistory(Operations.Delete, $"Template {templateToDelete.Name}" +
                                $" with text {templateToDelete.Text} has been deleted!");
                                dGVTemplates.Refresh();
                                PopulateGrid();
                            }
                        }
                    }
                    else
                    {
                        List<int> idList = new List<int>();

                        for (global::System.Int32 i = 0; i < selectedRaws.Count; i++)
                        {
                            int id = (int)selectedRaws[i].Cells["id"].Value;
                            idList.Add(id);
                        }

                        if (idList.Count > 0)
                        {
                            DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete selected templates?", "Delete", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (userConfirms == DialogResult.Yes)
                            {
                                Utils.DeleteTemplatesByIdList(idList);
                                dGVTemplates.Refresh();
                                PopulateGrid();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            NewTemplate newTemplate = new NewTemplate(this);
            newTemplate.Show();
        }

        private void mbtnEditTags_Click(object sender, EventArgs e)
        {
            TagsGlobalEditor tagsGlobalEditor = new TagsGlobalEditor(this);
            tagsGlobalEditor.Show();
        }

        private void mbtnUpdateGrid_Click(object sender, EventArgs e)
        {
            SelectIndexInSortGrid(2);
        }

        private void dGVTemplates_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dGVTemplates.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}

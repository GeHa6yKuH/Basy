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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Basy
{
    public partial class VersionsEditor : Form
    {
        Template _templateToEditVersions;
        private List<TVersion> _versions = new List<TVersion>();

        public VersionsEditor(Template template)
        {
            InitializeComponent();
            _templateToEditVersions = template;
            PopulateListWithVersions();

            lbVersions.DoubleClick += (s, e) =>
            {
                if (lbVersions.SelectedItem != null)
                {
                    VersionEditor versionEditor = new VersionEditor(
                        (TVersion)lbVersions.SelectedItem,
                        this,
                        _templateToEditVersions.Id);
                    versionEditor.Show();
                }
            };
        }

        public void PopulateListWithVersions()
        {
            lbVersions.Items.Clear();

            _versions = Utils.GetAllVersionsByTemplateId(_templateToEditVersions.Id);

            if (_versions.Count == 1)
            {
                Utils.SetTemplateHasMoreVersions(_templateToEditVersions.Id, false);
            }

            foreach (TVersion version in _versions)
            {
                lbVersions.Items.Add(version);
            }
        }

        private void mtbAdd_Click(object sender, EventArgs e)
        {
            if (_templateToEditVersions != null)
            {
                NewVersion newVersion = new NewVersion(_templateToEditVersions, this);
                newVersion.Show();
            }
            else
            {
                MessageBox.Show("no template: Interlnal Error!");
            }
        }

        private void mtbDelete_Click(object sender, EventArgs e)
        {
            TVersion version = (TVersion)lbVersions.Items[lbVersions.SelectedIndex];
            int id = version.Id;

            if (!Utils.IsVersionInitialById(id))
            {
                TVersion versionToDelete = Utils.findVersionById(id);

                if (versionToDelete != null)
                {
                    DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {versionToDelete.Name} Version?", "Delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (userConfirms == DialogResult.Yes)
                    {
                        Utils.deleteVersionById(id);
                        Utils.LogToHistory(Operations.Delete, $"Version {versionToDelete.Name}" +
                            $"with text {versionToDelete.Text} has been deleted!");
                        PopulateListWithVersions();
                    }
                }
            }
            else
            {
                MessageBox.Show("You can not delete the Initial version, only modify it's properties!");
            }
        }
    }
}

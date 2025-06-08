using Basy.Models;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basy
{
    public partial class PackagesControl : UserControl
    {
        private BindingList<Package> packages = new BindingList<Package>();

        public PackagesControl()
        {
            InitializeComponent();
        }

        private void PackagesControl_Load(object sender, EventArgs e)
        {
            sfbtnAdd.Paint += sfButtonPaint;
            sfbtnCreate.Paint += sfButtonPaint;
            sfBtnDelete.Paint += sfButtonPaint;

            packages.Clear();

            packages = Utils.GetAllPackages();

            dGVPackages.DataSource = packages;

        }

        private void sfButtonPaint(object sender, PaintEventArgs e)
        {
            SfButton sfButton = sender as SfButton;
            if (sfButton == null)
            {
                return;
            }

            int radius = 5;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(
            sfButton.ClientRectangle.X + 1,
            sfButton.ClientRectangle.Y + 1,
            sfButton.ClientRectangle.Width - 2,
            sfButton.ClientRectangle.Height - 2
            );
            sfButton.Region = new Region(GetRoundedRect(rect, radius));
            rect = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);

            Pen borderPen = new Pen(sfButton.Style.BackColor);

            e.Graphics.DrawPath(borderPen, GetRoundedRect(rect, radius));
            
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            // Top-left corner
            graphicsPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);

            // Top edge
            graphicsPath.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);

            // Top-right corner
            graphicsPath.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);

            // Right edge
            graphicsPath.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius);

            // Bottom-right corner
            graphicsPath.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);

            // Bottom edge
            graphicsPath.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom);

            // Bottom-left corner
            graphicsPath.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);

            // Left edge
            graphicsPath.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius);

            // Close the figure to complete the path
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        private void sfbtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void sfbtnAddFromRemote_Click(object sender, EventArgs e)
        {
            var packageJson = File.ReadAllText("D:\\.NET projects\\Basy\\Basy\\test\\package.json");
            Package package = JsonSerializer.Deserialize<Package>(packageJson);

            if (package != null)
            {
                pullPackage(package);
            }
        }

        private void pullPackage(Package package)
        {
            bool packageExists = addPackageIfNotExist(package);
            if (packageExists) 
            {
                MessageBox.Show("Package already exists!");
                return;
            }
            foreach (var template in package.Templates)
            {
                Utils.AddNewTemplate(template);
            }
            MessageBox.Show("Package successfully added!");
            PopulateGrid();
        }

        private bool addPackageIfNotExist(Package package)
        {
            bool packageExists = Utils.CheckExistanceOfPackageById(package.Id);
            if (packageExists) return true;
            Utils.AddNewPackage(package);
            return false;
        }

        private void sfBtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRaws = dGVPackages.SelectedRows;
            if (selectedRaws.Count > 0)
            {
                if (dGVPackages.SelectedRows.Count == 1)
                {
                    Guid id = (Guid)dGVPackages.SelectedRows[0].Cells["Id"].Value;

                    Package package = Utils.findPackageById(id);


                    if (package != null)
                    {
                        DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete {package.Name} Template?", "Delete", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (userConfirms == DialogResult.Yes)
                        {
                            Utils.deletePackageById(id);
                            Utils.LogToHistory(Operations.Delete, $"Template {package.Name}" +
                            $" has been deleted!");
                            dGVPackages.Refresh();
                            PopulateGrid();
                        }
                    }
                }
                else
                {
                    List<Guid> idList = new List<Guid>();

                    for (global::System.Int32 i = 0; i < selectedRaws.Count; i++)
                    {
                        Guid id = (Guid)selectedRaws[i].Cells["Id"].Value;
                        idList.Add(id);
                    }

                    if (idList.Count > 0)
                    {
                        DialogResult userConfirms = MessageBox.Show($"Are you sure you want to delete selected packages?", "Delete", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (userConfirms == DialogResult.Yes)
                        {
                            Utils.DeletePackagesByIdList(idList);
                            dGVPackages.Refresh();
                            PopulateGrid();
                        }
                    }
                }
            }
        }

        private void PopulateGrid()
        {
            packages.Clear();

            packages = Utils.GetAllPackages();

            dGVPackages.DataSource = packages;
        }
    }
}

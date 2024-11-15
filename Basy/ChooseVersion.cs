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
    public partial class ChooseVersion : Form
    {
        Template _templateToChooseVersions;
        List<TVersion> _versions;

        public ChooseVersion(Template template)
        {
            InitializeComponent();
            BringToFront();
            ShowInTaskbar = false;

            Deactivate += closeOnFocusLoose;

            _templateToChooseVersions = template;
            populateButtons();
        }

        private void closeOnFocusLoose(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            if (!Bounds.Contains(mousePosition))
            {
                Close();
            }
        }

        private void populateButtons()
        {
            if (_templateToChooseVersions != null)
            {
                _versions = Utils.GetAllVersionsByTemplateId(_templateToChooseVersions.Id);

                int rightMargin = 15;
                int bottomMargin = 20;
                int xPosition = lblPleaseChoose.Left - 15;
                int yPosition = lblPleaseChoose.Bottom + bottomMargin;

                foreach (TVersion version in _versions)
                {
                    Button button = new Button
                    {
                        Name = "btn" + version.Name,
                        Text = version.Name,
                        Size = new Size(100, 25),
                        Font = new Font("Microsoft Sans Serif", 10)
                    };

                    button.Location = new Point(xPosition, yPosition);

                    button.Click += (s, e) => {
                        if (!Utils.VersionHasParametersById(version.Id))
                        {
                            Utils.PasteTextAsync(version.Text);
                            Close();
                        }
                        else
                        {
                            ParametersTemplateWindow parametersTemplateWindow = new ParametersTemplateWindow(version.Text);
                            parametersTemplateWindow.Show();
                            Close();
                        }
                    };

                    Controls.Add(button);

                    xPosition += button.Width + rightMargin;
                }
            }
        }

        private void ChooseVersion_Load(object sender, EventArgs e)
        {
            Screen currentScreen = Screen.FromPoint(Cursor.Position);

            int centerX = currentScreen.Bounds.X + (currentScreen.Bounds.Width - this.Width) / 2;
            int centerY = currentScreen.Bounds.Y + (currentScreen.Bounds.Height - this.Height) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX, centerY);
        }
    }
}

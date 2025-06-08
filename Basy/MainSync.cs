using FontAwesome.Sharp;
using Syncfusion.WinForms.Controls;
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
    public partial class mainSync : SfForm
    {
        private IconButton _currentLeftBtn;
        private Panel _leftIconLine;
        private Color bkColor = ColorTranslator.FromHtml("#2B3D5B");

        public mainSync()
        {
            InitializeComponent();
        }

        private void FillUserControl(UserControl control)
        {
            mainContentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(control);

            pnlLeft.Controls.Add(_leftIconLine);
        }

        private void ActivateLeftBtn(IconButton senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableCurrentButton();

                _currentLeftBtn = senderBtn;
                string currentButtonText = _currentLeftBtn.Text;

                switch (currentButtonText)
                {
                    case "Templates":
                        FillUserControl(new TemplatesControl());
                        break;
                    case "Settings":
                        FillUserControl(new SettingsControl());
                        break;
                    case "History":
                        FillUserControl(new HistoryControl());
                        break;
                    case "How-To":
                        FillUserControl(new HowToControl());
                        break;
                    case "Packages":
                        FillUserControl(new PackagesControl());
                        break;
                }

                _currentLeftBtn.BackColor = Color.FromArgb(37, 36, 81);
                _currentLeftBtn.ForeColor = color;
                _currentLeftBtn.IconColor = color;

                lblCurrentControl.Text = _currentLeftBtn.Text;

                // left line

                _leftIconLine.BackColor = color;
                _leftIconLine.Location = new Point(0, _currentLeftBtn.Location.Y);
                _leftIconLine.Visible = true;
                _leftIconLine.BringToFront();
            }
        }

        private void DisableCurrentButton()
        {
            if (_currentLeftBtn != null)
            {
                _currentLeftBtn.BackColor = Color.FromArgb(45, 66, 91);
                _currentLeftBtn.ForeColor = Color.Cornsilk;
                _currentLeftBtn.IconColor = Color.Cornsilk;
            }
        }

        private void MainSync_Load(object sender, EventArgs e)
        {
            _leftIconLine = new Panel();
            _leftIconLine.Size = new Size(7, 66);

            Form form = this.Owner;

            this.Style.TitleBar.BackColor = bkColor;
            this.Style.TitleBar.ForeColor = Color.LightCyan;
            this.Style.TitleBar.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            this.Style.ShadowOpacity = 20;
            this.Style.InactiveShadowOpacity = 20;

            this.Style.TitleBar.BottomBorderColor = this.Style.BackColor;

            this.AllowRoundedCorners = true;

            this.Style.Border = new Pen(bkColor, 0);
            this.Style.BackColor = bkColor;
            this.Style.ForeColor = bkColor;
            this.Padding = new Padding(0);


            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

            form?.Close();

            ActivateLeftBtn(ibTemplates, Color.LightBlue);
        }

        private void mainSync_Activated(object sender, EventArgs e)
        {
            if (this.Style?.TitleBar != null)
            {
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#2B3D5B");
                this.Style.TitleBar.ForeColor = Color.Cyan;
            }
        }

        private void mainSync_Deactivate(object sender, EventArgs e)
        {
            if (this.Style?.TitleBar != null)
            {
                this.Style.TitleBar.BackColor = ColorTranslator.FromHtml("#2B3D5B");
                this.Style.TitleBar.ForeColor = Color.Cyan;
            }
        }

        private void ibHistory_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }

        private void ibSettings_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }

        private void ibTemplates_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }

        private void ibHowTo_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }
    }
}

using Basy.Models;
using FontAwesome.Sharp;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Basy
{
    public partial class Maineditorwindow : Form
    {
        private IconButton _currentLeftBtn;
        private Panel _leftIconLine;

        public Maineditorwindow()
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

                switch(currentButtonText)
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
                }

                _currentLeftBtn.BackColor = Color.FromArgb(37,36,81);
                _currentLeftBtn.ForeColor = color;
                _currentLeftBtn.IconColor = color;

                lblCurrentControl.Text = _currentLeftBtn.Text;

                // left line

                _leftIconLine.BackColor = color;
                _leftIconLine.Location = new Point(0,_currentLeftBtn.Location.Y);
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

        private void Maineditorwindow_Load(object sender, EventArgs e)
        {
            _leftIconLine = new Panel();
            _leftIconLine.Size = new Size(7, 66);

            Form form = this.Owner;

            form?.Close();

            ActivateLeftBtn(ibTemplates, Color.LightBlue);
        }

        private void lblHistory_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblHistory_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void ibHowTo_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            ActivateLeftBtn(btn, Color.LightBlue);
        }

        private void ibShare_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GeHa6yKuH/Basy");
        }
    }
}

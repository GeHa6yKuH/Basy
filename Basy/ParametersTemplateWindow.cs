using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Basy
{
    public partial class ParametersTemplateWindow : Form
    {
        private List<TextBox> _parameterTextBoxes = new List<TextBox>();
        private List<string> _parameters = new List<string>();
        private string _templateText;

        public ParametersTemplateWindow(string templateText)
        {
            InitializeComponent();
            _templateText = templateText;
            _parameters = Utils.GetAllParametersNamesFromTextBox(templateText);
        }

        private void ParametersTemplateWindow_Load(object sender, EventArgs e)
        {
            FillTemplatePannel();
        }

        private void FillTemplatePannel()
        {
            pnlTemplate.Controls.Clear();
            pnlTemplate.AutoScroll = true;

            int x = 0;
            int y = 0;
            int panelWidth = pnlTemplate.ClientSize.Width;
            int spacing = 10;

            int lastIndex = 0;
            foreach (string parameter in _parameters)
            {
                int paramStart = _templateText.IndexOf($"/{parameter}/", lastIndex);
                if (paramStart == -1) continue;

                if (paramStart > lastIndex)
                {
                    string textSegment = _templateText.Substring(lastIndex, paramStart - lastIndex);
                    string[] lines = textSegment.Split('\n');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        if (!string.IsNullOrEmpty(line))
                        {
                            Label lblText = new Label
                            {
                                Text = line,
                                Font = new Font("Verdana", 12),
                                AutoSize = true
                            };

                            if (x + lblText.PreferredWidth > panelWidth)
                            {
                                x = 0;
                                y += lblText.Height + spacing;
                            }

                            lblText.Location = new Point(x, y);
                            pnlTemplate.Controls.Add(lblText);
                            x += lblText.PreferredWidth + spacing;

                            int lastLabelHeight = lblText.Height;

                            if (i != lines.Length - 1)
                            {
                                x = 0;
                                y += lastLabelHeight + spacing;
                            }
                        }
                    }
                }

                TextBox txtParameter = new TextBox
                {
                    Width = 100,
                    Tag = parameter,
                    Font = new Font("Verdana", 12)
                };

                if (x + txtParameter.Width > panelWidth)
                {
                    x = 0;
                    y += txtParameter.Height + spacing;
                }

                txtParameter.Location = new Point(x, y);
                pnlTemplate.Controls.Add(txtParameter);
                _parameterTextBoxes.Add(txtParameter);
                x += txtParameter.Width + spacing;

                lastIndex = paramStart + parameter.Length + 2;
            }


            if (lastIndex < _templateText.Length)
            {
                string trailingText = _templateText.Substring(lastIndex);
                string[] lines = trailingText.Split('\n');

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (!string.IsNullOrEmpty(line))
                    {
                        Label lblText = new Label
                        {
                            Text = line,
                            Font = new Font("Verdana", 12),
                            AutoSize = true
                        };

                        if (x + lblText.PreferredWidth > panelWidth)
                        {
                            x = 0;
                            y += lblText.Height + spacing;
                        }

                        lblText.Location = new Point(x, y);
                        pnlTemplate.Controls.Add(lblText);
                        x += lblText.PreferredWidth + spacing;

                        int lastLabelHeight = lblText.Height;

                        if (i != lines.Length - 1)
                        {
                            x = 0;
                            y += lastLabelHeight + spacing;
                        }
                    }
                }
            }
        }

        private void mtbCopy_Click(object sender, EventArgs e)
        {
            string finalText = _templateText;

            foreach (TextBox textBox in _parameterTextBoxes)
            {
                string parameter = textBox.Tag.ToString();
                finalText = finalText.Replace($"/{parameter}/", textBox.Text);
            }

            Utils.PasteTextAsync(finalText);
            this.Close();
        }
    }
}

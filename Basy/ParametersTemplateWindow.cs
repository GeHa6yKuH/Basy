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
            int yPosition = 0;
            int spacing = 10;

            int lastIndex = 0;
            foreach (string parameter in _parameters)
            {
                int paramStart = _templateText.IndexOf($"/{parameter}/", lastIndex);
                if (paramStart == -1) continue;

                if (paramStart > lastIndex)
                {
                    Label lblText = new Label
                    {
                        Text = _templateText.Substring(lastIndex, paramStart - lastIndex),
                        AutoSize = true
                    };
                    pnlTemplate.Controls.Add(lblText);
                    yPosition += lblText.Height + spacing;
                }

                TextBox txtParameter = new TextBox
                {
                    Width = 100,
                    Tag = parameter,
                    Location = new Point(0, yPosition)
                };
                _parameterTextBoxes.Add(txtParameter);
                pnlTemplate.Controls.Add(txtParameter);
                yPosition += txtParameter.Height + spacing;

                lastIndex = paramStart + parameter.Length + 2;
            }

            if (lastIndex < _templateText.Length)
            {
                Label lblText = new Label
                {
                    Text = _templateText.Substring(lastIndex),
                    AutoSize = true,
                    Location = new Point(0, yPosition)
                };
                pnlTemplate.Controls.Add(lblText);
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

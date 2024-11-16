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
    public partial class ClipBoardPopup : Form
    {
        private List<BasyClip> _clips = new List<BasyClip>();

        public ClipBoardPopup()
        {
            InitializeComponent();
            TopMost = true;
            BringToFront();

            lbClips.Click += PasteClip;
        }

        private void PasteClip(object sender, EventArgs e)
        {
            if (lbClips.SelectedItem != null)
            {
                var selectedItem = lbClips.SelectedItem;

                if (selectedItem is BasyClip clip)
                {
                    if (clip.Value is string text)
                    {
                        Utils.PasteTextAsync(text);
                    }
                    else if (clip.Value is Image image)
                    {
                        Clipboard.SetImage(image);
                        MessageBox.Show("image copied to clipboard");
                    }
                }
                Close();
            }
        }

        private void PopulateListBox()
        {
            lbClips.Items.Clear();

            foreach (var clip in _clips)
            {
                lbClips.Items.Add(clip);
            }
        }

        private void ClipBoardPopup_Load(object sender, EventArgs e)
        {
            _clips = BasyClipboard._clips;
            PopulateListBox();
        }
    }
}

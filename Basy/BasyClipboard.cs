using Basy.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basy
{
    public static class BasyClipboard
    {
        public static List<BasyClip> _clips { get; } = new List<BasyClip>();

        private static Timer _timer;
        private static object _lastClipboardContent;
        private static string _lastImageName;
        private static int _maxAmount = 9;

        public static void StartClipboardMonitoring()
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += AddClipsToList;
            _timer.Start();
        }

        public static void StopClipboardMonitoring()
        {
            _timer.Stop();
        }

        private static void AddClipsToList(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                if (_lastClipboardContent == null || !_lastClipboardContent.Equals(text))
                {
                    if (_clips.Count >= _maxAmount)
                    {
                        _clips.RemoveAt(0);
                    }

                    _lastClipboardContent = text;
                    _clips.Add(new BasyClip { Name = text, Value = text });
                }
            }
            else if (Properties.Settings.Default.SaveImagesToClips)
            {
                IDataObject clipboardData = Clipboard.GetDataObject();
                if (clipboardData != null)
                {
                    if (clipboardData.GetDataPresent(DataFormats.FileDrop))
                    {
                        string[] files = (string[])clipboardData.GetData(DataFormats.FileDrop);
                        foreach (string file in files)
                        {
                            if (file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                            {
                                if (_lastImageName == null || file != _lastImageName)
                                {
                                    _lastImageName = file;
                                    Image image = Image.FromFile(file);

                                    if (_lastClipboardContent == null || !(_lastClipboardContent is Image lastImage && image.Equals(lastImage)))
                                    {
                                        _lastClipboardContent = image;
                                        string fileName = Path.GetFileName(file);

                                        if (_clips.Count >= _maxAmount)
                                        {
                                            _clips.RemoveAt(0);
                                        }

                                        _clips.Add(new BasyClip { Name = fileName, Value = image });
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}

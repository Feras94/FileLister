using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesLister
{
    public partial class MainForm : Form
    {
        public struct SearchParamaters
        {
            public string Extension { get; set; }
            public string StartPath { get; set; }
            public string OutputPath { get; set; }
            public bool OutputRelative { get; set; }
            public string Prefix { get; set; }
            public string Suffix { get; set; }
            public bool OpenWhenDone { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;

            var startParamaters = new SearchParamaters
            {
                Extension = txtExtension.Text,
                OutputPath = txtOutputPath.Text,
                StartPath = txtStartPath.Text,
                OutputRelative = checkIsRelative.Checked,
                Prefix = txtPrefix.Text,
                Suffix = txtSuffix.Text,
                OpenWhenDone = checkOpenWhenDone.Checked,
            };

            await Task.Run(() =>
            {
                DoWork(startParamaters);
            });

            progressBar.Visible = false;
        }

        private void DoWork(SearchParamaters info)
        {
            if (string.IsNullOrWhiteSpace(info.StartPath) ||
                string.IsNullOrWhiteSpace(info.Extension) ||
                string.IsNullOrWhiteSpace(info.OutputPath)
                )
                return;

            var startNode = new DirectoryInfo(info.StartPath);
            var folderStack = new Stack<DirectoryInfo>();
            folderStack.Push(startNode);

            var filesPaths = new List<string>();

            while (folderStack.Count > 0)
            {
                var node = folderStack.Pop();
                foreach (var subNodes in node.GetDirectories())
                    folderStack.Push(subNodes);

                filesPaths.AddRange(from file in node.GetFiles() where file.Extension.Equals(info.Extension) select file.FullName);
            }

            using (var fileWriter = new StreamWriter(info.OutputPath))
            {
                foreach (var filePath in filesPaths)
                {
                    var path = info.OutputRelative ? filePath.Replace(info.StartPath, "") : filePath;
                    var finalName = $"{info.Prefix}\"{path}\"{info.Suffix}";
                    fileWriter.WriteLine(finalName);
                }
            }

            if (info.OpenWhenDone)
            {
                var procStartInfo = new ProcessStartInfo(info.OutputPath);
                var process = new Process { StartInfo = procStartInfo };
                process.Start();
            }
        }
    }
}

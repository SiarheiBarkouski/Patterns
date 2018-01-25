using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesFactory;

namespace WinFormsTester
{
    public partial class Form1 : Form
    {
        private string AudioFilePath { get; set; }
        private readonly ServiceFactory _factory;

        public Form1()
        {
            InitializeComponent();
            _factory = new ServiceFactory();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var x = _factory.GetAudioService();
            var y = _factory.GetMessageBoxService();
            y.CatchException(() => x.Play(AudioFilePath));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var x = _factory.GetFileService();
            x.WriteFile(AudioFilePath, Environment.CurrentDirectory + $"//result.mp3");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AudioFilePath = ofd.FileName;

            var info = _factory.GetAudioService().GetAudioFileInfo(AudioFilePath);

            tbAudio.Text = $"File name: {info.Name}{Environment.NewLine}" +
                           $"Duration: {info.Duration.Minutes}:{info.Duration.Seconds}{Environment.NewLine}" +
                           $"File size: {info.FileSize} MB";
            }
        }
    }
}

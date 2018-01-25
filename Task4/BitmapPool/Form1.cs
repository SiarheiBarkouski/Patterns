using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapPool
{
    public partial class Form1 : Form
    {
        private readonly BitmapsPool _pool;
        public Form1()
        {
            InitializeComponent();
            _pool = new BitmapsPool(4);
        }

        private void btnGetImages_Click(object sender, EventArgs e)
        {
            pbOriginal.Image = _pool.BitmapList[0];
            pbNegative.Image = _pool.BitmapList[1];
            pbRotatedLeft.Image = _pool.BitmapList[2];
            pbRotatedRight.Image = _pool.BitmapList[3];
        }

        private void pb_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JPG | *.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ((PictureBox)sender).Image.Save(sfd.FileName);
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pool.Initialize(new Bitmap(ofd.FileName));
            }
        }
    }
}

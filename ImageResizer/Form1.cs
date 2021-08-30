using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        private List<string> Files = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInputFolderPath.Text))
                    throw new Exception("Input folder path is empty.");

                if (string.IsNullOrEmpty(txtOutputFolderPath.Text))
                    throw new Exception("Output folder path is empty.");

                ConvertImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertImages()
        {
            foreach (var file in Files)
                try
                {
                    ResizeImageAndSave((int)numWidth.Value, (int)numHeight.Value, file);
                }
                catch
                {
                    ;
                }
        }

        public void ResizeImageAndSave(int newWidth, int newHeight, string imagePath)
        {
            using (Image src = Image.FromFile(imagePath))
            using (Bitmap dst = new Bitmap(newWidth, newHeight))
            using (Graphics g = Graphics.FromImage(dst))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(src, 0, 0, dst.Width, dst.Height);
                dst.Save(Path.Combine(txtOutputFolderPath.Text, Path.GetFileName(imagePath)), ImageFormat.Png);
            }
        }

        private void btnSelectInputFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Files = Directory.GetFiles(fbd.SelectedPath)?.ToList();
                    txtInputFolderPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtOutputFolderPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}

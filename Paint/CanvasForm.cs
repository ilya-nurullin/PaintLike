using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class CanvasForm : Form
    {
        private Graphics g;

        private int old_x, old_y, new_x, new_y;

        public string FilePath;
        public bool IsChanged = false;
        public bool IsEmpty = true;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            old_x = e.X;
            old_y = e.Y;
            IsEmpty = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm.currentDrawMethod?.Invoke(e, g, MainForm.currentColor, MainForm.currentSize, ref old_x, ref old_y, pictureBox);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.afterMouseUp?.Invoke(e, g, MainForm.currentColor, MainForm.currentSize, ref old_x, ref old_y, pictureBox);
            IsChanged = true;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(pictureBox.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
        }

        public void ZoomIn()
        {
            pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Image.Width * 2, pictureBox.Image.Height * 2);
            g = Graphics.FromImage(pictureBox.Image);
            pictureBox.Refresh();
            Width = pictureBox.Image.Width;
            Height = pictureBox.Image.Height;
        }

        public void ZoomOut()
        {
            pictureBox.Image = new Bitmap(pictureBox.Image, pictureBox.Image.Width / 2, pictureBox.Image.Height / 2);
            g = Graphics.FromImage(pictureBox.Image);
            pictureBox.Refresh();
            Width = pictureBox.Image.Width;
            Height = pictureBox.Image.Height;
        }


        public void EmbossEffect()
        {
            var old_text = Text;
            var bmap = new Bitmap(pictureBox.Image);
            pictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(pictureBox.Image);
            int i = 0;
            int j = 0;
            int DispX = 1;
            int DispY = 1;
            int red = 0;
            int green = 0;
            int blue = 0;
            var _with1 = tempbmp;
            for (i = 0; i <= _with1.Height - 2; i++)
            {
                for (j = 0; j <= _with1.Width - 2; j++)
                {
                    System.Drawing.Color pixel1 = default(System.Drawing.Color);
                    System.Drawing.Color pixel2 = default(System.Drawing.Color);
                    pixel1 = _with1.GetPixel(j, i);
                    pixel2 = _with1.GetPixel(j + DispX, i + DispY);
                    red = Math.Min(Math.Abs(Convert.ToInt32(pixel1.R) - Convert.ToInt32(pixel2.R)) + 128, 255);
                    green = Math.Min(Math.Abs(Convert.ToInt32(pixel1.G) - Convert.ToInt32(pixel2.G)) + 128, 255);
                    blue = Math.Min(Math.Abs(Convert.ToInt32(pixel1.B) - Convert.ToInt32(pixel2.B)) + 128, 255);
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }

                if (i % 10 == 0)
                {
                    pictureBox.Invalidate();
                    pictureBox.Refresh();
                    Text = (100 * i / (pictureBox.Image.Height - 2)) + @"%";
                }
            }
            pictureBox.Refresh();
            Text = old_text;
            g = Graphics.FromImage(pictureBox.Image);
        }

        public void SharpenEffect()
        {
            var old_text = Text;
            var bmap = new Bitmap(pictureBox.Image);
            pictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(pictureBox.Image);
            int DX = 1;
            int DY = 1;
            int red = 0;
            int green = 0;
            int blue = 0;

            int i = 0;
            int j = 0;
            var _with1 = tempbmp;
            for (i = DX; i <= _with1.Height - DX - 1; i++)
            {
                for (j = DY; j <= _with1.Width - DY - 1; j++)
                {
                    red = (int) (Convert.ToInt32(_with1.GetPixel(j, i).R) + 0.5 * Convert.ToInt32((_with1.GetPixel(j, i).R) - Convert.ToInt32(_with1.GetPixel(j - DX, i - DY).R)));
                    green = (int) (Convert.ToInt32(_with1.GetPixel(j, i).G) + 0.7 * Convert.ToInt32((_with1.GetPixel(j, i).G) - Convert.ToInt32(_with1.GetPixel(j - DX, i - DY).G)));
                    blue = (int) (Convert.ToInt32(_with1.GetPixel(j, i).B) + 0.5 * Convert.ToInt32((_with1.GetPixel(j, i).B - Convert.ToInt32(_with1.GetPixel(j - DX, i - DY).B))));
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox.Invalidate();
                    Text = (100 * i / (pictureBox.Image.Height - 2)) + "%";
                    pictureBox.Refresh();
                }
            }
            pictureBox.Refresh();
            Text = old_text;
            g = Graphics.FromImage(pictureBox.Image);
        }

        public void SmoothEffect()
        {
            var old_text = Text;
            var bmap = new Bitmap(pictureBox.Image);
            pictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(pictureBox.Image);
            int DX = 1;
            int DY = 1;
            int red = 0;
            int green = 0;
            int blue = 0;

            int i = 0;
            int j = 0;
            var _with1 = tempbmp;
            for (i = DX; i <= _with1.Height - DX - 1; i++)
            {
                for (j = DY; j <= _with1.Width - DY - 1; j++)
                {
                    red = Convert.ToInt32((Convert.ToInt32(_with1.GetPixel(j - 1, i - 1).R) + Convert.ToInt32(_with1.GetPixel(j - 1, i).R) + Convert.ToInt32(_with1.GetPixel(j - 1, i + 1).R) + Convert.ToInt32(_with1.GetPixel(j, i - 1).R) + Convert.ToInt32(_with1.GetPixel(j, i).R) + Convert.ToInt32(_with1.GetPixel(j, i + 1).R) + Convert.ToInt32(_with1.GetPixel(j + 1, i - 1).R) + Convert.ToInt32(_with1.GetPixel(j + 1, i).R) + Convert.ToInt32(_with1.GetPixel(j + 1, i + 1).R)) / 9);

                    green = Convert.ToInt32((Convert.ToInt32(_with1.GetPixel(j - 1, i - 1).G) + Convert.ToInt32(_with1.GetPixel(j - 1, i).G) + Convert.ToInt32(_with1.GetPixel(j - 1, i + 1).G) + Convert.ToInt32(_with1.GetPixel(j, i - 1).G) + Convert.ToInt32(_with1.GetPixel(j, i).G) + Convert.ToInt32(_with1.GetPixel(j, i + 1).G) + Convert.ToInt32(_with1.GetPixel(j + 1, i - 1).G) + Convert.ToInt32(_with1.GetPixel(j + 1, i).G) + Convert.ToInt32(_with1.GetPixel(j + 1, i + 1).G)) / 9);

                    blue = Convert.ToInt32((Convert.ToInt32(_with1.GetPixel(j - 1, i - 1).B) + Convert.ToInt32(_with1.GetPixel(j - 1, i).B) + Convert.ToInt32(_with1.GetPixel(j - 1, i + 1).B) + Convert.ToInt32(_with1.GetPixel(j, i - 1).B) + Convert.ToInt32(_with1.GetPixel(j, i).B) + Convert.ToInt32(_with1.GetPixel(j, i + 1).B) + Convert.ToInt32(_with1.GetPixel(j + 1, i - 1).B) + Convert.ToInt32(_with1.GetPixel(j + 1, i).B) + Convert.ToInt32(_with1.GetPixel(j + 1, i + 1).B)) / 9);
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox.Invalidate();
                    pictureBox.Refresh();
                    Text = (100 * i / (pictureBox.Image.Height - 2)) + "%";
                }
            }
            pictureBox.Refresh();

            Text = old_text;
            g = Graphics.FromImage(pictureBox.Image);
        }

        public void DiffuseEffect()
        {
            var old_text = Text;
            var bmap = new Bitmap(pictureBox.Image);
            pictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(pictureBox.Image);
            int i = 0;
            int j = 0;
            int DX = 0;
            int DY = 0;
            int red = 0;
            int green = 0;
            int blue = 0;
            var _with1 = tempbmp;

            Random random = new Random();

            for (i = 3; i <= _with1.Height - 3; i++)
            {
                for (j = 3; j <= _with1.Width - 3; j++)
                {
                    DX = (int)(random.NextDouble() * 4 - 2);
                    DY = (int)(random.NextDouble() * 4 - 2);
                    red = _with1.GetPixel(j + DX, i + DY).R;
                    green = _with1.GetPixel(j + DX, i + DY).G;
                    blue = _with1.GetPixel(j + DX, i + DY).B;
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                this.Text = (100 * i / (_with1.Height - 2)) + "%";
                if (i % 10 == 0)
                {
                    pictureBox.Invalidate();
                    pictureBox.Refresh();
                    this.Text = (100 * i / (pictureBox.Image.Height - 2)) + "%";
                }
            }
            pictureBox.Refresh();

            Text = old_text;
            g = Graphics.FromImage(pictureBox.Image);
        }

        public void RotateLeft()
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Width = pictureBox.Height * pictureBox.Image.Width / pictureBox.Image.Height;
            pictureBox.Refresh();
        }

        public void RotateRIght()
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Width = pictureBox.Height * pictureBox.Image.Width / pictureBox.Image.Height;
            pictureBox.Refresh();
        }

        public void FlipX()
        {
            pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox.Width = pictureBox.Height * pictureBox.Image.Width / pictureBox.Image.Height;
            pictureBox.Refresh();
        }

        public void FlipY()
        {
            pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox.Width = pictureBox.Height * pictureBox.Image.Width / pictureBox.Image.Height;
            pictureBox.Refresh();
        }

        private Bitmap OpenBitmapFromFile()
        {
            var fs = new FileStream(FilePath, FileMode.Open);
            var bm = new Bitmap(fs, false);
            fs.Close();
            return bm;
        }

        public void OpenFile()
        {
            var OpenFileDialog1 = new OpenFileDialog {Filter = @"Images|*.GIF;*.TIF;*.JPG;*.PNG;*.BPM"};
            OpenFileDialog1.ShowDialog();
            if (string.IsNullOrEmpty(OpenFileDialog1.FileName))
                return;
            FilePath = OpenFileDialog1.FileName;
            pictureBox.Image = OpenBitmapFromFile();
            pictureBox.Width = pictureBox.Height * pictureBox.Image.Width / pictureBox.Image.Height;
            g = Graphics.FromImage(pictureBox.Image);
            Width = pictureBox.Image.Width;
            Height = pictureBox.Image.Height;
            Text = OpenFileDialog1.FileName;
        }

        private void CanvasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((FilePath == null || IsChanged) && ! IsEmpty)
            {
                switch (MessageBox.Show($"Сохранить файл {Text}?", "Сохранить?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel = true; break;
                    case DialogResult.Yes: var s = (Save()) ? e.Cancel = false : e.Cancel = true; break;
                }
            }
        }

        public bool Save()
        {
            IsChanged = false;
            if (FilePath == null)
            {
                return SaveAs();
            }
            else
            {
                pictureBox.Image.Save(FilePath);
                return true;
            }
            return false;
        }

        public bool SaveAs()
        {
            var dialog = new SaveFileDialog
            {
                Filter = @"PNG файл|*.png|JPEG файл|*.jpeg",
                FileName = Text
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
                Save();
                IsChanged = false;
                return true;
            }
            return false;
        }

        public CanvasForm()
        {
            InitializeComponent();
        }
    }
}

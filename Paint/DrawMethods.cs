using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class DrawMethods
    {
        public static void DrawByPen(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentSize < 5)
                    g.DrawLine(new Pen(currentColor, currentSize), old_x, old_y, e.X, e.Y);
                else
                    g.DrawEllipse(new Pen(currentColor, currentSize), e.X, e.Y, currentSize, currentSize);
                
                old_x = e.X;
                old_y = e.Y;
                pictureBox.Refresh();
            }
        }

        public static void Eraser(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentSize < 5)
                    g.DrawLine(new Pen(Color.White, currentSize), old_x, old_y, e.X, e.Y);
                else
                    g.DrawEllipse(new Pen(Color.White, currentSize), e.X, e.Y, currentSize, currentSize);

                old_x = e.X;
                old_y = e.Y;
                pictureBox.Refresh();
            }
        }

        public static void DrawLine(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(new Pen(currentColor, currentSize), old_x, old_y, e.X, e.Y);
                pictureBox.Refresh();
            }
        }
        public static void DrawEllipse(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox)
        {

            if (e.Button == MouseButtons.Left)
            {
                g.DrawEllipse(new Pen(currentColor, currentSize), old_x, old_y, e.X - old_x, e.Y - old_y);
                pictureBox.Refresh();
            }
        }

        public static void DrawStar(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x,
            ref int old_y, PictureBox pictureBox)
        {
            float r = (float) Math.Sqrt(Math.Pow(old_x - e.X, 2) + Math.Pow(old_y - e.Y, 2));
            int ox = (old_x + e.X) / 2;
            int oy = (old_y + e.Y) / 2;
            if (e.Button == MouseButtons.Left)
            {
                float[] x = new float[5], y = new float[5];
                for (int i = 0; i < 5; i++)
                {
                    x[i] = (float)(r * Math.Sin(2 * Math.PI / 5 * i) + ox);
                    y[i] = (float)(r * -Math.Cos(2 * Math.PI / 5 * i) + oy);
                }

                g.DrawLine(new Pen(currentColor, currentSize), x[0], y[0], x[2], y[2]);
                g.DrawLine(new Pen(currentColor, currentSize), x[0], y[0], x[3], y[3]);
                g.DrawLine(new Pen(currentColor, currentSize), x[1], y[1], x[3], y[3]);
                g.DrawLine(new Pen(currentColor, currentSize), x[1], y[1], x[4], y[4]);
                g.DrawLine(new Pen(currentColor, currentSize), x[2], y[2], x[4], y[4]);

                pictureBox.Refresh();
            }
        }
    }
}

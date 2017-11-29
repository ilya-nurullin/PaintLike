using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        public static Color currentColor = Color.Red;
        public static DrawMethod currentDrawMethod = DrawMethods.DrawByPen;
        public static DrawMethod afterMouseUp;
        public static float currentSize = 2;
        public static int currentWinNumber = 1;

        public delegate void DrawMethod(MouseEventArgs e, Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox);
        public delegate void AfterMouseUp(Graphics g, Color currentColor, float currentSize, ref int old_x, ref int old_y, PictureBox pictureBox);

        private static List<ToolStripButton> toolStripButtons = new List<ToolStripButton>();

        public MainForm()
        {
            InitializeComponent();

            toolStripButtons.AddRange(new []{ pensilStripButton, lineStripButton, starStripButton,
                elipseStripButton, starStripButton, eraserStripButton });

#if DEBUG
            OpenNewChild();
#endif
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewChild();
        }

        private void OpenNewChild()
        {
            var frm = new CanvasForm { MdiParent = this, Text = @"Безымянный " + currentWinNumber };
            frm.Show();
            currentWinNumber++;
        }

        private void chooseColorStripButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
                chooseColorStripButton.BackColor = currentColor;
            }
        }

        private void pensilStripButton_Click(object sender, EventArgs e)
        {
            currentDrawMethod = DrawMethods.DrawByPen;
            selectTool((ToolStripButton)sender);
        }

        private void sizeComboBox_TextChanged(object sender, EventArgs e)
        {
            int res;

            if (int.TryParse(sizeComboBox.Text, out res))
            {
                currentSize = int.Parse(sizeComboBox.Text);
            }
            else
            {
                MessageBox.Show(@"Ожидалось число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sizeComboBox.Text = currentSize.ToString();
            }
        }

        private void resetToolSelection()
        {
            toolStripButtons.ForEach(e => e.BackColor = SystemColors.Control);
        }

        private void selectTool(ToolStripButton e)
        {
            resetToolSelection();
            e.BackColor = SystemColors.ControlLight;
        }

        private void eraserStripButton_Click(object sender, EventArgs e)
        {
            currentDrawMethod = DrawMethods.Eraser;
            selectTool((ToolStripButton)sender);
        }

        private void zoomInStripButton_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.ZoomIn();
        }

        private void zoomOutStripButton_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.ZoomOut();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void эффект1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.EmbossEffect();
        }

        private void эффект2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.SharpenEffect();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null || ! ((CanvasForm)ActiveMdiChild).IsEmpty)
            {
                OpenNewChild();
            }
            ((CanvasForm)ActiveMdiChild)?.OpenFile();
        }

        private void эффект3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.SmoothEffect();
        }

        private void диффузноеОтражениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.DiffuseEffect();
        }

        private void повернутьНалевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm) ActiveMdiChild)?.RotateLeft();
        }

        private void повернутьGjЧасовойСтрелкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.RotateRIght();
        }

        private void отразитьПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.FlipY();
        }

        private void отразитьПоГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.FlipX();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.Save();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((CanvasForm)ActiveMdiChild)?.SaveAs();
        }

        private void lineStripButton_Click(object sender, EventArgs e)
        {
            currentDrawMethod = null;
            afterMouseUp = DrawMethods.DrawLine;
            selectTool((ToolStripButton)sender);
        }

        private void elipseStripButton_Click(object sender, EventArgs e)
        {
            currentDrawMethod = null;
            afterMouseUp = DrawMethods.DrawEllipse;
            selectTool((ToolStripButton)sender);
        }

        private void starStripButton_Click(object sender, EventArgs e)
        {
            currentDrawMethod = null;
            afterMouseUp = DrawMethods.DrawStar;
            selectTool((ToolStripButton)sender);
        }
    }
}

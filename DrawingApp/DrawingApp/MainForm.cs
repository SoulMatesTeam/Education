using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class MainForm : Form
    {
        Bitmap bitmap;
        Graphics bitmapCanvas;
        Graphics controlCanvas;
        List<Point> points;
        Point mousePreviousPosition;
        DrawingMode drawingMode;
        bool isDrawing;
        float penSize;
        Color penColor;

        public MainForm()
        {
            InitializeComponent();
            controlCanvas = pbCanvas.CreateGraphics();
            bitmap = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            bitmapCanvas = Graphics.FromImage(bitmap);

            points = new List<Point>();
            mousePreviousPosition = new Point();
            drawingMode = DrawingMode.FreeDrawing;
            isDrawing = false;
            penSize = 1f;
            penColor = Color.Black;
            cbColor.SelectedIndex = 0;
            
        }

        private void PnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            switch (drawingMode)
            {
                case DrawingMode.FreeDrawing:
                    FreeDrawing(e);
                    break;
                case DrawingMode.DrawByDots:
                    break;
                default:
                    break;
            }

            mousePreviousPosition = e.Location;
        }

        private void FreeDrawing(MouseEventArgs e)
        {
            if (isDrawing)
            {
                controlCanvas.DrawLine(new Pen(penColor, penSize), mousePreviousPosition, e.Location);
                points.Add(e.Location);
            }
        }

        private void PnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void PnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            bitmapCanvas.DrawLines(new Pen(new SolidBrush(penColor)), points.ToArray());
            points.Clear();
            controlCanvas.Clear(Color.White);
            pbCanvas.Image = bitmap;
        }

        private void BtPen_Click(object sender, EventArgs e)
        {
            drawingMode = DrawingMode.FreeDrawing;
        }

        private void pbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (drawingMode)
            {
                case DrawingMode.FreeDrawing:
                    break;
                case DrawingMode.DrawByDots:
                    DrawByDots(e);
                    break;
                default:
                    break;
            }
        }

        private void DrawByDots(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                controlCanvas.FillEllipse(Brushes.Black, new RectangleF(new PointF(e.X - 2.5f, e.Y - 2.5f), new Size(5, 5)));
            }

            if (e.Button == MouseButtons.Right)
            {
                controlCanvas.DrawLines(new Pen(penColor, penSize), points.ToArray());
                points.Clear();
            }
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            controlCanvas.Clear(Color.White);
        }

        private void btDrawByDots_Click(object sender, EventArgs e)
        {
            drawingMode = DrawingMode.DrawByDots;
        }

        private void tbPenSize_ValueChanged(object sender, EventArgs e)
        {
            penSize = (float)tbPenSize.Value;
            lbPenSize.Text = tbPenSize.Value.ToString();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            penColor = Color.FromName(cbColor.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images (*.png)|*.png";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}

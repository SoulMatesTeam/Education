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
        List<Shape> _shapes;
        List<Point> points;
        Point mousePreviousPosition;
        DrawingMode drawingMode;
        bool isDrawing;
        float penSize;
        Color penColor;
        Color backGroundColor;


        public MainForm()
        {
            InitializeComponent();
            controlCanvas = pbCanvas.CreateGraphics();
            bitmap = new Bitmap(pbCanvas.Width, pbCanvas.Height);
            bitmapCanvas = Graphics.FromImage(bitmap);

            points = new List<Point>();
            _shapes = new List<Shape>();

            mousePreviousPosition = new Point();
            drawingMode = DrawingMode.FreeDrawing;
            isDrawing = false;
            penSize = 1f;
            penColor = Color.Black;
            backGroundColor = Color.White;

            cbColor.SelectedIndex = 0;
            cbBgColor.SelectedIndex = 0;


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

            if(drawingMode == DrawingMode.FreeDrawing)
            {
                if (points.Count < 2)
                {
                    points.Clear();
                    return;
                }

                _shapes.Add(new Shape(points.ToArray()));
                points.Clear();
            }

            DrawShapes();
        }

        private void DrawShapes()
        {
            bitmapCanvas.Clear(backGroundColor);
            foreach (var shape in _shapes)
            {
                shape.Draw(new Pen(new SolidBrush(penColor), penSize), bitmapCanvas);
            }

            controlCanvas.Clear(backGroundColor);
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
                _shapes.Add(new Shape(points.ToArray()));
                points.Clear();
                DrawShapes();
            }
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            controlCanvas.Clear(Color.White);
            bitmapCanvas.Clear(Color.White);
            backGroundColor = Color.White;
            _shapes.Clear();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Images (*.png)|*.png| Images(*.jpg)|*.jpg";
            saveFileDialog1.Title = "Save an Image File";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);

                MessageBox.Show("Файл сохранен");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName), pbCanvas.Width, pbCanvas.Height);
                bitmapCanvas = Graphics.FromImage(bitmap);
                pbCanvas.Image = bitmap;
            }
        }

        private void cbBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            backGroundColor = Color.FromName(cbBgColor.Text);
            DrawShapes();
        }
    }
}

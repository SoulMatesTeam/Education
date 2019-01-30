using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DrawingApp
{
    public class Shape
    {
        private Point[] _points;
        
        public Shape(Point[] points)
        {
            _points = points;
        }

        public void Draw(Pen pen, Graphics canvas)
        {
            canvas.DrawLines(pen, _points);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Ellipse : SymFigures
    {
        private Point start { get; set; }
        private Point finish { get; set; }
        private Brush brush { get; set; }
        private Ellipse(float thickness, PointF start, PointF finish, Color color, Color colorFill) : base(thickness, color)
        {
            PointF startPoint = new PointF(Math.Min(start.X, finish.X), Math.Min(start.Y, finish.Y));
            PointF finishPoint = new PointF(Math.Max(start.X, finish.X), Math.Max(start.Y, finish.Y));

            startPoint = start;
            finishPoint = finish;

            pen = new Pen(color, thickness);
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            float width = finish.X - start.X;
            float height = finish.Y - start.Y;

            graphics.DrawEllipse(pen, start.X, start.Y, width, height);
            graphics.FillEllipse(brush, start.X, start.Y, width, height);
        }
    }
}

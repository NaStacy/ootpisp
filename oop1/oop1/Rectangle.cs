using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class Rectangle : SymFigures
    {
        private Brush brush { get; set; }


        public Rectangle(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            Point LeftPoint = new Point(Math.Min(point[0].X, point[1].X), Math.Min(point[0].Y, point[1].Y));
            Point RightPoint = new Point(Math.Max(point[0].X, point[1].X), Math.Max(point[0].Y, point[1].Y));

            graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
            graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
        }
    }
}

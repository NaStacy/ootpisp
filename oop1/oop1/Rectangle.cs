using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Rectangle : SymFigures
    {
        private Brush brush { get; set; }
        private Point start { get; set; }
        private Point finish { get; set; }
        private Rectangle(float thickness, Color color, Color colorFill, Point start, Point finish) : base(thickness, color)
        {
            brush = new SolidBrush(colorFill);
            this.start = start;
            this.finish = finish;
        }
        public override void Draw(Graphics graphics)
        {
            int width = Math.Abs(start.X - finish.X);
            int length = Math.Abs(start.Y - finish.Y);

            graphics.DrawRectangle(pen, start.X, start.Y, width, length);
            graphics.FillRectangle(brush, start.X, start.Y, width, length);
        }

    }
}

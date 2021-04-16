using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class Ellipse : SymFigures
    {
        private Brush brush { get; set; }

        public Ellipse(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            float width = point[1].X - point[0].X;
            float height = point[1].Y - point[0].Y;
            
            graphics.FillEllipse(brush, point[0].X, point[0].Y, width, height);
            graphics.DrawEllipse(pen, point[0].X, point[0].Y, width, height);
            
        }
    }
}

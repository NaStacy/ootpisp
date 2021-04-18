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
            float width = endPoint.X - startPoint.X;
            float height = endPoint.Y - startPoint.Y;
            
            graphics.FillEllipse(brush, startPoint.X, startPoint.Y, width, height);
            graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, width, height);
            
        }
    }
}

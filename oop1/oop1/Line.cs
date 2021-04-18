using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class Line : SymFigures
    {
        public Line(float thickness, Color color) : base(thickness, color) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, endPoint);
        }
    }
}

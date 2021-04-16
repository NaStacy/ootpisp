using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class WrPolygon : SymFigures
    {
        private Brush brush { get; set; }
        public WrPolygon(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }


        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, point);
            graphics.FillPolygon(brush, point);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Polygon : SymFigures
    {
        private PointF[] points { get; set; }
        private Brush brush { get; set; }
        private Polygon(PointF center, float radius, int num, Color color, Color colorFill, float thickness) : base(thickness, color)
        {
            brush = new SolidBrush(colorFill); 
            this.points = points;
            double angle = Math.PI * 2 / num;
            points = Enumerable.Range(0, num).Select(i => PointF.Add(center, new SizeF((float) Math.Sin(i* angle) * radius, (float) Math.Cos(i* angle) * radius))).ToArray();
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
            graphics.FillPolygon(brush, points);
        }

    }
}

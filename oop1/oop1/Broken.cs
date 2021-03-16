using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Broken : SymFigures
    {
        private Point[] points { get; set; }
        private Broken(float thickness, Color color, Point[] points) : base(thickness, color)
        {
            this.points = points;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }

    }
}

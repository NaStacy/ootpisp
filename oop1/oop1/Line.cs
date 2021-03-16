using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    class Line : SymFigures
    {
        private Point start { get; set; }
        private Point finish { get; set; }
        private Line (float thickness, Color color, Point start, Point finish): base(thickness, color)
        {
            this.start = start;
            this.finish = finish;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, start, finish);
        }

    }
}

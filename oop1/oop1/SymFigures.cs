using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace oop1
{
    public abstract class SymFigures
    {
        public Pen pen { get; set; }

        public Point[] point;

        public SymFigures(float thickness, Color color)
        {
            pen = new Pen(color, thickness);
        }
        public abstract void Draw(Graphics graphics);
    }
}

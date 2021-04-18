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

        protected Point startPoint;
        protected Point endPoint;

        public SymFigures(float thickness, Color color)
        {
            pen = new Pen(color, thickness);
        }

        public virtual Point StartPoint { get { return startPoint; } set { startPoint = value; } }
        public virtual Point EndPoint { get { return endPoint; } set { endPoint = value; } }

        public abstract void Draw(Graphics graphics);
    }
}

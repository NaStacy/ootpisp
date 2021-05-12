using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace oop1
{
    [DataContract]
    public class Line : SymFigures
    {
        public Line(float thickness, Color color) : base(thickness, color) { }

        public override void Draw(Graphics graphics)
        {
            SetPen();
            graphics.DrawLine(pen, startPoint, endPoint);
        }
    }
}

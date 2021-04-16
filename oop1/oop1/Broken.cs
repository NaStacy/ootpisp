using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class Broken : SymFigures
    { 
        public Broken (float thickness, Color color) : base(thickness, color) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(pen, point);
        }

    }
}

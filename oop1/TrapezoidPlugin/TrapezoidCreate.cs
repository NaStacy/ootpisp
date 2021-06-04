using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop1;

namespace TrapezoidPlugin
{
    [Factory("Trapezoid")]
    class TrapezoidCreate : ICreate
    {
        public SymFigures Create(float thickness, Color color, Color colorFill)
        {
            return new Trapezoid(thickness, color, colorFill);
        }

        public bool manyAng { get { return false; } }
        public bool manyClick { get { return false; } }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class PolygonCreate : ICreate
    {
        public SymFigures Create(float thickness, Color color, Color colorFill)
        {
            return new Polygon(thickness, color, colorFill);
        }
        public bool manyAng { get { return true; } }
        public bool manyClick { get { return false; } }

    }
}

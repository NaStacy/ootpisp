using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class WrPolygonCreate : ICreate
    {
        public SymFigures Create(float thickness, Color color, Color colorFill)
        {
            return new WrPolygon(thickness, color, colorFill);
        }

        public bool manyAng { get { return false; } }
        public bool manyClick { get { return true; } }

    }
}

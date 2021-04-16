using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;

namespace oop1
{
    public interface ICreate
    {
        bool manyAng { get; }
        bool manyClick { get; }

        
        SymFigures Create(float thickness, Color color, Color colorFill);
    }
}

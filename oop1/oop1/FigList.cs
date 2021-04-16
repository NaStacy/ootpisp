using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace oop1
{
    public class FigList
    {
        private List<SymFigures> figureList;
        public FigList() 
        {
            figureList = new List<SymFigures>();
        }
        public void Add(SymFigures sym) 
        {
            figureList.Add(sym);
        }
        public void Drow(Graphics graphics)
        {
            foreach (var figure in figureList)
            {
                figure.Draw(graphics);
            }
        }
    }
}
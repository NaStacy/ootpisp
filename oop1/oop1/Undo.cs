using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

namespace oop1
{
    public class Undo
    {
        private List<SymFigures> figureList;
        public Undo()
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
        public SymFigures Remove()
        {
            SymFigures temp = figureList.Last();
            figureList.Remove(figureList.Last());
            return temp;
        }
        public bool isChecked()
        {
            if (figureList.Count == 0)
                return false;
            return true;
        }
    }
}

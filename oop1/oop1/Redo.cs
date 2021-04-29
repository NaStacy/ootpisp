using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    public class Redo
    {
        private Stack<SymFigures> reStack; 
        public Redo()
        {
            reStack = new Stack<SymFigures>();
        }
        public void Push(SymFigures symFigures)
        {
            reStack.Push(symFigures);
        }
        public SymFigures Pop()
        {
            return reStack.Pop();
        }
        public void CleanStack()
        {
            reStack.Clear();
        }
        public bool isChecked() 
        {
            if (reStack.Count == 0)
                return false;

            return true;
        }
    }
}

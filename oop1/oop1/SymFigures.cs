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
    public abstract class SymFigures
    {
        [DataMember]
        public Color penColor;
        [DataMember]
        public float penWidth;

        [DataMember]
        protected Point startPoint;
        [DataMember]
        protected Point endPoint;

        protected Pen pen { get; set; }
        protected void SetPen()
        {
            pen = new Pen(penColor, penWidth);
        }

        public SymFigures(float thickness, Color color)
        {
            this.penColor = color;
            this.penWidth = thickness;

            pen = new Pen(color, thickness);
        }

        public virtual Point StartPoint { get { return startPoint; } set { startPoint = value; } }
        public virtual Point EndPoint { get { return endPoint; } set { endPoint = value; } }

        public abstract void Draw(Graphics graphics);
    }
}

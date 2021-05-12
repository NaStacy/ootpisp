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
    public class Rectangle : SymFigures
    {
        [DataMember]
        private Brush brush { get; set; }

        public Rectangle(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();

            Point LeftPoint = new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y));
            Point RightPoint = new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y));

            graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
            graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
        }
    }
}

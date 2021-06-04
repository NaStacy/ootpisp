using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using oop1;

namespace TrapezoidPlugin
{
    [DataContract]
    public class Trapezoid : SymFigures
    {
        [DataMember]
        private Brush brush { get; set; }

        [DataMember]
        private Point[] points;

        public Trapezoid(float thickness, Color color, Color colorFill) : base(thickness, color)
        {
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();

            int width = Math.Abs(endPoint.X - startPoint.X) / 3;
            points = new Point[4] { new Point(startPoint.X + width, startPoint.Y), new Point(endPoint.X - width, startPoint.Y),
                                    endPoint, new Point(startPoint.X, endPoint.Y) };


            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }
}

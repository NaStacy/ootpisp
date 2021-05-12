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
    public class Polygon : SymFigures
    {
        [DataMember]
        private PointF[] corners;

        [DataMember]
        private Brush brush { get; set; }

        [DataMember]
        public int cornersNum;

        public Polygon(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();

            corners = new PointF[cornersNum];
            corners[0] = endPoint;

            PointF o = startPoint;
            PointF polar = new PointF(1 * (float)Math.Cos(Math.Acos(-1.0) * 2 / cornersNum), 1 * (float)Math.Sin(Math.Acos(-1.0) * 2 / cornersNum));
            PointF radNext = new PointF(endPoint.X - o.X, endPoint.Y - o.Y);
            PointF temp = new PointF();

            for (int i = 1; i < cornersNum; i++)
            {
                temp.X = radNext.X * polar.X - radNext.Y * polar.Y;
                temp.Y = radNext.X * polar.Y + radNext.Y * polar.X;

                radNext.X = temp.X;
                radNext.Y = temp.Y;

                corners[i].X = o.X + radNext.X;
                corners[i].Y = o.Y + radNext.Y;
            }

            graphics.FillPolygon(brush, corners);
            graphics.DrawPolygon(pen, corners);
        }
    }
}

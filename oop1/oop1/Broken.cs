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
    public class Broken : SymFigures
    {
        [DataMember]
        private List<Point> points = new List<Point>();

        public Broken (float thickness, Color color) : base(thickness, color) { }

        public override Point StartPoint 
        {
            get => base.StartPoint;

            set
            {
                startPoint = value;
                points.Add(startPoint);

                if (points.Count == 1)
                {
                    points.Add(startPoint);
                }
            }
        }

        public override Point EndPoint
        {
            get => base.EndPoint;

            set
            {
                endPoint = value;
                points[points.Count - 1] = endPoint;
            }
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();
            graphics.DrawLines(pen, points.ToArray());
        }

    }
}

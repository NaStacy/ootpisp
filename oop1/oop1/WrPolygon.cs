﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace oop1
{
    public class WrPolygon : SymFigures
    {
        private Brush brush { get; set; }

        private List<Point> points = new List<Point>();

        public WrPolygon(float thickness, Color color, Color colorFill) : base(thickness, color) 
        {
            brush = new SolidBrush(colorFill);
        }

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
            graphics.FillPolygon(brush, points.ToArray());
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }

}

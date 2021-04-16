using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1
{
    public partial class Form : System.Windows.Forms.Form
    {
        private ICreate creator;
        private SymFigures figure;
        private FigList figList;
        private List<Point> points;
        private bool drow;
        private Point start;
        private Point end;
        private Color color;
        private Color colorFill;
        private float thickness;
        private int ang;


        public Form()
        {
            drow = false;
            points = new List<Point>();
            figList = new FigList();
            color = Color.Red;
            colorFill = Color.Yellow;
            thickness = 1;
            ang = 3;
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 3);
            Random random = new Random();
            int a;
            a = random.Next(5);
            if (a == 1)
            {
                pictureBox1.Image = null;
                graph.DrawLine(pen, 10, 10, 258, 258);
                pictureBox1.Image = bmp;
            }
            if (a == 2)
            {
                pictureBox1.Image = null;
                graph.DrawRectangle(pen, 10, 10, 258, 258);
                pictureBox1.Image = bmp;
            }
            if (a == 3)
            {
                pictureBox1.Image = null;
                graph.DrawEllipse (pen, 10, 10, 258, 258);
                pictureBox1.Image = bmp;
            }
            if (a == 4)
            {
                pictureBox1.Image = null;
                graph.DrawLine(pen, 130, 10, 258, 258);
                graph.DrawLine(pen, 258, 258, 10, 258);
                graph.DrawLine(pen, 10, 258, 130, 10);
                pictureBox1.Image = bmp;
            }
            if (a == 0)
            {
                pictureBox1.Image = null;
                graph.DrawLine(pen, 10, 10, 50, 258);
                graph.DrawLine(pen, 50, 258, 110, 10);
                graph.DrawLine(pen, 110, 10, 175, 258);
                graph.DrawLine(pen, 175, 258, 258, 10);
                pictureBox1.Image = bmp;
            } 
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                color = btnColor.BackColor;
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                btnFill.BackColor = colorDialog2.Color;
                colorFill = btnFill.BackColor;
            }
        }

        private void pbLine_Click(object sender, EventArgs e)
        {
            creator = new LineCreate();
        }

        private void pbBroken_Click(object sender, EventArgs e)
        {
            creator = new BrokenCreate();
        }

        private void pbRectangle_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreate ();
        }

        private void pbEllipse_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreate();
        }

        private void pbPolygon_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreate();
        }

        private void pbWrPolygon_Click(object sender, EventArgs e)
        {
            creator = new WrPolygonCreate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (creator != null)
            {
                if (!drow && !creator.manyClick)
                {
                    figure = creator.Create(thickness, color, colorFill);
                    if (creator.manyAng)
                    {
                        (figure as Polygon).cornersNum = ang;
                    }

                    drow = !drow;
                    start.X = e.X;
                    start.Y = e.Y;

                    points.Clear();
                    points.Add(start);
                    points.Add(start);
                }
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            figList.Drow(e.Graphics);
            if (drow)
            {
                figure.Draw(e.Graphics);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drow)
            {
                end.X = e.X;
                end.Y = e.Y;
                points[points.Count - 1] = end;

                figure.point = points.ToArray();
                pictureBox1.Refresh();
            }
        }

        private void numUpDownThickness_ValueChanged(object sender, EventArgs e)
        {
            thickness = (float)numUpDownThickness.Value;
            if (figure != null)
            {
                figure.pen = new Pen(color, thickness);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drow && !creator.manyClick)
            {
                end.X = e.X;
                end.Y = e.Y;
                drow = !drow;
                if (start != end)
                {
                    points[1] = end;
                    figList.Add(figure);
                }
            }
        }

        private void numUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            ang = (int)numUpDownAngle.Value;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (creator != null)
            {
                if (creator.manyClick)
                {
                    if (e.Button == MouseButtons.Left)
                    {

                        start.X = e.X;
                        start.Y = e.Y;

                        if (!drow)
                        {
                            figure = creator.Create(thickness, color, colorFill);

                            points.Clear();
                            points.Add(start);
                            points.Add(start);
                            drow = !drow;
                        }
                        else
                        {
                            points.Add(start);
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        drow = !drow;
                        figList.Add(figure);
                    }
                }
            }
        }
    }
}

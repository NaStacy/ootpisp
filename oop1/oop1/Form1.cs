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

        private Undo figList;
        private Redo figStack;

        private Point start;
        private Point end;
        
        private Color color;
        private Color colorFill;
        
        private float thickness;
        private int ang;

        private bool drow;

        public Form()
        {
            figList = new Undo();
            figStack = new Redo();
            
            color = Color.Red;
            colorFill = Color.Yellow;
            
            thickness = 1;
            ang = 3;

            drow = false;

            InitializeComponent();
        }

        #region figure's properties
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

        private void numUpDownThickness_ValueChanged(object sender, EventArgs e)
        {
            thickness = (float)numUpDownThickness.Value;
        }

        private void numUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            ang = (int)numUpDownAngle.Value;
        }
        #endregion

        #region create figure's
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
        #endregion

        #region mouse action
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

                    figure.StartPoint = start;
                }
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
                    figure.EndPoint = end;
                    figList.Add(figure);
                    figStack.CleanStack();
                }
            }
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
                            figure.StartPoint = start;

                            drow = !drow;
                        }
                        else
                        {
                            figure.StartPoint = start;
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        drow = !drow;
                        figList.Add(figure);
                        figStack.CleanStack();
                    }
                }
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drow)
            {
                end.X = e.X;
                end.Y = e.Y;

                figure.EndPoint = end;
                pictureBox1.Refresh();
            }
        }
        #endregion

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            figList.Drow(e.Graphics);
            if (drow)
            {
                figure.Draw(e.Graphics);
            }
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (figStack.isChecked())
            {
                figList.Add(figStack.Pop());

                pictureBox1.Refresh();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (figList.isChecked())
            {
                figStack.Push(figList.Remove());
                pictureBox1.Refresh();
            }
        }
    }
}

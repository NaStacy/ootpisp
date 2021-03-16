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
        
        public Form()
        {
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
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog2.Color;
            }
        }
    }
}

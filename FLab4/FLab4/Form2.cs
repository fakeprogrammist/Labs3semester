using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[1000];

            double a = Class1.a;
            double f = Class1.f;
            double w = Class1.w;
            double t = Class1.t;
            double x = Class1.x;
            for (int i = 0; i < points.Length; i++) 
            {
                points[i] = new Point(i, Convert.ToInt32(a*Math.Sin(w*x+f))*100 + 200);
                f += i;
            }
            graphics.DrawLines(pen, points);
        }
    }
}

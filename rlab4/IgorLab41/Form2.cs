using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLAB4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form2_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Azure);

            int x = Class1.x;
            int x0 = Class1.x0;
            int y = Class1.y;
            int y0 = Class1.y0;
            g.DrawEllipse(Pens.Black, 100, 100, 200, 200);
            g.DrawLine(Pens.Black, 100, 100, 100, 100);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Point point = new Point();
            g = CreateGraphics();
            g.Clear(Color.Azure);

            int x = Class1.x;
            int x0 = Class1.x0;
            int y = Class1.y;
            int y0 = Class1.y0;
            double r = Class1.r;
            g.DrawEllipse(Pens.Black, x0, y0, x, y);
            g.DrawEllipse(Pens.Black, x0 + x0/2, y0 + y0/2, 1, 1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

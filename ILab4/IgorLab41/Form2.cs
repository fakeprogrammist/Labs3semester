using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgorLab41
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.chart2.Series[0].Points.Clear();
            int x0 = Class1.x0;
            int x  = Class1.x;
            int a = Class1.a;
            int b = Class1.b;
            int c = Class1.c;
            int y;
            while (x0 != x) 
            {
                y = a * x0 * x0 + b * x0 + c;
                this.chart2.Series[0].Points.AddXY(x0, y);
                x0 += 1;
            }
        }
    }
}

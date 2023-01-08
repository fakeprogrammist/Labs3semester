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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double f = Convert.ToDouble(textBox2.Text);
            double t = Convert.ToDouble(textBox3.Text);
            double w = 2 * Math.PI / t;
            double x = Convert.ToDouble(textBox4.Text);
            Class1.a = a;
            Class1.f = f;
            Class1.t = t;
            Class1.w = w;
            Class1.x = x;
            Form2 form = new Form2();
            form.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox1.Text), x = Convert.ToInt32(textBox2.Text),
                a = Convert.ToInt32(textBox3.Text), b = Convert.ToInt32(textBox4.Text),
                c = Convert.ToInt32(textBox5.Text);

            Class1.x0= x0;
            Class1.x = x;
            Class1.a = a;
            Class1.b = b;
            Class1.c = c;
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}

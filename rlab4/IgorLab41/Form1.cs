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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox1.Text), x = Convert.ToInt32(textBox2.Text),
                y0 = Convert.ToInt32(textBox3.Text), y = Convert.ToInt32(textBox5.Text);

            Class1.x0= x0;
            Class1.x = x;
            Class1.y = y;
            Class1.y0 = y0;
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}

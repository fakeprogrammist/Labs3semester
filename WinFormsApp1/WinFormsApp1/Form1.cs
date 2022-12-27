using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(textBox1.Text);

            int[] array = new int[len];
            int k, l, sum = 0;

            k = Convert.ToInt32(textBox2.Text);
            l = Convert.ToInt32(textBox3.Text);

            for (int i = 0; i < len; i++)
            {
                Random rand = new Random();
                array[i] = rand.Next(1, len);
                listBox1.Items.Add(array[i]);
                if (i == k || i == l)
                    continue;
                sum += array[i];
            }
            textBox4.Text = sum.ToString();
        }
    }
}
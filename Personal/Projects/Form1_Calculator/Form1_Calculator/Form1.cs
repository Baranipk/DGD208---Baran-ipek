using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1_Calculator
{
    public partial class Form1 : Form
    {
        private int sayi1;
        private int sayi2;
        private int para=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            para ++;
            label1.Text = $"para: {para}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            label2.Text = (sayi1 + sayi2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            label2.Text = (sayi1 - sayi2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            label2.Text = (sayi1 * sayi2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            label2.Text = (sayi1 / sayi2).ToString();
        }
    }
}

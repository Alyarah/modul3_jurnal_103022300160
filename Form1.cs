using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_jurnal_103022300160
{
    public partial class Form1 : Form
    {
        int sum, num;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            num = num * 10 + 1;
            textBox1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = num * 10 + 2;
            textBox1.Text = num.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            num = num * 10 + 3;
            textBox1.Text = num.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            num = num * 10 + 4;
            textBox1.Text = num.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            num = num * 10 + 5;
            textBox1.Text = num.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            num = num * 10 + 6;
            textBox1.Text = num.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            num = num * 10 + 7;
            textBox1.Text = num.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            num = num * 10 + 8;
            textBox1.Text = num.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            num = num * 10 + 9;
            textBox1.Text = num.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            num = num * 10 + 0;
            textBox1.Text = num.ToString();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            sum = sum + num;
            num = 0;
            textBox1.Text = "";
        }

        private void btn_samaDengan_Click(object sender, EventArgs e)
        {
            sum = sum + num;
            num = 0;
            textBox1.Text = sum.ToString();
        }
    }
}

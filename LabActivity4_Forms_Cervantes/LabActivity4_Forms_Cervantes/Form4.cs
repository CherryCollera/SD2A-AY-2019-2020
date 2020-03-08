using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity4_Forms_Cervantes
{
    public partial class Form4 : Form
    {
        double a, b;

        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1_f.Text);
            b = Convert.ToDouble(textBox2_s.Text);
            textBox3_a.Text = (a - b).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1_f.Text);
            b = Convert.ToDouble(textBox2_s.Text);
            textBox3_a.Text = (a + b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1_f.Text);
            b = Convert.ToDouble(textBox2_s.Text);
            textBox3_a.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1_f.Text);
            b = Convert.ToDouble(textBox2_s.Text);
            textBox3_a.Text = (a / b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1_f.Text);
            b = Convert.ToDouble(textBox2_s.Text);
            textBox3_a.Text = (a % b).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

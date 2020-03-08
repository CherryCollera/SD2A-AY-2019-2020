using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = int.Parse(txtFirst.Text);
            num2 = int.Parse(txtSecond.Text);
            sum = num1 + num2;
            MessageBox.Show("Sum    :" + sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

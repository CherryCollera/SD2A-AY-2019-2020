using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabActivity5_Legaspi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            int number = 25;
            MessageBox.Show(number.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float number = 25.78F;
            MessageBox.Show(number.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double number = 25.7889;
            MessageBox.Show(number.ToString());
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;

            num1 = Convert.ToInt32(txtBox_Num1.Text);
            num2 = Convert.ToInt32(txtBox_Num2.Text);

            sum = num1 + num2;

            MessageBox.Show("The sum is " + Convert.ToString(sum));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

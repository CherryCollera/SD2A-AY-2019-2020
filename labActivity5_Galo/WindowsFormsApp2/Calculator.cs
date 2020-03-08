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
    public partial class Calculator : Form
    {
        double total1=0, total2=0;
        Boolean plusButtonClicked=false;
        Boolean minusButtonClicked = false;
        Boolean multiplicationButtonClicked = false;
        Boolean divideButtonClicked = false;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total1 = 0;
            total2 = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            
            txtDisplay.Clear();
            plusButtonClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked==true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);

            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplicationButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);

            }
            txtDisplay.Text = total2.ToString();total1 = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
            minusButtonClicked = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
            multiplicationButtonClicked = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
            divideButtonClicked = true;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

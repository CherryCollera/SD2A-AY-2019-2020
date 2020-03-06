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
    public partial class Calculator : Form
    {
        public double total1, total2;
        public string oprtn;

        bool btnAddClick = false;
        bool btnSubtractClick = false;
        bool btnMultiplyClick = false;
        bool btnDivideClick = false;
        
    public Calculator()
        {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void BtnForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();

            btnAddClick = true;
            btnSubtractClick = false;
            btnMultiplyClick = false;
            btnDivideClick = false;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();

            btnAddClick = false;
            btnSubtractClick = true;
            btnMultiplyClick = false;
            btnDivideClick = false;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();

            btnAddClick = false;
            btnSubtractClick = false;
            btnMultiplyClick = true;
            btnDivideClick = false;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();

            btnAddClick = false;
            btnSubtractClick = false;
            btnMultiplyClick = false;
            btnDivideClick = true;
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if(btnAddClick == true)
            {
                total2 = total1 + Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Text = Convert.ToString(total2);
                total1 = 0;
                total2 = 0;
            }
            else if (btnSubtractClick == true)
            {
                total2 = total1 - Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Text = Convert.ToString(total2);
                total1 = 0;
                total2 = 0;
            }
            else if (btnMultiplyClick == true)
            {
                total2 = total1 * Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Text = Convert.ToString(total2);
                total1 = 0;
                total2 = 0;
            }
            else if (btnDivideClick == true)
            {
                total2 = total1 / Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Text = Convert.ToString(total2);
                total1 = 0;
                total2 = 0;
            }
        }
    }
}

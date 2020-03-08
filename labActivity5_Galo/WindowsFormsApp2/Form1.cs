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
    public partial class Form1 : Form
    {
        //int answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Boolean answer;
            DialogResult dialog =MessageBox.Show("Hello", "My Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (dialog == DialogResult.Yes)
            {
                Calculator cal = new Calculator();
                cal.Show();
                this.Hide();
            }else 
                this.Close();

        }
    }
}

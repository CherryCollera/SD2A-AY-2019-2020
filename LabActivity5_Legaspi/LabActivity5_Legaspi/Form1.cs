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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Hello", "My Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                Calculator calc = new Calculator();
                calc.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
            
        }
    }
}

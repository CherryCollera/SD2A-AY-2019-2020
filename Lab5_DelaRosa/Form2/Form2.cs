﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form2 : Form
    
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "My message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Calcu cal = new Calcu();
            cal.Show();
            this.Hide();
            this.Close();
        }
    }
}

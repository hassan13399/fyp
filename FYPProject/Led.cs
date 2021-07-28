using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPProject
{
    public partial class Led : Form
    {

        public static string t;    

        public Led()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void getText_Click(object sender, EventArgs e)
        {

             t = pin.Text;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

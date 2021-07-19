using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPProject
{
    public partial class ledControl : UserControl
    {
        public String getPinValueee = pinValue.Text;
        
        public ledControl()
        {
            InitializeComponent();
             
        }
        public static String getpinValue() 
        {
            String value = pinValue.Text;
            return value;
        }
        private void ledControl_Load(object sender, EventArgs e)
        {

        }

        private void ledControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pinValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void pinValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}

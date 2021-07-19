using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPProject
{
    public partial class Delay : UserControl
    {
        public Delay()
        {
            InitializeComponent();
        }
        public String getDelayValue()
        {
            String value = delayValue.Text;
            return value;
        }

        private void Delay_Load(object sender, EventArgs e)
        {

        }
    }
}

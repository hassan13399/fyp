using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPProject
{
    public partial class WhileConditionController : UserControl
    {

        Form1 j = new Form1();
        ControllerVariables v = new ControllerVariables();
        public WhileConditionController()
        {
            InitializeComponent();
        }

        private void whileCloseBtn_MouseClick(object sender, MouseEventArgs e)
        {

            j.RemoveWhileController(whileCloseBtn);

        }
    }
}

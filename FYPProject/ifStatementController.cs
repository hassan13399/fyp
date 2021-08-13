using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static FYPProject.Form1;

namespace FYPProject
{
    

    public partial class ifStatementController : UserControl
    {
        //ControllerVariables v = new ControllerVariables();
        Form1 j = new Form1();
        //ifStatementController ifSta = new ifStatementController(j);

         public Button b;
        Button btn = new Button();

        public ifStatementController()
        {
            InitializeComponent();
            
        }

        public void ifCloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            j.RemoveIfController(ifCloseBtn);
            

        }

        
        
    }
}

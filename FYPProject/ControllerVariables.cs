using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;




namespace FYPProject
{
    class ControllerVariables: UserControl
    {
        Form1 j = new Form1();
        private int c;

        public void setIndex()
        {
            c = j.currenIndex;
            Console.WriteLine(c);
        }

        public int getIn()
        {            
            return c;
        }

        
        public void print()
        {
            Console.WriteLine(getIn());
        }
       

    }
}

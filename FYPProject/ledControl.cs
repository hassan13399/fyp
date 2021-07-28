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
        //public String getPinValueee = pinValue.Text;
        //public static string v;
        private Control activeControl;
        private Point previousLocation;

        // ledControl l = new ledControl();

        public ledControl()
        {
            InitializeComponent();
             
        }
        public String getpinValue() 
        {
            String v = pinValue.Text;
           // Console.WriteLine(v);
            return v;
        }
        private void ledControl_Load(object sender, EventArgs e)
        {

        }

        private void ledControl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;

        }

        private void pinValue_TextChanged(object sender, EventArgs e)
        {



        }

        private void pinValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ledControl_MouseMove(object sender, MouseEventArgs e)
        {

            
        }

        private void ledControl_MouseUp(object sender, MouseEventArgs e)
        {

            //activeControl = null;
            //Cursor = Cursors.Default;

        }
    }
}

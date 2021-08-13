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
        private Point p;
        public bool AllowDrag { get; set; }
        private bool _isDragging = false;
        private int _DDradius = 40;
        private int _mX = 0;
        private int _mY = 0;
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

            this.Focus();
            base.OnMouseDown(e);
            _mX = e.X;
            _mY = e.Y;

            this._isDragging = false;
        }

        private void ledControl_MouseMove(object sender, MouseEventArgs e)
        {
           

        }

        private void pinValue_TextChanged(object sender, EventArgs e)
        {



        }

        private void pinValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void ledControl_MouseUp(object sender, MouseEventArgs e)
        {

            

        }
    }
}

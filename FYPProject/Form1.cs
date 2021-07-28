using Solid.Arduino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FYPProject.SubMenus;
using System.Collections;
using Harr;

namespace FYPProject
{

  

    
    public partial class Form1 : Form 
    {
        //private List<HarrProgressBar> _items = new List<HarrProgressBar>();
        private List<UserControl> _items = new List<UserControl>();

        public String type;

        LoopSubMenuController loopSub = new LoopSubMenuController();
        ledControl ledC = new ledControl();
        ledControl lControl;
        DropLedControl d = new DropLedControl();
        DropLedControl dVar;


        public static String pinValue, variableType, variableName, variableValue, delayValue;

        private Control activeControl;
        private Point previousLocation;

        ledControl ledControlObj = new ledControl();
        
        Delay delayControlObj = new Delay();
        HandleVariables handleVariablesObj = new HandleVariables();
        ComboBox cboxx = new ComboBox();
        
        ledControl ledHandle;
        ledControl ledCon;
        private object p1;

        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            CustomizeControllerSub();

            ledC.MouseUp += LedControl_MouseUp;
            ledC.MouseMove += LedControl_MouseMove;


        }

        private void LedControl_MouseMove(object sender, MouseEventArgs e)
        {
            lControl = (ledControl)sender;

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;


        }

        private void LedControl_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            Cursor = Cursors.Default;

        }

        private void LedControl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            //Stack<int> myst = new Stack<int>();
            //myst.Push(12);
            //myst.Push(12);
            //myst.Push(12);
            //myst.Push(12);
            //myst.Push(12);

            //Console.WriteLine(myst.Pop());
            HarrProgressBar controllers;
            ledCon = new ledControl();
           

            ledC.MouseDown  += LedControl_MouseDown;
            



        }

        //private void LedControl_MouseDown(object sender, MouseEventArgs e)
        //{

        //.WriteLine("Hassan");
        //lControl = (ledControl)sender;
        //Bitmap bitmap = new Bitmap(lControl.Width, lControl.Height);
        //lControl.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
        //Cursor cursor = new Cursor(bitmap.GetHicon());
        //Cursor.Current = cursor;
        //this.DoDragDrop(lControl.Name, DragDropEffects.All);
        // }







        private void CustomizeDesign()
        {

            panelMediaSub.Visible = false;
            PanelPlaylist.Visible = false;
            loopPanel.Visible = false;



        }//CustomizeDesign

        private void HideSubMenu()
        {

            if (panelMediaSub.Visible == true)
                btnMedia.Visible = false;
            if (PanelPlaylist.Visible == true)
                btnPlayList.Visible = false;
            if (loopPanel.Visible == true)
                Loops.Visible = false;


        }//hideSubmenu

        private void ShowSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

   

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelPlaylist);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSub);
        } 

       

        private void button2_Click(object sender, EventArgs e)
        {
            Panel p1 = new Panel();
            p1.BackColor = Color.Gray;
            p1.Width = 400;
            p1.Height = 200;
            cboxx.Items.Add(1);
            cboxx.Items.Add(2);
            cboxx.Items.Add(3);
            cboxx.Items.Add(4);
            cboxx.Items.Add(5);
            cboxx.Items.Add(6);
            cboxx.Items.Add(7);
            cboxx.Items.Add(8);
            cboxx.Items.Add(9);
            cboxx.Items.Add(10);
            cboxx.Items.Add(11);
            cboxx.Items.Add(12);
            cboxx.Items.Add(13);
            p1.Controls.Add(cboxx);
            p1.Location = new Point(400,200);
            Droppanel.Controls.Add(p1);

            //Led l = new Led();
            //l.MdiParent = this;
            //l.Show();

            p1.MouseMove += ppp1_MouseClick;



        }//Button2 Click

        private void ppp1_MouseClick(object sender, MouseEventArgs e)
        {
            

                Point newLoc = new Point(e.X + e.Location.X, e.Y + e.Location.Y);
                panel1.Location = newLoc;

            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISerialConnection con = Connection.GetConnection();
            Console.WriteLine(con);

            string value = ledControlObj.getpinValue();
            pinValue = value;

            variableType = handleVariablesObj.getvariableType();
            variableName = handleVariablesObj.getvariableName();
            variableValue = handleVariablesObj.getvariableValue();
            delayValue = delayControlObj.getDelayValue();







            //Console.WriteLine(value);
            //Console.WriteLine("at Form 1");

            if (con != null)
            {
                New new1 = new New();
                using (var session = new ArduinoSession(con))
                    new1.PerformBasicTest(session);

               

            }

            
            //String delayValue = delayControlObj.getDelayValue();
            //Console.WriteLine(delayValue);
            //String variableType = handleVariablesObj.getvariableType();
            //Console.WriteLine(variableType);
            //String variableName = handleVariablesObj.getvariableName();
            //Console.WriteLine(variableName);
            //String variableValue = handleVariablesObj.getvariableValue();
            //Console.WriteLine(variableValue);

           // ArduinoBasicFunction.PerformBasicTest();

            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IfStatement i = new IfStatement();
            i.MdiParent = this;
            i.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Panel Droppanel = new Panel();
            //Droppanel.BackColor = Color.Red;
            //Droppanel.Show();

            //Panel droppanel3;
            //Form delayForm = new Form() { TopLevel = false, TopMost = true };
            //Button btn = new Button();
            // btn.Text = "doen";
            // btn.Location = new Point(100,100);
            //btn.BackColor = Color.Blue;
            //delayForm.BackColor = Color.Red;
            //delayForm.Resize = false;
            //delayForm.Show();

            ScrollBar vScrollBar1 = new VScrollBar();


            Panel p1 = new Panel();
            p1.BackColor = Color.Red;
            p1.Width = 400;
            p1.Height = 200;
            ComboBox cbox = new ComboBox();
            cbox.Items.Add(100);
            cbox.Items.Add(200);
            cbox.Items.Add(300);
            cbox.Items.Add(400);
            cbox.Items.Add(500);
            cbox.Items.Add(600);
            cbox.Items.Add(700);
            cbox.Items.Add(800);
            cbox.Items.Add(900);
            cbox.Items.Add(1000);
            cbox.Items.Add(2000);
            cbox.Items.Add(3000);

            p1.Controls.Add(cbox);
            Droppanel.Controls.Add(p1);
              
        }

       

        private void variable_Click(object sender, EventArgs e)
        {


            
            
            
            //Panel variablePanel = new Panel();
            //variablePanel.BackColor = Color.Red;
            //variablePanel.Location = new Point(100,100);
            //variablePanel.Width = 200;
            //variablePanel.Height = 200;
            ////variablePanel.Show();
            //ComboBox TypeForComboBox = new ComboBox();
            //TypeForComboBox.Items.Add("Boolean");
            //TypeForComboBox.Items.Add("String");
            //TypeForComboBox.Items.Add("int");
            //TypeForComboBox.Items.Add("Double");
            //TextBox variableName = new TextBox();
            //TextBox variableValue = new TextBox();
            //variablePanel.Controls.Add(TypeForComboBox);
            //variablePanel.Controls.Add(variableName);
            //variablePanel.Controls.Add(variableValue);
            //Droppanel.Controls.Add(variablePanel); 

        }


        
        private void CustomizeControllerSub()
        {

           

            
        }//CustomizeDesign

        private void HideControllerSub()
        {
           
        }

        private void ShowControllerSub(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideControllerSub();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void controller_Click(object sender, EventArgs e)
        {

            

        }

       
       
        public void CustomizeLddLocation()
        {
            ledControlObj.Location = new Point(50, 100);
        }

        private void ledControl1_Click(object sender, EventArgs e)
        {

            //Droppanel.Controls.Add(ledControlObj);
            //CustomizeLddLocation();
            ////ledControlObj.Location = new Point(50, 100);
            //ledControlObj.MouseDown += new MouseEventHandler(ledControl1_MouseDown);
            //ledControlObj.MouseMove += new MouseEventHandler(ledControl1_MouseMove);
            //ledControlObj.MouseUp += new MouseEventHandler(ledControl1_MouseUp);

           // this.Controls.Add(ledControlObj);

        }

       

        private void delay1_Click(object sender, EventArgs e)
        {
            delayControlObj.Location = new Point(200,200) ;
            Droppanel.Controls.Add(delayControlObj);
        }

        

        public void ShowSub(UserControl submenu)
        {



            //if (!Droppanel.Controls.Contains(submenu))
            //{

            //    Droppanel.Controls.Add(submenu);

            //}
            //else if (Droppanel.Controls.Contains(submenu))
            //{
            //    Droppanel.Controls.Remove(submenu);
            //}

        }


        private void variable_MouseClick(object sender, MouseEventArgs e)
        {

            
            ShowSub(loopSub);
           

        }

        //private void Droppanel_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //}


        //private void Droppanel_DragDrop(Object sender, DragEventArgs e)
        //{

        //    // DropLedControl c = new DropLedControl();
        //    //Droppanel.Controls.Add(c);

        //    


        //}


        private void Loops_Click(object sender, EventArgs e)
        {

            ShowControllerSub(loopPanel);

        }

        private void whileBtn_MouseDown(object sender, MouseEventArgs e)
        {

            //DropLedControl c = new DropLedControl();
            this.DoDragDrop(whileBtn.Name, DragDropEffects.All);
            type = "whileBtn";

            //Console.WriteLine(sender.GetType());
;

            // Droppanel_DragDrop
            
           
        }

       

        private void whileBtn_Click(object sender, EventArgs e)
        {

        }

       

        
        //private void Droppanel_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        private void ifBtn_MouseDown(object sender, MouseEventArgs e)
        {
            type = "ifBtn";

            this.DoDragDrop(ifBtn.Name, DragDropEffects.All);
            
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            type = "loopSubMenuC";

            this.DoDragDrop(button9.Name, DragDropEffects.All);
        }

        private void Droppanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Droppanel_DragDrop(object sender, DragEventArgs e)
        {
            FlowLayoutPanel _destination = (FlowLayoutPanel)sender;
            UserControl data = (UserControl)e.Data.GetData(typeof(UserControl));

            

            if (type == "ifBtn")
            {

                ledControl l = new ledControl();

                Droppanel.Controls.Add(l);
                Droppanel.AutoScrollPosition = new Point(l.Left, l.Right);
                this.Droppanel.Location = new System.Drawing.Point(47, 55);
                type = "";
                this._items.Add(l);



            }
            else if (type == "whileBtn")
            {
                DropLedControl c = new DropLedControl();
                Droppanel.Controls.Add(c);
                Droppanel.AutoScrollPosition = new Point(c.Left, c.Right);
                type = "";
                this._items.Add(c);
            }
            else if (type == "loopSubMenuC")
            {
                LoopSubMenuController c = new LoopSubMenuController();
                Droppanel.Controls.Add(c);
                Droppanel.AutoScrollPosition = new Point(c.Left, c.Right);
                type = "";
                this._items.Add(c);
            }

            Point p = _destination.PointToClient(new Point(e.X, e.Y));
            var item = _destination.GetChildAtPoint(p);
            int index = _destination.Controls.GetChildIndex(item, false);
            //_destination.Controls.SetChildIndex(data, index);

        }

       



        //private void Droppanel_DragDrop(object sender, DragEventArgs e)
        //{
        //    
        //}

        //private void Droppanel_DragEnter(object sender, DragEventArgs e)
        //{
        //    
        //}

        private void handleVariables1_Click(object sender, EventArgs e)
        {

            handleVariablesObj.Location = new Point(200, 300);
            Droppanel.Controls.Add(handleVariablesObj);

        }

        

        

       

        private void ledControl1_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;


        }

        private void ledControl1_MouseUp(object sender, MouseEventArgs e)
        {

            activeControl = null;
            Cursor = Cursors.Default;

        }

        private void ledControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
                return;

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
        }

        
    }
}

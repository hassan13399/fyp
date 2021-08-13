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

       //Objects

        LoopSubMenuController loopSub = new LoopSubMenuController();
        ledControl ledC = new ledControl();
        ledControl lControl;
        DropLedControl d = new DropLedControl();
        DropLedControl dVar;
        ledControl ledControlObj = new ledControl();
        Delay delayControlObj = new Delay();
        HandleVariables handleVariablesObj = new HandleVariables();

        //Variables

        public static String pinValue, variableType, variableName, variableValue, delayValue;
        private Control activeControl;
        private Point previousLocation;
        public UserControl currentController;
        public int currenIndex;
        public String type;
        private bool _isDragging;


        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();

            

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



            if (con != null)
            {
                New new1 = new New();
                using (var session = new ArduinoSession(con))
                    new1.PerformBasicTest(session);

            }//if

        }//connectToolStripMenuItem_Click


        private void Controller_Click(object sender, MouseEventArgs e)
        {
           UserControl c = (UserControl)sender;

            Console.WriteLine(c);

        }


        private void if_MouseHover(object sender, EventArgs e)
        {
            //currentController = (UserControl)sender;             
            //currenIndex = Droppanel.Controls.GetChildIndex(currentController);
            //Console.WriteLine(currentController);

        }

        private void ifMouse_Move(object sender, MouseEventArgs e)
        {
            //this.DoDragDrop(sender, DragDropEffects.All);
        }

        private void if_MouseDown(object sender, MouseEventArgs e)
        {

             currentController = (UserControl)sender;
            int i = Droppanel.Controls.GetChildIndex(currentController);

            base.OnMouseDown(e);

            currentController.DoDragDrop(sender, DragDropEffects.Move);
            //Console.WriteLine(currentController);
        }

        private void if_DragOver(object sender, DragEventArgs e)
        {
            base.OnDragOver(e);
            // is another dragable
            if (e.Data.GetData(typeof(UserControl)) != null)
            {
                FlowLayoutPanel p = (FlowLayoutPanel)(sender as UserControl).Parent;

                int myIndex = p.Controls.GetChildIndex((sender as UserControl));


                UserControl q = (UserControl)e.Data.GetData(typeof(UserControl));
                p.Controls.SetChildIndex(q, myIndex);
            }
        }

        
        private void while_MouseDown(object sender, MouseEventArgs e)
        {
            UserControl c = (UserControl)sender;
            int i = Droppanel.Controls.GetChildIndex(c);

            base.OnMouseDown(e);
            this.DoDragDrop(sender, DragDropEffects.All);
        }

        private void while_DragOver(object sender, DragEventArgs e)
        {
            base.OnDragOver(e);
            // is another dragable
            if (e.Data.GetData(typeof(UserControl)) != null)
            {
                FlowLayoutPanel p = (FlowLayoutPanel)(sender as UserControl).Parent;
                //Current Position             
                int myIndex = p.Controls.GetChildIndex((sender as UserControl));

                //Dragged to control to location of next picturebox
                UserControl q = (UserControl)e.Data.GetData(typeof(UserControl));
                p.Controls.SetChildIndex(q, myIndex);
            }
        }

        private void Droppanel_DragDrop(object sender, DragEventArgs e)
        {



            if (type == "ifBtn")
            {
                

                ifStatementController l = new ifStatementController();
                Droppanel.Controls.Add(l);
                
                //l.AllowDrop = true;
                l.MouseDown += new MouseEventHandler(if_MouseDown);
               // l.DragOver += new DragEventHandler(if_DragOver);
                //l.MouseMove += new MouseEventHandler(ifMouse_Move);

               
                //l.MouseClick += new MouseEventHandler(Controller_Click);
                //l.MouseHover += new EventHandler(if_MouseHover);

                Droppanel.AutoScrollPosition = new Point(l.Left, l.Right);
               
                type = "";

            }else if (type == "whileBtn")
            {
                WhileConditionController c = new WhileConditionController();
                Droppanel.Controls.Add(c);
                //c.AllowDrop = true;
                c.MouseDown += new MouseEventHandler(if_MouseDown);
                //c.DragOver += new DragEventHandler(if_DragOver);
                
                Droppanel.AutoScrollPosition = new Point(c.Left, c.Right);

               
                type = "";
            }
            else if (type == "loopSubMenuC")
            {
                Delay c = new Delay();
                
                Droppanel.Controls.Add(c);
                c.MouseDown += new MouseEventHandler(if_MouseDown);
                Droppanel.AutoScrollPosition = new Point(c.Left, c.Right);
                type = "";
               
            }


            
               
                Point mousePosition = Droppanel.PointToClient(new Point(e.X, e.Y));
                Control destination = Droppanel.GetChildAtPoint(mousePosition);
                int indexDestination = Droppanel.Controls.IndexOf(destination);

            if (currentController != null)
            {
                Droppanel.Controls.SetChildIndex(currentController, indexDestination);
                currentController = null;
            }



        }//DroppanelDragdrop

       

        private void Droppanel_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(typeof(MyWrapper)))
            //    e.Effect = DragDropEffects.Move;
            //else
            //    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.All;

        }



        private void CustomizeDesign()
        {

            setUpSubFlowPanel.Visible = false;
            logicsSubFlowPanel.Visible = false;
            loopsSubFlowPanel.Visible = false;
            pinSubPanel.Visible = false;



        }//CustomizeDesign

        
        private void btnPlayList_Click(object sender, EventArgs e)
        {
            ShowSubMenu(logicsSubFlowPanel);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(setUpSubFlowPanel);
        }

        private void Loops_Click(object sender, EventArgs e)
        {

            ShowSubMenu(loopsSubFlowPanel);

        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {

                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }//ShowSubMenu


        private void whileBtn_MouseDown(object sender, MouseEventArgs e)
        {
            type = "whileBtn";
            this.DoDragDrop(whileBtn.Name, DragDropEffects.All);
           
        }


        private void ifBtn_MouseDown(object sender, MouseEventArgs e)
        {
            type = "ifBtn";   
            this.DoDragDrop(ifBtn.Name, DragDropEffects.All);
            
        }

       
        private void pin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pinSubPanel);

        }


        private void delay_MouseDown(object sender, MouseEventArgs e)
        {
             
            type = "loopSubMenuC";

             this.DoDragDrop(delay.Name, DragDropEffects.All);
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

        public void RemoveIfController(Button i) 
        {

            UserControl UC = (UserControl)i.Parent;
            Droppanel.Controls.Remove(UC);
            UC.Dispose();

        }
        
        public void RemoveWhileController(Button i)
        {

            UserControl UC = (UserControl)i.Parent;
            Droppanel.Controls.Remove(UC);
            UC.Dispose();

        }

       


    }


    



}

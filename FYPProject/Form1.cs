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

namespace FYPProject
{
    public partial class Form1 : Form
    {
        
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
            ledCon = new ledControl();
            
           ledCon.MouseDown  += LedControl_MouseDown;
            
        }

        private void LedControl_MouseDown(object sender, MouseEventArgs e)
        {

            Console.WriteLine("Hassan");
            ledHandle = (ledControl)sender;
            Bitmap bitmap = new Bitmap(ledHandle.Width, ledHandle.Height);
            ledHandle.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            Cursor cursor = new Cursor(bitmap.GetHicon());
            Cursor.Current = cursor;
            this.DoDragDrop(ledHandle.Name, DragDropEffects.Move);
        }


        private void CustomizeDesign()
        {

            panelMediaSub.Visible = false;
            PanelPlaylist.Visible = false;
            PanelTools.Visible = false;



        }//CustomizeDesign

        private void HideSubMenu()
        {

            if (panelMediaSub.Visible == true)
                btnMedia.Visible = false;
            if (PanelPlaylist.Visible == true)
                btnPlayList.Visible = false;
            if (PanelTools.Visible == true)
                btnTools.Visible = false;


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void file_Click(object sender, EventArgs e)
        {

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

            if (con != null)
            {
                using (var session = new ArduinoSession(con))
                    New.PerformBasicTest(session);

            }

            String value = ledControlObj.getpinValue();
            Console.WriteLine(value);
            String delayValue = delayControlObj.getDelayValue();
            Console.WriteLine(delayValue);
            String variableType = handleVariablesObj.getvariableType();
            Console.WriteLine(variableType);
            String variableName = handleVariablesObj.getvariableName();
            Console.WriteLine(variableName);
            String variableValue = handleVariablesObj.getvariableValue();
            Console.WriteLine(variableValue);

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

        private void Droppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void variable_Click(object sender, EventArgs e)
        {
            Panel variablePanel = new Panel();
            variablePanel.BackColor = Color.Red;
            variablePanel.Location = new Point(100,100);
            variablePanel.Width = 200;
            variablePanel.Height = 200;
            //variablePanel.Show();
            ComboBox TypeForComboBox = new ComboBox();
            TypeForComboBox.Items.Add("Boolean");
            TypeForComboBox.Items.Add("String");
            TypeForComboBox.Items.Add("int");
            TypeForComboBox.Items.Add("Double");
            TextBox variableName = new TextBox();
            TextBox variableValue = new TextBox();
            variablePanel.Controls.Add(TypeForComboBox);
            variablePanel.Controls.Add(variableName);
            variablePanel.Controls.Add(variableValue);
            Droppanel.Controls.Add(variablePanel); 

        }


        private void Droppanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CustomizeControllerSub()
        {

            controllerSubPanel.Visible = false;
            
        }//CustomizeDesign

        private void HideControllerSub()
        {
            if (controllerSubPanel.Visible == true)
                controllerSubPanel.Visible = false;
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

            ShowControllerSub(controllerSubPanel);



        }

        private void ledControl1_Load(object sender, EventArgs e)
        {

        }

        private void controllerSubPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ledControl1_Click(object sender, EventArgs e)
        {

            Droppanel.Controls.Add(ledControlObj);
            




        }

        private void delay1_Load(object sender, EventArgs e)
        {

            
        }

        private void delay1_Click(object sender, EventArgs e)
        {
            delayControlObj.Location = new Point(200,200) ;
            Droppanel.Controls.Add(delayControlObj);
        }

        private void handleVariables1_Load(object sender, EventArgs e)
        {

        }

        private void handleVariables1_Click(object sender, EventArgs e)
        {

            handleVariablesObj.Location = new Point(200, 300);
            Droppanel.Controls.Add(handleVariablesObj);

        }

        private void rToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}

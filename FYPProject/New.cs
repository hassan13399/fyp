using System;
using System.Threading;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace FYPProject
{
    class New : ledControl

    {


        Form1 form1 = new Form1();
        ledControl ledControlObj = new ledControl();
        HandleVariables handleVariableControlObj = new HandleVariables();
       
        Delay delayControlObj = new Delay();
        HandleVariables handleVariablesObj = new HandleVariables();

        //static void Main(string[] args)
        //{
        //    ISerialConnection connection = GetConnection();

        //    if (connection != null)
        //        using (var session = new ArduinoSession(connection))
        //            PerformBasicTest(session);

        //    Console.WriteLine("Press a key");
        //    Console.ReadKey(true);
        //}







        public void PerformBasicTest(IFirmataProtocol session)
        {

            


            var firmware = session.GetFirmware();
            Console.WriteLine($"Firmware: {firmware.Name} version {firmware.MajorVersion}.{firmware.MinorVersion}");
            var protocolVersion = session.GetProtocolVersion();
            Console.WriteLine($"Firmata protocol version {protocolVersion.Major}.{protocolVersion.Minor}");

            //session.SetDigitalPinMode(value, PinMode.DigitalOutput);
            //session.SetDigitalPin(value, true);





            //newcode
            //String value = ledControlObj.getpinValue();
            //Console.WriteLine(value);
            //Form1 f = new Form1(); 

            String delayValue = Form1.delayValue;
            String pin = Form1.pinValue;
            String variableType = Form1.variableType;            
            String variableName = Form1.variableName;
            String variableValue = Form1.variableValue;
            
            

            //newcode end
            Console.WriteLine(pin);
            Console.WriteLine(delayValue);
            Console.WriteLine(variableType);
            Console.WriteLine(variableName);
            Console.WriteLine(variableValue);

            int pinInInteger = Int32.Parse(pin);
            int delayInteger = Int32.Parse(delayValue);

            Console.WriteLine(pinInInteger.GetType());


            //if (variableType == "Int")
            //{

            //    int variableString = Int32.Parse(variableValue);


            //}
            //else if (variableType == "Double")
            //{
            //    Double variableString = Double.Parse(variableValue);
            //}
            //else if (variableType == "Boolean" &&  ) ;
            //{

                

            //}






            while (true)
            {
                    
               // session.SetDigitalPinMode(pinInInteger, PinMode.DigitalOutput);
                session.SetDigitalPin(pinInInteger, true);
                Thread.Sleep(delayInteger);
                session.SetDigitalPin(pinInInteger, false);
                Thread.Sleep(delayInteger);


            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "New";
            this.Load += new System.EventHandler(this.New_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void New_Load(object sender, EventArgs e)
        {

        }
    }
}

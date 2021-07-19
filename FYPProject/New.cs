using System;
using System.Threading;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace FYPProject
{
    class New 
    {
        ledControl ledControlObj = new ledControl();
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







        public static void PerformBasicTest(IFirmataProtocol session)
        {

             String v =  Led.t;
            String g = pinValue.Text;
            int value =  int.Parse(Led.t);

            var firmware = session.GetFirmware();
            Console.WriteLine($"Firmware: {firmware.Name} version {firmware.MajorVersion}.{firmware.MinorVersion}");
            var protocolVersion = session.GetProtocolVersion();
            Console.WriteLine($"Firmata protocol version {protocolVersion.Major}.{protocolVersion.Minor}");

            session.SetDigitalPinMode(value, PinMode.DigitalOutput);
            session.SetDigitalPin(value, true);


            //newcode
            String value = ledControl.pinValue.Text;
            Console.WriteLine(value);
            String delayValue = delayControlObj.getDelayValue();
            Console.WriteLine(delayValue);
            String variableType = handleVariablesObj.getvariableType();
            Console.WriteLine(variableType);
            String variableName = handleVariablesObj.getvariableName();
            Console.WriteLine(variableName);
            String variableValue = handleVariablesObj.getvariableValue();
            Console.WriteLine(variableValue);

            //newcode end




            while (true) 
            {
                session.SetDigitalPin(value,true);
                Thread.Sleep(1000);
                session.SetDigitalPin(value,false);
                Thread.Sleep(1000);


            }
        }
    }
}

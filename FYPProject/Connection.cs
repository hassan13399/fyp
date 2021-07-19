using System;
using System.Collections.Generic;
using System.Text;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace FYPProject
{
    class Connection
    {



        public static ISerialConnection GetConnection()
        {
            Console.WriteLine("Searching Arduino connection...");
            ISerialConnection connection = EnhancedSerialConnection.Find();
            if (connection == null)
                Console.WriteLine("No connection found. Make sure your Arduino board is attached to a USB port.");
            else
                Console.WriteLine($"Connected to port {connection.PortName} at {connection.BaudRate} baud.");

            return connection;
        }

    }//class
}

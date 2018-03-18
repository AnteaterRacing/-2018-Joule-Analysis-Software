using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace SerialTest
{
    class XBee
    {
        internal static SerialPort XBee1 = new SerialPort();
        
        internal static bool OpenCOM()
        {
            try
            {
                XBee1.PortName = "COM4";
                XBee1.BaudRate = 9600;
                XBee1.Parity = Parity.None;
                XBee1.StopBits = StopBits.One;
                XBee1.DataBits = 8;
                XBee1.Open();

                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);

                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;


namespace SerialTest
{
    class Program
    {


        static int numberOfSensors = 26;

        static void Main(string[] args)
        {

            OpenCOM();
   
            while (true)
            {
                int[] data = new int[numberOfSensors];

                int readByte;

                if (General.XBee.BytesToRead > 24)
                {

                    readByte = General.XBee.ReadByte();

                    if(readByte == 51)
                    {

                        for(int i=0; i<numberOfSensors; i++)
                        {
                            data[i] = General.XBee.ReadByte();

                            Console.Write(data[i]-48);
                        }

                        Console.WriteLine();
                    }


                }

            }


            General.XBee.Close();
        }

        static void WriteOutputToTextFile(string _data)
        {
            string FolderName = "C:/Users/Preston Rogers/Desktop/Communication";
            using (StreamWriter SW = new StreamWriter(FolderName + "\\test.txt", true))   //true makes it append to the file instead of overwrite
            {
                SW.WriteLine(_data);
                SW.Close();
            }
        }

        static bool OpenCOM()
        {
            try
            {
                General.XBee.PortName = "COM9";
                General.XBee.BaudRate = 9600;
                General.XBee.Parity = Parity.None;
                General.XBee.StopBits = StopBits.One;
                General.XBee.DataBits = 8;
                General.XBee.Open();

                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);

                return false;
            }

        }

    }
    public class General
    {
        internal static SerialPort XBee = new SerialPort();
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;


namespace SerialTest
{
    class Program : Form
    {
        static int numberOfSensors = 26;

        public Program()
        {
            // Initializes COM Port
            XBee.OpenCOM();

            // Create GUI

            
            while (true)
            {
                int[] data = new int[numberOfSensors];

                int readByte;

                if (XBee.XBee1.BytesToRead > 24)
                {

                    readByte = XBee.XBee1.ReadByte();

                    if (readByte == 255)
                    {
                        for (int i = 0; i < numberOfSensors; i++)
                        {
                            data[i] = XBee.XBee1.ReadByte();

                            Console.Write(data[i]);

                            WriteOutputToTextFile(data[i], true);
                        }

                        Console.WriteLine();
                        WriteOutputToTextFile(0, false);
                    }

                }

            }

            XBee.XBee1.Close();
        }

        static void WriteOutputToTextFile(int _data, bool entering_new_data)
        {
            string FolderName = "D:/WriteToFolder";
            using (StreamWriter SW = new StreamWriter(FolderName + "\\data.csv", true))   //true makes it append to the file instead of overwrite
            {
                if (entering_new_data)
                {
                    SW.Write(_data + ", ");
                }
                else
                {
                    SW.WriteLine();
                }
                   
                SW.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Interface_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //static void Main(string[] args)
        //{

        //    OpenCOM();

        //    while (true)
        //    {
        //        int[] data = new int[numberOfSensors];

        //        int readByte;

        //        if (General.XBee.BytesToRead > 24)
        //        {

        //            readByte = General.XBee.ReadByte();

        //            if (readByte == 255)
        //            {
        //                for (int i = 0; i < numberOfSensors; i++)
        //                {
        //                    data[i] = General.XBee.ReadByte();

        //                    Console.Write(data[i]);
        //                    WriteOutputToTextFile(data[i], true);
        //                }

        //                Console.WriteLine();
        //                WriteOutputToTextFile(0, false);
        //            }

        //        }

        //    }

        //    General.XBee.Close();
        //}




    }
}

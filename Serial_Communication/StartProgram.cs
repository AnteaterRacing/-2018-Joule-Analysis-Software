/*__________________________________

              P R O G R A M   C L A S S
              
   For XBEE WeatherStation Telemetry Demo
                   Created 8/18/2017
                         Ron Kessler
____________________________________

 This class is the entry point for the app.

 */


using System;
using System.Windows.Forms;

namespace SerialTest
{
    // The point of this class is to initialize the program by enabling visual styles
    static class StartProgram
    {
        // [STAThread] must be present on the entry point of any application that uses Windows Forms
        // we are using windows forms for the GUI

        [STAThread]

        static void Main()
        {
            // enablevisualstyles is necessary because it allows colors, fonts, and other visual elements (such as buttons) (it is usually the first line in the main function
            Application.EnableVisualStyles();

            //
            Application.SetCompatibleTextRenderingDefault(false);

            // begins running a standard application message loop on the current thread and makes the specified form visible
            // goes into Serial_communication.cs and creates a new class of whatever the name is, in this case the class is 'Program'
            Application.Run(new Program());                  //now create mainForm object
        }
    }
}

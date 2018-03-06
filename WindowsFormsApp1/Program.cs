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


namespace XBEE_READER
{
    static class Program
    {
       

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());                  //now create mainForm object
        }
    }
}

/*________________________________________

           G E N E R A L   P R O P E R T I E S
           
         For XBEE WeatherStation Telemetry Demo
                          Created 8/18/2017
                               Ron Kessler
_________________________________________
 * Updated 9/20/2017
 *      Removed unused properties and usings
 * 
 *      9/24/2017   Did some clean up and defined regions
 */
using System.Windows.Forms;
using System.IO.Ports;

using System.Collections.Generic;


namespace XBEE_READER
{
    public class General
    {
        public General()
        {
            
        }

        #region My Static References/Objects
                public static frmMain mainForm;     //we use this as a handle to the main form(frmMain)

                //internal static SerialPort RS232 = new SerialPort();        //define our serial port

                internal static SerialPort XBee = new SerialPort();         // define serial port for Xbee

                internal static List<string> rawReadings = new List<string>();
        #endregion

        #region Properties

        private static string _connMsg = "Connected...";
       internal static string ConnectedMsg
        {
            get { return _connMsg; }

        }

        private static string _disconnectedMsg = "Disconnected";
        internal static string DisconnectedMsg
        {
            get { return _disconnectedMsg; }

        }

        internal static string LogFile = "..\\..\\DataLog.txt";
        internal static string WhichComPort { get; set; }
        internal static bool IsConnected { get; set; }
        internal static bool ReadStream { get; set; }
        internal static bool DoFileLogging { get; set; }
        internal static bool Log2SQL { get; set; }
        internal static string MSGTITLE = "UCI Race Car Telemetry";


        //---sensor data
        internal static string XAxis { get; set; }
        internal static string YAxis { get; set; }
        internal static string ZAxis { get; set; }


        // Tire temperature sensor data
        internal static string TTBR1 { get; set; }
        internal static string TTBR2 { get; set; }
        internal static string TTBR3 { get; set; }

        internal static string TTBL1 { get; set; }
        internal static string TTBL2 { get; set; }
        internal static string TTBL3 { get; set; }

        internal static string TTFR1 { get; set; }
        internal static string TTFR2 { get; set; }
        internal static string TTFR3 { get; set; }

        internal static string TTFL1 { get; set; }
        internal static string TTFL2 { get; set; }
        internal static string TTFL3 { get; set; }


        // Motor temperature sensor data
        internal static string MT1 { get; set; }
        internal static string MT2 { get; set; }


        // Wheel speed sensor data
        internal static string WSBR { get; set; }
        internal static string WSBL { get; set; }
        internal static string WSFR { get; set; }
        internal static string WSFL { get; set; }


        // Throttle position sensor data
        internal static string throttleR { get; set; }
        internal static string throttleL { get; set; }


        // Battery pack voltage, current, and temperature sensor data
        internal static string packVoltage { get; set; }
        internal static string packCurrent { get; set; }
        internal static string packTemperature { get; set; }


        // Steering angle sensor data
        internal static string steeringAngle { get; set; }


        // Accelerator and brake angle
        internal static string accelAngle { get; set; }
        internal static string brakeAngle { get; set; }




        internal static string receiveString { get; set; }



        #endregion

        internal static void NotifyUser(string msg)
        {
            MessageBox.Show(msg, MSGTITLE, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

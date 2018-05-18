using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace Data_Interface_Form
{
    public class General
    {
        internal static SerialPort XBee = new SerialPort();
        public static MainForm mainFormAddress;
        public static VisualDisplayForm visualDisplayFormAddress;

        internal static string MSGTITLE = "UCI Race Car Telemetry";

        internal static List<int> rawReadings = new List<int>();
        internal static List<int> dataForCsv = new List<int>();

        //Below is used for graphing to see how long it has been
        internal static Stopwatch elapsedTime = new Stopwatch();
        //Below is used to track when we started getting data
        internal static string startTime { get; set; }

        internal static int chartSpeed { get; set; }

        internal static int numberOfSensors = 26;

        internal static byte[] data = new byte[General.numberOfSensors];
        internal static int[] dataInt = new int[General.numberOfSensors];

        internal static string ChosenComPort { get; set; }
        internal static bool ConnectedToCom { get; set; }
        internal static bool ReadingFromTheStream { get; set; }
        internal static bool RunThatBgDataWorker { get; set; }
        internal static bool AllowCsvWriting { get; set; }

        Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();


        internal static string ConnectedMsg
        {
            get { return "You are now connected!"; }
        }


        internal static string DisconnectedMsg
        {
            get { return "Disconnected!"; }
        }

        internal static void NotifyUser(string msg)
        {
            MessageBox.Show(msg, MSGTITLE,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #region All of the sensor variable names
        //make sure you put the correct number of sensors
        

        // Tire temperature sensor data
        internal static int TTBR1 { get; set; }
        internal static int TTBR2 { get; set; }
        internal static int TTBR3 { get; set; }

        internal static int TTBL1 { get; set; }
        internal static int TTBL2 { get; set; }
        internal static int TTBL3 { get; set; }

        internal static int TTFR1 { get; set; }
        internal static int TTFR2 { get; set; }
        internal static int TTFR3 { get; set; }

        internal static int TTFL1 { get; set; }
        internal static int TTFL2 { get; set; }
        internal static int TTFL3 { get; set; }


        // Motor temperature sensor data
        internal static int MT1 { get; set; }
        internal static int MT2 { get; set; }


        // Wheel speed sensor data
        internal static int WSBR { get; set; }
        internal static int WSBL { get; set; }
        internal static int WSFR { get; set; }
        internal static int WSFL { get; set; }


        // Throttle position sensor data
        internal static int throttleR { get; set; }
        internal static int throttleL { get; set; }


        // Battery pack voltage, current, and temperature sensor data
        internal static int packVoltage { get; set; }
        internal static int packCurrent { get; set; }
        internal static int packTemperature { get; set; }
        internal static int packCharge { get; set; }


        // Steering and brake angle
        internal static int steeringAngle { get; set; }
        internal static int brakeAngle { get; set; }
        #endregion


    }
}

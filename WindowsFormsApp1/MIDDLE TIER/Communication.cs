/*__________________________________

                X B E E   R E A D E R
    C O M M U N I C A T I O N   C L A S S
   For XBEE WeatherStation Telemetry Demo
                   Created 8/18/2017
                         Ron Kessler
____________________________________
This class manages com operations
 
 Updated:       1/15/2017  Removed Save2Log and SQL calls. Handled in new button click events 
                            
                     9/25/2017  Removed the DataReceived event handler. A timer on frmMain calls
                                GetStream() every 500 ms.  Then ParseData() calls the UpdateGUI()
                                method on frmMain. This makes the GUI display data very fast!
 */

using System;
using System.Windows.Forms;
using System.IO.Ports;              //add this
using System.IO;

namespace XBEE_READER
{
    public class Communication
    {

        #region Open Com Port
        internal static bool OpenCom()
        {
            try
            {
                //General.RS232.PortName = General.WhichComPort.Trim();
                //General.RS232.BaudRate = 9600;
                //General.RS232.Parity = Parity.None;
                //General.RS232.StopBits = StopBits.One;
                //General.RS232.DataBits = 8;
                //General.RS232.Open();

                General.XBee.PortName = General.WhichComPort.Trim();
                General.XBee.BaudRate = 9600;
                General.XBee.Parity = Parity.None;
                General.XBee.StopBits = StopBits.One;
                General.XBee.DataBits = 8;
                General.XBee.Open();
                
                return true;
            }

            catch (Exception ex)
            {
                General.NotifyUser("Unable to connect." + ex.Message.ToString());
                General.IsConnected = false;
                
                return false;
            }

        }

        #endregion

        #region Read Raw Data & Parse it
       
        internal static void GetStream()
        {
            //---grab any data coming from Com port
            if (General.ReadStream)         //did they click start button? ReadStream is a flag
            {
                if (General.XBee.IsOpen)
                {
                    int numOfSensors = General.XBee.BytesToRead; // number of bytes in receive buffer (COM port storage?) 
                                                                 // number would be 26 if we had 26 sensors

                    byte[] buffer = new byte[numOfSensors]; // creates an array of bytes that we will store sensor data into
                                                            // if we had 26 sensors then buffer would have 26 elements
                                                            // these bytes are between 0-254 and represent the value for each sensor

                    General.XBee.Read(buffer, 0, numOfSensors); // puts the bytes from COM port into the buffer array


                    for (int i = 0; i < numOfSensors; i++) // going through and converting the bytes into integers
                        General.sensorData.Add(buffer[i]); // converting byte to int and storing in an int array

                    //setSensorValues(); // sets the values for each sensor to the ones in the int array
                    //printToFile(); // puts this stream of sensor values into another file for future use


                    General.mainForm.UpdateGUI();
                }
            }
        }

        public static void setSensorValues()
        {
            General.TTBR1 = General.sensorData[0];
            General.TTBR2 = General.sensorData[1];
            General.TTBR3 = General.sensorData[2];

            General.TTBL1 = General.sensorData[3];
            General.TTBL2 = General.sensorData[4];
            General.TTBL3 = General.sensorData[5];

            General.TTFR1 = General.sensorData[6];
            General.TTFR2 = General.sensorData[7];
            General.TTFR3 = General.sensorData[8];

            General.TTFL1 = General.sensorData[9];
            General.TTFL2 = General.sensorData[10];
            General.TTFL3 = General.sensorData[11];

            General.MT1 = General.sensorData[12];
            General.MT2 = General.sensorData[13];


            // Wheel speed sensor data being set
            General.WSBR = General.sensorData[14];
            General.WSBL = General.sensorData[15];
            General.WSFR = General.sensorData[16];
            General.WSFL = General.sensorData[17];


            // Throttle positions being set
            General.throttleR = General.sensorData[18];
            General.throttleL = General.sensorData[19];


            // Battery pack data being set
            General.packVoltage = General.sensorData[20];
            General.packCurrent = General.sensorData[21];
            General.packTemperature = General.sensorData[22];


            // Steering angle being set
            General.steeringAngle = General.sensorData[23];


            // Accelerator and brake angle being set
            General.accelAngle = General.sensorData[24];
            General.brakeAngle = General.sensorData[25];
        }





        public static void ParseData(string XBEEData)
        {
            //---break the stream and assign to the properties in General.
            try
            {
                if (XBEEData.Length > 2)
                {
                    /* 
                     * For tire and motor temp, use 2 bytes per sensor.
                     * Since first 14 sensors in protocol are tire temperature then motor temperature
                     * the first 28 bytes (numbers) correspond to those 14 sensors
                     */

                    

                    //---update the GUI with a call to the form's method

                }
            }
            catch (Exception ex)
            {
                General.NotifyUser("An error occurred while reading data.\n" + XBEEData + ex.Message.ToString());
            }

      }

        #region Close Com Port
        internal static void CloseCom()
        {
            //General.RS232.Close();
            General.XBee.Close();

        }

#endregion
    }
}
#endregion
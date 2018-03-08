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
                    int numOfBytes = General.XBee.BytesToRead;
                    byte[] buffer = new byte[numOfBytes];
                    General.XBee.Read(buffer, 0, numOfBytes);

                    General.receiveString = System.Text.Encoding.Default.GetString(buffer);
                    ParseData(General.receiveString);

                    //General.rxString = General.XBee.ReadExisting();



                    General.mainForm.UpdateGUI();
                }

                //if (General.RS232.IsOpen)
                //{
                //    do
                //    {
                //        string myStream = General.RS232.ReadLine();
                //        ParseData(myStream);
                //    }
                //    while (General.RS232.BytesToRead > 2);
                //}
            }
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

                    General.TTBR1 = XBEEData.Substring(0, 2);
                    General.TTBR2 = XBEEData.Substring(2, 4);
                    General.TTBR3 = XBEEData.Substring(4, 6);

                    General.TTBL1 = XBEEData.Substring(6, 8);
                    General.TTBL2 = XBEEData.Substring(8, 10);
                    General.TTBL3 = XBEEData.Substring(10, 12);

                    General.TTFR1 = XBEEData.Substring(12, 14);
                    General.TTFR2 = XBEEData.Substring(14, 16);
                    General.TTFR3 = XBEEData.Substring(16, 18);

                    General.TTFL1 = XBEEData.Substring(18, 20);
                    General.TTFL2 = XBEEData.Substring(20, 22);
                    General.TTFL3 = XBEEData.Substring(22, 24);

                    General.MT1 = XBEEData.Substring(24, 26);
                    General.MT2 = XBEEData.Substring(26, 28);

                    /*
                   
                    // Wheel speed sensor data being set
                    General.WSBR = XBEEData.Substring(, );
                    General.WSBL = XBEEData.Substring(, );
                    General.WSFR = XBEEData.Substring(, );          
                    General.WSFL = XBEEData.Substring(, );


                    // Throttle positions being set
                    General.throttleR = XBEEData.Substring(, );
                    General.throttleL = XBEEData.Substring(, );
                    

                    // Battery pack data being set
                    General.packVoltage = XBEEData.Substring(, );
                    General.packCurrent = XBEEData.Substring(, );
                    General.packTemperature = XBEEData.Substring(, );


                    // Steering angle being set
                    General.steeringAngle = XBEEData.Substring(, );


                    // Accelerator and brake angle being set
                    General.accelAngle = XBEEData.Substring(, );
                    General.brakeAngle = XBEEData.Substring(, );

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
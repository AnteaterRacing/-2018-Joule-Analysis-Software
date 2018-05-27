using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

//using Excel = Microsoft.Office.Interop.Excel;

namespace Data_Interface_Form
{
    static class Communication
    {

        internal static bool OpenCOM()
        {
            try
            {
                General.XBee.PortName = General.ChosenComPort.Trim();
                General.XBee.BaudRate = 9600;
                General.XBee.Parity = Parity.None;
                General.XBee.StopBits = StopBits.One;
                General.XBee.DataBits = 8;
                General.XBee.Open();

                return true;
            }
            catch (IOException ex)
            {
                General.NotifyUser("Unable to connect." + ex.Message.ToString());
                General.ConnectedToCom = false;

                return false;
            }
        }

        internal static void GetInfoFromCOM()
        {
            //If statemenet below makes sure that the user pressed the start button
            if (General.ReadingFromTheStream)
            {
                if(General.XBee.IsOpen)
                {

                    //byte[] data = new byte[General.numberOfSensors];

                    //int[] dataInt = new int[General.numberOfSensors];

                    int readByte;

                    if (General.XBee.BytesToRead > 0)
                    {
                        readByte = General.XBee.ReadByte();

                        if (readByte == 255)
                        {
                            General.rawReadings.Add(255);
                            General.XBee.Read(General.data, 0, General.numberOfSensors);

                            //This is to make sure there will be information to put on Csv
                            General.AllowCsvWriting = true;

                            //To get the timing of each data point
                            General.dataForCsv.Add((int)General.elapsedTime.ElapsedMilliseconds);

                            for (int i = 0; i < General.numberOfSensors; i++)
                            {
                                //data[i] = General.XBee.ReadByte();

                                General.dataInt[i] = Convert.ToInt32(General.data[i].ToString());

                                //Add the incoming data to the long integer list of rawreadings
                                General.rawReadings.Add(General.dataInt[i]);
                                General.dataForCsv.Add(General.dataInt[i]);
                            }

                            setSensorValues(General.dataInt);
                        }
                    }
                }
            }
        }



        public static void setSensorValues(int[] sensorData)
        {
            General.TTBR1 = (int)convertToTemp(sensorData[0]);
            //instead of just equating these, you would perform a function before setting General.TTBR1

            General.TTBR2 = (int)convertToTemp(sensorData[1]);
            General.TTBR3 = (int)convertToTemp(sensorData[2]);

            General.TTBL1 = (int)convertToTemp(sensorData[3]);
            General.TTBL2 = (int)convertToTemp(sensorData[4]);
            General.TTBL3 = (int)convertToTemp(sensorData[5]);

            General.TTFR1 = (int)convertToTemp(sensorData[6]);
            General.TTFR2 = (int)convertToTemp(sensorData[7]);
            General.TTFR3 = (int)convertToTemp(sensorData[8]);

            General.TTFL1 = (int)convertToTemp(sensorData[9]);
            General.TTFL2 = (int)convertToTemp(sensorData[10]);
            General.TTFL3 = (int)convertToTemp(sensorData[11]);

            General.MT1 = (int)convertToTemp(sensorData[12]);
            General.MT2 = (int)convertToTemp(sensorData[13]);

            // Wheel speed sensor data being set
            General.WSBR = (int)map(sensorData[14], 0, 255, 0, 54);
            General.WSBL = (int)map(sensorData[15], 0, 255, 0, 54);
            General.WSFR = (int)map(sensorData[16], 0, 255, 0, 54);
            General.WSFL = (int)map(sensorData[17], 0, 255, 0, 54);


            // Throttle positions being set
            General.throttleR = sensorData[18];
            General.throttleL = sensorData[19];


            // Battery pack data being set
            General.packVoltage = (int)map(Pack_Conversion(sensorData[20], sensorData[21]), 0, 255, 0, 94) / 10;
            General.packCurrent = (int)map(Pack_Conversion(sensorData[22], sensorData[23]), 0, 255, 0, 500) / 10;
            // We do not know the ranges for the pack Temperatre currently
            General.packTemperature = sensorData[24];
            General.packCharge = sensorData[25];

            // Steering and brake angle being set
            General.steeringAngle = sensorData[26];
            General.brakeAngle = sensorData[27];
        }

        #region calculations for sensor data
        public static double convertToTemp(int voltageADC)
        {
            double voltage = (voltageADC / 255.0) * (5.0);

            double temperature = Math.Log(voltage / 1.25) / Math.Log(1.0087);

            //Below is a conditional in case temperature is a low number
            temperature = (temperature < 0) ? -10.0 : temperature;

            return temperature;
        }
        public static float map(this float value, float from1, float to1, float from2, float to2)
        {
            return ((value - from1) / (to1 - from1)) * (to2 - from2) + from2;
        }

        public static int Pack_Conversion(int byte1, int byte2)
        {
            // Recombines the two bytes into 1.
            return (byte1 << 8) | byte2;
        }
        #endregion

        #region Optional Code for writing data to CSV file

        //Below is optional code for writing to a csv file
        internal static void WriteOutputToTextFile(List<int> dataForCsv)
        {
            string dateForCSV = General.startTime;

            string FolderName = "C:/Users/Preston Rogers/Desktop/Communication";

            using (StreamWriter SW = new StreamWriter(FolderName + "\\data_" + dateForCSV + ".csv", true))   //true makes it append to the file instead of overwrite
            {
                //Divided by number of Sensors + 1 to acccount for the sensors and timing information
                for (int i = 0; i < dataForCsv.Count; i++)
                {
                    if (i % (General.numberOfSensors+1) == 0)
                    {
                        SW.WriteLine();
                    }

                    SW.Write(dataForCsv[i] + ", ");
                }

                SW.Close();
            }
        }

        #endregion

        internal static void CloseCom()
        {
            General.XBee.Close();
        }

    }

}

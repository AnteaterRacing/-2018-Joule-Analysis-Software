/*__________________________________

                X B E E   R E A D E R
        D A T A L O G G E R   C L A S S
   For XBEE WeatherStation Telemetry Demo
                   Created 8/29/2017
                         Ron Kessler
____________________________________
This class manages file LOGGING operations
 
 Updated 
                10/22/2017 
                10/13/2017  Add Date/time entry at start of log file
 */

using System;
using System.IO;


namespace XBEE_READER
{
    class DataLogger
    {

        #region Save to Text File
        //---if the want logging, save data to textfile in project folder.
        
        internal static void Save2File()
        {
           //if (General.mainForm.lbHistory.Items.Count > 0)
           if (General.rawReadings.Count >0)            //read from list not listbox 10/22/2017
            {
                DateTime now = DateTime.Now;
                try
                {
                    using (StreamWriter myWriter = new StreamWriter(General.LogFile, append: false))
                    {
                        //---add a date time stamp
                        myWriter.Write("Start of Log...");
                        myWriter.Write(now.ToString());         //shows date/time   10/13/2017
                        myWriter.WriteLine(" ");

                        //---cycle through list and save items
                        foreach(string whichItem in General.rawReadings)       //use list structure not listbox 10/22/2017
                        {
                            myWriter.Write(whichItem);
                        }

                        General.NotifyUser("Your data has been saved.");
                    }
                }
                catch (Exception ex)
                {
                    General.NotifyUser("I could not save your changes." + ex.Message);

                }
            }
        }
        #endregion

        #region Read Log

       
        internal static void ReadLogFile()        //xAxis, yAxis, light sent from com class
        {
            //---show Form 'ShowLogFile'
            ShowLogFile displayLog = new ShowLogFile();
            displayLog.ShowDialog();

        }
        #endregion

        #region Clear Log
        internal static void ClearLogFile()
        {
            
                try
                {
                    using (StreamWriter myWriter = new StreamWriter(General.LogFile, false))  
                    {
                        myWriter.WriteLine("");
                        General.NotifyUser("The log data has been deleted.");
                    }
                }

                catch (Exception ex)
                {
                    General.NotifyUser("I could not delete the log data." + ex.Message);
                }

            }
        
        #endregion
    }
}

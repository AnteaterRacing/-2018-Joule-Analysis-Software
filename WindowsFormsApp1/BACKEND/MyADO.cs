/*__________________________________

                 M Y    A D O   C L A S S
           
         For XBEE WeatherStation Telemetry Demo
                          Created 9/19/2017
                               Ron Kessler
____________________________________
 *This manages CRUD ops for my local .mdf
 *
 * Updated 
 *              10/22/2017   Reads from General.rawData List instead of listbox to save time
 *                                  ALSO USES SQL TRANSACTION TO SAVE TIME!!
 * 10/17/2017  Steamlined the Save2DB method and tested it.
 * 9/19/2017
 *      Designed main definitions.
 *      
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;     //for Mr. Messagebox
using System.Data;
using System.Data.SqlClient;

namespace XBEE_READER
{
    public class MyADO
    {
        public MyADO()
        {

        }

        #region Create Conn
        //---create the conn string and the connection object
        static string connString = "Data Source =tcp:s15.winhost.com;Initial Catalog=DB_6901_xbeeweather;User ID=DB_6901_xbeeweather_user;Password=hobbit;";
        static SqlConnection myConn = new SqlConnection(connString);

        #endregion

        #region Display Records
        internal static void DisplayRecords()
        {
            //---show Form 'ShowLogFile'
            frmSQLRecords displaySQL = new frmSQLRecords();
            displaySQL.Show();

        }
        #endregion

        #region Post to SQL DB
        internal static void Post2DB()
        {

            //---now cycle through the list<> items and parse them and save to DB table. 10/22/2017
            //  Using a list structure to save time
            myConn.Close();

            //--scratch variables to read each line that starts with X,Y,Z
            string itemXFromLB = "";
            string itemYFromLB = "";
            string itemZFromLB = "";

            SqlCommand cmd = new SqlCommand("INSERT INTO Accelerometer (xAxis, yAxis,zAxis) VALUES (@xAxis, @yAxis, @zAxis)", myConn);
            SqlTransaction trans;

            myConn.Open();      //MAKE SURE THIS IS OPEN FIRST

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction

            trans = myConn.BeginTransaction();
            cmd.Transaction = trans;
            cmd.Connection = myConn;

            try
            {
                foreach (string myItem in General.rawReadings)      //10/22/2017 read from list not listbox
                {
                        if (myItem.Trim().Length > 0)
                        {

                            if (myItem.Substring(0, 1) == "X")
                            {

                                itemXFromLB = myItem.Substring(1);
                                cmd.Parameters.AddWithValue("@xAxis", itemXFromLB);
                            }
                            else if (myItem.Substring(0, 1) == "Y")
                            {
                                itemYFromLB = myItem.Substring(1);
                                cmd.Parameters.AddWithValue("@yAxis", itemYFromLB);
                            }
                            else if (myItem.Substring(0, 1) == "Z")
                            {
                                itemZFromLB = myItem.Substring(1);
                                cmd.Parameters.AddWithValue("@zAxis", itemZFromLB);

                                //---now since we have all three readings, make it so!
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();         //use this or it will keep using old parameter values!
                            }
                        }
                }
                trans.Commit();
                myConn.Close();
                General.NotifyUser("Your SQL records have been saved. ");
            }
            catch (Exception ex)
            {
                General.NotifyUser("An error occurred while saving to database. " + ex.Message.ToString());
                    try
                    {
                        trans.Rollback();
                        General.NotifyUser("Your transaction was rolled back.");
                    }
                    catch (Exception ex2)
                    {
                        General.NotifyUser("Unable to rollback the transaction" + ex2.Message.ToString());

                        myConn.Close();
                            cmd.Dispose();
                    }
            }
        }
        #endregion

        #region Delete Record
        internal static void DeleteRecords()
        {
                SqlCommand myDelete = new SqlCommand(@"DELETE FROM Accelerometer", myConn);

                try
                {
                    myConn.Open();
                    myDelete.ExecuteNonQuery();

                    General.NotifyUser("SQL records have been deleted.");
               
                }
                catch (Exception ex)
                {
                    General.NotifyUser("An error occurred while deleting database records. " + ex.Message.ToString());
                }
                finally
                {
                    myConn.Close();
                }
        }
        #endregion

    }

}

    


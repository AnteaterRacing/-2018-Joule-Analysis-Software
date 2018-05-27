using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Interface_Form
{
    class BackEnd
    {
        //make sure the string below goes to the right directory for your database
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\Vincent Ha\Documents\GitHub\JouleAnalysisSoftware\Data_Interface_Form\Data_Interface_Form\SensorDatabase.mdf;Integrated Security=True";
        static SqlConnection myConn2SensorDB = new SqlConnection(connString);

        #region Post to the SQL Database
        //Post the information retrieved at COM port to local database
        internal static void Post2SensorDB()
        {
            myConn2SensorDB.Close();

            //Now the SQL code that will post the information to the database
            SqlCommand command = new SqlCommand("INSERT INTO SensorDataTable (TTBR1,TTBR2,TTBR3,TTBL1,TTBL2,TTBL3,TTFR1,TTFR2,TTFR3,TTFL1,TTFL2,TTFL3,MT1,MT2,WSBR,WSBL,WSFR,WSFL,throttleR,throttleL,packVoltage,packCurrent,packTemperature,steeringAngle,accelAngle,brakeAngle) VALUES (@TTBR1,@TTBR2,@TTBR3,@TTBL1,@TTBL2,@TTBL3,@TTFR1,@TTFR2,@TTFR3,@TTFL1,@TTFL2,@TTFL3,@MT1,@MT2,@WSBR,@WSBL,@WSFR,@WSFL,@throttleR,@throttleL,@packVoltage,@packCurrent,@packTemperature,@steeringAngle,@accelAngle,@brakeAngle)", myConn2SensorDB);
            SqlTransaction trans;

            myConn2SensorDB.Open();

            trans = myConn2SensorDB.BeginTransaction();

            command.Transaction = trans;
            command.Connection = myConn2SensorDB;

            try
            {
                //Take each item in the sensor data list and add it to the SQL database
                int sensorCount = 0;

                foreach (int dataPoint in General.rawReadings)
                {

                    if (dataPoint == 255)
                    {
                        sensorCount = 1;

                        continue;
                    }

                    switch (sensorCount)
                    {
                        case 1:
                            command.Parameters.AddWithValue("@TTBR1", dataPoint);
                            sensorCount++;
                            break;
                        case 2:
                            command.Parameters.AddWithValue("@TTBR2", dataPoint);
                            sensorCount++;
                            break;
                        case 3:
                            command.Parameters.AddWithValue("@TTBR3", dataPoint);
                            sensorCount++;
                            break;
                        case 4:
                            command.Parameters.AddWithValue("@TTBL1", dataPoint);
                            sensorCount++;
                            break;
                        case 5:
                            command.Parameters.AddWithValue("@TTBL2", dataPoint);
                            sensorCount++;
                            break;
                        case 6:
                            command.Parameters.AddWithValue("@TTBL3", dataPoint);
                            sensorCount++;
                            break;
                        case 7:
                            command.Parameters.AddWithValue("@TTFR1", dataPoint);
                            sensorCount++;
                            break;
                        case 8:
                            command.Parameters.AddWithValue("@TTFR2", dataPoint);
                            sensorCount++;
                            break;
                        case 9:
                            command.Parameters.AddWithValue("@TTFR3", dataPoint);
                            sensorCount++;
                            break;
                        case 10:
                            command.Parameters.AddWithValue("@TTFL1", dataPoint);
                            sensorCount++;
                            break;
                        case 11:
                            command.Parameters.AddWithValue("@TTFL2", dataPoint);
                            sensorCount++;
                            break;
                        case 12:
                            command.Parameters.AddWithValue("@TTFL3", dataPoint);
                            sensorCount++;
                            break;
                        case 13:
                            command.Parameters.AddWithValue("@MT1", dataPoint);
                            sensorCount++;
                            break;
                        case 14:
                            command.Parameters.AddWithValue("@MT2", dataPoint);
                            sensorCount++;
                            break;
                        case 15:
                            command.Parameters.AddWithValue("@WSBR", dataPoint);
                            sensorCount++;
                            break;
                        case 16:
                            command.Parameters.AddWithValue("@WSBL", dataPoint);
                            sensorCount++;
                            break;
                        case 17:
                            command.Parameters.AddWithValue("@WSFR", dataPoint);
                            sensorCount++;
                            break;
                        case 18:
                            command.Parameters.AddWithValue("@WSFL", dataPoint);
                            sensorCount++;
                            break;
                        case 19:
                            command.Parameters.AddWithValue("@throttleR", dataPoint);
                            sensorCount++;
                            break;
                        case 20:
                            command.Parameters.AddWithValue("@throttleL", dataPoint);
                            sensorCount++;
                            break;
                        case 21:
                            command.Parameters.AddWithValue("@packVoltage", dataPoint);
                            sensorCount++;
                            break;
                        case 22:
                            command.Parameters.AddWithValue("@packCurrent", dataPoint);
                            sensorCount++;
                            break;
                        case 23:
                            command.Parameters.AddWithValue("@packTemperature", dataPoint);
                            sensorCount++;
                            break;
                        case 24:
                            command.Parameters.AddWithValue("@steeringAngle", dataPoint);
                            sensorCount++;
                            break;
                        case 25:
                            command.Parameters.AddWithValue("@accelAngle", dataPoint);
                            sensorCount++;
                            break;
                        case 26:
                            command.Parameters.AddWithValue("@brakeAngle", dataPoint);

                            //Now that we got all of the data points we need for one entry, add it in!
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();

                            sensorCount = 0;
                            break;
                        default:
                            break;
                    }

                    trans.Commit();
                    myConn2SensorDB.Close();
                    General.NotifyUser("Your SQL records have been saved. ");
                }  
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

                    myConn2SensorDB.Close();
                    command.Dispose();
                }
            }


        }
        #endregion
    }
}

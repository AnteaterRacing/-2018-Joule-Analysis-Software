/*______________________________________________
          U C I   X B E E   AC C E L E R O M E T E R
                           Version 2.2

              For UCI Racecar Telemetry Demo
                     Created 10/7/2017
                           Ron Kessler
                     Updated 10/15/2017
________________________________________________
 * PURPOSE: 
     * This app gathers accelerometer data from an Arduino
     * controlled ADXL-355 accelerometer.
     * 
     * The data is sent via XBEE to a receiver XBEE in the PC.
     * This app reads the serial data from the com port and
     * displays it on screen.
     * 
     * There are options to log the data to a textfile located
     * in the solution folder and/or save the data to a remote
     * SQL DB table hosted on Winhost.Com
     * 
     * This app can graph the incoming data as well as display it
     * in a listbox.
     * 
     * 
 * 
 * ADAPTED FROM MY ORIGINAL XBEE WEATHER DEMO
 * Updated:
 *        10/15/2017 Changed how data is logged. Reads listbox data and saves to disk
 *                          Added Notify User method in General class.
 *                          Now I use 1 background worker to save SQL records.
 *                          Log files and SQL table keys off listbox items. You must choose yes to grab data
 *                          before saving to a log/SQL.
 *                          Save 2 Log now reads each listbox item and sends to disk. 
 *                          Timer interval = 100ms 
 *        
 *        
 *       10/13/2017  Made chart scroll to the left. Can use a scrollbar to adjust speed.
 *                          Timer is set for 100ms. This controls thread that reads data and updates GUI.
 *      10/7/2017   Modified code from original demo
 *      
 *      
 *  
 *                                                                 
 */
 #region original History Updates
//     8/18/2017  Designed main definitions.
// *
// *      9/20/2017 Tested SQL remote DB and got chart working.Only charts
// * xAxis & yAxis.Good to go
// *      9/22/2017  Added ref to frmMain in General class so I can call UpdateGui()
// * from the Communication Class.Eliminated the timer that used to call
//* the update GUI method.Weather data was not being updated quickly.

//*
//*
//*      9/23/2017 3:45   All working just slow to respond to sensor changes.Only chart Light
//* since it changes more often.Need to look a charting demo (in AdvancedProgramming)
// * and see how they use time on the x- axis and also how they set the style.
// *                                 
// *      9/24/2017  12:43  Added the chart from another project because it looks cool. Also only displaying Light
// *                                  level because it changes and is more interesting.
// *                                  
// *                                  Added ability to disable Clear Log and Delete SQL buttons if their respective checkboxes are
// *                                  selected.You cannot write to a file that is already open...
// *                                  
// *                                  Testing still show s a significant lag between serial stream and GUI updates.

//* CHANGED ARDUINO SKETCH TO SEND DATA EVERY 1000 ms.SEE ARDUINO_XBEE_STREAM_2
// *                                  in folder NAS-2\Advanced Programming\XBEE Telemetry
// *                                  
// *                                  Made my lblMsg disabled because it seems unnecessay....
// *      9/24/2017   3PM Working on changing the serial comm code to async methods to eliminate datreceived event.                
// *      
// *      
// *      9/25/2017   9:30PM Added a timer to read the stream in Communication class every 500ms.
// * The Communication.ParseData method calls the UpdateGUI method in the
//* frmMain form.

//* I eliminated the DataReceived event handler for the serial port so the app readings
// *                                      would be responsive. As of now the Arduino transmits every 1000ms. 
// *                                      I will change that to 500ms so stream will be closer to real time.
// *                                      See code changes in Communication.GetStream().
// *                                      


 #endregion





using System;
using System.IO.Ports;              //add this
using System.Windows.Forms;


namespace XBEE_READER
{
    public partial class frmMain : Form
    {
        //---can now choose what axes to graph (10/11/2017)
        private bool graphX = false;
        private bool graphY = false;
        private bool graphZ = false;

        private int chartSpeed = 5;         //10/13/2017 Used to control chart scrolling speed

        #region Form constructor

        public frmMain()
        {
            InitializeComponent();

          
        }
#endregion 

        #region Load and Initialize combo box for Com Ports
        private void frmMain_Load(object sender, EventArgs e)
        {
                     
            //---added 9/22/17
            General.mainForm = this;        //set a reference back to this form so we can call methods from another class!

            //---usual setups
            lblComStatus.Text = General.DisconnectedMsg;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = false;
            btnRefresh.Enabled = true;
         
            
            //---show all available Com ports
            GetComPorts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetComPorts();
        }

        private void GetComPorts()
        {
            cboPorts.Items.Clear();
            foreach (string sp in SerialPort.GetPortNames())    //uses IO.Ports namespace
            {
                cboPorts.Items.Add(sp);
            }

            cboPorts.SelectedIndex = -1;
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---get selected port from UI
            try
            {
                General.WhichComPort = cboPorts.SelectedItem.ToString();
                if (General.WhichComPort.Substring(0, 3) == "COM")
                    btnConnect.Enabled = true;
                else
                    btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                lblComStatus.Text = "Cannot access that port." + ex.Message.ToString();
            }
        }
        #endregion

        #region Start | Stop Streaming |Timer

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            if (General.IsConnected)
            {
                General.ReadStream = true;
                btnStartStream.Enabled = false;
                btnStopStream.Enabled = true;

                //---10/15/17  Save to log only when stopped streaming
                btnSave2LogFile.Enabled = false;
                grpSQL.Enabled = false;

                lbHistory.Items.Clear();
                General.Log2SQL = true;

                timer1.Enabled = true;
                timer1.Start();
            }
        }
        private void btnStopStream_Click(object sender, EventArgs e)
        {
            General.ReadStream = false;
            btnStartStream.Enabled = true;
            btnStopStream.Enabled = false;
            
            //---10/15/17  Save to log only when stopped streaming
            btnSave2LogFile.Enabled = true;
            grpSQL.Enabled = true;
            timer1.Enabled = false;

            //---10/22/2017 Now load the listbox when they click stop automatically            
                foreach(string eachItem in General.rawReadings)
                    lbHistory.Items.Add(eachItem);
                
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            //---call the method that reads datastream from Arduino/XBEE
            Communication.GetStream();

            //---10/13/2017
            //---set up chart options. This sets left side of graph to less than current time so the graph scrolls. 
            //  Higher value (-25) slows the scrolling. Range is fixed 5-50 in properties

            if (chartSpeed < 5)
                chartSpeed = 5;
            else if (chartSpeed > 50)
                chartSpeed = 50;

            //---define the X Axis scrolling
            chart1.ChartAreas[0].AxisX.Minimum = now.AddSeconds(-chartSpeed).ToOADate();    //need the neg value here

            //---now show the data series they selected
            if (graphX)
                chart1.Series["xAxis"].Points.AddXY(now.ToOADate(), lblxAxis.Text);

            if (graphY)
                chart1.Series["yAxis"].Points.AddXY(now.ToOADate(), lblyAxis.Text);

            if (graphZ)
                chart1.Series["zAxis"].Points.AddXY(now.ToOADate(), lblzAxis.Text);
                 
        }

        #endregion

        #region Handle Buttons

        private void HandleComButtons_Click(object sender, EventArgs e)
        {
            Button whichButton = (Button)sender;

            switch (whichButton.Name)
            {
                case "btnConnect":
                    HandleConnectButton();
                    break;
                case "btnDisconnect":
                    Disconnect();
                    btnDisconnect.Enabled = false;
                    break;
                case "btnRefresh":
                    GetComPorts();
                    break;
                case "btnClearLB":
                    lbHistory.Items.Clear();
                    break;
                case "btnReadLogFile":
                    DataLogger.ReadLogFile();
                    break;
                case "btnClearLog":
                   DataLogger.ClearLogFile();
                    break;
                case "btnSave2SQL":
                    btnSave2SQL.Text = "PLEASE WAIT...";
                    btnSave2SQL.ForeColor = System.Drawing.Color.Red;
                    bgThreadSQL.RunWorkerAsync();
                    break;
                case "btnDisplaySQLData":
                    MyADO.DisplayRecords();
                    break;
                case "btnDeleteSQLRecords":
                    MyADO.DeleteRecords();
                    break;

            }
        }


        private void HandleConnectButton()
        {
            if (Communication.OpenCom())               //can we open com port?
            {
                lblComStatus.Text = General.ConnectedMsg;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                cboPorts.Focus();
                General.IsConnected = true;
                btnStartStream.Enabled = true;
                btnStopStream.Enabled = false;
            }
            else
            {
                lblComStatus.Text = General.DisconnectedMsg;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }

        }
        #endregion

        #region Graphing Options
        private void Axis2Graph_CheckedChanged(object sender, EventArgs e)
        {
            //---what do they want to graph. Toggle if checked/unchecked
            CheckBox whichOne = (CheckBox)sender;

            switch (whichOne.Name)
            {
                case "chkX":
                    graphX = !graphX;
                    break;
                case "chkY":
                    graphY = !graphY;
                    break;
                case "chkZ":
                    graphZ = !graphZ;
                    break;

            }
        }
            private void btnClearChart_Click(object sender, EventArgs e)
            {
          
            //---this clears the chart
                    foreach (var mySeries in chart1.Series)
                        {
                           mySeries.Points.Clear();
                        }
            }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            chartSpeed = hScrollBar1.Value;
        }

        #endregion

        #region Update GUI

        public void UpdateGUI()
        {
            //---make sure we have good data streaming in
            if ((General.XAxis != null) & (General.YAxis != null) & (General.ZAxis != null))
            {
              
                lblxAxis.Text = General.XAxis.Substring(1);
                lblyAxis.Text = General.YAxis.Substring(1);
                lblzAxis.Text = General.ZAxis.Substring(1);

                //---10/22/2017 Save raw data in a list structure. Faster than add to listbox?

                General.rawReadings.Add(General.XAxis);
                General.rawReadings.Add(General.YAxis);
                General.rawReadings.Add(General.ZAxis);
                General.rawReadings.Add("");
            }
        }
     

        #endregion

        #region Log File and DB Options
       
        //---file logging?

        private void btnSave2LogFile_Click(object sender, EventArgs e)
        {
           DataLogger.Save2File();
        }

        private void bgThreadSQL_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //---this background worker will save SQL records
            MyADO.Post2DB();
        }

        private void bgThreadSQL_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
                //---after background worker thread completes, reset text for the save button            
                btnSave2SQL.Text = "Save to Database";
                btnSave2SQL.ForeColor = System.Drawing.Color.Black;
            
        }

        #endregion

        #region Disconnect
        private void Disconnect()
        {
            //---clean up
            lblComStatus.Text = General.DisconnectedMsg;
            Communication.CloseCom();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disconnect();
            this.Close();
        }






















        #endregion

     
    }




}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
// THE ABOVE USING IS ESSENTIAL!!!! You must look for this interop that is downloaded directly on 
// your computer when you get Microsoft Office.
// I added it by going to references -> right click -> add reference -> browse 
// -> browsed for C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Excel\15.0.0.0__71e9bce111e9429c


namespace Data_Interface_Form
{
    public partial class MainForm : Form
    {
        //Everything here must be done in order for it to be done like normal code uploading to the GUI

        public MainForm()
        {
            InitializeComponent();

            this.bgWorkerDataFlow.DoWork += new DoWorkEventHandler(bgWorkerDataFlow_DoWork);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            General.mainFormAddress = this;        //set a reference back to this form so we can call methods from another class!

            //---usual setups

            infoLabel.Text = General.DisconnectedMsg;
            connectBtn.Enabled = false;
            disconnectBtn.Enabled = false;
            refreshBtn.Enabled = true;
            scrollCheckBox.Checked = false;
            General.chartSpeed = 5;
            General.RunThatBgDataWorker = false;

            sqlSaveBtn.Enabled = false;

            //---show all available COM ports
            GetComPorts();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetComPorts();
        }

        private void GetComPorts()
        {
            cboPorts.Items.Clear();
            foreach (string com in SerialPort.GetPortNames())    //uses IO.Ports namespace
            {
                cboPorts.Items.Add(com);
            }

            cboPorts.SelectedIndex = -1;
        }

        public void UpdateGUI()
        {
            double currentElapsedTime = (double)General.elapsedTime.ElapsedMilliseconds/1000.0;

            //Below allows for scrolling of the graph with greater General.chartSpeed values leading to slower scrolling
            if (scrollCheckBox.Checked)
            {
                TTBR_chart.ChartAreas[0].AxisX.Minimum = (double)currentElapsedTime - General.chartSpeed;
                MT_chart.ChartAreas[0].AxisX.Minimum = (double)currentElapsedTime - General.chartSpeed;
                WS_chart.ChartAreas[0].AxisX.Minimum = (double)currentElapsedTime - General.chartSpeed;
                TB_chart.ChartAreas[0].AxisX.Minimum = (double)currentElapsedTime - General.chartSpeed;
                Battery_chart.ChartAreas[0].AxisX.Minimum = (double)currentElapsedTime - General.chartSpeed;

            }
            else
            {
                TTBR_chart.ChartAreas[0].AxisX.Minimum = 0;
                MT_chart.ChartAreas[0].AxisX.Minimum = 0;
                WS_chart.ChartAreas[0].AxisX.Minimum = 0;
                TB_chart.ChartAreas[0].AxisX.Minimum = 0;
                Battery_chart.ChartAreas[0].AxisX.Minimum = 0;

            }

            TTBR_chart.Series["TTBR inner"].Points.AddXY(currentElapsedTime, General.TTBR1);
            TTBR_chart.Series["TTBR middle"].Points.AddXY(currentElapsedTime, General.TTBR2);
            TTBR_chart.Series["TTBR outer"].Points.AddXY(currentElapsedTime, General.TTBR3);

            TTBR_chart.Series["TTBL inner"].Points.AddXY(currentElapsedTime, General.TTBL1);
            TTBR_chart.Series["TTBL middle"].Points.AddXY(currentElapsedTime, General.TTBL2);
            TTBR_chart.Series["TTBL outer"].Points.AddXY(currentElapsedTime, General.TTBL3);


            MT_chart.Series["MT1"].Points.AddXY(currentElapsedTime, General.MT1);
            MT_chart.Series["MT2"].Points.AddXY(currentElapsedTime, General.MT2);

            WS_chart.Series["WSFL"].Points.AddXY(currentElapsedTime, General.WSFL);
            WS_chart.Series["WSFR"].Points.AddXY(currentElapsedTime, General.WSFR);
            WS_chart.Series["WSBL"].Points.AddXY(currentElapsedTime, General.WSBL);
            WS_chart.Series["WSBR"].Points.AddXY(currentElapsedTime, General.WSBR);

            TB_chart.Series["Brake"].Points.AddXY(currentElapsedTime, General.brakeAngle);
            TB_chart.Series["ThrottleL"].Points.AddXY(currentElapsedTime, General.throttleL);
            TB_chart.Series["ThrottleR"].Points.AddXY(currentElapsedTime, General.throttleR);

            Battery_chart.Series["Voltage"].Points.AddXY(currentElapsedTime, General.packVoltage);
            Battery_chart.Series["Current"].Points.AddXY(currentElapsedTime, General.packCurrent);
            Battery_chart.Series["State of Charge"].Points.AddXY(currentElapsedTime, General.packCharge);
            Battery_chart.Series["BMS Temp"].Points.AddXY(currentElapsedTime, General.packTemperature);
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //---get selected port from UI
            try
            {
                General.ChosenComPort = cboPorts.SelectedItem.ToString();
                if (General.ChosenComPort.Substring(0, 3) == "COM")
                    connectBtn.Enabled = true;
                else
                    connectBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                infoLabel.Text = "Cannot access that port." + ex.Message.ToString();
            }
        }


        private void streamStartBtn_Click(object sender, EventArgs e)
        {
            if (General.ConnectedToCom)
            {
                General.ReadingFromTheStream = true;
                streamStartBtn.Enabled = false;
                streamStopBtn.Enabled = true;

                //dataTimer used to get information in a periodic fashion
                
                General.startTime = DateTime.Now.ToString("M-dd-yyyy--HH-mm-ss");
                General.elapsedTime.Start();
                General.RunThatBgDataWorker = true;
           
                bgWorkerDataFlow.RunWorkerAsync();
                dataTimer.Start();
                csvTimer.Start();
            }
        }

        private void streamStopBtn_Click(object sender, EventArgs e)
        {
            General.ReadingFromTheStream = false;
            streamStartBtn.Enabled = true;
            streamStopBtn.Enabled = false;

            sqlSaveBtn.Enabled = true;

            dataTimer.Enabled = false;
            dataTimer.Enabled = false;
            General.elapsedTime.Stop();

            General.RunThatBgDataWorker = false;
        }


        private void connectBtn_Click(object sender, EventArgs e)
        {
            HandleConnectButton();
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void HandleConnectButton()
        {
            if (Communication.OpenCOM())               //can we open com port?
            {
                infoLabel.Text = General.ConnectedMsg;
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
                cboPorts.Focus();
                General.ConnectedToCom = true;
                streamStartBtn.Enabled = true;
                streamStopBtn.Enabled = false;
            }
            else
            {
                infoLabel.Text = General.DisconnectedMsg;

                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
            }

        }

        private void Disconnect()
        {
            //---clean up
            infoLabel.Text = General.DisconnectedMsg;
            Communication.CloseCom();

            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
        }

        private void bgWorkerSQL_DoWork(object sender, DoWorkEventArgs e)
        {
            BackEnd.Post2SensorDB();
        }

        private void sqlSaveBtn_Click(object sender, EventArgs e)
        {
            sqlSaveBtn.Text = "PLEASE WAIT...";
            sqlSaveBtn.ForeColor = System.Drawing.Color.Red;
            bgWorkerSQL.RunWorkerAsync();

            sqlSaveBtn.Enabled = false;
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            General.mainFormAddress.UpdateGUI();
        }

        private void chartScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            General.chartSpeed = chartScrollBar.Value;

            if (General.chartSpeed > 50)
            {
                General.chartSpeed = 50;
            }
            else if (General.chartSpeed <5)
            {
                General.chartSpeed = 5;
            }
        }

        private void bgWorkerSQL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sqlSaveBtn.Enabled = true;

            //---after background worker thread completes, reset text for the save button  
            sqlSaveBtn.ForeColor = System.Drawing.Color.Black;
            sqlSaveBtn.Text = "Save to Database";

        }

        private void displayVisualBtn_Click(object sender, EventArgs e)
        {
            VisualDisplayForm visualDisplayFormInstance = new VisualDisplayForm();
            visualDisplayFormInstance.Show();
        }

        private void bgWorkerDataFlow_DoWork(object sender, DoWorkEventArgs e)
        {
            while (General.RunThatBgDataWorker)
            {
                Communication.GetInfoFromCOM();
            }
        }

        private void csvTimer_Tick(object sender, EventArgs e)
        {

            //This if statement is just to make sure that the first 3 data points are all zero for this is really unlikely
            if (General.AllowCsvWriting == true)
            {
                Communication.WriteOutputToTextFile(General.dataForCsv);
            }

            General.dataForCsv.Clear();
            General.AllowCsvWriting = false;
        }
    }
}

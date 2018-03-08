/*__________________________________

                X B E E   R E A D E R
        D A T A L O G G E R   C L A S S
   For XBEE WeatherStation Telemetry Demo
                   Created 8/29/2017
                         Ron Kessler
____________________________________
This class manages file LOGGING operations
 
 Updated 8/28/2017
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XBEE_READER
{
    public partial class ShowLogFile : Form
    {
        public ShowLogFile()
        {
            InitializeComponent();
        }

        private void ShowLogFile_Load(object sender, EventArgs e)
        {
            StreamReader myReader =
                    new StreamReader(new FileStream(General.LogFile, FileMode.Open, FileAccess.Read));
            try
            {
                while (myReader.Peek() != -1)
                {
                    string dataFromFile = myReader.ReadLine();
                    lbData.Items.Add(dataFromFile);
                   
                }
                myReader.Close();
            }
            catch (IOException Err)
            {
                General.NotifyUser("I cannot Read the log File" + Err.Message.ToString());
            }

            finally
            {
                myReader.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    
    }
}

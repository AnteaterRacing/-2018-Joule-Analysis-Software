/*__________________________________

                X B E E   R E A D E R
             F O R M   S Q L   D A T A
   For XBEE WeatherStation Telemetry Demo
                   Created 8/18/2017
                         Ron Kessler
____________________________________
This form displays saved sql records 
 Updated 8/29/2017
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

namespace XBEE_READER
{
    public partial class frmSQLRecords : Form
    {
        public frmSQLRecords()
        {
            InitializeComponent();
        }

        #region Read SQL Records
        private void frmSQLRecords_Load(object sender, EventArgs e)
        {
            
            //---fill the grid
            try
            {
                this.accelerometerTableAdapter.Fill(this.dB_6901_AccelerometerDS.Accelerometer);
                //---alternate colors on the rows
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                General.NotifyUser("An error occured while reading database." + ex.Message.ToString());
            }
        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}

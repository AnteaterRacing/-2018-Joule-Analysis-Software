namespace XBEE_READER
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopStream = new System.Windows.Forms.Button();
            this.btnStartStream = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblComStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblzAxis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblyAxis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblxAxis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpSQL = new System.Windows.Forms.GroupBox();
            this.btnSave2SQL = new System.Windows.Forms.Button();
            this.btnDeleteSQLRecords = new System.Windows.Forms.Button();
            this.btnDisplaySQLData = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnClearLB = new System.Windows.Forms.Button();
            this.btnSave2LogFile = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnReadLogFile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.chkZ = new System.Windows.Forms.CheckBox();
            this.chkY = new System.Windows.Forms.CheckBox();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.bgThreadSQL = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grpSQL.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnStopStream);
            this.groupBox1.Controls.Add(this.btnStartStream);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.lblComStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Input COM Port";
            // 
            // btnStopStream
            // 
            this.btnStopStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStopStream.Enabled = false;
            this.btnStopStream.ForeColor = System.Drawing.Color.White;
            this.btnStopStream.Location = new System.Drawing.Point(213, 300);
            this.btnStopStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopStream.Name = "btnStopStream";
            this.btnStopStream.Size = new System.Drawing.Size(161, 112);
            this.btnStopStream.TabIndex = 8;
            this.btnStopStream.Text = "Stop";
            this.btnStopStream.UseVisualStyleBackColor = false;
            this.btnStopStream.Click += new System.EventHandler(this.btnStopStream_Click);
            // 
            // btnStartStream
            // 
            this.btnStartStream.BackColor = System.Drawing.Color.Green;
            this.btnStartStream.Enabled = false;
            this.btnStartStream.ForeColor = System.Drawing.Color.White;
            this.btnStartStream.Location = new System.Drawing.Point(72, 300);
            this.btnStartStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(161, 112);
            this.btnStartStream.TabIndex = 7;
            this.btnStartStream.Text = "Start";
            this.btnStartStream.UseVisualStyleBackColor = false;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(238, 41);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 46);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(238, 108);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 85);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(91, 108);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 85);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // lblComStatus
            // 
            this.lblComStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComStatus.Location = new System.Drawing.Point(93, 202);
            this.lblComStatus.Name = "lblComStatus";
            this.lblComStatus.Size = new System.Drawing.Size(266, 48);
            this.lblComStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // cboPorts
            // 
            this.cboPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.ItemHeight = 29;
            this.cboPorts.Location = new System.Drawing.Point(93, 41);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(138, 37);
            this.cboPorts.Sorted = true;
            this.cboPorts.TabIndex = 1;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.lblzAxis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblyAxis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblxAxis);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(476, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(302, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acclerometer Readings";
            // 
            // lblzAxis
            // 
            this.lblzAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblzAxis.Location = new System.Drawing.Point(129, 132);
            this.lblzAxis.Name = "lblzAxis";
            this.lblzAxis.Size = new System.Drawing.Size(140, 31);
            this.lblzAxis.TabIndex = 7;
            this.lblzAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Z-Axis";
            // 
            // lblyAxis
            // 
            this.lblyAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblyAxis.Location = new System.Drawing.Point(129, 86);
            this.lblyAxis.Name = "lblyAxis";
            this.lblyAxis.Size = new System.Drawing.Size(140, 31);
            this.lblyAxis.TabIndex = 5;
            this.lblyAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y-Axis";
            // 
            // lblxAxis
            // 
            this.lblxAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblxAxis.Location = new System.Drawing.Point(129, 40);
            this.lblxAxis.Name = "lblxAxis";
            this.lblxAxis.Size = new System.Drawing.Size(140, 31);
            this.lblxAxis.TabIndex = 3;
            this.lblxAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "X-Axis";
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 20;
            this.lbHistory.Location = new System.Drawing.Point(6, 28);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(175, 384);
            this.lbHistory.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1382, 33);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.BorderWidth = 2;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.SlateGray;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "hh:mm:ss";
            chartArea1.AxisX.LabelStyle.Interval = 10D;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 10D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 10D;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.Interval = 10D;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 93.99458F;
            chartArea1.InnerPlotPosition.Width = 94.32339F;
            chartArea1.InnerPlotPosition.X = 5.67661F;
            chartArea1.InnerPlotPosition.Y = 3.00271F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 502);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Default";
            series1.Name = "xAxis";
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Default";
            series2.Name = "yAxis";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "zAxis";
            series3.ShadowOffset = 1;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1368, 649);
            this.chart1.TabIndex = 34;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.ForeColor = System.Drawing.Color.DarkSlateGray;
            title1.Name = "Title1";
            title1.Text = "UCI Race Car Accelerometer Telemetry for Fall 2017";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Controls.Add(this.grpSQL);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.lbHistory);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(834, 49);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(525, 448);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manage Data Storage";
            // 
            // grpSQL
            // 
            this.grpSQL.Controls.Add(this.btnSave2SQL);
            this.grpSQL.Controls.Add(this.btnDeleteSQLRecords);
            this.grpSQL.Controls.Add(this.btnDisplaySQLData);
            this.grpSQL.Enabled = false;
            this.grpSQL.ForeColor = System.Drawing.Color.White;
            this.grpSQL.Location = new System.Drawing.Point(197, 259);
            this.grpSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSQL.Name = "grpSQL";
            this.grpSQL.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSQL.Size = new System.Drawing.Size(315, 181);
            this.grpSQL.TabIndex = 12;
            this.grpSQL.TabStop = false;
            this.grpSQL.Text = "Manage Remote SQL Database";
            // 
            // btnSave2SQL
            // 
            this.btnSave2SQL.ForeColor = System.Drawing.Color.Black;
            this.btnSave2SQL.Location = new System.Drawing.Point(132, 32);
            this.btnSave2SQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave2SQL.Name = "btnSave2SQL";
            this.btnSave2SQL.Size = new System.Drawing.Size(159, 40);
            this.btnSave2SQL.TabIndex = 12;
            this.btnSave2SQL.Text = "Save To Database";
            this.btnSave2SQL.UseVisualStyleBackColor = true;
            this.btnSave2SQL.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // btnDeleteSQLRecords
            // 
            this.btnDeleteSQLRecords.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSQLRecords.Location = new System.Drawing.Point(132, 121);
            this.btnDeleteSQLRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSQLRecords.Name = "btnDeleteSQLRecords";
            this.btnDeleteSQLRecords.Size = new System.Drawing.Size(159, 40);
            this.btnDeleteSQLRecords.TabIndex = 11;
            this.btnDeleteSQLRecords.Text = "Delete Records";
            this.btnDeleteSQLRecords.UseVisualStyleBackColor = true;
            this.btnDeleteSQLRecords.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // btnDisplaySQLData
            // 
            this.btnDisplaySQLData.ForeColor = System.Drawing.Color.Black;
            this.btnDisplaySQLData.Location = new System.Drawing.Point(132, 79);
            this.btnDisplaySQLData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplaySQLData.Name = "btnDisplaySQLData";
            this.btnDisplaySQLData.Size = new System.Drawing.Size(159, 40);
            this.btnDisplaySQLData.TabIndex = 9;
            this.btnDisplaySQLData.Text = "Display Records";
            this.btnDisplaySQLData.UseVisualStyleBackColor = true;
            this.btnDisplaySQLData.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnClearLB);
            this.groupBox7.Controls.Add(this.btnSave2LogFile);
            this.groupBox7.Controls.Add(this.btnClearLog);
            this.groupBox7.Controls.Add(this.btnReadLogFile);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(197, 28);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(315, 225);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Manage Log File";
            // 
            // btnClearLB
            // 
            this.btnClearLB.ForeColor = System.Drawing.Color.Black;
            this.btnClearLB.Location = new System.Drawing.Point(132, 126);
            this.btnClearLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLB.Name = "btnClearLB";
            this.btnClearLB.Size = new System.Drawing.Size(159, 40);
            this.btnClearLB.TabIndex = 12;
            this.btnClearLB.Text = "Clear List Box";
            this.btnClearLB.UseVisualStyleBackColor = true;
            this.btnClearLB.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // btnSave2LogFile
            // 
            this.btnSave2LogFile.Enabled = false;
            this.btnSave2LogFile.ForeColor = System.Drawing.Color.Black;
            this.btnSave2LogFile.Location = new System.Drawing.Point(132, 31);
            this.btnSave2LogFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave2LogFile.Name = "btnSave2LogFile";
            this.btnSave2LogFile.Size = new System.Drawing.Size(159, 40);
            this.btnSave2LogFile.TabIndex = 11;
            this.btnSave2LogFile.Text = "Save To Log File";
            this.btnSave2LogFile.UseVisualStyleBackColor = true;
            this.btnSave2LogFile.Click += new System.EventHandler(this.btnSave2LogFile_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.ForeColor = System.Drawing.Color.Black;
            this.btnClearLog.Location = new System.Drawing.Point(132, 174);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(159, 40);
            this.btnClearLog.TabIndex = 8;
            this.btnClearLog.Text = "Clear Log File";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // btnReadLogFile
            // 
            this.btnReadLogFile.ForeColor = System.Drawing.Color.Black;
            this.btnReadLogFile.Location = new System.Drawing.Point(132, 79);
            this.btnReadLogFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadLogFile.Name = "btnReadLogFile";
            this.btnReadLogFile.Size = new System.Drawing.Size(159, 40);
            this.btnReadLogFile.TabIndex = 7;
            this.btnReadLogFile.Text = "Show Log Data";
            this.btnReadLogFile.UseVisualStyleBackColor = true;
            this.btnReadLogFile.Click += new System.EventHandler(this.HandleComButtons_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.hScrollBar1);
            this.groupBox3.Controls.Add(this.btnClearChart);
            this.groupBox3.Controls.Add(this.chkZ);
            this.groupBox3.Controls.Add(this.chkY);
            this.groupBox3.Controls.Add(this.chkX);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(476, 249);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(302, 248);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphing Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Control Chart Scrolling";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 195);
            this.hScrollBar1.Maximum = 50;
            this.hScrollBar1.Minimum = 5;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(284, 25);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Value = 5;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnClearChart
            // 
            this.btnClearChart.ForeColor = System.Drawing.Color.Black;
            this.btnClearChart.Location = new System.Drawing.Point(158, 49);
            this.btnClearChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(123, 71);
            this.btnClearChart.TabIndex = 5;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // chkZ
            // 
            this.chkZ.AutoSize = true;
            this.chkZ.ForeColor = System.Drawing.Color.White;
            this.chkZ.Location = new System.Drawing.Point(14, 115);
            this.chkZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkZ.Name = "chkZ";
            this.chkZ.Size = new System.Drawing.Size(133, 24);
            this.chkZ.TabIndex = 4;
            this.chkZ.Text = "Display Z Axis";
            this.chkZ.UseVisualStyleBackColor = true;
            this.chkZ.CheckedChanged += new System.EventHandler(this.Axis2Graph_CheckedChanged);
            // 
            // chkY
            // 
            this.chkY.AutoSize = true;
            this.chkY.ForeColor = System.Drawing.Color.White;
            this.chkY.Location = new System.Drawing.Point(14, 80);
            this.chkY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkY.Name = "chkY";
            this.chkY.Size = new System.Drawing.Size(134, 24);
            this.chkY.TabIndex = 3;
            this.chkY.Text = "Display Y Axis";
            this.chkY.UseVisualStyleBackColor = true;
            this.chkY.CheckedChanged += new System.EventHandler(this.Axis2Graph_CheckedChanged);
            // 
            // chkX
            // 
            this.chkX.AutoSize = true;
            this.chkX.ForeColor = System.Drawing.Color.White;
            this.chkX.Location = new System.Drawing.Point(14, 49);
            this.chkX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(134, 24);
            this.chkX.TabIndex = 2;
            this.chkX.Text = "Display X Axis";
            this.chkX.UseVisualStyleBackColor = true;
            this.chkX.CheckedChanged += new System.EventHandler(this.Axis2Graph_CheckedChanged);
            // 
            // bgThreadSQL
            // 
            this.bgThreadSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgThreadSQL_DoWork);
            this.bgThreadSQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgThreadSQL_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1383, 1038);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCI RaceCar Engineering Telemetry  2.1.2 (10/22/2017)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.grpSQL.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label lblzAxis;
        internal System.Windows.Forms.Label lblyAxis;
        internal System.Windows.Forms.Label lblxAxis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox grpSQL;
        private System.Windows.Forms.Button btnReadLogFile;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnStopStream;
        private System.Windows.Forms.Button btnStartStream;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkZ;
        private System.Windows.Forms.CheckBox chkY;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnSave2LogFile;
        private System.Windows.Forms.Button btnClearLB;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bgThreadSQL;
        private System.Windows.Forms.Button btnSave2SQL;
        private System.Windows.Forms.Button btnDeleteSQLRecords;
        private System.Windows.Forms.Button btnDisplaySQLData;
    }
}


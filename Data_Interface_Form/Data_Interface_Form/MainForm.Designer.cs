namespace Data_Interface_Form
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.streamStartBtn = new System.Windows.Forms.Button();
            this.streamStopBtn = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.comLabel = new System.Windows.Forms.Label();
            this.SensorTabs = new System.Windows.Forms.TabControl();
            this.tireTempTab = new System.Windows.Forms.TabPage();
            this.motorTempTab = new System.Windows.Forms.TabPage();
            this.wheelSpeedTab = new System.Windows.Forms.TabPage();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.bgWorkerSQL = new System.ComponentModel.BackgroundWorker();
            this.sqlSaveBtn = new System.Windows.Forms.Button();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.chartScrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollCheckBox = new System.Windows.Forms.CheckBox();
            this.displayVisualBtn = new System.Windows.Forms.Button();
            this.bgWorkerDataFlow = new System.ComponentModel.BackgroundWorker();
            this.csvTimer = new System.Windows.Forms.Timer(this.components);
            this.TTBR_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SensorTabs.SuspendLayout();
            this.tireTempTab.SuspendLayout();
            this.motorTempTab.SuspendLayout();
            this.wheelSpeedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTBR_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MT_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WS_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // streamStartBtn
            // 
            this.streamStartBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.streamStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamStartBtn.Location = new System.Drawing.Point(786, 566);
            this.streamStartBtn.Name = "streamStartBtn";
            this.streamStartBtn.Size = new System.Drawing.Size(150, 47);
            this.streamStartBtn.TabIndex = 0;
            this.streamStartBtn.Text = "START";
            this.streamStartBtn.UseVisualStyleBackColor = false;
            this.streamStartBtn.Click += new System.EventHandler(this.streamStartBtn_Click);
            // 
            // streamStopBtn
            // 
            this.streamStopBtn.BackColor = System.Drawing.Color.Red;
            this.streamStopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamStopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.streamStopBtn.Location = new System.Drawing.Point(786, 619);
            this.streamStopBtn.Name = "streamStopBtn";
            this.streamStopBtn.Size = new System.Drawing.Size(150, 47);
            this.streamStopBtn.TabIndex = 1;
            this.streamStopBtn.Text = "STOP";
            this.streamStopBtn.UseVisualStyleBackColor = false;
            this.streamStopBtn.Click += new System.EventHandler(this.streamStopBtn_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(11, 591);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(150, 28);
            this.cboPorts.TabIndex = 2;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // comLabel
            // 
            this.comLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.comLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comLabel.Location = new System.Drawing.Point(11, 566);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(150, 22);
            this.comLabel.TabIndex = 3;
            this.comLabel.Text = "COM Ports";
            this.comLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensorTabs
            // 
            this.SensorTabs.Controls.Add(this.tireTempTab);
            this.SensorTabs.Controls.Add(this.motorTempTab);
            this.SensorTabs.Controls.Add(this.wheelSpeedTab);
            this.SensorTabs.Location = new System.Drawing.Point(12, 12);
            this.SensorTabs.Name = "SensorTabs";
            this.SensorTabs.SelectedIndex = 0;
            this.SensorTabs.Size = new System.Drawing.Size(1121, 539);
            this.SensorTabs.TabIndex = 4;
            // 
            // tireTempTab
            // 
            this.tireTempTab.Controls.Add(this.TTBR_chart);
            this.tireTempTab.Location = new System.Drawing.Point(4, 29);
            this.tireTempTab.Name = "tireTempTab";
            this.tireTempTab.Padding = new System.Windows.Forms.Padding(3);
            this.tireTempTab.Size = new System.Drawing.Size(1113, 506);
            this.tireTempTab.TabIndex = 0;
            this.tireTempTab.Text = "TTBR";
            this.tireTempTab.UseVisualStyleBackColor = true;
            // 
            // motorTempTab
            // 
            this.motorTempTab.Controls.Add(this.MT_chart);
            this.motorTempTab.Location = new System.Drawing.Point(4, 29);
            this.motorTempTab.Name = "motorTempTab";
            this.motorTempTab.Padding = new System.Windows.Forms.Padding(3);
            this.motorTempTab.Size = new System.Drawing.Size(1113, 506);
            this.motorTempTab.TabIndex = 1;
            this.motorTempTab.Text = "Motor Temp";
            this.motorTempTab.UseVisualStyleBackColor = true;
            // 
            // wheelSpeedTab
            // 
            this.wheelSpeedTab.Controls.Add(this.WS_chart);
            this.wheelSpeedTab.Location = new System.Drawing.Point(4, 29);
            this.wheelSpeedTab.Name = "wheelSpeedTab";
            this.wheelSpeedTab.Size = new System.Drawing.Size(1113, 506);
            this.wheelSpeedTab.TabIndex = 2;
            this.wheelSpeedTab.Text = "Wheel Speed";
            this.wheelSpeedTab.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Aqua;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.Black;
            this.refreshBtn.Location = new System.Drawing.Point(167, 566);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(93, 53);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Azure;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(420, 566);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(360, 100);
            this.infoLabel.TabIndex = 6;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Silver;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(266, 566);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(148, 47);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.Color.DarkGray;
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(266, 619);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(148, 47);
            this.disconnectBtn.TabIndex = 8;
            this.disconnectBtn.Text = "DISCONNECT";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // bgWorkerSQL
            // 
            this.bgWorkerSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSQL_DoWork);
            this.bgWorkerSQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSQL_RunWorkerCompleted);
            // 
            // sqlSaveBtn
            // 
            this.sqlSaveBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.sqlSaveBtn.Location = new System.Drawing.Point(942, 566);
            this.sqlSaveBtn.Name = "sqlSaveBtn";
            this.sqlSaveBtn.Size = new System.Drawing.Size(192, 47);
            this.sqlSaveBtn.TabIndex = 9;
            this.sqlSaveBtn.Text = "Save to Database";
            this.sqlSaveBtn.UseVisualStyleBackColor = false;
            this.sqlSaveBtn.Click += new System.EventHandler(this.sqlSaveBtn_Click);
            // 
            // dataTimer
            // 
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // chartScrollBar
            // 
            this.chartScrollBar.Location = new System.Drawing.Point(942, 644);
            this.chartScrollBar.Name = "chartScrollBar";
            this.chartScrollBar.Size = new System.Drawing.Size(191, 22);
            this.chartScrollBar.TabIndex = 10;
            this.chartScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.chartScrollBar_Scroll);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(942, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chart Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollCheckBox
            // 
            this.scrollCheckBox.AutoSize = true;
            this.scrollCheckBox.Location = new System.Drawing.Point(1058, 616);
            this.scrollCheckBox.Name = "scrollCheckBox";
            this.scrollCheckBox.Size = new System.Drawing.Size(83, 24);
            this.scrollCheckBox.TabIndex = 12;
            this.scrollCheckBox.Text = "Scroll?";
            this.scrollCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayVisualBtn
            // 
            this.displayVisualBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.displayVisualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayVisualBtn.Location = new System.Drawing.Point(11, 630);
            this.displayVisualBtn.Name = "displayVisualBtn";
            this.displayVisualBtn.Size = new System.Drawing.Size(248, 35);
            this.displayVisualBtn.TabIndex = 13;
            this.displayVisualBtn.Text = "Visual Display";
            this.displayVisualBtn.UseVisualStyleBackColor = false;
            this.displayVisualBtn.Click += new System.EventHandler(this.displayVisualBtn_Click);
            // 
            // bgWorkerDataFlow
            // 
            this.bgWorkerDataFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerDataFlow_DoWork);
            // 
            // csvTimer
            // 
            this.csvTimer.Interval = 2000;
            this.csvTimer.Tick += new System.EventHandler(this.csvTimer_Tick);
            // 
            // TTBR_chart
            // 
            this.TTBR_chart.BackColor = System.Drawing.Color.Khaki;
            chartArea1.Name = "ChartArea1";
            this.TTBR_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TTBR_chart.Legends.Add(legend1);
            this.TTBR_chart.Location = new System.Drawing.Point(1, -1);
            this.TTBR_chart.Name = "TTBR_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "TTBR1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "TTBR2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "TTBR3";
            this.TTBR_chart.Series.Add(series1);
            this.TTBR_chart.Series.Add(series2);
            this.TTBR_chart.Series.Add(series3);
            this.TTBR_chart.Size = new System.Drawing.Size(1110, 509);
            this.TTBR_chart.TabIndex = 1;
            this.TTBR_chart.Text = "chart1";
            // 
            // MT_chart
            // 
            this.MT_chart.BackColor = System.Drawing.Color.Wheat;
            chartArea2.Name = "ChartArea1";
            this.MT_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MT_chart.Legends.Add(legend2);
            this.MT_chart.Location = new System.Drawing.Point(1, -1);
            this.MT_chart.Name = "MT_chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "MT1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "MT2";
            this.MT_chart.Series.Add(series4);
            this.MT_chart.Series.Add(series5);
            this.MT_chart.Size = new System.Drawing.Size(1110, 509);
            this.MT_chart.TabIndex = 2;
            this.MT_chart.Text = "chart2";
            // 
            // WS_chart
            // 
            this.WS_chart.BackColor = System.Drawing.Color.Bisque;
            chartArea3.Name = "ChartArea1";
            this.WS_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.WS_chart.Legends.Add(legend3);
            this.WS_chart.Location = new System.Drawing.Point(1, -1);
            this.WS_chart.Name = "WS_chart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "WSFL";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "WSFR";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "WSBL";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "WSBR";
            this.WS_chart.Series.Add(series6);
            this.WS_chart.Series.Add(series7);
            this.WS_chart.Series.Add(series8);
            this.WS_chart.Series.Add(series9);
            this.WS_chart.Size = new System.Drawing.Size(1110, 509);
            this.WS_chart.TabIndex = 3;
            this.WS_chart.Text = "chart2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1146, 683);
            this.Controls.Add(this.displayVisualBtn);
            this.Controls.Add(this.scrollCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartScrollBar);
            this.Controls.Add(this.sqlSaveBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.SensorTabs);
            this.Controls.Add(this.comLabel);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.streamStopBtn);
            this.Controls.Add(this.streamStartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SensorTabs.ResumeLayout(false);
            this.tireTempTab.ResumeLayout(false);
            this.motorTempTab.ResumeLayout(false);
            this.wheelSpeedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTBR_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MT_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WS_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button streamStartBtn;
        private System.Windows.Forms.Button streamStopBtn;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Label comLabel;
        private System.Windows.Forms.TabControl SensorTabs;
        private System.Windows.Forms.TabPage tireTempTab;
        private System.Windows.Forms.TabPage motorTempTab;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.ComponentModel.BackgroundWorker bgWorkerSQL;
        private System.Windows.Forms.Button sqlSaveBtn;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.HScrollBar chartScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox scrollCheckBox;
        private System.Windows.Forms.TabPage wheelSpeedTab;
        private System.Windows.Forms.Button displayVisualBtn;
        private System.ComponentModel.BackgroundWorker bgWorkerDataFlow;
        private System.Windows.Forms.Timer csvTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart TTBR_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MT_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WS_chart;
    }
}


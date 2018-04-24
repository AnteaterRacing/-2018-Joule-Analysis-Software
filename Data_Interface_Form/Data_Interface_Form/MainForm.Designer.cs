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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.streamStartBtn = new System.Windows.Forms.Button();
            this.streamStopBtn = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.comLabel = new System.Windows.Forms.Label();
            this.SensorTabs = new System.Windows.Forms.TabControl();
            this.tireTempTab = new System.Windows.Forms.TabPage();
            this.TTBR_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.motorTempTab = new System.Windows.Forms.TabPage();
            this.MT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wheelSpeedTab = new System.Windows.Forms.TabPage();
            this.WS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.SensorTabs.SuspendLayout();
            this.tireTempTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTBR_chart)).BeginInit();
            this.motorTempTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MT_chart)).BeginInit();
            this.wheelSpeedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WS_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // streamStartBtn
            // 
            this.streamStartBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.streamStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamStartBtn.Location = new System.Drawing.Point(1048, 708);
            this.streamStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.streamStartBtn.Name = "streamStartBtn";
            this.streamStartBtn.Size = new System.Drawing.Size(200, 59);
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
            this.streamStopBtn.Location = new System.Drawing.Point(1048, 774);
            this.streamStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.streamStopBtn.Name = "streamStopBtn";
            this.streamStopBtn.Size = new System.Drawing.Size(200, 59);
            this.streamStopBtn.TabIndex = 1;
            this.streamStopBtn.Text = "STOP";
            this.streamStopBtn.UseVisualStyleBackColor = false;
            this.streamStopBtn.Click += new System.EventHandler(this.streamStopBtn_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(15, 739);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(199, 33);
            this.cboPorts.TabIndex = 2;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // comLabel
            // 
            this.comLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.comLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comLabel.Location = new System.Drawing.Point(15, 708);
            this.comLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(199, 27);
            this.comLabel.TabIndex = 3;
            this.comLabel.Text = "COM Ports";
            this.comLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comLabel.Click += new System.EventHandler(this.comLabel_Click);
            // 
            // SensorTabs
            // 
            this.SensorTabs.Controls.Add(this.tireTempTab);
            this.SensorTabs.Controls.Add(this.motorTempTab);
            this.SensorTabs.Controls.Add(this.wheelSpeedTab);
            this.SensorTabs.Location = new System.Drawing.Point(16, 15);
            this.SensorTabs.Margin = new System.Windows.Forms.Padding(4);
            this.SensorTabs.Name = "SensorTabs";
            this.SensorTabs.SelectedIndex = 0;
            this.SensorTabs.Size = new System.Drawing.Size(1495, 674);
            this.SensorTabs.TabIndex = 4;
            this.SensorTabs.SelectedIndexChanged += new System.EventHandler(this.SensorTabs_SelectedIndexChanged);
            // 
            // tireTempTab
            // 
            this.tireTempTab.Controls.Add(this.TTBR_chart);
            this.tireTempTab.Location = new System.Drawing.Point(8, 39);
            this.tireTempTab.Margin = new System.Windows.Forms.Padding(4);
            this.tireTempTab.Name = "tireTempTab";
            this.tireTempTab.Padding = new System.Windows.Forms.Padding(4);
            this.tireTempTab.Size = new System.Drawing.Size(1479, 627);
            this.tireTempTab.TabIndex = 0;
            this.tireTempTab.Text = "TTBR";
            this.tireTempTab.UseVisualStyleBackColor = true;
            this.tireTempTab.Click += new System.EventHandler(this.tireTempTab_Click);
            // 
            // TTBR_chart
            // 
            this.TTBR_chart.BackColor = System.Drawing.Color.Khaki;
            chartArea10.Name = "ChartArea1";
            this.TTBR_chart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.TTBR_chart.Legends.Add(legend10);
            this.TTBR_chart.Location = new System.Drawing.Point(3, 0);
            this.TTBR_chart.Margin = new System.Windows.Forms.Padding(4);
            this.TTBR_chart.Name = "TTBR_chart";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "TTBR1";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "TTBR2";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Legend = "Legend1";
            series30.Name = "TTBR3";
            this.TTBR_chart.Series.Add(series28);
            this.TTBR_chart.Series.Add(series29);
            this.TTBR_chart.Series.Add(series30);
            this.TTBR_chart.Size = new System.Drawing.Size(1480, 636);
            this.TTBR_chart.TabIndex = 0;
            this.TTBR_chart.Text = "chart1";
            this.TTBR_chart.Click += new System.EventHandler(this.TTBR_chart_Click);
            // 
            // motorTempTab
            // 
            this.motorTempTab.Controls.Add(this.MT_chart);
            this.motorTempTab.Location = new System.Drawing.Point(8, 39);
            this.motorTempTab.Margin = new System.Windows.Forms.Padding(4);
            this.motorTempTab.Name = "motorTempTab";
            this.motorTempTab.Padding = new System.Windows.Forms.Padding(4);
            this.motorTempTab.Size = new System.Drawing.Size(1479, 627);
            this.motorTempTab.TabIndex = 1;
            this.motorTempTab.Text = "Motor Temp";
            this.motorTempTab.UseVisualStyleBackColor = true;
            this.motorTempTab.Click += new System.EventHandler(this.motorTempTab_Click);
            // 
            // MT_chart
            // 
            this.MT_chart.BackColor = System.Drawing.Color.Wheat;
            chartArea11.Name = "ChartArea1";
            this.MT_chart.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.MT_chart.Legends.Add(legend11);
            this.MT_chart.Location = new System.Drawing.Point(1, -1);
            this.MT_chart.Margin = new System.Windows.Forms.Padding(4);
            this.MT_chart.Name = "MT_chart";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Legend = "Legend1";
            series31.Name = "MT1";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Legend = "Legend1";
            series32.Name = "MT2";
            this.MT_chart.Series.Add(series31);
            this.MT_chart.Series.Add(series32);
            this.MT_chart.Size = new System.Drawing.Size(1480, 636);
            this.MT_chart.TabIndex = 1;
            this.MT_chart.Text = "chart2";
            this.MT_chart.Click += new System.EventHandler(this.MT_chart_Click);
            // 
            // wheelSpeedTab
            // 
            this.wheelSpeedTab.Controls.Add(this.WS_chart);
            this.wheelSpeedTab.Location = new System.Drawing.Point(8, 39);
            this.wheelSpeedTab.Margin = new System.Windows.Forms.Padding(4);
            this.wheelSpeedTab.Name = "wheelSpeedTab";
            this.wheelSpeedTab.Size = new System.Drawing.Size(1479, 627);
            this.wheelSpeedTab.TabIndex = 2;
            this.wheelSpeedTab.Text = "Wheel Speed";
            this.wheelSpeedTab.UseVisualStyleBackColor = true;
            this.wheelSpeedTab.Click += new System.EventHandler(this.wheelSpeedTab_Click);
            // 
            // WS_chart
            // 
            this.WS_chart.BackColor = System.Drawing.Color.Bisque;
            chartArea12.Name = "ChartArea1";
            this.WS_chart.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.WS_chart.Legends.Add(legend12);
            this.WS_chart.Location = new System.Drawing.Point(1, -1);
            this.WS_chart.Margin = new System.Windows.Forms.Padding(4);
            this.WS_chart.Name = "WS_chart";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Legend = "Legend1";
            series33.Name = "WSFL";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Legend = "Legend1";
            series34.Name = "WSFR";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Legend = "Legend1";
            series35.Name = "WSBL";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Legend = "Legend1";
            series36.Name = "WSBR";
            this.WS_chart.Series.Add(series33);
            this.WS_chart.Series.Add(series34);
            this.WS_chart.Series.Add(series35);
            this.WS_chart.Series.Add(series36);
            this.WS_chart.Size = new System.Drawing.Size(1480, 636);
            this.WS_chart.TabIndex = 2;
            this.WS_chart.Text = "chart2";
            this.WS_chart.Click += new System.EventHandler(this.WS_chart_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Aqua;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.Black;
            this.refreshBtn.Location = new System.Drawing.Point(223, 708);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(124, 66);
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
            this.infoLabel.Location = new System.Drawing.Point(560, 708);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(480, 125);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Silver;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(355, 708);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(197, 59);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.Color.DarkGray;
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectBtn.Location = new System.Drawing.Point(355, 774);
            this.disconnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(197, 59);
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
            this.sqlSaveBtn.Location = new System.Drawing.Point(1256, 708);
            this.sqlSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sqlSaveBtn.Name = "sqlSaveBtn";
            this.sqlSaveBtn.Size = new System.Drawing.Size(256, 59);
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
            this.chartScrollBar.Location = new System.Drawing.Point(1256, 805);
            this.chartScrollBar.Name = "chartScrollBar";
            this.chartScrollBar.Size = new System.Drawing.Size(255, 22);
            this.chartScrollBar.TabIndex = 10;
            this.chartScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.chartScrollBar_Scroll);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(1256, 770);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chart Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // scrollCheckBox
            // 
            this.scrollCheckBox.AutoSize = true;
            this.scrollCheckBox.Location = new System.Drawing.Point(1411, 770);
            this.scrollCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.scrollCheckBox.Name = "scrollCheckBox";
            this.scrollCheckBox.Size = new System.Drawing.Size(110, 29);
            this.scrollCheckBox.TabIndex = 12;
            this.scrollCheckBox.Text = "Scroll?";
            this.scrollCheckBox.UseVisualStyleBackColor = true;
            this.scrollCheckBox.CheckedChanged += new System.EventHandler(this.scrollCheckBox_CheckedChanged);
            // 
            // displayVisualBtn
            // 
            this.displayVisualBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.displayVisualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayVisualBtn.Location = new System.Drawing.Point(15, 788);
            this.displayVisualBtn.Margin = new System.Windows.Forms.Padding(4);
            this.displayVisualBtn.Name = "displayVisualBtn";
            this.displayVisualBtn.Size = new System.Drawing.Size(331, 44);
            this.displayVisualBtn.TabIndex = 13;
            this.displayVisualBtn.Text = "Visual Display";
            this.displayVisualBtn.UseVisualStyleBackColor = false;
            this.displayVisualBtn.Click += new System.EventHandler(this.displayVisualBtn_Click);
            // 
            // bgWorkerDataFlow
            // 
            this.bgWorkerDataFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerDataFlow_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1528, 854);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SensorTabs.ResumeLayout(false);
            this.tireTempTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTBR_chart)).EndInit();
            this.motorTempTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MT_chart)).EndInit();
            this.wheelSpeedTab.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart TTBR_chart;
        private System.Windows.Forms.TabPage motorTempTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart MT_chart;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart WS_chart;
        private System.Windows.Forms.Button displayVisualBtn;
        private System.ComponentModel.BackgroundWorker bgWorkerDataFlow;
    }
}


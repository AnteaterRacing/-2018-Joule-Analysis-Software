namespace XBEE_READER
{
    partial class frmSQLRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB_6901_AccelerometerDS = new XBEE_READER.DB_6901_AccelerometerDS();
            this.accelerometerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accelerometerTableAdapter = new XBEE_READER.DB_6901_AccelerometerDSTableAdapters.AccelerometerTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAxisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yAxisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAxisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_6901_AccelerometerDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.xAxisDataGridViewTextBoxColumn,
            this.yAxisDataGridViewTextBoxColumn,
            this.zAxisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accelerometerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dB_6901_AccelerometerDS
            // 
            this.dB_6901_AccelerometerDS.DataSetName = "DB_6901_AccelerometerDS";
            this.dB_6901_AccelerometerDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accelerometerBindingSource
            // 
            this.accelerometerBindingSource.DataMember = "Accelerometer";
            this.accelerometerBindingSource.DataSource = this.dB_6901_AccelerometerDS;
            // 
            // accelerometerTableAdapter
            // 
            this.accelerometerTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xAxisDataGridViewTextBoxColumn
            // 
            this.xAxisDataGridViewTextBoxColumn.DataPropertyName = "XAxis";
            this.xAxisDataGridViewTextBoxColumn.HeaderText = "XAxis";
            this.xAxisDataGridViewTextBoxColumn.Name = "xAxisDataGridViewTextBoxColumn";
            this.xAxisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yAxisDataGridViewTextBoxColumn
            // 
            this.yAxisDataGridViewTextBoxColumn.DataPropertyName = "YAxis";
            this.yAxisDataGridViewTextBoxColumn.HeaderText = "YAxis";
            this.yAxisDataGridViewTextBoxColumn.Name = "yAxisDataGridViewTextBoxColumn";
            this.yAxisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zAxisDataGridViewTextBoxColumn
            // 
            this.zAxisDataGridViewTextBoxColumn.DataPropertyName = "ZAxis";
            this.zAxisDataGridViewTextBoxColumn.HeaderText = "ZAxis";
            this.zAxisDataGridViewTextBoxColumn.Name = "zAxisDataGridViewTextBoxColumn";
            this.zAxisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSQLRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSQLRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accelerometer Readings Records";
            this.Load += new System.EventHandler(this.frmSQLRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_6901_AccelerometerDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DB_6901_AccelerometerDS dB_6901_AccelerometerDS;
        private System.Windows.Forms.BindingSource accelerometerBindingSource;
        private DB_6901_AccelerometerDSTableAdapters.AccelerometerTableAdapter accelerometerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAxisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yAxisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zAxisDataGridViewTextBoxColumn;
    }
}
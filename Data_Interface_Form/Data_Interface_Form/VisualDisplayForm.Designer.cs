namespace Data_Interface_Form
{
    partial class VisualDisplayForm
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
            this.visualsUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.steeringWheel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.steeringWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // visualsUpdateTimer
            // 
            this.visualsUpdateTimer.Interval = 200;
            this.visualsUpdateTimer.Tick += new System.EventHandler(this.visualsUpdateTimer_Tick);
            // 
            // steeringWheel
            // 
            this.steeringWheel.Image = global::Data_Interface_Form.Properties.Resources.steering_wheel_resized;
            this.steeringWheel.Location = new System.Drawing.Point(816, 12);
            this.steeringWheel.Name = "steeringWheel";
            this.steeringWheel.Size = new System.Drawing.Size(148, 149);
            this.steeringWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.steeringWheel.TabIndex = 0;
            this.steeringWheel.TabStop = false;
            // 
            // VisualDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.steeringWheel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualDisplayForm";
            this.Text = "VisualDisplayForm";
            this.Load += new System.EventHandler(this.VisualDisplayForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualDisplayForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.steeringWheel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer visualsUpdateTimer;
        private System.Windows.Forms.PictureBox steeringWheel;
    }
}
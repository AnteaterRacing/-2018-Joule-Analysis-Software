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
            this.SuspendLayout();
            // 
            // visualsUpdateTimer
            // 
            this.visualsUpdateTimer.Interval = 200;
            this.visualsUpdateTimer.Tick += new System.EventHandler(this.visualsUpdateTimer_Tick);
            // 
            // VisualDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualDisplayForm";
            this.Text = "VisualDisplayForm";
            this.Load += new System.EventHandler(this.VisualDisplayForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualDisplayForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer visualsUpdateTimer;
    }
}
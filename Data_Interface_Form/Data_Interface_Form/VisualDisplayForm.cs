using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Data_Interface_Form
{
    public partial class VisualDisplayForm : Form
    {
        public VisualDisplayForm()
        {
            InitializeComponent();
        }

        Image steeringWheelOriginal;
        private void VisualDisplayForm_Load(object sender, EventArgs e)
        {
            General.visualDisplayFormAddress = this;

            visualsUpdateTimer.Enabled = true;
            steeringWheelOriginal = steeringWheel.Image;
        }

        #region Declaring rectangle objects
        Rectangle frontLeftWheel1, frontLeftWheel2, frontLeftWheel3;
        Rectangle frontRightWheel1, frontRightWheel2, frontRightWheel3;
        Rectangle rearLeftWheel1, rearLeftWheel2, rearLeftWheel3;
        Rectangle rearRightWheel1, rearRightWheel2, rearRightWheel3;

        Rectangle packVoltage, packVoltageEmpty;
        #endregion

        #region Declaring color objects for the rectangles
        Color fl1_color = new Color();
        Color fl2_color = new Color();
        Color fl3_color = new Color();

        Color fr1_color = new Color();
        Color fr2_color = new Color();
        Color fr3_color = new Color();

        Color rl1_color = new Color();
        Color rl2_color = new Color();
        Color rl3_color = new Color();

        Color rr1_color = new Color();
        Color rr2_color = new Color();
        Color rr3_color = new Color();

        Color packVoltage_color = new Color();
        Color packVoltageEmpty_color = new Color();
        #endregion

        #region Declaring initial values for the pack charge visual

        int width_packVoltage = 60;
        int width_packVoltageEmpty = 0;

        int x_packVoltage = 300;
        int x_packVoltageEmpty = 360;

        //General.TTBL1 is divided by 200 in order to get it into a percentage approximately
        double x_fl1 = 0;
        double x_fl2 = 0;
        double x_fl3 = 0;

        double x_fr1 = 0;
        double x_fr2 = 0;
        double x_fr3 = 0;


        double x_rl1 = 0;
        double x_rl2 = 0;
        double x_rl3 = 0;

        double x_rr1 = 0;
        double x_rr2 = 0;
        double x_rr3 = 0;

        int i = 0;
        #endregion

        #region Declaring initial values for the steering wheel

        int lastSteeringWheelAngleValue = 0;
        
        #endregion

        private void VisualDisplayForm_Paint(object sender, PaintEventArgs e)
        {
            #region Create rectangle instances
            frontLeftWheel1 = new Rectangle(20, 60, 15, 80);
            frontLeftWheel2 = new Rectangle(35, 60, 15, 80);
            frontLeftWheel3 = new Rectangle(50, 60, 15, 80);

            frontRightWheel1 = new Rectangle(150, 60, 15, 80);
            frontRightWheel2 = new Rectangle(165, 60, 15, 80);
            frontRightWheel3 = new Rectangle(180, 60, 15, 80);

            rearLeftWheel1 = new Rectangle(20, 340, 15, 80);
            rearLeftWheel2 = new Rectangle(35, 340, 15, 80);
            rearLeftWheel3 = new Rectangle(50, 340, 15, 80);

            rearRightWheel1 = new Rectangle(150, 340, 15, 80);
            rearRightWheel2 = new Rectangle(165, 340, 15, 80);
            rearRightWheel3 = new Rectangle(180, 340, 15, 80);


            packVoltage = new Rectangle(x_packVoltage, 60, width_packVoltage, 20);
            packVoltageEmpty = new Rectangle(x_packVoltageEmpty, 60, width_packVoltageEmpty, 20);

            #endregion

            #region Rotates Front Wheels Based on Steering Angle
            if (lastSteeringWheelAngleValue != (float)General.steeringAngle)
            {
                steeringWheel.Image = RotateImage(steeringWheelOriginal, (float)(General.steeringAngle));
                lastSteeringWheelAngleValue = General.steeringAngle;
            }
            #endregion

            #region Create solid brush instances to color the rectangles
            SolidBrush fl1 = new SolidBrush(fl1_color);
            SolidBrush fl2 = new SolidBrush(fl2_color);
            SolidBrush fl3 = new SolidBrush(fl3_color);

            SolidBrush fr1 = new SolidBrush(fr1_color);
            SolidBrush fr2 = new SolidBrush(fr2_color);
            SolidBrush fr3 = new SolidBrush(fr3_color);

            SolidBrush rl1 = new SolidBrush(rl1_color);
            SolidBrush rl2 = new SolidBrush(rl2_color);
            SolidBrush rl3 = new SolidBrush(rl3_color);

            SolidBrush rr1 = new SolidBrush(rr1_color);
            SolidBrush rr2 = new SolidBrush(rr2_color);
            SolidBrush rr3 = new SolidBrush(rr3_color);

            SolidBrush voltageBrush = new SolidBrush(packVoltage_color);
            SolidBrush voltageEmptyBrush = new SolidBrush(packVoltageEmpty_color);
            #endregion

            #region Initially fill the color of the rectangles at visuals form openning

            RotateRectangle(e.Graphics, frontLeftWheel1, frontLeftWheel2, fl1, General.steeringAngle);
            RotateRectangle(e.Graphics, frontLeftWheel2, frontLeftWheel2, fl2, General.steeringAngle);
            RotateRectangle(e.Graphics, frontLeftWheel3, frontLeftWheel2, fl3, General.steeringAngle);

            RotateRectangle(e.Graphics, frontRightWheel1, frontRightWheel2, fr1, General.steeringAngle);
            RotateRectangle(e.Graphics, frontRightWheel2, frontRightWheel2, fr2, General.steeringAngle);
            RotateRectangle(e.Graphics, frontRightWheel3, frontRightWheel2, fr3, General.steeringAngle);

            e.Graphics.FillRectangle(rl1, rearLeftWheel1);
            e.Graphics.FillRectangle(rl2, rearLeftWheel2);
            e.Graphics.FillRectangle(rl3, rearLeftWheel3);

            e.Graphics.FillRectangle(rr1, rearRightWheel1);
            e.Graphics.FillRectangle(rr2, rearRightWheel2);
            e.Graphics.FillRectangle(rr3, rearRightWheel3);

            e.Graphics.FillRectangle(voltageBrush, packVoltage);
            e.Graphics.FillRectangle(voltageEmptyBrush, packVoltageEmpty);
            #endregion
        }

        private void visualsUpdateTimer_Tick(object sender, EventArgs e)
        {

            x_fl1 = (((double)(General.TTFL1)) / 200.0);
            x_fl2 = (((double)(General.TTFL2)) / 200.0);
            x_fl3 = (((double)(General.TTFL3)) / 200.0);

            x_fr1 = (((double)(General.TTFR1)) / 200.0);
            x_fr2 = (((double)(General.TTFR2)) / 200.0);
            x_fr3 = (((double)(General.TTFR3)) / 200.0);


            x_rl1 = (((double)(General.TTBL1)) / 200.0);
            x_rl2 = (((double)(General.TTBL2)) / 200.0);
            x_rl3 = (((double)(General.TTBL3)) / 200.0);

            x_rr1 = (((double)(General.TTBR1)) / 200.0);
            x_rr2 = (((double)(General.TTBR2)) / 200.0);
            x_rr3 = (((double)(General.TTBR3)) / 200.0);

            General.packCharge++;
            General.packCharge%=100;
            
            if (i % 30 < 10)
            {
                General.TTFL1++;
                
                General.TTFL1 = General.TTFL1 % 200;
                i++;
                General.steeringAngle += 1;
            }
            else if (i % 30 < 20)
            {
                General.TTFR1+=4;
                General.TTFR1 = General.TTFR1 % 200;
                General.steeringAngle -= 5;
                i++;
            }
            else
            {
                General.steeringAngle = 0;
                i++;
            }
            

            width_packVoltage = (int)((General.packCharge / 100.0) * (60.0));
            width_packVoltageEmpty = 60 - width_packVoltage;
            x_packVoltageEmpty = x_packVoltage + width_packVoltage;



            //This code will change the intensity of the tire color based on the tire temp
            fl1_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fl1), (int)((Color.Red.G) * x_fl1), (int)((Color.Red.B) * x_fl1));
            fl2_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fl2), (int)((Color.Red.G) * x_fl2), (int)((Color.Red.B) * x_fl2));
            fl3_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fl3), (int)((Color.Red.G) * x_fl3), (int)((Color.Red.B) * x_fl3));

            fr1_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fr1), (int)((Color.Red.G) * x_fr1), (int)((Color.Red.B) * x_fr1));
            fr2_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fr2), (int)((Color.Red.G) * x_fr2), (int)((Color.Red.B) * x_fr2));
            fr3_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_fr3), (int)((Color.Red.G) * x_fr3), (int)((Color.Red.B) * x_fr3));

            rl1_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rl1), (int)((Color.Red.G) * x_rl1), (int)((Color.Red.B) * x_rl1));
            rl2_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rl2), (int)((Color.Red.G) * x_rl2), (int)((Color.Red.B) * x_rl2));
            rl3_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rl3), (int)((Color.Red.G) * x_rl3), (int)((Color.Red.B) * x_rl3));

            rr1_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rr1), (int)((Color.Red.G) * x_rr1), (int)((Color.Red.B) * x_rr1));
            rr2_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rr2), (int)((Color.Red.G) * x_rr2), (int)((Color.Red.B) * x_rr2));
            rr3_color = Color.FromArgb(Color.Red.A, (int)((Color.Red.R) * x_rr3), (int)((Color.Red.G) * x_rr3), (int)((Color.Red.B) * x_rr3));

            packVoltage_color = Color.Green;
            packVoltageEmpty_color = Color.Black;

            this.Invalidate();
            return;
        }


        public static Bitmap RotateImage(Image b, float angle) // Source: https://stackoverflow.com/questions/27431345/rotating-image-around-center-c-sharp?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
        {
            //Create a new empty bitmap to hold rotated image.
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //Make a graphics object from the empty bitmap.
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image.
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //Rotate.        
            g.RotateTransform(angle);
            //Move image back.
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //Draw passed in image onto graphics object.
            //Found ERROR 1: Many people do g.DwarImage(b,0,0); The problem is that you re giving just the position
            //Found ERROR 2: Many people do g.DrawImage(b, new Point(0,0)); The size still not present hehe :3

            g.DrawImage(b, 0, 0, b.Width, b.Height);  //My Final Solution :3
            return returnBitmap;
        }

        public void RotateRectangle(Graphics g, Rectangle notMiddle, Rectangle Middle, SolidBrush s, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(Middle.Left + (Middle.Width / 2),
                                          Middle.Top + (Middle.Height / 2)));
                g.Transform = m;
    
                g.FillRectangle(s, notMiddle);
                g.ResetTransform();
            }
        }
    }
}
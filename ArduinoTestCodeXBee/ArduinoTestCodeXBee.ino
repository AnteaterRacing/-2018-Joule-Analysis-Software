/*____________________________________________________
   U C I   A R D U I N O   A C C E L E R O M E T E R
   Telemetry Demo
  Created 10/7/2017
  Ron Kessler
  ____________________________________________________
*/

//Use the calibration sketch to get ADXL335 readings

#include <SoftwareSerial.h>      //8/13/2017  This is added to use digital pins 2 & 3. The XBEE shield makes those connections.

SoftwareSerial XBeeSerial (0, 1); // RX, TX  XBEE shield connects to arduino com port. MAKE SURE SWITCH ON SHIELD IS SET TO DL.

void setup()
{
  analogReference(EXTERNAL);
  XBeeSerial.begin(9600);
  //  Serial.begin(9600);       //enable for testing
}

void loop()
{
    byte x = 255;
    byte y = 9;
      for (int i = 0; i < 26; i++)
      {
         if (i == 0)
            XBeeSerial.write(x);
          else
            XBeeSerial.write(y);
      }
    XBeeSerial.print("\n");
    delay(50);
}

//Use the calibration sketch to get ADXL335 readings

#include <SoftwareSerial.h>      //8/13/2017  This is added to use digital pins 2 & 3. The XBEE shield makes those connections.

SoftwareSerial XBeeSerial (0, 1); // RX, TX  XBEE shield connects to arduino com port. MAKE SURE SWITCH ON SHIELD IS SET TO DL.

void setup()
{
  XBeeSerial.begin(9600);
  //  Serial.begin(9600);       //enable for testing
}

void loop()
{
  XBeeSerial.print(5);
  delay (1000);
}

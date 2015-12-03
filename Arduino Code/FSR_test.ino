
#include <SPI.h>

const int chipSelect = 53;

int FSR_Pin = A0; //analog pin 0
int LED_Pin = 8; //led pwm pin 8

void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
  // FSR value input to pad on corresponding pin
  int FSRReading = analogRead(FSR_Pin);

  // Flag to stop polling after read
  static boolean flag = false;

  // read data if flag not set
  if (!flag)
  {
    if (FSRReading > 100)
    {
      // set flag once adequate force is detected
      flag = true;

      // serial FSR value to GUI
      Serial.println(FSRReading);
    }
  }

  // reset flag once no force is detected to start reading again
  if (FSRReading == 0)
    flag = false;

  // light up LED with FSR value tied to brightness
  analogWrite(LED_Pin, FSRReading/1.5);

}

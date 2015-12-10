
#include <SPI.h>

const int chipSelect = 53;

int FSR1_Pin = A8; //analog pin 8
int FSR2_Pin = A9; //analog pin 9
int FSR3_Pin = A0; //analog pin 0
int FSR4_Pin = A1; //analog pin 1

int LED_Pin = 8; //led pwm pin 8

void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
  // FSR value input to pad on corresponding pin
  int FSRReading1 = analogRead(FSR1_Pin);
  int FSRReading2 = analogRead(FSR2_Pin);
  int FSRReading3 = analogRead(FSR3_Pin);
  int FSRReading4 = analogRead(FSR4_Pin);

  const int temp1 = FSRReading1;
  const int temp2 = FSRReading2;
  const int temp3 = FSRReading3;
  const int temp4 = FSRReading4;
  
  int maxVal = 0;

  // Flag to stop polling after read
  static boolean flag = false;
  
  static boolean flag1 = false;
  static boolean flag2 = false;
  static boolean flag3 = false;
  static boolean flag4 = false;

  // read data if flag not set
  if (!flag)
  {
    if (FSRReading1 > 100 || FSRReading2 > 100
                          || FSRReading3 > 100 
                          || FSRReading4 > 100)
    {
      // set flag once adequate force is detected
      flag = true;
      maxVal = max(max(FSRReading1, FSRReading2), max(FSRReading3, FSRReading4));
      
      // serial FSR value to GUI

        if (maxVal == FSRReading1)
        {
           Serial.print(1);
           flag1 = true;
        }

        if (maxVal == FSRReading2)
        {
           Serial.print(2);
           flag2 = true;
        }

        if (maxVal == FSRReading3)
        {
           Serial.print(3);
           flag3 = true;
        }

        if (maxVal == FSRReading4)
        {
           Serial.print(4);
           flag4 = true;
        }


      Serial.println(maxVal);
      maxVal = 0;
    }
  }

  // reset flag once no force is detected to start reading again
  if (flag1 == true)
  {
    if (FSRReading1 == 0)
    {
      flag = false;
      flag1 = false;
    }
  }
  if (flag2 == true)
  {
    if (FSRReading2 == 0)
    {
      flag = false;
      flag2 = false;
    }
  }
  if (flag3 == true)
  {
    if (FSRReading3 == 0)
    {
      flag = false;
      flag3 = false;
    }
  }
  if (flag4 == true)
  {
    if (FSRReading4 == 0)
    {
      flag = false;
      flag4 = false;
    }
  }

}

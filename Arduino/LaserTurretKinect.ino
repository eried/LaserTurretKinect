#include <Servo.h>
Servo s1, s2;

void setup()
{
  s1.attach(2);
  s2.attach(3);
  Serial.begin(9600);
}

void loop() 
{ 
   if(Serial.available()>2)
   {
     switch(Serial.read())
     {
       case 'X':
         s1.write(Serial.read());
         break;
       case 'Y':
         s2.write(Serial.read());
         break;
     }
   }
}

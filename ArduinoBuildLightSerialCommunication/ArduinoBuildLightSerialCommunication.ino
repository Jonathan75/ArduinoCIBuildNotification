const int redLed = 11;
const int yellowLed = 12;
const int greenLed = 13;

int count = 0;

//int lights[] = {11,12,13};

int brightness = 0;    // how bright the LED is
int fadeAmount = 1;    // how many points to fade the LED by
int brightnessMax = 255;
int lightPin = 13;
int lightValue = 10000;

void setup() {                
  Serial.begin(9600);
  pinMode(redLed, OUTPUT);    
  pinMode(yellowLed, OUTPUT);    
  pinMode(greenLed, OUTPUT);     
  testLights();
}


void loop() {
  if(count < 25)
  {
     testLights();
     count++;
  }
  //cycleLights();  
  readCommand();            
  //blinkLight();
}


void testLights()
{
  digitalWrite(greenLed, HIGH);
  delay(500); 
  digitalWrite(yellowLed, HIGH);
  delay(500); 
  digitalWrite(redLed, HIGH);
  delay(500); 
  digitalWrite(greenLed, LOW);
  delay(500); 
  digitalWrite(yellowLed, LOW);
  delay(500); 
  digitalWrite(redLed, LOW);
}
void cycleLights()
{
  digitalWrite(greenLed, HIGH);
  delay(lightValue); 
  digitalWrite(greenLed, LOW);
  
  digitalWrite(yellowLed, HIGH);
  delay(lightValue);
  digitalWrite(yellowLed, LOW);
  
  digitalWrite(redLed, HIGH);
  delay(lightValue); 
  digitalWrite(redLed, LOW);
}


void blinkLight()
{
  analogWrite(redLed, brightness);   
  brightness = brightness + fadeAmount;
  if (brightness == 0 || brightness == brightnessMax) {
    fadeAmount = -fadeAmount ; 
  }   
  delay(lightValue);  
}

void readCommand()
{
  if(Serial.available())
  {
    String input;   
    input = Serial.readString(); 
    
    Serial.print("Echo ");
    Serial.println(input);  
  }  
}



//void readCommand()
//{
//  if(Serial.available())
//  {
//    inputSize = 10;
//    char input[inputSize + 1];
//    
//    byte size = Serial.readBytes(input, sizeof(input) / sizeof(int));
//    input[size] = 0;
//    
//    
////    lightPin = Serial.parseInt();  
////    lightValue = Serial.parseInt();  
////    Serial.println(lightPin);
////    Serial.println(lightValue);
//    
//    digitalWrite(lightPin,lightValue);
//  }
//}



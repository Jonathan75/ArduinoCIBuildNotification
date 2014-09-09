const int redLed = 11;
const int yellowLed = 12;
const int greenLed = 13;

int brightness = 0;    // how bright the LED is
int fadeAmount = 1;    // how many points to fade the LED by
int brightnessMax = 255;
char lightCommand = ' ';
int lightValue = 30;

void setup() {                
  Serial.begin(9600);
  pinMode(redLed, OUTPUT);    
  pinMode(yellowLed, OUTPUT);    
  pinMode(greenLed, OUTPUT);    
  
  digitalWrite(yellowLed, HIGH);
  digitalWrite(greenLed, HIGH);
  digitalWrite(redLed, HIGH);
  delay(5000); 
  digitalWrite(yellowLed, LOW);
  digitalWrite(greenLed, LOW);
  digitalWrite(redLed, LOW);
}


void loop() {
  cycleLights();  
  readCommand();            
  //blinkLight();
}

void cycleLights()
{
  digitalWrite(yellowLed, HIGH);
  delay(lightValue); 
  digitalWrite(yellowLed, LOW);
  digitalWrite(greenLed, HIGH);
  delay(lightValue);
  digitalWrite(greenLed, LOW);
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
    lightValue = Serial.parseInt();  
    Serial.println(lightValue);
  }
}

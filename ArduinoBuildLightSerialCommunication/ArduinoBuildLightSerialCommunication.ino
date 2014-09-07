const int redLed = 11;
const int yellowLed = 12;
const int greenLed =13;

int brightness = 0;    // how bright the LED is
int fadeAmount = 1;    // how many points to fade the LED by
int brightnessMax = 50;
int delayValue = 30;

void setup() {                
  Serial.begin(9600);
  pinMode(redLed, OUTPUT);    
  pinMode(yellowLed, OUTPUT);    
  pinMode(greenLed, OUTPUT);    
  
  digitalWrite(yellowLed, HIGH);
  digitalWrite(greenLed, HIGH);
  
  
  delay(5000); 
}


void loop() {
  
  blinkLight();
  readCommand();            
}

void blinkLight()
{
  analogWrite(redLed, brightness);   
  brightness = brightness + fadeAmount;
  if (brightness == 0 || brightness == brightnessMax) {
    fadeAmount = -fadeAmount ; 
  }   
  delay(delayValue);  
}

void readCommand()
{
  if(Serial.available())
  {
    delayValue = Serial.parseInt();  
    Serial.println(delayValue);
  }
}

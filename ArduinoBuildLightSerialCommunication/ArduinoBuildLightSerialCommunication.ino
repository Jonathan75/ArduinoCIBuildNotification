const int led = 9;
int brightness = 0;    // how bright the LED is
int fadeAmount = 1;    // how many points to fade the LED by
int brightnessMax = 50;
int delayValue = 30;

void setup() {                
  Serial.begin(9600);
  pinMode(led, OUTPUT);    
  delay(5000); 
}


void loop() {
  blinkLight();
  readCommand();            
}

void blinkLight()
{
  analogWrite(led, brightness);   
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

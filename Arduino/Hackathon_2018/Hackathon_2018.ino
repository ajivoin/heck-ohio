#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
#include <avr/power.h>
#include <dht11.h>
#include <Wire.h>
#include <SPI.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BME280.h>
#define BME_SCK 13
#define BME_MISO 12
#define BME_MOSI 11
#define BME_CS 10
#define DHT11PIN 4

#endif
Adafruit_BME280 bme; // I2C

dht11 DHT11;

#define PIN 2
int analog_sensor  = A0; // select the input pin for the potentiometer
int relayPin = 3;
int inputPin = 9;
int outputPin = 8;
int scaledDistance = 0;
int analogValue ;
int maximum = 0;
int distance = 0;
int lastValue = 0;
int lastNonNegative = 0;

// Parameter 1 = number of pixels in strip
// Parameter 2 = Arduino pin number (most are valid)
// Parameter 3 = pixel type flags, add together as needed:
//   NEO_KHZ800  800 KHz bitstream (most NeoPixel products w/WS2812 LEDs)
//   NEO_KHZ400  400 KHz (classic 'v1' (not v2) FLORA pixels, WS2811 drivers)
//   NEO_GRB     Pixels are wired for GRB bitstream (most NeoPixel products)
//   NEO_RGB     Pixels are wired for RGB bitstream (v1 FLORA pixels, not v2)
//   NEO_RGBW    Pixels are wired for RGBW bitstream (NeoPixel RGBW products)
Adafruit_NeoPixel strip = Adafruit_NeoPixel(18, PIN, NEO_GRB + NEO_KHZ800);

// IMPORTANT: To reduce NeoPixel burnout risk, add 1000 uF capacitor across
// pixel power leads, add 300 - 500 Ohm resistor on first pixel's data input
// and minimize distance between Arduino and first pixel.  Avoid connecting
// on a live circuit...if you must, connect GND first.

void setup() {
  pinMode(relayPin, OUTPUT);
  pinMode(inputPin, INPUT);
  pinMode(outputPin, OUTPUT);
  Serial.begin(9600);
  bool status;
  status = bme.begin();

  strip.begin();
  strip.show(); // Initialize all pixels to 'off'
}

void loop() {
  for (uint16_t i = 8; i < strip.numPixels(); i++) {
  strip.setPixelColor(i, strip.Color(0,0,200));
  strip.show();
  }
  for (uint16_t i = 0; i < 6; i++) {
  strip.setPixelColor(i, strip.Color(200,0,0));
  strip.show();
  }
  delay(2000);
   for (uint16_t i = 8; i < strip.numPixels(); i++) {
  strip.setPixelColor(i, strip.Color(200,0,0));
  strip.show();
  }
  for (uint16_t i = 0; i < 6; i++) {
  strip.setPixelColor(i, strip.Color(0,0,200));
  strip.show();
  }
  delay(2000);
  // analogValue = analogRead (analog_sensor);
  // Serial.println (analogValue-80, DEC);
  //allOn(strip.Color(0,170,0));
  //digitalWrite(relayPin, HIGH);
  //delay(10000);
  //digitalWrite(relayPin, LOW); // The driving relay is disconnected
  //delay(10000);
  sendOutputValue();
  recieveInputValue();
}
void sendOutputValue() {
  int chk = DHT11.read(4);
  Serial.print(bme.readTemperature() * 9 / 5 + 32);
  Serial.print(",");
  Serial.print(Fahrenheit(DHT11.temperature) - 3, 2);
  Serial.print(",");
  Serial.print(bme.readHumidity());
  Serial.print(",");
  Serial.print(DHT11.humidity);
  Serial.print(",");
  Serial.print(bme.readPressure());
  Serial.print(",");
  Serial.print(ultraDistance());
  Serial.print(",");
  Serial.print("\n");
  delay(80);
}
int ultraDistance() {
  digitalWrite(outputPin, LOW);
  delayMicroseconds(2);
  digitalWrite(outputPin, HIGH); // Pulse for 10μs to trigger ultrasonic detection
  delayMicroseconds(10);
  digitalWrite(outputPin, LOW);
  distance = pulseIn(inputPin, HIGH);  // Read receiver pulse time
  distance = distance / 58; // Transform pulse time to distance
  delay(50);
  if (distance < 0)
    distance = lastNonNegative;
  if (distance > 0)
    lastNonNegative = distance;
  if ((distance - lastValue) > 20)
    distance = lastValue;
  return distance;
}
void recieveInputValue() {
  if (Serial.available())
  {
    int inputValue = Serial.read();
  }
}

double Fahrenheit(double celsius)
{
  return 1.8 * celsius + 32;
}

void setLeft() {
}

void allOn(uint32_t c) {
  for (uint16_t i = 0; i < strip.numPixels(); i++) {
    strip.setPixelColor(i, c);
    strip.show();
  }
}
void allOff() {
  for (uint16_t i = 0; i < strip.numPixels(); i++) {
    strip.setPixelColor(i, 0);
    strip.show();
  }
}
void flash(uint32_t c, uint8_t wait) {
  allOn(c);
  strip.show();
  delay(wait);
  allOff();
  strip.show();
  delay(wait);
}

// Fill the dots one after the other with a color
void colorWipe(uint32_t c, uint8_t wait) {
  for (uint16_t i = 0; i < strip.numPixels(); i++) {
    strip.setPixelColor(i, c);
    strip.show();
    delay(wait);
  }
}
void colorWipeBack(uint32_t c, uint8_t wait) {
  for (uint16_t i = strip.numPixels(); i > 0; i--) {
    strip.setPixelColor(i, c);
    strip.show();
    delay(wait);
  }
}
void chase(uint32_t c, uint8_t wait) {
  for (uint16_t i = 0; i < strip.numPixels(); i++) {
    if (i == 0) {
      strip.setPixelColor(strip.numPixels(), strip.Color(0, 0, 0));
    }
    else {
      strip.setPixelColor(i - 1, strip.Color(0, 0, 0));
    }
    strip.setPixelColor(i, c);
    strip.show();
    delay(wait);
  }
}
//void chasePersist(uint32_t c, uint8_t wait) {
//  (uint16_t i = 0; i < strip.numPixels(); i++) {
//    strip.setPixelColor(i, c);
//    strip.show();
//    delay(wait);
//  }
//}
void rainbow(uint8_t wait) {
  uint16_t i, j;

  for (j = 0; j < 256; j++) {
    for (i = 0; i < strip.numPixels(); i++) {
      strip.setPixelColor(i, Wheel((i + j) & 255));
    }
    strip.show();
    delay(wait);
  }
}

// Slightly different, this makes the rainbow equally distributed throughout
void rainbowCycle(uint8_t wait) {
  uint16_t i, j;

  for (j = 0; j < 256 * 5; j++) { // 5 cycles of all colors on wheel
    for (i = 0; i < strip.numPixels(); i++) {
      strip.setPixelColor(i, Wheel(((i * 256 / strip.numPixels()) + j) & 255));
    }
    strip.show();
    delay(wait);
  }
}

//Theatre-style crawling lights.
void theaterChase(uint32_t c, uint8_t wait) {
  for (int j = 0; j < 10; j++) { //do 10 cycles of chasing
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, c);  //turn every third pixel on
      }
      strip.show();

      delay(wait);

      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, 0);      //turn every third pixel off
      }
    }
  }
}

//Theatre-style crawling lights with rainbow effect
void theaterChaseRainbow(uint8_t wait) {
  for (int j = 0; j < 256; j++) {   // cycle all 256 colors in the wheel
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, Wheel( (i + j) % 255)); //turn every third pixel on
      }
      strip.show();

      delay(wait);

      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, 0);      //turn every third pixel off
      }
    }
  }
}

// Input a value 0 to 255 to get a color value.
// The colours are a transition r - g - b - back to r.
uint32_t Wheel(byte WheelPos) {
  WheelPos = 255 - WheelPos;
  if (WheelPos < 85) {
    return strip.Color(255 - WheelPos * 3, 0, WheelPos * 3);
  }
  if (WheelPos < 170) {
    WheelPos -= 85;
    return strip.Color(0, WheelPos * 3, 255 - WheelPos * 3);
  }
  WheelPos -= 170;
  return strip.Color(WheelPos * 3, 255 - WheelPos * 3, 0);
}

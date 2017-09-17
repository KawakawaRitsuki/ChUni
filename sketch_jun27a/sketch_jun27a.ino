#include "FastLED.h"
 int threshold = 300;
 
#define NUM_LEDS 16
#define DATA_PIN 3

CRGB leds[NUM_LEDS];
 void setup() {
     Serial.begin(9600) ;
  FastLED.addLeds<NEOPIXEL, DATA_PIN>(leds, NUM_LEDS);
 }
 int last = 0;
 void loop() {
     if ( analogRead(0) < threshold ) {
       if(last == 0){
         leds[0] = CRGB::Yellow;
         last = 1;
       }
     }else{
       if(last == 1){
         Serial.println("はなした");
         leds[0] = CRGB::DeepPink;
         last = 0;
       }
     }
 }

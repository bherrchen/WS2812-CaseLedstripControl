
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Stripcontrol
//
//	v0.01
//	prototype
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Defines
//#include <EEPROM.h>
#include "FastLED.h"
#include <Adafruit_NeoPixel.h>


FASTLED_USING_NAMESPACE


#if defined(FASTLED_VERSION) && (FASTLED_VERSION < 3001000)
#warning "Requires FastLED 3.1 or later; check github for latest code."
#endif

//#define DATA_PIN    3
//#define CLK_PIN   4
#define LED_TYPE    WS2811
#define COLOR_ORDER GRB
#define NUM_LEDS    57
#define CHIPSET     WS2812
bool gReverseDirection = true;


CRGB leftLeds[NUM_LEDS]; 
CRGB centerLeds[NUM_LEDS];
CRGB rightLeds[NUM_LEDS];


#define BRIGHTNESS         200
#define FRAMES_PER_SECOND  120



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// VARS

String inputString = "";         // a string to hold incoming data
String SerialMSG = "";
boolean stringComplete = false;  // whether the string is complete


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Setup Loop

void setup() {
  delay(3000); // 3 second delay for recovery
  
  // tell FastLED about the LED strip configuration
  LEDS.addLeds<WS2811, 3, GRB>(leftLeds, NUM_LEDS);
  LEDS.addLeds<WS2811, 5, GRB >(centerLeds, NUM_LEDS);
  LEDS.addLeds<WS2811, 4, GRB >(rightLeds, NUM_LEDS);

  // set master brightness control
  FastLED.setBrightness(BRIGHTNESS);
  
    // initialize serial:
  Serial.begin(9600);
  // reserve 200 bytes for the inputString:
  inputString.reserve(200);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// typedef

// List of patterns to cycle through.  Each is defined as a separate function below.
typedef void (*SimplePatternList[])();
SimplePatternList gPatterns = { boot, white, black, rainbow, rainbowWithGlitter, confetti, sinelon, juggle, bpm, rainbow2, fire };

uint8_t gCurrentPatternNumber = 1; // Index number of which pattern is current
uint8_t gHue = 0; // rotating "base color" used by many of the patterns
bool initialized = false;
uint8_t lastSerial = 0;
uint8_t max_bright = 128;   
uint8_t frequency = 50;                                       // controls the interval between strikes
uint8_t flashes = 8;                                          //the upper limit of flashes per strike
unsigned int dimmer = 1;
uint8_t mod1;
uint8_t mod2;
uint8_t ledstart;                                             // Starting location of a flash
uint8_t ledlen;   

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Patterns Setting
// Settings for Fire2012

#define COOLING  55
#define SPARKING 120


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Main Loop


void loop()
{

   //serial communication
   if (stringComplete) {
    
    SerialMSG = inputString;
    // clear the string:
    inputString = "";
    stringComplete = false;
    gCurrentPatternNumber = SerialMSG.toInt();
    lastSerial = SerialMSG.toInt();
  }
  
  // send the 'leds' array out to the actual LED strip
  FastLED.show();  
  // insert a delay to keep the framerate modest
  FastLED.delay(1000/FRAMES_PER_SECOND); 
  // Call the current pattern function once, updating the 'leds' array

  gPatterns[gCurrentPatternNumber]();
  //boot();
  
  

  // do some periodic updates
  EVERY_N_MILLISECONDS( 20 ) { gHue++; } // slowly cycle the "base color" through the rainbow
  
  EVERY_N_SECONDS( 10 ) { if (lastSerial == 55) { nextPattern(); }} // change patterns periodically
  

 
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Pattern Control
#define ARRAY_SIZE(A) (sizeof(A) / sizeof((A)[0]))


void nextPattern()
{
  // add one to the current pattern number, and wrap around at the end
  gCurrentPatternNumber = (gCurrentPatternNumber + 1) % ARRAY_SIZE( gPatterns);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Individual Patterns

void boot() 
{
  if (!initialized) {
 
  FastLED.clear();
  FastLED.show(); 
  delay(3000); //pause  
  initialized = true;
  
  } else
    {
    
           
     for (int CDOWN = 0; CDOWN < 57; CDOWN++) {
        fadeToBlackBy( leftLeds, 57, 20);
        fadeToBlackBy( centerLeds, 57,20);
        fadeToBlackBy( rightLeds, 57, 20);  
      
        leftLeds[CDOWN] += CRGB::White;
        centerLeds[CDOWN] += CRGB::White;
        rightLeds[CDOWN] += CRGB::White;
        
        FastLED.show(); 
        delay(60);
        }
    for (int i =0; i<80;i++) {
        fadeToBlackBy( leftLeds, 57, 10);
        fadeToBlackBy( centerLeds, 57, 10);
        fadeToBlackBy( rightLeds, 57, 10);  
        FastLED.show(); 
        delay(30);
    }
    delay(2000);
     for (int y =0; y<255;y++) {
        for (int i =0; i<NUM_LEDS;i++) {
          
          leftLeds[i]++;   
          centerLeds[i]++;
          rightLeds[i]++;
        }
        
        
        FastLED.show(); 
        delay(50);
    }
    initialized=false;
    nextPattern(); 
    }
       
}


void white()
{
  for( int i = 0; i < NUM_LEDS; i++) {
    leftLeds[i] += CRGB::White;
    centerLeds[i] += CRGB::White;
    rightLeds[i] += CRGB::White;
  }
}

void black()
{
         fadeToBlackBy( leftLeds, 57, 10);
        fadeToBlackBy( centerLeds, 57, 10);
        fadeToBlackBy( rightLeds, 57, 10);  
 }


void rainbow() 
{
  // FastLED's built-in rainbow generator
  fill_rainbow( leftLeds, NUM_LEDS, gHue, 5);
  fill_rainbow( centerLeds, NUM_LEDS, gHue, 5);
  fill_rainbow( rightLeds, NUM_LEDS, gHue, 5);
    
    /*
    EVERY_N_MILLISECONDS(100) {
      if (mod2 = 0) {mod2=1;}
      else {mod2=1;}
    }
    
    if (mod2 = 1) {
      for( int i = 0; i < NUM_LEDS; i++) {
      leftLeds[i] += CRGB::White;
      centerLeds[i] += CRGB::White;
      rightLeds[i] += CRGB::White; }
    }
    else
    { 
      for( int i = 0; i < NUM_LEDS; i++) {
      leftLeds[i] = CRGB::Black;
      centerLeds[i] = CRGB::Black;
      rightLeds[i] = CRGB::Black; }

        
       /* fadeToBlackBy( leftLeds, 57, 255);
        fadeToBlackBy( centerLeds, 57, 255);
        fadeToBlackBy( rightLeds, 57, 255); */
    
  
}

void rainbow2(){
 
 // regenbogen(uint32_t warteZeit, uint8_t saettigung, uint8_t hellwert)
  regenbogen(1500, 220, 250);
}
void regenbogen(uint32_t warteZeit, uint8_t saettigung, uint8_t hellwert)
  // warteZeit = Dauer um den Farbkreis einmal zu durchlaufen
  // saettigung = 0 - 255; 255 voll gesaettigte Farben
  // hellwert = 0 - 255; 255 volle Helligkeit
{
  uint32_t aktuelleZeit = millis();
  uint8_t farbverschiebung = (180 * aktuelleZeit / warteZeit) % 255;
  
      for(uint8_t led = 24; led < NUM_LEDS; led++)
     {
    uint8_t farbwert = (led * 255 / (NUM_LEDS + 2) - farbverschiebung ) % 255;
               leftLeds[led] = CHSV(farbwert, saettigung, hellwert);
               centerLeds[led] = CHSV(farbwert, saettigung, hellwert);
               rightLeds[led] = CHSV(farbwert, saettigung, hellwert);
    }
 //      for(uint8_t led = 13; led < NUM_LEDS-13; led++)
 //    {
 //   uint8_t farbwert = (led / (NUM_LEDS) * farbverschiebung );
 //              leftLeds[led] = CHSV(farbwert+farbverschiebung, saettigung, hellwert);
 //     }
       for(uint8_t led = 0; led < NUM_LEDS-24; led++)
       {
               uint8_t farbwert = (led * 255 / (NUM_LEDS + 2) + farbverschiebung ) % 255;
               leftLeds[led] = CHSV(farbwert, saettigung, hellwert);
               centerLeds[led] = CHSV(farbwert, saettigung, hellwert);
               rightLeds[led] = CHSV(farbwert, saettigung, hellwert);
  }
  FastLED.show();
}

void gradientRight(byte ledcount, byte rainbowWidth, byte sat, unsigned int duration) {
  memset(leftLeds, 0, ledcount*3);
  byte hue[NUM_LEDS];

  // Farbverschiebung
  byte colorshift = (255*millis()/duration)%255;
  for(int i = 0; i < ledcount; i++) {
    hue[i] = (i*255/rainbowWidth+colorshift)%255;
  }

  // Farbton nach rechts verschieben (1 2 3 4 5, -> 5 1 2 3 4)
  for(int led = 0; led < ledcount; led++) {
    leftLeds[ledcount-(led+1)] = CHSV(hue[led], sat, 200);
  }

  FastLED.show();
}
void gradientLeft(byte ledcount, byte rainbowWidth, byte sat, unsigned int duration) {
  memset(leftLeds, 0, ledcount*3);
  byte hue[NUM_LEDS];

  // Farbverschiebung
  byte colorshift = (255*millis()/duration)%255;
  for(int i = 0; i < ledcount; i++) {
    hue[i] = (i*255/rainbowWidth+colorshift)%255;
  }

  // Farbton nach links verschieben (1 2 3 4 5 -> 2 3 4 5 1)
  for(int led = 0; led < ledcount; led++)
  {
    leftLeds[led] = CHSV(hue[led], sat, 255);
  }

  FastLED.show();
}

void explosion(byte ledcount,byte rainbowWidth,byte sat, unsigned int duration) {
  memset(leftLeds,0,ledcount*3);
  byte hue[NUM_LEDS];

  // Farbverschiebung
  byte colorshift = (255*millis()/duration)%255;
  for(int i = 0; i < ledcount; i++) {
    hue[i] = (i*255/rainbowWidth+colorshift)%255;
  }

  // Farbton nach links verschieben (3 2 1 -> 4 3 2)
  for(int led = 0; led < ledcount/2; led++) {
    leftLeds[led] = CHSV(hue[led], sat, 100);
  }

  // Gerade Anzahl Leds
  // Farbton nach rechts verschieben (1 2 3 -> 4 3 2)
  if(ledcount%2 == 0) {
    for(int led = ledcount/2; led < ledcount; led++) {
      leftLeds[led] = CHSV(hue[ledcount-led], sat, 100);
    }
  }
  // Ungerade Anzahl Leds
  // Farbton nach rechts verschieben (1 2 3 -> 4 3 2)
  else {
    for(int led = (ledcount/2)+1; led < ledcount; led++) {
      leftLeds[led] = CHSV(hue[(ledcount-1)-led], sat, 100);
    }
    // Farbton nach links und rechts verschieben (2 1 2 -> 3 2 3)
    leftLeds[(ledcount/2)] = CHSV(hue[(ledcount/2)], sat, 100);
  }

  FastLED.show();
}

void implosion(byte ledcount,byte rainbowWidth,byte sat, unsigned int duration) {
  memset(leftLeds,0,ledcount*3);
  byte hue[NUM_LEDS];

  // Farbverschiebung
  byte colorshift = (255*millis()/duration)%255;
  for(int i = 0; i < ledcount; i++) {
    hue[i] = (i*255/rainbowWidth+colorshift)%255;
  }
  
  // Farbton nach rechts verschieben (3 2 1 -> 2 3 4)
  for(int led = 0; led < ledcount/2; led++) {
    leftLeds[led] = CHSV(hue[(ledcount/2)-led], sat, 100);
  }
  
  // Farbton nach links verschieben (3 2 1 -> 2 1 4)
  for(int led = ledcount/2; led < ledcount; led++) {
    leftLeds[led] = CHSV(hue[led-(ledcount/2)], sat, 100);
  }

  FastLED.show();
}

void rainbowWithGlitter() 
{
  // built-in FastLED rainbow, plus some random sparkly glitter
  rainbow();
  addGlitter(80);
}

void addGlitter( fract8 chanceOfGlitter) 
{
  if( random8() < chanceOfGlitter) {
    leftLeds[ random16(NUM_LEDS) ] += CRGB::White;
    rightLeds[ random16(NUM_LEDS) ] += CRGB::White;
    centerLeds[ random16(NUM_LEDS) ] += CRGB::White;
  }
}

void confetti() 
{
  // random colored speckles that blink in and fade smoothly
  fadeToBlackBy( leftLeds, NUM_LEDS, 10);
  fadeToBlackBy( rightLeds, NUM_LEDS, 10);
  fadeToBlackBy( centerLeds, NUM_LEDS, 10);
  int pos1 = random16(NUM_LEDS);
  int pos2 = random16(NUM_LEDS);
  int pos3 = random16(NUM_LEDS);
  leftLeds[pos1] += CHSV( gHue + random8(64), 200, 255);
  centerLeds[pos2] += CHSV( gHue + random8(64), 200, 255);
  rightLeds[pos3] += CHSV( gHue + random8(64), 200, 255);
}

void sinelon()
{
  // a colored dot sweeping back and forth, with fading trails
  fadeToBlackBy( leftLeds, NUM_LEDS, 10);
  fadeToBlackBy( rightLeds, NUM_LEDS, 10);
  fadeToBlackBy( centerLeds, NUM_LEDS, 10);
  int pos1 = beatsin16(13,0,NUM_LEDS);
  int pos2 = beatsin16(13,0,NUM_LEDS);
  int pos3 = beatsin16(13,0,NUM_LEDS);
  leftLeds[pos1] += CHSV( gHue, 255, 192);
  centerLeds[pos2] += CHSV( gHue, 255, 192);
  rightLeds[pos3] += CHSV( gHue, 255, 192);
}

void bpm()
{
  // colored stripes pulsing at a defined Beats-Per-Minute (BPM)
  uint8_t BeatsPerMinute = 62;
  CRGBPalette16 palette = PartyColors_p;
  uint8_t beat = beatsin8( BeatsPerMinute, 64, 255);
  for( int i = 0; i < NUM_LEDS; i++) { //9948
    leftLeds[i] = ColorFromPalette(palette, gHue+(i*2), beat-gHue+(i*10));
    centerLeds[i] = ColorFromPalette(palette, gHue+(i*2), beat-gHue+(i*10));
    rightLeds[i] = ColorFromPalette(palette, gHue+(i*2), beat-gHue+(i*10));
  }
}

void juggle() {
  // eight colored dots, weaving in and out of sync with each other
  fadeToBlackBy( leftLeds, NUM_LEDS, 10);
  fadeToBlackBy( rightLeds, NUM_LEDS, 10);
  fadeToBlackBy( centerLeds, NUM_LEDS, 10);
  byte dothue = 0;
  for( int i = 0; i < 8; i++) {
    rightLeds[beatsin16(i+7,0,NUM_LEDS)] |= CHSV(dothue, 200, 255);
    centerLeds[beatsin16(i+7,0,NUM_LEDS)] |= CHSV(dothue, 200, 255);
    leftLeds[beatsin16(i+7,0,NUM_LEDS)] |= CHSV(dothue, 200, 255);
    dothue += 32;
  }
}


void fire() {
// Array of temperature readings at each simulation cell
  static byte heat1[NUM_LEDS];
  static byte heat2[NUM_LEDS];
  static byte heat3[NUM_LEDS];

  // Step 1.  Cool down every cell a little
    for( int i = 0; i < NUM_LEDS; i++) {
      heat1[i] = qsub8( heat1[i],  random8(0, ((COOLING * 10) / NUM_LEDS) + 2));
      heat2[i] = qsub8( heat2[i],  random8(0, ((COOLING * 10) / NUM_LEDS) + 2));
      heat3[i] = qsub8( heat3[i],  random8(0, ((COOLING * 10) / NUM_LEDS) + 2));
    }
  
    // Step 2.  Heat from each cell drifts 'up' and diffuses a little
    for( int k= NUM_LEDS - 1; k >= 2; k--) {
      heat1[k] = (heat1[k - 1] + heat1[k - 2] + heat1[k - 2] ) / 3;
      heat2[k] = (heat2[k - 1] + heat2[k - 2] + heat2[k - 2] ) / 3;
      heat3[k] = (heat3[k - 1] + heat3[k - 2] + heat3[k - 2] ) / 3;
    }
    
    // Step 3.  Randomly ignite new 'sparks' of heat near the bottom
    if( random8() < SPARKING ) {
      int y1 = random8(7);
      int y2 = random8(7);
      int y3 = random8(7);
      heat1[y1] = qadd8( heat1[y1], random8(160,255) );
      heat2[y2] = qadd8( heat2[y2], random8(160,255) );
      heat3[y3] = qadd8( heat3[y3], random8(160,255) );
    }

    // Step 4.  Map from heat cells to LED colors
    for( int j = 0; j < NUM_LEDS; j++) {
      CRGB color1 = HeatColor( heat1[j]);
      CRGB color2 = HeatColor( heat2[j]);
      CRGB color3 = HeatColor( heat3[j]);
      int pixelnumber;
      if( gReverseDirection ) {
        pixelnumber = (NUM_LEDS-1) - j;
      } else {
        pixelnumber = j;
      }
      leftLeds[pixelnumber] = color1;
      centerLeds[pixelnumber] = color2;
      rightLeds[pixelnumber] = color3;
    }
  
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Serial Communication

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////// EOF


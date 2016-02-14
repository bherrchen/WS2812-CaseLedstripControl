using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardustripcontrol2811
{
    class manualStripController
    {
        private byte[] LEDstripArray;
        private int arduino_PIN;
        private bool initialized = false;


        public manualStripController(int pin, int ledcount)
        {
            LEDstripArray = new Byte[ledcount];
            foreach (Byte by in LEDstripArray) {
                LEDstripArray[by] = 0x00;
            }
            arduino_PIN = pin;
            initialized = true;
        }


        public void setLEDvalue(int led, byte ledvalue) {
            LEDstripArray[led] = ledvalue;
        }

        public byte getLEDvalue(int led) {
            return LEDstripArray[led];
        }

        public void updateArduino(arduino arduinoBoard)
        {
            arduinoBoard.SCsendLEDarray(LEDstripArray);
        }

    }
}

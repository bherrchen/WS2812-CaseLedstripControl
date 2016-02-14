using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ardustripcontrol2811
{

    public class arduino
    {

        private SerialPort arduinoBoard = new SerialPort();
        public String versionFromArduino;
        private bool comPortOpen;
        

        public arduino()
            {
            comPortOpen = arduinoBoard.IsOpen;
            }

        public void OpenArduinoConnection(String s)
        {
            if (!arduinoBoard.IsOpen)
            {
                //arduinoBoard.DataReceived += arduinoBoard_DataReceived;
                arduinoBoard.BaudRate = 9600;
                arduinoBoard.PortName = s;
                if (System.IO.Ports.SerialPort.GetPortNames().Contains(s))
                {
                    try { arduinoBoard.Open(); }    
                    catch (Exception Ex) { return; }
                   
                }
                
            }
            else
            {
                //throw new InvalidOperationException("The Serial Port is already open!");
                Console.WriteLine("The Serial Port is already open!");
                return;
            }
        }

        public void CloseArduinoConnection()
        {
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Close();
            }
        }

        public bool SCsendCommand(int command)
        {           
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.WriteLine(command.ToString());
                
                return true;
            }
            else { return false; }
        }

        public bool getVersion()
        {
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("50");
                arduinoBoard.NewLine = "\n";
                arduinoBoard.ReadTimeout = 2000;
                this.versionFromArduino = "N/A";
                try { this.versionFromArduino = arduinoBoard.ReadLine(); }
                catch (TimeoutException) { Console.WriteLine("Timeout"); }
                
                return true;
            } else { return false; };
        }
        public bool isComPortOpen ()
        {
            comPortOpen = arduinoBoard.IsOpen;
            return comPortOpen;
        }

        public void SCsendLEDarray(Byte[] ledStripArray)
        {
            if (this.comPortOpen)
            {
                arduinoBoard.WriteLine("99");
                arduinoBoard.WriteLine(ledStripArray.ToString());
            }
        }
    }
}

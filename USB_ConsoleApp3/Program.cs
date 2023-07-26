using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CyUSB;

namespace USB_ConsoleApp3
{


    internal class Program
    {

        static SerialPort _serialPort;
        static void Main(string[] args)
        {
            Program program = new Program();

            program.InitCOM("COM9");
            program.OpenPort();
            program.SendCommand("\x01\x01\x01\xfd");

            Console.ReadLine();


        }



        public void InitCOM(string PortName)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = PortName;// SetPortName("COM4");//SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = 9600;// SetPortBaudRate(9600);//SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = Parity.None;// SetPortParity(Parity.None);//SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = 8;// SetPortDataBits(8);//SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = StopBits.One;// SetPortStopBits(StopBits.One);//SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = Handshake.RequestToSend;//(_serialPort.Handshake);
            _serialPort.ReceivedBytesThreshold = 4;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceive);
        }


        private void port_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                StringBuilder currentLine = new StringBuilder();
                while(_serialPort.BytesToRead > 0)
                {
                    char ch = (char)_serialPort.ReadByte();
                    currentLine.Append(ch);
                    
                }
                Console.WriteLine(currentLine.ToString());
                currentLine = new StringBuilder();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void OpenPort()
        {
            try
            {
                _serialPort.Open();
            }catch
            {

            }

            if (_serialPort.IsOpen)
            {
                Console.WriteLine("The port is opened!");
            }
            else
            {
                Console.WriteLine("Failed to open port");
            }

        }


        public void ClosePort()
        {
            _serialPort.Close();
            if (!_serialPort.IsOpen)
            {
                Console.WriteLine("the port is already closed");
            }
        }


        public void SendCommand(string CommandString)
        {
            byte[] WriteBuffer = Encoding.ASCII.GetBytes(CommandString);

            _serialPort.Write(WriteBuffer, 0, WriteBuffer.Length);
        }



    }
}

using System;
using System.ComponentModel.Design;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;

class CommUSB
{

    //serial import
    public SerialPort serialPort;

    //store the value of transformation
    public string Code { get; set; }

    public CommUSB()
    {
        serialPort = new SerialPort();
    }

    //The state of serial
    public bool IsOpen
    {
        get
        {
            return serialPort.IsOpen;
        }
    }


    //Open the serial
    public bool Open()
    {
        if (serialPort.IsOpen)
        {
            Close();
        }
        serialPort.Open();
        if (serialPort.IsOpen)
        {
            return true;
        }
        else
        {
            Console.WriteLine("You failed to open serial!");
            return false;
        }
    }


    public void Close()
    {
        serialPort.Close();
    }


    public void WritePort(byte[] send, int offSet, int count)
    {
        if (IsOpen)
        {
            serialPort.Write(send, offSet, count);
        }
    }


    public string[] GetComName()
    {
        string[] names = null;
        try
        {
            names = SerialPort.GetPortNames();
        }
        catch (Exception)
        {
            Console.WriteLine("Can't find the serial!");
        }
        return names;
    }

    public void SerialPortValue(string portName, int baudRate)
    {
        serialPort.PortName = portName;
        serialPort.BaudRate = baudRate;
        serialPort.DataBits = 8;
        serialPort.Parity = Parity.None;
        serialPort.StopBits = StopBits.One;
        serialPort.ReadTimeout = 100;
    }





    


}
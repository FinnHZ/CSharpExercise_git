using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace USB_ConsoleApp2
{
    internal class Program
    {

        public CommUSB commUSB;
        public string codeTxt { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("read start....");

            var pr = new Program();

            while (true)
            {
                pr.RunUsbCommunicate();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Monitoring......");

            }

        }

        public void RunUsbCommunicate()
        {

            try
            {
                string comPort = "COM9";
                commUSB = new CommUSB();
                commUSB.SerialPortValue(comPort, 9600);
                if (commUSB.Open())
                {
                    commUSB.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort_DataReceived);
                }
            }catch(Exception ex)
            {
                commUSB.Close();
            }

        }


        public void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("entered");

            System.Threading.Thread.Sleep(100);
            byte[] m_recvBytes = new byte[commUSB.serialPort.BytesToRead];
            int result = commUSB.serialPort.Read(m_recvBytes, 0, m_recvBytes.Length);
            if (result <= 0)
                return;

            Console.WriteLine(result);

            //commUSB.Code = Encoding.ASCII.GetString(m_recvBytes, 0, m_recvBytes.Length);
            //codeTxt = commUSB.Code;
            //if (!string.IsNullOrEmpty(codeTxt) && codeTxt.Length >= 8)
            //{
            //    // codeTxt didn' get the data from serial
            //}




            commUSB.serialPort.DiscardInBuffer();

        }




    }
}

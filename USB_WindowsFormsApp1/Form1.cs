using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyUSB;

namespace USB_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private USBDeviceList usbDevices = null;
        private CyHidDevice myHidDevice = null;
        private const int VID = 0x0403;//0x1FBB;
        private const int PID = 0x6001; //0x3681;
        byte[] data;



        public Form1()
        {
            InitializeComponent();

            USB_Init();

        }


        private void USB_Init()
        {
            usbDevices = new USBDeviceList(CyConst.DEVICES_HID);


            usbDevices.DeviceAttached += new EventHandler(usbDevices_DeviceAttached);
            usbDevices.DeviceRemoved += new EventHandler(usbDevices_DeviceRemoved);

            Gt_Devices();
        }


        private void usbDevices_DeviceAttached(object sender, EventArgs e)
        {
            USBEventArgs usbEvent = e as USBEventArgs;
            if((usbEvent.VendorID == VID)&&(usbEvent.ProductID == PID))
            {
                //..................................
            }
        }


        private void usbDevices_DeviceRemoved(object sender, EventArgs e)
        {
            USBEventArgs usbEvent = e as USBEventArgs;
            if ((usbEvent.VendorID == VID) && (usbEvent.ProductID == PID))
            {
                //..................................
            }
        }

        private void Gt_Devices()
        {
            myHidDevice = usbDevices[VID, PID] as CyHidDevice;
        }

        public int receive_usb_data()
        {

            
            int num = 0;
            Console.WriteLine(myHidDevice == null);
            if(myHidDevice != null)
            {
                if (myHidDevice.ReadInput())
                {
                    num = myHidDevice.Inputs.RptByteLen;
                    if(num != 0x00)
                    {
                        for(int temp=0; temp < num -1; temp++)
                        {
                            data[temp] = myHidDevice.Inputs.DataBuf[temp + 1];
                        }
                    }
                }
                else
                {
                    if (myHidDevice.ReadInput())
                    {
                        num = myHidDevice.Inputs.RptByteLen;
                        if (num != 0x00)
                        {
                            for (int temp = 0; temp < num - 1; temp++)
                            {
                                data[temp] = myHidDevice.Inputs.DataBuf[temp + 1];
                            }
                        }
                    }
                }
            }
            return num;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int abc = receive_usb_data();

            Console.WriteLine(abc);



        }
    }
}

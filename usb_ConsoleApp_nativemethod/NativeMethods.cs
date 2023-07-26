using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace usb_ConsoleApp_nativemethod
{
    internal static class NativeMethods
    {
        internal const int MMSYSERR_NOERROR = 0;
        internal const int CALLBACK_FUNCTION = 0x00030000;

        internal delegate void MidiInProc(
            IntPtr hMidiIn,
            uint wMsg,
            IntPtr dwInstance,
            UInt32 dwParam1,
            UInt32 dwParam2
            );

        [DllImport("winmm.dll")]
        internal static extern int midiInGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiInClose(IntPtr hMidiIn);

        [DllImport("winmm.dll")]
        internal static extern int midiInOpen(
            out IntPtr IphMidiIn,
            int uDeviceID,
            MidiInProc dwCallback,
            IntPtr dwCallbackInstance,
            int dwFlags
            );

        [DllImport("winmm.dll")]
        internal static extern int midiInStart(IntPtr hMidiIn);

        [DllImport("winmm.dll")]
        internal static extern int miiInStop(IntPtr hMidiIn);
    }


    public class InputPort
    {
        private static NativeMethods.MidiInProc midiInProc;
        private static IntPtr handle;

        public InputPort()
        {
            midiInProc = new NativeMethods.MidiInProc(MidiProc);
            handle = IntPtr.Zero;
        }

        public static int InputCount
        {
            get { return NativeMethods.midiInGetNumDevs(); }
        }

        public bool Close()
        {
            bool result = NativeMethods.midiInClose(handle) == NativeMethods.MMSYSERR_NOERROR;
            handle = IntPtr.Zero;
            return result;
        }

        public bool Open(int id)
        {
            return NativeMethods.midiInOpen(out handle, id, midiInProc, IntPtr.Zero, NativeMethods.CALLBACK_FUNCTION) == NativeMethods.MMSYSERR_NOERROR;
        }


        public bool Start()
        {
            return NativeMethods.midiInStart(handle) == NativeMethods.MMSYSERR_NOERROR;
        }

        public bool Stop()
        {
            return NativeMethods.miiInStop(handle) == NativeMethods.MMSYSERR_NOERROR;
        }


        public IntPtr hmidi = IntPtr.Zero;
        public uint midi_wMsg = 0;
        public IntPtr midi_dwIns = IntPtr.Zero;
        public UInt32 midi_dw1 = 0;
        public UInt32 midi_dw2 = 0;



        public void MidiProc(IntPtr hMidiIn,
            uint wMsg,
            IntPtr dwInstance,
            UInt32 dwParam1,
            UInt32 dwParam2
            )
        {
            //Receive Msg here
            hmidi = hMidiIn;

            if (wMsg == 963)
            {
                dwParam1 = dwParam1 & 0xFFFF;
                uint h_dw1 = 0;
                uint I_dw1 = 0;
                h_dw1 = dwParam1 & 0xFF;
                I_dw1 = (dwParam1 >> 8) & 0xFF;


                Console.WriteLine(Convert.ToString(wMsg, 16));
                Console.WriteLine(Convert.ToString(h_dw1, 16));
                Console.WriteLine(Convert.ToString(I_dw1, 16));
                Console.WriteLine(Convert.ToString(dwParam2, 16));

                Console.WriteLine("-------------------------------------");
            }
            else
            {
                Console.WriteLine(Convert.ToString(wMsg, 16));
                Console.WriteLine(Convert.ToString(dwParam1, 16));
                Console.WriteLine(Convert.ToString(dwParam2, 16));
                Console.WriteLine("-------------------------------------");

            }

        }
    }




}

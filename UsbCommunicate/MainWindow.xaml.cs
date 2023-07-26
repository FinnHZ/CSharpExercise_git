using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CyUSB;
using System.IO.Ports;
using ProfibusSlaveGUILib;
using ProfibusSignalConfigValidatorLib;
using ProfibusSlaveDTMLib;


namespace UsbCommunicate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NativeMethods.MidiInProc midiInProc;
        private IntPtr handle;


        public MainWindow()
        {

            InitializeComponent();

        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProfibusSlaveGUI prop = new ProfibusSlaveGUILib.ProfibusSlaveGUI();
            PBSignalConfigValidator prop1 = new ProfibusSignalConfigValidatorLib.PBSignalConfigValidator();
            FirmwareDiagnosticClass prop2 = new FirmwareDiagnosticClass();
        }
    }
}

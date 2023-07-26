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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<string> equalList = new List<string>() {"0", "+"};
        public List<string> numStrList = new List<string>() {"0", "1", "2", "3","4","5","6","7","8","9"};
        public List<string> operatorList = new List<string>() { "+", "-", "*", "/" };
        public List<string> specialList = new List<string>() { ".", "="};
        public List<string> temStrList = new List<string>() {};

        public string frontStr = "";
        public string backStr = "";
        public string temStr = "";

        private void btnsClicks(object sender, RoutedEventArgs e)
        {

            Button btnCurrent = (Button)sender;
            string currentStr = btnCurrent.Content.ToString();



            //temStrList.Add(currentStr);

            //foreach (string it in temStrList)
            //{
            //    frontStr = frontStr + it;
            //}

            //tb.Text = frontStr;

            //frontStr = "";

        }
    }
}

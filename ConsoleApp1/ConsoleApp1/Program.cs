using System;
using System.IO;
using System.Text;
//using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
//using SomeNameSpace;
//using SomeNameSpace.Nested;

namespace ConsoleApp1
{

    class Program
    {
        
        static void Main(string[] args)
        {

            string testPath = "C:\\Users\\f.he\\OneDrive - AuCom Group\\Desktop\\testSecret.txt";

            string testWords = "Hello World!";

            //FileStream F = new FileStream("C:\\Users\\f.he\\OneDrive - AuCom Group\\Desktop\\testSecret.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var result_binaryString = ByteToBinary(SToByteArr(testWords, Encoding.ASCII));

            using (StreamWriter F = new StreamWriter(testPath))
            {
                F.WriteLine(result_binaryString);
            }


            string line = "";

            using (StreamReader sr = new StreamReader(testPath))
            {


                while ((line = sr.ReadLine()) != null)
                {
                    var normalResult = BinaryToStr(line.Replace(" ", ""));
                    Console.WriteLine(normalResult);
                }


            }



            Console.ReadKey();

        }



        public static byte[] SToByteArr(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static string ByteToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        public static string BinaryToStr(string str)
        {
            StringBuilder sb = new StringBuilder();

            while (str.Length > 0)
            {
                string block = str.Substring(0, 8);
                str = str.Substring(8);
                int value = 0;
                foreach (int x in block)
                {
                    int temp = x - 48;
                    value = (value << 1) | temp;
                }
                sb.Append(Convert.ToChar(value));
            }
            return sb.ToString();
        }



    }
}

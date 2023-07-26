using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AwaitTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer(1000); //实例化Timer类，设置时间间隔
            t.Elapsed += new System.Timers.ElapsedEventHandler(Method2); //到达时间的时候执行事件
            t.AutoReset = true; //设置是执行一次（false）还是一直执行(true)
            t.Enabled = true; //是否执行System.Timers.Timer.Elapsed事件
 
        }

        public void Method2(object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString() + "_" + Thread.CurrentThread.ManagedThreadId.ToString());
        }






    }
}

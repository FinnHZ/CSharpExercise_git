using System;
using System.Threading;

namespace MultithreadingApplication
{
    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            // 线程暂停 5000 毫秒
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds",
                              sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        public static void CallToChildThreadsssssss()
        {
            Console.WriteLine("2222222222222222222");
       
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            //CallToChildThread();

            ThreadStart childref2 = new ThreadStart(CallToChildThreadsssssss);
            Console.WriteLine("In Main: 22222222222");
            Thread childThread2 = new Thread(childref2);
            childThread2.Start();

            Console.ReadKey();
        }
    }
}
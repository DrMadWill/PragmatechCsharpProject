using System;
using System.Diagnostics;
using System.Threading;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Race condition 
            //for (int i = 0; i < 10; i++)
            //    new Thread(() => Console.WriteLine(i)).Start();


            ////  Race condition solve
            //for (int i = 0; i < 10; i++)
            //{
            //    int hu = i;
            //    new Thread(() => Console.WriteLine(hu)).Start();
            //}
            #endregion


            #region Abort Problem

            //Thread thread = new Thread(() => Console.WriteLine("Will"));
            //thread.Start();

            //if (6 > 5)
            //{
            //    thread.Abort();
            //}

            //Thread thread1 = new Thread(() => Console.WriteLine("Add"));
            //thread1.Start();

            #endregion

            // Join()
            //Thread thread = new Thread(MethodJoin);
            //thread.Start();
            //thread.Join();
            //Console.WriteLine("I Wait For You,Bro");


            // Thread Priority 
            Thread thread = new Thread(Heights);
            thread.Priority = ThreadPriority.Highest;
            thread.Start();

            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void Heights()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("||  Mad  | ");
            }
        }

        public static void MethodJoin()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Threading;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Process process = new Process();
            //process.StartInfo.FileName = "calc.exe";
            //process.StartInfo.Arguments = "";
            //process.Start();


            //Process.Start("https://www.google.com/");
            //Process.Start("https://www.youtube.com/watch?v=PsyLA-SYIUM&list=RDMM&index=3");

            //* NowRunFile
            //var proces = Process.GetCurrentProcess();
            //Console.WriteLine(proces);

            // Task Meneger
            //var proces = Process.GetProcesses();
            //foreach (var item in proces)
            //{
            //    Console.WriteLine(item.ProcessName);
            //}



            //Thread thread = new Thread(WriteWill);
            //thread.Start();
            //WriteMad();


            Thread thread = new Thread(WriteDr);
            thread.IsBackground = true;
            thread.Start();
            WriteMad();
        }


        public static void WriteWill()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("will");
            }
        }

        public static void WriteMad()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Mad");
            }
        }

        public static void WriteDr()
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine("will");
            }
        }
    }
}

using System;
using System.Threading;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ThreadPool.QueueUserWorkItem(WriteMad);
            Console.WriteLine("Hello I'am Jenis");
            Console.WriteLine("Class introduct Ended");

            
        }

        static void WriteMad(object state)
        {
            Console.WriteLine("Inot ended and I live. Mad Firend is So Mad");
        }
    }
}
